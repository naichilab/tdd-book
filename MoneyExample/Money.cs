namespace MoneyExample
{
    public abstract class Money
    {
        protected int Amount;
        public abstract Money Times(int multiplier);
        public abstract string Currency();

        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount
                   && GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
    }
}