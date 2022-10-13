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
    public partial class FormAddNoteCatalog : Form
    {
        public FormAddNoteCatalog()
        {
            InitializeComponent();
        }

        private void labelErrorCatalog_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ShowError(string Text)
        {

                timerErrorCatalog.Start();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            buttonUpdate.Visible = false;
            if (string.IsNullOrEmpty(comboBoxDisciplina.Text))
            {

                ShowErrorDisciplina("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(comboBoxNrMatricol.Text))
            {
                ShowErrorNrMatricol("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxNota.Text) || textBoxNota.Text == "Notă")
            {
                ShowErrorNota("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxDeleted.Text))
            {
                ShowErrorComboBox("Error! This fields is necessary");
            }
            else
            {
                ShowError("Completare reusita");
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO TableNotes (cod_disciplina, nr_matricol, nota, sters) VALUES ('" + comboBoxDisciplina.Text + "','" + comboBoxNrMatricol.Text + "','" + textBoxNota.Text + "','"+textBoxDeleted.Text+"')", conn);


                int i = cmd.ExecuteNonQuery();

                if (i != 0)

                {


                }
                else
                {

                }
                conn.Close();
                this.Close();

            }
        }

        private void textBoxNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxDisciplina.Text))
            {

                ShowErrorDisciplina("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(comboBoxNrMatricol.Text))
            {
                ShowErrorNrMatricol("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxNota.Text) || textBoxNota.Text == "Notă")
            {
                ShowErrorNota("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxDeleted.Text))
            {
                ShowErrorComboBox("Error! This fields is necessary");
            }
            else
            { 


                    this.Close();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxCod_Leave(object sender, EventArgs e)
        {
            if (comboBoxDisciplina.Text == "")
            {
                comboBoxDisciplina.Text = "Cod Disciplină";
            }
        }

        private void textBoxCod_Enter(object sender, EventArgs e)
        {
            if (comboBoxDisciplina.Text == "Cod Disciplină")
            {
                comboBoxDisciplina.Text = "";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNumarMatricol_Leave(object sender, EventArgs e)
        {
            if (comboBoxNrMatricol.Text == "")
            {
                comboBoxNrMatricol.Text = "Număr Matricol";
            }
        }

        private void textBoxNumarMatricol_Enter(object sender, EventArgs e)
        {
            if (comboBoxNrMatricol.Text == "Număr Matricol")
            {
                comboBoxNrMatricol.Text = "";
            }
        }

        private void textBoxNota_Enter(object sender, EventArgs e)
        {
            if (textBoxNota.Text == "Notă")
            {
                textBoxNota.Text = "";
            }
        }

        private void textBoxNota_Leave(object sender, EventArgs e)
        {
            if (textBoxNota.Text == "")
            {
                textBoxNota.Text = "Notă";
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAddNoteCatalog_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
            SqlCommand cmd,cmd1;
            conn.Open();
            cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TableStudents";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            foreach (DataRow dr1 in dt.Rows)
            {
                comboBoxNrMatricol.Items.Add(dr1["nr_matricol"].ToString());

            }
            cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * FROM TableDisciplina";
            DataTable dt1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            adapter1.Fill(dt1);
            foreach (DataRow dr2 in dt1.Rows)
            {
                comboBoxDisciplina.Items.Add(dr2["cod_disciplina"].ToString());

            }

        }

        private void textBoxCodDisciplina_TextChanged(object sender, EventArgs e)
        {

        }

        public void ShowErrorDisciplina(string Text)
        {
            labelCodDisciplina.Text = Text;
            labelCodDisciplina.Visible = true;
            panelDisciplina.BackColor = Color.Red;
            timerErrorCatalog.Start();

        }
        public void ShowErrorNrMatricol(string Text)
        {
            labelNrMatricol.Text = Text;
            labelNrMatricol.Visible = true;
            panelNrMatricol.BackColor = Color.Red;
            timerErrorCatalog.Start();

        }
        public void ShowErrorNota(string Text)
        {
            labelNota.Text = Text;
            labelNota.Visible = true;
            panelNota.BackColor = Color.Red;
            timerErrorCatalog.Start();

        }
        public void ShowErrorComboBox(string Text)
        {
            labelDeleted.Text = Text;
            labelDeleted.Visible = true;
            panelDeleted.BackColor = Color.Red;
            timerErrorCatalog.Start();

        }

        private void timerErrorCatalog_Tick(object sender, EventArgs e)
        {
            timerErrorCatalog.Stop();
            panelNrMatricol.BackColor = Color.Black;
            labelNrMatricol.Visible = false;

            panelDisciplina.BackColor = Color.Black;
            labelCodDisciplina.Visible = false;

            panelNota.BackColor = Color.Black;
            labelNota.Visible = false;

            panelDeleted.BackColor = Color.Black;
            labelDeleted.Visible = false;
        }

        private void comboBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
