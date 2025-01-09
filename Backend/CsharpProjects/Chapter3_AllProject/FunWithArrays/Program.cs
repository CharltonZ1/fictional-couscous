Console.WriteLine("***** Fun with Arrays");

SimpleArrays();
ArrayInitialization();
DeclareImplicitArray();
ArrayOfObjects();
RectMultidimensionalArray();
JaggedMultidimensionalArray();
PassAndReceiveArrays();
SystemArrayFunctionality();
IndexesAndRanges();

Console.WriteLine("Press any key to continue...");
Console.ReadKey();

static void SimpleArrays()
{
    Console.WriteLine("=> Simple Array Creation.");
    int[] ints = new int[3];
    ints[0] = 1;
    ints[1] = 2;
    ints[2] = 3;

    foreach (int i in ints)
    {
        Console.WriteLine(i);
    }

    string[] strings = ["Hello", "World", "From", "C#"];
    foreach (string s in strings)
    {
        Console.WriteLine(s);
    }

    Console.WriteLine();
}

static void ArrayInitialization()
{
    Console.WriteLine("=> Array Initialization.");

    // Array initialization syntax using the new keyword.
    string[] stringArray = new string[] { "one", "two", "three" };
    Console.WriteLine("stringArray has {0} elements", stringArray.Length);

    // Array initialization without the new keyword
    bool[] bools = { false, false, true };
    Console.WriteLine("bools has {0} elements", bools.Length);

    // Array initialization with new keyword and size.
    int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
    Console.WriteLine("numbers has {0} elements", numbers.Length);

    Console.WriteLine();
}

static void DeclareImplicitArray()
{
    Console.WriteLine("=> Implicit Array Initialization.");

    // a is really int[]
    var a = new[] { 1, 10, 100, 1000 };
    Console.WriteLine("a is a: {0}", a.ToString());

    // b is really double[]
    var b = new[] { 1, 1.5, 3.4, 1000 };
    Console.WriteLine("b is a: {0}", b.ToString());

    // c is really string[]
    var c = new[] { "hello", null, "world" };
    Console.WriteLine("c is a {0}", c.ToString());

    Console.WriteLine();
}


static void ArrayOfObjects()
{
    Console.WriteLine("=> Array of Objects.");

    // An array of objects can contain anything.
    object[] objects = new object[4];
    objects[0] = 10;
    objects[1] = false;
    objects[2] = new DateTime(1969, 3, 24);
    objects[3] = "Hello";

    foreach (object obj in objects)
    {
        Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
    }

    Console.WriteLine();
}

static void RectMultidimensionalArray()
{
    Console.WriteLine("=> Rectangular Multidimensional Array.");

    // A rectangular MD array.
    int[,] myMatrix;
    myMatrix = new int[3, 4];

    // Populate (3 * 4) array.
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 4; col++)
        {
            myMatrix[row, col] = row * col;
        }
    }

    // Print (3 * 4) array.
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 4; col++)
        {
            Console.Write(myMatrix[row, col] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

static void JaggedMultidimensionalArray()
{
    Console.WriteLine("=> Jagged Multidimensional Array.");
    // A jagged MD array (i.e., an array of arrays)
    int[][] myJagArray = new int[5][];

    for (int i = 0; i < myJagArray.Length; i++)
    {
        myJagArray[i] = new int[i + 7];
    }

    // Print each row.
    for (int i = 0; i < myJagArray.Length; i++)
    {
        for (int j = 0; j < myJagArray[i].Length; j++)
        {
            Console.Write(myJagArray[i][j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

static void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Item {0} is {1}", i, arr[i]);
    }
}

static string[] GetStringArray()
{
    string[] strings = { "one", "two", "three", "four", "five" };
    return strings;
}

static void PassAndReceiveArrays()
{
    Console.WriteLine("=> Arrays as params and return values");

    // Pass array as parameter.
    int[] ages = { 20, 22, 23, 0 };
    PrintArray(ages);

    // Get array as return value.
    string[] strs = GetStringArray();
    foreach (string s in strs)
    {
        Console.WriteLine(s);
    }

    Console.WriteLine();
}

static void SystemArrayFunctionality()
{
    Console.WriteLine("=> Working with System.Array");
    string[] strings = GetStringArray();

    Console.WriteLine("-> Here is the array:");
    for (int i = 0; i < strings.Length; i++)
    {
        Console.Write("{0} ", strings[i]);
    }
    Console.WriteLine("\n");

    // Reverse them in place.
    Array.Reverse(strings);
    Console.WriteLine("-> The reversed array:");
    for (int i = 0; i < strings.Length; i++)
    {
        Console.Write("{0} ", strings[i]);
    }

    Console.WriteLine("\n");

    // Clear out all but the first two elements.
    Array.Clear(strings, 2, strings.Length - 2);
    Console.WriteLine("-> Cleared out all but the first two elements:");
    for (int i = 0; i < strings.Length; i++)
    {
        Console.Write("{0} ", strings[i]);
    }

    Console.WriteLine();
}


// Indexes and Ranges
static void IndexesAndRanges()
{
    Console.WriteLine("=> System.Index and System.Range");

    string[] arr = new string[]
    {
        "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"
    };

    for (int i = 0; i < arr.Length; i++)
    {
        Index idx = i;
        Console.Write($"{arr[idx]} ");
    }

    Console.WriteLine('\n');

    for (int i = 1; i <= arr.Length; i++)
    {
        Index idx = ^i;
        Console.Write($"{arr[idx]} ");
    }

    Console.WriteLine('\n');

    for (int i = 2; i < arr.Length; i++)
    {
        Range r = 1..4;
        string[] words = arr[r];
        foreach (string word in words)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

}