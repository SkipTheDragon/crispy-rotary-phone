using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAOO
{
    public partial class Home : Form
    {
        public static DefaultPanel currentPanel;
        public Home()
        {
            InitializeComponent();
            Home.currentPanel = panelBunuri;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        
        
        private void panelAmenitati_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxDomeniu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelRiscuri_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            panelBunuri.Visible = false;
            panelAmenintari.Visible = false;
            panelVulnerabilitati.Visible = false;
            panelRiscuri.Visible = false;
            panelTratare.Visible = false;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    panelBunuri.Visible = true;
                    labelCurrent.Text = "Identificare bunuri";
                    break;
                case 1:
                    panelAmenintari.Visible = true;
                    labelCurrent.Text = "Identificare amenintari";
                    break;
                case 2:
                    panelVulnerabilitati.Visible = true;
                    labelCurrent.Text = "Identificare vulnerabilitati";
                    /*Home.currentPanel = panelVulnerabilitati;*/
                    break;
                case 3:
                    panelRiscuri.Visible = true;
                    labelCurrent.Text = "Identificare riscuri";
                    /*Home.currentPanel = panelRiscuri;*/
                    break;
                case 4:
                    panelTratare.Visible = true;
                    labelCurrent.Text = "Tratare riscuri si identificare contramasuri";
                    break;
                default:
                    panelBunuri.Visible = true;
                    break;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            currentPanel.addNewCell();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            currentPanel.deleteCurrentCell();
        }

        private void panelVulnerabilitati_Load(object sender, EventArgs e)
        {

        }
    }
}
