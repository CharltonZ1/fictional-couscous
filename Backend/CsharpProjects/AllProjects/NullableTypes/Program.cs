
Console.WriteLine("***** Fun With Nullable Value Types *****\n");

DataReader dr = new();

// Get int from "database".
int? i = dr.GetIntFromDB();

// If the value from GetIntFromDB is null, assign local variable to 100.
int myData = i ?? 100;
Console.WriteLine("Value of myData: {0}", myData);

// Get bool from "database".
bool? b = dr.GetBoolFromDB();

// If the value from GetBoolFromDB is null, assign local variable to false.
bool myBool = b ?? false;
Console.WriteLine("Value of myBool: {0}", myBool);

// Null-Coalescing Assignment Operator
int? nullableInt = null;
nullableInt ??= 100;
Console.WriteLine("Value of nullableInt: {0}", nullableInt);

// More examples
// Traditional null checking
TesterMethod(null);

// Using the null conditional operator
TesterMethod2(null);

// Using the null conditional operator with null coalescing
TesterMethod3(null);

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();

static void TesterMethod3(string[] args)
{
    // We should check for null before accessing the array data!
    // And assign a default value if the array is null.
    Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
}
static void TesterMethod2(string[] args)
{
    // We should check for null before accessing the array data!
    Console.WriteLine($"You sent me {args?.Length} arguments.");
}
static void TesterMethod(string[] args)
{
    if (args != null)
    {
        Console.WriteLine($"You sent me {args.Length} arguments.");
    }
    else
    {
        Console.WriteLine("Args is null.");
    }
}

static void LocalNullableTypes()
{
    int? nullableint = 10;
    double? nullableDouble = 3.14;
    bool? nullableBool = null;
    int?[] arrayOfNullableInts = new int?[10];
    Console.WriteLine("Nullable Types:");
    Console.WriteLine("Value of nullableint: {0}", nullableint);
}

static void LocalNullableTypesUsingNullable()
{
    // Define some local nullable types using Nullable<T>.
    Nullable<int> nullableint = 10;
    Nullable<double> nullableDouble = 3.14;
    Nullable<bool> nullableBool = null;
    Console.WriteLine("Using Nullable<T>:");
    Console.WriteLine("Value of nullableint: {0}", nullableint);
}

class DataReader
{
    public int? numericValue = null;
    public bool? boolValue = true;

    public int? GetIntFromDB()
    {
        return numericValue;
    }

    public bool? GetBoolFromDB()
    {
        return boolValue;
    }
}
