using System;

namespace MoneyExample
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

    }
}