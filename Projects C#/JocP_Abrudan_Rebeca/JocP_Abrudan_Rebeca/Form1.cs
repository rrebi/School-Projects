using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocP_Abrudan_Rebeca
{
    public partial class Form1 : Form
    {
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion

        #region .. code for Flickering ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
            //SetDoubleBuffered(player);


            this.DoubleBuffered = true;
            /*
            fundal.Controls.Add(player);
            player.BackColor = Color.Transparent;

            
            fundal.Controls.Add(p1);
            p1.BackColor = Color.Transparent;
            
            fundal.Controls.Add(p2);
            p2.BackColor = Color.Transparent;

            fundal.Controls.Add(p3);
            p3.BackColor = Color.Transparent;

            fundal.Controls.Add(p4);
            p4.BackColor = Color.Transparent;

            fundal.Controls.Add(p5);
            p5.BackColor = Color.Transparent;

            fundal.Controls.Add(p6);
            p6.BackColor = Color.Transparent;

            fundal.Controls.Add(c1);
            c1.BackColor = Color.Transparent;
            
            
            
            p1.BringToFront();
            p2.BringToFront();
            p3.BringToFront();
            p4.BringToFront();
            p5.BringToFront();
            p6.BringToFront();
            player.BringToFront();*/


            usa.Visible = false;
            go.Visible = false;
            exit.Visible = false;

        }

        bool sus, dreapta, stanga;
        int viteza = 15;
        int cadere = 3;
        bool salt = false, jos = true;
        int p = 5, s, vitezaback = 15; 

        private void player_Click(object sender, EventArgs e)
        {

        }

        /* 
        bool verificare_sus(PictureBox player)
        {
            foreach (Control x in this.fundal.Controls)
            {
                if ((string)x.Tag == "platforma")
                    if (player.Top + player.Height + vitezaplayer >= x.Top && player.Top < x.Top)
                        if ((player.Left + player.Width >= x.Left) && (player.Left <= x.Left + x.Width))
                            return false;
            }
            return true;
        }
        */

        bool verificare_jos(PictureBox player)
        {
            foreach (Control x in this.fundal.Controls)
            {
                if ((string)x.Tag == "platforma")
                    if (player.Top + player.Height + viteza >= x.Top && player.Top < x.Top)
                        if ((player.Left + player.Width >= x.Left) && (player.Left <= x.Left + x.Width))
                            return false;
            }
            return true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        /*

        bool verificare_dreapta(PictureBox player)
        {
            foreach (Control x in this.fundal.Controls)
            {
                if ((string)x.Tag == "platforma")
                    if (player.Left + player.Width + vitezaplayer >= x.Left && player.Left < x.Left)
                        if ((player.Top + player.Height >= x.Top) && (player.Top <= x.Top + x.Height))
                            return false;
            }
            return true;
        }

        bool verificare_stanga(PictureBox player)
        {
            foreach (Control x in this.fundal.Controls)
            {
                if ((string)x.Tag == "platforma")
                    if (player.Left - vitezaplayer <= x.Left + x.Width && player.Left > x.Left + x.Width)
                        if ((player.Top + player.Height >= x.Top) && (player.Top <= x.Top + x.Height))
                            return false;
            }
            return true;
        } */

        private void timer1_Tick(object sender, EventArgs e)
        {
            puncte.Text = "Corali ramasi: " + p;
            if (verificare_jos(player) == true && jos == true)
                player.Top += cadere;
            if (player.Top < this.Height - player.Height - 30)
                player.Top += cadere;
            if (sus)
                player.Top -= viteza;
            if (dreapta && player.Left + (player.Width + 10) < this.fundal.Width)
            {
                player.Left += viteza;
            }
            if (stanga && player.Left > 10)
            {
                player.Left -= viteza;
            }
            if (dreapta == true && fundal.Left > -300)
            {
                fundal.Left -= vitezaback;
                MoveGameElements("inapoi");
            }
            if (stanga == true && fundal.Left < -10)
            {
                fundal.Left += vitezaback;
                MoveGameElements("inainte");
            }

            if (salt == true)
            {
                if ((player.Top > s - 90) && jos == false)
                {
                    player.Top -= 10;
                }
                else
                {
                    jos = true;
                }
                if (verificare_jos(player) == false)
                {
                    salt = false;
                    jos = true;
                }
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platforma")
                {
                    if (x.Bounds.IntersectsWith(player.Bounds))
                        player.Top = x.Top - player.Height;
                }
            }
            //banut
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (x.Bounds.IntersectsWith(player.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        p--;
                        puncte.Text = "Corali ramasi: " + p;

                        if (p == 0)
                        {
                            usa.Visible = true;
                        }
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "usa")
                {
                    if (x.Bounds.IntersectsWith(player.Bounds) && usa.Visible==true)
                    {
                        player.Visible = false;
                        x.Visible = false;
                        timer1.Enabled = false;
                        go.Visible = true;
                        exit.Visible = true;
                    }
                }
                
            }

        }

        private void RestartGame()
        {
            salt = false;
            stanga = false;
            dreapta = false;
            jos = true;
            p = 5;
            usa.Visible = false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) sus = false;
            if (e.KeyCode == Keys.Left) stanga = false;
            if (e.KeyCode == Keys.Right) dreapta = false;
            if (e.KeyCode == Keys.Up && salt == false && verificare_jos(player) == false)
            {
                s = player.Top;
                salt = true;
                jos = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                stanga = true;
                player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (e.KeyCode == Keys.Right)
            {
                dreapta = true;
                player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (e.KeyCode == Keys.Up) sus = true;
            if (e.KeyCode == Keys.Up && salt == false && verificare_jos(player) == false)
            {
                s = player.Top;
                salt = true;
                jos = false;
            }
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && (string)X.Tag == "platforma" || X is PictureBox && (string)X.Tag == "coin" || X is PictureBox && (string)X.Tag == "usa")
                {
                    if (direction == "inapoi")
                    {
                        X.Left -= vitezaback;
                    }
                    if (direction == "inainte")
                    {
                        X.Left += vitezaback;
                    }
                }
            }
        } 
    }
}
