using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using DataTable = System.Data.DataTable;
namespace ExcelOledb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

          //  this.radGridView1.EnableFiltering = true;
          //  this.radGridView1.ShowHeaderCellButtons = true; // enable Excel-like filtering
           // dataGridView1 dateTimeColumn = this.radGridView1.Columns["OrderDate"] as dataGridView1;
           // dateTimeColumn.FilteringMode = GridViewTimeFilteringMode.Date;
           // this.radGridView1.FilterPopupRequired += radGridView1_FilterPopupRequired;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dt = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach (var row in rows)
                        {
                            if (isFirstRow)
                            {
                                //adding column
                                foreach (IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                            }
                        }
                        dataGridView1.DataSource = dt.DefaultView;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView1.DataSource as DataView;
                if (dv != null)
                     dv.RowFilter = button2.Text;
                label2.Text = $"Number of valided pieces: {dataGridView1.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView1.DataSource as DataView;
                if (dv != null)
                    //  dv.RowFilter = button2.Text;
                    dv.RowFilter = "Validation = False";
                label1.Text = $"Number of unvalided pieces: {dataGridView1.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                DataView dv = dataGridView1.DataSource as DataView;
                if (dv == null)
                    // dv.RowFilter = button4.Text;  
                    //  dv.RowFilter = " TestedTime + TimeValue(30/12/1899 18:22:42)  ";
                    //  dv.RowFilter = "TestedTime = '30/12/1899 18:22:42', TestedTime = '30/12/1899 18:24:42 '";
                    //dv.RowFilter = "TestedTime = '18:24:42'";
                    // dv.RowFilter = "TestedTime = '30/12/1899 18:24:42'";

                dv.RowFilter = "TestedData= '2021-07-16'";

                label3.Text = $"16/07/2021: {dataGridView1.RowCount}";
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private string TimeValue(int v1, int v2, int v3, int v4)
        {
            throw new NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView1.DataSource as DataView;
                if (dv != null)
                    //  dv.RowFilter = button2.Text;
                    dv.RowFilter = "ResistorsElementQuantity = 28";
                label6.Text = $"with R=28Ω: {dataGridView1.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView1.DataSource as DataView;
                if (dv != null)
                    //  dv.RowFilter = button2.Text;
                    dv.RowFilter = "InductionsElementQuantity = 1";
                //    dv.RowFilter = "TestedTime = '19/00/48'";
                label5.Text = $"B=1Tesla: {dataGridView1.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView1.DataSource as DataView;
                if (dv != null)
                    dv.RowFilter = "DiodesElementQuantity = 11";
                
                label4.Text = $"Number of diodes: {dataGridView1.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
