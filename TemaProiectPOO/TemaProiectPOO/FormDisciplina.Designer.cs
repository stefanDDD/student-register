
namespace TemaProiectPOO
{
    partial class FormDisciplina
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
            this.tableDisciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet1 = new TemaProiectPOO.dataBaseStudentsDataSet1();
            this.dataBaseStudentsDataSet = new TemaProiectPOO.dataBaseStudentsDataSet();
            this.dataBaseStudentsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableDisciplineTableAdapter = new TemaProiectPOO.dataBaseStudentsDataSet1TableAdapters.TableDisciplineTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonRefreshDisciplina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDisciplina = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcrediteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editbutton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletebbutton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableDisciplinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet11 = new TemaProiectPOO.dataBaseStudentsDataSet11();
            this.tableDisciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet8 = new TemaProiectPOO.dataBaseStudentsDataSet8();
            this.tableDisciplineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet7 = new TemaProiectPOO.dataBaseStudentsDataSet7();
            this.tableDisciplineTableAdapter1 = new TemaProiectPOO.dataBaseStudentsDataSet7TableAdapters.TableDisciplineTableAdapter();
            this.tableDisciplinaTableAdapter = new TemaProiectPOO.dataBaseStudentsDataSet8TableAdapters.TableDisciplinaTableAdapter();
            this.tableDisciplinaTableAdapter1 = new TemaProiectPOO.dataBaseStudentsDataSet11TableAdapters.TableDisciplinaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplineBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDisciplineBindingSource
            // 
            this.tableDisciplineBindingSource.DataMember = "TableDiscipline";
            this.tableDisciplineBindingSource.DataSource = this.dataBaseStudentsDataSet1;
            // 
            // dataBaseStudentsDataSet1
            // 
            this.dataBaseStudentsDataSet1.DataSetName = "dataBaseStudentsDataSet1";
            this.dataBaseStudentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBaseStudentsDataSet
            // 
            this.dataBaseStudentsDataSet.DataSetName = "dataBaseStudentsDataSet";
            this.dataBaseStudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBaseStudentsDataSetBindingSource
            // 
            this.dataBaseStudentsDataSetBindingSource.DataSource = this.dataBaseStudentsDataSet;
            this.dataBaseStudentsDataSetBindingSource.Position = 0;
            // 
            // tableDisciplineTableAdapter
            // 
            this.tableDisciplineTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonExport);
            this.panel2.Controls.Add(this.buttonRefreshDisciplina);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 74);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Location = new System.Drawing.Point(548, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 20);
            this.panel3.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxSearch.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.Location = new System.Drawing.Point(18, 0);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(191, 20);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonExport
            // 
            this.buttonExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonExport.FlatAppearance.BorderSize = 3;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonExport.Location = new System.Drawing.Point(204, 30);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(93, 37);
            this.buttonExport.TabIndex = 7;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonRefreshDisciplina
            // 
            this.buttonRefreshDisciplina.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefreshDisciplina.FlatAppearance.BorderSize = 3;
            this.buttonRefreshDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshDisciplina.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshDisciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefreshDisciplina.Location = new System.Drawing.Point(105, 30);
            this.buttonRefreshDisciplina.Name = "buttonRefreshDisciplina";
            this.buttonRefreshDisciplina.Size = new System.Drawing.Size(93, 37);
            this.buttonRefreshDisciplina.TabIndex = 3;
            this.buttonRefreshDisciplina.Text = "Refresh";
            this.buttonRefreshDisciplina.UseVisualStyleBackColor = true;
            this.buttonRefreshDisciplina.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.button1.Location = new System.Drawing.Point(6, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDisciplina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 348);
            this.panel1.TabIndex = 4;
            // 
            // dgvDisciplina
            // 
            this.dgvDisciplina.AllowUserToAddRows = false;
            this.dgvDisciplina.AllowUserToDeleteRows = false;
            this.dgvDisciplina.AllowUserToResizeColumns = false;
            this.dgvDisciplina.AllowUserToResizeRows = false;
            this.dgvDisciplina.AutoGenerateColumns = false;
            this.dgvDisciplina.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.coddisciplinaDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.nrcrediteDataGridViewTextBoxColumn,
            this.stersDataGridViewTextBoxColumn,
            this.editbutton,
            this.deletebbutton});
            this.dgvDisciplina.DataSource = this.tableDisciplinaBindingSource1;
            this.dgvDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisciplina.Location = new System.Drawing.Point(0, 0);
            this.dgvDisciplina.Name = "dgvDisciplina";
            this.dgvDisciplina.ReadOnly = true;
            this.dgvDisciplina.RowHeadersVisible = false;
            this.dgvDisciplina.RowHeadersWidth = 51;
            this.dgvDisciplina.Size = new System.Drawing.Size(766, 348);
            this.dgvDisciplina.TabIndex = 1;
            this.dgvDisciplina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisciplina_CellContentClick_2);
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
            // coddisciplinaDataGridViewTextBoxColumn
            // 
            this.coddisciplinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coddisciplinaDataGridViewTextBoxColumn.DataPropertyName = "cod_disciplina";
            this.coddisciplinaDataGridViewTextBoxColumn.HeaderText = "Cod Disciplină";
            this.coddisciplinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coddisciplinaDataGridViewTextBoxColumn.Name = "coddisciplinaDataGridViewTextBoxColumn";
            this.coddisciplinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.coddisciplinaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nrcrediteDataGridViewTextBoxColumn
            // 
            this.nrcrediteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nrcrediteDataGridViewTextBoxColumn.DataPropertyName = "nr_credite";
            this.nrcrediteDataGridViewTextBoxColumn.HeaderText = "Număr Credite";
            this.nrcrediteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrcrediteDataGridViewTextBoxColumn.Name = "nrcrediteDataGridViewTextBoxColumn";
            this.nrcrediteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrcrediteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // editbutton
            // 
            this.editbutton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.editbutton.DataPropertyName = "EditButton";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.editbutton.DefaultCellStyle = dataGridViewCellStyle1;
            this.editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbutton.HeaderText = "";
            this.editbutton.MinimumWidth = 6;
            this.editbutton.Name = "editbutton";
            this.editbutton.ReadOnly = true;
            this.editbutton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editbutton.Text = "Edit";
            this.editbutton.ToolTipText = "Edit";
            this.editbutton.UseColumnTextForButtonValue = true;
            // 
            // deletebbutton
            // 
            this.deletebbutton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deletebbutton.DataPropertyName = "DeleteButton";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.deletebbutton.DefaultCellStyle = dataGridViewCellStyle2;
            this.deletebbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebbutton.HeaderText = "";
            this.deletebbutton.MinimumWidth = 6;
            this.deletebbutton.Name = "deletebbutton";
            this.deletebbutton.ReadOnly = true;
            this.deletebbutton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deletebbutton.Text = "DELETE";
            this.deletebbutton.ToolTipText = "DELETE";
            this.deletebbutton.UseColumnTextForButtonValue = true;
            // 
            // tableDisciplinaBindingSource1
            // 
            this.tableDisciplinaBindingSource1.DataMember = "TableDisciplina";
            this.tableDisciplinaBindingSource1.DataSource = this.dataBaseStudentsDataSet11;
            // 
            // dataBaseStudentsDataSet11
            // 
            this.dataBaseStudentsDataSet11.DataSetName = "dataBaseStudentsDataSet11";
            this.dataBaseStudentsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDisciplinaBindingSource
            // 
            this.tableDisciplinaBindingSource.DataMember = "TableDisciplina";
            this.tableDisciplinaBindingSource.DataSource = this.dataBaseStudentsDataSet8;
            // 
            // dataBaseStudentsDataSet8
            // 
            this.dataBaseStudentsDataSet8.DataSetName = "dataBaseStudentsDataSet8";
            this.dataBaseStudentsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDisciplineBindingSource1
            // 
            this.tableDisciplineBindingSource1.DataMember = "TableDiscipline";
            this.tableDisciplineBindingSource1.DataSource = this.dataBaseStudentsDataSet7;
            // 
            // dataBaseStudentsDataSet7
            // 
            this.dataBaseStudentsDataSet7.DataSetName = "dataBaseStudentsDataSet7";
            this.dataBaseStudentsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDisciplineTableAdapter1
            // 
            this.tableDisciplineTableAdapter1.ClearBeforeFill = true;
            // 
            // tableDisciplinaTableAdapter
            // 
            this.tableDisciplinaTableAdapter.ClearBeforeFill = true;
            // 
            // tableDisciplinaTableAdapter1
            // 
            this.tableDisciplinaTableAdapter1.ClearBeforeFill = true;
            // 
            // FormDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormDisciplina";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplinaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplineBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataBaseStudentsDataSetBindingSource;
        private dataBaseStudentsDataSet dataBaseStudentsDataSet;
        private dataBaseStudentsDataSet1 dataBaseStudentsDataSet1;
        private System.Windows.Forms.BindingSource tableDisciplineBindingSource;
        private dataBaseStudentsDataSet1TableAdapters.TableDisciplineTableAdapter tableDisciplineTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonRefreshDisciplina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private dataBaseStudentsDataSet7 dataBaseStudentsDataSet7;
        private System.Windows.Forms.BindingSource tableDisciplineBindingSource1;
        private dataBaseStudentsDataSet7TableAdapters.TableDisciplineTableAdapter tableDisciplineTableAdapter1;
        private dataBaseStudentsDataSet8 dataBaseStudentsDataSet8;
        private System.Windows.Forms.BindingSource tableDisciplinaBindingSource;
        private dataBaseStudentsDataSet8TableAdapters.TableDisciplinaTableAdapter tableDisciplinaTableAdapter;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel3;
        private dataBaseStudentsDataSet11 dataBaseStudentsDataSet11;
        private System.Windows.Forms.BindingSource tableDisciplinaBindingSource1;
        private dataBaseStudentsDataSet11TableAdapters.TableDisciplinaTableAdapter tableDisciplinaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddisciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcrediteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editbutton;
        private System.Windows.Forms.DataGridViewButtonColumn deletebbutton;
        public System.Windows.Forms.DataGridView dgvDisciplina;
    }
}