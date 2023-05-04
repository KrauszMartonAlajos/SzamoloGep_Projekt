using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzamoloGep_Beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
            
        }
        int eredmeny = 0;
        string aktszam = "";
        double szam;
        bool vz = true;
        string muvelet = "";
        private void ketto_nhatvanya_Click(object sender, EventArgs e)
        {
            vz = !vz;
        }

        private void pi_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            szam = pi;
            aktszam = Convert.ToString(szam);
        }

        private void e_szam_Click(object sender, EventArgs e)
        {
            double e_szam = Math.E;
            szam = e_szam;
            aktszam = Convert.ToString(szam);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            aktszam = "";
            szam = 0;
        }

        private void torles_Click(object sender, EventArgs e)
        {
            //el távolítja az utolsó számjegyet az aktuális számból
            aktszam = aktszam.Remove(aktszam.Length - 1);
            label1.Text = aktszam;
        }

        private void negyzet_Click(object sender, EventArgs e)
        {
            double szamh = Convert.ToDouble(aktszam);

            szam = szamh * szamh;

            label1.Text = Convert.ToString(szam);
            aktszam = "";
        }

        private void reciprok_Click(object sender, EventArgs e)
        {
            double reciproka = 1 / Convert.ToDouble(aktszam);
            aktszam = Convert.ToString(reciproka);
        }

        private void abs_Click(object sender, EventArgs e)
        {
            double absszam = Math.Abs(Convert.ToDouble(aktszam));
            aktszam = Convert.ToString(absszam);
        }

        private void exp_Click(object sender, EventArgs e)
        {
            //nem kell
        }

        private void mod_Click(object sender, EventArgs e)
        {

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            aktszam = Convert.ToString(Math.Sqrt(Convert.ToDouble(aktszam)));
            label1.Text = aktszam;
        }

        private void zarjel_sad_Click(object sender, EventArgs e)
        {
            //nem kell
        }

        private void zarjel_happy_Click(object sender, EventArgs e)
        {
            //nem kell
        }

        private void n_faktorialis_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(aktszam);
            double megoldas = 1;
            for (int i = 1; i < n+1; i++)
            {
                megoldas *= i;
            }
            aktszam = Convert.ToString(megoldas);
            label1.Text = aktszam;
        }

        private void osztas_Click(object sender, EventArgs e)
        {
            muvelet = "/";
        }

        private void x_y_hatvanyon_Click(object sender, EventArgs e)
        {
            double elsoszam = Convert.ToDouble(aktszam);
            aktszam = "";
            double masodikszam = Convert.ToDouble(aktszam);
            double megoldas = Math.Pow(elsoszam, masodikszam);
            aktszam = Convert.ToString(megoldas);
            label1.Text = aktszam;
            //?
        }

        private void het_Click(object sender, EventArgs e)
        {
            aktszam += "7";
            label1.Text = aktszam;
        }

        private void nyolc_Click(object sender, EventArgs e)
        {
            aktszam += "8";
            label1.Text = aktszam;
        }

        private void kilenc_Click(object sender, EventArgs e)
        {
            aktszam += "9";
            label1.Text = aktszam;
        }

        private void szorzas_Click(object sender, EventArgs e)
        {
            muvelet = "*";
        }

        private void tiz_x_hatvanyon_Click(object sender, EventArgs e)
        {
            double megoldas = Math.Pow(10,Convert.ToDouble(aktszam));
            aktszam = Convert.ToString(megoldas);
            label1.Text = aktszam;
        }

        private void negy_Click(object sender, EventArgs e)
        {
            aktszam += "4";
            label1.Text = aktszam;
        }

        private void ot_Click(object sender, EventArgs e)
        {
            aktszam += "5";
            label1.Text = aktszam;
        }

        private void hat_Click(object sender, EventArgs e)
        {
            aktszam += "6";
            label1.Text = aktszam;
        }

        private void kivonas_Click(object sender, EventArgs e)
        {
            aktszam += "-";
        }

        private void log_Click(object sender, EventArgs e)
        {
            //?
        }

        private void egy_Click(object sender, EventArgs e)
        {
            aktszam += "1";
            label1.Text = aktszam;
        }

        private void ketto_Click(object sender, EventArgs e)
        {
            aktszam += "2";
            label1.Text = aktszam;
        }

        private void harom_Click(object sender, EventArgs e)
        {
            aktszam += "3";
            label1.Text = aktszam;
        }

        private void osszeadas_Click(object sender, EventArgs e)
        {
            muvelet = "+";
        }

        private void In_Click(object sender, EventArgs e)
        {
            //?
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //előjel csere
            double megoldas = Convert.ToDouble(aktszam) * -1;
            aktszam = Convert.ToString(megoldas);
            label1.Text = aktszam;
        }

        private void nulla_Click(object sender, EventArgs e)
        {
            aktszam += "0";
            label1.Text = aktszam;
        }

        private void t_vesszo_Click(object sender, EventArgs e)
        {
            aktszam += ",";
        }

        private void kiszamol_Click(object sender, EventArgs e)
        {
            label1.Text = aktszam;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
