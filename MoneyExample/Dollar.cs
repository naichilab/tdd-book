using System;

namespace MoneyExample
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var other = obj as Dollar;
            if (other == null) return false;
            return Amount == other.Amount;
        }
    }
}