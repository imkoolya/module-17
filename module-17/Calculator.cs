public class RegularAccountInterestCalculator : IAccountInterestCalculator
{
    public void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * 0.4;

        if (account.Balance < 1000)
            account.Interest -= account.Balance * 0.2;
        else
            account.Interest -= account.Balance * 0.4;
    }
}
public class SalaryAccountInterestCalculator : IAccountInterestCalculator
{
    public void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * 0.5;
    }
}
public static class Calculator
{
    public static void CalculateInterest(Account account, IAccountInterestCalculator interestCalculator)
    {
        interestCalculator.CalculateInterest(account);
    }
}