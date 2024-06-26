﻿// Create Account class having instance member 
// 1. id- id should be generated by application, it is readonly property
// 2. name – write getter setter (minimum length=3 max=15)
// 3. balance- Write getter setter 
// It has deposit method who’s job is to increase the balance.
// Declare static float Interestrate=0.07.
// It has withdraw method who’s job is to reduce balance.
// Declare conts float minbal=1000. When user withdraw money your application should ensure that minimum balance is maintain. 
// Give appropriate validation like user can not deposit or withdraw 0 or negative. user can not open account with 0 amount
// When you run your application at the beginning it should print name of bank and copy right detail.
// It has static method which will calculate and return  interest amount for each account holder and increase the balance.
// Write display method who’s job is to display Id name and balance and interest received.
// If you are comfortable the exception try to use it and handle it also.
// Your application should allow you to create only 3 object


class Account{
    int id;
    string name;
    double balance;
    static int count=0;
    const float minBalance = 1000F;
    static float InterestRate=0.07F;
     float interest;

    static Account(){
        Console.WriteLine("Welcome to 901 Gringotts Bank @2024");
    }
 public Account(string name, double balance)
 {
     if(count>2){
            throw new Exception("No space for additional account");
    }
     if(balance < minBalance)
     {
         throw new Exception("Balance must be greater than 1000");
     }
     else
     {
        id= ++count;
        Name=name;
        Balance= balance;
     }
 }

 static float CalcInterestAmount(Account obj){
    obj.interest= (float)obj.balance*InterestRate;
    obj.Depoist(obj.interest);
    return obj.interest;
 }

 public void Withdraw(float amt)
 {
     if (amt >0 && amt < balance && balance-amt>minBalance)
     {
         Balance = balance - amt;
     }
     else
     {
        throw new Exception("Minimum 1000 balance must be maintain");
     }
 }

 public void Depoist(float amt)
 {
    if(amt<1){
        throw new Exception("Cannot depoist 0 or less than Zero amount");
    }

     if( balance ==0 && amt < 1000)
     {
         Console.WriteLine("Depoist amount must be greater than 1000");
     }
     Balance += amt;
 }

 public string Display()
 {
     return string.Format("id:{0} name:{1} balance:{2} interest={3}",id,name,balance,interest);
 }

 public int Id{
    get{return id;}
}

public string Name{
    get{return name;}
    set{
        if(value.Length<3 && value.Length>=15){
            throw new Exception("First Name must be greater than 3 char and less than 15 char");
        }
        name=value;
    }
}

public double Balance{
    get{return balance;}
    set{
        if(value<1000){
            throw new Exception("Balance must be greater than 1000");
        }
        balance=value;
    }
}

public class Program{
    static void Main(string[] args){
        try{
            Account a1=new Account("Tejas",10001);
            Account.CalcInterestAmount(a1);
            Console.WriteLine(a1.Display());
             Account a2=new Account("Pratik",1005);
            Account.CalcInterestAmount(a2);
            Console.WriteLine(a2.Display());
             Account a3=new Account("Sameer",5000);
            Account.CalcInterestAmount(a3);
            Console.WriteLine(a3.Display());

            //Exception
             Account a4=new Account("Yash",1000);
            Account.CalcInterestAmount(a4);
            Console.WriteLine(a4.Display());
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }
}

}
