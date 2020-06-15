namespace MoneyExample
{
    public abstract class Money
    {
        protected int Amount;
        public abstract Money Times(int multiplier);
        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount
                   && GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(5);
        }
    }
}