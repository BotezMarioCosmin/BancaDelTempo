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
            this.btnPrestazioni = new System.Windows.Forms.Button();
            this.btnSegreteria = new System.Windows.Forms.Button();
            this.lblDebito = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTimeLive = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.timerTimeLive = new System.Windows.Forms.Timer(this.components);
            this.pnlSoci = new System.Windows.Forms.Panel();
            this.lblHomeView = new System.Windows.Forms.Label();
            this.btnApriFileJSON = new System.Windows.Forms.Button();
            this.listViewElencoSoci = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnImpostazioniEliminaSocio = new System.Windows.Forms.Button();
            this.btnImpostazioniAggiungiSocio = new System.Windows.Forms.Button();
            this.lblModificaFile = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblUserUpload = new System.Windows.Forms.Label();
            this.btnUserUploadPhoto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSettings = new System.Windows.Forms.Label();
            this.textBoxDebito = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.btnApriFileJson2 = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.listViewSettings = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSegreteria = new System.Windows.Forms.Panel();
            this.btnApriFileJsonSegreteria = new System.Windows.Forms.Button();
            this.listViewSegreteria = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlSoci.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlSegreteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnPrestazioni);
            this.panel1.Controls.Add(this.btnSegreteria);
            this.panel1.Controls.Add(this.lblDebito);
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
            this.btnSegreteria.Click += new System.EventHandler(this.btnSegreteria_Click);
            // 
            // lblDebito
            // 
            this.lblDebito.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebito.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblDebito.Location = new System.Drawing.Point(2, 496);
            this.lblDebito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(298, 54);
            this.lblDebito.TabIndex = 11;
            this.lblDebito.Text = "Debito: nnn";
            this.lblDebito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            // timerTimeLive
            // 
            this.timerTimeLive.Interval = 1000;
            this.timerTimeLive.Tick += new System.EventHandler(this.timerTimeLive_Tick);
            // 
            // pnlSoci
            // 
            this.pnlSoci.Controls.Add(this.lblHomeView);
            this.pnlSoci.Controls.Add(this.btnApriFileJSON);
            this.pnlSoci.Controls.Add(this.listViewElencoSoci);
            this.pnlSoci.Location = new System.Drawing.Point(775, 326);
            this.pnlSoci.Name = "pnlSoci";
            this.pnlSoci.Size = new System.Drawing.Size(934, 648);
            this.pnlSoci.TabIndex = 12;
            // 
            // lblHomeView
            // 
            this.lblHomeView.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeView.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblHomeView.Location = new System.Drawing.Point(2, 0);
            this.lblHomeView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeView.Name = "lblHomeView";
            this.lblHomeView.Size = new System.Drawing.Size(927, 96);
            this.lblHomeView.TabIndex = 17;
            this.lblHomeView.Text = "Home: visualizza debiti";
            this.lblHomeView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApriFileJSON
            // 
            this.btnApriFileJSON.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnApriFileJSON.FlatAppearance.BorderSize = 0;
            this.btnApriFileJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApriFileJSON.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApriFileJSON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnApriFileJSON.Location = new System.Drawing.Point(726, 604);
            this.btnApriFileJSON.Name = "btnApriFileJSON";
            this.btnApriFileJSON.Size = new System.Drawing.Size(208, 44);
            this.btnApriFileJSON.TabIndex = 16;
            this.btnApriFileJSON.Text = "Apri file JSON";
            this.btnApriFileJSON.UseVisualStyleBackColor = false;
            this.btnApriFileJSON.Click += new System.EventHandler(this.btnApriFileJSON_Click);
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
            this.listViewElencoSoci.Location = new System.Drawing.Point(0, 99);
            this.listViewElencoSoci.Name = "listViewElencoSoci";
            this.listViewElencoSoci.Size = new System.Drawing.Size(934, 499);
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
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnImpostazioniEliminaSocio);
            this.pnlSettings.Controls.Add(this.btnImpostazioniAggiungiSocio);
            this.pnlSettings.Controls.Add(this.lblModificaFile);
            this.pnlSettings.Controls.Add(this.panel3);
            this.pnlSettings.Controls.Add(this.btnDelete);
            this.pnlSettings.Controls.Add(this.lblUserUpload);
            this.pnlSettings.Controls.Add(this.btnUserUploadPhoto);
            this.pnlSettings.Controls.Add(this.panel2);
            this.pnlSettings.Controls.Add(this.lblSettings);
            this.pnlSettings.Controls.Add(this.textBoxDebito);
            this.pnlSettings.Controls.Add(this.textBoxTelefono);
            this.pnlSettings.Controls.Add(this.btnApriFileJson2);
            this.pnlSettings.Controls.Add(this.textBoxNome);
            this.pnlSettings.Controls.Add(this.textBoxCognome);
            this.pnlSettings.Controls.Add(this.listViewSettings);
            this.pnlSettings.Location = new System.Drawing.Point(337, 31);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(944, 657);
            this.pnlSettings.TabIndex = 19;
            // 
            // btnImpostazioniEliminaSocio
            // 
            this.btnImpostazioniEliminaSocio.BackColor = System.Drawing.Color.Red;
            this.btnImpostazioniEliminaSocio.FlatAppearance.BorderSize = 0;
            this.btnImpostazioniEliminaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpostazioniEliminaSocio.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpostazioniEliminaSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnImpostazioniEliminaSocio.Location = new System.Drawing.Point(10, 613);
            this.btnImpostazioniEliminaSocio.Name = "btnImpostazioniEliminaSocio";
            this.btnImpostazioniEliminaSocio.Size = new System.Drawing.Size(203, 44);
            this.btnImpostazioniEliminaSocio.TabIndex = 25;
            this.btnImpostazioniEliminaSocio.Text = "Elimina";
            this.btnImpostazioniEliminaSocio.UseVisualStyleBackColor = false;
            this.btnImpostazioniEliminaSocio.Click += new System.EventHandler(this.btnImpostazioniEliminaSocio_Click);
            // 
            // btnImpostazioniAggiungiSocio
            // 
            this.btnImpostazioniAggiungiSocio.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnImpostazioniAggiungiSocio.FlatAppearance.BorderSize = 0;
            this.btnImpostazioniAggiungiSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpostazioniAggiungiSocio.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpostazioniAggiungiSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnImpostazioniAggiungiSocio.Location = new System.Drawing.Point(436, 231);
            this.btnImpostazioniAggiungiSocio.Name = "btnImpostazioniAggiungiSocio";
            this.btnImpostazioniAggiungiSocio.Size = new System.Drawing.Size(203, 44);
            this.btnImpostazioniAggiungiSocio.TabIndex = 24;
            this.btnImpostazioniAggiungiSocio.Text = "Aggiungi";
            this.btnImpostazioniAggiungiSocio.UseVisualStyleBackColor = false;
            this.btnImpostazioniAggiungiSocio.Click += new System.EventHandler(this.btnImpostazioniAggiungiSocio_Click);
            // 
            // lblModificaFile
            // 
            this.lblModificaFile.AutoSize = true;
            this.lblModificaFile.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaFile.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblModificaFile.Location = new System.Drawing.Point(8, 180);
            this.lblModificaFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificaFile.Name = "lblModificaFile";
            this.lblModificaFile.Size = new System.Drawing.Size(299, 39);
            this.lblModificaFile.TabIndex = 23;
            this.lblModificaFile.Text = "Modifica file JSON";
            this.lblModificaFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(10, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 1);
            this.panel3.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnDelete.Location = new System.Drawing.Point(224, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 44);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblUserUpload
            // 
            this.lblUserUpload.AutoSize = true;
            this.lblUserUpload.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserUpload.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblUserUpload.Location = new System.Drawing.Point(8, 72);
            this.lblUserUpload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserUpload.Name = "lblUserUpload";
            this.lblUserUpload.Size = new System.Drawing.Size(119, 39);
            this.lblUserUpload.TabIndex = 21;
            this.lblUserUpload.Text = "Utente";
            this.lblUserUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUserUploadPhoto
            // 
            this.btnUserUploadPhoto.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUserUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUserUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserUploadPhoto.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserUploadPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUserUploadPhoto.Location = new System.Drawing.Point(15, 114);
            this.btnUserUploadPhoto.Name = "btnUserUploadPhoto";
            this.btnUserUploadPhoto.Size = new System.Drawing.Size(203, 44);
            this.btnUserUploadPhoto.TabIndex = 20;
            this.btnUserUploadPhoto.Text = "Carica foto";
            this.btnUserUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUserUploadPhoto.Click += new System.EventHandler(this.btnUserUploadPhoto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(10, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 1);
            this.panel2.TabIndex = 19;
            // 
            // lblSettings
            // 
            this.lblSettings.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblSettings.Location = new System.Drawing.Point(6, 4);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(926, 54);
            this.lblSettings.TabIndex = 17;
            this.lblSettings.Text = "Impostazioni";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDebito
            // 
            this.textBoxDebito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.textBoxDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDebito.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.textBoxDebito.Location = new System.Drawing.Point(224, 259);
            this.textBoxDebito.Name = "textBoxDebito";
            this.textBoxDebito.Size = new System.Drawing.Size(206, 29);
            this.textBoxDebito.TabIndex = 18;
            this.textBoxDebito.Text = "Debito";
            this.textBoxDebito.Click += new System.EventHandler(this.textBoxDebito_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.textBoxTelefono.Location = new System.Drawing.Point(224, 222);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(206, 29);
            this.textBoxTelefono.TabIndex = 17;
            this.textBoxTelefono.Text = "Telefono";
            this.textBoxTelefono.Click += new System.EventHandler(this.textBoxTelefono_Click);
            // 
            // btnApriFileJson2
            // 
            this.btnApriFileJson2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnApriFileJson2.FlatAppearance.BorderSize = 0;
            this.btnApriFileJson2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApriFileJson2.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApriFileJson2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnApriFileJson2.Location = new System.Drawing.Point(729, 613);
            this.btnApriFileJson2.Name = "btnApriFileJson2";
            this.btnApriFileJson2.Size = new System.Drawing.Size(203, 44);
            this.btnApriFileJson2.TabIndex = 16;
            this.btnApriFileJson2.Text = "Apri file JSON";
            this.btnApriFileJson2.UseVisualStyleBackColor = false;
            this.btnApriFileJson2.Click += new System.EventHandler(this.btnApriFileJson2_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.textBoxNome.Location = new System.Drawing.Point(10, 259);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(196, 29);
            this.textBoxNome.TabIndex = 13;
            this.textBoxNome.Text = "Nome";
            this.textBoxNome.Click += new System.EventHandler(this.textBoxNome_Click);
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.textBoxCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCognome.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.textBoxCognome.Location = new System.Drawing.Point(10, 222);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.Size = new System.Drawing.Size(196, 29);
            this.textBoxCognome.TabIndex = 12;
            this.textBoxCognome.Text = "Cognome";
            this.textBoxCognome.Click += new System.EventHandler(this.textBoxCognome_Click);
            // 
            // listViewSettings
            // 
            this.listViewSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.listViewSettings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSettings.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.listViewSettings.FullRowSelect = true;
            this.listViewSettings.HideSelection = false;
            this.listViewSettings.Location = new System.Drawing.Point(10, 305);
            this.listViewSettings.Name = "listViewSettings";
            this.listViewSettings.Size = new System.Drawing.Size(922, 303);
            this.listViewSettings.TabIndex = 11;
            this.listViewSettings.UseCompatibleStateImageBehavior = false;
            this.listViewSettings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cognome";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nome";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Telefono";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Debito (min)";
            this.columnHeader8.Width = 200;
            // 
            // pnlSegreteria
            // 
            this.pnlSegreteria.Controls.Add(this.label1);
            this.pnlSegreteria.Controls.Add(this.btnApriFileJsonSegreteria);
            this.pnlSegreteria.Controls.Add(this.listViewSegreteria);
            this.pnlSegreteria.Location = new System.Drawing.Point(352, 425);
            this.pnlSegreteria.Name = "pnlSegreteria";
            this.pnlSegreteria.Size = new System.Drawing.Size(934, 648);
            this.pnlSegreteria.TabIndex = 17;
            // 
            // btnApriFileJsonSegreteria
            // 
            this.btnApriFileJsonSegreteria.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnApriFileJsonSegreteria.FlatAppearance.BorderSize = 0;
            this.btnApriFileJsonSegreteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApriFileJsonSegreteria.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApriFileJsonSegreteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnApriFileJsonSegreteria.Location = new System.Drawing.Point(726, 604);
            this.btnApriFileJsonSegreteria.Name = "btnApriFileJsonSegreteria";
            this.btnApriFileJsonSegreteria.Size = new System.Drawing.Size(208, 44);
            this.btnApriFileJsonSegreteria.TabIndex = 16;
            this.btnApriFileJsonSegreteria.Text = "Apri file JSON";
            this.btnApriFileJsonSegreteria.UseVisualStyleBackColor = false;
            this.btnApriFileJsonSegreteria.Click += new System.EventHandler(this.btnApriFileJsonSegreteria_Click);
            // 
            // listViewSegreteria
            // 
            this.listViewSegreteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.listViewSegreteria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewSegreteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSegreteria.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.listViewSegreteria.FullRowSelect = true;
            this.listViewSegreteria.HideSelection = false;
            this.listViewSegreteria.Location = new System.Drawing.Point(0, 99);
            this.listViewSegreteria.Name = "listViewSegreteria";
            this.listViewSegreteria.Size = new System.Drawing.Size(934, 499);
            this.listViewSegreteria.TabIndex = 11;
            this.listViewSegreteria.UseCompatibleStateImageBehavior = false;
            this.listViewSegreteria.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cognome";
            this.columnHeader9.Width = 300;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nome";
            this.columnHeader10.Width = 300;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Telefono";
            this.columnHeader11.Width = 300;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(927, 96);
            this.label1.TabIndex = 18;
            this.label1.Text = "Segreteria: visualizza Soci";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::BancaDelTempo.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(221, 58);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(50, 50);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::BancaDelTempo.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(26, 58);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::BancaDelTempo.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(95, 31);
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
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlSegreteria);
            this.Controls.Add(this.pnlSoci);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banca del Tempo";
            this.panel1.ResumeLayout(false);
            this.pnlSoci.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlSegreteria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimeLive;
        private System.Windows.Forms.Timer timerTimeLive;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.Panel pnlSoci;
        private System.Windows.Forms.Button btnApriFileJSON;
        private System.Windows.Forms.ListView listViewElencoSoci;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnPrestazioni;
        private System.Windows.Forms.Button btnSegreteria;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.TextBox textBoxDebito;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Button btnApriFileJson2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCognome;
        private System.Windows.Forms.ListView listViewSettings;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnImpostazioniEliminaSocio;
        private System.Windows.Forms.Button btnImpostazioniAggiungiSocio;
        private System.Windows.Forms.Label lblModificaFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblUserUpload;
        private System.Windows.Forms.Button btnUserUploadPhoto;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel pnlSegreteria;
        private System.Windows.Forms.Button btnApriFileJsonSegreteria;
        private System.Windows.Forms.ListView listViewSegreteria;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label lblHomeView;
        private System.Windows.Forms.Label label1;
    }
}