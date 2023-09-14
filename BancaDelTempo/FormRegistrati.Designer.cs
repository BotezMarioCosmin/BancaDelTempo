namespace BancaDelTempo
{
    partial class FormRegistrati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrati));
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTimeLive = new System.Windows.Forms.Label();
            this.timerTimeLive = new System.Windows.Forms.Timer(this.components);
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.pn1 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxBank = new System.Windows.Forms.PictureBox();
            this.textBoxZona = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBank)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegistrati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrati.FlatAppearance.BorderSize = 0;
            this.btnRegistrati.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrati.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnRegistrati.Location = new System.Drawing.Point(70, 654);
            this.btnRegistrati.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.Size = new System.Drawing.Size(450, 71);
            this.btnRegistrati.TabIndex = 6;
            this.btnRegistrati.Text = "REGISTRATI";
            this.btnRegistrati.UseVisualStyleBackColor = false;
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::BancaDelTempo.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(18, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 77);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTimeLive
            // 
            this.lblTimeLive.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLive.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTimeLive.Location = new System.Drawing.Point(382, 14);
            this.lblTimeLive.Name = "lblTimeLive";
            this.lblTimeLive.Size = new System.Drawing.Size(186, 77);
            this.lblTimeLive.TabIndex = 8;
            this.lblTimeLive.Text = "HH : mm";
            this.lblTimeLive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerTimeLive
            // 
            this.timerTimeLive.Interval = 1000;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxUsername.Location = new System.Drawing.Point(70, 289);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(450, 39);
            this.textBoxUsername.TabIndex = 11;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pn1.Location = new System.Drawing.Point(70, 340);
            this.pn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(450, 2);
            this.pn1.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPassword.Location = new System.Drawing.Point(70, 351);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(390, 39);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Location = new System.Drawing.Point(70, 401);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 2);
            this.panel1.TabIndex = 12;
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxCognome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCognome.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCognome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxCognome.Location = new System.Drawing.Point(70, 412);
            this.textBoxCognome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.Size = new System.Drawing.Size(450, 39);
            this.textBoxCognome.TabIndex = 15;
            this.textBoxCognome.Text = "Cognome";
            this.textBoxCognome.Click += new System.EventHandler(this.textBoxCognome_Click);
            this.textBoxCognome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCognome_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Location = new System.Drawing.Point(70, 463);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 2);
            this.panel2.TabIndex = 14;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxNome.Location = new System.Drawing.Point(70, 474);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(450, 39);
            this.textBoxNome.TabIndex = 17;
            this.textBoxNome.Text = "Nome";
            this.textBoxNome.Click += new System.EventHandler(this.textBoxNome_Click);
            this.textBoxNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNome_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Location = new System.Drawing.Point(70, 524);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 2);
            this.panel3.TabIndex = 16;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefono.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxTelefono.Location = new System.Drawing.Point(70, 535);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(450, 39);
            this.textBoxTelefono.TabIndex = 19;
            this.textBoxTelefono.Tag = "";
            this.textBoxTelefono.Text = "Telefono";
            this.textBoxTelefono.Click += new System.EventHandler(this.textBoxTelefono_Click);
            this.textBoxTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTelefono_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Location = new System.Drawing.Point(70, 586);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 2);
            this.panel4.TabIndex = 18;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::BancaDelTempo.Properties.Resources.hide;
            this.pictureBoxPassword.Location = new System.Drawing.Point(469, 345);
            this.pictureBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(51, 52);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 20;
            this.pictureBoxPassword.TabStop = false;
            this.pictureBoxPassword.Click += new System.EventHandler(this.pictureBoxPassword_Click);
            // 
            // pictureBoxBank
            // 
            this.pictureBoxBank.Image = global::BancaDelTempo.Properties.Resources.bank;
            this.pictureBoxBank.Location = new System.Drawing.Point(198, 97);
            this.pictureBoxBank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxBank.Name = "pictureBoxBank";
            this.pictureBoxBank.Size = new System.Drawing.Size(189, 182);
            this.pictureBoxBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBank.TabIndex = 21;
            this.pictureBoxBank.TabStop = false;
            // 
            // textBoxZona
            // 
            this.textBoxZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxZona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZona.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZona.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxZona.Location = new System.Drawing.Point(70, 598);
            this.textBoxZona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxZona.Name = "textBoxZona";
            this.textBoxZona.Size = new System.Drawing.Size(450, 39);
            this.textBoxZona.TabIndex = 23;
            this.textBoxZona.Tag = "";
            this.textBoxZona.Text = "Zona";
            this.textBoxZona.Click += new System.EventHandler(this.textBoxZona_Click);
            this.textBoxZona.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxZona_KeyDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel5.Location = new System.Drawing.Point(70, 649);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 2);
            this.panel5.TabIndex = 22;
            // 
            // FormRegistrati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(591, 802);
            this.Controls.Add(this.textBoxZona);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBoxBank);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxCognome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.lblTimeLive);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegistrati);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormRegistrati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banca del Tempo > Registrati";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrati;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTimeLive;
        private System.Windows.Forms.Timer timerTimeLive;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCognome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxBank;
        private System.Windows.Forms.TextBox textBoxZona;
        private System.Windows.Forms.Panel panel5;
    }
}