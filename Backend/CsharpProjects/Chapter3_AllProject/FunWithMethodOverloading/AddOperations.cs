namespace FunWithMethodOverloading;

public static class AddOperations
{
    // Overloaded Add() method.

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static long Add(long a, long b)
    {
        return a + b;
    }

    public static int Add(int a, int b, int c = 0)
    {
        return a + b + c;
    }
}