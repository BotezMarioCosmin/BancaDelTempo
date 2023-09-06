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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTimeLive = new System.Windows.Forms.Label();
            this.timerTimeLive = new System.Windows.Forms.Timer(this.components);
            this.pnlHome = new System.Windows.Forms.Panel();
            this.labelHomeDebitoValue = new System.Windows.Forms.Label();
            this.lblHomeDebito = new System.Windows.Forms.Label();
            this.lblBancaDelTempo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlNav.Controls.Add(this.btnHome);
            this.pnlNav.Controls.Add(this.lblTimeLive);
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(250, 720);
            this.pnlNav.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.Location = new System.Drawing.Point(0, 130);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(250, 85);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTimeLive
            // 
            this.lblTimeLive.AutoSize = true;
            this.lblTimeLive.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLive.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimeLive.Location = new System.Drawing.Point(3, 49);
            this.lblTimeLive.Name = "lblTimeLive";
            this.lblTimeLive.Size = new System.Drawing.Size(249, 54);
            this.lblTimeLive.TabIndex = 1;
            this.lblTimeLive.Text = "HH : mm : ss";
            // 
            // timerTimeLive
            // 
            this.timerTimeLive.Interval = 1000;
            this.timerTimeLive.Tick += new System.EventHandler(this.timerTimeLive_Tick);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.pnlHome.Controls.Add(this.labelHomeDebitoValue);
            this.pnlHome.Controls.Add(this.lblHomeDebito);
            this.pnlHome.Location = new System.Drawing.Point(250, 130);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1031, 590);
            this.pnlHome.TabIndex = 1;
            // 
            // labelHomeDebitoValue
            // 
            this.labelHomeDebitoValue.AutoSize = true;
            this.labelHomeDebitoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeDebitoValue.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelHomeDebitoValue.Location = new System.Drawing.Point(518, 268);
            this.labelHomeDebitoValue.Name = "labelHomeDebitoValue";
            this.labelHomeDebitoValue.Size = new System.Drawing.Size(98, 37);
            this.labelHomeDebitoValue.TabIndex = 1;
            this.labelHomeDebitoValue.Text = "999 h";
            // 
            // lblHomeDebito
            // 
            this.lblHomeDebito.AutoSize = true;
            this.lblHomeDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeDebito.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHomeDebito.Location = new System.Drawing.Point(403, 268);
            this.lblHomeDebito.Name = "lblHomeDebito";
            this.lblHomeDebito.Size = new System.Drawing.Size(118, 37);
            this.lblHomeDebito.TabIndex = 0;
            this.lblHomeDebito.Text = "Debito:";
            // 
            // lblBancaDelTempo
            // 
            this.lblBancaDelTempo.AutoSize = true;
            this.lblBancaDelTempo.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancaDelTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.lblBancaDelTempo.Location = new System.Drawing.Point(485, 32);
            this.lblBancaDelTempo.Name = "lblBancaDelTempo";
            this.lblBancaDelTempo.Size = new System.Drawing.Size(579, 75);
            this.lblBancaDelTempo.TabIndex = 2;
            this.lblBancaDelTempo.Text = "BANCA DEL TEMPO";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1241, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblBancaDelTempo);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblTimeLive;
        private System.Windows.Forms.Timer timerTimeLive;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblBancaDelTempo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblHomeDebito;
        private System.Windows.Forms.Label labelHomeDebitoValue;
        private System.Windows.Forms.Button btnClose;
    }
}

