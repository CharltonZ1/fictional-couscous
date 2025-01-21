using StaticDataAndMembers;

Console.WriteLine("***** Fun with Static Data *****\n");

SavingsAccount s1 = new(50);
SavingsAccount s2 = new(100);

// Print the current interest rate.
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

// Creating a new object, this does NOT 'reset' the interest rate

SavingsAccount.SetInterestRate(0.08);

SavingsAccount s3 = new(5000);

Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();


Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();