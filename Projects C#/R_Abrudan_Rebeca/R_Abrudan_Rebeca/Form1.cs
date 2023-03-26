using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R_Abrudan_Rebeca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_vieti.Text = Convert.ToString(vieti);
            lbl_final.Visible = false;
            lbl_lose.Visible = false;
            btn_exit.Visible = false;
            btn_restart.Visible = false;
            exit.Visible = false;
            restart.Visible = false;
        }



        bool st, dr, sus, jos;
        int viteza = 10; //viteza rachetei
        int vitezaa = 12; //viteza asteroid
        int vieti = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vieti == 0)
            {
                timer1.Enabled = false;
                lbl_lose.Visible = true;
                racheta.Visible = false;
            }
            lbl_lose.Visible = false;
            //miscarea rachetei
            if(st == true)
            {
                if (racheta.Left <= 0)
                    racheta.Left = racheta.Left + 2;
                else
                    racheta.Left = racheta.Left - viteza;
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "asteroizi")
                    {
                        if (racheta.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            st = false;
                            racheta.Left = racheta.Left + viteza + 2;
                        }
                    }
                }
                racheta.Left = racheta.Left - viteza;
            }

            if (dr == true)
            {
                if (racheta.Left >= this.Width - racheta.Width - 6)
                    racheta.Left = racheta.Left - 4;
                else
                    racheta.Left = racheta.Left + viteza;
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "asteroizi")
                    {
                        if (racheta.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            dr = false;
                            racheta.Left = racheta.Left - viteza - 6;
                        }
                    }
                }
                racheta.Left = racheta.Left + viteza;
            }

            if (sus == true)
            {
                if (racheta.Top <= 0)
                    racheta.Top = racheta.Top + 11;
                else
                    racheta.Top = racheta.Top - viteza;
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "asteroizi")
                    {
                        if (racheta.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            sus = false;
                            racheta.Top = racheta.Top + viteza + 6;
                        }
                    }
                }
                racheta.Top = racheta.Top - viteza;
            }

            if (jos == true)
            {
                if (racheta.Top >= this.Height - racheta.Height - 45)
                    racheta.Top = racheta.Top - 10;
                else
                    racheta.Top = racheta.Top + viteza;
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "asteroizi")
                    {
                        if (racheta.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            jos = false;
                            racheta.Top = racheta.Top - viteza - 6;
                        }
                    }
                }
                racheta.Top = racheta.Top + viteza;
            }

            

            //miscarea asteroidului
            foreach (Control x in this.Controls)
            {
                if((string)x.Tag == "asteroizi")
                {
                    if (x.Top <= this.Height)
                        x.Top = x.Top + vitezaa;
                    else //cand asteroidul dispare din ecran
                    {
                        Random nr = new Random();
                        int xo = nr.Next(1, 350); //coord pe orizontala

                        Random dim = new Random(); //dimensiunea asteroidului
                        int dx = dim.Next(30, 80);
                        int dy = dim.Next(30, 80);

                        Random dist = new Random(); //distanta fata de marginea de sus a ferestrei

                        x.Top = -dist.Next(50, 100);
                        x.Left = xo;

                        x.Height = dx;
                        x.Width = dy;
                    }
                }
            }

            if (lbl_final.Visible == true || lbl_lose.Visible == true)
            {
                btn_exit.Visible = true;
                btn_restart.Visible = true;
                exit.Visible = true;
                restart.Visible = true;
            }

            //vieti
            if (vieti==0)
            {
                timer1.Enabled = false;
                lbl_lose.Visible = true;
                exit.Visible = true;
                restart.Visible = true;
            }
            /*if (lbl_lose.Visible == true)
            {
                btn_exit.Visible = true;
                btn_restart.Visible = true;
            }*/

            

        }

        

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            vieti = 5;
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                st = true;
            if (e.KeyCode == Keys.Right)
                dr = true;
            if (e.KeyCode == Keys.Up)
                sus = true;
            if (e.KeyCode == Keys.Down)
                jos = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                st = false;
            if (e.KeyCode == Keys.Right)
                dr = false;
            if (e.KeyCode == Keys.Up)
                sus = false;
            if (e.KeyCode == Keys.Down)
                jos = false;
        }

        private void racheta_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
