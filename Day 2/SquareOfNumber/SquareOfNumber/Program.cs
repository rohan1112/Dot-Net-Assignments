//Q2.Accept a float value and print square of that number
//Solve above code using Parse(), ToSingle() and TryPrase() method.
//Also observe exception if you do not enter valid data



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String num1 = Console.ReadLine();
            String num2 = Console.ReadLine();
            float a, b;

            try
            {

            a=float.Parse(num1);
            b=float.Parse(num2);
            Console.WriteLine("Sum is : " + (a + b));
            }catch(Exception e) { Console.WriteLine(e.StackTrace); }

           
            Console.WriteLine("*********************************************************************************");
            try
            {
            a = Convert.ToSingle(num1);
            b = Convert.ToSingle(num2);
            Console.WriteLine("Sum is : " + (a + b));
            }catch( Exception e) { Console.WriteLine(e.ToString()); }

            Console.WriteLine("*********************************************************************************");
            bool a1 = float.TryParse(num2, out a);
            bool b1 = float.TryParse(num1, out b);

            if (a1 == true && b1 == true)
            {
                Console.WriteLine("Sum is : " + (a + b));
            }
            else
            {
                Console.WriteLine("Not valid number");
            }


            Console.ReadLine();
        }
    }
}
