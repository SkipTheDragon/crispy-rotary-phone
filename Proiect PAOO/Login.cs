using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Proiect_PAOO
{
    public partial class Login : Form
    {
        Thread thread;
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openHome);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openHome()
        {
            Application.Run(new Home());
        }
    }
}
