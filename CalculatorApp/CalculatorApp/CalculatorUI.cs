using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }
        Calculator aCalculator = new Calculator();
        private void Add_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = aCalculator.AddTwoNumber(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = aCalculator.SubstractTwoNumber(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = aCalculator.MultiplyTwoNumber(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void Devide_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = aCalculator.DevideTwoNumber(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

    }
}
