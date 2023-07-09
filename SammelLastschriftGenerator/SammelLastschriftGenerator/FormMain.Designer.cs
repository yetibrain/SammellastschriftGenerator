namespace SammelLastschriftGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMainTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMandantTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sammellastschriftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogDb = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMitgliederliste = new System.Windows.Forms.TabPage();
            this.listViewMitglieder = new System.Windows.Forms.ListView();
            this.columnHeaderMitgliedId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMandant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIBAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEinzugsOkDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListMitgliederListe = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonValidateIBAN = new System.Windows.Forms.ToolStripButton();
            this.tabPageMitgliedsbeitrag = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewMitgliedsbeitrag = new System.Windows.Forms.ListView();
            this.columnMitgliedId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMitglied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJahresbeitrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBeitragszahlung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEinzugsOkDate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransaktionen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListMitgliedsBeitrag = new System.Windows.Forms.ImageList(this.components);
            this.listViewBeitragTransaktion = new System.Windows.Forms.ListView();
            this.columnHeaderTransaktionsDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransakionsArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBetrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZweck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxYear = new System.Windows.Forms.ToolStripComboBox();
            this.tabPageSammlerMainTemplate = new System.Windows.Forms.TabPage();
            this.textBoxMainTemplate = new System.Windows.Forms.TextBox();
            this.tabPageSammlerMandantTemplate = new System.Windows.Forms.TabPage();
            this.textBoxMandantTemplate = new System.Windows.Forms.TextBox();
            this.tabPageSammelLastschrift = new System.Windows.Forms.TabPage();
            this.textBoxSammelLastschrift = new System.Windows.Forms.TextBox();
            this.openFileDialogMainTemplate = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogMandantTemplate = new System.Windows.Forms.OpenFileDialog();
            this.toolStripStatusLabelDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeaderLastIBANCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripButtonGenerateBeitragsListe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGenerateMemberList = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageMitgliederliste.SuspendLayout();
            this.contextMenuStripListView.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPageMitgliedsbeitrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPageSammlerMainTemplate.SuspendLayout();
            this.tabPageSammlerMandantTemplate.SuspendLayout();
            this.tabPageSammelLastschrift.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDB,
            this.toolStripStatusLabelDatabase});
            this.statusStripMain.Location = new System.Drawing.Point(0, 565);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1396, 22);
            this.statusStripMain.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1396, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseToolStripMenuItem,
            this.openMainTemplateToolStripMenuItem,
            this.openMandantTemplateToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseToolStripMenuItem_Click);
            // 
            // openMainTemplateToolStripMenuItem
            // 
            this.openMainTemplateToolStripMenuItem.Name = "openMainTemplateToolStripMenuItem";
            this.openMainTemplateToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openMainTemplateToolStripMenuItem.Text = "Open Main Template";
            this.openMainTemplateToolStripMenuItem.Click += new System.EventHandler(this.openMainTemplateToolStripMenuItem_Click);
            // 
            // openMandantTemplateToolStripMenuItem
            // 
            this.openMandantTemplateToolStripMenuItem.Name = "openMandantTemplateToolStripMenuItem";
            this.openMandantTemplateToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openMandantTemplateToolStripMenuItem.Text = "Open Mandant Template";
            this.openMandantTemplateToolStripMenuItem.Click += new System.EventHandler(this.openMandantTemplateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sammellastschriftToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // sammellastschriftToolStripMenuItem
            // 
            this.sammellastschriftToolStripMenuItem.Name = "sammellastschriftToolStripMenuItem";
            this.sammellastschriftToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sammellastschriftToolStripMenuItem.Text = "Sammellastschrift";
            this.sammellastschriftToolStripMenuItem.Click += new System.EventHandler(this.sammellastschriftToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialogDb
            // 
            this.openFileDialogDb.Filter = "db-Files|*.db";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMitgliederliste);
            this.tabControlMain.Controls.Add(this.tabPageMitgliedsbeitrag);
            this.tabControlMain.Controls.Add(this.tabPageSammlerMainTemplate);
            this.tabControlMain.Controls.Add(this.tabPageSammlerMandantTemplate);
            this.tabControlMain.Controls.Add(this.tabPageSammelLastschrift);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1396, 541);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPageMitgliederliste
            // 
            this.tabPageMitgliederliste.Controls.Add(this.listViewMitglieder);
            this.tabPageMitgliederliste.Controls.Add(this.toolStrip2);
            this.tabPageMitgliederliste.Location = new System.Drawing.Point(4, 22);
            this.tabPageMitgliederliste.Name = "tabPageMitgliederliste";
            this.tabPageMitgliederliste.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMitgliederliste.Size = new System.Drawing.Size(1388, 515);
            this.tabPageMitgliederliste.TabIndex = 0;
            this.tabPageMitgliederliste.Text = "Mitgliederliste";
            this.tabPageMitgliederliste.UseVisualStyleBackColor = true;
            // 
            // listViewMitglieder
            // 
            this.listViewMitglieder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMitgliedId,
            this.columnHeaderMandant,
            this.columnHeaderIBAN,
            this.columnHeaderLastIBANCheck,
            this.columnHeaderEinzugsOkDate});
            this.listViewMitglieder.ContextMenuStrip = this.contextMenuStripListView;
            this.listViewMitglieder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMitglieder.FullRowSelect = true;
            this.listViewMitglieder.GridLines = true;
            this.listViewMitglieder.HideSelection = false;
            this.listViewMitglieder.Location = new System.Drawing.Point(3, 28);
            this.listViewMitglieder.MultiSelect = false;
            this.listViewMitglieder.Name = "listViewMitglieder";
            this.listViewMitglieder.ShowGroups = false;
            this.listViewMitglieder.Size = new System.Drawing.Size(1382, 484);
            this.listViewMitglieder.SmallImageList = this.imageListMitgliederListe;
            this.listViewMitglieder.TabIndex = 5;
            this.listViewMitglieder.UseCompatibleStateImageBehavior = false;
            this.listViewMitglieder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMitgliedId
            // 
            this.columnHeaderMitgliedId.Text = "Mitglied-Id";
            this.columnHeaderMitgliedId.Width = 100;
            // 
            // columnHeaderMandant
            // 
            this.columnHeaderMandant.Text = "Mitglied";
            this.columnHeaderMandant.Width = 200;
            // 
            // columnHeaderIBAN
            // 
            this.columnHeaderIBAN.Text = "IBAN";
            this.columnHeaderIBAN.Width = 200;
            // 
            // columnHeaderEinzugsOkDate
            // 
            this.columnHeaderEinzugsOkDate.Text = "Einzugsermächtigungsdatum";
            this.columnHeaderEinzugsOkDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderEinzugsOkDate.Width = 150;
            // 
            // contextMenuStripListView
            // 
            this.contextMenuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTransactionToolStripMenuItem});
            this.contextMenuStripListView.Name = "contextMenuStripListView";
            this.contextMenuStripListView.Size = new System.Drawing.Size(181, 26);
            this.contextMenuStripListView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripListView_Opening);
            // 
            // createTransactionToolStripMenuItem
            // 
            this.createTransactionToolStripMenuItem.Name = "createTransactionToolStripMenuItem";
            this.createTransactionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createTransactionToolStripMenuItem.Text = "Create Transaction...";
            this.createTransactionToolStripMenuItem.Click += new System.EventHandler(this.createPaymentToolStripMenuItem_Click);
            // 
            // imageListMitgliederListe
            // 
            this.imageListMitgliederListe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMitgliederListe.ImageStream")));
            this.imageListMitgliederListe.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMitgliederListe.Images.SetKeyName(0, "green_ball");
            this.imageListMitgliederListe.Images.SetKeyName(1, "yellow_ball");
            this.imageListMitgliederListe.Images.SetKeyName(2, "red_ball");
            this.imageListMitgliederListe.Images.SetKeyName(3, "cyan_ball");
            this.imageListMitgliederListe.Images.SetKeyName(4, "blue_ball");
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGenerateMemberList,
            this.toolStripButtonValidateIBAN});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1382, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonValidateIBAN
            // 
            this.toolStripButtonValidateIBAN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonValidateIBAN.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonValidateIBAN.Image")));
            this.toolStripButtonValidateIBAN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonValidateIBAN.Name = "toolStripButtonValidateIBAN";
            this.toolStripButtonValidateIBAN.Size = new System.Drawing.Size(82, 22);
            this.toolStripButtonValidateIBAN.Text = "Validate IBAN";
            this.toolStripButtonValidateIBAN.Click += new System.EventHandler(this.toolStripButtonValidateIBAN_Click);
            // 
            // tabPageMitgliedsbeitrag
            // 
            this.tabPageMitgliedsbeitrag.Controls.Add(this.splitContainer1);
            this.tabPageMitgliedsbeitrag.Controls.Add(this.toolStrip1);
            this.tabPageMitgliedsbeitrag.Location = new System.Drawing.Point(4, 22);
            this.tabPageMitgliedsbeitrag.Name = "tabPageMitgliedsbeitrag";
            this.tabPageMitgliedsbeitrag.Size = new System.Drawing.Size(1388, 515);
            this.tabPageMitgliedsbeitrag.TabIndex = 4;
            this.tabPageMitgliedsbeitrag.Text = "Mitgliedsbeitrag";
            this.tabPageMitgliedsbeitrag.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewMitgliedsbeitrag);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.listViewBeitragTransaktion);
            this.splitContainer1.Size = new System.Drawing.Size(1388, 490);
            this.splitContainer1.SplitterDistance = 780;
            this.splitContainer1.TabIndex = 2;
            // 
            // listViewMitgliedsbeitrag
            // 
            this.listViewMitgliedsbeitrag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMitgliedId,
            this.columnHeaderMitglied,
            this.columnHeaderJahresbeitrag,
            this.columnHeaderBeitragszahlung,
            this.columnHeaderEinzugsOkDate2,
            this.columnHeaderTransaktionen});
            this.listViewMitgliedsbeitrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMitgliedsbeitrag.FullRowSelect = true;
            this.listViewMitgliedsbeitrag.GridLines = true;
            this.listViewMitgliedsbeitrag.HideSelection = false;
            this.listViewMitgliedsbeitrag.Location = new System.Drawing.Point(0, 0);
            this.listViewMitgliedsbeitrag.MultiSelect = false;
            this.listViewMitgliedsbeitrag.Name = "listViewMitgliedsbeitrag";
            this.listViewMitgliedsbeitrag.Size = new System.Drawing.Size(780, 490);
            this.listViewMitgliedsbeitrag.SmallImageList = this.imageListMitgliedsBeitrag;
            this.listViewMitgliedsbeitrag.TabIndex = 1;
            this.listViewMitgliedsbeitrag.UseCompatibleStateImageBehavior = false;
            this.listViewMitgliedsbeitrag.View = System.Windows.Forms.View.Details;
            this.listViewMitgliedsbeitrag.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMitgliedsbeitrag_ItemSelectionChanged);
            // 
            // columnMitgliedId
            // 
            this.columnMitgliedId.Text = "Mitglied-Id";
            this.columnMitgliedId.Width = 100;
            // 
            // columnHeaderMitglied
            // 
            this.columnHeaderMitglied.Text = "Mitglied";
            this.columnHeaderMitglied.Width = 200;
            // 
            // columnHeaderJahresbeitrag
            // 
            this.columnHeaderJahresbeitrag.Text = "Jahresbeitrag";
            this.columnHeaderJahresbeitrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderJahresbeitrag.Width = 100;
            // 
            // columnHeaderBeitragszahlung
            // 
            this.columnHeaderBeitragszahlung.Text = "Beitragszahlung";
            this.columnHeaderBeitragszahlung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderBeitragszahlung.Width = 100;
            // 
            // columnHeaderEinzugsOkDate2
            // 
            this.columnHeaderEinzugsOkDate2.Text = "Einzugsermächtigungsdatum";
            this.columnHeaderEinzugsOkDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderEinzugsOkDate2.Width = 150;
            // 
            // columnHeaderTransaktionen
            // 
            this.columnHeaderTransaktionen.Text = "Transaktionen";
            this.columnHeaderTransaktionen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderTransaktionen.Width = 100;
            // 
            // imageListMitgliedsBeitrag
            // 
            this.imageListMitgliedsBeitrag.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMitgliedsBeitrag.ImageStream")));
            this.imageListMitgliedsBeitrag.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMitgliedsBeitrag.Images.SetKeyName(0, "green_ball");
            this.imageListMitgliedsBeitrag.Images.SetKeyName(1, "yellow_ball");
            this.imageListMitgliedsBeitrag.Images.SetKeyName(2, "red_ball");
            this.imageListMitgliedsBeitrag.Images.SetKeyName(3, "cyan_ball");
            this.imageListMitgliedsBeitrag.Images.SetKeyName(4, "blue_ball");
            // 
            // listViewBeitragTransaktion
            // 
            this.listViewBeitragTransaktion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTransaktionsDatum,
            this.columnHeaderTransakionsArt,
            this.columnHeaderBetrag,
            this.columnHeaderZweck});
            this.listViewBeitragTransaktion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBeitragTransaktion.FullRowSelect = true;
            this.listViewBeitragTransaktion.GridLines = true;
            this.listViewBeitragTransaktion.HideSelection = false;
            this.listViewBeitragTransaktion.Location = new System.Drawing.Point(0, 0);
            this.listViewBeitragTransaktion.MultiSelect = false;
            this.listViewBeitragTransaktion.Name = "listViewBeitragTransaktion";
            this.listViewBeitragTransaktion.Size = new System.Drawing.Size(604, 490);
            this.listViewBeitragTransaktion.TabIndex = 0;
            this.listViewBeitragTransaktion.UseCompatibleStateImageBehavior = false;
            this.listViewBeitragTransaktion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTransaktionsDatum
            // 
            this.columnHeaderTransaktionsDatum.Text = "Transaktionsdatum";
            this.columnHeaderTransaktionsDatum.Width = 120;
            // 
            // columnHeaderTransakionsArt
            // 
            this.columnHeaderTransakionsArt.Text = "Transaktionsart";
            this.columnHeaderTransakionsArt.Width = 100;
            // 
            // columnHeaderBetrag
            // 
            this.columnHeaderBetrag.Text = "Betrag";
            this.columnHeaderBetrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderBetrag.Width = 100;
            // 
            // columnHeaderZweck
            // 
            this.columnHeaderZweck.Text = "Zweck";
            this.columnHeaderZweck.Width = 400;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxYear,
            this.toolStripButtonGenerateBeitragsListe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1388, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxYear
            // 
            this.toolStripComboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxYear.Name = "toolStripComboBoxYear";
            this.toolStripComboBoxYear.Size = new System.Drawing.Size(98, 25);
            // 
            // tabPageSammlerMainTemplate
            // 
            this.tabPageSammlerMainTemplate.Controls.Add(this.textBoxMainTemplate);
            this.tabPageSammlerMainTemplate.Location = new System.Drawing.Point(4, 22);
            this.tabPageSammlerMainTemplate.Name = "tabPageSammlerMainTemplate";
            this.tabPageSammlerMainTemplate.Size = new System.Drawing.Size(1388, 515);
            this.tabPageSammlerMainTemplate.TabIndex = 2;
            this.tabPageSammlerMainTemplate.Text = "Sammler Main Template";
            this.tabPageSammlerMainTemplate.UseVisualStyleBackColor = true;
            // 
            // textBoxMainTemplate
            // 
            this.textBoxMainTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMainTemplate.Location = new System.Drawing.Point(0, 0);
            this.textBoxMainTemplate.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxMainTemplate.Multiline = true;
            this.textBoxMainTemplate.Name = "textBoxMainTemplate";
            this.textBoxMainTemplate.ReadOnly = true;
            this.textBoxMainTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMainTemplate.Size = new System.Drawing.Size(1388, 515);
            this.textBoxMainTemplate.TabIndex = 0;
            // 
            // tabPageSammlerMandantTemplate
            // 
            this.tabPageSammlerMandantTemplate.Controls.Add(this.textBoxMandantTemplate);
            this.tabPageSammlerMandantTemplate.Location = new System.Drawing.Point(4, 22);
            this.tabPageSammlerMandantTemplate.Name = "tabPageSammlerMandantTemplate";
            this.tabPageSammlerMandantTemplate.Size = new System.Drawing.Size(1388, 515);
            this.tabPageSammlerMandantTemplate.TabIndex = 3;
            this.tabPageSammlerMandantTemplate.Text = "Sammler Mandant Template";
            this.tabPageSammlerMandantTemplate.UseVisualStyleBackColor = true;
            // 
            // textBoxMandantTemplate
            // 
            this.textBoxMandantTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMandantTemplate.Location = new System.Drawing.Point(0, 0);
            this.textBoxMandantTemplate.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxMandantTemplate.Multiline = true;
            this.textBoxMandantTemplate.Name = "textBoxMandantTemplate";
            this.textBoxMandantTemplate.ReadOnly = true;
            this.textBoxMandantTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMandantTemplate.Size = new System.Drawing.Size(1388, 515);
            this.textBoxMandantTemplate.TabIndex = 1;
            // 
            // tabPageSammelLastschrift
            // 
            this.tabPageSammelLastschrift.Controls.Add(this.textBoxSammelLastschrift);
            this.tabPageSammelLastschrift.Location = new System.Drawing.Point(4, 22);
            this.tabPageSammelLastschrift.Name = "tabPageSammelLastschrift";
            this.tabPageSammelLastschrift.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSammelLastschrift.Size = new System.Drawing.Size(1388, 515);
            this.tabPageSammelLastschrift.TabIndex = 1;
            this.tabPageSammelLastschrift.Text = "Sammel Lastschrift";
            this.tabPageSammelLastschrift.UseVisualStyleBackColor = true;
            // 
            // textBoxSammelLastschrift
            // 
            this.textBoxSammelLastschrift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSammelLastschrift.Location = new System.Drawing.Point(3, 3);
            this.textBoxSammelLastschrift.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxSammelLastschrift.Multiline = true;
            this.textBoxSammelLastschrift.Name = "textBoxSammelLastschrift";
            this.textBoxSammelLastschrift.ReadOnly = true;
            this.textBoxSammelLastschrift.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSammelLastschrift.Size = new System.Drawing.Size(1382, 509);
            this.textBoxSammelLastschrift.TabIndex = 3;
            // 
            // openFileDialogMainTemplate
            // 
            this.openFileDialogMainTemplate.Filter = "xml-Files|*.xml";
            // 
            // openFileDialogMandantTemplate
            // 
            this.openFileDialogMandantTemplate.Filter = "xml-Files|*.xml";
            // 
            // toolStripStatusLabelDB
            // 
            this.toolStripStatusLabelDB.Name = "toolStripStatusLabelDB";
            this.toolStripStatusLabelDB.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabelDB.Text = "Database:";
            // 
            // toolStripStatusLabelDatabase
            // 
            this.toolStripStatusLabelDatabase.Name = "toolStripStatusLabelDatabase";
            this.toolStripStatusLabelDatabase.Size = new System.Drawing.Size(0, 17);
            // 
            // columnHeaderLastIBANCheck
            // 
            this.columnHeaderLastIBANCheck.Text = "IBAN Check Datum";
            this.columnHeaderLastIBANCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderLastIBANCheck.Width = 120;
            // 
            // toolStripButtonGenerateBeitragsListe
            // 
            this.toolStripButtonGenerateBeitragsListe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGenerateBeitragsListe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateBeitragsListe.Image")));
            this.toolStripButtonGenerateBeitragsListe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerateBeitragsListe.Name = "toolStripButtonGenerateBeitragsListe";
            this.toolStripButtonGenerateBeitragsListe.Size = new System.Drawing.Size(68, 22);
            this.toolStripButtonGenerateBeitragsListe.Text = "Generieren";
            this.toolStripButtonGenerateBeitragsListe.Click += new System.EventHandler(this.toolStripButtonGenerate_Click);
            // 
            // toolStripButtonGenerateMemberList
            // 
            this.toolStripButtonGenerateMemberList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGenerateMemberList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateMemberList.Image")));
            this.toolStripButtonGenerateMemberList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerateMemberList.Name = "toolStripButtonGenerateMemberList";
            this.toolStripButtonGenerateMemberList.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonGenerateMemberList.Text = "Generate";
            this.toolStripButtonGenerateMemberList.Click += new System.EventHandler(this.toolStripButtonGenerateMemberList_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 587);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sammel Lastschrift Generator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMitgliederliste.ResumeLayout(false);
            this.tabPageMitgliederliste.PerformLayout();
            this.contextMenuStripListView.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPageMitgliedsbeitrag.ResumeLayout(false);
            this.tabPageMitgliedsbeitrag.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPageSammlerMainTemplate.ResumeLayout(false);
            this.tabPageSammlerMainTemplate.PerformLayout();
            this.tabPageSammlerMandantTemplate.ResumeLayout(false);
            this.tabPageSammlerMandantTemplate.PerformLayout();
            this.tabPageSammelLastschrift.ResumeLayout(false);
            this.tabPageSammelLastschrift.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogDb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sammellastschriftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMainTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMandantTemplateToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMitgliederliste;
        private System.Windows.Forms.TabPage tabPageSammelLastschrift;
        private System.Windows.Forms.TabPage tabPageSammlerMainTemplate;
        private System.Windows.Forms.TabPage tabPageSammlerMandantTemplate;
        private System.Windows.Forms.TextBox textBoxMainTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialogMainTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialogMandantTemplate;
        private System.Windows.Forms.TextBox textBoxMandantTemplate;
        private System.Windows.Forms.TextBox textBoxSammelLastschrift;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListView;
        private System.Windows.Forms.ToolStripMenuItem createTransactionToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageMitgliedsbeitrag;
        private System.Windows.Forms.ListView listViewMitgliedsbeitrag;
        private System.Windows.Forms.ColumnHeader columnMitgliedId;
        private System.Windows.Forms.ColumnHeader columnHeaderMitglied;
        private System.Windows.Forms.ColumnHeader columnHeaderJahresbeitrag;
        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripComboBox toolStripComboBoxYear;
        private System.Windows.Forms.ListView listViewMitglieder;
        private System.Windows.Forms.ColumnHeader columnHeaderMitgliedId;
        private System.Windows.Forms.ColumnHeader columnHeaderMandant;
        private System.Windows.Forms.ColumnHeader columnHeaderIBAN;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonValidateIBAN;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewBeitragTransaktion;
        private System.Windows.Forms.ColumnHeader columnHeaderTransaktionsDatum;
        private System.Windows.Forms.ColumnHeader columnHeaderTransakionsArt;
        private System.Windows.Forms.ColumnHeader columnHeaderBetrag;
        private System.Windows.Forms.ColumnHeader columnHeaderZweck;
        private System.Windows.Forms.ColumnHeader columnHeaderBeitragszahlung;
        private System.Windows.Forms.ImageList imageListMitgliederListe;
        private System.Windows.Forms.ImageList imageListMitgliedsBeitrag;
        private System.Windows.Forms.ColumnHeader columnHeaderEinzugsOkDate;
        private System.Windows.Forms.ColumnHeader columnHeaderEinzugsOkDate2;
        private System.Windows.Forms.ColumnHeader columnHeaderTransaktionen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDB;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDatabase;
        private System.Windows.Forms.ColumnHeader columnHeaderLastIBANCheck;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerateBeitragsListe;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerateMemberList;
    }
}

