using System;

namespace Day05_Assignment02;

public static class CopyAnArray
{
    public static void CopyArray()
    {
        int[] initialArray = new int[10];
        for (int i = 0; i < initialArray.Length; i++)
        {
            initialArray[i] = i + 1;
        }
        
        int[] copiedArray = new int [initialArray.Length];

        for (int i = 0; i < copiedArray.Length; i++)
        {
            copiedArray[i] = initialArray[i];
        }

        Console.WriteLine("Original Array:");
        foreach (int item in initialArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nCopied Array:");
        foreach (int item in copiedArray)
        {
            Console.Write(item + " ");
        }
    }
}
