namespace MoneyExample
{
    public class Sum : Expression
    {
        public Expression Augend { get; set; }
        public Expression Addend { get; set; }

        public Sum(Expression augend, Expression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Expression Plus(Expression added)
        {
            return new Sum(this, added);
        }

        public Expression Times(int multiplier)
        {
            return new Sum(Augend.Times(multiplier), Addend.Times(multiplier));
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = Augend.Reduce(bank, to).Amount + Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }
    }
}