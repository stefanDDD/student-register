
namespace TemaProiectPOO
{
    partial class FormAddDiscipline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelNrCredite = new System.Windows.Forms.Panel();
            this.textBoxCredite = new System.Windows.Forms.TextBox();
            this.panelDenumire = new System.Windows.Forms.Panel();
            this.panelCodDisciplina = new System.Windows.Forms.Panel();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.textBoxCodDisciplina = new System.Windows.Forms.TextBox();
            this.timerAddDiscipline = new System.Windows.Forms.Timer(this.components);
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelComboBox = new System.Windows.Forms.Panel();
            this.labelCodDisciplina = new System.Windows.Forms.Label();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelNumarCredite = new System.Windows.Forms.Label();
            this.labelDeleted = new System.Windows.Forms.Label();
            this.comboBoxDeleted = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 67);
            this.panel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonSave.Location = new System.Drawing.Point(45, 461);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 36);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelNrCredite
            // 
            this.panelNrCredite.BackColor = System.Drawing.Color.Black;
            this.panelNrCredite.Location = new System.Drawing.Point(45, 333);
            this.panelNrCredite.Margin = new System.Windows.Forms.Padding(4);
            this.panelNrCredite.Name = "panelNrCredite";
            this.panelNrCredite.Size = new System.Drawing.Size(293, 1);
            this.panelNrCredite.TabIndex = 24;
            // 
            // textBoxCredite
            // 
            this.textBoxCredite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCredite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCredite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCredite.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxCredite.Location = new System.Drawing.Point(45, 292);
            this.textBoxCredite.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCredite.Multiline = true;
            this.textBoxCredite.Name = "textBoxCredite";
            this.textBoxCredite.Size = new System.Drawing.Size(293, 36);
            this.textBoxCredite.TabIndex = 22;
            this.textBoxCredite.Text = "Număr Credite";
            this.textBoxCredite.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            this.textBoxCredite.Enter += new System.EventHandler(this.textBoxNrCredite_Enter);
            this.textBoxCredite.Leave += new System.EventHandler(this.textBoxNrCredite_Leave);
            // 
            // panelDenumire
            // 
            this.panelDenumire.BackColor = System.Drawing.Color.Black;
            this.panelDenumire.Location = new System.Drawing.Point(45, 249);
            this.panelDenumire.Margin = new System.Windows.Forms.Padding(4);
            this.panelDenumire.Name = "panelDenumire";
            this.panelDenumire.Size = new System.Drawing.Size(293, 1);
            this.panelDenumire.TabIndex = 21;
            // 
            // panelCodDisciplina
            // 
            this.panelCodDisciplina.BackColor = System.Drawing.Color.Black;
            this.panelCodDisciplina.Location = new System.Drawing.Point(45, 160);
            this.panelCodDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.panelCodDisciplina.Name = "panelCodDisciplina";
            this.panelCodDisciplina.Size = new System.Drawing.Size(293, 1);
            this.panelCodDisciplina.TabIndex = 20;
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDenumire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDenumire.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxDenumire.Location = new System.Drawing.Point(45, 209);
            this.textBoxDenumire.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDenumire.Multiline = true;
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(293, 36);
            this.textBoxDenumire.TabIndex = 19;
            this.textBoxDenumire.Text = "Denumire";
            this.textBoxDenumire.Enter += new System.EventHandler(this.textBoxDenumire_Enter);
            this.textBoxDenumire.Leave += new System.EventHandler(this.textBoxDenumire_Leave);
            // 
            // textBoxCodDisciplina
            // 
            this.textBoxCodDisciplina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCodDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodDisciplina.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxCodDisciplina.Location = new System.Drawing.Point(45, 119);
            this.textBoxCodDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodDisciplina.Multiline = true;
            this.textBoxCodDisciplina.Name = "textBoxCodDisciplina";
            this.textBoxCodDisciplina.Size = new System.Drawing.Size(293, 36);
            this.textBoxCodDisciplina.TabIndex = 18;
            this.textBoxCodDisciplina.Text = "Cod Disciplină";
            this.textBoxCodDisciplina.Enter += new System.EventHandler(this.textBoxCod_Enter);
            this.textBoxCodDisciplina.Leave += new System.EventHandler(this.textBoxCod_Leave);
            // 
            // timerAddDiscipline
            // 
            this.timerAddDiscipline.Interval = 2000;
            this.timerAddDiscipline.Tick += new System.EventHandler(this.timerAddDiscipline_Tick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 2;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonUpdate.Location = new System.Drawing.Point(44, 461);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(111, 36);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelComboBox
            // 
            this.panelComboBox.BackColor = System.Drawing.Color.Black;
            this.panelComboBox.Location = new System.Drawing.Point(45, 421);
            this.panelComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.panelComboBox.Name = "panelComboBox";
            this.panelComboBox.Size = new System.Drawing.Size(293, 1);
            this.panelComboBox.TabIndex = 29;
            // 
            // labelCodDisciplina
            // 
            this.labelCodDisciplina.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodDisciplina.ForeColor = System.Drawing.Color.Red;
            this.labelCodDisciplina.Location = new System.Drawing.Point(44, 164);
            this.labelCodDisciplina.Name = "labelCodDisciplina";
            this.labelCodDisciplina.Size = new System.Drawing.Size(293, 13);
            this.labelCodDisciplina.TabIndex = 30;
            this.labelCodDisciplina.Text = "label2";
            this.labelCodDisciplina.Visible = false;
            // 
            // labelDenumire
            // 
            this.labelDenumire.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.ForeColor = System.Drawing.Color.Red;
            this.labelDenumire.Location = new System.Drawing.Point(45, 253);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(293, 13);
            this.labelDenumire.TabIndex = 31;
            this.labelDenumire.Text = "label2";
            this.labelDenumire.Visible = false;
            // 
            // labelNumarCredite
            // 
            this.labelNumarCredite.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumarCredite.ForeColor = System.Drawing.Color.Red;
            this.labelNumarCredite.Location = new System.Drawing.Point(45, 337);
            this.labelNumarCredite.Name = "labelNumarCredite";
            this.labelNumarCredite.Size = new System.Drawing.Size(293, 13);
            this.labelNumarCredite.TabIndex = 32;
            this.labelNumarCredite.Text = "label2";
            this.labelNumarCredite.Visible = false;
            // 
            // labelDeleted
            // 
            this.labelDeleted.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleted.ForeColor = System.Drawing.Color.Red;
            this.labelDeleted.Location = new System.Drawing.Point(45, 425);
            this.labelDeleted.Name = "labelDeleted";
            this.labelDeleted.Size = new System.Drawing.Size(293, 13);
            this.labelDeleted.TabIndex = 33;
            this.labelDeleted.Text = "label2";
            this.labelDeleted.Visible = false;
            // 
            // comboBoxDeleted
            // 
            this.comboBoxDeleted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeleted.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBoxDeleted.FormattingEnabled = true;
            this.comboBoxDeleted.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboBoxDeleted.Location = new System.Drawing.Point(44, 382);
            this.comboBoxDeleted.Name = "comboBoxDeleted";
            this.comboBoxDeleted.Size = new System.Drawing.Size(293, 37);
            this.comboBoxDeleted.TabIndex = 34;
            // 
            // FormAddDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 550);
            this.Controls.Add(this.comboBoxDeleted);
            this.Controls.Add(this.labelDeleted);
            this.Controls.Add(this.labelNumarCredite);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.labelCodDisciplina);
            this.Controls.Add(this.panelComboBox);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelNrCredite);
            this.Controls.Add(this.textBoxCredite);
            this.Controls.Add(this.panelDenumire);
            this.Controls.Add(this.panelCodDisciplina);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.textBoxCodDisciplina);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddDiscipline";
            this.Load += new System.EventHandler(this.FormDiscipline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelNrCredite;
        private System.Windows.Forms.Panel panelDenumire;
        private System.Windows.Forms.Panel panelCodDisciplina;
        private System.Windows.Forms.Timer timerAddDiscipline;
        public System.Windows.Forms.TextBox textBoxCredite;
        public System.Windows.Forms.TextBox textBoxDenumire;
        public System.Windows.Forms.TextBox textBoxCodDisciplina;
        public System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panelComboBox;
        public System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCodDisciplina;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelNumarCredite;
        private System.Windows.Forms.Label labelDeleted;
        public System.Windows.Forms.ComboBox comboBoxDeleted;
    }
}