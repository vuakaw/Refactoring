using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploRefactoring
{
    internal class InterestCalculator
    {
        private decimal _interestRate = 1.01m;

        public void CalculateInterest(Account account)
        {
            if(account.AccountType == "Checking")
            {
                return;
            }
            if(account.AccountType == "Savings")
            {
                decimal interest = account.Balance * this._interestRate;
                account.Balance = interest;
                return;
            }
            throw new InvalidOperationException(string.Format("Unknown Account tyoe: {0}", account.AccountType));
        }
    }
}
