using System;

namespace MoneyExample
{
    public class Franc
    {
        private readonly int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var other = obj as Franc;
            if (other == null) return false;
            return _amount == other._amount;
        }
    }
}