namespace SammelLastschriftGenerator
{
    partial class BankTransactionDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelMitgliedId = new System.Windows.Forms.Label();
            this.groupBoxMitgliedData = new System.Windows.Forms.GroupBox();
            this.textBoxIBAN = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelIBAN = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxTransactionData = new System.Windows.Forms.GroupBox();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.comboBoxTransaction = new System.Windows.Forms.ComboBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxTransactionReason = new System.Windows.Forms.TextBox();
            this.dateTimePickerTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.labelTransactionAmount = new System.Windows.Forms.Label();
            this.labelTRansaction = new System.Windows.Forms.Label();
            this.labelTRansactionReason = new System.Windows.Forms.Label();
            this.labelTransactionDate = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.groupBoxMitgliedData.SuspendLayout();
            this.groupBoxTransactionData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(25, 404);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(386, 29);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(417, 404);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(243, 29);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // labelMitgliedId
            // 
            this.labelMitgliedId.AutoSize = true;
            this.labelMitgliedId.Location = new System.Drawing.Point(30, 40);
            this.labelMitgliedId.Name = "labelMitgliedId";
            this.labelMitgliedId.Size = new System.Drawing.Size(19, 13);
            this.labelMitgliedId.TabIndex = 2;
            this.labelMitgliedId.Text = "Id:";
            // 
            // groupBoxMitgliedData
            // 
            this.groupBoxMitgliedData.Controls.Add(this.textBoxIBAN);
            this.groupBoxMitgliedData.Controls.Add(this.textBoxName);
            this.groupBoxMitgliedData.Controls.Add(this.textBoxId);
            this.groupBoxMitgliedData.Controls.Add(this.labelIBAN);
            this.groupBoxMitgliedData.Controls.Add(this.labelName);
            this.groupBoxMitgliedData.Controls.Add(this.labelMitgliedId);
            this.groupBoxMitgliedData.Location = new System.Drawing.Point(25, 12);
            this.groupBoxMitgliedData.Name = "groupBoxMitgliedData";
            this.groupBoxMitgliedData.Size = new System.Drawing.Size(635, 142);
            this.groupBoxMitgliedData.TabIndex = 3;
            this.groupBoxMitgliedData.TabStop = false;
            this.groupBoxMitgliedData.Text = "Mitglied Daten";
            // 
            // textBoxIBAN
            // 
            this.textBoxIBAN.Location = new System.Drawing.Point(120, 107);
            this.textBoxIBAN.Name = "textBoxIBAN";
            this.textBoxIBAN.ReadOnly = true;
            this.textBoxIBAN.Size = new System.Drawing.Size(173, 20);
            this.textBoxIBAN.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(403, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(120, 37);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // labelIBAN
            // 
            this.labelIBAN.AutoSize = true;
            this.labelIBAN.Location = new System.Drawing.Point(30, 110);
            this.labelIBAN.Name = "labelIBAN";
            this.labelIBAN.Size = new System.Drawing.Size(35, 13);
            this.labelIBAN.TabIndex = 4;
            this.labelIBAN.Text = "IBAN:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 72);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // groupBoxTransactionData
            // 
            this.groupBoxTransactionData.Controls.Add(this.labelCurrency);
            this.groupBoxTransactionData.Controls.Add(this.comboBoxTransaction);
            this.groupBoxTransactionData.Controls.Add(this.textBoxAmount);
            this.groupBoxTransactionData.Controls.Add(this.textBoxTransactionReason);
            this.groupBoxTransactionData.Controls.Add(this.dateTimePickerTransactionDate);
            this.groupBoxTransactionData.Controls.Add(this.comboBoxYear);
            this.groupBoxTransactionData.Controls.Add(this.labelTransactionAmount);
            this.groupBoxTransactionData.Controls.Add(this.labelTRansaction);
            this.groupBoxTransactionData.Controls.Add(this.labelTRansactionReason);
            this.groupBoxTransactionData.Controls.Add(this.labelTransactionDate);
            this.groupBoxTransactionData.Controls.Add(this.labelYear);
            this.groupBoxTransactionData.Location = new System.Drawing.Point(25, 173);
            this.groupBoxTransactionData.Name = "groupBoxTransactionData";
            this.groupBoxTransactionData.Size = new System.Drawing.Size(635, 209);
            this.groupBoxTransactionData.TabIndex = 4;
            this.groupBoxTransactionData.TabStop = false;
            this.groupBoxTransactionData.Text = "Transaktions Daten";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(339, 155);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(13, 13);
            this.labelCurrency.TabIndex = 10;
            this.labelCurrency.Text = "€";
            // 
            // comboBoxTransaction
            // 
            this.comboBoxTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransaction.FormattingEnabled = true;
            this.comboBoxTransaction.Location = new System.Drawing.Point(204, 118);
            this.comboBoxTransaction.Name = "comboBoxTransaction";
            this.comboBoxTransaction.Size = new System.Drawing.Size(119, 21);
            this.comboBoxTransaction.TabIndex = 9;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(204, 152);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(119, 20);
            this.textBoxAmount.TabIndex = 8;
            // 
            // textBoxTransactionReason
            // 
            this.textBoxTransactionReason.Location = new System.Drawing.Point(204, 88);
            this.textBoxTransactionReason.Name = "textBoxTransactionReason";
            this.textBoxTransactionReason.Size = new System.Drawing.Size(413, 20);
            this.textBoxTransactionReason.TabIndex = 7;
            // 
            // dateTimePickerTransactionDate
            // 
            this.dateTimePickerTransactionDate.Location = new System.Drawing.Point(204, 57);
            this.dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            this.dateTimePickerTransactionDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTransactionDate.TabIndex = 6;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(204, 25);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(89, 21);
            this.comboBoxYear.TabIndex = 5;
            // 
            // labelTransactionAmount
            // 
            this.labelTransactionAmount.AutoSize = true;
            this.labelTransactionAmount.Location = new System.Drawing.Point(30, 155);
            this.labelTransactionAmount.Name = "labelTransactionAmount";
            this.labelTransactionAmount.Size = new System.Drawing.Size(41, 13);
            this.labelTransactionAmount.TabIndex = 4;
            this.labelTransactionAmount.Text = "Betrag:";
            // 
            // labelTRansaction
            // 
            this.labelTRansaction.AutoSize = true;
            this.labelTRansaction.Location = new System.Drawing.Point(30, 121);
            this.labelTRansaction.Name = "labelTRansaction";
            this.labelTRansaction.Size = new System.Drawing.Size(66, 13);
            this.labelTRansaction.TabIndex = 3;
            this.labelTRansaction.Text = "Transaktion:";
            // 
            // labelTRansactionReason
            // 
            this.labelTRansactionReason.AutoSize = true;
            this.labelTRansactionReason.Location = new System.Drawing.Point(30, 88);
            this.labelTRansactionReason.Name = "labelTRansactionReason";
            this.labelTRansactionReason.Size = new System.Drawing.Size(43, 13);
            this.labelTRansactionReason.TabIndex = 2;
            this.labelTRansactionReason.Text = "Zweck:";
            // 
            // labelTransactionDate
            // 
            this.labelTransactionDate.AutoSize = true;
            this.labelTransactionDate.Location = new System.Drawing.Point(30, 57);
            this.labelTransactionDate.Name = "labelTransactionDate";
            this.labelTransactionDate.Size = new System.Drawing.Size(41, 13);
            this.labelTransactionDate.TabIndex = 1;
            this.labelTransactionDate.Text = "Datum:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(30, 28);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(30, 13);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "Jahr:";
            // 
            // BankTransactionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 445);
            this.Controls.Add(this.groupBoxTransactionData);
            this.Controls.Add(this.groupBoxMitgliedData);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankTransactionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank Transaction";
            this.groupBoxMitgliedData.ResumeLayout(false);
            this.groupBoxMitgliedData.PerformLayout();
            this.groupBoxTransactionData.ResumeLayout(false);
            this.groupBoxTransactionData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelMitgliedId;
        private System.Windows.Forms.GroupBox groupBoxMitgliedData;
        private System.Windows.Forms.Label labelIBAN;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxTransactionData;
        internal System.Windows.Forms.TextBox textBoxIBAN;
        internal System.Windows.Forms.TextBox textBoxName;
        internal System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelTransactionAmount;
        private System.Windows.Forms.Label labelTRansaction;
        private System.Windows.Forms.Label labelTRansactionReason;
        private System.Windows.Forms.Label labelTransactionDate;
        private System.Windows.Forms.Label labelYear;
        internal System.Windows.Forms.ComboBox comboBoxYear;
        internal System.Windows.Forms.ComboBox comboBoxTransaction;
        internal System.Windows.Forms.TextBox textBoxTransactionReason;
        internal System.Windows.Forms.TextBox textBoxAmount;
        internal System.Windows.Forms.DateTimePicker dateTimePickerTransactionDate;
    }
}