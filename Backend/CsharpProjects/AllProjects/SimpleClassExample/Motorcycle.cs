namespace SimpleClassExample;

public class Motorcycle
{
    public int driverIntensity;
    public string driverName;

    //public Motorcycle() { }

    //public Motorcycle(int intensity)
    //    : this(intensity, "") 
    //{
    //    Console.WriteLine("In constructor taking an int");
    //}

    //public Motorcycle(string name)
    //    : this(0, name)
    //{
    //    Console.WriteLine("In constructor taking a string");
    //}


    // With named parameters and default values. 
    // The same can be achieved with the previous constructors.
    // But this way is more readable and maintainable.
    public Motorcycle(int intensity = 0, string name = "")
    {
        Console.WriteLine("In constructor taking an int and a string");
        if (intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
        driverName = name;
    }

    public void PopAWheely()
    {
        for (int i = 0; i <= driverIntensity; i++)
        {
            Console.WriteLine("YEEEEEE HAAAEEWW!");
        }
    }

    public void SetDriverName(string name) => driverName = name;

}
