using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorUtils
    {
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Multiplicate(decimal a, decimal b)
        {
            return a * b;
        }
        public static decimal Substract(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Divide(decimal a, decimal b)
        {
            if (b==0)
            {
                throw new ArgumentException("Cannot devide a number by 0");
            }
            return a / b;
        }
    }
}
