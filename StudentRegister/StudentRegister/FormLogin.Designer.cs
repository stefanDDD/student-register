
namespace TemaProiectPOO
{
    partial class LogInForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelErrorUsernameText = new System.Windows.Forms.Panel();
            this.panelErrorPasswordText = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelErrorUsername = new System.Windows.Forms.Panel();
            this.labelErrorUsername = new System.Windows.Forms.Label();
            this.timerErrorUsername = new System.Windows.Forms.Timer(this.components);
            this.panelErrorPassword = new System.Windows.Forms.Panel();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panelErrorUsername.SuspendLayout();
            this.panelErrorPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(51, 199);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 22);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(51, 260);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // panelErrorUsernameText
            // 
            this.panelErrorUsernameText.BackColor = System.Drawing.Color.Black;
            this.panelErrorUsernameText.Location = new System.Drawing.Point(31, 220);
            this.panelErrorUsernameText.Name = "panelErrorUsernameText";
            this.panelErrorUsernameText.Size = new System.Drawing.Size(220, 1);
            this.panelErrorUsernameText.TabIndex = 7;
            // 
            // panelErrorPasswordText
            // 
            this.panelErrorPasswordText.BackColor = System.Drawing.Color.Black;
            this.panelErrorPasswordText.Location = new System.Drawing.Point(31, 284);
            this.panelErrorPasswordText.Name = "panelErrorPasswordText";
            this.panelErrorPasswordText.Size = new System.Drawing.Size(220, 1);
            this.panelErrorPasswordText.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.labelTitle.Location = new System.Drawing.Point(83, 129);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(139, 30);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "StudentDB";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(24, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "“Education is the most powerful weapon you can use to change the world.”";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelErrorUsername
            // 
            this.panelErrorUsername.Controls.Add(this.labelErrorUsername);
            this.panelErrorUsername.Location = new System.Drawing.Point(31, 223);
            this.panelErrorUsername.Margin = new System.Windows.Forms.Padding(2);
            this.panelErrorUsername.Name = "panelErrorUsername";
            this.panelErrorUsername.Size = new System.Drawing.Size(220, 11);
            this.panelErrorUsername.TabIndex = 14;
            // 
            // labelErrorUsername
            // 
            this.labelErrorUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelErrorUsername.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.labelErrorUsername.Location = new System.Drawing.Point(0, 0);
            this.labelErrorUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorUsername.Name = "labelErrorUsername";
            this.labelErrorUsername.Size = new System.Drawing.Size(220, 11);
            this.labelErrorUsername.TabIndex = 15;
            this.labelErrorUsername.Text = "label1";
            this.labelErrorUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelErrorUsername.Visible = false;
            this.labelErrorUsername.Click += new System.EventHandler(this.labelErrorUsername_Click);
            // 
            // timerErrorUsername
            // 
            this.timerErrorUsername.Interval = 2000;
            this.timerErrorUsername.Tick += new System.EventHandler(this.timerErrorUsername_Tick);
            // 
            // panelErrorPassword
            // 
            this.panelErrorPassword.Controls.Add(this.labelErrorPassword);
            this.panelErrorPassword.Location = new System.Drawing.Point(31, 287);
            this.panelErrorPassword.Margin = new System.Windows.Forms.Padding(2);
            this.panelErrorPassword.Name = "panelErrorPassword";
            this.panelErrorPassword.Size = new System.Drawing.Size(220, 11);
            this.panelErrorPassword.TabIndex = 16;
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelErrorPassword.Font = new System.Drawing.Font("Britannic Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPassword.Location = new System.Drawing.Point(0, 0);
            this.labelErrorPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(220, 11);
            this.labelErrorPassword.TabIndex = 17;
            this.labelErrorPassword.Text = "label2";
            this.labelErrorPassword.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TemaProiectPOO.Properties.Resources.password_icon_png_371054_free_icons_library_password_icon_png_808_980;
            this.pictureBox4.Location = new System.Drawing.Point(31, 261);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TemaProiectPOO.Properties.Resources._1727561;
            this.pictureBox3.Location = new System.Drawing.Point(31, 197);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TemaProiectPOO.Properties.Resources.logo_ro_RO__1_;
            this.pictureBox2.Location = new System.Drawing.Point(215, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TemaProiectPOO.Properties.Resources.logo_ro_RO;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = global::TemaProiectPOO.Properties.Resources._151_1516056_gold_graduation_cap_png_transparent_png_removebg_preview__1_;
            this.pictureBoxImage.Location = new System.Drawing.Point(106, 72);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 10;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panelErrorPassword);
            this.Controls.Add(this.panelErrorUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelErrorPasswordText);
            this.Controls.Add(this.panelErrorUsernameText);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogInForm_KeyDown);
            this.panelErrorUsername.ResumeLayout(false);
            this.panelErrorPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelErrorUsernameText;
        private System.Windows.Forms.Panel panelErrorPasswordText;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelErrorUsername;
        private System.Windows.Forms.Label labelErrorUsername;
        private System.Windows.Forms.Timer timerErrorUsername;
        private System.Windows.Forms.Panel panelErrorPassword;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}