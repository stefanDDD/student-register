
namespace TemaProiectPOO
{
    partial class FormStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrmatricolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableStudentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet13 = new TemaProiectPOO.dataBaseStudentsDataSet13();
            this.tableStudentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet10 = new TemaProiectPOO.dataBaseStudentsDataSet10();
            this.tableStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet3 = new TemaProiectPOO.dataBaseStudentsDataSet3();
            this.tableStudentsTableAdapter = new TemaProiectPOO.dataBaseStudentsDataSet3TableAdapters.tableStudentsTableAdapter();
            this.tableStudentsTableAdapter1 = new TemaProiectPOO.dataBaseStudentsDataSet10TableAdapters.TableStudentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRefreshStudents = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tableStudentsTableAdapter2 = new TemaProiectPOO.dataBaseStudentsDataSet13TableAdapters.TableStudentsTableAdapter();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.dataGridViewStudents);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 91);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1021, 428);
            this.panelChildForm.TabIndex = 3;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AllowUserToResizeColumns = false;
            this.dataGridViewStudents.AllowUserToResizeRows = false;
            this.dataGridViewStudents.AutoGenerateColumns = false;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nrmatricolDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.stersDataGridViewTextBoxColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.dataGridViewStudents.DataSource = this.tableStudentsBindingSource2;
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudents.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1021, 428);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            this.dataGridViewStudents.Click += new System.EventHandler(this.dgvStudents_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nrmatricolDataGridViewTextBoxColumn
            // 
            this.nrmatricolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nrmatricolDataGridViewTextBoxColumn.DataPropertyName = "nr_matricol";
            this.nrmatricolDataGridViewTextBoxColumn.HeaderText = "Număr Matricol";
            this.nrmatricolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrmatricolDataGridViewTextBoxColumn.Name = "nrmatricolDataGridViewTextBoxColumn";
            this.nrmatricolDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrmatricolDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenumeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stersDataGridViewTextBoxColumn
            // 
            this.stersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stersDataGridViewTextBoxColumn.DataPropertyName = "sters";
            this.stersDataGridViewTextBoxColumn.HeaderText = "Șters";
            this.stersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stersDataGridViewTextBoxColumn.Name = "stersDataGridViewTextBoxColumn";
            this.stersDataGridViewTextBoxColumn.ReadOnly = true;
            this.stersDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditColumn.DataPropertyName = "Edit";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.EditColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.EditColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditColumn.HeaderText = "";
            this.EditColumn.MinimumWidth = 6;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditColumn.Text = "EDIT";
            this.EditColumn.ToolTipText = "EDIT";
            this.EditColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteColumn.DataPropertyName = "Delete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteColumn.Text = "DELETE";
            this.DeleteColumn.ToolTipText = "DELETE";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // tableStudentsBindingSource2
            // 
            this.tableStudentsBindingSource2.DataMember = "TableStudents";
            this.tableStudentsBindingSource2.DataSource = this.dataBaseStudentsDataSet13;
            // 
            // dataBaseStudentsDataSet13
            // 
            this.dataBaseStudentsDataSet13.DataSetName = "dataBaseStudentsDataSet13";
            this.dataBaseStudentsDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableStudentsBindingSource1
            // 
            this.tableStudentsBindingSource1.DataMember = "TableStudents";
            this.tableStudentsBindingSource1.DataSource = this.dataBaseStudentsDataSet10;
            // 
            // dataBaseStudentsDataSet10
            // 
            this.dataBaseStudentsDataSet10.DataSetName = "dataBaseStudentsDataSet10";
            this.dataBaseStudentsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableStudentsBindingSource
            // 
            this.tableStudentsBindingSource.DataMember = "tableStudents";
            this.tableStudentsBindingSource.DataSource = this.dataBaseStudentsDataSet3;
            // 
            // dataBaseStudentsDataSet3
            // 
            this.dataBaseStudentsDataSet3.DataSetName = "dataBaseStudentsDataSet3";
            this.dataBaseStudentsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableStudentsTableAdapter
            // 
            this.tableStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableStudentsTableAdapter1
            // 
            this.tableStudentsTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.button1.Location = new System.Drawing.Point(8, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRefreshStudents
            // 
            this.buttonRefreshStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefreshStudents.FlatAppearance.BorderSize = 3;
            this.buttonRefreshStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshStudents.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefreshStudents.Location = new System.Drawing.Point(140, 37);
            this.buttonRefreshStudents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshStudents.Name = "buttonRefreshStudents";
            this.buttonRefreshStudents.Size = new System.Drawing.Size(124, 46);
            this.buttonRefreshStudents.TabIndex = 4;
            this.buttonRefreshStudents.Text = "Refresh";
            this.buttonRefreshStudents.UseVisualStyleBackColor = true;
            this.buttonRefreshStudents.Click += new System.EventHandler(this.buttonRefreshStudents_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxSearch.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.Location = new System.Drawing.Point(26, 0);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(253, 25);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.buttonRefresh);
            this.panel2.Controls.Add(this.buttonRefreshStudents);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 91);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Location = new System.Drawing.Point(731, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 25);
            this.panel1.TabIndex = 4;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 3;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefresh.Location = new System.Drawing.Point(272, 37);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(124, 46);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Export";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableStudentsTableAdapter2
            // 
            this.tableStudentsTableAdapter2.ClearBeforeFill = true;
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 519);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStudents";
            this.Text = "FormStudents";
            this.Load += new System.EventHandler(this.FormStudentsDB_Load);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private dataBaseStudentsDataSet3 dataBaseStudentsDataSet3;
        private System.Windows.Forms.BindingSource tableStudentsBindingSource;
        private dataBaseStudentsDataSet3TableAdapters.tableStudentsTableAdapter tableStudentsTableAdapter;
        private dataBaseStudentsDataSet10 dataBaseStudentsDataSet10;
        private System.Windows.Forms.BindingSource tableStudentsBindingSource1;
        private dataBaseStudentsDataSet10TableAdapters.TableStudentsTableAdapter tableStudentsTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRefreshStudents;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel1;
        private dataBaseStudentsDataSet13 dataBaseStudentsDataSet13;
        private System.Windows.Forms.BindingSource tableStudentsBindingSource2;
        private dataBaseStudentsDataSet13TableAdapters.TableStudentsTableAdapter tableStudentsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrmatricolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}