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
        string aktszam = "0";
        string aktszam2 = "";
        double szam;
        bool vanevesszo = false;
        string muvelet = "";
        bool muvelet_vane = false;
        private void ketto_nhatvanya_Click(object sender, EventArgs e)
        {

            double megoldas = Math.Pow(2, Convert.ToDouble(aktszam));
            aktszam = Convert.ToString(megoldas);
            label1.Text = aktszam;
        }

        private void pi_Click(object sender, EventArgs e)
        {
            
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                double pi = Math.PI;
                szam = pi;
                aktszam = Convert.ToString(szam);
                label1.Text = aktszam;
                vanevesszo = true;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                double pi = Math.PI;
                szam = pi;
                aktszam2 = Convert.ToString(szam);
                label1.Text = aktszam2;
                vanevesszo = true;

            }
        }

        private void e_szam_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                double pi = Math.E;
                szam = pi;
                aktszam = Convert.ToString(szam);
                label1.Text = aktszam;
                vanevesszo = true;

            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                double pi = Math.E;
                szam = pi;
                aktszam2 = Convert.ToString(szam);
                label1.Text = aktszam2;
                vanevesszo = true;

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text = "0";
                aktszam = "0";
                aktszam2 = "";
                muvelet_vane = false;
                szam = 0;
                vanevesszo = false;
            }
            else 
            {
                aktszam = "";
                aktszam2 = "";
                muvelet_vane = false;
                szam = 0;
                vanevesszo = false;
            }

        }

        private void torles_Click(object sender, EventArgs e)
        {
            //el távolítja az utolsó számjegyet az aktuális számból
            try
            {
                aktszam = aktszam.Remove(aktszam.Length - 1);
                label1.Text = aktszam;
                if (label1.Text == "")
                {
                    aktszam = "0";
                    label1.Text = aktszam;
                    aktszam2 = "";

                }
            }
            catch
            {
                aktszam = "0";
                label1.Text = aktszam;

            }

        }

        private void negyzet_Click(object sender, EventArgs e)
        {
            try
            {
                double szamh = Convert.ToDouble(aktszam);

                szam = szamh * szamh;

                label1.Text = Convert.ToString(szam);
                aktszam = Convert.ToString(szam);
                //aktszam = "";
            }
            catch
            {

            }

        }

        private void reciprok_Click(object sender, EventArgs e)
        {
            try
            {
                if (aktszam != "0")
                {
                    double reciproka = 1 / Convert.ToDouble(aktszam);
                    aktszam = Convert.ToString(reciproka);
                    label1.Text = aktszam;
                }
                else
                {
                    label1.Text = "Nullával nem lehet osztani";
                }
                
            }
            catch
            {

            }
        }

        private void abs_Click(object sender, EventArgs e)
        {
            double absszam = Math.Abs(Convert.ToDouble(aktszam));
            aktszam = Convert.ToString(absszam);
            label1.Text = aktszam;
        }

        private void exp_Click(object sender, EventArgs e)
        {
            //nem kell
        }

        private void mod_Click(object sender, EventArgs e)
        {
            muvelet = "mod";
            muvelet_vane = true;
            vanevesszo = false;

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
            for (int i = 1; i < n + 1; i++)
            {
                megoldas *= i;
            }
            aktszam = Convert.ToString(megoldas);
            label1.Text = aktszam;
        }

        private void osztas_Click(object sender, EventArgs e)
        {
            muvelet = "/";
            muvelet_vane = true;
            vanevesszo = false;

        }

        private void x_y_hatvanyon_Click(object sender, EventArgs e)
        {
            muvelet = "XonY";
            muvelet_vane = true;
            vanevesszo = false;

            //?
        }

        private void het_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "7";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam2 += "7";
                label1.Text = aktszam2;
            }
        }

        private void nyolc_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "8";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam2 += "8";
                label1.Text = aktszam2;
            }
        }

        private void kilenc_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "9";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam2 += "9";
                label1.Text = aktszam2;
            }
        }

        private void szorzas_Click(object sender, EventArgs e)
        {
            muvelet = "*";
            muvelet_vane = true;
            vanevesszo = false;

        }

        private void tiz_x_hatvanyon_Click(object sender, EventArgs e)
        {
            double megoldas = Math.Pow(10, Convert.ToDouble(aktszam));
            aktszam = Convert.ToString(megoldas);
            label1.Text = aktszam;
        }

        private void negy_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "4";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam2 += "4";
                label1.Text = aktszam2;
            }
        }

        private void ot_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "5";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam2 += "5";
                label1.Text = aktszam2;
            }
        }

        private void hat_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "6";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam2 += "6";
                label1.Text = aktszam2;
            }
        }

        private void kivonas_Click(object sender, EventArgs e)
        {
            if (aktszam == "")
            {
                aktszam += "-";

            }
            else
            {
                muvelet = "-";
                vanevesszo = false;

                muvelet_vane = true;
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            muvelet = "log";
            muvelet_vane = true;
            vanevesszo = false;

        }

        private void egy_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "1";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam2 += "1";
                label1.Text = aktszam2;
            }
        }

        private void ketto_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "2";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam2 += "2";
                label1.Text = aktszam2;
            }
        }

        private void harom_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "3";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam2 += "3";
                label1.Text = aktszam2;
            }
        }

        private void osszeadas_Click(object sender, EventArgs e)
        {
            muvelet = "+";
            muvelet_vane = true;
            vanevesszo = false;
        }

        private void In_Click(object sender, EventArgs e)
        {
            double megoldas = Math.Log10(Convert.ToDouble(aktszam));
            aktszam = Convert.ToString(megoldas);
            label1.Text = aktszam;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //előjel csere
            try
            {
                if (!muvelet_vane)
                {
                    double megoldas = Convert.ToDouble(aktszam) * -1;
                    aktszam = Convert.ToString(megoldas);
                    label1.Text = aktszam;
                }
                else if (muvelet_vane)
                {
                    double megoldas = Convert.ToDouble(aktszam2) * -1;
                    aktszam2 = Convert.ToString(megoldas);
                    label1.Text = aktszam2;
                }
                
            }
            catch
            {
            }
        }

        private void nulla_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                    aktszam = "";
                }
                aktszam += "0";
                label1.Text = aktszam;
            }
            else if (muvelet_vane)
            {
                if (aktszam2.Length > 0)
                {
                    if (aktszam2[0] != '0')
                    {
                        aktszam2 += "0";

                    }
                }
                else 
                {
                    aktszam2 += "0";
                }
                label1.Text = aktszam2;
            }
        }

        private void t_vesszo_Click(object sender, EventArgs e)
        {
            if (!muvelet_vane)
            {
                if (vanevesszo == false)
                {
                    aktszam += ",";
                    vanevesszo = true;
                    label1.Text = aktszam;
                }

            }
            else if (muvelet_vane)
            {
                if (vanevesszo == false)
                {
                    aktszam2 += ",";
                    vanevesszo = true;
                    label1.Text = aktszam2;
                }
            }
        }

        private void kiszamol_Click(object sender, EventArgs e)
        {
            try
            {

                label1.Text = aktszam;
                MuveletElvegzese();
                muvelet_vane = false;
                aktszam2 = "";
                vanevesszo = false;
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void MuveletElvegzese()
        {
            if (muvelet == "+")
            {
                if (label1.Text == "0")
                {
                    aktszam = aktszam2;
                }
                else
                {
                    double a = Convert.ToDouble(aktszam);
                    double b = Convert.ToDouble(aktszam2);
                    aktszam = Convert.ToString(a + b);
                }
                label1.Text = aktszam;
            }
            else if (muvelet == "-")
            {
                double a = Convert.ToDouble(aktszam);
                double b = Convert.ToDouble(aktszam2);
                aktszam = Convert.ToString(a - b);
                label1.Text = aktszam;
            }
            else if (muvelet == "*")
            {
                double a = Convert.ToDouble(aktszam);
                double b = Convert.ToDouble(aktszam2);
                aktszam = Convert.ToString(a * b);
                label1.Text = aktszam;
            }
            else if (muvelet == "/")
            {
                double a = Convert.ToDouble(aktszam);
                double b = Convert.ToDouble(aktszam2);
                if (b == 0)
                {
                    label1.Text = "Nullával nem lehet osztani";
                }
                else
                {

                    aktszam = Convert.ToString(a / b); // b / a
                    label1.Text = aktszam;
                }
            }
            else if (muvelet == "XonY")
            {
                double a = Convert.ToDouble(aktszam);
                double b = Convert.ToDouble(aktszam2);
                aktszam = Convert.ToString(Math.Pow(a, b));
                label1.Text = aktszam;
            }
            else if (muvelet == "mod")
            {
                double a = Convert.ToDouble(aktszam);
                double b = Convert.ToDouble(aktszam2);
                aktszam = Convert.ToString(a % b);
                label1.Text = aktszam;
            }
            else if (muvelet == "log")
            {
                double a = Convert.ToDouble(aktszam);
                double b = Convert.ToDouble(aktszam2);
                aktszam = Convert.ToString(Math.Log(a, b));
                label1.Text = aktszam;
            }
            else if (aktszam == "0")
            {
                label1.Text = aktszam;
            }
            
        }
    }
}
