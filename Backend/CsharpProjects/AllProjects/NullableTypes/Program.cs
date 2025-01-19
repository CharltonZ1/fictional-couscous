
Console.WriteLine("***** Fun With Nullable Value Types *****\n");

DataReader dr = new DataReader();

// Get int from "database".
int? i = dr.GetIntFromDB();

if (i.HasValue)
    Console.WriteLine("Value of 'i' is: {0}", i.Value);
else
    Console.WriteLine("Value of 'i' is undefined.");

bool? b = dr.GetBoolFromDB();

if (b != null)
    Console.WriteLine("Value of 'b' is: {0}", b.Value);
else
    Console.WriteLine("Value of 'b' is undefined.");

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();


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
