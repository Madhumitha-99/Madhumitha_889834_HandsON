using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a, b,result;

        private void add_CheckedChanged(object sender, EventArgs e)
        {
            if (new Regex("^[0-9]*$").IsMatch(Operand1.Text) && new Regex("^[0-9]*$").IsMatch(Operand2.Text))
            {
                a = float.Parse(Operand1.Text);
                b = float.Parse(Operand2.Text);
                result = a + b;
                MessageBox.Show("Result: " + result.ToString());
            }
            else
            {
                MessageBox.Show("Enter valid operands");
            }
        }
        private void subtract_CheckedChanged(object sender, EventArgs e)
        {
            if (new Regex("^[0-9]*$").IsMatch(Operand1.Text) && new Regex("^[0-9]*$").IsMatch(Operand2.Text))
            {
                a = float.Parse(Operand1.Text);
                b = float.Parse(Operand2.Text);
                result = a - b;
                MessageBox.Show("Result: " + result.ToString());
            }
            else
            {
                MessageBox.Show("Enter valid operands");
            }

        }
        private void multiply_CheckedChanged(object sender, EventArgs e)
        {
            if (new Regex("^[0-9]*$").IsMatch(Operand1.Text) && new Regex("^[0-9]*$").IsMatch(Operand2.Text))
            {
                a = float.Parse(Operand1.Text);
                b = float.Parse(Operand2.Text);
                result = a * b;
                MessageBox.Show("Result: " + result.ToString());
            }
            else
            {
                MessageBox.Show("Enter valid operands");
            }
        }
        private void divide_CheckedChanged(object sender, EventArgs e)
        {
            if (new Regex("^[0-9]*$").IsMatch(Operand1.Text) && new Regex("^[0-9]*$").IsMatch(Operand2.Text))
            {
                a = float.Parse(Operand1.Text);
                b = float.Parse(Operand2.Text);
                result = a / b;
                MessageBox.Show("Result: " + result.ToString());
            }
            else
            {
                MessageBox.Show("Enter valid operands");
            }

        }

        

        

        

       
    }
}
