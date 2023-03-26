using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chicken_Invaders_Abrudan_Rebeca
{
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();

            Poza _pui;

            _pui = new Poza(80, 80);
            _pui.Image = Properties.Resources.puii;
            Controls.Add(_pui);

            _pui = new Poza(80, 80);
            _pui.Left = Width - _pui.Width;
            _pui.Image = Properties.Resources.puii;
            Controls.Add(_pui);

            _pui = new Poza(80, 80);
            _pui.Left = Width - _pui.Width;
            _pui.Top = Height - _pui.Height;
            _pui.Image = Properties.Resources.puii;
            Controls.Add(_pui);

            _pui = new Poza(80, 80);
            _pui.Top = Height - _pui.Height;
            _pui.Image = Properties.Resources.puii;
            Controls.Add(_pui);

            _pui = new Poza(60, 60);
            _pui.Left = Width / 2 - _pui.Width * 2;
            _pui.Top = Height - _pui.Height;
            _pui.Image = Properties.Resources.puiii;
            Controls.Add(_pui);

            _pui = new Poza(60, 60);
            _pui.Left = Width / 2 + _pui.Width;
            _pui.Top = Height - _pui.Height;
            _pui.Image = Properties.Resources.puiiii;
            Controls.Add(_pui);
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChickenInvaders f1 = new ChickenInvaders();
            f1.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
