namespace MoneyExample
{
    public interface Expression
    {
        Expression Plus(Expression added);
        Expression Times(int multiplier);
        Money Reduce(Bank bank, string to);
    }
}