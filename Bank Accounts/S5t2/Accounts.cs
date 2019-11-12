using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5t2
{
    public abstract class Accounts
    {
        public Accounts(string customer, double balance, int interestrate)
        {
            this.Customer = customer;
            this.Balance = (int)balance;
            this.InterestRate = interestrate;
            
        }
        public string Customer { get; set; }
        public int Balance { get; set; }
        public int InterestRate { get; set; }
        public int Ammount { get; set; }

        public int Numberofmonths { get; set; }

        public abstract void CalculateInterest();
       
        public virtual void DepositOperation()
        {
            this.Balance += Ammount;
        }
        public virtual void WithdrawOperation()
        {
            this.Balance -= Ammount;
        }
        
    }
 

}

