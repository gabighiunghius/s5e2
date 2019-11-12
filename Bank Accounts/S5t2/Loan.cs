using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5t2
{
    class Loan : Accounts
    {
        public Loan(string customer, double balance, int interestrate) : base(customer, balance, interestrate) { }
        
        public override void CalculateInterest()
        {

            
        }
        public void DepositOperation() { }
        
    }
}
