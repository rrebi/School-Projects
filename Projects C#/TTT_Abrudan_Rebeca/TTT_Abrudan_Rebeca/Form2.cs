using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT_Abrudan_Rebeca
{
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
