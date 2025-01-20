using SimpleClassExample;

Console.WriteLine("***** Fun with Class Types *****\n");

// Allocate and configure a Car object.
Car myCar = new();

myCar.petName = "Henry";
myCar.currSpeed = 10;

// Speed up the car a few times and print out
// the new stat

for (int i = 0; i < 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}

Car chuck = new();
chuck.PrintState();

// Make a Car called Mary going 0 KM/H.
Car mary = new("Mary");
mary.PrintState();

// Make a Car called Daisy going 75 KM/H.
Car daisy = new("Daisy", 75);
daisy.PrintState();

Motorcycle m = new(5);
m.SetDriverName("Tiny");
m.PopAWheely();
Console.WriteLine("Rider name is {0}", m.driverName);

MakeSomeBikes();

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();


static void MakeSomeBikes()
{
    // driverName = "", driverIntensity = 0
    Motorcycle m1 = new();
    Console.WriteLine("Name= {0}, Intensity= {1}", m1.driverName, m1.driverIntensity);
    // driverName = "Tiny", driverIntensity = 0
    Motorcycle m2 = new("Tiny");
    Console.WriteLine("Name= {0}, Intensity= {1}", m2.driverName, m2.driverIntensity);
    // driverName = "", driverIntensity = 7
    Motorcycle m3 = new(7);
    Console.WriteLine("Name= {0}, Intensity= {1}", m3.driverName, m3.driverIntensity);
}