using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator1
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operatori=" ";
        bool isoperatori = false;
        bool button38Clicked = false;
        bool button37Clicked=false;
        bool button33Clicked = false;
        
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            isoperatori = false;
            textBox1.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1.Text.Remove (textBox1.TextLength - 1,1).ToString();
           
        }

        private void operator_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            operatori = button.Text;
            value = double.Parse(textBox1.Text);
            isoperatori = true;
            
                textBox1.Text = " ";
                textBox2.Text = value + operatori;
            
            
           
            
         
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operatori)
            {
               case "+":  textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-": textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                    break;
                case "x": textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷": textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Sqrt(a)).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double a;
            if (button33Clicked == true)
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (1 / (Math.Sin(a))).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (1 / (Math.Sin(a))).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (1 / (Math.Sin(a))).ToString();
                }

            }
            else
            {

                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Sin(a)).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (Math.Sin(a)).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (Math.Sin(a)).ToString();
                }
            }
            

        }

        private void button26_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);
            textBox1.Text = (a / 100).ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double a;
            if (button33Clicked == true)
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (1 / (Math.Tan(a))).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (1 / (Math.Tan(a))).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (1 / (Math.Tan(a))).ToString();
                }
            }
            else
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Tan(a)).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (Math.Tan(a)).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (Math.Tan(a)).ToString();
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double a;
            if (button33Clicked == true)
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (1/(Math.Cos(a))).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (1/(Math.Cos(a))).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (1/(Math.Cos(a))).ToString();
                }
            }
            else
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Cos(a)).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (Math.Cos(a)).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (Math.Cos(a)).ToString();
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Log(a)).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Pow(10,a)).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double a;
            if (button33Clicked == true)
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (1/(Math.Cosh(a))).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (1/(Math.Cosh(a))).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (1/(Math.Cosh(a))).ToString();
                }
            }
            else
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Cosh(a)).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (Math.Cosh(a)).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (Math.Cosh(a)).ToString();
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Exp(a)).ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            
            double a;
            a = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Pow(a, 2)).ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33Clicked = true;
            if (true)
            {
                button25.Text = "sin-1";
                button28.Text = "cos-1";
                button30.Text = "sinh-1";
                button23.Text = "cosh-1";
                button29.Text = "tanh-1";
                button27.Text = "tan-1";
            }
            


        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a;
            int F = 1;
            a = int.Parse(textBox1.Text);
            for (int i = 1; i <= a; i++)
                F = F * i;
            textBox1.Text = (F).ToString();
            
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3,14159265359";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);
            textBox1.Text = ("-" + a).ToString();
           
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double a;
            if (button33Clicked == true)
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (1 / (Math.Tan(a))).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (1 / (Math.Tan(a))).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (1 / (Math.Tan(a))).ToString();
                }
            }
            else
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Sinh(a)).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (Math.Sinh(a)).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (Math.Sinh(a)).ToString();
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double a;
            if (button33Clicked == true)
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (1/(Math.Tanh(a))).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (1/(Math.Tanh(a))).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (1/(Math.Tanh(a))).ToString();
                }
            }
            

            else
            {
                if (button38Clicked == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Tanh(a)).ToString();
                }
                else if (button37Clicked == true)
                {
                    a = double.Parse(textBox1.Text) * 0.0174533;
                    textBox1.Text = (Math.Tanh(a)).ToString();
                }
                else
                {
                    a = double.Parse(textBox1.Text) * 1.11111;
                    textBox1.Text = (Math.Tanh(a)).ToString();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38Clicked = true;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37Clicked = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (true)
            {
                button25.Text = "sin";
                button28.Text = "cos";
                button30.Text = "sinh";
                button23.Text = "cosh";
                button29.Text = "tanh";
                button27.Text = "tan";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);
            textBox1.Text=(1/a).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
