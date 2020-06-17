namespace MoneyExample
{
    public class Money : Expression
    {
        protected int Amount;
        protected string _currency;

        public Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, _currency);
        }

        public Expression Plus(Money added)
        {
            return new Sum(this, added);
        }

        public string Currency() => _currency;

        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount
                   && Currency().Equals(money.Currency());
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override string ToString()
        {
            return $"{Amount} {_currency}";
        }
    }
}