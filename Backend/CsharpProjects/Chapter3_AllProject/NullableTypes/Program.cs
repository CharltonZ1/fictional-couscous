

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

