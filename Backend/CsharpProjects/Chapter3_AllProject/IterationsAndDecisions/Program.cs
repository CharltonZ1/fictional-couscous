
using System.Runtime.CompilerServices;

Console.WriteLine("*** Fun with Loops and Control Flow ***");

ForLoopExample();
ForEachLoopExample();
LinqQueryOverInts();
WhileLoopExample();
DoWhileLoopExample();
IfElseExample();
IfElsePatternMatchingExample();
IfElsePatternMatchingUpdatedinCSharp9();
ConditionalOperatorExample();
ConditionalRefExample();
SwitchExample();
SwitchOnStringExample();
SwitchOnEnumExample();
SwitchWithGoto();
ExecutePatternMatchingSwitch();
ExecutePatternMatchingSwitchWithWhen();

Console.WriteLine("Press Enter to continue...");
Console.ReadLine();

static void ForLoopExample()
{
    Console.WriteLine("=> For Loop Example:");
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Number is: {0}", i);
    }
    Console.WriteLine();
}

static void ForEachLoopExample()
{
    Console.WriteLine("=> Foreach Loop Example:");
    string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
    foreach (string c in carTypes)
    {
        Console.WriteLine(c);
    }
    Console.WriteLine();
}

static void LinqQueryOverInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
    var subset = from i in numbers where i < 10 select i;
    Console.WriteLine("Values in subset: ");
    foreach (var  i in numbers) { Console.WriteLine(i); }
    Console.WriteLine();
}

static void WhileLoopExample()
{
    Console.WriteLine("=> While Loop Example:");
    string userIsDone = "";
    while (userIsDone.ToLower() != "yes")
    {
        Console.WriteLine("In while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
    }
    Console.WriteLine();
}

static void DoWhileLoopExample()
{
    string userIsdone = "";
    do
    {
        Console.WriteLine("In do/while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsdone = Console.ReadLine();
    } while (userIsdone.ToLower() != "yes");
    Console.WriteLine();
}


static void IfElseExample()
{
    string stringData = "My textual data";
    if (stringData.Length > 0)
    {
        Console.WriteLine("string is greater than 0 characters");
    }
    else
    {
        Console.WriteLine("string is empty");
    }
    Console.WriteLine();
}

static void IfElsePatternMatchingExample()
{
    object testObject = "test";
    object testObject2 = 123;
    if (testObject is int i)
    {
        Console.WriteLine($"{i} is an int");
    }
    else
    {
        Console.WriteLine($"{testObject} is not an int");
    }

    if (testObject2 is int j)
    {
        Console.WriteLine($"{j} is an int");
    }
    else
    {
        Console.WriteLine($"{testObject2} is not an int");
    }
    Console.WriteLine();
}
153246
static void IfElsePatternMatchingUpdatedinCSharp9()
{
    Console.WriteLine("C# 9 If Else Pattern Matching Improvements");
    object testObject = "test";
    Type t = typeof(int);
    char c = 'a';

    // Type pattern
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
    }

    // Relational, Conjuctive, and Disjunctive patterns
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{c} is a valid alpahbetical character");
    }

    // Parenthesized patterns

    if ((c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ','))
    {
        Console.WriteLine($"{c} is a character or seperator");
    }

    // Negative patterns
    if ( testObject is not string)
    {
        Console.WriteLine($"{testObject} is not a string");
    }
    if (testObject is not null)
    {
        Console.WriteLine($"{testObject} is not null");
    }
    Console.WriteLine();
}


static void ConditionalOperatorExample()
{
    Console.WriteLine("=> Conditional Operator Example:");
    int x = 10, y = 4;
    string result = x > y ? "x is greater than y" : "y is greater than or equal to x";
    Console.WriteLine(result);
    Console.WriteLine();
}

static void ConditionalRefExample()
{
    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 10, 20, 30, 40, 50 };

    int index = 7;
    ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]);
    refValue = 0;

    index = 2;
    ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]) = 100;
    Console.WriteLine(string.Join(" ", smallArray));
    Console.WriteLine(string.Join(" ", largeArray));
    Console.WriteLine();
}

