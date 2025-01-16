

Console.WriteLine("***** Fun with Value and Ref Types *****\n");

ValueTypesAssignment();
RefTypesAssignment();
ValueTypeContainingRefType();


Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();


static void ValueTypesAssignment()
{
    Console.WriteLine("Assigning value types:\n");

    Point p1 = new(10, 10, "P1");
    Point p2 = p1;

    p1.Display();
    p2.Display();

    p1.X = 100;
    Console.WriteLine("\n=> Changed p1.X = 100\n");
    p1.Display();
    p2.Display();
}

static void RefTypesAssignment()
{
    Console.WriteLine("Assigning reference types:\n");
    PointRef p1 = new(10, 10, "P1");
    PointRef p2 = p1;
    p1.Display();
    p2.Display();
    p1.X = 100;
    Console.WriteLine("\n=> Changed p1.X = 100\n");
    p1.Display();
    p2.Display();
}

static void ValueTypeContainingRefType()
{
    Console.WriteLine("=> Creating rl");
    Rectangle rl = new(10, 10, "Rect1", "This is your rectangle");

    Console.WriteLine("=> Assigning r2 to rl");
    Rectangle r2 = rl;

    Console.WriteLine("=> Changing values of r2");
    r2.RectInfo.Info = "This is new info";
    r2.X = 100;

    rl.Display();
    r2.Display();
}

struct Point(int x, int y, string n)
{
    public int X = x;
    public int Y = y;
    public string Name = n;

    public void Increment()
    {
        X++; Y++;
    }

    public void Decrement()
    {
        X--; Y--;
    }

    public readonly void Display()
    {
        Console.WriteLine("Value of X: {0}, Value of Y: {1}", X, Y);
    }
}

class PointRef(int x, int y, string n)
{
    public int X = x;
    public int Y = y;
    public string Name = n;

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
        Console.WriteLine("Value of X: {0}, Value of Y: {1}", X, Y);
    }
}

class ShapeInfo(string info)
{
    public string Info = info;
}

struct Rectangle(int x, int y, string n, string info)
{
    public int X = x;
    public int Y = y;
    public string Name = n;
    public ShapeInfo RectInfo = new(info);
    public readonly void Display()
    {
        Console.WriteLine("Value of X: {0}, Value of Y: {1}", X, Y);
        Console.WriteLine("Value of Name: {0}", Name);
        Console.WriteLine("Value of Info: {0}", RectInfo.Info);
    }
}