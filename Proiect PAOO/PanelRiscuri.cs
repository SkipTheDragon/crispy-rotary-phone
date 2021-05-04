using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Proiect_PAOO
{
    class PanelRiscuri : Panel
    {
        DataGridView dataGridViewRisc = new DataGridView();
        Label label36 = new Label();
        Button buttonRiscDiag = new Button();
        Button buttonRiscIdent = new Button();
        Button buttonRiscAnuleaza = new Button();
        Button buttonRiscSave = new Button();
        TextBox textBoxRiscProb = new TextBox();
        TextBox textBoxRiscNivel = new TextBox();
        TextBox textBoxRiscNatura = new TextBox();
        Label label35 = new Label();
        Label label34 = new Label();
        Label label33 = new Label();
        TextBox textBoxRiscNume = new TextBox();
        Label label32 = new Label();
        Label label31 = new Label();
        Label label30 = new Label();
        TextBox textBoxRiscVul2 = new TextBox();
        TextBox textBoxRiscAmen2 = new TextBox();
        TextBox textBoxRiscVul = new TextBox();
        TextBox textBoxRiscAmen = new TextBox();
        TextBox textBoxRiscBun2 = new TextBox();
        TextBox textBoxRiscBun = new TextBox();
        Label label29 = new Label();
        Label label28 = new Label();
        Label label27 = new Label();
        DataGridViewTextBoxColumn NumeRisc = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn NivelulRiscului = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn ProbAparitie = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn NaturaRiscului = new DataGridViewTextBoxColumn();

        public PanelRiscuri()
        {

        }

        private void buildUI()
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(dataGridViewRisc);
            this.Controls.Add(label36);
            this.Controls.Add(buttonRiscDiag);
            this.Controls.Add(buttonRiscIdent);
            this.Controls.Add(buttonRiscAnuleaza);
            this.Controls.Add(buttonRiscSave);
            this.Controls.Add(textBoxRiscProb);
            this.Controls.Add(textBoxRiscNivel);
            this.Controls.Add(textBoxRiscNatura);
            this.Controls.Add(label35);
            this.Controls.Add(label34);
            this.Controls.Add(label33);
            this.Controls.Add(textBoxRiscNume);
            this.Controls.Add(label32);
            this.Controls.Add(label31);
            this.Controls.Add(label30);
            this.Controls.Add(textBoxRiscVul2);
            this.Controls.Add(textBoxRiscAmen2);
            this.Controls.Add(textBoxRiscVul);
            this.Controls.Add(textBoxRiscAmen);
            this.Controls.Add(textBoxRiscBun2);
            this.Controls.Add(textBoxRiscBun);
            this.Controls.Add(label29);
            this.Controls.Add(label28);
            this.Controls.Add(label27);
            this.Location = new System.Drawing.Point(162, 93);
            this.Name = "panelRiscuri";
            this.Size = new System.Drawing.Size(793, 396);
            this.TabIndex = 7;
        }

        private void appendToUI()
        {
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRisc)).BeginInit();
            // 
            // dataGridViewRisc
            // 
            dataGridViewRisc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRisc.Columns.AddRange(new DataGridViewColumn[] {
            NumeRisc,
            dataGridViewTextBoxColumn1,
            NivelulRiscului,
            ProbAparitie,
            NaturaRiscului});
            dataGridViewRisc.Location = new System.Drawing.Point(0, 287);
            dataGridViewRisc.Name = "dataGridViewRisc";
            dataGridViewRisc.RowTemplate.Height = 25;
            dataGridViewRisc.Size = new System.Drawing.Size(793, 109);
            dataGridViewRisc.TabIndex = 24;
            // 
            // NumeRisc
            // 
            NumeRisc.HeaderText = "Nume Risc";
            NumeRisc.Name = "NumeRisc";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Bun";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // NivelulRiscului
            // 
            NivelulRiscului.HeaderText = "Nivelul Riscului";
            NivelulRiscului.Name = "NivelulRiscului";
            // 
            // ProbAparitie
            // 
            ProbAparitie.HeaderText = "Probabilitatea de aparitie";
            ProbAparitie.Name = "ProbAparitie";
            // 
            // NaturaRiscului
            // 
            NaturaRiscului.HeaderText = "Natura Riscului";
            NaturaRiscului.Name = "NaturaRiscului";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new System.Drawing.Point(6, 269);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(42, 15);
            label36.TabIndex = 23;
            label36.Text = "Riscuri";
            // 
            // buttonRiscDiag
            // 
            buttonRiscDiag.AutoSize = true;
            buttonRiscDiag.Location = new System.Drawing.Point(124, 234);
            buttonRiscDiag.Name = "buttonRiscDiag";
            buttonRiscDiag.Size = new System.Drawing.Size(202, 25);
            buttonRiscDiag.TabIndex = 22;
            buttonRiscDiag.Text = "Vezi diagrama/probabilitate impact";
            buttonRiscDiag.UseVisualStyleBackColor = true;
            buttonRiscIdent.AutoSize = true;
            buttonRiscIdent.Location = new System.Drawing.Point(6, 232);
            buttonRiscIdent.Name = "buttonRiscIdent";
            buttonRiscIdent.Size = new System.Drawing.Size(101, 25);
            buttonRiscIdent.TabIndex = 21;
            buttonRiscIdent.Text = "Identifica riscuri";
            buttonRiscIdent.UseVisualStyleBackColor = true;
            buttonRiscAnuleaza.Location = new System.Drawing.Point(706, 186);
            buttonRiscAnuleaza.Name = "buttonRiscAnuleaza";
            buttonRiscAnuleaza.Size = new System.Drawing.Size(75, 23);
            buttonRiscAnuleaza.TabIndex = 20;
            buttonRiscAnuleaza.Text = "Anuleaza";
            buttonRiscAnuleaza.UseVisualStyleBackColor = true;
            buttonRiscSave.Location = new System.Drawing.Point(616, 186);
            buttonRiscSave.Name = "buttonRiscSave";
            buttonRiscSave.Size = new System.Drawing.Size(75, 23);
            buttonRiscSave.TabIndex = 19;
            buttonRiscSave.Text = "Salveaza";
            buttonRiscSave.UseVisualStyleBackColor = true;
            textBoxRiscProb.Location = new System.Drawing.Point(454, 193);
            textBoxRiscProb.Name = "textBoxRiscProb";
            textBoxRiscProb.Size = new System.Drawing.Size(104, 23);
            textBoxRiscProb.TabIndex = 18;
            textBoxRiscNivel.Location = new System.Drawing.Point(334, 193);
            textBoxRiscNivel.Name = "textBoxRiscNivel";
            textBoxRiscNivel.Size = new System.Drawing.Size(100, 23);
            textBoxRiscNivel.TabIndex = 17;
            // 
            // textBoxRiscNatura
            // 
            textBoxRiscNatura.Location = new System.Drawing.Point(227, 193);
            textBoxRiscNatura.Name = "textBoxRiscNatura";
            textBoxRiscNatura.Size = new System.Drawing.Size(87, 23);
            textBoxRiscNatura.TabIndex = 16;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new System.Drawing.Point(454, 175);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(109, 15);
            label35.TabIndex = 15;
            label35.Text = "Probab. de aparitie:";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new System.Drawing.Point(334, 175);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(88, 15);
            label34.TabIndex = 14;
            label34.Text = "Nivelul riscului:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new System.Drawing.Point(227, 175);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(87, 15);
            label33.TabIndex = 13;
            label33.Text = "Natura riscului:";
            // 
            // textBoxRiscNume
            // 
            textBoxRiscNume.Location = new System.Drawing.Point(6, 193);
            textBoxRiscNume.Name = "textBoxRiscNume";
            textBoxRiscNume.Size = new System.Drawing.Size(175, 23);
            textBoxRiscNume.TabIndex = 12;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new System.Drawing.Point(6, 175);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(64, 15);
            label32.TabIndex = 11;
            label32.Text = "Nume risc:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new System.Drawing.Point(605, 60);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(86, 15);
            label31.TabIndex = 10;
            label31.Text = "Vulnerabilitate:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new System.Drawing.Point(227, 60);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(72, 15);
            label30.TabIndex = 9;
            label30.Text = "Amenintare:";
            // 
            // textBoxRiscVul2
            // 
            textBoxRiscVul2.Location = new System.Drawing.Point(605, 108);
            textBoxRiscVul2.Multiline = true;
            textBoxRiscVul2.Name = "textBoxRiscVul2";
            textBoxRiscVul2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxRiscVul2.Size = new System.Drawing.Size(176, 54);
            textBoxRiscVul2.TabIndex = 8;
            // 
            // textBoxRiscAmen2
            // 
            textBoxRiscAmen2.Location = new System.Drawing.Point(227, 108);
            textBoxRiscAmen2.Multiline = true;
            textBoxRiscAmen2.Name = "textBoxRiscAmen2";
            textBoxRiscAmen2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxRiscAmen2.Size = new System.Drawing.Size(331, 54);
            textBoxRiscAmen2.TabIndex = 7;
            // 
            // textBoxRiscVul
            // 
            textBoxRiscVul.Location = new System.Drawing.Point(605, 79);
            textBoxRiscVul.Name = "textBoxRiscVul";
            textBoxRiscVul.Size = new System.Drawing.Size(176, 23);
            textBoxRiscVul.TabIndex = 6;
            // 
            // textBoxRiscAmen
            // 
            textBoxRiscAmen.Location = new System.Drawing.Point(227, 79);
            textBoxRiscAmen.Name = "textBoxRiscAmen";
            textBoxRiscAmen.Size = new System.Drawing.Size(331, 23);
            textBoxRiscAmen.TabIndex = 5;
            // 
            // textBoxRiscBun2
            // 
            textBoxRiscBun2.Location = new System.Drawing.Point(6, 108);
            textBoxRiscBun2.Multiline = true;
            textBoxRiscBun2.Name = "textBoxRiscBun2";
            textBoxRiscBun2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxRiscBun2.Size = new System.Drawing.Size(175, 54);
            textBoxRiscBun2.TabIndex = 4;
            // 
            // textBoxRiscBun
            // 
            textBoxRiscBun.Location = new System.Drawing.Point(6, 79);
            textBoxRiscBun.Name = "textBoxRiscBun";
            textBoxRiscBun.Size = new System.Drawing.Size(175, 23);
            textBoxRiscBun.TabIndex = 3;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new System.Drawing.Point(4, 61);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(31, 15);
            label29.TabIndex = 2;
            label29.Text = "Bun:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label28.Location = new System.Drawing.Point(10, 33);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(138, 15);
            label28.TabIndex = 1;
            label28.Text = "Vizualizare/editare riscuri";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label27.Location = new System.Drawing.Point(10, 9);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(136, 20);
            label27.TabIndex = 0;
            label27.Text = "Identificare riscuri";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRisc)).EndInit();
        }
    }
}
