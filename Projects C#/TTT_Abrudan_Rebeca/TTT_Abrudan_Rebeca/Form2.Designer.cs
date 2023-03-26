namespace TTT_Abrudan_Rebeca
{
    partial class Generic
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
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(123, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "(c) 2021, Abrudan Rebeca";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(162)))), ((int)(((byte)(132)))));
            this.start.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(184, 64);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(133, 48);
            this.start.TabIndex = 10;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTT_Abrudan_Rebeca.Properties.Resources.gif;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(9, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 49);
            this.label2.TabIndex = 12;
            this.label2.Text = "The first player to get 3 of her marks in a row (up, down, across, or diagonally)" +
    " is the winner.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(9, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 46);
            this.label3.TabIndex = 13;
            this.label3.Text = "You are X, your friend is O. Players take turns putting their marks in empty squa" +
    "res.";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(9, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "When all 9 squares are full, the game is over.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Generic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(165)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(335, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Name = "Generic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}