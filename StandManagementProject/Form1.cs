using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class Form1 : Form
    {
        string operation = "";
        decimal num1;
        decimal num2;
        decimal ans;
        public Form1()
        {
            ans = 0;
            
            num1 = 0;
            num2 = 0;
            InitializeComponent();
            textBox1.Text = "0";
        }
        private void Input(string a)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = a;
            }
            else
                textBox1.Text += a;
        }

        private void Btn_1_Click_1(object sender, EventArgs e)
        {
            Input("1");
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Input("2");
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Input("3");
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Input("4");
        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        private void Devis_to_Facture_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void Devis_to_Facture_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Devis_to_Facture_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void Btn_5_Click(object sender, EventArgs e)
        {
            Input("5");
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Input("6");
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Input("7");
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Input("8");
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Input("9");
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Input("0");
        }

        private void Btn_plus_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "+";
            textBox1.Text = "0";
        }

        private void Btn_minus_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "-";
            textBox1.Text = "0";
        }

        private void Btn_multiply_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "*";
            textBox1.Text = "0";
        }

        private void Btn_divide_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "/";
            textBox1.Text = "0";
        }

        private void Btn_equal_Click(object sender, EventArgs e)
        {
            num2 = Decimal.Parse(textBox1.Text);

            switch (operation) {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textBox1.Text = (num1 / num2).ToString();
                    break;
                case "%":
                    textBox1.Text = (num1 % num2).ToString();
                    break;
                case "^":
                    textBox1.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                    break;
                    
            }
            ans = Decimal.Parse(textBox1.Text);
            history_textBox.Text += num1.ToString() + operation + num2.ToString() + "=" + textBox1.Text +"\r\n";
            num2 = 0;
            num1 = 0;
           // textBox1.Text = "0";
            
        }

        private void Btn_sin_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Sin(temp)).ToString();
            ans = Decimal.Parse(textBox1.Text);
            history_textBox.Text += "Sin(" + temp.ToString() + ") = " + textBox1.Text +"\r\n";
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            else
                textBox1.Text = "0";
            //string temp = textBox1.Text;
            //int length = temp.Length - 1;
            //textBox1.Text = temp.Remove(0,length);
        }

        private void Ac_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
        }

        private void Ans_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = ans.ToString();
        }

        private void Dot_btn_Click(object sender, EventArgs e)
        {
            Input(",");
        }

        private void Btn_cos_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Cos(temp)).ToString();
            history_textBox.Text += "Cos(" + temp.ToString() + ") = " + textBox1.Text + "\r\n";
            ans = Decimal.Parse(textBox1.Text);
        }

        private void Tan_btn_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Tan(temp)).ToString();
            history_textBox.Text += "Tan(" + temp.ToString() + ") = " + textBox1.Text + "\r\n";
            ans = Decimal.Parse(textBox1.Text);
        }

        private void Log_btn_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Log10(temp)).ToString();
            history_textBox.Text += "Log(" + temp.ToString() + ") = " + textBox1.Text + "\r\n";
            ans = Decimal.Parse(textBox1.Text);
        }

        private void Btn_reciprocal_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            //temp = 1 / temp;
            textBox1.Text = (1/temp).ToString();
            history_textBox.Text += "1/" + temp.ToString() + " = " + textBox1.Text + "\r\n";
            ans = Decimal.Parse(textBox1.Text);
        }

        private void Factorial_btn_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            temp = Math.Floor(temp);
            double sum = 1.0;
            for (double i =1.0; i<=temp; i+=1.0)
            {
                sum *= i;
            }
            history_textBox.Text += textBox1.Text + "! = " + sum.ToString() + "\r\n";
            textBox1.Text = sum.ToString();
            ans = Decimal.Parse(textBox1.Text);
        }


      

        private void Btn_modulo_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "%";
            textBox1.Text = "0";
            ans = Decimal.Parse(textBox1.Text);
        }

        private void Btn_cube_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "^";
            textBox1.Text = "0";
            ans = Decimal.Parse(textBox1.Text);
        }

        private void Btn_plusminus_Click(object sender, EventArgs e)
        {
            decimal temp = decimal.Parse(textBox1.Text);
            temp = -temp;
            textBox1.Text = temp.ToString();
        }

        private void Tanh_btn_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Tanh(temp)).ToString();
            history_textBox.Text += "Tanh(" + temp.ToString() + ") = " + textBox1.Text + "\r\n";
            if (!Decimal.TryParse(textBox1.Text, out ans))
            {
                ans = 99999999999999;
            }
        }

        private void Cosh_btn_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Cosh(temp)).ToString();
            history_textBox.Text += "Cosh(" + temp.ToString() + ") = " + textBox1.Text + "\r\n";
            if (!Decimal.TryParse(textBox1.Text, out ans))
            {
                ans = 99999999999999;
            }
        }

        private void Sinh_btn_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Sinh(temp)).ToString();
            history_textBox.Text += "Sinh(" + temp.ToString() + ") = " + textBox1.Text + "\r\n";
            if(!Decimal.TryParse(textBox1.Text, out ans)){
                ans = 99999999999999;
            }
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            history_textBox.Clear();
        }
    }
}
