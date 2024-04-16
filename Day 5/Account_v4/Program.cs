// Create class Account having member variable id,name, balance.
// Write getter/setter for id, name and balance
// create method deposit which will increase balance
// Create two child class currentaccount and saving account
// It has member type,
// In both the class create withdraw method who’ s job is to reduce balance.
// In currentaccount negative balance allowed
// In savingaccount –ve balance not allowed.
// When you load application it should print name of bank.
// New Savingaccount(1,”Raj”,50000,” “saving”)

namespace BankAccount
{

    public class Account
    {
        int id;
        string name, AccType;
        double balance;
        static int count = 0;
        internal const float minBalance = 1000F;
        static double InterestRate = 0.07;
        double interest;

        static Account()
        {
            Console.WriteLine("Welcome to 901 Gringotts Bank @2024");
        }

        public Account()
        {

        }
        public Account(string name, double balance, string accountType)
        {
            if (count > 2)
            {
                throw new Exception("No space for additional account");
            }
            if (balance < minBalance)
            {
                throw new Exception("Balance must be greater than 1000");
            }
            else
            {
                id = ++count;
                Name = name;
                Balance = balance;
                AccountType = accountType;

            }
        }

        public static double CalcInterestAmount(Account obj)
        {
            obj.interest = obj.balance * InterestRate;
            obj.Balance = obj.balance + obj.interest;
            return obj.interest;
        }

        //  public void Withdraw(float amt)
        //  {
        //      if (amt >0 && amt < balance && balance-amt>minBalance)
        //      {
        //          Balance = balance - amt;
        //      }
        //      else
        //      {
        //         throw new Exception("Minimum 1000 balance must be maintain");
        //      }
        //  }

        public void Depoist(float amt)
        {
            if (amt < 1)
            {
                throw new Exception("Cannot depoist 0 or less than Zero amount");
            }

            if (balance == 0 && amt < 1000)
            {
                Console.WriteLine("Depoist amount must be greater than 1000");
            }
            Balance += amt;
            CalcInterestAmount(this);
        }

        public override string ToString()
        {
            return string.Format("id:{0} name:{1} balance:{2:0.00} interest={3:0.00} Type:{4}", id, name, balance, interest, AccType);
        }

        public int Id
        {
            get { return id; }
        }

        public string AccountType
        {
            get { return AccType; }
            set
            {
                AccType = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3 && value.Length >= 15)
                {
                    throw new Exception("First Name must be greater than 3 char and less than 15 char");
                }
                name = value;
            }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (this.AccountType == "Current")
                {
                    balance = value;
                }
                else if (value < 1000)
                {
                    throw new Exception("Balance must be greater than 1000");
                }
                balance = value;
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    SavingAccount s = new SavingAccount("Rohan", 20000, "Saving");
                    s.Withdraw(1000);
                    Console.WriteLine(s);
                    CurrentAccount c = new CurrentAccount("Pratik", 24000, "Current");
                    c.Withdraw(25000);
                    Console.WriteLine(c);
                    SavingAccount s1 = new SavingAccount("Sameer", 28025, "Saving");
                    s1.Withdraw(8000);
                    Console.WriteLine(s1);
                    CurrentAccount c1 = new CurrentAccount("Yash", 32000, "Current");
                    c1.Withdraw(32000);
                    Console.WriteLine(c1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }

}