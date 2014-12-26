using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
     
        public double AddTwoNumber(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double SubstractTwoNumber(double firstNumber, double secondNumber)
        {
           return firstNumber - secondNumber;
        }

        public double MultiplyTwoNumber(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double DevideTwoNumber(double firstNumber, double secondNumber)
        {
            return  firstNumber/secondNumber;
        }
    }
}
