using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Net;
using System.Text;
using System.Text.Json;

namespace SammelLastschriftGenerator
{
    public static class Model
    {
        private static SQLiteConnection con = null;
        private static WebClient webClient = new WebClient();

        public static string Beitragsjahr { get; private set; }
        public static int AnzahlMandanten { get; private set; }
        public static decimal Beitragssumme { get; private set; }

        internal static Dictionary<string, string> SaveKey = new Dictionary<string, string>();

        static Model()
        {
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
        }

        public static void OpenDatabase(string dbName)
        {
            con = new SQLiteConnection($"URI=file:{dbName}");
            con.Open();
        }

        public static void Close()
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
            }
        }

        public static string CreateMitgliederListe()
        {
            string stm = "SELECT MitgliedId, Anrede, Vorname, Nachname FROM Mitglieder";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            string mitglieder = string.Empty;
            while (rdr.Read())
            {
                mitglieder += $"{rdr.GetString(0)} {rdr.GetString(1)} {rdr.GetString(2)} {rdr.GetString(3)} {Environment.NewLine}";
            }

            cmd.Dispose();

            return mitglieder;
        }

        public static List<string> CreateMitgliederListeEx()
        {
            string stm = "SELECT MitgliedId FROM Mitglieder";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            List<string> ml = new List<string>();

            while (rdr.Read())
            {
                ml.Add(rdr.GetString(0));
            }

            cmd.Dispose();

            return ml;
        }

        public static Mitglied GetMitglied(string id)
        {
            string stm = "SELECT MitgliedId, Anrede, Vorname, Nachname, IBAN FROM Mitglieder WHERE MitgliedId = @id";
            Mitglied m = new Mitglied();

            using (var cmd = new SQLiteCommand(stm, con))
            {
                //cmd.Parameters.Add(new SQLiteParameter("id", id));

                cmd.AddParameter("id", id);

                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    rdr.Read();
                    m.Id = rdr.GetString(0);
                    m.Mandant = $"{rdr.GetString(1)} {rdr.GetString(2)} {rdr.GetString(3)}";
                    bool iban = rdr.IsDBNull(4);
                    if (!iban) m.IBAN = rdr.GetString(4);
                }
            }

            return m;
        }

        public static int UpdateMitglied(string id, DateTime ibanCheckDate, bool valid, string bic, string bank)
        {
            string stm = "UPDATE Mitglieder SET 'DatumIBANCheck' = @ibanCheck, 'IBANValid' = @ibanValid, BIC = @bic, 'BankName' = @bankname WHERE MitgliedId = @id";
            int result = 0;

            using (var cmd = new SQLiteCommand(stm, con))
            {
                cmd.Parameters.Add(new SQLiteParameter("ibanCheck", ibanCheckDate.ToString("dd.MM.yyyy HH:mm")));
                if (!valid)
                {
                    int x = 0;
                }
                cmd.Parameters.Add(new SQLiteParameter("ibanValid", valid ? 1 : 0));
                cmd.Parameters.Add(new SQLiteParameter("bic", bic));
                cmd.Parameters.Add(new SQLiteParameter("bankname", bank));
                cmd.Parameters.Add(new SQLiteParameter("id", id));

                result = cmd.ExecuteNonQuery();
            }

            return result;
        }

        public static List<Mitglied> GetMitglieder()
        {
            string stm = "SELECT MitgliedId, Anrede, Vorname, Nachname, IBAN, IBANValid, DatumIBANCheck, Jahresbeitrag, Lastschrifterteilungsdatum FROM Mitglieder";
            List<Mitglied> ml = new List<Mitglied>();

            using (var cmd = new SQLiteCommand(stm, con))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Mitglied m = new Mitglied();
                        m.Id = rdr.GetString(0);
                        m.Mandant = $"{rdr.GetString(1)} {rdr.GetString(2)} {rdr.GetString(3)}";
                        bool iban = rdr.IsDBNull(4);
                        if (!iban) m.IBAN = rdr.GetString(4);
                        bool ibanOk = rdr.IsDBNull(5);
                        if (!ibanOk) m.IBANValid = rdr.GetInt64(5);
                        bool datIbanCheck = rdr.IsDBNull(6);
                        if (!datIbanCheck) m.DatumIBANCheck = rdr.GetString(6);
                        m.Jahresbeitrag = rdr.GetDecimal(7);
                        m.Lastschrifterteilungsdatum = rdr.IsDBNull(8) ? "" : rdr.GetString(8);
                        
                        ml.Add(m);
                    }
                }
            }

            return ml;
        }

        public static List<string> GetYears()
        {
            string stm = "SELECT Jahr FROM Transaktionsjahr";
            List<string> years = new List<string>();

            using (var cmd = new SQLiteCommand(stm, con))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int year = rdr.GetInt32(0);
                        string theYear = year.ToString();
                        years.Add(theYear);
                    }
                }
            }

            return years;
        }

        public static List<string> GetTransactionMethod()
        {
            string stm = "SELECT Method FROM Transaktionsart";
            List<string> transart = new List<string>();

            using (var cmd = new SQLiteCommand(stm, con))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        string art = rdr.GetString(0);
                        transart.Add(art);
                    }
                }
            }

            return transart;
        }

        public static string CreateSammelLastSchrift(string template, string beitragsjahr)
        {
            string stm = "SELECT MitgliedId, Anrede, Vorname, Nachname, Jahresbeitrag, Lastschrifterteilungsdatum, IBAN, IBANValid FROM Mitglieder ORDER BY MitgliedId";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            string mandant = string.Empty;
            StringBuilder sb = new StringBuilder();

            int mid = rdr.GetOrdinal("MitgliedId");
            int anr = rdr.GetOrdinal("Anrede");
            int vnm = rdr.GetOrdinal("Vorname");
            int nam = rdr.GetOrdinal("Nachname");
            int btr = rdr.GetOrdinal("Jahresbeitrag");
            int lsd = rdr.GetOrdinal("Lastschrifterteilungsdatum");
            int ibn = rdr.GetOrdinal("IBAN");
            int ibv = rdr.GetOrdinal("IBANValid");

            int mandantenCount = 0;
            AnzahlMandanten = 0;
            Beitragssumme = 0;
            Beitragsjahr = beitragsjahr;

            while (rdr.Read())
            {
                bool ibanValid = false;
                float jahresbeitrag = rdr.GetFloat(btr);
                bool iban = rdr.IsDBNull(ibn);
                bool lastschrifterteilungsdatum = rdr.IsDBNull(lsd);
                if (!rdr.IsDBNull(ibv))
                {
                    var valid = rdr.GetInt64(ibv);
                    ibanValid = valid > 0 ? true : false;
                }

                // check
                if (lastschrifterteilungsdatum ||
                    iban ||
                    jahresbeitrag <= 0.0 ||
                    !ibanValid)
                {
                    continue;
                }

                mandant = template;
                mandant = mandant.Replace("{{Mitglied-ID}}", rdr.GetString(mid));
                mandant = mandant.Replace("{{Anrede}}", rdr.GetString(anr));
                mandant = mandant.Replace("{{Vorname}}", rdr.GetString(vnm));
                mandant = mandant.Replace("{{Nachname}}", rdr.GetString(nam));
                mandant = mandant.Replace("{{Jahresbeitrag-Betrag}}", rdr.GetFloat(btr).ToString("0.00", CultureInfo.InvariantCulture));
                DateTime datum = DateTime.Parse(rdr.GetString(lsd));
                string datumUsa = datum.ToString("yyyy-MM-dd");
                mandant = mandant.Replace("{{Datum-Lastschrifteinzug-Ermächtigung}}", datumUsa);
                mandant = mandant.Replace("{{Mitglied-IBAN}}", rdr.GetString(ibn).Replace(" ", ""));
                mandant = mandant.Replace("{{Jahresbeitrag-Jahr}}", beitragsjahr);
                sb.Append(mandant);
                sb.Append(Environment.NewLine);
                mandantenCount++;
                Beitragssumme = Beitragssumme + (decimal)rdr.GetFloat(btr);
            }

            cmd.Dispose();

            AnzahlMandanten = mandantenCount;

            return sb.ToString();
        }

        public static OpenIban CallGetWebClient(string iban)
        {
            string escIban = Uri.EscapeUriString(iban.Replace(" ", ""));
            string apiUrl = string.Format("https://openiban.com/validate/{0}?getBIC=true&validateBankCode=true", escIban);

            var json = webClient.DownloadString(apiUrl);

            OpenIban response = JsonSerializer.Deserialize<OpenIban>(json);

            return response;
        }

        internal static void CreateTransaction(string transactYear, string memberId, string transactionDate, string reason, string transactionType, string amount)
        {
            string stm = "INSERT INTO Transaktionen (Jahr,MitgliedId,Transaktionsdatum,Zweck,Transaktionsart,Betrag) VALUES(@jahr,@memberId,@transDate,@reason,@transKind,@amount)";
            var cmd = new SQLiteCommand(stm, con);
            int result = 0;

            cmd.Parameters.Add(new SQLiteParameter("jahr", transactYear));
            cmd.Parameters.Add(new SQLiteParameter("memberId", memberId));
            cmd.Parameters.Add(new SQLiteParameter("transDate", transactionDate));
            cmd.Parameters.Add(new SQLiteParameter("reason", reason));
            cmd.Parameters.Add(new SQLiteParameter("transKind", transactionType));
            cmd.Parameters.Add(new SQLiteParameter("amount", amount));

            result = cmd.ExecuteNonQuery();
        }

        internal static List<Transaktion> GetTransactions(string transactYear, string memberId)
        {
            string stm = "SELECT Id,Jahr,MitgliedId,Transaktionsdatum,Zweck,Transaktionsart,Betrag FROM Transaktionen WHERE Jahr = @transactYear AND MitgliedId = @memberId";

            var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.Add(new SQLiteParameter("transactYear", transactYear));
            cmd.Parameters.Add(new SQLiteParameter("memberId", memberId));

            List<Transaktion> tlist = new List<Transaktion>();
            
            SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Transaktion trans = new Transaktion();
                trans.Id = rdr.GetInt32(0);
                trans.Transaktionsdatum = rdr.GetString(3);
                trans.Zweck = rdr.GetString(4);
                trans.Transaktionsart = rdr.GetString(5);                
                trans.Betrag = decimal.Parse(rdr.GetString(6));

                //decimal paymentSum = GetPaymentSum(transactYear, memberId);

                tlist.Add(trans);
            }

            return tlist;
        }

        internal static decimal GetPaymentSum(string transactYear, string memberId)
        {
            string stm = "SELECT Jahr,MitgliedId,Betrag FROM Transaktionen WHERE Jahr = @transactYear AND MitgliedId = @memberId";

            var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.Add(new SQLiteParameter("transactYear", transactYear));
            cmd.Parameters.Add(new SQLiteParameter("memberId", memberId));

            List<Transaktion> tlist = new List<Transaktion>();

            SQLiteDataReader rdr = cmd.ExecuteReader();

            decimal payment = 0;

            while (rdr.Read())
            {
                payment += decimal.Parse(rdr.GetString(2));                
            }

            return payment;
        }        

        public class BankData
        {
            public string bankCode { get; set; }
            public string name { get; set; }
            public string zip { get; set; }
            public string city { get; set; }
            public string bic { get; set; }
        }

        public class CheckResults
        {
            public bool bankCode { get; set; }
        }

        public class OpenIban
        {
            public bool valid { get; set; }
            public IList<string> messages { get; set; }
            public string iban { get; set; }
            public BankData bankData { get; set; }
            public CheckResults checkResults { get; set; }
        }

    }

}
