namespace SammelLastschriftGenerator
{
    public class Mitglied
    {
        public string Id { get; set; }
        public string Mandant { get; set; }
        public decimal Jahresbeitrag { get; set; }
        public string Lastschrifterteilungsdatum { get; set; }
        public decimal Beitragszahlung { get; set; }
        public string IBAN { get; set; }
        public long IBANValid { get; set; }
        public string DatumIBANCheck { get; set; }
        public bool BankAccountOk { get; set; }
        public int Transaktionen { get; set; }
    }
}
