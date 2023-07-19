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
            this.lblTimeLive = new System.Windows.Forms.Label();
            this.timerTimeLive = new System.Windows.Forms.Timer(this.components);
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblBancaDelTempo = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlNav.Controls.Add(this.lblTimeLive);
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(250, 720);
            this.pnlNav.TabIndex = 0;
            // 
            // lblTimeLive
            // 
            this.lblTimeLive.AutoSize = true;
            this.lblTimeLive.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLive.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimeLive.Location = new System.Drawing.Point(3, 21);
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
            this.pnlHome.Location = new System.Drawing.Point(250, 91);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1031, 629);
            this.pnlHome.TabIndex = 1;
            // 
            // lblBancaDelTempo
            // 
            this.lblBancaDelTempo.AutoSize = true;
            this.lblBancaDelTempo.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancaDelTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.lblBancaDelTempo.Location = new System.Drawing.Point(485, 4);
            this.lblBancaDelTempo.Name = "lblBancaDelTempo";
            this.lblBancaDelTempo.Size = new System.Drawing.Size(579, 75);
            this.lblBancaDelTempo.TabIndex = 2;
            this.lblBancaDelTempo.Text = "BANCA DEL TEMPO";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblBancaDelTempo);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblTimeLive;
        private System.Windows.Forms.Timer timerTimeLive;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblBancaDelTempo;
    }
}

