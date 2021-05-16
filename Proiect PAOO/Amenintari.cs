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
    public partial class Amenintari : DefaultPanel
    {
        public int editID;
        public Amenintari()
        {
            InitializeComponent();
            comboBoxNivMin.SelectedIndex = 0;
            comboBoxNivMax.SelectedIndex = 0;
            fillTable();
            fillSle();
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
                query = "SELECT * FROM `amenintari`";
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

                dataGridViewAmenintari.DataSource = dt;
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

        public void clearForm()
        {
            textBoxAmenNume.Text = "";
            comboBoxNivMin.SelectedIndex = 0;
            comboBoxNivMax.SelectedIndex = 0;
            for (int i = 0; i < checkedListBoxBunuri.Items.Count; ++i)
            {
                checkedListBoxBunuri.SetItemChecked(i, false);
            }

            this.editID = -1;
            label13.Text = "Adaugare";
        }

        private void buttonAmenAnuleaza_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void fillSle()
        {
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
                while (dataReader.Read())
                {
                    checkedListBoxBunuri.Items.Add(new Bunuri(Int16.Parse(dataReader["cod_bun"].ToString()), dataReader["nume_bun"].ToString()));
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

        private void dataGridViewAmenintari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewAmenintari.CurrentCell.RowIndex;
            int columnindex = dataGridViewAmenintari.CurrentCell.ColumnIndex;
            int codAmen = Int16.Parse(dataGridViewAmenintari.Rows[rowindex].Cells["cod_amenintare"].Value.ToString());

            // cellValue = dataGridViewVulnerabilitati.Rows[rowindex];
            textBoxAmenNume.Text = dataGridViewAmenintari.Rows[rowindex].Cells["amenintare"].Value.ToString();
            comboBoxNivMin.SelectedItem = dataGridViewAmenintari.Rows[rowindex].Cells["nivel_minim"].Value.ToString();
            comboBoxNivMax.SelectedItem = dataGridViewAmenintari.Rows[rowindex].Cells["nivel_maxim"].Value.ToString();

            for (int i = 0; i < checkedListBoxBunuri.Items.Count; ++i)
            {
                checkedListBoxBunuri.SetItemChecked(i, false);
            }

            for (int i = 0; i < checkedListBoxBunuri.Items.Count; ++i)
            {
                Bunuri s = (Bunuri)checkedListBoxBunuri.Items[i];

                if (s.Id == Int16.Parse(dataGridViewAmenintari.Rows[rowindex].Cells["cod_bun"].Value.ToString()))
                {
                    checkedListBoxBunuri.SetItemChecked(i, true);
                    break;
                }
            }

            this.editID = codAmen;
            label13.Text = "Editare " + this.editID;
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
                query = "INSERT INTO amenintari (amenintare, cod_bun, nivel_minim, nivel_maxim) VALUES (@amenintare, @cod_bun, @nivel_minim, @nivel_maxim)";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@amenintare", MySqlDbType.VarChar).Value = textBoxAmenNume.Text;
                cmd.Parameters.Add("@cod_bun", MySqlDbType.Int16).Value = ((Bunuri)checkedListBoxBunuri.CheckedItems[checkedListBoxBunuri.CheckedItems.Count - 1]).Id;
                cmd.Parameters.Add("@nivel_minim", MySqlDbType.VarChar).Value = comboBoxNivMin.Text;
                cmd.Parameters.Add("@nivel_maxim", MySqlDbType.VarChar).Value = comboBoxNivMax.Text;
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

        override public void update()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            Kernel con = new Kernel();

            try
            {
                MySqlCommand cmd;
                string query;

                con.OpenConnection();
                //create a query for retrieving data in the database.
                query = "UPDATE amenintari SET amenintare = @amenintare, cod_bun = @cod_bun, nivel_minim = @nivel_minim, nivel_maxim = @nivel_maxim  WHERE cod_amenintare = @cod_amenintare";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@amenintare", MySqlDbType.VarChar).Value = textBoxAmenNume.Text;
                cmd.Parameters.Add("@cod_bun", MySqlDbType.Int16).Value = ((Bunuri)checkedListBoxBunuri.CheckedItems[checkedListBoxBunuri.CheckedItems.Count - 1]).Id;
                cmd.Parameters.Add("@nivel_minim", MySqlDbType.VarChar).Value = comboBoxNivMin.Text;
                cmd.Parameters.Add("@nivel_maxim", MySqlDbType.VarChar).Value = comboBoxNivMax.Text;
                cmd.Parameters.Add("@cod_amenintare", MySqlDbType.Int16).Value = this.editID;
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

        override public void deleteCurrentCell()
        {
            if (this.editID == -1)
            {
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
                query = "DELETE FROM amenintari WHERE cod_amenintare = @cod_amenintare";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@cod_amenintare", MySqlDbType.Int16).Value = this.editID;
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
            clearForm();
        }

        override public void addNewCell()
        {
            this.editID = -1;
            label13.Text = "Adaugare";
        }

        override public void refresh()
        {
            fillTable();
            comboBoxNivMin.SelectedIndex = 0;
            comboBoxNivMax.SelectedIndex = 0;
            fillSle();
        }

        private void buttonAmenSave_Click(object sender, EventArgs e)
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
            clearForm();
        }
    }
}
