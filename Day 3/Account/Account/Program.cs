//2.Open previous example of Class Account
//As soon as you run your code it should print name of the bank



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        int id, balance;
        string name;

        static Account()
        {
            Console.WriteLine("Welcom to 901 Gringotts Bank!!!!!!!!!!!");
        }
        public Account(int id, string name, int balance)
        {
            this.id = id;
            this.name = name;

            this.balance = balance;
        }
        public void deposit(int amt)
        {
            if (amt > 0)
            {
                balance = balance + amt;
            }
        }
        public void withdraw(int amt)
        {
            if (amt < balance)
            {
                balance = balance - amt;
            }
        }
        public string getDetails()
        {
            return string.Format("Name={0} Balance={1}", name, balance);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "Akshay", 10000);
            Console.WriteLine("Before Withdrawing : " + account.getDetails());
            account.withdraw(500);
            Console.WriteLine("After Withdrawing : " + account.getDetails());
            account.deposit(2000);
            Console.WriteLine("After Depoisting : " + account.getDetails());

        }
    }
}