Console.WriteLine("***** Fun with type conversions *****");

// Add two shorts, and print the result.
//short numb1 = 9, numb2 = 10;
//Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));

// Compile error!. Narrowing always results in a compile error.
//short numb1 = 30000, numb2 = 30000;
//short answer = Add(numb1, numb2);

// Explicitly cast the int to a short (and it may lose data).
// Narrowing always requires a cast like in the next example.
short numb1 = 30000, numb2 = 30000;
short answer = (short)Add(numb1, numb2);
Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);

NarrowingAttempt();
//ProcessBytes();
//ProcessBytesChecked();

Console.WriteLine();
Console.WriteLine("Press Enter to close...");
Console.ReadLine();

static int Add(int x, int y) => x + y;

// Another compile error!
//static void NarrowingAttempt()
//{
//    byte myByte = 0;
//    int myInt = 200;
//    myByte = myInt;
//    Console.WriteLine("Value of myByte: {0}", myByte);
//}

static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;
    myByte = (byte)myInt;
    Console.WriteLine("Value of myByte: {0}", myByte);
}

//static void ProcessBytes()
//{
//    byte b1 = 100;
//    byte b2 = 250;
//    byte sum = (byte)Add(b1, b2);

//    Console.WriteLine("sum = {0}", sum);
//}

//static void ProcessBytesChecked()
//{
//    byte b1 = 100;
//    byte b2 = 250;
//    try
//    {
//        checked
//        {
//            byte sum = (byte)Add(b1, b2);
//            Console.WriteLine("sum = {0}", sum);
//        }
//    }
//    catch (OverflowException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
}

// OverflowException! can be enabled on a project so that it is automatically checked at runtime. 
// To allow overflow, use the unchecked keyword.