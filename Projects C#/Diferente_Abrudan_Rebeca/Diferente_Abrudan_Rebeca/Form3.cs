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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
        }

        int nr = 3;

        private void dif2_Click(object sender, EventArgs e)
        {
            nr--;
            lbl_dif.Text = Convert.ToString(nr);
            dif2.Visible = false;
            if (nr == 0)
            {
                MessageBox.Show("YOU WON!");
                button1.Visible = true;
                button2.Visible = true;
            }
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
                button2.Visible = true;
            }
        }

        private void dif1_Click(object sender, EventArgs e)
        {
            nr--;
            lbl_dif.Text = Convert.ToString(nr);
            dif1.Visible = false;
            if (nr == 0)
            {
                MessageBox.Show("YOU WON!");
                button1.Visible = true;
                button2.Visible = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
