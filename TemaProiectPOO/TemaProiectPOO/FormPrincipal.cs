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
    public partial class FirstForm : System.Windows.Forms.Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FirstForm Form1 = new FirstForm();

            // TODO: This line of code loads data into the 'dataBaseStudentsDataSet.tableStudents' table. You can move, or remove it, as needed.
            this.tableStudentsTableAdapter.Fill(this.dataBaseStudentsDataSet.tableStudents);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddStudents formStud = new FormAddStudents();
            formStud.Show();

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDisciplina());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCatalogNote());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDashboard());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormStudents());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void buttonMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReport());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelChildForm.Show();
        }
    }
}
