// Create class Account having member id, name , balance.
// Id autoincrement write read only property
// Write getter setter for name and balance.
// Balance can be modified only by child class.
// This has virtual withdraw method which will 0.
// It has deposit method.
// Create two child class current and saving and override withdraw method. 
// Create reference of Account class and point to saving account
// and  current account. Using parent’s reference call withdraw method and deposit method.
// Use ToString method to display status of the object [id name balance]

namespace BankAccount
{

    public class Account
    {
        private int id;
        private string name, AccType;
        private double balance;
        private static int count = 0;
        internal const float minBalance = 1000F;
        private static double InterestRate = 0.07;
        private double interest;

        static Account()
        {
            Console.WriteLine("Welcome to 901 Gringotts Bank @2024");
        }

        // public Account()
        // {

        // }
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

         public virtual void Withdraw(float amt)
         {
            //  if (amt >0 && amt < balance && balance-amt>minBalance)
            //  {
            //      Balance = balance - amt;
            //  }
            //  else
            //  {
            //     throw new Exception("Minimum 1000 balance must be maintain");
            //  }
         }

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
        }

        public override string ToString()
        {
            return string.Format("id:{0} name:{1} balance:{2:0.00} Type:{3}", id, name, balance,AccType);
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
            protected set
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

    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account s = new SavingAccount("Rohan", 20000, "Saving");
                s.Withdraw(1000);
                Console.WriteLine(s);
                Account c = new CurrentAccount("Pratik", 24000, "Current");
                c.Withdraw(25000);
                Console.WriteLine(c);
                Account s1 = new SavingAccount("Sameer", 28025, "Saving");
                s1.Withdraw(8000);
                Console.WriteLine(s1);
                Account c1 = new CurrentAccount("Yash", 32000, "Current");
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