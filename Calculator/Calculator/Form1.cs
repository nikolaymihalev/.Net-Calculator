using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int result = 0;
        string sign = string.Empty;

        public Form1()
        {
            InitializeComponent();            
        }

        private void butDeleteCurrently_Click(object sender, EventArgs e)
        {

        }

        private void butDeleteAll_Click(object sender, EventArgs e)
        {

        }

        private void numb8_Click(object sender, EventArgs e)
        {
            AddToText("8");
            if (result == 0)
            {
                result = 8;
            }
            else 
            {
                if (sign != string.Empty) 
                {
                    switch (sign) 
                    {
                        case "+":result += 8; break;
                        case "-":result -= 8; break;
                        case "*":result *= 8; break;
                        case "/":result /= 8; break;
                    }
                }
            }
        }

        private void numb7_Click(object sender, EventArgs e)
        {
            AddToText("7");
            if (result == 0)
            {
                result = 7;
            }
        }

        private void numb4_Click(object sender, EventArgs e)
        {
            AddToText("4");
            if (result == 0)
            {
                result = 4;
            }
        }

        private void numb5_Click(object sender, EventArgs e)
        {
            AddToText("5");
            if (result == 0)
            {
                result = 5;
            }
        }

        private void numb6_Click(object sender, EventArgs e)
        {
            AddToText("6");
            if (result == 0)
            {
                result = 6;
            }
        }

        private void numb9_Click(object sender, EventArgs e)
        {
            AddToText("9");
            if (result == 0)
            {
                result = 9;
            }
        }

        private void numbDivis_Click(object sender, EventArgs e)
        {
            AddToText("/");
        }

        private void butRemoSym_Click(object sender, EventArgs e)
        {

        }

        private void butMultiple_Click(object sender, EventArgs e)
        {
            AddToText("*");
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            AddToText("-");
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            AddToText("+");
            sign = "+";
        }

        private void numb3_Click(object sender, EventArgs e)
        {
            AddToText("3");
            if (result == 0)
            {
                result = 2;
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            AddToText("2");
            if (result == 0)
            {
                result = 2;
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            AddToText("1");
            if (result == 0)
            {
                result = 1;
            }
        }

        private void butProcent_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToText("0");
        }

        private void butKoma_Click(object sender, EventArgs e)
        {
            AddToText(",");
        }

        private void butEqual_Click(object sender, EventArgs e)
        {                        
            expressionBox.Text = result.ToString();
        }

        void AddToText(string text) 
        {
            expressionBox.Text += text;

        }
    }
}