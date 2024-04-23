// Create class employee with member Id , EmpName salary and DetId
// Create class Department with member DetId  DeptName[ADV, HR, ADMIN]
// Create array of each class and store 6 object
// Write query and display EmpName and name of Department

class Employee{
    int id;
    public string empName;
    double salary;
    public int deptid;

    public Employee(int id,string empName,double salary,int deptid){
        this.id=id;
        this.empName=empName;
        this.salary=salary;
        this.deptid=deptid;
    }

}

public enum dept{
        ADV,HR,ADMIN
    }

class Department{
    public int deptid;
    public dept deptName;
    

    public Department(int deptid,dept d){
        this.deptid=deptid;
        this.deptName=d;
    }
}

public class Program{
    static void Main(string[] args)
    {
        Employee e1=new Employee(1,"Tejas",5000,1);
        Employee e2=new Employee(2,"Saurabh",6000,2);
        Employee e3=new Employee(3,"Yash",7000,3);
        Employee e4=new Employee(4,"Pratik",8000,1);
        Employee e5=new Employee(5,"Sameer",9000,2);
        Employee e6=new Employee(6,"Rohan",3000,3);

        Department d1=new Department(1,dept.ADV);
        Department d2=new Department(2,dept.HR);
        Department d3=new Department(3,dept.ADMIN);
        // Department d4=new Department(1,dept.ADV);
        // Department d5=new Department(2,dept.HR);
        // Department d6=new Department(3,dept.ADMIN);

        Employee[] empArr=new Employee[6]{e1,e2,e3,e4,e5,e6};
        Department[] deptArr=new Department[3]{d1,d2,d3};

        //Rythmic Method
        System.Console.WriteLine("******************************************");
        System.Console.WriteLine("Using Rythmic Method ");
        System.Console.WriteLine("******************************************");
        var res=from e in empArr join d in deptArr on e.deptid equals d.deptid  select new{Name=e.empName ,Department=d.deptName} ;
        foreach (var item in res)
        {
            System.Console.WriteLine(item);
        }

        //Extension Method
        System.Console.WriteLine("******************************************");
        System.Console.WriteLine("Using Extension Method ");
        System.Console.WriteLine("******************************************");
        var result=empArr.Join(deptArr,e=>e.deptid,d=>d.deptid,(e,d)=>new {Name=e.empName,Department=d.deptName});
        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }
    }
}


