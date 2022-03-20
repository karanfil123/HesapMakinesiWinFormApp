using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Rakamlar_Click(object sender, EventArgs e)
        {
            txt_Metin.Text = txt_Metin.Text + ((Button)sender).Text;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\ikrnf\source\repos\HesapMakinesi\a.mp3";
            var Esc = 27;
            var Del = 127;
            var C = 84;
            var Virgul = 110;
            var esit = 13;
            var bol = 47;
            var carp = 42;
            var cikar = 45;
            var topla = 43;
            char x = e.KeyChar;
            if (x == '1')
            {
                btn1.PerformClick();

            }
            else if (x == '2')
            {
                btn_2.PerformClick();

            }
            else if (x == '3')
            {
                btn_3.PerformClick();

            }
            else if (x == '4')
            {
                btn_4.PerformClick();

            }
            else if (x == '5')
            {
                btn_5.PerformClick();

            }
            else if (x == '6')
            {
                btn_6.PerformClick();

            }
            else if (x == '7')
            {
                btn_7.PerformClick();

            }
            else if (x == '8')
            {
                btn_8.PerformClick();

            }
            else if (x == '9')
            {
                btn_9.PerformClick();

            }
            else if (x == '0')
            {
                btn_0.PerformClick();

            }
            else if (x == Esc)
            {
                btn_Esc.PerformClick();

            }
            else if (x == Del)
            {
                btn_Del.PerformClick();

            }
            else if (x == C)
            {
                btn_C.PerformClick();

            }
            else if (x == Virgul)
            {
                btn_virgul.PerformClick();

            }
            else if (x == esit)
            {
                btn_Sonuc.PerformClick();

            }
            else if (x == bol)
            {
                btn_Bolme.PerformClick();

            }
            else if (x == carp)
            {
                btn_Carpi.PerformClick();

            }
            else if (x == cikar)
            {
                btn_Eksi.PerformClick();

            }
            else if (x == topla)
            {
                btn_Arti.PerformClick();

            }
        }

        private void btn_Esc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Kapanıyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\ikrnf\source\repos\HesapMakinesi\a.mp3";
            txt_Metin.Text = txt_Metin.Text.Substring(0, txt_Metin.Text.Length - 1);
            if (txt_Metin.Text == "")
            {
                txt_Metin.Text = "0";
            }
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\ikrnf\source\repos\HesapMakinesi\a.mp3";
            txt_Metin.Clear();
            txt_Metin.Text = "0";
        }
        private void btn_virgul_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\ikrnf\source\repos\HesapMakinesi\a.mp3";
            if (txt_Metin.Text.IndexOf(",") < 1)
            {
                txt_Metin.Text = txt_Metin.Text + ",";
            }
        }


        private void btn_Bolme_Click(object sender, EventArgs e)
        {
            string bk = btn_Bolme.Text;
        }

        private void btn_Carpi_Click(object sender, EventArgs e)
        {
            txt_Metin.Text = txt_Metin.Text + "x";
        }

        private void btn_Eksi_Click(object sender, EventArgs e)
        {
            txt_Metin.Text = txt_Metin.Text + "-";
        }

        private void btn_Arti_Click(object sender, EventArgs e)
        {
            txt_Metin.Text = txt_Metin.Text + "-";
        }
        string op = null;
        private void btn_Sonuc_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "/":

                default:
                    break;
            }
        }
    }
}
