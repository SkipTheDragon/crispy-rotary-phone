﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect_PAOO
{
    public partial class Riscuri : UserControl
    {
        public Riscuri()
        {
            InitializeComponent();
            fillTable();
        }

        private void Riscuri_Load(object sender, EventArgs e)
        {

        }

        private void fillTable()
        {
            string query;
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt;
            MySqlCommand cmd;

            Kernel con = new Kernel();
            try
            {
                con.OpenConnection();
                //create a query for retrieving data in the database.
                query = "SELECT * FROM `riscuri`";
                //initialize new Sql commands
                cmd = new MySqlCommand();
                //hold the data to be executed.
                cmd.Connection = con.connection;
                cmd.CommandText = query;
                //initialize new Sql data adapter
                //fetching query in the database.
                da.SelectCommand = cmd;
                //initialize new datatable
                dt = new DataTable();
                //refreshes the rows in specified range in the datasource.
                da.Fill(dt);

                dataGridViewRisc.DataSource = dt;
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
    }
}
