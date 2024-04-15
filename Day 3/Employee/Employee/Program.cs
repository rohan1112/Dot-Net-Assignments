//3.Create class Employee having member Id, Name, Salary, NetSalary, Dept d
//Create enum Dept { MKT, ADMIN, ADV }
//Create method public double paytax(double p) { return tax amount and set netsalary(note: netsalary = salary - salary * p %)}
//Create method display to display name and netsalary and department
//When you load application it should print name of company.
//  new Employee(1,”Raj”, 50000, Dept.MKT)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    enum dept
    {
        MKT,
        ADV,
        ADMN
    }

    class Employee
    {
        int id;
        string name;
        double salary,netsalary,taxAmount;
        dept d;

        static Employee()
        {
            Console.WriteLine("Welcome To 901 pvt.ltd !!!!!!11");
        }
        public Employee(int id, string name, int salary, dept d)
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
            this.d = d;
        }

        public string getEmpDetails()
        {
            return string.Format("name={0} Net Salary= {1} Department={2}",name,netsalary,d); 
        }
        public double CalculateSal(double p)
        {
            netsalary = salary - salary * (p / (double)100);
            return netsalary;
        }
        public double paytax(double p) {
            CalculateSal(p);
            taxAmount = salary * (p / (double)100); 
            return taxAmount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Tejas", 3000, dept.ADMN);

            Console.WriteLine("Tax Amount= "+ e1.paytax(10));

            Console.WriteLine(e1.getEmpDetails());


        }
    }
}
