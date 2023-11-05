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
            Count(8);
        }

        private void numb7_Click(object sender, EventArgs e)
        {
            AddToText("7");
            Count(7);
        }

        private void numb4_Click(object sender, EventArgs e)
        {
            AddToText("4");
            Count(4);
        }

        private void numb5_Click(object sender, EventArgs e)
        {
            AddToText("5");
            Count(5);
        }

        private void numb6_Click(object sender, EventArgs e)
        {
            AddToText("6");
            Count(6);
        }

        private void numb9_Click(object sender, EventArgs e)
        {
            AddToText("9");
            Count(9);
        }

        private void numbDivis_Click(object sender, EventArgs e)
        {
            AddToText("/");
            sign = "/";
        }

        private void butRemoSym_Click(object sender, EventArgs e)
        {

        }

        private void butMultiple_Click(object sender, EventArgs e)
        {
            AddToText("*");
            sign = "*";
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            AddToText("-");
            sign = "-";
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            AddToText("+");
            sign = "+";
        }

        private void numb3_Click(object sender, EventArgs e)
        {
            AddToText("3");
            Count(3);
        }

        private void num2_Click(object sender, EventArgs e)
        {
            AddToText("2");
            Count(2);
        }

        private void num1_Click(object sender, EventArgs e)
        {
            AddToText("1");
            Count(1);
        }

        private void butProcent_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToText("0");
            Count(0);
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

        void Count(int number)
        {
            if (result == 0)
            {
                result = number;
            }
            else 
            {
                if (sign != string.Empty) 
                {
                    switch (sign) 
                    {
                        case "+":result += number; break;
                        case "-":result -= number; break;
                        case "*":result *= number; break;
                        case "/":result /= number; break;
                    }
                }
            }
        }
    }
}