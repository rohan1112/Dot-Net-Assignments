//Create a class calculator and write 3 instance method square, cube, round[if in put 22.5 o / p 22]
//Which will return square .cube and rounded number.
//Create object and call method and print the result.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public void sqaure(int num)
        {
            Console.WriteLine(num * num);
        }

        public void cube(int num)
        {
            Console.WriteLine(num * num*num);
        }

        public void round(double num)
        {
            Console.WriteLine(Math.Round(num));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.sqaure(5);
            c.cube(5);
            c.round(22.5);
        }
    }
}
