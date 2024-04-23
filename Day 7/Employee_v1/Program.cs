// Create abstract class Employee having member id, name, salary, netsalary
// It has method givebasic_salary which will set netsalary after deduction 10%TDS
//  it has abstract method givebonus
// Id should be autoincrement and should be readonly property
// Write getter setter for name and salary
// Salary can be set only by child class
// Create two child class permanentEmp and tempEmp
// permanentEmp get bonus of 10%[ declare this as static veriable ]
// const maxsalay=150000.
// Ensure that you are not paying more then 150000 to any employee
// Bonus for tempEmp is 5% of the basic salary.
// When you load application it should print name of company
// When you give salary it should give SMS and Email to the employee.
// Crate Array of Employee and store all child class object.

using System.Net.Mail;

delegate void SalaryEvent(Object obj);
abstract class Employee{
    int id;
    static int getid=0;
    string name;
    double salary;
    double netsalary;
    const double TDS=0.1;
    const double MaxSalary=10000;
    public static event SalaryEvent sendSMSorMail; 

    public Employee(string name,double salary){
        Name=name;
        Salary=salary;
        id=++getid;
    }
    static Employee(){
        System.Console.WriteLine("WelCome to 901 pvt ltd.!!!!!!!!");
    }
    public string Name{
        get{return name;}
        set{
            name=value;
        }
    }

    public double Salary{
         get{return salary;}
        protected set{
            if(value>150000){
                throw new Exception("Salary cannot be more than 150000");
            }
            else{
                salary=value;
                
                if(sendSMSorMail!=null){
                    sendSMSorMail(this);
                }
            }
        }
    }

    public double Givebasic_salary(){
        netsalary=Salary-(salary*TDS);
        return netsalary;
    }
    public abstract void Givebonus();
}

class Sms{
    public void sendSMS(Object obj){
        Employee e=obj as Employee;
        if(e!=null){
            System.Console.WriteLine(string.Format("SMS:Salary {0:C} Credited Sucessfully to {1}",e.Salary,e.Name));
        }
    }
}

class Email{
    public void sendMail(Object obj){
         Employee e=obj as Employee;
        if(e!=null){
            System.Console.WriteLine(string.Format("Mail:Salary {0:C} Credited Sucessfully to {1}",e.Salary,e.Name));
        }
    }
}
class Program{
    static void Main(string[] args)
    {
        Sms sms=new Sms();
        Email mail=new Email();
        
        Employee.sendSMSorMail+=sms.sendSMS;
        Employee.sendSMSorMail+=mail.sendMail;

        Employee[] EmpArr=new Employee[5];
        EmpArr[0]=new PermanentEmp("Tejas",25000);
        EmpArr[1]=new TempEmp("Pratik",15000);
        EmpArr[2]=new PermanentEmp("Yash",20000);
        EmpArr[3]=new TempEmp("Akshay",16000);
        EmpArr[4]=new PermanentEmp("Sameer",26000);
        
    }
}


