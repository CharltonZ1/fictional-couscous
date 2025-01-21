

namespace StaticDataAndMembers;

class SavingsAccount
{
    public double currBalance;

    private static double _currInterestRate = 0.04;

    public static double InterestRate
    {
        get => _currInterestRate;
        set => _currInterestRate = value;
    }

    public SavingsAccount(double balance)
    {
        currBalance = balance;
    }
}
