string? nullableString = null;
Test? nullableTestClass = null;


// Warning CS8600  Converting null literal or possible null value to non-nullable type.
Test nonNullableTestClass = nullableTestClass;

#nullable disable
Test anotherNullableClass = null;
// Warning CS8632  The annotation for nullable reference types
// should only be used in code within a '#nullable' annotations context.
// Example
//Test? anotherNullableClass = null; // Illegal outside of a nullable context
// Warning CS8632  The annotation for nullable reference types
// should only be used in code within a '#nullable' annotations context.
string? anotherNullableString = null;
#nullable restore

EnterLogData(null);
// Warning CS8604  Possible null reference argument for parameter 'message' in 'void EnterLogData(string message, string owner)'.


static void EnterLogData(string message, string owner = "Programmer")
{
    Console.WriteLine($"Error: {message}");
    Console.WriteLine($"Owner of Error: {owner}");
}

class Test
{
    public string Name { get; set; }
    public int Age { get; set; }
}