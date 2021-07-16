using System;
using System.Windows.Forms;
using System.Data.SqlClient; //adaugarea functiilor 
//using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;
using ClosedXML.Excel;
using DataTable = System.Data.DataTable;

namespace Reporting_Interface
{
    public partial class Form1 : Form {
        public Form1(){InitializeComponent();}

        private void buton_cautare_Click(object sender, EventArgs e){

            try {
                DataView dv = dataGridView1.DataSource as DataView;
                if(dv!=null)
                    dv.RowFilter = textBoxID.Text;
                totalPiese.Text = $"Number of pieces: {dataGridView1.RowCount}";
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label3.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void buton_afisare_Click(object sender, EventArgs e){
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
            {
                if(ofd.ShowDialog()==DialogResult.OK){
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dt = new DataTable();
                    using(XLWorkbook workbook = new XLWorkbook(ofd.FileName)){
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach(var row in rows ){
                            if(isFirstRow){
                                //adding column
                                foreach (IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;
                            }
                            else{
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                            }
                        }
                        dataGridView1.DataSource = dt.DefaultView;
                        totalPiese.Text = $"Number of pieces: {dataGridView1.RowCount}";
                    }

                }
            }   
        }
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)100)
                buton_cautare.PerformClick();
        }

        private void buton_report_Click(object sender, EventArgs e)
        {
            try{
                DataView dv = dataGridView1.DataSource as DataView;
                if (dv != null)
                    dv.RowFilter = "Validation = False";
                label4.Text = $"Number of unvalided pieces: {dataGridView1.RowCount}";
                label3.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}