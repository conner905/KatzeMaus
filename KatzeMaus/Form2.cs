using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatzeMaus1
{
    public partial class Form2 : Form
    {

        int timeLeft = 15;
        int mpunkt = 0;
        int kpunkt = 0;
        bool spielerEinsIstKatze;
        public Form2(int groesse, int zeit, bool spielerEinsIstKatze)
        {
            this.spielerEinsIstKatze = spielerEinsIstKatze;
            InitializeComponent();
            if (zeit == 0)
            {
                timeLeft = 10;
            }
            if (zeit == 2)
            {
                timeLeft = 20;
            }
            if (groesse == 1)
            {
                this.Width = 1100;
                this.Height = 750;
            }
            if (groesse == 2)
            {
                this.Width = 1800;
                this.Height = 1100;
            }

            Maus.Location = new Point(this.Width - Maus.Width - 30, this.Height - Maus.Height - 50);

            timer1.Start();
        }



        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (spielerEinsIstKatze == true)
                    KHoch();
                else
                    MHoch();
            }

                if (e.KeyCode == Keys.S)
                {
                    if (spielerEinsIstKatze == true)
                        KUnten();
                    else
                        MUnten();
                }
                if (e.KeyCode == Keys.A)
                {
                    if (spielerEinsIstKatze == true)
                        KLinks();
                    else
                        MLinks();
                }
                if (e.KeyCode == Keys.D)
                {
                    if (spielerEinsIstKatze == true)
                        KRechts();
                    else
                        MRechts();
                }

                if (e.KeyCode == Keys.Up)
                {
                    if (spielerEinsIstKatze == true)
                        MHoch();
                    else
                        KHoch();
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (spielerEinsIstKatze == true)
                        MUnten();
                    else
                        KUnten();
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (spielerEinsIstKatze == true)
                        MLinks();
                    else
                        KLinks();
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (spielerEinsIstKatze == true)
                        MRechts();
                    else
                        KRechts();
                }


                if (Maus.Bounds.IntersectsWith(Katze.Bounds))
                {
                    kpunkt++;
                    reset();
                }
                if (Maus.Bounds.IntersectsWith(Mauseloch.Bounds))
                {
                    mpunkt++;
                    reset();
                }
         }


            private void timer1_Tick_1(object sender, EventArgs e)
            {
                if (timeLeft > 0)
                {
                    label5.Text = kpunkt.ToString();
                    label4.Text = mpunkt.ToString();

                    timeLeft = timeLeft - 1;
                    label1.Text = timeLeft.ToString();
                }
                else
                {
                    mpunkt++;
                    label4.Text = mpunkt.ToString();
                    timer1.Stop();
                    reset();
                }
                if (mpunkt == 7 || kpunkt == 7)
                {
                    mpunkt = 0;
                    kpunkt = 0;
                    reset();
                }

            }
            public void reset()
            {
                Katze.Location = new Point(20, +30);
                Maus.Location = new Point(this.Width - Maus.Width - 30, this.Height - Maus.Height - 50);
                timeLeft = 15;
                timer1.Start();
            }


            public void KHoch()
            {
                Katze.Location = new Point(Katze.Location.X + 0, Katze.Location.Y - 10);
                if (Katze.Location.Y < -10)
                {
                    Katze.Location = new Point(Katze.Location.X, Katze.Location.Y + 10);
                }
            }

            public void MHoch()
            {
                Maus.Location = new Point(Maus.Location.X + 0, Maus.Location.Y - 10);
                if (Maus.Location.Y < -10)
                {
                    Maus.Location = new Point(Maus.Location.X, Maus.Location.Y + 10);
                }
            }

            public void KLinks()
            {
                Katze.Location = new Point(Katze.Location.X - 10, Katze.Location.Y + 0);
                if (Katze.Location.X < -10)
                {
                    Katze.Location = new Point(Katze.Location.X + 10, Katze.Location.Y);
                }
            }

            public void MLinks()
            {
                Maus.Location = new Point(Maus.Location.X - 10, Maus.Location.Y);
                if (Maus.Location.X < -10)
                {
                    Maus.Location = new Point(Maus.Location.X + 10, Maus.Location.Y);
                }
            }

            public void KUnten()
            {
                Katze.Location = new Point(Katze.Location.X + 0, Katze.Location.Y + 10);
                if (Katze.Location.Y + Katze.Height > this.Height - 50)
                {
                    Katze.Location = new Point(Katze.Location.X, this.Height - Katze.Width - 20);
                }
            }

            public void MUnten()
            {
                Maus.Location = new Point(Maus.Location.X + 0, Maus.Location.Y + 10);
                if (Maus.Location.Y + Maus.Height > this.Height - 50)
                {
                    Maus.Location = new Point(Maus.Location.X, this.Height - Maus.Width - 20);
                }
            }

            public void KRechts()
            {
                Katze.Location = new Point(Katze.Location.X + 10, Katze.Location.Y + 0);
                if (Katze.Location.X + Katze.Width > this.Width - 20)
                {
                    Katze.Location = new Point(this.Width - Katze.Width - 20, Katze.Location.Y);
                }
            }

            public void MRechts()
            {
                Maus.Location = new Point(Maus.Location.X + 10, Maus.Location.Y);
                if (Maus.Location.X + Maus.Width > this.Width - 20)
                {
                    Maus.Location = new Point(this.Width - Maus.Width - 20, Maus.Location.Y);
                }
            }
        }
    }

