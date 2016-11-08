using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SimpleCalculator
    {
        static void Main(string[] args)
        {
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public string String(string firstName,string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
