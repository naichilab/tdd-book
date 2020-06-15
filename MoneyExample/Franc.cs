using System;

namespace MoneyExample
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }
    }
}