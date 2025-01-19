Console.WriteLine("***** Fun with Enums *****");
// Make an EmpTypeEnum variable.
EmpTypeEnum emp = EmpTypeEnum.Admin;
AskForBonus(emp);

// Print storage for the enum.
Console.WriteLine("EmpTypeEnum uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));

// OR

Console.WriteLine("EmpTypeEnum user a {0} for storage", Enum.GetUnderlyingType(typeof(EmpTypeEnum)));

// Print out the current value of EmpTypeEnum variable.
Console.WriteLine("EmpTypeEnum value: {0}", (int)emp);

// Print the string name of the enum variable.
Console.WriteLine("EmpTypeEnum value: {0}", emp.ToString());

// Modern C# allows you to use the nameof() operator to get the name of the enum variable. 

Console.WriteLine("EmpTypeEnum name using nameof(emp): {0}", nameof(emp));


Console.WriteLine("EmpTypeEnum name of the value of emp: {0}", emp);

DayOfWeek day = DayOfWeek.Monday;
ConsoleColor cc = ConsoleColor.Gray;

EvaluateEnum(emp);
EvaluateEnum(day);
EvaluateEnum(cc);


Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();

static void EvaluateEnum(System.Enum e)
{
    Console.WriteLine("=> Information about {0}", e.GetType().Name);

    Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

    // Get all the name-value pairs for incoming parameter.
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine("This enum has {0} members.", enumData.Length);

    // Now show the string name and associated value, using the D format flag.
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
    }
    Console.WriteLine();
}


static void AskForBonus(EmpTypeEnum emp)
{
    switch (emp)
    {
        case EmpTypeEnum.Manager:
            Console.WriteLine("How about stock options instead?");
            break;
        case EmpTypeEnum.Programmer:
            Console.WriteLine("You have already gotten enough cash...");
            break;
        case EmpTypeEnum.Admin:
            Console.WriteLine("You have already gotten enough cash...");
            break;
        case EmpTypeEnum.Tester:
            Console.WriteLine("You have already gotten enough cash...");
            break;
        default:
            Console.WriteLine("Don't know what you do...");
            break;
    }

    Console.WriteLine();
}



// Legal ways to define an enum
enum EmpTypeEnum
{
    Manager,
    Programmer,
    Admin,
    Tester
}

//enum EmpTypeEnum
//{
//    Manager = 102,
//    Programmer,
//    Admin,
//    Tester
//}

//enum EmpTypeEnum
//{
//    Manager = 102,
//    Programmer = 105,
//    Admin = 110,
//    Tester = 115
//}

//enum EmpTypeEnum : byte]
//{
//    Manager = 102,
//    Programmer = 105,
//    Admin = 110,
//    Tester = 115
//}