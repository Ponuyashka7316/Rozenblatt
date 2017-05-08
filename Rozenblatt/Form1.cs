using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozenblatt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        double[,] myArr = new double[10, 7];
        int[] cbArr = new int[10];
        int[] cbArr2 = new int[10];
        double[] provMas = new double[7];
        int p;
        int t;
        int f;
        double[] rez1 = new double[10];
        double[] rez2 = new double[10];
        double minElement;
        double maxElement;
        double sredz;
        double final1;
        double final2;
        Random ran = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (p = 0; p < 10; p++)
            {
                rez1[p] = 0;
                rez1[p] = 0;
            }

            for (int j = 0; j < 7; j++)
            {
                double a = 0.1;
                double b = 0.9;
                provMas[j] = (b - a) * ran.NextDouble() + a;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    double a = 0.1;
                    double b = 0.9;
                    myArr[i, j] = (b - a) * ran.NextDouble() + a;
                }
            }

            for (p = 1; p < 10; p++)
            {
               
                    if ((this.Controls["cb" + p.ToString()] as CheckBox).Checked)
                        cbArr[p] = 1;
                    textBox1.Text += cbArr[p];
               
            }
            for (t = 1; t < 10; t++)
            {
               
                    if ((this.Controls["ch" + t.ToString()] as CheckBox).Checked)
                        cbArr2[t] = 1;
                    textBox2.Text += cbArr2[t];
               
            }

            for (p = 0; p < 10; p++)
            {
                rez1[p] += myArr[p, 1] * cbArr[1] + myArr[p, 2] * cbArr[2] + myArr[p, 3] * cbArr[3] + myArr[p, 4] * cbArr[4] + myArr[p, 5] * cbArr[5] + myArr[p, 6] * cbArr[6];
            }
            for (t = 0; t < 10; t++)
            {
                rez2[t] += myArr[t, 1] * cbArr2[1] + myArr[t, 2] * cbArr2[2] + myArr[t, 3] * cbArr2[3] + myArr[t, 4] * cbArr2[4] + myArr[t, 5] * cbArr2[5] + myArr[t, 6] * cbArr2[6];
            }

            a1.Text += " " + rez1[1].ToString("0.0");
            a2.Text += " " + rez1[2].ToString("0.0");
            a3.Text += " " + rez1[3].ToString("0.0");
            a4.Text += " " + rez1[4].ToString("0.0");
            a5.Text += " " + rez1[5].ToString("0.0");
            a6.Text += " " + rez1[6].ToString("0.0");

            o1.Text += " " + rez2[1].ToString("0.0");
            o2.Text += " " + rez2[2].ToString("0.0");
            o3.Text += " " + rez2[3].ToString("0.0");
            o4.Text += " " + rez2[4].ToString("0.0");
            o5.Text += " " + rez2[5].ToString("0.0");
            o6.Text += " " + rez2[6].ToString("0.0");

            minElement = rez1[1];
            for (int i = 0; i < 7; i++)
            {
                if (minElement > rez1[i])
                {
                    minElement = rez1[i];
                }
            }
            for (int i = 0; i < 7; i++)
            {
                if (maxElement < rez2[i])
                {
                    maxElement = rez2[i];
                }
            }

            sredz = (minElement + maxElement) / 2;
            sredn.Text += "" + sredz.ToString("0.0");
            min.Text += "" + minElement.ToString("0.0");
            max.Text += "" + maxElement.ToString("0.0");

            for (p = 0; p < 7; p++)
            {
                if (rez1[p] > sredz)
                    final1 += provMas[p];
                if (rez2[p] > sredz)
                    final2 += provMas[p];
            }

            lb1.Text += final1.ToString("0.0");
            lb2.Text += final2.ToString("0.0");




        }

        //public void Clear() {
        //    a1.Text = "Uвх. А1 =";
        //    a2.Text = "Uвх. А2 =";
        //    a3.Text = "Uвх. А3 =";
        //    a4.Text = "Uвх. А4 =";
        //    a5.Text = "Uвх. А5 =";
        //    a6.Text = "Uвх. А6 =";
        //    lb1.Text = "Uвх. R 1 = ";

        //    o1.Text = "Uвх. А1 =";
        //    o2.Text = "Uвх. А2 =";
        //    o3.Text = "Uвх. А3 =";
        //    o4.Text = "Uвх. А4 =";
        //    o5.Text = "Uвх. А5 =";
        //    o6.Text = "Uвх. А6 =";
        //    lb2.Text = "Uвх. R 2 = ";

        //    sredn.Text = "Среднее = ";
        //    min.Text = "Мин = ";
        //    max.Text = "Макс = ";

        //}
        private void Clear_Click(object sender, EventArgs e)
        {
            a1.Text = "Uвх. А1 =";
            a2.Text = "Uвх. А2 =";
            a3.Text = "Uвх. А3 =";
            a4.Text = "Uвх. А4 =";
            a5.Text = "Uвх. А5 =";
            a6.Text = "Uвх. А6 =";
            lb1.Text = "Uвх. R1 = ";

            o1.Text = "Uвх. А1 =";
            o2.Text = "Uвх. А2 =";
            o3.Text = "Uвх. А3 =";
            o4.Text = "Uвх. А4 =";
            o5.Text = "Uвх. А5 =";
            o6.Text = "Uвх. А6 =";
            lb2.Text = "Uвх. R2 = ";

            sredn.Text = "sredn = ";
            min.Text = "min = ";
            max.Text = "max = ";
            for (p = 1; p < 10; p++)
            {

                if ((this.Controls["cb" + p.ToString()] as CheckBox).Checked)
                    (this.Controls["cb" + p.ToString()] as CheckBox).Checked = false;

            }
            for (t = 1; t < 10; t++)
            {

                if ((this.Controls["ch" + t.ToString()] as CheckBox).Checked)
                    (this.Controls["ch" + t.ToString()] as CheckBox).Checked = false;

            }
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
