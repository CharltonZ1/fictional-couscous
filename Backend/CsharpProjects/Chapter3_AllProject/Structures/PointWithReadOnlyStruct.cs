namespace Structures;

struct PointWithReadOnly
{
    // Fields of the structure
    public int X;
    public readonly int Y;
    public readonly string Name;

    // Display the current position and name
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}, Name = {2}", X, Y, Name);
    }

    // Constructor
    public PointWithReadOnly(int XPos, int YPos, string Name)
    {
        X = XPos;
        Y = YPos;
        this.Name = Name;
    }
}