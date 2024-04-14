//Create enum dep having value[MKT = 1, ADV = 2, ADMN = 3]
//Create a class Employee with instance member id, name, salary and enum dept d.
//Create 5 object of class Employee and put them into different department.
//Write a  sataic method which will display department wise total salary paid

//E.g.
//1, "Raj", 3000, dep.ADMN
//2, "Reena", 2000, dep.ADMN
// 3, "Geeta", 1000, dep.MKT

//O/p ADMN department spend 5000 on salary
//MKT department spend 1000 on salary



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
        int id, salary;
        string name;
        dept d;

        public Employee(int id, string name, int salary, dept d)
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
            this.d=d;
        }

        public static int getEmpDetails(Employee[] Earr,dept d)
        {
            int TotalSalary = 0;
            for (int i = 0; i<Earr.Length; i++){
                if (Earr[i].d == d)
                {
                    Console.WriteLine(string.Format("id={0}  name={1}  Salary={2}  Dept={3}",Earr[i].id, Earr[i].name, Earr[i].salary,d));
                    
                    TotalSalary = TotalSalary + Earr[i].salary;
                }
            }
            return TotalSalary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Tejas", 3000, dept.ADMN);
            Employee e2 = new Employee(2, "Pratik", 2000, dept.ADV);
            Employee e3 = new Employee(3, "Saurabh", 4000, dept.MKT);
            Employee e4 = new Employee(4, "Yash", 2000, dept.ADMN);
            Employee e5 = new Employee(5, "Sameer", 5000, dept.ADV);

            

            Employee[] Earr = { e1, e2, e3, e4, e5 };

            Console.WriteLine("Employees in Administritive Department");
            int totalSalary=Employee.getEmpDetails(Earr,dept.ADMN);
            Console.WriteLine(string.Format("Department {0} spend on {1}\n ", dept.ADMN, totalSalary));
            Console.WriteLine("Employees in Advocative Department");
            totalSalary=Employee.getEmpDetails(Earr,dept.ADV);
            Console.WriteLine(string.Format("Department {0} spend on {1}\n ", dept.ADV, totalSalary));
            Console.WriteLine("Employees in Marketing Department");
            totalSalary=Employee.getEmpDetails(Earr,dept.MKT);
            Console.WriteLine(string.Format("Department {0} spend on {1} ", dept.MKT, totalSalary));
        }
      }
}
