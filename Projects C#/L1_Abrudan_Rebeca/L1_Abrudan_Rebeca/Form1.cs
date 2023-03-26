using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_Abrudan_Rebeca
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
        }

        bool st, dr, sus, jos;
        int viteza = 5;
        int vieti = 5;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            /*vieti = 5;
            lbl_vieti.Text = Convert.ToString(vieti);
            timer1.Enabled = true;
            player.Visible = true;
            lbl_final.Visible = false;
            lbl_lose.Visible = false;
            btn_exit.Visible = false;
            btn_restart.Visible = false;*/
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(vieti==0)
            {
                timer1.Enabled = false;
                lbl_lose.Visible = true;
                player.Visible = false;
            }

            if (st == true)
            {
                /*if (player.Left <= 0)
                    player.Left = player.Left + 2;
                else
                    player.Left = player.Left - viteza;*/
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "ziduri")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            st = false;
                            player.Left = player.Left + viteza + 6;
                        }
                    }
                }
                player.Left = player.Left - viteza;
            }

            if (dr == true)
            {
                /*if (player.Left >= this.Width-player.Width-20)
                    player.Left = player.Left - 2;
                else
                    player.Left = player.Left + viteza;*/
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "ziduri")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            dr = false;
                            player.Left = player.Left - viteza - 6;
                        }
                    }
                }
                player.Left = player.Left + viteza;
            }

            if (sus == true)
            {
                /*if (player.Top <= 32)
                {
                    player.Top = player.Top + 2;
                    vieti--;
                    lbl_vieti.Text = Convert.ToString(vieti);
                    sus = false;
                }
                else
                    player.Top = player.Top - viteza;*/
                foreach(Control x in this.Controls)
                {
                    if((string)x.Tag=="ziduri")
                    {
                        if(player.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            sus = false;
                            player.Top = player.Top + viteza + 6;
                        }
                    }
                }
                player.Top = player.Top - viteza;
            }

            if (jos == true)
            {
                /*if (player.Top >= this.Height - player.Height-40)
                    player.Top = player.Top - 2;
                else
                    player.Top = player.Top + viteza;*/
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "ziduri")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            jos = false;
                            player.Top = player.Top - viteza - 6;
                        }
                    }
                }
                player.Top = player.Top + viteza;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "usa")
                {
                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        player.Visible = false;
                        x.Visible = false;
                        timer1.Enabled = false;
                        lbl_final.Visible = true;
                    }
                }
            }
            
            if(lbl_final.Visible==true || lbl_lose.Visible==true)
            {
                btn_exit.Visible = true;
                btn_restart.Visible = true;
            }
           
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
    }
}
