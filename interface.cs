using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal interface ICardHolder
    {
        // interface methods
        void SetBalance(double newBalance);
        void PrintOptions();
        void Deposit(CardHolder currentUser);
        void Withdraw(CardHolder currentUser);
        void Balance1(CardHolder currentUser);

    }
}
