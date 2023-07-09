namespace SammelLastschriftGenerator
{
    partial class SammelllastschriftErgebnisDialog
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.textBoxBeitragssumme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnzahlMandanten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxJahr = new System.Windows.Forms.TextBox();
            this.labelBeitragsjahr = new System.Windows.Forms.Label();
            this.groupBoxParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(25, 223);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(281, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.textBoxBeitragssumme);
            this.groupBoxParams.Controls.Add(this.label2);
            this.groupBoxParams.Controls.Add(this.textBoxAnzahlMandanten);
            this.groupBoxParams.Controls.Add(this.label1);
            this.groupBoxParams.Controls.Add(this.textBoxJahr);
            this.groupBoxParams.Controls.Add(this.labelBeitragsjahr);
            this.groupBoxParams.Location = new System.Drawing.Point(25, 12);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(281, 178);
            this.groupBoxParams.TabIndex = 2;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Daten";
            // 
            // textBoxBeitragssumme
            // 
            this.textBoxBeitragssumme.Location = new System.Drawing.Point(141, 126);
            this.textBoxBeitragssumme.Name = "textBoxBeitragssumme";
            this.textBoxBeitragssumme.ReadOnly = true;
            this.textBoxBeitragssumme.Size = new System.Drawing.Size(100, 20);
            this.textBoxBeitragssumme.TabIndex = 6;
            this.textBoxBeitragssumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Beitragssumme €:";
            // 
            // textBoxAnzahlMandanten
            // 
            this.textBoxAnzahlMandanten.Location = new System.Drawing.Point(141, 76);
            this.textBoxAnzahlMandanten.Name = "textBoxAnzahlMandanten";
            this.textBoxAnzahlMandanten.ReadOnly = true;
            this.textBoxAnzahlMandanten.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnzahlMandanten.TabIndex = 4;
            this.textBoxAnzahlMandanten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anzahl Mandanten:";
            // 
            // textBoxJahr
            // 
            this.textBoxJahr.Location = new System.Drawing.Point(141, 32);
            this.textBoxJahr.Name = "textBoxJahr";
            this.textBoxJahr.ReadOnly = true;
            this.textBoxJahr.Size = new System.Drawing.Size(100, 20);
            this.textBoxJahr.TabIndex = 2;
            this.textBoxJahr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelBeitragsjahr
            // 
            this.labelBeitragsjahr.AutoSize = true;
            this.labelBeitragsjahr.Location = new System.Drawing.Point(19, 35);
            this.labelBeitragsjahr.Name = "labelBeitragsjahr";
            this.labelBeitragsjahr.Size = new System.Drawing.Size(65, 13);
            this.labelBeitragsjahr.TabIndex = 1;
            this.labelBeitragsjahr.Text = "Beitragsjahr:";
            // 
            // SammelllastschriftErgebnisDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 269);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SammelllastschriftErgebnisDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sammell Lastschrift Ergebnis";
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.Label labelBeitragsjahr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBoxBeitragssumme;
        internal System.Windows.Forms.TextBox textBoxAnzahlMandanten;
        internal System.Windows.Forms.TextBox textBoxJahr;
    }
}