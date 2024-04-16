using BankAccount;

namespace BankAccount
{
    class SavingAccount : Account {

        public SavingAccount(string name,double salary,string AccountType) : base(name,salary,AccountType){

        }
        public new void Withdraw(float amt)
        {
            if (amt >0 && amt < Balance && Balance-amt>minBalance)
            {
                Balance = Balance - amt;
                CalcInterestAmount(this);
            }
            else
            {
            throw new Exception("Minimum 1000 balance must be maintain");
            }
        }
    }
}