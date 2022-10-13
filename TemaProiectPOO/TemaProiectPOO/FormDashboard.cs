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

namespace TemaProiectPOO
{
    public partial class FormDashboard : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
        SqlCommand cmd;
 


        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

            conn.Open();
           
            SqlCommand cmd1 = new SqlCommand("Select * From TableNotes", conn);
            
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1);
            for (int i1 = 0; i1 < ds1.Tables[0].Rows.Count; i1++)
            {
                comboBoxNrMatricol.Items.Add(ds1.Tables[0].Rows[i1][2]);

            }

            SqlCommand cmd = new SqlCommand("Select * From TableNotes", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBoxCodDisciplina.Items.Add(ds1.Tables[0].Rows[i][1]);

            }

            conn.Close();



        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBoxStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Disciplină_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculeazaMedia_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Avg(nota) From TableNotes Where nr_matricol="+comboBoxNrMatricol.Text+"");
            cmd.Connection = conn;
            int avg = (Int32)cmd.ExecuteScalar();



            textBoxMedie.Text = avg.ToString();


            SqlCommand cmd1 = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From TableStudents Where nr_matricol = " + comboBoxNrMatricol.SelectedItem.ToString() + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBoxName.Text = dr["nume"].ToString();
                textBoxSurname.Text = dr["prenume"].ToString();
            }

            checkBox.Enabled = false;
            if (avg > 5)
            {
                checkBox.Checked = true;
            }
            else
            {
                checkBox.Checked = false;

            }


            conn.Close();
         
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select Sum(nr_credite) From TableDisciplina Where cod_disciplina ='" + comboBoxCodDisciplina.Text + "'");
            cmd2.Connection = conn;
            int sum = (Int32)cmd2.ExecuteScalar();
            textBoxCredite.Text = sum.ToString();
            conn.Close();
        }

        private void comboBoxDisciplina1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxIntegralist_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNrMatricol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCredite_TextChanged(object sender, EventArgs e)
        {

        }

        private void Integralist_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
