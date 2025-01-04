
DeclareImplicitVars();

Console.WriteLine("***** Fun with Implicit Typing *****");

DeclareImplicitVars();
DeclareImplicitNumerics();
ImplicitTypeIsStrongTyping();
LinkQueryOverIntsExample();

Console.WriteLine("Press Enter key to continue...");
Console.ReadLine();

static void DeclareImplicitVars()
{
    // Declare implicit local variables
    var myInt = 0;
    var myBool = true;
    var myString = "Time, marches on...";
    var myArray = new[] { 123, 456, 789 };
    var myDict = new Dictionary<string, int>()
    {
        { "First", 1 },
        { "Second", 2 }
    };

    // Print out the underlying types
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
    Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
    Console.WriteLine("myString is a: {0}", myString.GetType().Name);
    Console.WriteLine("myArray is a: {0}", myArray.GetType().Name);
    Console.WriteLine("myDict is a: {0}", myDict.GetType().Name);
    Console.WriteLine();
}

static void DeclareImplicitNumerics()
{
    var myUInt = 0u;
    var myInt = 0;
    var myLong = 0L;
    var myDouble = 0.5;
    var myFloat = 0.5F;
    var myDecimal = 0.5M;

    // Print out the underlying types
    Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
    Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
    Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
    Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
    Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);
    Console.WriteLine();
}


// Do's and don'ts
// Implicit typing only applies to local variables or property scopes.
// Fields, method parameters, and return types must be explicitly typed.
// Implicitly typed variables must be initialized at the time of declaration. Cannot be null at declaration.
// It is permissible to assign a null value to an implicitly typed variable after its declaration.
// It is also permissible to assign a value of a different type to an implicitly typed variable after during declaration.
// It is also permissible to return an implicitly typed variable from a method.
// Provided the method return type is the same underlying type as the implicitly typed variable.

static void ImplicitTypeIsStrongTyping()
{
    // The compiler knows myInt is a System.Int32.
    var myInt = 0;

    // This would be a compile-time error!
    //myInt = "This is not an int!";
}

static void LinkQueryOverIntsExample()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

    // LINQ query!
    var subset = from i in numbers where i < 10 select i;

    Console.WriteLine("Values in subset: ");
    foreach (var i in subset) Console.WriteLine(i);
    Console.WriteLine();

    // what type is a subset?
    Console.WriteLine("subset is a: {0}", subset.GetType().Name);
    Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
    Console.WriteLine();
}
