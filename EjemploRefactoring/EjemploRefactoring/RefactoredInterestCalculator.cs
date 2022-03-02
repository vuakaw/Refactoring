using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploRefactoring
{
    public class RefactoredInterestCalculator
    {
        private decimal _interestRate = 1.01m;

        public decimal CalculateInterest(RefactoredAccount account)
        {
            if(account.AccountType == "Checking")
            {
                return 0;
            }
            if(account.AccountType == "Savings")
            {
                decimal interest = account.Balance * this._interestRate;    
                return interest;
            }
            throw new InvalidOperationException(string.Format("Unkown Account Type: {}", account.AccountType));
        }
    }
}
