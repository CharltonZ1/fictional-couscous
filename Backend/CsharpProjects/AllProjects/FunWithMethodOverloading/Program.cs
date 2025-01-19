using static FunWithMethodOverloading.AddOperations;

Console.WriteLine("***** Fun with Method Overloading *****\n");

// Calls int version of Add()
Console.WriteLine(Add(10, 10));

// Calls long version of Add()
Console.WriteLine(Add(Add(9000000000000000000, 9000000000000000000), 9000000000000000000));

// Calls double version of Add()

Console.WriteLine(Add(4.3, 4.4));

Console.WriteLine("Press any key to exit.");
Console.ReadKey();