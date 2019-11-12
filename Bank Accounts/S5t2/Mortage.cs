using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5t2
{
   public class Mortage : Accounts
    {
        public Mortage(string customer, double balance, int interestrate) : base(customer, balance, interestrate) { }

        public override void CalculateInterest()
        {
           
        }
        public void DepositOperation() { }
        
    }
}
