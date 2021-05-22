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
    public partial class Bun : DefaultPanel
    {
        public int editID;
        public Bun()
        {
            InitializeComponent();
            comboBoxDomeniu.SelectedIndex = 0;
            comboBoxImMax.SelectedIndex = 0;
            comboBoxImMin.SelectedIndex = 0;
            fillTable();
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
                query = "SELECT * FROM `bunuri`";
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

                dataGridViewBunuri.DataSource = dt;
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

        private void buttonBunAnuleaza_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            textBoxBunNume.Text = "";
            comboBoxImMin.SelectedIndex = 0;
            comboBoxImMax.SelectedIndex = 0;
            comboBoxDomeniu.SelectedIndex = 0;
            textBoxBunCost.Text = "";
            textBoxBunCostRed.Text = "";

            this.editID = -1;
            label4.Text = "Adaugare";
        }

        private void dataGridViewBunuri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clearForm();
            int rowindex = dataGridViewBunuri.CurrentCell.RowIndex;
            int columnindex = dataGridViewBunuri.CurrentCell.ColumnIndex;
            int codBun = Int16.Parse(dataGridViewBunuri.Rows[rowindex].Cells["cod_bun"].Value.ToString());

            // cellValue = dataGridViewVulnerabilitati.Rows[rowindex];
            textBoxBunNume.Text = dataGridViewBunuri.Rows[rowindex].Cells["nume_bun"].Value.ToString();
            comboBoxDomeniu.SelectedItem = dataGridViewBunuri.Rows[rowindex].Cells["domeniu_categorie"].Value.ToString();
            comboBoxImMin.SelectedItem = dataGridViewBunuri.Rows[rowindex].Cells["impact_minim"].Value.ToString();
            comboBoxImMax.SelectedItem = dataGridViewBunuri.Rows[rowindex].Cells["impact_maxim"].Value.ToString();
            textBoxBunCost.Text = dataGridViewBunuri.Rows[rowindex].Cells["cost"].Value.ToString();
            textBoxBunCostRed.Text = dataGridViewBunuri.Rows[rowindex].Cells["cost_de_reducere"].Value.ToString();

            this.editID = codBun;
            label4.Text = "Editare";
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
                query = "INSERT INTO bunuri (nume_bun, cod_proiect, impact_minim, impact_maxim, domeniu_categorie, cost, cost_de_reducere) VALUES (@nume_bun, @cod_proiect, @impact_minim, @impact_maxim, @domeniu_categorie, @cost, @cost_de_reducere)";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@nume_bun", MySqlDbType.VarChar).Value = textBoxBunNume.Text;
                cmd.Parameters.Add("@cod_proiect", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("@impact_minim", MySqlDbType.Int16).Value = Int16.Parse(comboBoxImMin.Text);
                cmd.Parameters.Add("@impact_maxim", MySqlDbType.Int16).Value = Int16.Parse(comboBoxImMax.Text);
                cmd.Parameters.Add("@domeniu_categorie", MySqlDbType.VarChar).Value = comboBoxDomeniu.Text;
                cmd.Parameters.Add("@cost", MySqlDbType.Float).Value = float.Parse(textBoxBunCost.Text);
                cmd.Parameters.Add("@cost_de_reducere", MySqlDbType.Float).Value = float.Parse(textBoxBunCostRed.Text);
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
                query = "UPDATE bunuri SET nume_bun = @nume_bun, impact_minim = @impact_minim, impact_maxim = @impact_maxim, domeniu_categorie = @domeniu_categorie, cost = @cost, cost_de_reducere = @cost_de_reducere WHERE cod_bun = @cod_bun";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@nume_bun", MySqlDbType.VarChar).Value = textBoxBunNume.Text;
                cmd.Parameters.Add("@impact_minim", MySqlDbType.Int16).Value = Int16.Parse(comboBoxImMin.Text);
                cmd.Parameters.Add("@impact_maxim", MySqlDbType.Int16).Value = Int16.Parse(comboBoxImMax.Text);
                cmd.Parameters.Add("@domeniu_categorie", MySqlDbType.VarChar).Value = comboBoxDomeniu.Text;
                cmd.Parameters.Add("@cost", MySqlDbType.Float).Value = float.Parse(textBoxBunCost.Text);
                cmd.Parameters.Add("@cost_de_reducere", MySqlDbType.Float).Value = float.Parse(textBoxBunCostRed.Text);
                cmd.Parameters.Add("@cod_bun", MySqlDbType.Int16).Value = this.editID;
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
                query = "DELETE FROM bunuri WHERE cod_bun = @cod_bun";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@cod_bun", MySqlDbType.Int16).Value = this.editID;
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

        private void buttonBunSave_Click(object sender, EventArgs e)
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
        override public void addNewCell()
        {
            this.editID = -1;
            label4.Text = "Adaugare";
        }

        override public void refresh()
        {
            fillTable();
            comboBoxDomeniu.SelectedIndex = 0;
            comboBoxImMax.SelectedIndex = 0;
            comboBoxImMin.SelectedIndex = 0;
        }
    }
}
