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
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
        }
    }
}
