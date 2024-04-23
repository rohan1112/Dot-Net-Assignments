class PermanentEmp:Employee{
    static double EmpBonus=0.1;

    public PermanentEmp(string name,double salary):base(name,salary){
        
    }
    public override void Givebonus()
    {
        double salary=Salary*EmpBonus;
        Salary=Salary+salary;
        throw new NotImplementedException();
    }
}