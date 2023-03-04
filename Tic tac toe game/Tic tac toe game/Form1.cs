using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe_game
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        bool gedis = true;
        int saygac = 0;

        private void frmmain_Load(object sender, EventArgs e)
        {
            panel2.Enabled = false;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            btnplayer1.BackColor = Color.Green;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void a1_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = (Button)sender;
                if (gedis == true)
                {
                    a.Text = "X";
                    
                    btnplayer2.BackColor = Color.Green;
                    btnplayer1.BackColor = Color.FloralWhite;
                }
                else
                {
                    a.Text = "0";
                    btnplayer1.BackColor = Color.Green;
                    btnplayer2.BackColor = Color.FloralWhite;
                }
                    
                gedis = !gedis;
                saygac++;
                btnstart.Enabled = false;
                a.Enabled = false;
                check();
                
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void check()
        {
            bool qalibmovcudur = false;

            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && a1.Text != "")
                qalibmovcudur = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && b1.Text != "")
                qalibmovcudur = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && c1.Text != "")
                qalibmovcudur = true;

            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && a1.Text != "")
                qalibmovcudur = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && a2.Text != "")
                qalibmovcudur = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && a3.Text != "")
                qalibmovcudur = true;

            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && a1.Text != "")
                qalibmovcudur = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && b2.Text != "")
                qalibmovcudur = true;


            if (qalibmovcudur)
            {
                btnrestart.Enabled = true;
                btnplayer1.BackColor = Color.FloralWhite;
                btnplayer2.BackColor = Color.FloralWhite;
                string netice = "";
                if (gedis)
                {
                    netice = "0";
                }
                else
                    netice = "X";
                MessageBox.Show("Oyunun qalib " + netice + " dir! Davam etmək üçün OK klik edin", "Nəticə");
            }
            else if (saygac==9)
            {
                btnstart.Enabled = true;
                MessageBox.Show("Oyun heç-heçə bitdi!  Davam etmək üçün OK klik edin");
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = (Button)sender;
                if (gedis == true)
                {
                    a.Text = "X";
                    btnplayer2.BackColor = Color.Green;
                    btnplayer1.BackColor = Color.FloralWhite;
                }
                else
                {
                    a.Text = "0";
                    btnplayer1.BackColor = Color.Green;
                    btnplayer2.BackColor = Color.FloralWhite;
                }
                    
                gedis = !gedis;
                saygac++;
                btnstart.Enabled = false;
                a.Enabled = false;
                check();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = (Button)sender;
                if (gedis == true)
                {
                    a.Text = "X";
                    btnplayer2.BackColor = Color.Green;
                    btnplayer1.BackColor = Color.FloralWhite;
                }
                else
                {
                    a.Text = "0";
                    btnplayer1.BackColor = Color.Green;
                    btnplayer2.BackColor = Color.FloralWhite;
                }
                    
                gedis = !gedis;
                saygac++;
                btnstart.Enabled = false;
                a.Enabled = false;
                check();
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = (Button)sender;
                if (gedis == true)
                {
                    a.Text = "X";
                    btnplayer2.BackColor = Color.Green;
                    btnplayer1.BackColor = Color.FloralWhite;
                }
                else
                {
                    a.Text = "0";
                    btnplayer1.BackColor = Color.Green;
                    btnplayer2.BackColor = Color.FloralWhite;
                }
                    
                gedis = !gedis;
                saygac++;
                btnstart.Enabled = false;
                a.Enabled = false;
                check();

                btnstart.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = (Button)sender;
                if (gedis == true)
                {
                    a.Text = "X";
                    btnplayer2.BackColor = Color.Green;
                    btnplayer1.BackColor = Color.FloralWhite;
                }
                else
                {
                    a.Text = "0";
                    btnplayer1.BackColor = Color.Green;
                    btnplayer2.BackColor = Color.FloralWhite;
                }
                    
                gedis = !gedis;
                saygac++;
                btnstart.Enabled = false;
                a.Enabled = false;
                check();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = (Button)sender;
                if (gedis == true)
                {
                    a.Text = "X";
                    btnplayer2.BackColor = Color.Green;
                    btnplayer1.BackColor = Color.FloralWhite;
                }
                else
                {
                    a.Text = "0";
                    btnplayer1.BackColor = Color.Green;
                    btnplayer2.BackColor = Color.FloralWhite;
                }
                    
                gedis = !gedis;
                saygac++;
                btnstart.Enabled = false;
                a.Enabled = false;
                check();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = (Button)sender;
                if (gedis == true)
                {
                    a.Text = "X";
                    btnplayer2.BackColor = Color.Green;
                    btnplayer1.BackColor = Color.FloralWhite;
                }
                else
                {
                    a.Text = "0";
                    btnplayer1.BackColor = Color.Green;
                    btnplayer2.BackColor = Color.FloralWhite;
                }
                    
                gedis = !gedis;
                saygac++;
                btnstart.Enabled = false;
                a.Enabled = false;
                check();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = (Button)sender;
                if (gedis == true)
                {
                    a.Text = "X";
                    btnplayer2.BackColor = Color.Green;
                    btnplayer1.BackColor = Color.FloralWhite;
                }
                else
                {
                    a.Text = "0";
                    btnplayer1.BackColor = Color.Green;
                    btnplayer2.BackColor = Color.FloralWhite;
                }
                    
                gedis = !gedis;
                saygac++;
                btnstart.Enabled = false;
                a.Enabled = false;
                check();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = (Button)sender;
                if (gedis == true)
                {
                    a.Text = "X";
                    btnplayer2.BackColor = Color.Green;
                    btnplayer1.BackColor = Color.FloralWhite;
                }
                else
                {
                    a.Text = "0";
                    btnplayer1.BackColor = Color.Green;
                    btnplayer2.BackColor = Color.FloralWhite;
                }
                    
                gedis = !gedis;
                saygac++;
                btnstart.Enabled = false;
                a.Enabled = false;
                check();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {

            saygac = 0;
            gedis = true;
            a1.Text = "";
            a1.Enabled = true;
            a2.Text = "";
            a2.Enabled = true;
            a3.Text = "";
            a3.Enabled = true;
            b1.Text = "";
            b1.Enabled = true;
            b2.Text = "";
            b2.Enabled = true;
            b3.Text = "";
            b3.Enabled = true;
            c1.Text = "";
            c1.Enabled = true;
            c2.Text = "";
            c2.Enabled = true;
            c3.Text = "";
            c3.Enabled = true;
            btnstart.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