static void SwitchExample()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.WriteLine("Please pick your language preference: ");

    string langChoice = Console.ReadLine();
    int n = int.Parse(langChoice);

    switch (n)
    {
        case 1:
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        case 2:
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        default:
            Console.WriteLine("Well, good luck with that!");
            break;
    }
    Console.WriteLine();
}


static void SwitchOnStringExample()
{
    Console.WriteLine("C# or VB");
    Console.WriteLine("Please pick your language preference: ");

    string langChoice = Console.ReadLine();

    switch (langChoice.ToUpper())
    {
        case "C#":
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        case "VB":
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        default:
            Console.WriteLine("Well, good luck with that!");
            break;
    }
    Console.WriteLine();
}


static void SwitchOnEnumExample()
{
    Console.WriteLine("Enter your favorite day of the week: ");
    DayOfWeek favDay;
    try
    {
        favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Bad Input!");
        return;
    }

    switch (favDay)
    {
        case DayOfWeek.Sunday:
            Console.WriteLine("Rest and relaxation!");
            break;
        case DayOfWeek.Monday:
            Console.WriteLine("Back to work!");
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine("At least it's not Monday!");
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine("A fine day.");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine("Almost Friday.");
            break;
        case DayOfWeek.Friday:
            Console.WriteLine("Thank God it's Friday!");
            break;
        case DayOfWeek.Saturday:
            Console.WriteLine("Weekend at last!");
            break;
    }
    Console.WriteLine();
}

static void SwitchWithGoto()
{
    var foo = 5;
    switch (foo)
    {
        case 1:
            Console.WriteLine("Case 1");
            goto case 2;
        case 2:
            Console.WriteLine("Case 2");
            goto default;
        default:
            Console.WriteLine("Default");
            break;
    }
    Console.WriteLine();
}


static void ExecutePatternMatchingSwitch()
{
    Console.WriteLine("1 [Integer (5)], 2 [String \"Hi\"], 3 [Decimal (2.5)] ");
    Console.WriteLine("Please choose an option: ");
    string userChoice = Console.ReadLine();
    object choice;

    // Standard constant pattern switch statement
    switch (userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5m;
            break;
        default:
            choice = 5;
            break;
    }

    // New switch statement that uses pattern matching
    switch (choice)
    {
        case int i:
            Console.WriteLine($"Your choice is an integer: {i}");
            break;
        case string s:
            Console.WriteLine($"Your choice is a string: {s}");
            break;
        case decimal d:
            Console.WriteLine($"Your choice is a decimal: {d}");
            break;
        default:
            Console.WriteLine("Your choice is something else");
            break;
    }
    Console.WriteLine();
}

static void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.WriteLine("Please pick your language preference: ");
    
    object langChoice = Console.ReadLine();
    var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

    switch (choice)
    {
        case int i when i == 2:
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
    Console.WriteLine();
}

static string FromRainbowClassic(string colorBand)
{
    switch (colorBand)
    {
        case "Red": return "#FF0000";
        case "Orange": return "#FF7F00";
        case "Yellow": return "#FFFF00";
        case "Green": return "#00FF00";
        case "Blue": return "#0000FF";
        case "Indigo": return "#4B0082";
        case "Violet": return "#9400D3";
        default: return "#FFFFFF";
    }
}

static string FromRainbowConcise(string colorBand)
{
    return colorBand switch
    {
        "Red" => "#F00",
        "Orange" => "#FF7F00",
        "Yellow" => "#FF0",
        "Green" => "#0F0",
        "Blue" => "00F",
        "Indigo" => "#4B0082",
        "Violet" => "#9400D3",
        _ => "#FFF"
    };
}

static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins",
        ("rock","scissors") => "Rock wins",
        ("paper", "rock") => "Paper wins",
        ("paper", "scissors") => "Sciessors wins",
        ("scissors", "rock") => "Rock wins",
        ("scissors", "paper") => "Scissors wins",
        (_, _) => "Tie"
    };
}
