// Create interface Irpository
//  List<Employee > display()
// void Add(Employee e)
// void remove(int id);
// Employee Getemp(int Id);
// List<Employee> Getemp(string Name);
// Void update(int id,string name);
// Create class EmployeeService which will implement all the above method, This class has member 
// Public static List<Employee> db=new List <Employee> ();
// Create Employee class with member Id, Name, Salary, Gender . Id should be autoincrement.
// Put employee class in folder Models
// Put Service and repository class in Folder Service

interface Irepository{
    List<Employee> display();
    void Add(Employee e);
    void Remove(Employee e);
    Employee getemp(int id);
    List<Employee> getemp(string name);
    void update(int id,string name);
}

class EmployeeService : Irepository
{
    public static List<Employee> db=new List<Employee>();
    public void Add(Employee e)
    {
        if(db.Count()==0){
            e.Id=1;
            db.Add(e);
        }else{
            e.Id=db.Max(emp=>emp.Id)+1;
            db.Add(e);
        }
    }

    public List<Employee> display()
    {
        return db.ToList();
    }

    public Employee getemp(int id)
    {
        Employee e= (Employee)(from emp in db where id == emp.Id select emp).FirstOrDefault();
        return e;
        throw new NotImplementedException();
    }

    public List<Employee> getemp(string name)
    {
        var e= from emp in db where emp.Name == name select emp;
        return e.ToList();
        throw new NotImplementedException();
    }

    public void Remove(Employee e)
    {
        db.Remove(e);
        throw new NotImplementedException();
    }

    public void update(int id, string name)
    {
        // update db  where emp.Id ==id 
        throw new NotImplementedException();
    }
}

class Employee{
    static int getId=0;
    int id;
    // int id;
    // string empName,gender;
    // double salary;
    public Employee(string empName,string gender,double salary){
        Name=empName;
        Salary=salary;
        Gender=gender;
        id=++getId;
    }

    public string Name{
        get;
        set;
    }
    public int Id{
        get;
        set;
    }
    public double Salary{
        get;
        set;
    }
    public string Gender{
        get;
        set;
    }

}

class program{
    static EmployeeService employeeService=new EmployeeService();
    static void Main(string[] args)
    {
        try{

        Employee e1=new Employee("Tejas","Male",1000);
        Employee e2=new Employee("Saurabh","Male",2000);
        Employee e3=new Employee("Pratik","Male",3000);
        Employee e4=new Employee("Tejas","Male",5000);
        employeeService.Add(e1);
        employeeService.Add(e2);
        employeeService.Add(e3);
        employeeService.Add(e4);

        var a=employeeService.display();
        foreach (var item in a)
        {
            System.Console.WriteLine($"Id:{item.Id} Name:{item.Name} Gender:{item.Gender} Salary:{item.Salary}");
        }

        var emp=employeeService.getemp(2);
            System.Console.WriteLine($"Id:{emp?.Id} Name:{emp?.Name} Gender:{emp?.Gender} Salary:{emp?.Salary}");
        
        var empbyName=employeeService.getemp("Tejas");
         foreach (var item in empbyName)
        {
            System.Console.WriteLine($"Id:{item.Id} Name:{item.Name} Gender:{item.Gender} Salary:{item.Salary}");
        }



        }catch(Exception e){System.Console.WriteLine(e.StackTrace);}
    }
}






