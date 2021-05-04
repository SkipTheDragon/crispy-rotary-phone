using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Proiect_PAOO
{
    class PanelTratare : Panel
    {
        DataGridView dataGridViewTrat = new DataGridView();
        Label label47 = new Label();
        Button buttonTratSave = new Button();
        Button buttonTratStergere = new Button();
        Button buttonTratAdauga = new Button();
        TextBox textBoxTratAdauga = new TextBox();
        TextBox textBoxTratContra = new TextBox();
        Label label46 = new Label();
        TextBox textBoxTratVul = new TextBox();
        Label label45 = new Label();
        TextBox textBoxTratAmen = new TextBox();
        Label label44 = new Label();
        TextBox textBoxTratBun = new TextBox();
        Label label43 = new Label();
        TextBox textBoxTratMet = new TextBox();
        Label label42 = new Label();
        TextBox textBoxTratProb = new TextBox();
        TextBox textBoxTratNiv = new TextBox();
        Label label41 = new Label();
        Label label40 = new Label();
        TextBox textBox1 = new TextBox();
        Label label39 = new Label();
        Label label38 = new Label();
        Label label37 = new Label();


        DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn MetodaTratare = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn CategorieContramasuri = new DataGridViewTextBoxColumn();
        DataGridViewCheckBoxColumn Tratat = new DataGridViewCheckBoxColumn();
        public PanelTratare()
        {

        }

        private void buildUI()
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(this.dataGridViewTrat);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.buttonTratSave);
            this.Controls.Add(this.buttonTratStergere);
            this.Controls.Add(this.buttonTratAdauga);
            this.Controls.Add(this.textBoxTratAdauga);
            this.Controls.Add(this.textBoxTratContra);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.textBoxTratVul);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.textBoxTratAmen);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.textBoxTratBun);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.textBoxTratMet);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.textBoxTratProb);
            this.Controls.Add(this.textBoxTratNiv);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Location = new System.Drawing.Point(162, 93);
            this.Name = "panelTratare";
            this.Size = new System.Drawing.Size(793, 396);
            this.TabIndex = 8;
        }

        private void appendToUI()
        {
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrat)).BeginInit();
            // 
            // dataGridViewTrat
            // 
            dataGridViewTrat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrat.Columns.AddRange(new DataGridViewColumn[] {
            dataGridViewTextBoxColumn2,
            MetodaTratare,
            CategorieContramasuri,
            Tratat});
            dataGridViewTrat.Location = new System.Drawing.Point(-2, 263);
            dataGridViewTrat.Name = "dataGridViewTrat";
            dataGridViewTrat.RowTemplate.Height = 25;
            dataGridViewTrat.Size = new System.Drawing.Size(793, 129);
            dataGridViewTrat.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nume Risc";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // MetodaTratare
            // 
            MetodaTratare.HeaderText = "Metoda De Tratare";
            MetodaTratare.Name = "MetodaTratare";
            // 
            // CategorieContramasuri
            // 
            CategorieContramasuri.HeaderText = "Categorie Contramasuri";
            CategorieContramasuri.Name = "CategorieContramasuri";
            // 
            // Tratat
            // 
            Tratat.HeaderText = "Tratat";
            Tratat.Name = "Tratat";
            Tratat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Tratat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new System.Drawing.Point(4, 244);
            label47.Name = "label47";
            label47.Size = new System.Drawing.Size(42, 15);
            label47.TabIndex = 22;
            label47.Text = "Riscuri";
            // 
            // buttonTratSave
            // 
            buttonTratSave.Location = new System.Drawing.Point(592, 235);
            buttonTratSave.Name = "buttonTratSave";
            buttonTratSave.Size = new System.Drawing.Size(75, 23);
            buttonTratSave.TabIndex = 21;
            buttonTratSave.Text = "Salvati";
            buttonTratSave.UseVisualStyleBackColor = true;
            // 
            // buttonTratStergere
            // 
            buttonTratStergere.AutoSize = true;
            buttonTratStergere.Location = new System.Drawing.Point(673, 232);
            buttonTratStergere.Name = "buttonTratStergere";
            buttonTratStergere.Size = new System.Drawing.Size(109, 25);
            buttonTratStergere.TabIndex = 20;
            buttonTratStergere.Text = "Stergere formular";
            buttonTratStergere.UseVisualStyleBackColor = true;
            // 
            // buttonTratAdauga
            // 
            buttonTratAdauga.Location = new System.Drawing.Point(705, 187);
            buttonTratAdauga.Name = "buttonTratAdauga";
            buttonTratAdauga.Size = new System.Drawing.Size(75, 23);
            buttonTratAdauga.TabIndex = 19;
            buttonTratAdauga.Text = "Adauga";
            buttonTratAdauga.UseVisualStyleBackColor = true;
            // 
            // textBoxTratAdauga
            // 
            textBoxTratAdauga.Location = new System.Drawing.Point(412, 187);
            textBoxTratAdauga.Name = "textBoxTratAdauga";
            textBoxTratAdauga.Size = new System.Drawing.Size(288, 23);
            textBoxTratAdauga.TabIndex = 18;
            // 
            // textBoxTratContra
            // 
            textBoxTratContra.Location = new System.Drawing.Point(412, 78);
            textBoxTratContra.Multiline = true;
            textBoxTratContra.Name = "textBoxTratContra";
            textBoxTratContra.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxTratContra.Size = new System.Drawing.Size(367, 103);
            textBoxTratContra.TabIndex = 17;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new System.Drawing.Point(412, 60);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(192, 15);
            label46.TabIndex = 16;
            label46.Text = "Contramasuri, Categoria \'Activitati\'";
            // 
            // textBoxTratVul
            // 
            textBoxTratVul.Location = new System.Drawing.Point(248, 187);
            textBoxTratVul.Name = "textBoxTratVul";
            textBoxTratVul.Size = new System.Drawing.Size(131, 23);
            textBoxTratVul.TabIndex = 15;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new System.Drawing.Point(248, 166);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(86, 15);
            label45.TabIndex = 14;
            label45.Text = "Vulnerabilitate:";
            // 
            // textBoxTratAmen
            // 
            textBoxTratAmen.Location = new System.Drawing.Point(248, 129);
            textBoxTratAmen.Name = "textBoxTratAmen";
            textBoxTratAmen.Size = new System.Drawing.Size(131, 23);
            textBoxTratAmen.TabIndex = 13;
            // 
            // label44
            // 
            label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(248, 109);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(72, 15);
            this.label44.TabIndex = 12;
            this.label44.Text = "Amenintare:";
            // 
            // textBoxTratBun
            // 
            textBoxTratBun.Location = new System.Drawing.Point(248, 78);
            textBoxTratBun.Name = "textBoxTratBun";
            textBoxTratBun.Size = new System.Drawing.Size(131, 23);
            textBoxTratBun.TabIndex = 11;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new System.Drawing.Point(248, 60);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(31, 15);
            label43.TabIndex = 10;
            label43.Text = "Bun:";
            // 
            // textBoxTratMet
            // 
            textBoxTratMet.Location = new System.Drawing.Point(4, 184);
            textBoxTratMet.Name = "textBoxTratMet";
            textBoxTratMet.Size = new System.Drawing.Size(217, 23);
            textBoxTratMet.TabIndex = 9;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new System.Drawing.Point(4, 160);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(104, 15);
            label42.TabIndex = 8;
            label42.Text = "Metoda de tratare:";
            // 
            // textBoxTratProb
            // 
            textBoxTratProb.Location = new System.Drawing.Point(126, 129);
            textBoxTratProb.Name = "textBoxTratProb";
            textBoxTratProb.Size = new System.Drawing.Size(95, 23);
            textBoxTratProb.TabIndex = 7;
            // 
            // textBoxTratNiv
            // 
            textBoxTratNiv.Location = new System.Drawing.Point(4, 129);
            textBoxTratNiv.Name = "textBoxTratNiv";
            textBoxTratNiv.Size = new System.Drawing.Size(103, 23);
            textBoxTratNiv.TabIndex = 6;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new System.Drawing.Point(122, 108);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(96, 15);
            label41.TabIndex = 5;
            label41.Text = "Prob. de aparitie:";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new System.Drawing.Point(4, 108);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(88, 15);
            label40.TabIndex = 4;
            label40.Text = "Nivelul riscului:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(4, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(217, 23);
            textBox1.TabIndex = 3;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new System.Drawing.Point(4, 61);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(64, 15);
            label39.TabIndex = 2;
            label39.Text = "Nume risc:";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new System.Drawing.Point(10, 33);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(139, 15);
            label38.TabIndex = 1;
            label38.Text = "Identificare contramasuri";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label37.Location = new System.Drawing.Point(10, 9);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(301, 20);
            label37.TabIndex = 0;
            label37.Text = "Tratare riscuri si identificare contramasuri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrat)).EndInit();

        }
    }
}
