class TempEmp:Employee{
    static double EmpBonus=0.5;

    public TempEmp(string name,double salary):base(name,salary){
        
    }
    public override void Givebonus()
    {
        double salary=Salary*EmpBonus;
        Salary=Salary+salary;
        throw new NotImplementedException();
    }
}