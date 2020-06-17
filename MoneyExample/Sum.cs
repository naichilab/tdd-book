namespace MoneyExample
{
    public class Sum : Expression
    {
        public Money Augend { get; set; }
        public Money Addend { get; set; }

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = Augend.Reduce(bank, to).Amount + Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }
    }
}