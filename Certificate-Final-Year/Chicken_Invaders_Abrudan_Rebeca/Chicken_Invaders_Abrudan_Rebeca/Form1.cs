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
    public partial class ChickenInvaders : Form
    {
        
        int puiViteza = 2, StPui = 0, vieti = 3, scor = 0;
        int streak = 0;
        
        Poza _nava;
        
        List<Poza> _glont = new List<Poza>();

        Bitmap _puiI = Properties.Resources.puiV;
        List<Bitmap> _puiF = new List<Bitmap>();
        Poza[,] _pui = new Poza[3, 6];
        int[] puiT = new int[3];

        List<Poza> _inimi = new List<Poza>();

        Bitmap _ouS = Properties.Resources.ouS;
        List<Bitmap> _ouSF = new List<Bitmap>();
        List<Poza> _ou = new List<Poza>();

        Random rand = new Random();

        public ChickenInvaders()
        {
            InitializeComponent();
            initial();
            DoubleBuffered = true;
        }

        private void initial()
        {
            bara.Width = 900;
            bara.Left = 1;
            bara.Top = 243;
            bara.Tag = "bara";

            _nava = new Poza(80, 80);
            _nava.Left = Width / 2 - _nava.Width / 2;
            _nava.Top = Height - _nava.Height;
            _nava.Tag = "nava";
            _nava.Image = Properties.Resources.nava;
            Controls.Add(_nava);

            impartireImagini(_puiI, _puiF, 10);

            crearePui();

            creareInimi();

            impartireImagini(_ouS, _ouSF, 8);
        }

        private void creareInimi()
        {
            Bitmap inima = Properties.Resources.inimaR;
            for (int i = 0; i < 3; i++)
            {
                _inimi.Add(new Poza(40, 40));
                _inimi[i].Image = inima;
                _inimi[i].Left = Width - (3 - i) * 45;
                Controls.Add(_inimi[i]);
            }
        }

        private void crearePui()
        {
            Bitmap img = _puiF[0];
            for (int i = 0; i < 3; i++)
            {
                puiT[i] = i * 80 + img.Height;
                for (int j = 0; j < 6; j++)
                {
                    Poza bpui = new Poza(img.Width, img.Height);
                    bpui.Image = img;
                    bpui.Tag = "pui";
                    bpui.Left = j * 80;
                    bpui.Top = i * 80 + img.Height;
                    _pui[i, j] = bpui;
                    Controls.Add(bpui);
                }
            }
        }

        private void impartireImagini(Bitmap originala, List<Bitmap> res, int n)
        {
            int w = originala.Width / n;
            int h = originala.Height;
            for(int i = 0; i < n; i++)
            {
                int s = i * w;
                Bitmap Poza = new Bitmap(w, h);
                for (int j = 0; j < h; j++)
                    for (int k = 0; k < w; k++)
                        Poza.SetPixel(k, j, originala.GetPixel(k + s, j));
                res.Add(Poza);
            }
        }

        private void otimer_Tick(object sender, EventArgs e)
        {
            if (rand.Next(200) == 5)
                aurncaOu();

            for(int i = 0; i < _ou.Count; i++)
            {
                _ou[i].Top += _ou[i].ouViteza;
                if(_nava.Bounds.IntersectsWith(_ou[i].Bounds))
                {
                    Controls.Remove(_ou[i]);
                    _ou.RemoveAt(i);
                    scadeVieti();
                    break;
                }
                if (_ou[i].Top >= Height - (_ou[i].Height + 20))
                {
                    _ou[i].ouViteza = 0;
                    if(_ou[i].ouCount / 2 < _ouSF.Count) //ouCount==0 initial
                    {
                        _ou[i].ouCount += 1;
                    } 
                    else
                    
                    {
                        Controls.Remove(_ou[i]);
                        _ou.RemoveAt(i);
                    }
                }
            }
        }

        private void scadeVieti()
        {
            vieti -= 1;
            _inimi[vieti].Image = Properties.Resources.inima;
            if (vieti < 1)
                SfJoc(Properties.Resources.GameOver);
        }
                
        private void SfJoc(Bitmap gameOver)
        {
            otimer.Stop();
            gtimer.Stop();
            ptimer.Stop();
            Controls.Clear();

            Poza sf = new Poza(300, 300);
            sf.Click += inchide;
            sf.Image = gameOver;
            sf.Left = Width / 2 - sf.Width / 2;
            sf.Top = Height / 2 - sf.Height / 2;
            Controls.Add(sf);

            Poza sageata = new Poza(300, 200);
            sageata.Image = Properties.Resources.arrow;
            sageata.Left = 1;
            sageata.Top = sageata.Height;
            Controls.Add(sageata);

            Button next = new Button();
            next.Location = new Point(600, 400);
            next.Text = "NEXT LEVEL";
            next.AutoSize = true;
            next.Enabled = true;
            next.BackColor = Color.White;
            next.ForeColor = Color.Black;
            next.Font = new Font("Goudy Stout", 12);
            next.Click += new EventHandler(nxt);
            Controls.Add(next);
            

            Button restart = new Button();
            restart.Location = new Point(400, 400);
            restart.Text = "RESTART";
            restart.AutoSize = true;
            restart.BackColor = Color.White;
            restart.ForeColor = Color.Black;
            restart.Font = new Font("Goudy Stout", 12);
            restart.Click += new EventHandler(restrt);
            Controls.Add(restart);
        }

        private void restrt(object sender, EventArgs e)
        {
            this.Hide();
            ChickenInvaders f1 = new ChickenInvaders();
            f1.Show();
        }

        private void nxt(object sender, EventArgs e)
        {
            this.Hide();
            Lv2 f1 = new Lv2();
            f1.Size = new Size(900, 500);
            f1.Show();
        }

        private void inchide(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aurncaOu()
        {
            List<Poza> puiDisponibili = new List<Poza>();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 6; j++)
                    if (_pui[i, j] != null)
                        puiDisponibili.Add(_pui[i, j]);

            //(random) puiul de la care cade oul
            Poza bpui = puiDisponibili[rand.Next() % puiDisponibili.Count];
            Poza ou = new Poza(10, 10);
            ou.Image = Properties.Resources.ou;
            ou.Tag = "ou";
            ou.Left = bpui.Left + bpui.Width / 2 - ou.Width / 2;
            ou.Top = bpui.Top + bpui.Height;
            _ou.Add(ou);
            Controls.Add(ou);
        }

        private void ChickenInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    _nava.Left -= 10;
                    break;
                case Keys.Right:
                    _nava.Left += 10;
                    break;
                case Keys.Up:
                    _nava.Top -= 10;
                    break;
                case Keys.Down:
                    _nava.Top += 10;
                    break;
            }
        }

        private void ChickenInvaders_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (streak < 3)
                    aruncaGloante(Properties.Resources.b1);
                else
                    if(streak >= 3 && streak < 9)
                        aruncaGloante(Properties.Resources.b2);
                    else
                        if(streak >= 9)
                            aruncaGloante(Properties.Resources.b3);
            }
        }

        private void aruncaGloante(Bitmap gloante)
        {
            Poza glont = new Poza(5, 5);
            glont.Tag = "glont";
            glont.Left = _nava.Left + _nava.Width / 2 - glont.Width / 2;
            glont.Top = _nava.Top - glont.Height;
            glont.Image = gloante;
            _glont.Add(glont);
            Controls.Add(glont); 
        }

        private void ptimer_Tick(object sender, EventArgs e)
        {
            if (StPui + 490 > Width || StPui < 0)
            {
                puiViteza = -puiViteza;
            }
            StPui += puiViteza;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 6; j++)
                {
                    if (_pui[i, j] == null)
                        continue;
                    _pui[i, j].Left += puiViteza;

                    if (_nava.Bounds.IntersectsWith(_pui[i,j].Bounds))
                    {
                        scadeVieti();
                        _nava.Left = Width / 2 - _nava.Width / 2;
                        _nava.Top = Height - _nava.Height;
                    }
                }
            
        }
        
        private void gtimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < _glont.Count; i++)
                _glont[i].Top -= 20;
            atingereGlont();
            if (scor == 180)
                SfJoc(Properties.Resources.win);
        }

        private void atingereGlont()
        {
            
            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "pui")
                    {
                        if (j is PictureBox && j.Tag == "glont")
                        {

                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                scor += 10;
                                lbl_scor.Text = "Score: " + scor.ToString();
                                this.Controls.Remove(i);
                                this.Controls.Remove(j);
                                streak++;
                            }
                        }
                    }
                }
            }

            foreach (Control y in this.Controls)
            {
                foreach (Control z in this.Controls)
                {
                    if (y is PictureBox && y.Tag == "ou")
                    {
                        if (z is PictureBox && z.Tag == "glont")
                        {

                            if (y.Bounds.IntersectsWith(z.Bounds))
                            {
                                
                                this.Controls.Remove(y);
                                this.Controls.Remove(z);
                            }
                        }
                    }
                }
            }

            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "bara")
                    {
                        if (j is PictureBox && j.Tag == "nava")
                        {

                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                scadeVieti();
                                _nava.Left = Width / 2 - _nava.Width / 2;
                                _nava.Top = Height - _nava.Height;
                            }
                        }
                    }
                }
            }
        }
    }
}
