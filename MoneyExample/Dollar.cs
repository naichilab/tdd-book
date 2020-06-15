using System;

namespace MoneyExample
{
    public class Dollar
    {
        private readonly int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var other = obj as Dollar;
            if (other == null) return false;
            return _amount == other._amount;
        }
    }
}