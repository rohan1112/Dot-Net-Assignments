using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskADO
{
    internal class EmployeePOCO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public EmployeePOCO(string name, float salary)
        {
            Name = name;
            Salary = salary;
        }
        public EmployeePOCO() { }

    }
}
