namespace SimpleClassExample;

public class Car
{
    // The 'state' of the Car.
    public string petName;
    public int currSpeed;

    // A custom default constructor.
    public Car()
    {
        petName = "Chuck";
        currSpeed = 10;
    }

    // Let the caller set the full state of the Car.
    public Car(string name, int speed)
    {
        petName = name;
        currSpeed = speed;
    }

    // Out parameter example.
    public Car(string name, int speed, out bool inDanger)
    {
        petName = name;
        currSpeed = speed;

        if (currSpeed > 65)
        {
            inDanger = true;
        }
        else
        {
            inDanger = false;
        }
    }

    // Here teh currSpeed will receive the default value of an int (0).
    public Car(string name) => petName = name;

    // The 'behavior' of the Car.
    // Using the expression-bodied member syntax.
    public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed} KM/H.");

    public void SpeedUp(int delta) => currSpeed += delta;
}
