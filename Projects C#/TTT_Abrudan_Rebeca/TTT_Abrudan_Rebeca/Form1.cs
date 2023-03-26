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
    public partial class Form1 : Form
    {
        bool turn = true; //true = X turn; false = Y turn
        int turn_count = 0;
        

        public Form1()
        {
            InitializeComponent();
            b_l.Visible = false;
            b_w.Visible = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "0";
            turn = !turn;
            b.Enabled = false;
            exit.Enabled = true;
            restart.Enabled = true;
            turn_count++;
            check_winner();
        }

        private void check_winner()
        {
            bool win = false;

            //orizontal
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                win = true;
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && (!b4.Enabled))
                win = true;
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && (!b7.Enabled))
                win = true;

            //vertical
            if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && (!b1.Enabled))
                win = true;
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && (!b2.Enabled))
                win = true;
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && (!b3.Enabled))
                win = true;

            //diagonal
            if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b1.Enabled))
                win = true;
            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && (!b3.Enabled))
                win = true;

            if (win)
            {
                disable_buttons();
                String winner = "";
                if (turn)
                    winner = "0";
                else
                    winner = "X";
                //essageBox.Show("The winner is " + winner, "Congrats!");
                b_w.Visible = true;
            }
            else
            {
                if (turn_count == 9)
                    //MessageBox.Show("Draw");
                    b_l.Visible = true;
            }
        }

        private void disable_buttons()
        {
            foreach (Component c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
                exit.Enabled = true;
                restart.Enabled = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Component c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = true;
                exit.Enabled = true;
                restart.Enabled = true;
                b_l.Visible = false;
                b_w.Visible = false;
                b.Text = "";
                exit.Text = "EXIT";
                restart.Text = "RESTART";
            }
        }
    }
}
