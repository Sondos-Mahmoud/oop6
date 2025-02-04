using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal class Math
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b; 
        public static double Divide(int a, int b)
        {
            return b != 0 ? (double)a / b : throw new DivideByZeroException("Cannot divide by zero.");
        }

        internal static decimal Min(int quantity, int v)
        {
            throw new NotImplementedException();
        }
    }
}
