using System;

namespace MoneyExample
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(Amount * multiplier);
        }
    }
}