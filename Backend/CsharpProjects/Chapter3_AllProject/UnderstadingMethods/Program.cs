Console.WriteLine("***** Fun with Methods *****");

DisplayFanceMessage(message: "Wow! Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);

DisplayFanceMessage(backgroundColor: ConsoleColor.Green, textColor: ConsoleColor.Blue, message: "Testing 1, 2, 3");

//EnterLogData("Oh no! Grid can't find data");
//EnterLogData("Oh no! I can't find the payroll data", "CFO");

//Console.WriteLine("Pass in a comma-delimited list of doubles:");
//double average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
//Console.WriteLine("Average of data is: {0}", average);

//Console.WriteLine("Or pass in an array of doubles:");
//double[] data = { 4.0, 3.2, 5.7 };
//average = CalculateAverage(data);
//Console.WriteLine("Average of data is: {0}", average);

//Console.WriteLine("Average of 0 is 0:");
//Console.WriteLine("Average of data is: {0}", CalculateAverage());
//Console.WriteLine();

//string s1 = "Flip";
//string s2 = "Flop";
//Console.WriteLine("Before: {0}, {1}", s1, s2);
//SwapStrings(ref s1, ref s2);
//Console.WriteLine("After: {0}, {1}", s1, s2);

// Return multiple values using out parameters
//FillTheseValues(out int i, out string str, out bool b);
//Console.WriteLine("Int is: {0}", i);
//Console.WriteLine("String is: {0}", str);
//Console.WriteLine("Bool is: {0}", b);
//Console.WriteLine();

// Discarding out parameters
//FillTheseValues(out _, out _, out _);


//int x = 9, y = 10;
//Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
//Console.WriteLine("Answer is: {0}", Add(x, y));
//Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
//Console.WriteLine();

//int ans;
//AddUsingOutParam(x, y, out ans);
//Console.WriteLine("Using out parameter: {0}", ans);

// C# 7.0 allows out params to be declared in the method call
//AddUsingOutParam(x, y, out int ans);
//Console.WriteLine("Using out parameter: {0}", ans);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

static int Add(int a, int b)
{
    int ans = a + b;

    a = 100;
    b = 200;
    // The caller will not see the changes made to a and b
    // because they are passed by value (copies of the original values)
    return ans;
}

static void AddUsingOutParam(int a, int b, out int ans)
{
    ans = a + b;
}

static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}

static void SwapStrings(ref string s1,  ref string s2)
{
    // Modern C# allows you to swap values without using a temp variable
    (s2, s1) = (s1, s2);

    // Old way
    //string temp = s1;
    //s1 = s2;
    //s2 = temp;
}

static int AddReadOnly(in int x, in int y)
{
    // Error! Cannot modify x or y as they are readonly
    //x = 100;
    //y = 200;
    return x + y;
}

static double CalculateAverage(params double[] values)
{
    Console.WriteLine("You sent {0} doubles", values.Length);
    double sum = 0;

    if (values.Length == 0)
    {
        return sum;
    }

    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }

    return sum;
}

static void EnterLogData(string m, string owner = "Programmer")
{
    Console.Beep();
    Console.WriteLine("Error: {0}", m);
    Console.WriteLine("Owner of Error: {0}", owner);
}

// DateTime.Now is calculated at runtime
// C# requires default parameters to be compile-time constants
//static void EnterLogDataError(string m, string owner = "Programmer", DateTime dt = DateTime.Now)
//{
//}

static void DisplayFanceMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
{
    // Store old colors to restore after message is printed
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldBackgroundColor = Console.BackgroundColor;
    // Set new colors and print message
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    // Restore previous colors
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldBackgroundColor;
}