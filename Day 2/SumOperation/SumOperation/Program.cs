//Q1.Accept two number from user and do the sum of it



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String num1=Console.ReadLine();
            String num2=Console.ReadLine();
            int a, b;

            a = Convert.ToInt32(num1);
            b= Convert.ToInt32(num2);

            Console.WriteLine("Sum is : "+ (a+b));
            Console.ReadLine();
        }
    }
}
