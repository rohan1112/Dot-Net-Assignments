using Microsoft.Extensions.Configuration;

namespace EmployeeTaskADO
{
    internal class Program
    {
        public static IConfiguration Iconfig;

        public static void buildConfiguration()
        {
            var build= new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",optional:false, reloadOnChange: true).Build();
            Iconfig = build;
        }
        static void Main(string[] args)
        {
            buildConfiguration();
            EmployeeDAL e = new EmployeeDAL(Iconfig);
            e.getEmployees();
            EmployeePOCO emp = e.Search(1);
            Console.WriteLine($"{emp.Id} {emp.Name} {emp.Salary}");

            List<EmployeePOCO> emplist = e.Search("pqr");
            emplist.ForEach(p => Console.WriteLine($"{p.Id} {p.Name} {p.Salary}"));

            int deletedRows =e.deleteData(7);
            Console.WriteLine($"Deleted Rows are {deletedRows}");


            EmployeePOCO updateEmp = new EmployeePOCO("Avinash",2180);
            int updatedRows = e.updateData(1, updateEmp);
            Console.WriteLine($"updated Rows are {updatedRows}");
            e.getEmployees();



        }
    }
}
