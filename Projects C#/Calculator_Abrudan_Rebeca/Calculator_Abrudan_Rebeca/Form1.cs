using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Calculator_Abrudan_Rebeca
{
    public partial class Form1 : Form
    {

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        public Form1()
        {
            InitializeComponent();
        }

        int nr1, nr2, op; // +=1, -=2, /=3, *=4, ^=5, rad=6

        private void b_3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(3);
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(4);
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(5);
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(6);
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(7);
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(8);
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(9);
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(0);
        }

        private void b_Plus_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            op = 1;
        }

        private void b_Minus_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            op = 2;
        }

        private void b_Ori_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            op = 4;
        }

        private void b_Imp_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            op = 3;
        }

        private void b_Egal_Click(object sender, EventArgs e)
        {
            nr2 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            if (op == 1)
            {
                label1.Text = Convert.ToString(nr1 + nr2);
            }
            else
            {
                if (op == 2)
                {
                    label1.Text = Convert.ToString(nr1 - nr2);
                }
                else
                {
                    if (op == 3)
                    {
                        if (nr2 == 0)
                            label1.Text = "Eroare!";
                        else
                        {
                            float c;
                            c = (float)nr1 / nr2;
                            label1.Text = Convert.ToString(c);
                        }
                    }
                    else
                    {
                        if (op == 4)
                        {
                            label1.Text = Convert.ToString(nr1 * nr2);
                        }
                        else
                        {
                            if (op == 5)
                            {
                                label1.Text = Convert.ToString(Math.Pow(nr1, nr2));
                            }
                            else
                            {
                                if(op==6)
                                {
                                    label1.Text = Convert.ToString(Math.Log(nr2, nr1));
                                }
                            }
                        }
                    }
                }
            }
        }

        private void b_c_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void b_Sterge_Click(object sender, EventArgs e)
        {
            string s = label1.Text;
            if (s.Length > 1)
                s = s.Substring(0, s.Length - 1);
            else
                s = "";
            label1.Text = s;
            if (op == 0)
            {
                if (s != "")
                    nr1 = Convert.ToInt32(label1.Text);
                else
                    nr1 = 0;
            }
            else
            {
                if (s != "")
                    nr2 = Convert.ToInt32(label1.Text);
                else
                    nr2 = 0;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void b_Putere_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            op = 5;
        }

        private void b_Rad_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            op = 6;
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(2);
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Convert.ToString(1);
        }
    }
}
