namespace MoneyExample
{
    public abstract class Money
    {
        protected int Amount;
        protected string _currency;
        
        public Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }
        
        public abstract Money Times(int multiplier);
        public string Currency() => _currency;

        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount
                   && GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount,"USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}