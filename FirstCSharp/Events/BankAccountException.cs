using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class BalanceNotAllowedException : Exception
    {
        public BalanceNotAllowedException(decimal balance) :
            base($"$/ {balance} not allowed as initial balance, must be greater than $/ 10")
        {

        }       
    }

    public class DepositAmountNotAllowedException : Exception
    {
        public DepositAmountNotAllowedException(decimal amount) 
            : base($"amount {amount} not allowed for deposit")
        {

        }
    }

}
