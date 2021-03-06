namespace MoneyExample
{
    public class Money : Expression
    {
        public int Amount;
        protected string _currency;

        public Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public Expression Times(int multiplier)
        {
            return new Money(Amount * multiplier, _currency);
        }

        public Expression Plus(Expression added)
        {
            return new Sum(this, added);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(_currency, to);
            return new Money(Amount / rate, to);
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