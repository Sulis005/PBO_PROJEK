namespace PBO_PROJEK.Views
{
    partial class FrmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnDonatur = new System.Windows.Forms.Button();
            this.btnPengelola = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblDaftar = new System.Windows.Forms.LinkLabel();
            this.lblLupaPassword = new System.Windows.Forms.LinkLabel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(145, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(196, 139);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(72, 16);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "ReuseHub";
            // 
            // btnDonatur
            // 
            this.btnDonatur.Location = new System.Drawing.Point(117, 184);
            this.btnDonatur.Name = "btnDonatur";
            this.btnDonatur.Size = new System.Drawing.Size(94, 37);
            this.btnDonatur.TabIndex = 2;
            this.btnDonatur.Text = "Donatur";
            this.btnDonatur.UseVisualStyleBackColor = true;
            // 
            // btnPengelola
            // 
            this.btnPengelola.Location = new System.Drawing.Point(269, 184);
            this.btnPengelola.Name = "btnPengelola";
            this.btnPengelola.Size = new System.Drawing.Size(100, 37);
            this.btnPengelola.TabIndex = 3;
            this.btnPengelola.Text = "Pengelola";
            this.btnPengelola.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 236);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 321);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(173, 401);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblDaftar
            // 
            this.lblDaftar.AutoSize = true;
            this.lblDaftar.Location = new System.Drawing.Point(47, 470);
            this.lblDaftar.Name = "lblDaftar";
            this.lblDaftar.Size = new System.Drawing.Size(114, 16);
            this.lblDaftar.TabIndex = 7;
            this.lblDaftar.TabStop = true;
            this.lblDaftar.Text = "Lupa Password??";
            // 
            // lblLupaPassword
            // 
            this.lblLupaPassword.AutoSize = true;
            this.lblLupaPassword.Location = new System.Drawing.Point(47, 503);
            this.lblLupaPassword.Name = "lblLupaPassword";
            this.lblLupaPassword.Size = new System.Drawing.Size(200, 16);
            this.lblLupaPassword.TabIndex = 8;
            this.lblLupaPassword.TabStop = true;
            this.lblLupaPassword.Text = "Register kalo belom punya akun";
            this.lblLupaPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 271);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 22);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 359);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 22);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "Password";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLupaPassword);
            this.Controls.Add(this.lblDaftar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnPengelola);
            this.Controls.Add(this.btnDonatur);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnDonatur;
        private System.Windows.Forms.Button btnPengelola;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblDaftar;
        private System.Windows.Forms.LinkLabel lblLupaPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
    }
}