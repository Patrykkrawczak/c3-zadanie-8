using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            


            int z = int.Parse(z_box.Text);
            Random rnd = new Random();
            int d = 10;
            int l = 100000;
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = 0;
            single.X2 = Math.PI/2;
            single.Area = Math.Sin(single.X2) - Math.Sin(single.X1);
            bool czy1 = false;
            bool czy2 = false;
            for (double n = 100000.0F; n > 0  ; n -= Math.Max(n*0.1,10 ))
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0.0F;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += Math.Cos(i) * (i - old_i);

                    old_i = i;
                };
                if ((Math.Abs(single.Area - f)/ single.Area  >= z / 100.0 ) && !czy1)
                {

                    string wynik = "metoda prostokatów parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t\t";
                    wynik_box.Text += wynik;
                    czy1 = true;
                }
                f = 0.0F;

                old_i = 0.0F;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += ((Math.Cos(i) + Math.Cos(old_i)) / 2) * (i - old_i);

                    old_i = i;
                };
                if ((Math.Abs(single.Area - f)/ single.Area >= z / 100.0) && !czy2)
                {
                    double xxx = f;

                    string wynik =  "metoda trapezów parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t";
                    wynik_box.Text += wynik;
                    czy2 = true;
                }
                if (czy1 && czy2) 
                {
                    break;
                }
            };
        }
    }
}
