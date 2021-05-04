using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Proiect_PAOO
{
    class PanelVulnerabilitati : Panel
    {
        DataGridView dataGridViewVulnerabilitati = new DataGridView();
        Label label26 = new Label();
        Button buttonVulSave = new Button();
        Button buttonVulAnuleaza = new Button();
        CheckedListBox checkedListBoxVul = new CheckedListBox();
        Label label25 = new Label();
        Label label24 = new Label();
        Label label23 = new Label();
        ComboBox comboBoxNivel = new ComboBox();
        TextBox textBoxVul = new TextBox();
        ComboBox comboBoxNomVul = new ComboBox();
        Label label22 = new Label();
        Label label21 = new Label();
        Label label20 = new Label();
        DataGridViewTextBoxColumn Bun = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn Vulnerabilitate = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn Nivel = new DataGridViewTextBoxColumn();
        public PanelVulnerabilitati()
        {

        }

        private void buildUI()
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(this.dataGridViewVulnerabilitati);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.buttonVulSave);
            this.Controls.Add(this.buttonVulAnuleaza);
            this.Controls.Add(this.checkedListBoxVul);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.textBoxVul);
            this.Controls.Add(this.comboBoxNomVul);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Location = new System.Drawing.Point(162, 93);
            this.Name = "panelVulnerabilitati";
            this.Size = new System.Drawing.Size(793, 396);
            this.TabIndex = 5;
        }

        private void appendToUI()
        {
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVulnerabilitati)).BeginInit();


            // 
            // dataGridViewVulnerabilitati
            // 
            dataGridViewVulnerabilitati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVulnerabilitati.Columns.AddRange(new DataGridViewColumn[] {
            Bun,
            Vulnerabilitate,
            Nivel});
            dataGridViewVulnerabilitati.Location = new System.Drawing.Point(-2, 184);
            dataGridViewVulnerabilitati.Name = "dataGridViewVulnerabilitati";
            dataGridViewVulnerabilitati.RowTemplate.Height = 25;
            dataGridViewVulnerabilitati.Size = new System.Drawing.Size(793, 210);
            dataGridViewVulnerabilitati.TabIndex = 13;
            // 
            // Bun
            // 
            Bun.HeaderText = "Bun";
            Bun.Name = "Bun";
            // 
            // Vulnerabilitate
            // 
            Vulnerabilitate.HeaderText = "Vulnerabilitate";
            Vulnerabilitate.Name = "Vulnerabilitate";
            // 
            // Nivel
            // 
            Nivel.HeaderText = "Nivel";
            Nivel.Name = "Nivel";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(4, 166);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(80, 15);
            label26.TabIndex = 12;
            label26.Text = "Vulnerabilitati";
            // 
            // buttonVulSave
            // 
            buttonVulSave.Location = new System.Drawing.Point(614, 142);
            buttonVulSave.Name = "buttonVulSave";
            buttonVulSave.Size = new System.Drawing.Size(75, 23);
            buttonVulSave.TabIndex = 11;
            buttonVulSave.Text = "Salveaza";
            buttonVulSave.UseVisualStyleBackColor = true;
            // 
            // buttonVulAnuleaza
            // 
            buttonVulAnuleaza.Location = new System.Drawing.Point(695, 142);
            buttonVulAnuleaza.Name = "buttonVulAnuleaza";
            buttonVulAnuleaza.Size = new System.Drawing.Size(75, 23);
            buttonVulAnuleaza.TabIndex = 10;
            buttonVulAnuleaza.Text = "Anuleaza";
            buttonVulAnuleaza.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxVul
            // 
            checkedListBoxVul.FormattingEnabled = true;
            checkedListBoxVul.Items.AddRange(new object[] {
            "Furnizori",
            "Imaginea organizatiei"});
            checkedListBoxVul.Location = new System.Drawing.Point(524, 60);
            checkedListBoxVul.Name = "checkedListBoxVul";
            checkedListBoxVul.Size = new System.Drawing.Size(246, 76);
            checkedListBoxVul.TabIndex = 9;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(473, 63);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(45, 15);
            label25.TabIndex = 8;
            label25.Text = "Bunuri:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(122, 121);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(37, 15);
            label24.TabIndex = 7;
            label24.Text = "Nivel:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(73, 91);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(86, 15);
            label23.TabIndex = 6;
            label23.Text = "Vulnerabilitate:";
            // 
            // comboBoxNivel
            // 
            comboBoxNivel.FormattingEnabled = true;
            comboBoxNivel.Items.AddRange(new object[] {
            "Mic",
            "Mediu",
            "Mare"});
            comboBoxNivel.Location = new System.Drawing.Point(165, 117);
            comboBoxNivel.Name = "comboBoxNivel";
            comboBoxNivel.Size = new System.Drawing.Size(258, 23);
            comboBoxNivel.TabIndex = 5;
            // 
            // textBoxVul
            // 
            textBoxVul.Location = new System.Drawing.Point(165, 88);
            textBoxVul.Name = "textBoxVul";
            textBoxVul.Size = new System.Drawing.Size(258, 23);
            textBoxVul.TabIndex = 4;
            // 
            // comboBoxNomVul
            // 
            comboBoxNomVul.FormattingEnabled = true;
            comboBoxNomVul.Location = new System.Drawing.Point(165, 58);
            comboBoxNomVul.Name = "comboBoxNomVul";
            comboBoxNomVul.Size = new System.Drawing.Size(258, 23);
            comboBoxNomVul.TabIndex = 3;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(4, 61);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(155, 15);
            label22.TabIndex = 2;
            label22.Text = "Nomenclator vulnerabilitati:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(10, 33);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(174, 15);
            label21.TabIndex = 1;
            label21.Text = "Adaugare/editare vulnerabilitati";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label20.Location = new System.Drawing.Point(10, 9);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(190, 20);
            label20.TabIndex = 0;
            label20.Text = "Identificare vulnerabilitati";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVulnerabilitati)).EndInit();
        }
    }
}
