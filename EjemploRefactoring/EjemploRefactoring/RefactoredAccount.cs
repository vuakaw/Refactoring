using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploRefactoring
{
    public class RefactoredAccount
    {
        public RefactoredAccount(int id, string accountType, decimal balance)
        {
            Id = id;
            AccountType = accountType;
            Balance = balance;
        }
        public int Id { get; }
        public string AccountType { get; }
        public decimal Balance { get; private set; }

        public void CalculateAndApplyInterest(RefactoredInterestCalculator calculator)
        {
            var interest = calculator.CalculateInterest(this);
            IncreaseBalance(interest);
        }

        private void IncreaseBalance(decimal amount)
        {
            Balance += amount;
        }
    }
}
