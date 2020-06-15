using System;

namespace MoneyExample
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
            _currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}