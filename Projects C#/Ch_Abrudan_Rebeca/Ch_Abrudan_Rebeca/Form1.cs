using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_Abrudan_Rebeca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            juc1.Visible = false;
            juc2.Visible = false;
        }

        int n = 16;
        int x = 1;
        
        private void c1_Click(object sender, EventArgs e)
        {
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;
            c10.Enabled = false;
            c11.Enabled = false;
            c12.Enabled = false;
            c13.Enabled = false;
            c14.Enabled = false;
            c15.Enabled = false;
            c16.Enabled = false;

            c1.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c2_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;
            c10.Enabled = false;
            c11.Enabled = false;
            c12.Enabled = false;
            c13.Enabled = false;
            c14.Enabled = false;
            c15.Enabled = false;
            c16.Enabled = false;

            c2.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c3_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;
            c10.Enabled = false;
            c11.Enabled = false;
            c12.Enabled = false;
            c13.Enabled = false;
            c14.Enabled = false;
            c15.Enabled = false;
            c16.Enabled = false;

            c3.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c4_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;
            c10.Enabled = false;
            c11.Enabled = false;
            c12.Enabled = false;
            c13.Enabled = false;
            c14.Enabled = false;
            c15.Enabled = false;
            c16.Enabled = false;

            c4.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c5_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c10.Enabled = false;
            c11.Enabled = false;
            c12.Enabled = false;
            c13.Enabled = false;
            c14.Enabled = false;
            c15.Enabled = false;
            c16.Enabled = false;

            c5.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c6_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c10.Enabled = false;
            c11.Enabled = false;
            c12.Enabled = false;
            c13.Enabled = false;
            c14.Enabled = false;
            c15.Enabled = false;
            c16.Enabled = false;

            c6.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c7_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c10.Enabled = false;
            c11.Enabled = false;
            c12.Enabled = false;
            c13.Enabled = false;
            c14.Enabled = false;
            c15.Enabled = false;
            c16.Enabled = false;

            c7.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c8_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c10.Enabled = false;
            c11.Enabled = false;
            c12.Enabled = false;
            c13.Enabled = false;
            c14.Enabled = false;
            c15.Enabled = false;
            c16.Enabled = false;

            c8.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c9_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c10.Enabled = false;
            c11.Enabled = false;
            c12.Enabled = false;
            c13.Enabled = false;
            c14.Enabled = false;
            c15.Enabled = false;
            c16.Enabled = false;

            c9.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c10_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;

            c10.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c11_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;

            c11.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c12_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;

            c12.Visible = false;

            n--;
            if (n <= 1 && x==1) 
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c13_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;

            c13.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c14_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;

            c14.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c16_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;

            c16.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void c15_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            c4.Enabled = false;
            c5.Enabled = false;
            c6.Enabled = false;
            c7.Enabled = false;
            c8.Enabled = false;
            c9.Enabled = false;

            c15.Visible = false;

            n--;
            if (n <= 1 && x == 1)
                juc1.Visible = true;
            if (n <= 1 && x == 2)
                juc2.Visible = true;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            n = 16;
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;
            c4.Visible = true;
            c5.Visible = true;
            c6.Visible = true;
            c7.Visible = true;
            c8.Visible = true;
            c9.Visible = true;
            c10.Visible = true;
            c11.Visible = true;
            c12.Visible = true;
            c13.Visible = true;
            c14.Visible = true;
            c15.Visible = true;
            c16.Visible = true;

            juc1.Visible = false;
            juc2.Visible = false;

            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;
            c4.Enabled = true;
            c5.Enabled = true;
            c6.Enabled = true;
            c7.Enabled = true;
            c8.Enabled = true;
            c9.Enabled = true;
            c10.Enabled = true;
            c11.Enabled = true;
            c12.Enabled = true;
            c13.Enabled = true;
            c14.Enabled = true;
            c15.Enabled = true;
            c16.Enabled = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next_Click(object sender, EventArgs e)
        {
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;
            c4.Enabled = true;
            c5.Enabled = true;
            c6.Enabled = true;
            c7.Enabled = true;
            c8.Enabled = true;
            c9.Enabled = true;
            c10.Enabled = true;
            c11.Enabled = true;
            c12.Enabled = true;
            c13.Enabled = true;
            c14.Enabled = true;
            c15.Enabled = true;
            c16.Enabled = true;

            if (x == 1)
                x = 2;
            else
                x = 1;

            lbl_n.Text = Convert.ToString(x);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
