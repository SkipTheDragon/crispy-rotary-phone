using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_PAOO
{
    class PanelBunuri : System.Windows.Forms.Panel
    {
        private System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
        private System.Windows.Forms.DataGridView dataGridViewBunuri = new System.Windows.Forms.DataGridView();
        private System.Windows.Forms.Splitter splitter1 = new System.Windows.Forms.Splitter();
        private System.Windows.Forms.Button buttonBunAnuleaza = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button buttonBunSave = new System.Windows.Forms.Button();
        private System.Windows.Forms.Label label7 = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label label6 = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
        private System.Windows.Forms.TextBox textBoxBunNume = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.ComboBox comboBoxImMin = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.ComboBox comboBoxNomendator = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.Label label8 = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label label11 = new System.Windows.Forms.Label();
        private System.Windows.Forms.TextBox textBoxBunCost = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.Label label10 = new System.Windows.Forms.Label();
        private System.Windows.Forms.ComboBox comboBoxDomeniu = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.Label label9 = new System.Windows.Forms.Label();
        private System.Windows.Forms.TextBox textBoxBunCostRed = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.ComboBox comboBoxImMax = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpactMinim = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpactMaxim = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn Domeniu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn CostReducere = new System.Windows.Forms.DataGridViewTextBoxColumn();

        public void buildUI() {
            BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Controls.Add(this.buttonBunAnuleaza);
            Controls.Add(this.buttonBunSave);
            Controls.Add(this.textBoxBunCostRed);
            Controls.Add(this.label11);
            Controls.Add(this.textBoxBunCost);
            Controls.Add(this.label10);
            Controls.Add(this.comboBoxDomeniu);
            Controls.Add(this.label9);
            Controls.Add(this.comboBoxImMax);
            Controls.Add(this.label8);
            Controls.Add(this.textBoxBunNume);
            Controls.Add(this.comboBoxImMin);
            Controls.Add(this.comboBoxNomendator);
            Controls.Add(this.label7);
            Controls.Add(this.label6);
            Controls.Add(this.label5);
            Controls.Add(this.label4);
            Controls.Add(this.label3);
            Controls.Add(this.splitter1);
            Controls.Add(this.label2);
            Controls.Add(this.dataGridViewBunuri);
            Location = new System.Drawing.Point(162, 93);
            Name = "panelBunuri";
            Size = new System.Drawing.Size(793, 396);
            TabIndex = 3;
        }

        public void appendDataToUI() {
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBunuri)).BeginInit();

            // 
            // buttonBunAnuleaza
            // 
            this.buttonBunAnuleaza.Location = new System.Drawing.Point(705, 115);
            this.buttonBunAnuleaza.Name = "buttonBunAnuleaza";
            this.buttonBunAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.buttonBunAnuleaza.TabIndex = 20;
            this.buttonBunAnuleaza.Text = "Anuleaza";
            this.buttonBunAnuleaza.UseVisualStyleBackColor = true;
            // 
            // buttonBunSave
            // 
            this.buttonBunSave.Location = new System.Drawing.Point(619, 115);
            this.buttonBunSave.Name = "buttonBunSave";
            this.buttonBunSave.Size = new System.Drawing.Size(75, 23);
            this.buttonBunSave.TabIndex = 19;
            this.buttonBunSave.Text = "Salveaza";
            this.buttonBunSave.UseVisualStyleBackColor = true;
            // 
            // textBoxBunCostRed
            // 
            this.textBoxBunCostRed.Location = new System.Drawing.Point(724, 86);
            this.textBoxBunCostRed.Name = "textBoxBunCostRed";
            this.textBoxBunCostRed.Size = new System.Drawing.Size(56, 23);
            this.textBoxBunCostRed.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(619, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cost de reducere:";
            // 
            // textBoxBunCost
            // 
            this.textBoxBunCost.Location = new System.Drawing.Point(550, 83);
            this.textBoxBunCost.Name = "textBoxBunCost";
            this.textBoxBunCost.Size = new System.Drawing.Size(56, 23);
            this.textBoxBunCost.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 15;
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
            this.comboBoxDomeniu.Location = new System.Drawing.Point(550, 58);
            this.comboBoxDomeniu.Name = "comboBoxDomeniu";
            this.comboBoxDomeniu.Size = new System.Drawing.Size(230, 23);
            this.comboBoxDomeniu.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 13;
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
            this.comboBoxImMax.Location = new System.Drawing.Point(341, 108);
            this.comboBoxImMax.Name = "comboBoxImMax";
            this.comboBoxImMax.Size = new System.Drawing.Size(80, 23);
            this.comboBoxImMax.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Impact maxim:";
            // 
            // textBoxBunNume
            // 
            this.textBoxBunNume.Location = new System.Drawing.Point(126, 83);
            this.textBoxBunNume.Name = "textBoxBunNume";
            this.textBoxBunNume.Size = new System.Drawing.Size(295, 23);
            this.textBoxBunNume.TabIndex = 10;
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
            this.comboBoxImMin.Location = new System.Drawing.Point(126, 108);
            this.comboBoxImMin.Name = "comboBoxImMin";
            this.comboBoxImMin.Size = new System.Drawing.Size(80, 23);
            this.comboBoxImMin.TabIndex = 9;
            // 
            // comboBoxNomendator
            // 
            this.comboBoxNomendator.FormattingEnabled = true;
            this.comboBoxNomendator.Location = new System.Drawing.Point(126, 58);
            this.comboBoxNomendator.Name = "comboBoxNomendator";
            this.comboBoxNomendator.Size = new System.Drawing.Size(295, 23);
            this.comboBoxNomendator.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Impact minim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nume:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nomendator bunuri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adaugare/editare bunuri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identificare bunuri";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 392);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bunuri";

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
            this.dataGridViewBunuri.Location = new System.Drawing.Point(1, 166);
            this.dataGridViewBunuri.Name = "dataGridViewBunuri";
            this.dataGridViewBunuri.RowTemplate.Height = 25;
            this.dataGridViewBunuri.Size = new System.Drawing.Size(792, 226);
            this.dataGridViewBunuri.TabIndex = 0;

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBunuri)).EndInit();

        }
    }
}
