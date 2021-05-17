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
    public partial class Riscuri : DefaultPanel
    {
        public int editID = -1;

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

        private void fillSle(CheckedListBox check, string table, string id, string name)
        {

            string query;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd;
            check.Items.Clear();
            Kernel con = new Kernel();
            try
            {
                con.OpenConnection();
                //create a query for retrieving data in the database.
                query = "SELECT * FROM `"+ table + "` ";
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
                    check.Items.Add(new Bunuri(Int16.Parse(dataReader[id].ToString()), dataReader[name].ToString()));
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
                query = "INSERT INTO riscuri (nume_risc, nivel_risc, prob_aparitie,natura_risc) VALUES (@nume_risc, @nivel_risc, @prob_aparitie, @natura_risc)";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };

                cmd.Parameters.Add("@nume_risc", MySqlDbType.VarChar).Value = textBoxRiscNume.Text;
                cmd.Parameters.Add("@nivel_risc", MySqlDbType.Float).Value = textBoxRiscNivel.Text;
                cmd.Parameters.Add("@prob_aparitie", MySqlDbType.VarChar).Value = textBoxRiscProb.Text;
                cmd.Parameters.Add("@natura_risc", MySqlDbType.VarChar).Value = textBoxRiscNatura.Text;

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

        private void buttonRiscSave_Click(object sender, EventArgs e)
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

        private void dataGridViewRisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewRisc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewRisc.CurrentCell.RowIndex;
            int columnindex = dataGridViewRisc.CurrentCell.ColumnIndex;
            int codVul = Int16.Parse(dataGridViewRisc.Rows[rowindex].Cells["cod_risc"].Value.ToString());

            textBoxRiscNume.Text = dataGridViewRisc.Rows[rowindex].Cells["nume_risc"].Value.ToString();
            textBoxRiscNivel.Text = dataGridViewRisc.Rows[rowindex].Cells["nivel_risc"].Value.ToString();
            textBoxRiscProb.Text = dataGridViewRisc.Rows[rowindex].Cells["prob_aparitie"].Value.ToString();
            textBoxRiscNatura.Text = dataGridViewRisc.Rows[rowindex].Cells["natura_risc"].Value.ToString();

            this.editID = codVul;
            label28.Text = "Editare";
        }

        override public void addNewCell()
        {
            this.editID = -1;
            label28.Text = "Adaugare";
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
                query = "DELETE FROM riscuri WHERE cod_risc = @cod_risc";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };
                cmd.Parameters.Add("@cod_risc", MySqlDbType.Int16).Value = this.editID;
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
        }

        private void buttonRiscAnuleaza_Click(object sender, EventArgs e)
        {
            textBoxRiscNume.Text = "";
            textBoxRiscNivel.Text = "";
            textBoxRiscProb.Text = "";
            textBoxRiscNatura.Text = "";

            this.editID = -1;
            label28.Text = "Adaugare";
        }
    }
}
