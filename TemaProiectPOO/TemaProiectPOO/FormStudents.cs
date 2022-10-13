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
    public partial class FormStudents : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public FormStudents()
        {
            InitializeComponent();
        }

        private void FormStudentsDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseStudentsDataSet13.TableStudents' table. You can move, or remove it, as needed.
            this.tableStudentsTableAdapter2.Fill(this.dataBaseStudentsDataSet13.TableStudents);
            // TODO: This line of code loads data into the 'dataBaseStudentsDataSet10.TableStudents' table. You can move, or remove it, as needed.
            this.tableStudentsTableAdapter1.Fill(this.dataBaseStudentsDataSet10.TableStudents);
            // TODO: This line of code loads data into the 'dataBaseStudentsDataSet3.tableStudents' table. You can move, or remove it, as needed.
            this.tableStudentsTableAdapter.Fill(this.dataBaseStudentsDataSet3.tableStudents);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddStudents fStudents = new FormAddStudents();
            fStudents.Show();
        }

        private void buttonRefreshStudents_Click(object sender, EventArgs e)
        {

            ShowData();
            this.dataGridViewStudents.Refresh();
            this.dataGridViewStudents.Update();
        }


        public void ShowData()
        {

            adapter = new SqlDataAdapter("SELECT * FROM TableStudents", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewStudents.DataSource = dt;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBoxSearch.Text);
        }
        public void SearchData(string search)
        {

            conn.Open();
            string query = "SELECT * FROM TableStudents WHERE nr_matricol LIKE '%" + search + "%' OR nume LIKE '%" + search + "%' OR prenume LIKE '%" + search + "%' ";

            adapter = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adapter.Fill(dt);

            dataGridViewStudents.DataSource = dt;
            conn.Close();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           if (e.ColumnIndex == 5)
            {
                int rowIndex = e.RowIndex;
                FormAddStudents f2 = new FormAddStudents();
                FormStudents f1 = new FormStudents();
                DataGridViewRow row = dataGridViewStudents.Rows[rowIndex];
                f2.textBoxNumber.Text = row.Cells[1].Value.ToString();
                f2.textBoxName.Text = row.Cells[2].Value.ToString();
                f2.textBoxSurname.Text = row.Cells[3].Value.ToString();
                f2.textBoxDeleted.Text = row.Cells[4].Value.ToString();
                f2.buttonSave.Visible = false;
                f2.buttonUpdate.Visible = true;
                f2.ShowDialog();


                f2.buttonUpdate.Click += f2.buttonUpdate_Click;
                

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE TableStudents SET nr_matricol='" + f2.textBoxNumber.Text + "',nume='" + f2.textBoxName.Text + "',prenume='" + f2.textBoxSurname.Text + "',sters='" + f2.textBoxDeleted.Text + "' WHERE Id=" + row.Cells[0].Value.ToString(), conn);
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
                    string sql = "DELETE FROM TableStudents WHERE Id=" + dataGridViewStudents.Rows[rowIndex].Cells[0].Value;
                    //create sql command
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    //open connection
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    dataGridViewStudents.Rows.RemoveAt(rowIndex);

                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.dataBaseStudentsDataSet13.TableStudents.CopyToDataTable(), "Id");
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

        private void dgvStudents_Click(object sender, EventArgs e)
        {

        }
    }
}
