Console.WriteLine("***** Ref and Value Type Params *****");


Console.WriteLine("\nPassing Person object by value\n");
// Create a Person object and assign values.\
Person fred = new Person("Fred", 12);
Console.WriteLine("\nBefore by value call, Person is:");
fred.Display();

SendAPersonByValue(fred);
Console.WriteLine("\nAfter by value call, Person is:");
fred.Display();

Console.WriteLine("\nPassing Person object by ref\n");

// Create a Person object and assign values.
Person mel = new("Mel", 23);
Console.WriteLine("\nBefore by ref call, Person is:");
mel.Display();

SendPersonByRef(ref mel);

Console.WriteLine("\nAfter by ref call, Person is:");
mel.Display();



Console.WriteLine("Press any key to exit.");
Console.ReadKey();

static void SendAPersonByValue(Person p)
{
    // Change the age of "p"?
    p.personAge = 99;
    // Will the caller see this reassignment?
    p = new Person("Nikki", 99);
}

static void SendPersonByRef(ref Person p)
{
    p.personAge = 555;

    // P is now pointing to a new object on the heap!
    p = new Person("Nikki", 999);
}

class Person
{
    public string personName;
    public int personAge;

    public Person(string name, int age)
    {
        personName = name;
        personAge = age;
    }

    public Person() { }

    public void Display()
    {
        Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
    }
}