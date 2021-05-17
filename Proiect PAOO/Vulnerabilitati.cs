using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect_PAOO
{
    public partial class Vulnerabilitati : DefaultPanel
    {
        public int editID = -1;
        public Vulnerabilitati()
        {
            InitializeComponent();
            fillTable();
            comboBoxNivel.SelectedIndex = 0;
            FillSle();
        }

        private void comboBoxNomVul_SelectedIndexChanged(object sender, EventArgs e)
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
                query = "SELECT * FROM `vulnerabilitati`";
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

                dataGridViewVulnerabilitati.DataSource = dt;
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

        private void FillSle() {

            string query;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd;

            Kernel con = new Kernel();
            try
            {
                con.OpenConnection();
                //create a query for retrieving data in the database.
                query = "SELECT * FROM `bunuri`";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                //initialize new Sql data adapter
                //fetching query in the database.
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read()) {
                    checkedListBoxVul.Items.Add(new Bunuri(Int16.Parse(dataReader["cod_bun"].ToString()), dataReader["nume_bun"].ToString()));
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
        private void dataGridViewVulnerabilitati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewVulnerabilitati.CurrentCell.RowIndex;
            int columnindex = dataGridViewVulnerabilitati.CurrentCell.ColumnIndex;
            int codVul = Int16.Parse(dataGridViewVulnerabilitati.Rows[rowindex].Cells["cod_vulnerabilitate"].Value.ToString());

            // cellValue = dataGridViewVulnerabilitati.Rows[rowindex];
            textBoxVul.Text = dataGridViewVulnerabilitati.Rows[rowindex].Cells["vulnerabilitate"].Value.ToString();


            for (int i = 0; i < comboBoxNivel.Items.Count; ++i)
            {
                string s = comboBoxNivel.Items[i].ToString();

                if (s == dataGridViewVulnerabilitati.Rows[rowindex].Cells["nivel"].Value.ToString())
                {
                    comboBoxNivel.SelectedIndex = i;
                }
            }

            for (int i = 0; i < checkedListBoxVul.Items.Count; ++i)
            {
                checkedListBoxVul.SetItemChecked(i, false);
            }

            for (int i = 0; i < checkedListBoxVul.Items.Count; ++i)
            {
                Bunuri s = (Bunuri)checkedListBoxVul.Items[i];

                if (s.Id == Int16.Parse(dataGridViewVulnerabilitati.Rows[rowindex].Cells["cod_bun"].Value.ToString()))
                {
                    checkedListBoxVul.SetItemChecked(i, true);
                    break;
                }
            }

           this.editID = codVul;
            label21.Text = "Editare";

        }

        private void buttonVulAnuleaza_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        public void cleanForm() {
            textBoxVul.Text = "";
            comboBoxNivel.SelectedIndex = 0;
            for (int i = 0; i < checkedListBoxVul.Items.Count; ++i)
            {
                checkedListBoxVul.SetItemChecked(i, false);
            }

            this.editID = -1;
            label21.Text = "Adaugare";
        }

        private void textBoxVul_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxVul_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonVulSave_Click(object sender, EventArgs e)
        {

            if (this.editID != -1) //update
            {
                this.update();
            }
            else //insert
            {
                this.insert();
            }
            fillTable();
        }


        override public void update() {
            MySqlDataAdapter da = new MySqlDataAdapter();
            Kernel con = new Kernel();

            try
            {
                MySqlCommand cmd;
                string query;

                con.OpenConnection();
                //create a query for retrieving data in the database.
                query = "UPDATE vulnerabilitati SET cod_bun = @cod_bun, vulnerabilitate = @vulnerabilitate, nivel = @nivel  WHERE cod_vulnerabilitate = @cod_vulnerabilitate";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@cod_bun", MySqlDbType.Int16).Value = ((Bunuri)checkedListBoxVul.CheckedItems[checkedListBoxVul.CheckedItems.Count - 1]).Id;
                cmd.Parameters.Add("@vulnerabilitate", MySqlDbType.VarChar).Value = textBoxVul.Text;
                cmd.Parameters.Add("@nivel", MySqlDbType.VarChar).Value = comboBoxNivel.Text;
                cmd.Parameters.Add("@cod_vulnerabilitate", MySqlDbType.Int16).Value = this.editID;
                cmd.ExecuteNonQuery();
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

        override public void insert()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            Kernel con = new Kernel();

            try
            {
                MySqlCommand cmd;
                string query;

                con.OpenConnection();
                //create a query for retrieving data in the database.
                query = "INSERT INTO vulnerabilitati (cod_bun, vulnerabilitate, nivel) VALUES (@cod_bun, @vulnerabilitate, @nivel)";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@cod_bun", MySqlDbType.Int16).Value = ((Bunuri)checkedListBoxVul.CheckedItems[checkedListBoxVul.CheckedItems.Count - 1]).Id;
                cmd.Parameters.Add("@vulnerabilitate", MySqlDbType.VarChar).Value = textBoxVul.Text;
                cmd.Parameters.Add("@nivel", MySqlDbType.VarChar).Value = comboBoxNivel.Text;
                cmd.ExecuteNonQuery();
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
        override public void deleteCurrentCell() {
            if (this.editID == -1) {
                MessageBox.Show("Nothing selected");
                return;
            }

            MySqlDataAdapter da = new MySqlDataAdapter();
            Kernel con = new Kernel();
            try
            {
                MySqlCommand cmd;
                string query;

                con.OpenConnection();
                //create a query for retrieving data in the database.
                query = "DELETE FROM vulnerabilitati WHERE cod_vulnerabilitate = @cod_vulnerabilitate";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@cod_vulnerabilitate", MySqlDbType.Int16).Value = this.editID;
                cmd.ExecuteNonQuery();
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

            fillTable();
            cleanForm();
        }

        override public void addNewCell()
        {
            this.editID = -1;
            label21.Text = "Adaugare";
        }

        override public void refresh() {
            fillTable();
            comboBoxNivel.SelectedIndex = 0;
            FillSle();
        }
    }
}
