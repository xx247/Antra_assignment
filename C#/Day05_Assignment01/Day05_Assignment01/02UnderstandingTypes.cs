using System;

namespace Day05_Assignment01;

public static class UnderstandingTypes
{
    public static void Types()
    {
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
                "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "float", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "double", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("Type: {0, -10} Size: {1, -5} Min: {2, -30} Max: {3}",
            "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }
}

