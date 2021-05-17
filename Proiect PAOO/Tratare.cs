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
    public partial class Tratare : DefaultPanel
    {
        public int editID = -1;

        public Tratare()
        {
            InitializeComponent();
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
                query = "SELECT DISTINCT r.cod_risc, r.nume_risc, r.nivel_risc, r.prob_aparitie, r.natura_risc, b.nume_bun, vu.vulnerabilitate, am.amenintare, c.metoda_tratare  FROM `riscuri` r LEFT JOIN  `contramasuri` c ON c.cod_risc = r.cod_risc LEFT JOIN bunuri b ON b.cod_bun = r.cod_bun LEFT JOIN vulnerabilitati vu ON b.cod_bun = vu.cod_bun LEFT JOIN amenintari am ON am.cod_bun = b.cod_bun";
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

                dataGridViewTrat.DataSource = dt;
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

        private void fillSle() {

            string query;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd;
            checkedListBox1.Items.Clear();
            Kernel con = new Kernel();
            try
            {
                con.OpenConnection();
                //create a query for retrieving data in the database.
                query = "SELECT * FROM `contramasuri` WHERE categorie_contram = 'Activitati' ";
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
                    checkedListBox1.Items.Add(new Bunuri(Int16.Parse(dataReader["cod_contramasura"].ToString()), dataReader["metoda_tratare"].ToString()));
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

        private void dataGridViewTrat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewTrat.CurrentCell.RowIndex;
            int columnindex = dataGridViewTrat.CurrentCell.ColumnIndex;
            int codVul = Int16.Parse(dataGridViewTrat.Rows[rowindex].Cells["cod_risc"].Value.ToString());
            
            textBoxTratProb.Text = dataGridViewTrat.Rows[rowindex].Cells["prob_aparitie"].Value.ToString();
            textBox1.Text = dataGridViewTrat.Rows[rowindex].Cells["nume_risc"].Value.ToString();
            textBoxTratBun.Text = dataGridViewTrat.Rows[rowindex].Cells["nume_bun"].Value.ToString();
            textBoxTratNiv.Text = dataGridViewTrat.Rows[rowindex].Cells["nivel_risc"].Value.ToString();

            textBoxTratMet.Text = dataGridViewTrat.Rows[rowindex].Cells["metoda_tratare"].Value.ToString();

            textBoxTratAmen.Text = dataGridViewTrat.Rows[rowindex].Cells["amenintare"].Value.ToString();
            textBoxTratVul.Text = dataGridViewTrat.Rows[rowindex].Cells["vulnerabilitate"].Value.ToString();

            this.editID = codVul;
            label38.Text = "Editare";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTratSave_Click(object sender, EventArgs e)
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

        private void buttonTratStergere_Click(object sender, EventArgs e)
        {

            textBoxTratProb.Text = "";
            textBox1.Text ="";
            textBoxTratBun.Text = "";
            textBoxTratNiv.Text = "";
            textBoxTratMet.Text = "";
            // textBoxTratMet.Text = dataGridViewTrat.Rows[rowindex].Cells["nivel_risc"].Value.ToString();
            textBoxTratAmen.Text = "";
            textBoxTratVul.Text = "";
            this.editID = -1;
            label38.Text = "Adaugare";
        }

        private void buttonTratAdauga_Click(object sender, EventArgs e)
        {
            string query;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd;

            Kernel con = new Kernel();
            try
            {
                con.OpenConnection();

                //create a query for retrieving data in the database.
                query = "INSERT INTO `contramasuri` (categorie_contram,tratat, metoda_tratare, cod_risc) VALUES ('Activitati',0, @metoda_tratare,0) ";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };

                cmd.Parameters.Add("@metoda_tratare", MySqlDbType.VarChar).Value = textBoxTratAdauga.Text;
                cmd.ExecuteNonQuery();

                fillSle();
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
                query = "INSERT INTO riscuri (nume_risc, nivel_risc, prob_aparitie) VALUES (@nume_risc, @nivel_risc, @prob_aparitie)";
                //initialize new Sql commands
                cmd = new MySqlCommand
                {
                    //hold the data to be executed.
                    Connection = con.connection,
                    CommandText = query
                };

                cmd.Parameters.Add("@nume_risc", MySqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@nivel_risc", MySqlDbType.Float).Value = textBoxTratNiv.Text;
                cmd.Parameters.Add("@prob_aparitie", MySqlDbType.VarChar).Value = textBoxTratProb.Text;

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

        }

        override public void addNewCell()
        {
            this.editID = -1;
            label38.Text = "Adaugare";
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
    }
}
