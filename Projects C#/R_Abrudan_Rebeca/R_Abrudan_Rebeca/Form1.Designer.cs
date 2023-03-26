namespace R_Abrudan_Rebeca
{
    partial class Form1
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
            this.racheta = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.a = new System.Windows.Forms.PictureBox();
            this.c = new System.Windows.Forms.PictureBox();
            this.b = new System.Windows.Forms.PictureBox();
            this.lbl_vieti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_lose = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_final = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.SuspendLayout();
            // 
            // racheta
            // 
            this.racheta.BackColor = System.Drawing.Color.Transparent;
            this.racheta.Image = global::R_Abrudan_Rebeca.Properties.Resources.racheta;
            this.racheta.Location = new System.Drawing.Point(221, 439);
            this.racheta.Margin = new System.Windows.Forms.Padding(4);
            this.racheta.Name = "racheta";
            this.racheta.Size = new System.Drawing.Size(87, 84);
            this.racheta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racheta.TabIndex = 0;
            this.racheta.TabStop = false;
            this.racheta.Click += new System.EventHandler(this.racheta_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Image = global::R_Abrudan_Rebeca.Properties.Resources.asteroid;
            this.a.Location = new System.Drawing.Point(60, 49);
            this.a.Margin = new System.Windows.Forms.Padding(4);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(108, 48);
            this.a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a.TabIndex = 1;
            this.a.TabStop = false;
            this.a.Tag = "asteroizi";
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.Image = global::R_Abrudan_Rebeca.Properties.Resources.asteroid;
            this.c.Location = new System.Drawing.Point(360, 15);
            this.c.Margin = new System.Windows.Forms.Padding(4);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(92, 82);
            this.c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c.TabIndex = 2;
            this.c.TabStop = false;
            this.c.Tag = "asteroizi";
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.Image = global::R_Abrudan_Rebeca.Properties.Resources.asteroid;
            this.b.Location = new System.Drawing.Point(236, 142);
            this.b.Margin = new System.Windows.Forms.Padding(4);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(55, 46);
            this.b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b.TabIndex = 3;
            this.b.TabStop = false;
            this.b.Tag = "asteroizi";
            // 
            // lbl_vieti
            // 
            this.lbl_vieti.AutoSize = true;
            this.lbl_vieti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_vieti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vieti.Location = new System.Drawing.Point(107, 527);
            this.lbl_vieti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vieti.Name = "lbl_vieti";
            this.lbl_vieti.Size = new System.Drawing.Size(29, 31);
            this.lbl_vieti.TabIndex = 4;
            this.lbl_vieti.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 527);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vieti";
            // 
            // lbl_lose
            // 
            this.lbl_lose.BackColor = System.Drawing.Color.Maroon;
            this.lbl_lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_lose.Location = new System.Drawing.Point(0, 230);
            this.lbl_lose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lose.Name = "lbl_lose";
            this.lbl_lose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_lose.Size = new System.Drawing.Size(565, 87);
            this.lbl_lose.TabIndex = 6;
            this.lbl_lose.Text = "GAME OVER!";
            this.lbl_lose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Location = new System.Drawing.Point(207, 294);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_restart.Location = new System.Drawing.Point(288, 294);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 23);
            this.btn_restart.TabIndex = 8;
            this.btn_restart.Text = "RESTART";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // lbl_final
            // 
            this.lbl_final.BackColor = System.Drawing.Color.Maroon;
            this.lbl_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_final.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_final.Location = new System.Drawing.Point(0, 230);
            this.lbl_final.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_final.Size = new System.Drawing.Size(565, 87);
            this.lbl_final.TabIndex = 9;
            this.lbl_final.Text = "YOU WON!";
            this.lbl_final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(288, 323);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(104, 43);
            this.exit.TabIndex = 10;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.restart.Location = new System.Drawing.Point(167, 323);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(115, 43);
            this.restart.TabIndex = 11;
            this.restart.Text = "RESTART";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::R_Abrudan_Rebeca.Properties.Resources.galaxy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 587);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lbl_final);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_lose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_vieti);
            this.Controls.Add(this.b);
            this.Controls.Add(this.c);
            this.Controls.Add(this.a);
            this.Controls.Add(this.racheta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Racheta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.racheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racheta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox a;
        private System.Windows.Forms.PictureBox c;
        private System.Windows.Forms.PictureBox b;
        private System.Windows.Forms.Label lbl_vieti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_lose;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button restart;
    }
}

