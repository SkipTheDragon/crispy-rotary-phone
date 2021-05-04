using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Proiect_PAOO
{
    class PanelAmenintari : System.Windows.Forms.Panel
    {
        Button buttonAmenAnuleaza = new System.Windows.Forms.Button();
        Button buttonAmenSave = new System.Windows.Forms.Button();
        DataGridView dataGridViewAmenintari = new System.Windows.Forms.DataGridView();
        DataGridViewTextBoxColumn Amenintare = new System.Windows.Forms.DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn Bunuri = new System.Windows.Forms.DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn NivelMinim = new System.Windows.Forms.DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn NivelMaxim = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Label label19 = new System.Windows.Forms.Label();
        Label label18 = new System.Windows.Forms.Label();
        CheckedListBox checkedListBoxBunuri = new System.Windows.Forms.CheckedListBox();
        Label label17 = new System.Windows.Forms.Label();
        ComboBox comboBoxNivMax = new System.Windows.Forms.ComboBox();
        ComboBox comboBoxNivMin = new System.Windows.Forms.ComboBox();
        TextBox textBoxAmenNume = new System.Windows.Forms.TextBox();
        Label label16 = new System.Windows.Forms.Label();
        Label label15 = new System.Windows.Forms.Label();
        ComboBox comboBoxNomAmen = new System.Windows.Forms.ComboBox();
        Label label14 = new System.Windows.Forms.Label();
        Label label13 = new System.Windows.Forms.Label();
        Label label12 = new System.Windows.Forms.Label();

        public void buildUI() {
            // 
            // panelAmenintari
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.buttonAmenAnuleaza);
            this.Controls.Add(this.buttonAmenSave);
            this.Controls.Add(this.dataGridViewAmenintari);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkedListBoxBunuri);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxNivMax);
            this.Controls.Add(this.comboBoxNivMin);
            this.Controls.Add(this.textBoxAmenNume);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxNomAmen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Location = new System.Drawing.Point(162, 93);
            this.Name = "panelAmenintari";
            this.Size = new System.Drawing.Size(793, 396);
            this.TabIndex = 4;
        }

        public void appendDataToUI()
        {
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmenintari)).BeginInit();

            // 
            // buttonAmenAnuleaza
            // 
            this.buttonAmenAnuleaza.Location = new System.Drawing.Point(673, 150);
            this.buttonAmenAnuleaza.Name = "buttonAmenAnuleaza";
            this.buttonAmenAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.buttonAmenAnuleaza.TabIndex = 15;
            this.buttonAmenAnuleaza.Text = "Anuleaza";
            this.buttonAmenAnuleaza.UseVisualStyleBackColor = true;
            // 
            // buttonAmenSave
            // 
            this.buttonAmenSave.Location = new System.Drawing.Point(592, 150);
            this.buttonAmenSave.Name = "buttonAmenSave";
            this.buttonAmenSave.Size = new System.Drawing.Size(75, 23);
            this.buttonAmenSave.TabIndex = 14;
            this.buttonAmenSave.Text = "Salveaza";
            this.buttonAmenSave.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAmenintari
            // 
            this.dataGridViewAmenintari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAmenintari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amenintare,
            this.Bunuri,
            this.NivelMinim,
            this.NivelMaxim});
            this.dataGridViewAmenintari.Location = new System.Drawing.Point(0, 198);
            this.dataGridViewAmenintari.Name = "dataGridViewAmenintari";
            this.dataGridViewAmenintari.RowTemplate.Height = 25;
            this.dataGridViewAmenintari.Size = new System.Drawing.Size(793, 196);
            this.dataGridViewAmenintari.TabIndex = 13;
            // 
            // Amenintare
            // 
            this.Amenintare.HeaderText = "Amenintare";
            this.Amenintare.Name = "Amenintare";
            // 
            // Bunuri
            // 
            this.Bunuri.HeaderText = "Bunuri";
            this.Bunuri.Name = "Bunuri";
            // 
            // NivelMinim
            // 
            this.NivelMinim.HeaderText = "Nivel Minim";
            this.NivelMinim.Name = "NivelMinim";
            // 
            // NivelMaxim
            // 
            this.NivelMaxim.HeaderText = "Nivel Maxim";
            this.NivelMaxim.Name = "NivelMaxim";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(0, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 15);
            this.label19.TabIndex = 12;
            this.label19.Text = "Amenintari";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(486, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "Bunuri:";
            // 
            // checkedListBoxBunuri
            // 
            this.checkedListBoxBunuri.FormattingEnabled = true;
            this.checkedListBoxBunuri.Items.AddRange(new object[] {
            "Furnizori",
            "Imaginea organizatiei"});
            this.checkedListBoxBunuri.Location = new System.Drawing.Point(537, 58);
            this.checkedListBoxBunuri.Name = "checkedListBoxBunuri";
            this.checkedListBoxBunuri.Size = new System.Drawing.Size(211, 76);
            this.checkedListBoxBunuri.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(67, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "Nivel maxim:";
            // 
            // comboBoxNivMax
            // 
            this.comboBoxNivMax.FormattingEnabled = true;
            this.comboBoxNivMax.Items.AddRange(new object[] {
            "Mic",
            "Mediu",
            "Mare"});
            this.comboBoxNivMax.Location = new System.Drawing.Point(150, 148);
            this.comboBoxNivMax.Name = "comboBoxNivMax";
            this.comboBoxNivMax.Size = new System.Drawing.Size(240, 23);
            this.comboBoxNivMax.TabIndex = 8;
            // 
            // comboBoxNivMin
            // 
            this.comboBoxNivMin.FormattingEnabled = true;
            this.comboBoxNivMin.Items.AddRange(new object[] {
            "Mic",
            "Mediu",
            "Mare"});
            this.comboBoxNivMin.Location = new System.Drawing.Point(150, 119);
            this.comboBoxNivMin.Name = "comboBoxNivMin";
            this.comboBoxNivMin.Size = new System.Drawing.Size(240, 23);
            this.comboBoxNivMin.TabIndex = 7;
            // 
            // textBoxAmenNume
            // 
            this.textBoxAmenNume.Location = new System.Drawing.Point(150, 90);
            this.textBoxAmenNume.Name = "textBoxAmenNume";
            this.textBoxAmenNume.Size = new System.Drawing.Size(240, 23);
            this.textBoxAmenNume.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(69, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nivel minim:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(101, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Nume:";
            // 
            // comboBoxNomAmen
            // 
            this.comboBoxNomAmen.FormattingEnabled = true;
            this.comboBoxNomAmen.Location = new System.Drawing.Point(150, 58);
            this.comboBoxNomAmen.Name = "comboBoxNomAmen";
            this.comboBoxNomAmen.Size = new System.Drawing.Size(240, 23);
            this.comboBoxNomAmen.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Nomenclator amenintari:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(10, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Adaugare/Elimiare amenintari";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(10, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Identificare amenintari";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmenintari)).EndInit();

        }
    }
}
