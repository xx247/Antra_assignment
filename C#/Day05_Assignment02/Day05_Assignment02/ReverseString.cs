using System;

namespace Day05_Assignment02;

public static class ReverseStrings
{
    public static void ReverseStringUsingChar()
    {
        Console.WriteLine("Inout a string:");
        string input = Console.ReadLine();

        char[] chararray = input.ToCharArray();
        Array.Reverse(chararray);
        string reversedString = new string(chararray);

        Console.WriteLine("Reversed string using char array:");
        Console.WriteLine(reversedString);
    }

    public static void ReverseStringUsingForLoop()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Method 2: Print letters in back direction using a for-loop
        Console.WriteLine("Reversed string using for loop:");
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }
}
