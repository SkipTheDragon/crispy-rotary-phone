using MySql.Data.MySqlClient;
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
            textBoxUser.Text = "admin";
            textBoxPass.Text = "admin";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "" && textBoxPass.Text != "")
            {
                string query;
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd;
                Kernel con = new Kernel();
                try
                {
                    con.OpenConnection();
                    //create a query for retrieving data in the database.
                    query = "SELECT * FROM `organizatie` WHERE user = @usr AND parola = @pass";
                    //initialize new Sql commands
                    cmd = new MySqlCommand
                    {
                        //hold the data to be executed.
                        Connection = con.connection,
                        CommandText = query
                    };
                    cmd.Parameters.Add("@usr", MySqlDbType.VarChar).Value = textBoxUser.Text;
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPass.Text;
                    MySqlDataReader row;
                    row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {

                        MessageBox.Show("Logat cu username " + textBoxUser.Text);
                        this.Close();
                        thread = new Thread(openHome);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                    else
                    {
                        MessageBox.Show("Date Gresite!");
                    }
                }
                catch (Exception ex)
                {
                    //catching error
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    da.Dispose();
                    con.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Introdueceti datele pentru logare!");
            }
            
        }

        private void openHome()
        {
            Application.Run(new Home());
        }
    }
}
