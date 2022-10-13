using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaProiectPOO
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }



        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }


        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseStudentsDataSet17.TableNotes' table. You can move, or remove it, as needed.
            this.tableNotesTableAdapter3.Fill(this.dataBaseStudentsDataSet17.TableNotes);
            // TODO: This line of code loads data into the 'dataBaseStudentsDataSet15.TableNotes' table. You can move, or remove it, as needed.
            this.tableNotesTableAdapter2.Fill(this.dataBaseStudentsDataSet15.TableNotes);

            this.reportViewer3.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.dataBaseStudentsDataSet14.TableNotes.CopyToDataTable(), "Id");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Ai reusit transferul datelor in fisierul Excel");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Search";
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search")
            {
                textBoxSearch.Text = "";
            }
        }

        private void reportViewer3_Load_1(object sender, EventArgs e)
        {

        }

        private void reportViewer3_Load_2(object sender, EventArgs e)
        {

        }
    }
}
