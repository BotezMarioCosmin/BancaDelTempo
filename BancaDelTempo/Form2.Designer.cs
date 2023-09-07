namespace BancaDelTempo
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTimeLive = new System.Windows.Forms.Label();
            this.timerTimeLive = new System.Windows.Forms.Timer(this.components);
            this.lblDebito = new System.Windows.Forms.Label();
            this.pnlSoci = new System.Windows.Forms.Panel();
            this.textBoxAggiungiSocioTelefono = new System.Windows.Forms.TextBox();
            this.btnApriFileJSON = new System.Windows.Forms.Button();
            this.btnEliminaSocio = new System.Windows.Forms.Button();
            this.btnAggiungiSocio = new System.Windows.Forms.Button();
            this.textBoxAggiungiSocioNome = new System.Windows.Forms.TextBox();
            this.textBoxAggiungiSocioCognome = new System.Windows.Forms.TextBox();
            this.listViewElencoSoci = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAggiungiSocioDebito = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSegreteria = new System.Windows.Forms.Button();
            this.btnPrestazioni = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlSoci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btnPrestazioni);
            this.panel1.Controls.Add(this.btnSegreteria);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblTimeLive);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBoxUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 686);
            this.panel1.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblUser.Location = new System.Drawing.Point(3, 143);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(297, 54);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeLive
            // 
            this.lblTimeLive.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLive.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTimeLive.Location = new System.Drawing.Point(3, 579);
            this.lblTimeLive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeLive.Name = "lblTimeLive";
            this.lblTimeLive.Size = new System.Drawing.Size(297, 81);
            this.lblTimeLive.TabIndex = 3;
            this.lblTimeLive.Text = "HH : mm";
            this.lblTimeLive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTimeLive
            // 
            this.timerTimeLive.Interval = 1000;
            this.timerTimeLive.Tick += new System.EventHandler(this.timerTimeLive_Tick);
            // 
            // lblDebito
            // 
            this.lblDebito.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebito.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblDebito.Location = new System.Drawing.Point(307, 34);
            this.lblDebito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(278, 54);
            this.lblDebito.TabIndex = 11;
            this.lblDebito.Text = "Debito: nnn";
            this.lblDebito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSoci
            // 
            this.pnlSoci.Controls.Add(this.textBoxAggiungiSocioDebito);
            this.pnlSoci.Controls.Add(this.textBoxAggiungiSocioTelefono);
            this.pnlSoci.Controls.Add(this.btnApriFileJSON);
            this.pnlSoci.Controls.Add(this.btnEliminaSocio);
            this.pnlSoci.Controls.Add(this.btnAggiungiSocio);
            this.pnlSoci.Controls.Add(this.textBoxAggiungiSocioNome);
            this.pnlSoci.Controls.Add(this.textBoxAggiungiSocioCognome);
            this.pnlSoci.Controls.Add(this.listViewElencoSoci);
            this.pnlSoci.Location = new System.Drawing.Point(315, 96);
            this.pnlSoci.Name = "pnlSoci";
            this.pnlSoci.Size = new System.Drawing.Size(944, 573);
            this.pnlSoci.TabIndex = 12;
            // 
            // textBoxAggiungiSocioTelefono
            // 
            this.textBoxAggiungiSocioTelefono.Location = new System.Drawing.Point(726, 60);
            this.textBoxAggiungiSocioTelefono.Name = "textBoxAggiungiSocioTelefono";
            this.textBoxAggiungiSocioTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxAggiungiSocioTelefono.TabIndex = 17;
            // 
            // btnApriFileJSON
            // 
            this.btnApriFileJSON.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnApriFileJSON.FlatAppearance.BorderSize = 0;
            this.btnApriFileJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApriFileJSON.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApriFileJSON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnApriFileJSON.Location = new System.Drawing.Point(726, 520);
            this.btnApriFileJSON.Name = "btnApriFileJSON";
            this.btnApriFileJSON.Size = new System.Drawing.Size(203, 44);
            this.btnApriFileJSON.TabIndex = 16;
            this.btnApriFileJSON.Text = "Apri file JSON";
            this.btnApriFileJSON.UseVisualStyleBackColor = false;
            this.btnApriFileJSON.Click += new System.EventHandler(this.btnApriFileJSON_Click);
            // 
            // btnEliminaSocio
            // 
            this.btnEliminaSocio.Location = new System.Drawing.Point(832, 47);
            this.btnEliminaSocio.Name = "btnEliminaSocio";
            this.btnEliminaSocio.Size = new System.Drawing.Size(97, 33);
            this.btnEliminaSocio.TabIndex = 15;
            this.btnEliminaSocio.Text = "Elimina";
            this.btnEliminaSocio.UseVisualStyleBackColor = true;
            this.btnEliminaSocio.Click += new System.EventHandler(this.btnEliminaSocio_Click);
            // 
            // btnAggiungiSocio
            // 
            this.btnAggiungiSocio.Location = new System.Drawing.Point(832, 8);
            this.btnAggiungiSocio.Name = "btnAggiungiSocio";
            this.btnAggiungiSocio.Size = new System.Drawing.Size(97, 33);
            this.btnAggiungiSocio.TabIndex = 14;
            this.btnAggiungiSocio.Text = "Aggiungi";
            this.btnAggiungiSocio.UseVisualStyleBackColor = true;
            this.btnAggiungiSocio.Click += new System.EventHandler(this.btnAggiungiSocio_Click);
            // 
            // textBoxAggiungiSocioNome
            // 
            this.textBoxAggiungiSocioNome.Location = new System.Drawing.Point(726, 34);
            this.textBoxAggiungiSocioNome.Name = "textBoxAggiungiSocioNome";
            this.textBoxAggiungiSocioNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxAggiungiSocioNome.TabIndex = 13;
            // 
            // textBoxAggiungiSocioCognome
            // 
            this.textBoxAggiungiSocioCognome.Location = new System.Drawing.Point(726, 8);
            this.textBoxAggiungiSocioCognome.Name = "textBoxAggiungiSocioCognome";
            this.textBoxAggiungiSocioCognome.Size = new System.Drawing.Size(100, 20);
            this.textBoxAggiungiSocioCognome.TabIndex = 12;
            // 
            // listViewElencoSoci
            // 
            this.listViewElencoSoci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.listViewElencoSoci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewElencoSoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewElencoSoci.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.listViewElencoSoci.FullRowSelect = true;
            this.listViewElencoSoci.HideSelection = false;
            this.listViewElencoSoci.Location = new System.Drawing.Point(0, 100);
            this.listViewElencoSoci.Name = "listViewElencoSoci";
            this.listViewElencoSoci.Size = new System.Drawing.Size(929, 415);
            this.listViewElencoSoci.TabIndex = 11;
            this.listViewElencoSoci.UseCompatibleStateImageBehavior = false;
            this.listViewElencoSoci.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cognome";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefono";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Debito (min)";
            this.columnHeader4.Width = 200;
            // 
            // textBoxAggiungiSocioDebito
            // 
            this.textBoxAggiungiSocioDebito.Location = new System.Drawing.Point(521, 54);
            this.textBoxAggiungiSocioDebito.Name = "textBoxAggiungiSocioDebito";
            this.textBoxAggiungiSocioDebito.Size = new System.Drawing.Size(100, 20);
            this.textBoxAggiungiSocioDebito.TabIndex = 18;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnHome.Location = new System.Drawing.Point(0, 227);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(302, 77);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnSegreteria
            // 
            this.btnSegreteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnSegreteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegreteria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.btnSegreteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegreteria.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegreteria.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSegreteria.Location = new System.Drawing.Point(0, 303);
            this.btnSegreteria.Name = "btnSegreteria";
            this.btnSegreteria.Size = new System.Drawing.Size(302, 77);
            this.btnSegreteria.TabIndex = 14;
            this.btnSegreteria.Text = "Segreteria";
            this.btnSegreteria.UseVisualStyleBackColor = false;
            // 
            // btnPrestazioni
            // 
            this.btnPrestazioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnPrestazioni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestazioni.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.btnPrestazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestazioni.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestazioni.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnPrestazioni.Location = new System.Drawing.Point(0, 379);
            this.btnPrestazioni.Name = "btnPrestazioni";
            this.btnPrestazioni.Size = new System.Drawing.Size(302, 77);
            this.btnPrestazioni.TabIndex = 15;
            this.btnPrestazioni.Text = "Prestazioni";
            this.btnPrestazioni.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::BancaDelTempo.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(22, 62);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::BancaDelTempo.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(94, 15);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(106, 96);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlSoci);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banca del Tempo";
            this.panel1.ResumeLayout(false);
            this.pnlSoci.ResumeLayout(false);
            this.pnlSoci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimeLive;
        private System.Windows.Forms.Timer timerTimeLive;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.Panel pnlSoci;
        private System.Windows.Forms.TextBox textBoxAggiungiSocioTelefono;
        private System.Windows.Forms.Button btnApriFileJSON;
        private System.Windows.Forms.Button btnEliminaSocio;
        private System.Windows.Forms.Button btnAggiungiSocio;
        private System.Windows.Forms.TextBox textBoxAggiungiSocioNome;
        private System.Windows.Forms.TextBox textBoxAggiungiSocioCognome;
        private System.Windows.Forms.ListView listViewElencoSoci;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBoxAggiungiSocioDebito;
        private System.Windows.Forms.Button btnPrestazioni;
        private System.Windows.Forms.Button btnSegreteria;
        private System.Windows.Forms.Button btnHome;
    }
}