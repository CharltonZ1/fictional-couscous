Console.WriteLine("***** C# App *****");
Console.WriteLine("Hello World!");
Console.WriteLine("******************");

// Different ways to iterate through command line arguments
//foreach (string arg in args)
//{
//    Console.WriteLine($"Arg: {arg}");
//}

//for (int i = 0; i < args.Length; i++)
//{
//    Console.WriteLine($"Arg: {args[i]}");
//}
//string[] theArgs = Environment.GetCommandLineArgs();
//foreach (string arg in theArgs)
//{
//    Console.WriteLine($"Arg: {arg}");
//}

// Local method within the Top-level statements.
ShowEnvironmentDetails();

Console.WriteLine("Press Enter key to exit...");
Console.ReadLine();

return 0;

static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    // and other details
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine($"Drive: {drive}");
    }
    Console.WriteLine($"OS: {Environment.OSVersion}");
    Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
    Console.WriteLine(".NET Version: {0}", Environment.Version);
}