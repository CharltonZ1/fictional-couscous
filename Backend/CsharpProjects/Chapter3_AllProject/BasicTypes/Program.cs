using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

Console.WriteLine("***** Fun with Basic Data Types *****");

LocalVarDeclarations();
DefaultDeclarations();
NewingDataTypes();
ObjectFunctionality();
DataTypeFunctionality();
CharFunctionality();
ParseFromStrings();
ParseFromStringWithTryParse();
UseDatesAndTimes();
UseBigInteger();
DigitSeperators();
BinaryLiterals();
BasicStringFunctionality();
StringConcatenation();
EscapeCharacters();
StringInterpolation();
StringInterpolationWithDefaultInterpolatedStringHandler();
StringEquality();
StringEqualitySpecifyingCompareRules();
StringsAreImmutable();
StringsAreImmutable2();
FunWithStringBuilder();

Console.WriteLine("Press Enter key to continue...");
Console.ReadLine();

static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declarations:");
    // Local variables are declared as so:
    // dataType varName = initialValue;
    int myInt = 0;
    string myString = "This is a string of unicode characters.";

    // Declare three bools on a single line.
    bool b1 = true, b2 = false, b3 = b1;

    // Use System.Boolean data type to declare a bool.
    System.Boolean b4 = false;

    Console.WriteLine("Data: {0}, {1}, {2}, {3}, {4}", myInt, myString, b1, b2, b3);
    Console.WriteLine();
}

static void DefaultDeclarations()
{
    Console.WriteLine("=> Default Declarations:");
    int myInt = default;
    Console.WriteLine("Default value for myInt is: {0}", myInt);
    Console.WriteLine();
}

static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new(); // Set to false. Simplified syntax. vs . bool b = new bool();
    int i = new(); // Set to 0. vs. int i = new int();
    double d = new(); // Set to 0. vs. double d = new double();
    DateTime dt = new(); // Set to 1/1/0001 12:00:00 AM. vs. DateTime dt = new DateTime();

    Console.WriteLine("bool b = new() is {0}", b);
    Console.WriteLine("int i = new() is {0}", i);
    Console.WriteLine("double d = new() is {0}", d);
    Console.WriteLine("DateTime dt = new() is {0}", dt);
    Console.WriteLine();
}

static void ObjectFunctionality()
{
    Console.WriteLine("=> System.Object Functionality:");
    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(13) = {0}", 12.Equals(13));
    Console.WriteLine("12.ToString() = {0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}

static void DataTypeFunctionality()
{
    Console.WriteLine("=> Data Type Functionality:");

    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}, double.MaxValue");
    Console.WriteLine("Min of double: {0}, double.MinValue");
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
    Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
    Console.WriteLine();
}

static void CharFunctionality()
{
    Console.WriteLine("=> Char Type Functionality:");
    char myChar = 'a';
    Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
    Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation(myChar));
    Console.WriteLine();
}

static void ParseFromStrings()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("110,10");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("10");
    Console.WriteLine("Value of i: {0}", i);
    char c = Char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();
}

static void ParseFromStringWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse:");
    if (bool.TryParse("True", out bool b))
    {
        Console.WriteLine("Value of b: {0}", b);
    }
    else
    {
        Console.WriteLine("Default value of b: {0}", b);
    }

    string value = "text";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine("Value of d: {0}", d);
    }
    else
    {
        Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d);
    }

    Console.WriteLine();
}

static void UseDatesAndTimes()
{
    Console.WriteLine("=> Dates and Times");

    // This constructor takes (year, month, day).
    DateTime dt = new(2021, 10, 17);


    // What day of the month is this?
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

    // Month is now December.
    dt.AddMonths(2);
    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

    // This constructor takes (hours, minutes, seconds).
    TimeSpan ts = new(4, 30, 0);
    Console.WriteLine(ts);

    // Subtract 15 minutes from the current TimeSpan and
    // print the result.
    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

    // Date Only
    DateOnly dateOnly = new(2021, 10, 17);
    Console.WriteLine(dateOnly);

    // Time Only
    TimeOnly timeOnly = new(16, 30);
    Console.WriteLine(timeOnly);

    Console.WriteLine();
}

static void UseBigInteger()
{
    Console.WriteLine("=> Use BigInteger:");
    BigInteger biggy = BigInteger.Parse("999999999999999999999999999999999999999999999999");
    Console.WriteLine("Value of biggy is {0}", biggy);
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
    BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888888888888"));
    Console.WriteLine("Value of reallyBig is {0}", reallyBig);
    Console.WriteLine();
}

