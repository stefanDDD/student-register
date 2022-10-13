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
    public partial class LogInForm : System.Windows.Forms.Form
    {
        public LogInForm()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 20;
        }


        public void ShowError(string Text)
        {
            labelErrorUsername.Text = Text;
            panelErrorUsername.Visible = true;
            labelErrorUsername.Visible = true;
            panelErrorUsernameText.BackColor = Color.Red;
            timerErrorUsername.Start();

        }
        public void ShowErrorPassword(string Text)
        {
            labelErrorPassword.Text = Text;
            panelErrorPassword.Visible = true;
            labelErrorPassword.Visible = true;
            panelErrorPasswordText.BackColor = Color.Red;
            timerErrorUsername.Start();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dbLoginEntities context = new dbLoginEntities();
            if (textBoxUsername.Text != string.Empty || textBoxPassword.Text != string.Empty)
            {
                var user = context.TableLogIn.Where(a => a.username.Equals(textBoxUsername.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.password.Equals(textBoxPassword.Text))
                    {
                        this.Hide();
                        FirstForm firstF = new FirstForm();
                        firstF.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        ShowErrorPassword("Wrong password!");
                        textBoxPassword.Text = string.Empty;
                    }
                }
                else
                {
                    ShowError("Wrong username!");
                    textBoxUsername.Text = string.Empty;
                    
                }
            }

            
        }

        private void LogInForm_Load(object sender, EventArgs e)
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

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
            }
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
           
        }


        private void label1_Click(object sender, EventArgs e)
        {
            labelTitle.BackColor = System.Drawing.Color.Transparent;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelErrorUsername_Click(object sender, EventArgs e)
        {

        }

        private void timerErrorUsername_Tick(object sender, EventArgs e)
        {
            timerErrorUsername.Stop();
            labelErrorUsername.Visible = false;
            panelErrorUsernameText.BackColor = Color.Black;

            labelErrorPassword.Visible = false;
            panelErrorPasswordText.BackColor = Color.Black;
        }

        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }

        }
    }
}
