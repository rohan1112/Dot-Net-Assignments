//Create class Employee with private vatiable id name salary, netsalary
//Create method public double Calculatesal()
//Which will return net salary. Netsalary= salary-salary*10%
//Create method display which will display Name and net salary.
//Create 3 object of a class and call display method.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee2
{
    class Employee
    {
        int id;
        double salary, netsalary;
        string name;

        public Employee(int id,string name, double salary)
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
        }

        public double CalculateSal()
        {
            netsalary = salary - salary * (10 /(double) 100);
            return netsalary;
        }

        public string DisplayDetails()
        {
            return string.Format("Name={0} NetSalary={1}",name, CalculateSal());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Pravin", 25000);
            Employee e2 = new Employee(1, "Akshay", 30000);
            Employee e3 = new Employee(1, "Sharukh", 28000);
            Console.WriteLine("Net Salary: "+ e1.CalculateSal());
            Console.WriteLine(e1.DisplayDetails());
            Console.WriteLine(e2.DisplayDetails());
            Console.WriteLine(e3.DisplayDetails());
            Console.ReadLine();
        }
    }
}
