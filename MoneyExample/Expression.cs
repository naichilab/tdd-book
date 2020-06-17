namespace MoneyExample
{
    public interface Expression
    {
        Expression Plus(Expression added);
        Money Reduce(Bank bank, string to);
    }
}