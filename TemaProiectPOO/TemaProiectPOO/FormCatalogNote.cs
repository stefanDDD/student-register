using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClosedXML.Excel;

namespace TemaProiectPOO
{
    public partial class FormCatalogNote : System.Windows.Forms.Form
    {
        public int ID { get; set; }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public FormCatalogNote()
        {
            InitializeComponent();
        }

        private void FormCatalogNote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseStudentsDataSet12.TableNotes' table. You can move, or remove it, as needed.
            this.tableNotesTableAdapter3.Fill(this.dataBaseStudentsDataSet12.TableNotes);
            this.tableNotesTableAdapter2.Fill(this.dataBaseStudentsDataSet9.TableNotes);
            // TODO: This line of code loads data into the 'dataBaseStudentsDataSet9.TableNotes' table. You can move, or remove it, as needed.
            

        }

        private void buttonRefreshCatalogNote_Click(object sender, EventArgs e)
        {
            ShowData();
            this.dgvCatalogNote.Refresh();
            this.dgvCatalogNote.Update();
        }
        public void ShowData()
        {

            adapter = new SqlDataAdapter("SELECT * FROM TableNotes", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCatalogNote.DataSource = dt;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBoxSearch.Text);
        }
        public void SearchData(string search)
        {

            conn.Open();
            string query = "SELECT * FROM TableNotes WHERE id LIKE '%" + search + "%' OR cod_disciplina LIKE '%" + search + "%' OR nr_matricol LIKE '%" + search + "%' OR nota LIKE '%" + search + "%' OR sters LIKE '%" + search + "%' ";

            adapter = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvCatalogNote.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddNoteCatalog fAddNote = new FormAddNoteCatalog();
            fAddNote.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void dgvDiscipline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
        }

        private void dgvCatalogNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 5)
            {
                int rowIndex = e.RowIndex;
                FormAddNoteCatalog f2 = new FormAddNoteCatalog();
                FormCatalogNote f1 = new FormCatalogNote();
                DataGridViewRow row = dgvCatalogNote.Rows[rowIndex];
                f2.comboBoxDisciplina.Text = row.Cells[1].Value.ToString();
                f2.comboBoxNrMatricol.Text = row.Cells[2].Value.ToString();
                f2.textBoxNota.Text = row.Cells[3].Value.ToString();
                f2.textBoxDeleted.Text = row.Cells[4].Value.ToString();
                f2.buttonSave.Visible = false;
                f2.buttonUpdate.Visible = true;
                f2.ShowDialog();


                f2.buttonUpdate.Click += f2.buttonUpdate_Click;

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE TableNotes SET cod_disciplina='" + f2.comboBoxDisciplina.Text + "',nr_matricol='" + f2.comboBoxNrMatricol.Text + "',nota='" + f2.textBoxNota.Text + "',sters='" + f2.textBoxDeleted.Text + "' WHERE id=" +row.Cells[0].Value.ToString(), conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();






            }
            else if (e.ColumnIndex == 6)
            {

                DialogResult dialogResult = MessageBox.Show("Doriti sa stergeti contactul?", "Warning", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //create sql connection
                    conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");

                    int rowIndex = e.RowIndex;
                    //sql to delete data
                    string sql = "DELETE FROM TableNotes WHERE id=" + dgvCatalogNote.Rows[rowIndex].Cells[0].Value;
                    //create sql command
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    //open connection
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    dgvCatalogNote.Rows.RemoveAt(rowIndex);

                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
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
                            workbook.Worksheets.Add(this.dataBaseStudentsDataSet12.TableNotes.CopyToDataTable(), "id");
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
    }
}
