
namespace Proiect_PAOO
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFisier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFisDes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFisSal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFisInc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEditare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuVizualizare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuVizRap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuUnelte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuUnelInt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuUnelForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAjutor = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.panelVulnerabilitati = new Proiect_PAOO.Vulnerabilitati();
            this.panelRiscuri = new Proiect_PAOO.Riscuri();
            this.buttonBunAnuleaza = new System.Windows.Forms.Button();
            this.buttonBunSave = new System.Windows.Forms.Button();
            this.textBoxBunCostRed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBunCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDomeniu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxImMax = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBunNume = new System.Windows.Forms.TextBox();
            this.comboBoxImMin = new System.Windows.Forms.ComboBox();
            this.comboBoxNomendator = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewBunuri = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpactMinim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpactMaxim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domeniu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostReducere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBunuri = new Proiect_PAOO.Bun();
            this.panelAmenintari = new Proiect_PAOO.Amenintari();
            this.panelTratare = new Proiect_PAOO.Tratare();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBunuri)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFisier,
            this.toolStripMenuEditare,
            this.toolStripMenuVizualizare,
            this.toolStripMenuUnelte,
            this.toolStripMenuAjutor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuFisier
            // 
            this.toolStripMenuFisier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFisDes,
            this.toolStripMenuFisSal,
            this.toolStripMenuFisInc});
            this.toolStripMenuFisier.Name = "toolStripMenuFisier";
            this.toolStripMenuFisier.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuFisier.Text = "Fisier";
            // 
            // toolStripMenuFisDes
            // 
            this.toolStripMenuFisDes.Name = "toolStripMenuFisDes";
            this.toolStripMenuFisDes.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuFisDes.Text = "Deschide";
            // 
            // toolStripMenuFisSal
            // 
            this.toolStripMenuFisSal.Name = "toolStripMenuFisSal";
            this.toolStripMenuFisSal.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuFisSal.Text = "Salvare";
            // 
            // toolStripMenuFisInc
            // 
            this.toolStripMenuFisInc.Name = "toolStripMenuFisInc";
            this.toolStripMenuFisInc.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuFisInc.Text = "Inchidere";
            // 
            // toolStripMenuEditare
            // 
            this.toolStripMenuEditare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEditCopy,
            this.toolStripMenuEditCut,
            this.toolStripMenuEditPaste});
            this.toolStripMenuEditare.Name = "toolStripMenuEditare";
            this.toolStripMenuEditare.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuEditare.Text = "Editare";
            // 
            // toolStripMenuEditCopy
            // 
            this.toolStripMenuEditCopy.Name = "toolStripMenuEditCopy";
            this.toolStripMenuEditCopy.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuEditCopy.Text = "Copy";
            // 
            // toolStripMenuEditCut
            // 
            this.toolStripMenuEditCut.Name = "toolStripMenuEditCut";
            this.toolStripMenuEditCut.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuEditCut.Text = "Cut";
            // 
            // toolStripMenuEditPaste
            // 
            this.toolStripMenuEditPaste.Name = "toolStripMenuEditPaste";
            this.toolStripMenuEditPaste.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuEditPaste.Text = "Paste";
            // 
            // toolStripMenuVizualizare
            // 
            this.toolStripMenuVizualizare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuVizRap});
            this.toolStripMenuVizualizare.Name = "toolStripMenuVizualizare";
            this.toolStripMenuVizualizare.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuVizualizare.Text = "Vizualizare";
            // 
            // toolStripMenuVizRap
            // 
            this.toolStripMenuVizRap.Name = "toolStripMenuVizRap";
            this.toolStripMenuVizRap.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuVizRap.Text = "Raport";
            // 
            // toolStripMenuUnelte
            // 
            this.toolStripMenuUnelte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuUnelInt,
            this.toolStripMenuUnelForm});
            this.toolStripMenuUnelte.Name = "toolStripMenuUnelte";
            this.toolStripMenuUnelte.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuUnelte.Text = "Unelte";
            // 
            // toolStripMenuUnelInt
            // 
            this.toolStripMenuUnelInt.Name = "toolStripMenuUnelInt";
            this.toolStripMenuUnelInt.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuUnelInt.Text = "Interogari";
            // 
            // toolStripMenuUnelForm
            // 
            this.toolStripMenuUnelForm.Name = "toolStripMenuUnelForm";
            this.toolStripMenuUnelForm.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuUnelForm.Text = "Formulare";
            // 
            // toolStripMenuAjutor
            // 
            this.toolStripMenuAjutor.Name = "toolStripMenuAjutor";
            this.toolStripMenuAjutor.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuAjutor.Text = "Ajutor";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonExcel);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonX);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 58);
            this.panel1.TabIndex = 1;
            // 
            // buttonExcel
            // 
            this.buttonExcel.Image = global::Proiect_PAOO.Properties.Resources.excel;
            this.buttonExcel.Location = new System.Drawing.Point(144, 10);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(38, 38);
            this.buttonExcel.TabIndex = 3;
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.AutoSize = true;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.Location = new System.Drawing.Point(100, 10);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(38, 38);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonX
            // 
            this.buttonX.AutoSize = true;
            this.buttonX.Image = ((System.Drawing.Image)(resources.GetObject("buttonX.Image")));
            this.buttonX.Location = new System.Drawing.Point(56, 10);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(38, 38);
            this.buttonX.TabIndex = 1;
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.AutoSize = true;
            this.buttonPlus.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlus.Image")));
            this.buttonPlus.Location = new System.Drawing.Point(12, 10);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(38, 38);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 411);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "RISK";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Identificare bunuri",
            "Identificare amenintari",
            "Identificare vulnerabilitati",
            "Identificare riscuri",
            "Tratare riscuri si identificare contramasuri"});
            this.listBox1.Location = new System.Drawing.Point(12, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 349);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Location = new System.Drawing.Point(12, 507);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(104, 15);
            this.labelCurrent.TabIndex = 6;
            this.labelCurrent.Text = "Identificare bunuri";
            // 
            // panelVulnerabilitati
            // 
            this.panelVulnerabilitati.Location = new System.Drawing.Point(171, 93);
            this.panelVulnerabilitati.Name = "panelVulnerabilitati";
            this.panelVulnerabilitati.Size = new System.Drawing.Size(792, 394);
            this.panelVulnerabilitati.TabIndex = 9;
            this.panelVulnerabilitati.Load += new System.EventHandler(this.panelVulnerabilitati_Load);
            // 
            // panelRiscuri
            // 
            this.panelRiscuri.Location = new System.Drawing.Point(172, 92);
            this.panelRiscuri.Name = "panelRiscuri";
            this.panelRiscuri.Size = new System.Drawing.Size(791, 394);
            this.panelRiscuri.TabIndex = 10;
            this.panelRiscuri.Load += new System.EventHandler(this.panelRiscuri_Load);
            // 
            // buttonBunAnuleaza
            // 
            this.buttonBunAnuleaza.Location = new System.Drawing.Point(827, 115);
            this.buttonBunAnuleaza.Name = "buttonBunAnuleaza";
            this.buttonBunAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.buttonBunAnuleaza.TabIndex = 41;
            this.buttonBunAnuleaza.Text = "Anuleaza";
            this.buttonBunAnuleaza.UseVisualStyleBackColor = true;
            // 
            // buttonBunSave
            // 
            this.buttonBunSave.Location = new System.Drawing.Point(741, 115);
            this.buttonBunSave.Name = "buttonBunSave";
            this.buttonBunSave.Size = new System.Drawing.Size(75, 23);
            this.buttonBunSave.TabIndex = 40;
            this.buttonBunSave.Text = "Salveaza";
            this.buttonBunSave.UseVisualStyleBackColor = true;
            // 
            // textBoxBunCostRed
            // 
            this.textBoxBunCostRed.Location = new System.Drawing.Point(846, 86);
            this.textBoxBunCostRed.Name = "textBoxBunCostRed";
            this.textBoxBunCostRed.Size = new System.Drawing.Size(56, 23);
            this.textBoxBunCostRed.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(741, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Cost de reducere:";
            // 
            // textBoxBunCost
            // 
            this.textBoxBunCost.Location = new System.Drawing.Point(672, 83);
            this.textBoxBunCost.Name = "textBoxBunCost";
            this.textBoxBunCost.Size = new System.Drawing.Size(56, 23);
            this.textBoxBunCost.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(632, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Cost:";
            // 
            // comboBoxDomeniu
            // 
            this.comboBoxDomeniu.FormattingEnabled = true;
            this.comboBoxDomeniu.Items.AddRange(new object[] {
            "Oameni",
            "Activitati",
            "Informatii",
            "Facilitati"});
            this.comboBoxDomeniu.Location = new System.Drawing.Point(672, 58);
            this.comboBoxDomeniu.Name = "comboBoxDomeniu";
            this.comboBoxDomeniu.Size = new System.Drawing.Size(230, 23);
            this.comboBoxDomeniu.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(607, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Domeniu:";
            // 
            // comboBoxImMax
            // 
            this.comboBoxImMax.FormattingEnabled = true;
            this.comboBoxImMax.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxImMax.Location = new System.Drawing.Point(463, 108);
            this.comboBoxImMax.Name = "comboBoxImMax";
            this.comboBoxImMax.Size = new System.Drawing.Size(80, 23);
            this.comboBoxImMax.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Impact maxim:";
            // 
            // textBoxBunNume
            // 
            this.textBoxBunNume.Location = new System.Drawing.Point(248, 83);
            this.textBoxBunNume.Name = "textBoxBunNume";
            this.textBoxBunNume.Size = new System.Drawing.Size(295, 23);
            this.textBoxBunNume.TabIndex = 31;
            // 
            // comboBoxImMin
            // 
            this.comboBoxImMin.FormattingEnabled = true;
            this.comboBoxImMin.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxImMin.Location = new System.Drawing.Point(248, 108);
            this.comboBoxImMin.Name = "comboBoxImMin";
            this.comboBoxImMin.Size = new System.Drawing.Size(80, 23);
            this.comboBoxImMin.TabIndex = 30;
            // 
            // comboBoxNomendator
            // 
            this.comboBoxNomendator.FormattingEnabled = true;
            this.comboBoxNomendator.Location = new System.Drawing.Point(248, 58);
            this.comboBoxNomendator.Name = "comboBoxNomendator";
            this.comboBoxNomendator.Size = new System.Drawing.Size(295, 23);
            this.comboBoxNomendator.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Impact minim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nume:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nomendator bunuri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(132, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adaugare/editare bunuri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Identificare bunuri";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 533);
            this.splitter1.TabIndex = 23;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bunuri";
            // 
            // dataGridViewBunuri
            // 
            this.dataGridViewBunuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBunuri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.ImpactMinim,
            this.ImpactMaxim,
            this.Domeniu,
            this.Cost,
            this.CostReducere});
            this.dataGridViewBunuri.Location = new System.Drawing.Point(123, 166);
            this.dataGridViewBunuri.Name = "dataGridViewBunuri";
            this.dataGridViewBunuri.RowTemplate.Height = 25;
            this.dataGridViewBunuri.Size = new System.Drawing.Size(792, 226);
            this.dataGridViewBunuri.TabIndex = 21;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // ImpactMinim
            // 
            this.ImpactMinim.HeaderText = "Impact Minim";
            this.ImpactMinim.Name = "ImpactMinim";
            // 
            // ImpactMaxim
            // 
            this.ImpactMaxim.HeaderText = "Impact Maxim";
            this.ImpactMaxim.Name = "ImpactMaxim";
            // 
            // Domeniu
            // 
            this.Domeniu.HeaderText = "Domeniu";
            this.Domeniu.Name = "Domeniu";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // CostReducere
            // 
            this.CostReducere.HeaderText = "Cost de reducere";
            this.CostReducere.Name = "CostReducere";
            // 
            // panelBunuri
            // 
            this.panelBunuri.Location = new System.Drawing.Point(172, 95);
            this.panelBunuri.Name = "panelBunuri";
            this.panelBunuri.Size = new System.Drawing.Size(793, 397);
            this.panelBunuri.TabIndex = 11;
            // 
            // panelAmenintari
            // 
            this.panelAmenintari.Location = new System.Drawing.Point(172, 92);
            this.panelAmenintari.Name = "panelAmenintari";
            this.panelAmenintari.Size = new System.Drawing.Size(793, 394);
            this.panelAmenintari.TabIndex = 3;
            // 
            // panelTratare
            // 
            this.panelTratare.Location = new System.Drawing.Point(172, 92);
            this.panelTratare.Name = "panelTratare";
            this.panelTratare.Size = new System.Drawing.Size(793, 395);
            this.panelTratare.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 534);
            this.Controls.Add(this.panelBunuri);
            this.Controls.Add(this.panelVulnerabilitati);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelRiscuri);
            this.Controls.Add(this.panelTratare);
            this.Controls.Add(this.panelAmenintari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Analiza si evaluarea riscurilor de securitate";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBunuri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFisier;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEditare;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuVizualizare;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuUnelte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAjutor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFisDes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFisSal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFisInc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEditCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuVizRap;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuUnelInt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuUnelForm;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Label labelCurrent;
        private Vulnerabilitati panelVulnerabilitati;
        private Riscuri panelRiscuri;
        private System.Windows.Forms.Button buttonBunAnuleaza;
        private System.Windows.Forms.Button buttonBunSave;
        private System.Windows.Forms.TextBox textBoxBunCostRed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBunCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxDomeniu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxImMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBunNume;
        private System.Windows.Forms.ComboBox comboBoxImMin;
        private System.Windows.Forms.ComboBox comboBoxNomendator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridViewBunuri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpactMinim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpactMaxim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domeniu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostReducere;
        private Bun panelBunuri;
        private Amenintari panelAmenintari;
        private Tratare panelTratare;
        private System.Windows.Forms.Button buttonExcel;
    }
}

