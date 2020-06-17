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
    }
}