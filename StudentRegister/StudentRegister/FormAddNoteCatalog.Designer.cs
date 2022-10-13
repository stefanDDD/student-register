
namespace TemaProiectPOO
{
    partial class FormAddNoteCatalog
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
            this.timerErrorCatalog = new System.Windows.Forms.Timer(this.components);
            this.panelDisciplina = new System.Windows.Forms.Panel();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.panelNrMatricol = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNota = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDeleted = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            this.labelNrMatricol = new System.Windows.Forms.Label();
            this.labelCodDisciplina = new System.Windows.Forms.Label();
            this.comboBoxNrMatricol = new System.Windows.Forms.ComboBox();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxDeleted = new System.Windows.Forms.ComboBox();
            this.panelDeleted = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 69);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timerErrorCatalog
            // 
            this.timerErrorCatalog.Interval = 2000;
            this.timerErrorCatalog.Tick += new System.EventHandler(this.timerErrorCatalog_Tick);
            // 
            // panelDisciplina
            // 
            this.panelDisciplina.BackColor = System.Drawing.Color.Black;
            this.panelDisciplina.Location = new System.Drawing.Point(35, 89);
            this.panelDisciplina.Name = "panelDisciplina";
            this.panelDisciplina.Size = new System.Drawing.Size(220, 1);
            this.panelDisciplina.TabIndex = 30;
            // 
            // textBoxNota
            // 
            this.textBoxNota.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNota.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNota.Location = new System.Drawing.Point(35, 201);
            this.textBoxNota.Multiline = true;
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(220, 29);
            this.textBoxNota.TabIndex = 32;
            this.textBoxNota.Text = "Notă";
            this.textBoxNota.TextChanged += new System.EventHandler(this.textBoxNota_TextChanged);
            this.textBoxNota.Enter += new System.EventHandler(this.textBoxNota_Enter);
            this.textBoxNota.Leave += new System.EventHandler(this.textBoxNota_Leave);
            // 
            // panelNrMatricol
            // 
            this.panelNrMatricol.BackColor = System.Drawing.Color.Black;
            this.panelNrMatricol.Location = new System.Drawing.Point(35, 158);
            this.panelNrMatricol.Name = "panelNrMatricol";
            this.panelNrMatricol.Size = new System.Drawing.Size(220, 1);
            this.panelNrMatricol.TabIndex = 33;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonSave.Location = new System.Drawing.Point(35, 327);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 29);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelNota);
            this.panel2.Controls.Add(this.panelNrMatricol);
            this.panel2.Controls.Add(this.panelDisciplina);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 396);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelNota
            // 
            this.panelNota.BackColor = System.Drawing.Color.Black;
            this.panelNota.Location = new System.Drawing.Point(35, 232);
            this.panelNota.Name = "panelNota";
            this.panelNota.Size = new System.Drawing.Size(220, 1);
            this.panelNota.TabIndex = 34;
            this.panelNota.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelDeleted);
            this.panel4.Controls.Add(this.labelNota);
            this.panel4.Controls.Add(this.labelNrMatricol);
            this.panel4.Controls.Add(this.labelCodDisciplina);
            this.panel4.Controls.Add(this.textBoxNota);
            this.panel4.Controls.Add(this.comboBoxNrMatricol);
            this.panel4.Controls.Add(this.comboBoxDisciplina);
            this.panel4.Controls.Add(this.buttonUpdate);
            this.panel4.Controls.Add(this.textBoxDeleted);
            this.panel4.Controls.Add(this.panelDeleted);
            this.panel4.Controls.Add(this.buttonSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 375);
            this.panel4.TabIndex = 39;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelDeleted
            // 
            this.labelDeleted.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleted.ForeColor = System.Drawing.Color.Red;
            this.labelDeleted.Location = new System.Drawing.Point(35, 294);
            this.labelDeleted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeleted.Name = "labelDeleted";
            this.labelDeleted.Size = new System.Drawing.Size(220, 11);
            this.labelDeleted.TabIndex = 44;
            this.labelDeleted.Text = "label2";
            this.labelDeleted.Visible = false;
            // 
            // labelNota
            // 
            this.labelNota.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota.ForeColor = System.Drawing.Color.Red;
            this.labelNota.Location = new System.Drawing.Point(35, 236);
            this.labelNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(220, 11);
            this.labelNota.TabIndex = 43;
            this.labelNota.Text = "label2";
            this.labelNota.Visible = false;
            // 
            // labelNrMatricol
            // 
            this.labelNrMatricol.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrMatricol.ForeColor = System.Drawing.Color.Red;
            this.labelNrMatricol.Location = new System.Drawing.Point(35, 162);
            this.labelNrMatricol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNrMatricol.Name = "labelNrMatricol";
            this.labelNrMatricol.Size = new System.Drawing.Size(220, 11);
            this.labelNrMatricol.TabIndex = 42;
            this.labelNrMatricol.Text = "label2";
            this.labelNrMatricol.Visible = false;
            // 
            // labelCodDisciplina
            // 
            this.labelCodDisciplina.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodDisciplina.ForeColor = System.Drawing.Color.Red;
            this.labelCodDisciplina.Location = new System.Drawing.Point(35, 93);
            this.labelCodDisciplina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodDisciplina.Name = "labelCodDisciplina";
            this.labelCodDisciplina.Size = new System.Drawing.Size(220, 11);
            this.labelCodDisciplina.TabIndex = 41;
            this.labelCodDisciplina.Text = "label2";
            this.labelCodDisciplina.Visible = false;
            // 
            // comboBoxNrMatricol
            // 
            this.comboBoxNrMatricol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNrMatricol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNrMatricol.FormattingEnabled = true;
            this.comboBoxNrMatricol.Location = new System.Drawing.Point(35, 127);
            this.comboBoxNrMatricol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNrMatricol.Name = "comboBoxNrMatricol";
            this.comboBoxNrMatricol.Size = new System.Drawing.Size(221, 30);
            this.comboBoxNrMatricol.TabIndex = 40;
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(35, 55);
            this.comboBoxDisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(221, 30);
            this.comboBoxDisciplina.TabIndex = 39;
            this.comboBoxDisciplina.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplina_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 2;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonUpdate.Location = new System.Drawing.Point(35, 327);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(83, 29);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxDeleted
            // 
            this.textBoxDeleted.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxDeleted.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textBoxDeleted.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDeleted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBoxDeleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textBoxDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeleted.FormattingEnabled = true;
            this.textBoxDeleted.ItemHeight = 20;
            this.textBoxDeleted.Items.AddRange(new object[] {
            "1",
            "0"});
            this.textBoxDeleted.Location = new System.Drawing.Point(35, 263);
            this.textBoxDeleted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDeleted.Name = "textBoxDeleted";
            this.textBoxDeleted.Size = new System.Drawing.Size(221, 28);
            this.textBoxDeleted.TabIndex = 38;
            // 
            // panelDeleted
            // 
            this.panelDeleted.BackColor = System.Drawing.Color.Black;
            this.panelDeleted.Location = new System.Drawing.Point(35, 291);
            this.panelDeleted.Name = "panelDeleted";
            this.panelDeleted.Size = new System.Drawing.Size(220, 1);
            this.panelDeleted.TabIndex = 37;
            // 
            // FormAddNoteCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddNoteCatalog";
            this.Load += new System.EventHandler(this.FormAddNoteCatalog_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerErrorCatalog;
        private System.Windows.Forms.Panel panelDisciplina;
        private System.Windows.Forms.Panel panelNrMatricol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNota;
        public System.Windows.Forms.TextBox textBoxNota;
        public System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ComboBox textBoxDeleted;
        private System.Windows.Forms.Panel panelDeleted;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.ComboBox comboBoxNrMatricol;
        public System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Label labelCodDisciplina;
        private System.Windows.Forms.Label labelNrMatricol;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Label labelDeleted;
    }
}