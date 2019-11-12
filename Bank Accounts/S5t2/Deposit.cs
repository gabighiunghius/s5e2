using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5t2
{
    class Deposit : Accounts
    {
        public Deposit(string customer, double balance, int interestrate) : base(customer, balance, interestrate) { }




        public override void CalculateInterest()
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                InterestRate = 0;
            }
            else InterestRate = Numberofmonths * InterestRate;
        }

        
        public void DepositOperation() { }

        public void WithdrawOperation() { }
       


    }
}
