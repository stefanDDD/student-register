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
    public partial class FormAddStudents : System.Windows.Forms.Form
    {
        public FormAddStudents()
        {
            InitializeComponent();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            buttonUpdate.Visible = false;
            if (string.IsNullOrEmpty(textBoxNumber.Text) || textBoxNumber.Text == "Număr Matricol")
            {

                ShowErrorNrMatricol("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxName.Text) || textBoxName.Text == "Nume")
            {
                ShowErrorName("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxSurname.Text) || textBoxSurname.Text == "Prenume")
            {
                ShowErrorSurname("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxDeleted.Text))
            {
                ShowErrorComboBox("Error! This fields is necessary");
            }
            else
            {
                
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dataBaseStudents;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO tableStudents (nr_matricol, nume, prenume, sters) VALUES ('" + textBoxNumber.Text + "','" + textBoxName.Text + "','" + textBoxSurname.Text + "','"+textBoxDeleted.Text+"')", conn);


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

        public void ShowErrorNrMatricol(string Text)
        {
            labelNrMatricol.Text = Text;
            labelNrMatricol.Visible = true;
            panelNumarMatricol.BackColor = Color.Red;
            timerError.Start();

        }
        public void ShowErrorName(string Text)
        {
            labelName.Text = Text;
            labelName.Visible = true;
            panelName.BackColor = Color.Red;
            timerError.Start();

        }
        public void ShowErrorSurname(string Text)
        {
            labelSurname.Text = Text;
            labelSurname.Visible = true;
            panelSurname.BackColor = Color.Red;
            timerError.Start();

        }
        public void ShowErrorComboBox(string Text)
        {
            labelComboBox.Text = Text;
            labelComboBox.Visible = true;
            panelComboBox.BackColor = Color.Red;
            timerError.Start();

        }
        private void FormStudents_Load(object sender, EventArgs e)
        {

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerError.Stop();
            panelNumarMatricol.BackColor = Color.Black;
            labelNrMatricol.Visible = false;

            panelName.BackColor = Color.Black;
            labelName.Visible = false;

            panelSurname.BackColor = Color.Black;
            labelSurname.Visible = false;

            panelComboBox.BackColor = Color.Black;
            labelComboBox.Visible = false;
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxDeleted_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(textBoxNumber.Text) || textBoxNumber.Text == "Număr Matricol")
            {

                ShowErrorNrMatricol("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxName.Text) || textBoxName.Text == "Nume")
            {
                ShowErrorName("Error! This fields is necessary");
            }
            else if (string.IsNullOrEmpty(textBoxSurname.Text) || textBoxSurname.Text == "Prenume")
            {
                ShowErrorSurname("Error! This fields is necessary");
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

        private void textBoxNrMatricol_Leave(object sender, EventArgs e)
        {
            if (textBoxNumber.Text == "")
            {
                textBoxNumber.Text = "Număr Matricol";
            }
        }

        private void textBoxNrMatricol_Enter(object sender, EventArgs e)
        {
            if (textBoxNumber.Text == "Număr Matricol")
            {
                textBoxNumber.Text = "";
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Nume";
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Nume")
            {
                textBoxName.Text = "";
            }
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "")
            {
                textBoxSurname.Text = "Prenume";
            }
        }

        private void textBoxSurname_Enter(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "Prenume")
            {
                textBoxSurname.Text = "";
            }
        }

        private void panelError_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