static void DigitSeperators()
{
    Console.WriteLine("=> Use Digit Seperators:");
    Console.WriteLine("Integer:");
    Console.WriteLine(123_456);
    Console.WriteLine("Long:");
    Console.WriteLine(123_456_789L);
    Console.WriteLine("Float:");
    Console.WriteLine(123_456.12F);
    Console.WriteLine("Double:");
    Console.WriteLine(123_456.12);
    Console.WriteLine("Decimal:");
    Console.WriteLine(123_456.12M);
    Console.WriteLine("Hex:");
    Console.WriteLine(0x00_00_FF_FF);
    Console.WriteLine();
}


static void BinaryLiterals()
{
    Console.WriteLine("=> Use Binary Literals:");
    Console.WriteLine("Sixteen: {0}", 0b0001_0000);
    Console.WriteLine("Thirty Two: {0}", 0b0010_0000);
    Console.WriteLine();
}

static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String Functionality:");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains('y'));
    Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
    Console.WriteLine();
}

static void StringConcatenation()
{
    Console.WriteLine("=> String Concatenation:");
    string s1 = "First half of the sentence";
    string s2 = "; second half of the sentence";
    string s3 = s1 + s2;
    string s4 = String.Concat(s1, s2);

    Console.WriteLine("Result of concatenation using +: {0}", s3);
    Console.WriteLine("Result of concatenation using String.Concat: {0}", s4);
    Console.WriteLine();
}

static void EscapeCharacters()
{
    Console.WriteLine("=> Escape Characters:");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
    Console.WriteLine(strWithTabs);
    Console.WriteLine("Everyone loves \"Hello World\" ");
    Console.WriteLine("C:\\MyApp\\bin\\Debug ");

    // Adds a total of 4 blank lines (then a beep).
    Console.WriteLine("All finished.\n\n\n\n\a ");

    // Adds 4 more blank lines
    Console.WriteLine("All finished for real this time. {0}{0}{0}{0}", Environment.NewLine);
    Console.WriteLine();
}


static void StringInterpolation()
{
    Console.WriteLine("=> String Interpolation:");
    int age = 4;
    string name = "Soren";

    // Using curly braces.
    string greeting = string.Format("Hello {0} you are {1} years old.", name.ToUpper(), age);
    Console.WriteLine(greeting);

    // Using string interpolation.
    string greeting2 = $"Hello {name.ToUpper()} you are {age} years old.";
    Console.WriteLine(greeting2);
    Console.WriteLine();
}

static void StringInterpolationWithDefaultInterpolatedStringHandler()
{
    Console.WriteLine("=> String Interpolation with Default Interpolated String Handler:");
    int age = 4;
    string name = "Soren";

    var builder = new DefaultInterpolatedStringHandler(3, 2);
    builder.AppendLiteral("Hello ");
    builder.AppendFormatted(name.ToUpper());
    builder.AppendLiteral(" you are ");
    builder.AppendFormatted(age);
    builder.AppendLiteral(" years old.");
    var result = builder.ToStringAndClear();
    Console.WriteLine(result);
}

static void StringEquality()
{
    Console.WriteLine("=> String Equality: ");

    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);

    Console.WriteLine();

    // Test strings for equality
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
}

static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=> String Equality (Case Incensitive):");
    string s1 = "Hello!";
    string s2 = "HELLO!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();

    // Check the results of chaning the default compare rules.
    Console.WriteLine("Default rules: s1={0}, s2={1}, s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));

    // Ignore case.
    Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    // Ignore case, Invriant Culture.
    Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();

    Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
    // Ignore case
    Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
    // Ignore case, Invariant Culture
    Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();
}

static void StringsAreImmutable()
{
    Console.WriteLine("=> Immutable Strings: ");

    // Initial string
    string s1 = "This is my string.";
    Console.WriteLine("s1 = {0}", s1);

    // Uppercase s1?
    string upperString = s1.ToUpper();
    Console.WriteLine("upperString = {0}", upperString);

    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine();
}

static void StringsAreImmutable2()
{
    Console.WriteLine("=> Immutable Strings2: ");

    // Initial string
    string s1 = "This is my other string.";
    Console.WriteLine("s1 = {0}", s1);

    Console.WriteLine("Reassign our initial string, s1 = New string");
    Console.WriteLine("s1 = {0}", s1 = "New string");
    Console.WriteLine();
}

static void FunWithStringBuilder()
{
    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
    sb.Append("\n");
    sb.AppendLine("Half Life");
    sb.AppendLine("Morrowind");
    sb.AppendLine("Deus Ex" + "2");
    sb.AppendLine("System Shock");
    Console.WriteLine(sb.ToString());
    sb.Replace("2", " Invisible War");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has {0} chatrs.", sb.Length);
    Console.WriteLine();
}