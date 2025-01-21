

namespace StaticDataAndMembers;

class SavingsAccount
{
    public double currBalance;
    public static double interestRate;

    public SavingsAccount(double balance)
    {
        currBalance = balance;
    }

    // Static constructor!
    static SavingsAccount() => interestRate = 0.04;

    public static double GetInterestRate() => interestRate;

    public static void SetInterestRate(double newRate) => interestRate = newRate;
}
