using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace SammelLastschriftGenerator
{
    public partial class FormMain : Form
    {
        SQLiteConnection con = null;
        List<string> ml = null;
        HashSet<string> accCheck = new HashSet<string>();

        public FormMain()
        {
            InitializeComponent();            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Model.Close();
        }

        private void sammellastschriftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SammelllastschriftDialog sld = new SammelllastschriftDialog();

            DialogResult dr = sld.ShowDialog();
            if (dr.Equals(DialogResult.Cancel)) return;

            string year = sld.numericUpDownYear.Value.ToString();
            
            textBoxSammelLastschrift.Text = string.Empty;

            string mandanten = Model.CreateSammelLastSchrift(textBoxMandantTemplate.Text, year);

            SammelllastschriftErgebnisDialog sled = new SammelllastschriftErgebnisDialog();
            sled.textBoxJahr.Text = Model.Beitragsjahr;
            string mandantenCount = Model.AnzahlMandanten.ToString();
            sled.textBoxAnzahlMandanten.Text = mandantenCount;
            string beitragssumme = Model.Beitragssumme.ToString("0,0.00", CultureInfo.InvariantCulture);
            sled.textBoxBeitragssumme.Text = beitragssumme;

            string sammellastschrift = textBoxMainTemplate.Text.Replace("{{Mandanten}}", mandanten);
            sammellastschrift = sammellastschrift.Replace("{{Mandanten-Anzahl}}", mandantenCount);
            sammellastschrift = sammellastschrift.Replace("{{Mandanten-Lastschrift-Summe}}", beitragssumme);

            textBoxSammelLastschrift.Text = Program.PrettyXml(sammellastschrift);


            sled.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }        

        private void GeneriereMitgliederListe()
        {
            listViewMitglieder.Items.Clear();

            List<Mitglied> ml = Model.GetMitglieder();

            foreach (Mitglied m in ml)
            {
                listViewMitglieder.Items.Add(CreateListViewItemMitgliederListe(m));
            }


            toolStripButtonValidateIBAN.Enabled = true;
        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialogDb.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                string dbName = openFileDialogDb.FileName;
                Model.OpenDatabase(dbName);

                toolStripStatusLabelDatabase.Text = dbName;
                toolStripButtonGenerateMemberList.Enabled = true;

                LadeBeitragsJahre();

                toolStripButtonGenerateBeitragsListe.Enabled = true;

                sammellastschriftToolStripMenuItem.Enabled = true;

                listViewMitglieder.Items.Clear();
                listViewMitgliedsbeitrag.Items.Clear();
                accCheck.Clear();
            }
        }

        private void openMainTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialogMainTemplate.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                string mainTemplateName = openFileDialogMainTemplate.FileName;
                string text = File.ReadAllText(mainTemplateName);
                string text2 = Program.FormatXml(text);
                textBoxMainTemplate.Text = text2;
            }
        }        

        private void openMandantTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialogMandantTemplate.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                string mandantTemplateName = openFileDialogMandantTemplate.FileName;
                string text = File.ReadAllText(mandantTemplateName);
                string text2 = Program.FormatXml(text);
                textBoxMandantTemplate.Text = text2;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            listViewMitglieder.SetDoubleBuffered(true);
            listViewMitgliedsbeitrag.SetDoubleBuffered(true);
            listViewBeitragTransaktion.SetDoubleBuffered(true);

            toolStripButtonValidateIBAN.Enabled = false;
            toolStripButtonGenerateMemberList.Enabled = false;
            toolStripButtonGenerateBeitragsListe.Enabled = false;
            toolStripComboBoxYear.Enabled = false;

            sammellastschriftToolStripMenuItem.Enabled = false;
        }

        private ListViewItem CreateListViewItemMitgliederListe(Mitglied m)
        {
            ListViewItem lvi = new ListViewItem();
            
            lvi.Text = m.Id;

            ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
            lvsi1.Text = m.Mandant;
            lvi.SubItems.Add(lvsi1);

            ListViewItem.ListViewSubItem lvsi2 = new ListViewItem.ListViewSubItem();
            lvsi2.Text = m.IBAN;
            lvi.SubItems.Add(lvsi2);

            ListViewItem.ListViewSubItem lvsi3 = new ListViewItem.ListViewSubItem();
            lvsi3.Text = m.DatumIBANCheck;
            lvi.SubItems.Add(lvsi3);

            ListViewItem.ListViewSubItem lvsi4 = new ListViewItem.ListViewSubItem();
            lvsi4.Text = m.Lastschrifterteilungsdatum;
            lvi.SubItems.Add(lvsi4);

            if (!string.IsNullOrEmpty(m.IBAN))
            {
                if (m.IBANValid > 0)
                {
                    lvi.SubItems[2].ForeColor = Color.DarkCyan;
                    lvi.ImageKey = "cyan_ball";
                }
                else
                {
                    lvi.SubItems[2].ForeColor = Color.Red;
                    lvi.ImageKey = "red_ball";
                }
            }
                        
            lvi.UseItemStyleForSubItems = false;

            return lvi;
        }

        private ListViewItem CreateListViewItemMitgliedsbeitragsListe(Mitglied m)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = m.Id;

            ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
            lvsi1.Text = m.Mandant;
            lvi.SubItems.Add(lvsi1);

            ListViewItem.ListViewSubItem lvsi2 = new ListViewItem.ListViewSubItem();
            lvsi2.Text = string.Format("{0:N2} €", m.Jahresbeitrag);
            lvi.SubItems.Add(lvsi2);

            ListViewItem.ListViewSubItem lvsi3 = new ListViewItem.ListViewSubItem();
            lvsi3.Text = string.Format("{0:N2} €", m.Beitragszahlung);
            lvi.SubItems.Add(lvsi3);

            ListViewItem.ListViewSubItem lvsi4 = new ListViewItem.ListViewSubItem();
            lvsi4.Text = m.Lastschrifterteilungsdatum;
            lvi.SubItems.Add(lvsi4);

            ListViewItem.ListViewSubItem lvsi5 = new ListViewItem.ListViewSubItem();
            lvsi5.Text = m.Transaktionen.ToString();
            lvi.SubItems.Add(lvsi5);

            lvi.ImageKey = "blue_ball";

            if (m.Beitragszahlung > 0)
            {
                if (m.Beitragszahlung == m.Jahresbeitrag)
                {
                    lvi.ImageKey = "green_ball";
                }
                else if (m.Beitragszahlung < m.Jahresbeitrag)
                {
                    lvi.ImageKey = "yellow_ball";
                }
            }
            else if (m.Beitragszahlung == 0 && m.Jahresbeitrag > 0)
            {
                lvi.ImageKey = "red_ball";
            }

            return lvi;
        }

        private void checkIBANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidateIBAN();
        }

        private void ValidateIBAN()
        {
            int index = 0;
            int valids = 0;
            int invalids = 0;
            int noiban = 0;

            Cursor.Current = Cursors.WaitCursor;

            foreach (ListViewItem lvi in listViewMitglieder.Items)
            {
                string id = lvi.Text;

                Mitglied mtg = Model.GetMitglied(id);

                if (!string.IsNullOrEmpty(mtg.IBAN))
                {
                    Model.OpenIban response = Model.CallGetWebClient(mtg.IBAN);

                    DateTime checkDate = DateTime.Now;

                    int result = Model.UpdateMitglied(id, checkDate, response.valid, response.bankData.bic, response.bankData.name);

                    if (response.valid && result.Equals(1))
                    {
                        lvi.SubItems[2].ForeColor = Color.DarkCyan;
                        lvi.SubItems[3].Text = checkDate.ToString("dd.MM.yyyy HH:mm");
                        lvi.ImageKey = "cyan_ball";
                        valids++;
                    }
                    else
                    {
                        lvi.SubItems[2].ForeColor = Color.Red;
                        lvi.SubItems[3].Text = checkDate.ToString("dd.MM.yyyy HH:mm");
                        lvi.ImageKey = "red_ball";
                        invalids++;
                    }
                    listViewMitglieder.EnsureVisible(index);
                }
                else
                {
                    lvi.ImageKey = "white_ball";
                    noiban++;
                }

                listViewMitglieder.RedrawItems(index, index, false);

                index++;
            }

            Cursor.Current = Cursors.Default;

            string msg = string.Format("{0} Mitglieder haben eine gültige IBAN\r\n{1} Mitglieder haben eine ungültige IBAN\r\n{2} Mitglieder haben keine IBAN", valids, invalids, noiban);
            MessageBox.Show(this, msg, "IBAN Check", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (index > 0)
            {
                listViewMitglieder.EnsureVisible(0);
            }
        }

        private void createPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewMitglieder.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listViewMitglieder.SelectedItems[0];

                BankTransactionDialog apd = new BankTransactionDialog();
                apd.textBoxId.Text = lvi.Text;
                apd.textBoxName.Text = lvi.SubItems[1].Text;
                apd.textBoxIBAN.Text = lvi.SubItems[2].Text;

                List<string> years = Model.GetYears();
                apd.comboBoxYear.Items.AddRange(years.ToArray());
                string year = ObtainSaveKey("Year");
                int yearInx = apd.comboBoxYear.FindString(year);
                if (years.Count > 0) apd.comboBoxYear.SelectedIndex = 0;
                if (yearInx > -1) apd.comboBoxYear.SelectedIndex = yearInx;

                List<string> methods = Model.GetTransactionMethod();
                apd.comboBoxTransaction.Items.AddRange(methods.ToArray());
                string paymnt = ObtainSaveKey("TransactionMethod");
                int payInx = apd.comboBoxTransaction.FindString(paymnt);
                if (methods.Count > 0) apd.comboBoxTransaction.SelectedIndex = 0;
                if (payInx > -1) apd.comboBoxTransaction.SelectedIndex = payInx;

                string transactDate = ObtainSaveKey("TransactionDate");
                if (!string.IsNullOrEmpty(transactDate))
                {
                    apd.dateTimePickerTransactionDate.Text = transactDate;
                }

                string trnsactrsn = ObtainSaveKey("TransactionReason");
                if (!string.IsNullOrEmpty(trnsactrsn))
                {
                    apd.textBoxTransactionReason.Text = trnsactrsn;
                }

                string amount = ObtainSaveKey("TransactionAmount");
                if (!string.IsNullOrEmpty(amount))
                {
                    apd.textBoxAmount.Text = amount;
                }

                DialogResult dr = apd.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    string yearSelectedSaveKey = apd.comboBoxYear.SelectedItem as string;
                    string transactionMethod = apd.comboBoxTransaction.SelectedItem.ToString();
                    string transactionReason = apd.textBoxTransactionReason.Text;
                    string transactAmount = apd.textBoxAmount.Text;
                    string transactionDate = apd.dateTimePickerTransactionDate.Value.ToShortDateString();
                    StoreSaveKey("Year", yearSelectedSaveKey);
                    StoreSaveKey("TransactionMethod", transactionMethod);
                    StoreSaveKey("TransactionReason", transactionReason);
                    StoreSaveKey("TransactionDate", transactionDate);
                    StoreSaveKey("TransactionAmount", transactAmount);
                    Model.CreateTransaction(yearSelectedSaveKey, apd.textBoxId.Text, transactionDate, transactionReason, transactionMethod, transactAmount);
                }
            }
        }

        private static void StoreSaveKey(string keyName, string keyValue)
        {
            if (Model.SaveKey.ContainsKey(keyName))
            {
                Model.SaveKey[keyName] = keyValue;
            }
            else
            {
                Model.SaveKey.Add(keyName, keyValue);
            }
        }

        private static string ObtainSaveKey(string keyName)
        {
            if (Model.SaveKey.ContainsKey(keyName))
            {
                return Model.SaveKey[keyName];
            }

            return null;           
        }

        private void contextMenuStripListView_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listViewMitglieder.Items.Count.Equals(0))
            {
                e.Cancel = true;
            }
        }        

        private void LadeBeitragsJahre()
        {
            List<string> years = Model.GetYears();
            toolStripComboBoxYear.Items.Clear();
            toolStripComboBoxYear.Items.AddRange(years.ToArray());
            string year = ObtainSaveKey("Year");
            int yearInx = toolStripComboBoxYear.FindString(year);
            if (years.Count > 0) toolStripComboBoxYear.SelectedIndex = 0;
            if (yearInx > -1) toolStripComboBoxYear.SelectedIndex = yearInx;

            toolStripComboBoxYear.Enabled = true;
        }

        private void GeneriereMitgliedsBeitragsListe(string beitragsJahr)
        {
            listViewMitgliedsbeitrag.Items.Clear();
            listViewBeitragTransaktion.Items.Clear();

            List<Mitglied> ml = Model.GetMitglieder();

            foreach (Mitglied m in ml)
            {
                decimal paymentSum = 0; // Model.GetPaymentSum(beitragsJahr, m.Id);
                List<Transaktion> tl = Model.GetTransactions(beitragsJahr, m.Id);
                tl.ForEach((t) => { paymentSum += t.Betrag; });
                m.Beitragszahlung = paymentSum;
                m.Transaktionen = tl.Count;
                listViewMitgliedsbeitrag.Items.Add(CreateListViewItemMitgliedsbeitragsListe(m));
            }
        }

        private ListViewItem CreateListViewItemMitgliedsbeitragTransaktionsListe(Transaktion t)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = t.Transaktionsdatum;

            ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
            lvsi1.Text = t.Transaktionsart;
            lvi.SubItems.Add(lvsi1);

            ListViewItem.ListViewSubItem lvsi2 = new ListViewItem.ListViewSubItem();
            lvsi2.Text = string.Format("{0:N2} €", t.Betrag);
            lvi.SubItems.Add(lvsi2);

            ListViewItem.ListViewSubItem lvsi3 = new ListViewItem.ListViewSubItem();
            lvsi3.Text = t.Zweck;
            lvi.SubItems.Add(lvsi3);

            lvi.UseItemStyleForSubItems = false;

            return lvi;
        }

        private void listViewMitgliedsbeitrag_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string year = toolStripComboBoxYear.Text;

                listViewBeitragTransaktion.Items.Clear();

                List<Transaktion> tl = Model.GetTransactions(year, e.Item.Text);

                foreach (Transaktion t in tl)
                {
                    ListViewItem lvi = CreateListViewItemMitgliedsbeitragTransaktionsListe(t);
                    listViewBeitragTransaktion.Items.Add(lvi);
                }                
            }
        }

        private void toolStripButtonGenerate_Click(object sender, EventArgs e)
        {
            GeneriereMitgliedsBeitragsListe(toolStripComboBoxYear.Text);
        }

        private void toolStripButtonValidateIBAN_Click(object sender, EventArgs e)
        {
            ValidateIBAN();
        }

        private void toolStripButtonGenerateMemberList_Click(object sender, EventArgs e)
        {
            GeneriereMitgliederListe();
        }
    }
}
