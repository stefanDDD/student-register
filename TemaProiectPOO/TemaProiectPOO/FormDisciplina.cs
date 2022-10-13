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
    public partial class FormDisciplina : System.Windows.Forms.Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt;

        public FormDisciplina()
        {
            InitializeComponent();
        }

        private void FormDisciplina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseStudentsDataSet11.TableDisciplina' table. You can move, or remove it, as needed.
            this.tableDisciplinaTableAdapter1.Fill(this.dataBaseStudentsDataSet11.TableDisciplina);
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowData();
            this.dgvDisciplina.Refresh();
            this.dgvDisciplina.Update();
        }

       
        public void ShowData()
        {

            adapter = new SqlDataAdapter("SELECT * FROM TableDisciplina", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvDisciplina.DataSource = dt;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBoxSearch.Text);
        }
        public void SearchData(string search)
        {

            conn.Open();
            string query = "SELECT * FROM TableDisciplina WHERE cod_disciplina LIKE '%" + search + "%' OR denumire LIKE '%" + search + "%' OR nr_credite LIKE '%" + search + "%' OR sters LIKE '%" + search + "%' ";

            adapter = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvDisciplina.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddDiscipline fDiscipline = new FormAddDiscipline();
            fDiscipline.Show();
        }

        private void dgvDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvDisciplina_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvDisciplina_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvDisciplina.Rows[rowIndex];

                FormAddDiscipline f2 = new FormAddDiscipline();
                FormDisciplina f1 = new FormDisciplina();
               
                f2.textBoxCodDisciplina.Text = row.Cells[1].Value.ToString();
                f2.textBoxDenumire.Text = row.Cells[2].Value.ToString();
                f2.textBoxCredite.Text = row.Cells[3].Value.ToString();
                f2.comboBoxDeleted.Text = row.Cells[4].Value.ToString();
                f2.buttonSave.Visible = false;
                f2.buttonUpdate.Visible = true;
                f2.ShowDialog();


                f2.buttonUpdate.Click += f2.buttonUpdate_Click;

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE TableDisciplina SET cod_disciplina='" + f2.textBoxCodDisciplina.Text + "',denumire='" + f2.textBoxDenumire.Text + "',nr_credite='" + f2.textBoxCredite.Text + "',sters='" + f2.comboBoxDeleted.Text + "' WHERE ID=" + row.Cells[0].Value.ToString(), conn);
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
                    string sql = "DELETE FROM TableDisciplina WHERE Id=" + dgvDisciplina.Rows[rowIndex].Cells[0].Value;
                    //create sql command
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    //open connection
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    dgvDisciplina.Rows.RemoveAt(rowIndex);

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
                            workbook.Worksheets.Add(this.dataBaseStudentsDataSet11.TableDisciplina.CopyToDataTable(), "Id");
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
