Console.WriteLine("***** Tuple Basics *****");

// Make a tuple with three elements.
var myTuple = (1, "Steve", true);
Console.WriteLine(myTuple);

// OR

(int, string, bool) myTuple2 = (1, "Steve", true);

// Access the tuple data by Item1, Item2, and Item3.
Console.WriteLine($"Item1: {myTuple.Item1}");
Console.WriteLine($"Item2: {myTuple.Item2}");
Console.WriteLine($"Item3: {myTuple.Item3}");

// Give each element a name.
var myNamedTuple = (first: 1, second: "Steve", third: true);

// OR

(int a, string b, bool c) myNamedTuple2 = (1, "Steve", true);

// Access the named tuple data by name.
Console.WriteLine($"first: {myNamedTuple.first}");
Console.WriteLine($"second: {myNamedTuple.second}");
Console.WriteLine($"third: {myNamedTuple.third}");

Console.WriteLine($"a: {myNamedTuple2.a}");
Console.WriteLine($"b: {myNamedTuple2.b}");
Console.WriteLine($"c: {myNamedTuple2.c}");

Console.WriteLine("=> Nested tuples:");
var myNestedTuple = (first: 1, second: "Steve", third: true, moreData: (2, "Jane"));
Console.WriteLine(myNestedTuple);

Console.WriteLine($"Item1: {myNestedTuple.first}");
Console.WriteLine($"Item2: {myNestedTuple.second}");
Console.WriteLine($"Item3: {myNestedTuple.third}");
Console.WriteLine($"moreData: {myNestedTuple.moreData}");
Console.WriteLine($"moreData Item1: {myNestedTuple.moreData.Item1}");


Console.WriteLine("=> Inferred tuple names:");
var foo = new { Prop1 = "first", Prop2 = "second" };
var bar = new { foo.Prop1, foo.Prop2 };

Console.WriteLine($"{bar.Prop1}, {bar.Prop2}");

Console.WriteLine("=> Tuples equality/inequality:");
// lifted conversions
var left = (a: 5, b: 10);
(int? a, int? b) nullableMembers = (5, 10);
Console.WriteLine("Is left equal to nullableMembers: {0}", left == nullableMembers); // True

(long a, long b) longTuple = (5, 10);
Console.WriteLine("Is left equal to longTuple: {0}", left == longTuple); // True

// comparisons performed on long tuples
(long a, long b, long c) longFirst = (5, 10, 15);
(long a, long b, long c) longSecond = (5, 10, 15);
Console.WriteLine("Is longFirst equal to longSecond: {0}", longFirst == longSecond); // True

var samples = FillTheseValuesUsingTuples();
Console.WriteLine($"Int: {samples.a}, String: {samples.b}, Bool: {samples.c}");

// Understanding discarding using the SplitNames example
// Only use first and last names.
var (first, _, last) = SplitNames("John F Kennedy");
Console.WriteLine($"First: {first}, Last: {last}");
// the middle name is discarded.

Console.WriteLine("RockPaperScissors((rock, paper)): {0}", RockPaperScissorsTuple(("rock", "paper")));

// Deconstructing tuples
var (a, b, c) = FillTheseValuesUsingTuples();
Console.WriteLine($"Int: {a}, String: {b}, Bool: {c}");

// Deconstructing tuples with a method
var p = new Point(7, 5);
var (x, y) = p.Deconstruct();
Console.WriteLine($"x: {x}, y: {y}");

// Deconstructing tuples with positional patterns
var p1 = new Point(7, 5);
int xp1 = 0;
int yp1 = 0;
(xp1, yp1) = p1;
Console.WriteLine($"xp1: {xp1}, yp1: {yp1}");


// If deconstruct is not defined with two out parameters
// then the Deconstruct method has to be expl
static string GetQuadrant1(Point p)
{
    return p.Deconstruct() switch
    {
        (0, 0) => "Origin",
        var (x, y) when x > 0 && y > 0 => "Quadrant 1",
        var (x, y) when x < 0 && y > 0 => "Quadrant 2",
        var (x, y) when x < 0 && y < 0 => "Quadrant 3",
        var (x, y) when x > 0 && y < 0 => "Quadrant 4",
        var (_,_) => "On an axis"
    };
}

// If the Deconstruct method is defined with two out parameters
// then the Deconstruct method can be used directly

static string GetQuadrant2(Point p)
{
    return p switch
    {
        (0, 0) => "Origin",
        var (x, y) when x > 0 && y > 0 => "Quadrant 1",
        var (x, y) when x < 0 && y > 0 => "Quadrant 2",
        var (x, y) when x < 0 && y < 0 => "Quadrant 3",
        var (x, y) when x > 0 && y < 0 => "Quadrant 4",
        var (_,_) => "On an axis"
    };
}

//Switch expression with Tuples
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins",
        ("rock", "scissors") => "Rock wins",
        ("paper", "rock") => "Paper wins",
        ("paper", "scissors") => "Scissors wins",
        ("scissors", "paper") => "Scissors wins",
        ("scissors", "rock") => "Rock wins",
    };
}

// RockPaperScissors using switch expression with Tuples
static string RockPaperScissorsTuple((string first, string second) players)
{
    return players switch
    {
        ("rock", "paper") => "Paper wins",
        ("rock", "scissors") => "Rock wins",
        ("paper", "rock") => "Paper wins",
        ("paper", "scissors") => "Scissors wins",
        ("scissors", "paper") => "Scissors wins",
        ("scissors", "rock") => "Rock wins",
    };
}

    static (string first, string middle, string last) SplitNames(string fullName)
{
    return ("John", "F", "Kennedy");
}

static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}

// Using tuples to return multiple values.
static (int a, string b, bool c) FillTheseValuesUsingTuples()
{
    return (9, "Enjoy your string.", true);
}

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();

struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y) => (X, Y) = (x, y);

    public readonly (int X, int Y) Deconstruct() => (X, Y);
    public readonly void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
}