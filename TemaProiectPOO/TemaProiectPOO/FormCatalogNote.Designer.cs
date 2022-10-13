
namespace TemaProiectPOO
{
    partial class FormCatalogNote
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
            this.tableNotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet2 = new TemaProiectPOO.dataBaseStudentsDataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCatalogNote = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrmatricolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableNotesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet12 = new TemaProiectPOO.dataBaseStudentsDataSet12();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonRefreshCatalogNote = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableNotesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet9 = new TemaProiectPOO.dataBaseStudentsDataSet9();
            this.tableNotesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet6 = new TemaProiectPOO.dataBaseStudentsDataSet6();
            this.tableNotesTableAdapter = new TemaProiectPOO.dataBaseStudentsDataSet2TableAdapters.TableNotesTableAdapter();
            this.dataBaseStudentsDataSet4 = new TemaProiectPOO.dataBaseStudentsDataSet4();
            this.tableDisciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableDisciplineTableAdapter = new TemaProiectPOO.dataBaseStudentsDataSet4TableAdapters.TableDisciplineTableAdapter();
            this.dataBaseStudentsDataSet5 = new TemaProiectPOO.dataBaseStudentsDataSet5();
            this.tableDisciplineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableDisciplineTableAdapter1 = new TemaProiectPOO.dataBaseStudentsDataSet5TableAdapters.TableDisciplineTableAdapter();
            this.tableNotesTableAdapter1 = new TemaProiectPOO.dataBaseStudentsDataSet6TableAdapters.TableNotesTableAdapter();
            this.tableNotesTableAdapter2 = new TemaProiectPOO.dataBaseStudentsDataSet9TableAdapters.TableNotesTableAdapter();
            this.tableNotesTableAdapter3 = new TemaProiectPOO.dataBaseStudentsDataSet12TableAdapters.TableNotesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableNotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNotesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet12)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableNotesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNotesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplineBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableNotesBindingSource
            // 
            this.tableNotesBindingSource.DataMember = "TableNotes";
            this.tableNotesBindingSource.DataSource = this.dataBaseStudentsDataSet2;
            // 
            // dataBaseStudentsDataSet2
            // 
            this.dataBaseStudentsDataSet2.DataSetName = "dataBaseStudentsDataSet2";
            this.dataBaseStudentsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCatalogNote);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 422);
            this.panel1.TabIndex = 2;
            // 
            // dgvCatalogNote
            // 
            this.dgvCatalogNote.AllowUserToAddRows = false;
            this.dgvCatalogNote.AllowUserToDeleteRows = false;
            this.dgvCatalogNote.AllowUserToResizeColumns = false;
            this.dgvCatalogNote.AllowUserToResizeRows = false;
            this.dgvCatalogNote.AutoGenerateColumns = false;
            this.dgvCatalogNote.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvCatalogNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCatalogNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.coddisciplinaDataGridViewTextBoxColumn,
            this.nrmatricolDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.stersDataGridViewTextBoxColumn,
            this.Edit,
            this.DeleteButton1});
            this.dgvCatalogNote.DataSource = this.tableNotesBindingSource3;
            this.dgvCatalogNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatalogNote.Location = new System.Drawing.Point(0, 74);
            this.dgvCatalogNote.Name = "dgvCatalogNote";
            this.dgvCatalogNote.ReadOnly = true;
            this.dgvCatalogNote.RowHeadersVisible = false;
            this.dgvCatalogNote.RowHeadersWidth = 51;
            this.dgvCatalogNote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogNote.Size = new System.Drawing.Size(766, 348);
            this.dgvCatalogNote.TabIndex = 4;
            this.dgvCatalogNote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogNote_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.DataPropertyName = "Edit";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "EDIT";
            this.Edit.ToolTipText = "EDIT";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // DeleteButton1
            // 
            this.DeleteButton1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteButton1.DataPropertyName = "DeleteButton";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.DeleteButton1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton1.HeaderText = "";
            this.DeleteButton1.MinimumWidth = 6;
            this.DeleteButton1.Name = "DeleteButton1";
            this.DeleteButton1.ReadOnly = true;
            this.DeleteButton1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteButton1.Text = "DELETE";
            this.DeleteButton1.ToolTipText = "DELETE";
            this.DeleteButton1.UseColumnTextForButtonValue = true;
            // 
            // tableNotesBindingSource3
            // 
            this.tableNotesBindingSource3.DataMember = "TableNotes";
            this.tableNotesBindingSource3.DataSource = this.dataBaseStudentsDataSet12;
            // 
            // dataBaseStudentsDataSet12
            // 
            this.dataBaseStudentsDataSet12.DataSetName = "dataBaseStudentsDataSet12";
            this.dataBaseStudentsDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonExport);
            this.panel2.Controls.Add(this.buttonRefreshCatalogNote);
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
            this.panel3.TabIndex = 9;
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
            this.textBoxSearch.TabIndex = 7;
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
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonRefreshCatalogNote
            // 
            this.buttonRefreshCatalogNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefreshCatalogNote.FlatAppearance.BorderSize = 3;
            this.buttonRefreshCatalogNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshCatalogNote.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshCatalogNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefreshCatalogNote.Location = new System.Drawing.Point(105, 30);
            this.buttonRefreshCatalogNote.Name = "buttonRefreshCatalogNote";
            this.buttonRefreshCatalogNote.Size = new System.Drawing.Size(93, 37);
            this.buttonRefreshCatalogNote.TabIndex = 4;
            this.buttonRefreshCatalogNote.Text = "Refresh";
            this.buttonRefreshCatalogNote.UseVisualStyleBackColor = true;
            this.buttonRefreshCatalogNote.Click += new System.EventHandler(this.buttonRefreshCatalogNote_Click);
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
            // tableNotesBindingSource2
            // 
            this.tableNotesBindingSource2.DataMember = "TableNotes";
            this.tableNotesBindingSource2.DataSource = this.dataBaseStudentsDataSet9;
            // 
            // dataBaseStudentsDataSet9
            // 
            this.dataBaseStudentsDataSet9.DataSetName = "dataBaseStudentsDataSet9";
            this.dataBaseStudentsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableNotesBindingSource1
            // 
            this.tableNotesBindingSource1.DataMember = "TableNotes";
            this.tableNotesBindingSource1.DataSource = this.dataBaseStudentsDataSet6;
            // 
            // dataBaseStudentsDataSet6
            // 
            this.dataBaseStudentsDataSet6.DataSetName = "dataBaseStudentsDataSet6";
            this.dataBaseStudentsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableNotesTableAdapter
            // 
            this.tableNotesTableAdapter.ClearBeforeFill = true;
            // 
            // dataBaseStudentsDataSet4
            // 
            this.dataBaseStudentsDataSet4.DataSetName = "dataBaseStudentsDataSet4";
            this.dataBaseStudentsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDisciplineBindingSource
            // 
            this.tableDisciplineBindingSource.DataMember = "TableDiscipline";
            this.tableDisciplineBindingSource.DataSource = this.dataBaseStudentsDataSet4;
            // 
            // tableDisciplineTableAdapter
            // 
            this.tableDisciplineTableAdapter.ClearBeforeFill = true;
            // 
            // dataBaseStudentsDataSet5
            // 
            this.dataBaseStudentsDataSet5.DataSetName = "dataBaseStudentsDataSet5";
            this.dataBaseStudentsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDisciplineBindingSource1
            // 
            this.tableDisciplineBindingSource1.DataMember = "TableDiscipline";
            this.tableDisciplineBindingSource1.DataSource = this.dataBaseStudentsDataSet5;
            // 
            // tableDisciplineTableAdapter1
            // 
            this.tableDisciplineTableAdapter1.ClearBeforeFill = true;
            // 
            // tableNotesTableAdapter1
            // 
            this.tableNotesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableNotesTableAdapter2
            // 
            this.tableNotesTableAdapter2.ClearBeforeFill = true;
            // 
            // tableNotesTableAdapter3
            // 
            this.tableNotesTableAdapter3.ClearBeforeFill = true;
            // 
            // FormCatalogNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 422);
            this.Controls.Add(this.panel1);
            this.Name = "FormCatalogNote";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.FormCatalogNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableNotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNotesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet12)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableNotesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNotesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisciplineBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private dataBaseStudentsDataSet2 dataBaseStudentsDataSet2;
        private System.Windows.Forms.BindingSource tableNotesBindingSource;
        private dataBaseStudentsDataSet2TableAdapters.TableNotesTableAdapter tableNotesTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRefreshCatalogNote;
        private System.Windows.Forms.TextBox textBoxSearch;
        private dataBaseStudentsDataSet4 dataBaseStudentsDataSet4;
        private System.Windows.Forms.BindingSource tableDisciplineBindingSource;
        private dataBaseStudentsDataSet4TableAdapters.TableDisciplineTableAdapter tableDisciplineTableAdapter;
        private dataBaseStudentsDataSet5 dataBaseStudentsDataSet5;
        private System.Windows.Forms.BindingSource tableDisciplineBindingSource1;
        private dataBaseStudentsDataSet5TableAdapters.TableDisciplineTableAdapter tableDisciplineTableAdapter1;
        private dataBaseStudentsDataSet6 dataBaseStudentsDataSet6;
        private System.Windows.Forms.BindingSource tableNotesBindingSource1;
        private dataBaseStudentsDataSet6TableAdapters.TableNotesTableAdapter tableNotesTableAdapter1;
        private dataBaseStudentsDataSet9 dataBaseStudentsDataSet9;
        private System.Windows.Forms.BindingSource tableNotesBindingSource2;
        private dataBaseStudentsDataSet9TableAdapters.TableNotesTableAdapter tableNotesTableAdapter2;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel3;
        private dataBaseStudentsDataSet12 dataBaseStudentsDataSet12;
        private System.Windows.Forms.BindingSource tableNotesBindingSource3;
        private dataBaseStudentsDataSet12TableAdapters.TableNotesTableAdapter tableNotesTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddisciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrmatricolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton1;
        public System.Windows.Forms.DataGridView dgvCatalogNote;
    }
}