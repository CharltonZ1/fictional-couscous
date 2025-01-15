using Structures;

Console.WriteLine("***** A First Look at Structures *****\n");

Point myPoint = new(349, 76);
//myPoint.X = 349;
//myPoint.Y = 76;
myPoint.Display();

myPoint.Increment();
myPoint.Display();

PointWithReadOnly p3 = new(50, 60, "Point 3");
p3.Display();

var s = new DisposableRefStruct(10, 20);
s.Display();
s.Dispose();

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();

struct Point
{
    public int X;
    public int Y;

    public Point()
    {
        X = Y = 0;
    }

    public Point(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }

    public void Increment()
    {
        X++; Y++;
    }

    public void Decrement()
    {
        X--; Y--;
    }

    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}

readonly struct ReadOnlyPoint
{
    public int X { get; }
    public int Y { get; }
    public ReadOnlyPoint(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}

ref struct DisposableRefStruct
{
    public int X;
    public readonly int Y;

    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }

    public DisposableRefStruct(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
        Console.WriteLine("Created!");
    }

    public void Dispose()
    {
        Console.WriteLine("Disposed!");
    }
}