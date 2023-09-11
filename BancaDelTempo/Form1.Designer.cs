namespace BancaDelTempo
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblTimeLive = new System.Windows.Forms.Label();
            this.timerTimeLive = new System.Windows.Forms.Timer(this.components);
            this.pn1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelRegistrati = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxBank = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimeLive
            // 
            this.lblTimeLive.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLive.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTimeLive.Location = new System.Drawing.Point(255, 9);
            this.lblTimeLive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeLive.Name = "lblTimeLive";
            this.lblTimeLive.Size = new System.Drawing.Size(124, 50);
            this.lblTimeLive.TabIndex = 1;
            this.lblTimeLive.Text = "HH : mm";
            this.lblTimeLive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerTimeLive
            // 
            this.timerTimeLive.Interval = 1000;
            this.timerTimeLive.Tick += new System.EventHandler(this.timerTimeLive_Tick);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pn1.Location = new System.Drawing.Point(43, 269);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(300, 1);
            this.pn1.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnLogin.Location = new System.Drawing.Point(43, 425);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 46);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "ACCEDI";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxUsername.Location = new System.Drawing.Point(83, 236);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(260, 26);
            this.textBoxUsername.TabIndex = 9;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPassword.Location = new System.Drawing.Point(83, 306);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(260, 26);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Location = new System.Drawing.Point(43, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 12;
            // 
            // linkLabelRegistrati
            // 
            this.linkLabelRegistrati.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistrati.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.linkLabelRegistrati.LinkColor = System.Drawing.Color.MediumTurquoise;
            this.linkLabelRegistrati.Location = new System.Drawing.Point(43, 370);
            this.linkLabelRegistrati.Name = "linkLabelRegistrati";
            this.linkLabelRegistrati.Size = new System.Drawing.Size(300, 40);
            this.linkLabelRegistrati.TabIndex = 16;
            this.linkLabelRegistrati.TabStop = true;
            this.linkLabelRegistrati.Text = "Registrati";
            this.linkLabelRegistrati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelRegistrati.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistrati_LinkClicked);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::BancaDelTempo.Properties.Resources.hide;
            this.pictureBoxPassword.Location = new System.Drawing.Point(43, 299);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(34, 38);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 14;
            this.pictureBoxPassword.TabStop = false;
            this.pictureBoxPassword.Click += new System.EventHandler(this.pictureBoxPassword_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::BancaDelTempo.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(43, 229);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(34, 38);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 11;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxBank
            // 
            this.pictureBoxBank.Image = global::BancaDelTempo.Properties.Resources.bank;
            this.pictureBoxBank.Location = new System.Drawing.Point(132, 63);
            this.pictureBoxBank.Name = "pictureBoxBank";
            this.pictureBoxBank.Size = new System.Drawing.Size(126, 118);
            this.pictureBoxBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBank.TabIndex = 10;
            this.pictureBoxBank.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(390, 517);
            this.Controls.Add(this.linkLabelRegistrati);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.pictureBoxBank);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.lblTimeLive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banca del Tempo > Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimeLive;
        private System.Windows.Forms.Timer timerTimeLive;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.PictureBox pictureBoxBank;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelRegistrati;
    }
}

