using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringEconomy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonProfit_Click(object sender, EventArgs e)
        {
            try
            {
                double cf = double.Parse(textBox1CF.Text);
                double cv = double.Parse(textBox2CV.Text);
                double a = double.Parse(textBox3a.Text);
                double b = double.Parse(textBox4b.Text);

                double d = 0.0;
                d = ((a - cv) / (2 * b));
                textBox6D.Text = d.ToString();
                double profit = 0.0;
                profit = (-b * Math.Pow(d, 2)) + (a - cv) * d - cf;
                textBox5Profit.Text = profit.ToString();

                double demandnegative = 0.0;
                double demandpositive = 0.0;
                double sqrt = Math.Pow((a - cv), 2) - 4 * (-b) * (-cf);
                demandnegative = (-(a - cv) - Math.Sqrt(sqrt)) / (2 * -b);
                textBox7DemandNegative.Text = demandnegative.ToString();
                demandpositive = (-(a - cv) + Math.Sqrt(sqrt)) / (2 * -b);
                textBox8DemandPositive.Text = demandpositive.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Sayilarda Hata Var!");
            }

        }
        private void buttonCost_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1a.Text);
                double X = double.Parse(textBox2X.Text);
                double b = double.Parse(textBox3b.Text);
                double k = double.Parse(textBox4k.Text);

                double cost = a * X + b / X + k;
                textBox5Cost.Text = cost.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Sayilarda Hata Var!");
            }

        }
        private void buttonCN_Click(object sender, EventArgs e)
        {
            try
            {
                double ck = double.Parse(textBox1Ck.Text);
                double In = double.Parse(textBox2In.Text);
                double Ik = double.Parse(textBox3Ik.Text);

                double cn = ck * (In / Ik);
                textBox4Cn.Text = cn.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Sayilarda Hata Var!");
            }

        }
        private void buttonCK_Click(object sender, EventArgs e)
        {
            try
            {
                double cn = double.Parse(textBox4Cn.Text);
                double In = double.Parse(textBox2In.Text);
                double Ik = double.Parse(textBox3Ik.Text);

                double ck = cn / (In / Ik);
                textBox1Ck.Text = ck.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Sayilarda Hata Var!");
            }
        }
        private void buttonCB_Click(object sender, EventArgs e)
        {
            try
            {
                double cost = double.Parse(textBox6Cost.Text);
                double sa = double.Parse(textBox3SA.Text);
                double sb = double.Parse(textBox4SB.Text);

                double cb = cost * (sa / sb);
                textBox2CB.Text = cb.ToString();
                MessageBox.Show("CB Hesaplandi SA ve SB sayilarini degistir!");
            }
            catch (Exception)
            {

                MessageBox.Show("Sayilarda Hata Var Once CB Hesaplanmali!");
            }

        }
        private void buttonCA_Click(object sender, EventArgs e)
        {
            try
            {
                double cb = double.Parse(textBox2CB.Text);
                double sa = double.Parse(textBox3SA.Text);
                double sb = double.Parse(textBox4SB.Text);
                double x = double.Parse(textBox5X.Text);

                double ca = cb * (Math.Pow((sa / sb), x));
                textBox1CA.Text = ca.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Sayilarda Hata Var Once CB Hesaplanmali!");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double F = 0.0;
                if (textBox6P.Text != "" && textBox1i.Text != "" && textBox2N.Text != "")
                {
                    double P = double.Parse(textBox6P.Text);
                    double i = double.Parse(textBox1i.Text);
                    double N = double.Parse(textBox2N.Text);
                    double point = 1 + (i / 100);
                    double pointlast = Math.Pow(point, N);
                    F = P * Math.Pow(point, N);
                    textBox5F.Text = F.ToString();
                    MessageBox.Show($"F = ${textBox6P.Text}(F/P,{textBox1i.Text}%,{textBox2N.Text}) = ${textBox6P.Text}({pointlast.ToString()}) = ${F.ToString()}");
                }
                else
                    MessageBox.Show("Sayilarda Hata Var!");
            }
            catch (Exception)
            {
                MessageBox.Show("Sayilarda Hata Var!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double P = 0.0;
                if (textBox5F.Text != "" && textBox1i.Text != "" && textBox2N.Text != "")
                {
                    double F = double.Parse(textBox5F.Text);
                    double i = double.Parse(textBox1i.Text);
                    double N = double.Parse(textBox2N.Text);
                    double point = 1 + (i / 100);
                    double pointlast = Math.Pow(point, -N);
                    P = F * Math.Pow(point, -N);
                    textBox6P.Text = P.ToString();
                    MessageBox.Show($"F = ${textBox5F.Text}(P/F,{textBox1i.Text}%,{textBox2N.Text}) = ${textBox5F.Text}({pointlast.ToString()}) = ${P.ToString()}");
                }
                else
                    MessageBox.Show("Sayilarda Hata Var!");
            }
            catch (Exception)
            {
                MessageBox.Show("Sayilarda Hata Var!");
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            double F = 0.0;
            double A = double.Parse(textBox7A.Text);
            double i = double.Parse(textBox1i.Text);
            double N = double.Parse(textBox2N.Text);

            double point = 1 + (i / 100);
            double pointlast = Math.Pow(point, N);

            double dividing = pointlast - 1;
            double divided = i / 100;
            F = A * (dividing / divided);
            textBox5F.Text = F.ToString();

            MessageBox.Show($"F = ${textBox7A.Text}(F/A,{textBox1i.Text}%,{textBox2N.Text}) = ${textBox7A.Text}({(dividing / divided).ToString()}) = ${F.ToString()}");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double P = 0.0;
            double A = double.Parse(textBox7A.Text);
            double i = double.Parse(textBox1i.Text);
            double N = double.Parse(textBox2N.Text);

            double point = 1 + (i / 100);
            double pointlast = Math.Pow(point, N);

            double dividing = pointlast - 1;
            double divided = (i / 100) * pointlast;
            P = A * (dividing / divided);
            textBox6P.Text = P.ToString();

            MessageBox.Show($"P = ${textBox7A.Text}(P/A,{textBox1i.Text}%,{textBox2N.Text}) = ${textBox7A.Text}({(dividing / divided).ToString()}) = ${P.ToString()}");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double A = 0.0;
            double F = double.Parse(textBox5F.Text);
            double i = double.Parse(textBox1i.Text);
            double N = double.Parse(textBox2N.Text);

            double point = 1 + (i / 100);
            double pointlast = Math.Pow(point, N);

            double dividing = pointlast - 1;
            double divided = i / 100;
            A = F * (divided / dividing);
            textBox7A.Text = A.ToString();

            MessageBox.Show($"A = ${textBox5F.Text}(A/F,{textBox1i.Text}%,{textBox2N.Text}) = ${textBox5F.Text}({(divided / dividing).ToString()}) = ${A.ToString()}");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            double A = 0.0;
            double P = double.Parse(textBox6P.Text);
            double i = double.Parse(textBox1i.Text);
            double N = double.Parse(textBox2N.Text);

            double pointdividing = 1 + (i / 100);
            double pointdividinglast = (i / 100) * Math.Pow(pointdividing, N);

            double dividing = pointdividinglast;

            double pointdivided = 1 + (i / 100);
            double pointdividedlast = Math.Pow(pointdivided, N) - 1;

            double divided = pointdividedlast;

            A = P * (dividing / divided);

            MessageBox.Show($"A = ${textBox6P.Text}(A/P,{textBox1i.Text}%,{textBox2N.Text}) = ${textBox6P.Text}({(divided / dividing).ToString()}) = ${A.ToString()}");
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {
            double P = 0.0;
            double P0 = 0.0;
            double A = double.Parse(textBox7A.Text);
            double i = double.Parse(textBox1i.Text);
            double N = double.Parse(textBox2N.Text);

            double point = 1 + (i / 100);
            double pointlast = Math.Pow(point, N);

            double dividing = pointlast - 1;
            double divided = (i / 100) * pointlast;
            P = A * (dividing / divided);

            

            double J = double.Parse(textBox2N.Text);
            double point1 = 1 + (i / 100);
            double pointlast1 = Math.Pow(point1, -J);
            P0 = P * pointlast1;

            MessageBox.Show($"P = ${textBox7A.Text}(P/A,{textBox1i.Text}%,{textBox2N.Text}) = ${textBox7A.Text}({(dividing / divided).ToString()}) = ${P.ToString()}");
            MessageBox.Show($"P0 = ${P}(P/F,{textBox1i.Text}%,{textBox2N.Text}) = ${textBox5F.Text}({pointlast1.ToString()}) = ${P0.ToString()}");
            //MessageBox.Show($"P0 = {A.ToString()} x (P/A,{i.ToString()}%,{N.ToString()})(P/F,{i.ToString()}%,{J.ToString()}) = {(P * pointlast1).ToString()}");
            //MessageBox.Show($"P0 = {A.ToString()} x {pointlast.ToString()} x {pointlast1.ToString()} = {(P * pointlast1).ToString()}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double PW = double.Parse(textBox1PW.Text);
            double P = double.Parse(textBox6P.Text);
            MessageBox.Show("PW: " + (PW - P).ToString());
        }
    }
}
