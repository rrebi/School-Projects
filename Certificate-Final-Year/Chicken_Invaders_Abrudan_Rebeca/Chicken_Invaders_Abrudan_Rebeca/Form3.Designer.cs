namespace Chicken_Invaders_Abrudan_Rebeca
{
    partial class Lv2
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
            this.otimer = new System.Windows.Forms.Timer(this.components);
            this.ptimer = new System.Windows.Forms.Timer(this.components);
            this.gtimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_scor = new System.Windows.Forms.Label();
            this.bara = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bara)).BeginInit();
            this.SuspendLayout();
            // 
            // otimer
            // 
            this.otimer.Enabled = true;
            this.otimer.Interval = 20;
            this.otimer.Tick += new System.EventHandler(this.otimer_Tick);
            // 
            // ptimer
            // 
            this.ptimer.Enabled = true;
            this.ptimer.Interval = 20;
            this.ptimer.Tick += new System.EventHandler(this.ptimer_Tick);
            // 
            // gtimer
            // 
            this.gtimer.Enabled = true;
            this.gtimer.Interval = 20;
            this.gtimer.Tick += new System.EventHandler(this.gtimer_Tick);
            // 
            // lbl_scor
            // 
            this.lbl_scor.AutoSize = true;
            this.lbl_scor.BackColor = System.Drawing.Color.Black;
            this.lbl_scor.Font = new System.Drawing.Font("Courier New", 10.25F);
            this.lbl_scor.ForeColor = System.Drawing.Color.Snow;
            this.lbl_scor.Location = new System.Drawing.Point(12, 9);
            this.lbl_scor.Name = "lbl_scor";
            this.lbl_scor.Size = new System.Drawing.Size(86, 20);
            this.lbl_scor.TabIndex = 1;
            this.lbl_scor.Text = "Scor: 0";
            // 
            // bara
            // 
            this.bara.BackColor = System.Drawing.Color.Black;
            this.bara.BackgroundImage = global::Chicken_Invaders_Abrudan_Rebeca.Properties.Resources.cer;
            this.bara.Location = new System.Drawing.Point(1, 231);
            this.bara.Name = "bara";
            this.bara.Size = new System.Drawing.Size(898, 10);
            this.bara.TabIndex = 2;
            this.bara.TabStop = false;
            // 
            // Lv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.bara);
            this.Controls.Add(this.lbl_scor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lv2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chicken Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChickenInvaders_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChickenInvaders_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer otimer;
        private System.Windows.Forms.Timer ptimer;
        private System.Windows.Forms.Timer gtimer;
        private System.Windows.Forms.Label lbl_scor;
        private System.Windows.Forms.PictureBox bara;
    }
}