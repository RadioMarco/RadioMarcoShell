using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class Calculator
    {
        public static double RechenVerteiler(string[] calculation)
        {
            double result = 1.23;
            for (int i = 2; i < calculation.Length-1; i=+2)
            {
                
            }

            return result;
        }
        public static double Addition(double firstNumber,double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static double Substraction(double firstNumber,double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static double Multiplication(double firstNumber,double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public static double Division(double firstNumber,double secondNumber)
        {
            return firstNumber / secondNumber;
        }
        public static double Mod(double firstNumber,double secondNumber)
        {
            return firstNumber % secondNumber;
        }

    }
}
