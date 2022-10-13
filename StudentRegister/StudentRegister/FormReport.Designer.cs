
namespace TemaProiectPOO
{
    partial class FormReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet17 = new TemaProiectPOO.dataBaseStudentsDataSet17();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseStudentsDataSet14 = new TemaProiectPOO.dataBaseStudentsDataSet14();
            this.tableNotesTableAdapter1 = new TemaProiectPOO.dataBaseStudentsDataSet14TableAdapters.TableNotesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataBaseStudentsDataSet15 = new TemaProiectPOO.dataBaseStudentsDataSet15();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableNotesTableAdapter2 = new TemaProiectPOO.dataBaseStudentsDataSet15TableAdapters.TableNotesTableAdapter();
            this.dataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new TemaProiectPOO.DataSet1();
            this.dataSet11BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tableNotesTableAdapter3 = new TemaProiectPOO.dataBaseStudentsDataSet17TableAdapters.TableNotesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet14)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "TableNotes";
            this.bindingSource3.DataSource = this.dataBaseStudentsDataSet17;
            // 
            // dataBaseStudentsDataSet17
            // 
            this.dataBaseStudentsDataSet17.DataSetName = "dataBaseStudentsDataSet17";
            this.dataBaseStudentsDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TableNotes";
            this.bindingSource1.DataSource = this.dataBaseStudentsDataSet14;
            // 
            // dataBaseStudentsDataSet14
            // 
            this.dataBaseStudentsDataSet14.DataSetName = "dataBaseStudentsDataSet14";
            this.dataBaseStudentsDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableNotesTableAdapter1
            // 
            this.tableNotesTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.reportViewer3);
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 422);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource3;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "TemaProiectPOO.Report1.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1022, 422);
            this.reportViewer3.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.buttonExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonExport.FlatAppearance.BorderSize = 3;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonExport.Location = new System.Drawing.Point(24, 29);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(124, 46);
            this.buttonExport.TabIndex = 10;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonRefresh);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonExport);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 101);
            this.panel2.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 3;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.buttonRefresh.Location = new System.Drawing.Point(156, 29);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(124, 46);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Search Data";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Location = new System.Drawing.Point(464, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 22);
            this.panel3.TabIndex = 11;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxSearch.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.Location = new System.Drawing.Point(283, 0);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(253, 22);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // dataBaseStudentsDataSet15
            // 
            this.dataBaseStudentsDataSet15.DataSetName = "dataBaseStudentsDataSet15";
            this.dataBaseStudentsDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "TableNotes";
            this.bindingSource2.DataSource = this.dataBaseStudentsDataSet15;
            // 
            // tableNotesTableAdapter2
            // 
            this.tableNotesTableAdapter2.ClearBeforeFill = true;
            // 
            // dataSet11BindingSource
            // 
            this.dataSet11BindingSource.DataSource = this.dataSet11;
            this.dataSet11BindingSource.Position = 0;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet11BindingSource1
            // 
            this.dataSet11BindingSource1.DataSource = this.dataSet11;
            this.dataSet11BindingSource1.Position = 0;
            // 
            // dataSet11BindingSource2
            // 
            this.dataSet11BindingSource2.DataSource = this.dataSet11;
            this.dataSet11BindingSource2.Position = 0;
            // 
            // dataSet11BindingSource3
            // 
            this.dataSet11BindingSource3.DataSource = this.dataSet11;
            this.dataSet11BindingSource3.Position = 0;
            // 
            // tableNotesTableAdapter3
            // 
            this.tableNotesTableAdapter3.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.ClientSize = new System.Drawing.Size(1022, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet14)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseStudentsDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TableNotesBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.TableNotesTableAdapter TableNotesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private dataBaseStudentsDataSet14 dataBaseStudentsDataSet14;
        private System.Windows.Forms.BindingSource bindingSource1;
        private dataBaseStudentsDataSet14TableAdapters.TableNotesTableAdapter tableNotesTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private dataBaseStudentsDataSet15 dataBaseStudentsDataSet15;
        private System.Windows.Forms.BindingSource bindingSource2;
        private dataBaseStudentsDataSet15TableAdapters.TableNotesTableAdapter tableNotesTableAdapter2;
        private System.Windows.Forms.BindingSource dataSet11BindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource dataSet11BindingSource1;
        private System.Windows.Forms.BindingSource dataSet11BindingSource2;
        private System.Windows.Forms.BindingSource dataSet11BindingSource3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private dataBaseStudentsDataSet17 dataBaseStudentsDataSet17;
        private System.Windows.Forms.BindingSource bindingSource3;
        private dataBaseStudentsDataSet17TableAdapters.TableNotesTableAdapter tableNotesTableAdapter3;
    }
}