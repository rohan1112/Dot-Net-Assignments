using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Person
    {
        public virtual void display()
        {
            Console.WriteLine( "hello");
        }
    }

    class Employee: Person
    {
        public override void display()
        {
            Console.WriteLine("Hello Emp"); 
        }
    }

    class Manager : Employee
    {
        public override void display()
        {
            Console.WriteLine("Hello manager");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person();
           p.display();
            Employee e = new Employee();
            e.display();
            Manager manager = new Manager();
            manager.display();
        }
    }
}
