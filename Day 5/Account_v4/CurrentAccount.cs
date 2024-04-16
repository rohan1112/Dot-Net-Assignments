using BankAccount;

namespace BankAccount
{
    class CurrentAccount : Account {

        public CurrentAccount(string name,double salary,string AccountType) : base(name,salary,AccountType){

        }
        public new void Withdraw(float amt)
        {
                Balance = Balance - amt;
                CalcInterestAmount(this);
        }
    }
}