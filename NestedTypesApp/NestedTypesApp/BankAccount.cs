using System;
using System.Collections.Generic;
using System.Text;

namespace NestedTypesApp
{
    public class BankAccount
    {
        protected decimal _sum;
        protected string _userAccount;
        protected double _interestRate;
        protected int _percentage; 
        protected DateTime accountopeningdate;

        public BankAccount(string user, decimal balance, double interestRate)
        {
            this._interestRate = interestRate;
            this._userAccount = user;
            this._sum = balance;
        }

        public virtual decimal GetSum
        {
            get { return _sum; }
        }

        public virtual void Withdraw(decimal amount)
        {
            _sum -= amount;
        }

        public virtual void Deposit(decimal amount)
        {
            _sum += amount;
        }

        private sealed class SavingsAccount : BankAccount
        {
            public SavingsAccount(string user, decimal sum, double interestRate):base(user,sum,interestRate)
            {

            }
         
            public override void Withdraw(decimal amount)
            {
                if (amount < _sum)
                    _sum -= amount;
                else
                    throw new Exception("Cannot withdraw");
            }
         
        }
        private sealed class CheckingAccount : BankAccount
        {
            public CheckingAccount(string user, decimal sum, double interestRate) : base(user, sum, interestRate)
            {

            }
            public override void Withdraw(decimal amount)
            {
                _sum -= amount;
                if (amount < _sum)
                    _interestRate = -0.10;
            }
        }
        public static BankAccount MakeSavingAccount()
        {
            return null;
        }
        public static BankAccount MakeChequingAccount()
        {
            return null;
        }
    }

}
