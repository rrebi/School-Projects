using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diferente_Abrudan_Rebeca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        int nr = 4;

        private void dif1_Click(object sender, EventArgs e)
        {
            nr--;
            lbl_dif.Text = Convert.ToString(nr);
            dif1.Visible = false;
            if (nr == 0)
            {
                MessageBox.Show("YOU WON!");
                button1.Visible = true;
            }
        }

        private void dif4_Click(object sender, EventArgs e)
        {
            nr--;
            lbl_dif.Text = Convert.ToString(nr);
            dif4.Visible = false;
            if (nr == 0)
            {
                MessageBox.Show("YOU WON!");
                button1.Visible = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            dif1.Visible = true;
            dif2.Visible = true;
            dif3.Visible = true;
            nr = 3;
            lbl_dif.Text = Convert.ToString(nr);
        }

        private void dif3_Click(object sender, EventArgs e)
        {
            nr--;
            lbl_dif.Text = Convert.ToString(nr);
            dif3.Visible = false;
            if (nr == 0)
            {
                MessageBox.Show("YOU WON!");
                button1.Visible = true;
            }
        }

        private void dif2_Click(object sender, EventArgs e)
        {
            nr--;
            lbl_dif.Text = Convert.ToString(nr);
            dif2.Visible = false;
            if (nr == 0)
            {
                MessageBox.Show("YOU WON!");
                button1.Visible = true;
            }
        }
    }
}
