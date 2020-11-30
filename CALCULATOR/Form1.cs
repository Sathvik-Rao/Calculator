using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string a = string.Empty;
        string b = string.Empty;
        char ch;
      //  string s=string.Empty;
        double ans = 0.0;
        double num1 = 0.0;
        double num2 = 0.0;
        double pi = 3.14159265358979323846264338327950288419716939937510582097494459230781;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";//creates gap
            input += "5";//insert element
            this.textBox1.Text += input;//displays on the screen
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "+";
            a = input;
            ch = '+';
            input = string.Empty;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.a = string.Empty;
            this.b = string.Empty;
                       
        }

        private void sub_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "-";
            a = input;
            ch = '-';
            input = string.Empty;

        }

        private void mult_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "*";
            a = input;
            ch = '*';
            input = string.Empty;
        }

        private void div_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "/";
            a = input;
            ch = '/';
            input = string.Empty;

        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch =='p')
            {
                b = input;
                input = string.Empty;
                double.TryParse(a, out num1);//converts string to double
                double.TryParse(b, out num2);
                if (ch == '+')
                {
                    ans = num1 + num2;
                    textBox1.Text = ans.ToString();
                    
                }
                else if (ch == '-')
                {
                    ans = num1 - num2;
                    textBox1.Text = ans.ToString();
                }
                else if (ch == '*')
                {
                    ans = num1 * num2;
                    textBox1.Text = ans.ToString();
                }
                else if (ch == '/')
                {
                    if (num2 != 0)
                    {
                        ans = num1 / num2;
                        textBox1.Text = ans.ToString();
                    }
                    else
                    {
                        textBox1.Text = "DIV/ZERO!!!";
                    }
                }
                else if (ch=='p')
                {
                    ans = Math.Pow(num1, num2);
                    textBox1.Text = ans.ToString();
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sin_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);
            num1 = (num1 * pi) / (180);//radian value
            ans = Math.Sin(num1);
            textBox1.Text = ans.ToString();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);
            num1 = (num1 * pi) / (180);//radian value
            ans = Math.Cos(num1);
            textBox1.Text = ans.ToString();
        }

        private void tan_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);
            num1 = (num1 * pi) / (180);//radian value
            ans = Math.Tan(num1);
            textBox1.Text = ans.ToString();

        }

        private void sqroot_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);//converts string to double
            if (num1 >= 0)
            {
                ans = Math.Sqrt(num1);
                textBox1.Text = ans.ToString();
            }
            else if(num1<0)
            {
                num1 = Math.Abs(num1);
                ans = Math.Sqrt(num1);
                textBox1.Text = ans.ToString("i*0.000000000000000");
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);//converts string to double
            ans = Math.Log10(num1);
            textBox1.Text = ans.ToString();
        }

        private void pow_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "power";
            a = input;
            ch = 'p';
            input = string.Empty;
        }

        private void exp_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);//converts string to double
            ans = Math.Exp(num1);
            textBox1.Text = ans.ToString();
        }

        private void fact_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);//converts string to double
            if (num1 > 0)
            {
                long f = 1;
                while (num1 >= 1)
                {
                    f = f * (long)num1;
                    num1 = num1 - 1;
                }
                ans = f;
                textBox1.Text = ans.ToString();
            }
            else if (num1 == 0)
            {
                this.textBox1.Text = "1";
            }
            else if (num1 < 0)
            {
                this.textBox1.Text = "Error!";
            }
        }

        private void ctof_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);//converts string to double
            ans = (((num1) * (1.8)) + 32);
            textBox1.Text = ans.ToString();
        }

        private void ftoc_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);//converts string to double
            ans = (((num1) - 32) / 1.8);
            textBox1.Text = ans.ToString();

        }

        private void ctok_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);//converts string to double
            ans = (num1 + 273.15);
            textBox1.Text = ans.ToString();

        }

        private void ktoc_Click(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);//converts string to double
            ans = (num1 - 273.15);
            textBox1.Text = ans.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input = input + "-";
            this.textBox1.Text += input;
        }

        private void log_Click_1(object sender, EventArgs e)
        {
            a = input;
            double.TryParse(a, out num1);//converts string to double
            ans = Math.Log(num1);
            textBox1.Text = ans.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            if (input.Length>0)
            {

                input = input.Remove(input.Length - 1);
            }
                this.textBox1.Text += input;
        }

        private void answer_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Ans";
            input += ans;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
