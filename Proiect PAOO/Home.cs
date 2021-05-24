using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ClosedXML.Excel;

namespace Proiect_PAOO
{
    public partial class Home : Form
    {
        public static DefaultPanel currentPanel;
        public static DataGridView currentTable;
        public Home()
        {
            InitializeComponent();
            Home.currentPanel = panelBunuri;
            Home.currentTable = dataGridViewBunuri;
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

        public DataTable toTable(DataGridView dataGrid)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGrid.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }

        public void export(DataTable dtblTable, string strHeader)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "PDF|*.pdf";
            saveFileDialog1.FileName = strHeader;
            saveFileDialog1.Title = "Save " + labelCurrent.Text;
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(saveFileDialog1.FileName);
                System.IO.FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
                Document document = new Document();
                document.SetPageSize(iTextSharp.text.PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntHead = new Font(bfntHead, 16, 1, Color.GRAY);
                Paragraph prgHeading = new Paragraph();
                prgHeading.Alignment = Element.ALIGN_CENTER;
                prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
                document.Add(prgHeading);

                Paragraph prgAuthor = new Paragraph();
                BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
                prgAuthor.Alignment = Element.ALIGN_RIGHT;
                prgAuthor.Add(new Chunk("Societate RISK", fntAuthor));
                prgAuthor.Add(new Chunk("\nData: " + DateTime.Now.ToShortDateString(), fntAuthor));
                document.Add(prgAuthor);

                Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
                document.Add(p);

                document.Add(new Chunk("\n", fntHead));

                PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
                BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
                for (int i = 0; i < dtblTable.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = Color.GRAY;
                    cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                    table.AddCell(cell);
                }
                for (int i = 0; i < dtblTable.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtblTable.Columns.Count; j++)
                    {
                        table.AddCell(dtblTable.Rows[i][j].ToString());
                    }
                }

                document.Add(table);
                document.Close();
                writer.Close();
                fs.Close();
            }
        }

        public void excel(DataTable dt, string strHeader)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
            saveFileDialog1.FileName = strHeader;
            saveFileDialog1.Title = "Save " + labelCurrent.Text;
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetFullPath(saveFileDialog1.FileName);
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, strHeader);

                    //wb.Worksheet(1).Cells("A1:C1").Style.Fill.BackgroundColor = XLColor.DarkGreen;
                    /*for (int i = 1; i <= dt.Rows.Count; i++)
                    {
                        string cellRange = string.Format("A{0}:C{0}", i + 1);
                        if (i % 2 != 0)
                        {
                            wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.GreenYellow;
                        }
                        else
                        {
                            wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.Yellow;
                        }

                    }*/
                    wb.Worksheet(1).Columns().AdjustToContents();

                    wb.SaveAs(folderPath);
                }
            }
        }

        public void print()
        {
            try
            {
                DataTable dtbl = toTable(currentTable);
                export(dtbl, labelCurrent.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        public void export()
        {
            try
            {
                DataTable dtbl = toTable(currentTable);
                excel(dtbl, labelCurrent.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
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
                    Home.currentPanel = panelBunuri;
                    Home.currentTable = panelBunuri.dataGridViewBunuri;
                    break;
                case 1:
                    panelAmenintari.Visible = true;
                    labelCurrent.Text = "Identificare amenintari";
                    Home.currentPanel = panelAmenintari;
                    Home.currentTable = panelAmenintari.dataGridViewAmenintari;
                    break;
                case 2:
                    panelVulnerabilitati.Visible = true;
                    labelCurrent.Text = "Identificare vulnerabilitati";
                    Home.currentPanel = panelVulnerabilitati;
                    Home.currentTable = panelVulnerabilitati.dataGridViewVulnerabilitati;
                    break;
                case 3:
                    panelRiscuri.Visible = true;
                    labelCurrent.Text = "Identificare riscuri";
                    Home.currentPanel = panelRiscuri;
                    Home.currentTable = panelRiscuri.dataGridViewRisc;
                    break;
                case 4:
                    panelTratare.Visible = true;
                    labelCurrent.Text = "Tratare riscuri si identificare contramasuri";
                    Home.currentPanel = panelTratare;
                    Home.currentTable = panelTratare.dataGridViewTrat;
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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            print();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            export();
        }
    }
}
