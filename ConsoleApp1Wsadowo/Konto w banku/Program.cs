using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konto_w_banku
{
    class Program
    {
        static void Main(string[] args)
        {

            public class Account : IAccount 
        {

            public Account(string Name, decimal Balance = 0)
            {
                if (Name == null) throw new ArgumentOutOfRangeException();

                Name = Name.Replace(" ", "");
                if (Name.Length >= 3)
                {
                    this.Name = Name;
                }
                else
                {
                    throw new ArgumentException();
                }

                if (Balance >= 0)
                {
                    this.Balance = Balance;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

                IsBlocked = false;
            }
        
            public string Name { get; }

            private decimal balance;
            public decimal Balance
            {
                get
                {
                    return Math.Round(this.balance, 4);
                }
                private set
                {
                    this.balance = Math.Round(value, 4);
                }
            }

            public bool IsBlocked { get; private set; }

            public void Block()
            {
                IsBlocked = true;
            }

            public bool Deposit(decimal amount)
            {
                if (!IsBlocked && amount >= 0)
                {
                    Balance += amount;
                    return true;
                }
                return false;
            }

            public void Unblock()
            {
                IsBlocked = false;
            }

            public bool Withdrawal(decimal amount)
            {
                if (!IsBlocked && amount > 0 && amount <= Balance)
                {
                    Balance -= amount;
                    return true;
                }
                return false;
            }

            public override string ToString()
            {
                if (IsBlocked) return $"Account name: {Name}, balance: {Balance:0.00}, blocked";
                return $"Account name: {Name}, balance: {Balance:0.00}";
            }
        }
    
        
    }
}
