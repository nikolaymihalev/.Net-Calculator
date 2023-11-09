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
        double result = 0;
        string operationPerformed=string.Empty;
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();            
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0")||isOperationPerformed) 
            {
                resultBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            resultBox.Text += button.Text;
        }
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            result=double.Parse(resultBox.Text);
            labOperation.Text = $"{result} {operationPerformed}";
            isOperationPerformed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butDeleteCurrently_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
        }

        private void butDeleteAll_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            result = 0;
        }
    }
}