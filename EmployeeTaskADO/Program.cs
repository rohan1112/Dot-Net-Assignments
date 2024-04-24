using Microsoft.Extensions.Configuration;

namespace EmployeeTaskADO
{
    internal class Program
    {
        public static IConfiguration Iconfig;
        static EmployeeDAL e = null;
        static Random rnd = new Random();
        public static void buildConfiguration()
        {
            var build = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            Iconfig = build;
        }

        static void displayAllEmployees()
        {
            e.getEmployees();
        }

        static void SearchEmployeeById()
        {
            EmployeePOCO emp = e.Search(1);
            if (emp == null)
            {
                System.Console.WriteLine("Employee Not Found");
            }
            Console.WriteLine($"{emp.Id} {emp.Name} {emp.Salary}");
        }

        static void SearchEmployeeByName()
        {
            List<EmployeePOCO> emplist = e.Search("pqr");
            if (emplist.Count == 0)
            {
                System.Console.WriteLine("Employee Not Found");
            }
            emplist.ForEach(p => Console.WriteLine($"{p.Id} {p.Name} {p.Salary}"));
        }

        static void DeleteEmployee()
        {
            int deletedRows = e.deleteData(7);
            Console.WriteLine($"Deleted Rows are {deletedRows}");
        }

        static void updateEmployee()
        {
            EmployeePOCO updateEmp = new EmployeePOCO("Avinash", rnd.Next(10000,100000));
            int updatedRows = e.updateData(1, updateEmp);
            Console.WriteLine($"updated Rows are {updatedRows}");
            
        }
        static void Main(string[] args)
        {
            buildConfiguration();
            e = new EmployeeDAL(Iconfig);

            System.Console.WriteLine("************************************************************************************************");
            System.Console.WriteLine("Displaying All Employees");
            displayAllEmployees();
            System.Console.WriteLine("************************************************************************************************");

            System.Console.WriteLine("Searching Employee with Id of 1");
            SearchEmployeeById();
            System.Console.WriteLine("************************************************************************************************");


            System.Console.WriteLine("Searching Employee with Name of Pratik");
            SearchEmployeeByName();
            System.Console.WriteLine("************************************************************************************************");

            System.Console.WriteLine("Deleting Employee having Id 4");
            DeleteEmployee();
            System.Console.WriteLine("************************************************************************************************");
            System.Console.WriteLine("Updating Employee having Id 1");
            updateEmployee();
            System.Console.WriteLine("************************************************************************************************");
             System.Console.WriteLine("Displaying All Employees");
            displayAllEmployees();

        }
    }
}
