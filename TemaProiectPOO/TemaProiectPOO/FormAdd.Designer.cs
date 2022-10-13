
namespace TemaProiectPOO
{
    partial class FormAddStudents
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
            this.panelError = new System.Windows.Forms.Panel();
            this.labelComboBox = new System.Windows.Forms.Label();
            this.panelNumarMatricol = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNrMatricol = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDeleted = new System.Windows.Forms.ComboBox();
            this.panelComboBox = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelSurname = new System.Windows.Forms.Panel();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.panelNrMatricol = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerError = new System.Windows.Forms.Timer(this.components);
            this.panelError.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelError
            // 
            this.panelError.BackColor = System.Drawing.Color.White;
            this.panelError.Controls.Add(this.labelComboBox);
            this.panelError.Controls.Add(this.panelNumarMatricol);
            this.panelError.Controls.Add(this.panel3);
            this.panelError.Controls.Add(this.labelSurname);
            this.panelError.Controls.Add(this.labelName);
            this.panelError.Controls.Add(this.textBoxDeleted);
            this.panelError.Controls.Add(this.panelComboBox);
            this.panelError.Controls.Add(this.buttonUpdate);
            this.panelError.Controls.Add(this.buttonSave);
            this.panelError.Controls.Add(this.panelSurname);
            this.panelError.Controls.Add(this.textBoxSurname);
            this.panelError.Controls.Add(this.panelName);
            this.panelError.Controls.Add(this.panelNrMatricol);
            this.panelError.Controls.Add(this.textBoxName);
            this.panelError.Controls.Add(this.textBoxNumber);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelError.ForeColor = System.Drawing.Color.Red;
            this.panelError.Location = new System.Drawing.Point(0, 79);
            this.panelError.Margin = new System.Windows.Forms.Padding(4);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(389, 471);
            this.panelError.TabIndex = 0;
            this.panelError.Paint += new System.Windows.Forms.PaintEventHandler(this.panelError_Paint);
            // 
            // labelComboBox
            // 
            this.labelComboBox.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComboBox.Location = new System.Drawing.Point(56, 341);
            this.labelComboBox.Name = "labelComboBox";
            this.labelComboBox.Size = new System.Drawing.Size(293, 13);
            this.labelComboBox.TabIndex = 24;
            this.labelComboBox.Text = "label3";
            this.labelComboBox.Visible = false;
            // 
            // panelNumarMatricol
            // 
            this.panelNumarMatricol.BackColor = System.Drawing.Color.Black;
            this.panelNumarMatricol.Location = new System.Drawing.Point(56, 93);
            this.panelNumarMatricol.Margin = new System.Windows.Forms.Padding(4);
            this.panelNumarMatricol.Name = "panelNumarMatricol";
            this.panelNumarMatricol.Size = new System.Drawing.Size(293, 1);
            this.panelNumarMatricol.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelNrMatricol);
            this.panel3.Location = new System.Drawing.Point(56, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 13);
            this.panel3.TabIndex = 1;
            // 
            // labelNrMatricol
            // 
            this.labelNrMatricol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNrMatricol.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrMatricol.Location = new System.Drawing.Point(0, 0);
            this.labelNrMatricol.Name = "labelNrMatricol";
            this.labelNrMatricol.Size = new System.Drawing.Size(293, 13);
            this.labelNrMatricol.TabIndex = 0;
            this.labelNrMatricol.Text = "label1";
            this.labelNrMatricol.Visible = false;
            // 
            // labelSurname
            // 
            this.labelSurname.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(56, 262);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(293, 13);
            this.labelSurname.TabIndex = 23;
            this.labelSurname.Text = "label3";
            this.labelSurname.Visible = false;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(56, 179);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(293, 13);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "label2";
            this.labelName.Visible = false;
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
            this.textBoxDeleted.ItemHeight = 25;
            this.textBoxDeleted.Items.AddRange(new object[] {
            "1",
            "0"});
            this.textBoxDeleted.Location = new System.Drawing.Point(56, 305);
            this.textBoxDeleted.Name = "textBoxDeleted";
            this.textBoxDeleted.Size = new System.Drawing.Size(293, 33);
            this.textBoxDeleted.TabIndex = 21;
            // 
            // panelComboBox
            // 
            this.panelComboBox.BackColor = System.Drawing.Color.Black;
            this.panelComboBox.Location = new System.Drawing.Point(56, 339);
            this.panelComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.panelComboBox.Name = "panelComboBox";
            this.panelComboBox.Size = new System.Drawing.Size(293, 1);
            this.panelComboBox.TabIndex = 20;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 2;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonUpdate.Location = new System.Drawing.Point(56, 372);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(111, 36);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonSave.Location = new System.Drawing.Point(56, 372);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 36);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelSurname
            // 
            this.panelSurname.BackColor = System.Drawing.Color.Black;
            this.panelSurname.Location = new System.Drawing.Point(56, 258);
            this.panelSurname.Margin = new System.Windows.Forms.Padding(4);
            this.panelSurname.Name = "panelSurname";
            this.panelSurname.Size = new System.Drawing.Size(293, 1);
            this.panelSurname.TabIndex = 15;
            this.panelSurname.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSurname.Location = new System.Drawing.Point(56, 219);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(293, 36);
            this.textBoxSurname.TabIndex = 13;
            this.textBoxSurname.Text = "Prenume";
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            this.textBoxSurname.Enter += new System.EventHandler(this.textBoxSurname_Enter);
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.Black;
            this.panelName.Location = new System.Drawing.Point(56, 174);
            this.panelName.Margin = new System.Windows.Forms.Padding(4);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(293, 1);
            this.panelName.TabIndex = 12;
            this.panelName.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panelNrMatricol
            // 
            this.panelNrMatricol.BackColor = System.Drawing.Color.Black;
            this.panelNrMatricol.Location = new System.Drawing.Point(56, 95);
            this.panelNrMatricol.Margin = new System.Windows.Forms.Padding(4);
            this.panelNrMatricol.Name = "panelNrMatricol";
            this.panelNrMatricol.Size = new System.Drawing.Size(293, 1);
            this.panelNrMatricol.TabIndex = 11;
            this.panelNrMatricol.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxName.Location = new System.Drawing.Point(56, 135);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(293, 36);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.Text = "Nume";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumber.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumber.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxNumber.Location = new System.Drawing.Point(56, 55);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumber.Multiline = true;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(293, 36);
            this.textBoxNumber.TabIndex = 9;
            this.textBoxNumber.Text = "Număr Matricol";
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            this.textBoxNumber.Enter += new System.EventHandler(this.textBoxNrMatricol_Enter);
            this.textBoxNumber.Leave += new System.EventHandler(this.textBoxNrMatricol_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 79);
            this.panel1.TabIndex = 0;
            // 
            // timerError
            // 
            this.timerError.Interval = 2000;
            this.timerError.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 550);
            this.Controls.Add(this.panelError);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddStudents";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelNrMatricol;
        private System.Windows.Forms.Panel panelSurname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerError;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxNumber;
        public System.Windows.Forms.TextBox textBoxSurname;
        public System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panelComboBox;
        public System.Windows.Forms.ComboBox textBoxDeleted;
        public System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNrMatricol;
        private System.Windows.Forms.Panel panelNumarMatricol;
        private System.Windows.Forms.Label labelComboBox;
    }
}