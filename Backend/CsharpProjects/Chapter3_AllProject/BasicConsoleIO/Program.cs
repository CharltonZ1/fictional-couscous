Console.WriteLine("***** Basic Console I/O *****");
GetUserData();

// Wait for Enter key to be pressed.
Console.WriteLine("\nPress Enter to close...");
Console.ReadLine();


static void GetUserData()
{
    // Get name and age.
    Console.Write("Please enter your name: ");
    string? userName = Console.ReadLine();
    Console.Write("Please enter your age: ");
    string? userAge = Console.ReadLine();

    // Change echo text color
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;

    // Echo to the console.
    Console.WriteLine($"Hello {userName}! You are {userAge} years old.");

    Console.WriteLine();

    // Restore previous color.
    Console.ForegroundColor = prevColor;

    FormatNumericalData();
}

static void FormatNumericalData()
{
    var value = 99999;
    Console.WriteLine("The value 99999 in various formats:");
    Console.WriteLine("c format: {0:c}", value);
    Console.WriteLine("d9 format: {0:d9}", value);
    Console.WriteLine("f3 format: {0:f3}", value);
    Console.WriteLine("n format: {0:n}", value);


    // Notice that upper- or lowercasing for hex 
    // determines if letters are upper- or lowercase.
    Console.WriteLine("E format: {0:E}", value);
    Console.WriteLine("e format: {0:e}", value);
    Console.WriteLine("x format: {0:x}", value);
    Console.WriteLine("X format: {0:X}", value);
}