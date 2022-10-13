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
    public partial class FormAddDiscipline : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public FormAddDiscipline()
        {
            InitializeComponent();
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }
        public void ShowError(string Text)
        {

          
            timerAddDiscipline.Start();

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            

            if (string.IsNullOrEmpty(textBoxCodDisciplina.Text) || textBoxCodDisciplina.Text == "Cod Disciplină")
            {

                ShowErrorCodDisciplina("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxDenumire.Text) || textBoxDenumire.Text == "Denumire")
            {
                ShowErrorDenumire("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxCredite.Text) || textBoxCredite.Text == "Număr Credite")
            {

                ShowErrorNrCredite("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(comboBoxDeleted.Text))
            {
                ShowErrorComboBox("Error! This fields is necessary");
            }
            else
            {
                ShowError("Completare reusita");
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
                conn.Open();
                buttonUpdate.Visible = false;
                SqlCommand cmd = new SqlCommand("INSERT INTO TableDisciplina (cod_disciplina, denumire, nr_credite, sters) VALUES ('" + textBoxCodDisciplina.Text + "','" + textBoxDenumire.Text + "','" + textBoxCredite.Text + "','" + comboBoxDeleted.Text + "')", conn);


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

        private void FormDiscipline_Load(object sender, EventArgs e)
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

        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodDisciplina.Text) || textBoxCodDisciplina.Text == "Cod Disciplină")
            {

                ShowErrorCodDisciplina("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxDenumire.Text) || textBoxDenumire.Text == "Denumire")
            {
                ShowErrorDenumire("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxCredite.Text) || textBoxCredite.Text == "Număr Credite")
            {

                ShowErrorNrCredite("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(comboBoxDeleted.Text))
            {
                ShowErrorComboBox("Error! This fields is necessary");
            }
            else
            {
                this.Close();
            }
        }

        private void textBoxCod_Leave(object sender, EventArgs e)
        {
            if (textBoxCodDisciplina.Text == "")
            {
                textBoxCodDisciplina.Text = "Cod Disciplină";
            }
        }

        private void textBoxCod_Enter(object sender, EventArgs e)
        {
            if (textBoxCodDisciplina.Text == "Cod Disciplină")
            {
                textBoxCodDisciplina.Text = "";
            }
        }

        private void textBoxDenumire_Leave(object sender, EventArgs e)
        {
            if (textBoxDenumire.Text == "")
            {
                textBoxDenumire.Text = "Denumire";
            }
        }

        private void textBoxDenumire_Enter(object sender, EventArgs e)
        {
            if (textBoxDenumire.Text == "Denumire")
            {
                textBoxDenumire.Text = "";
            }
        }

        private void textBoxNrCredite_Leave(object sender, EventArgs e)
        {
            if (textBoxCredite.Text == "")
            {
                textBoxCredite.Text = "Număr Credite";
            }
        }

        private void textBoxNrCredite_Enter(object sender, EventArgs e)
        {
            if (textBoxCredite.Text == "Număr Credite")
            {
                textBoxCredite.Text = "";
            }
        }

        private void timerAddDiscipline_Tick(object sender, EventArgs e)
        {
            timerAddDiscipline.Stop();
            panelCodDisciplina.BackColor = Color.Black;
            labelCodDisciplina.Visible = false;

            panelDenumire.BackColor = Color.Black;
            labelDenumire.Visible = false;

            panelNrCredite.BackColor = Color.Black;
            labelNumarCredite.Visible = false;

            panelComboBox.BackColor = Color.Black;
            labelDeleted.Visible = false;
        }

        public void ShowErrorCodDisciplina(string Text)
        {
            labelCodDisciplina.Text = Text;
            labelCodDisciplina.Visible = true;
            panelCodDisciplina.BackColor = Color.Red;
            timerAddDiscipline.Start();

        }
        public void ShowErrorDenumire(string Text)
        {
            labelDenumire.Text = Text;
            labelDenumire.Visible = true;
            panelDenumire.BackColor = Color.Red;
            timerAddDiscipline.Start();

        }
        public void ShowErrorNrCredite(string Text)
        {
            labelNumarCredite.Text = Text;
            labelNumarCredite.Visible = true;
            panelNrCredite.BackColor = Color.Red;
            timerAddDiscipline.Start();

        }
        public void ShowErrorComboBox(string Text)
        {
            labelDeleted.Text = Text;
            labelDeleted.Visible = true;
            panelComboBox.BackColor = Color.Red;
            timerAddDiscipline.Start();

        }
    }
}
