using System;

namespace Day05_Assignment02;

public static class FindsLongestSequence
{
    public static void LongestSequence()
    {
        Console.WriteLine("Enter integers separated by space:");
        string[] input = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(input, int.Parse);

        int longestStart = 0; // Starting index of the longest sequence
        int longestLength = 1; // Length of the longest sequence found so far
        int currentStart = 0; // Starting index of the current sequence
        int currentLength = 1; // Length of the current sequence

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    longestStart = currentStart;
                }

                // Reset current sequence tracking
                currentStart = i;
                currentLength = 1;
            }
        }

        // Check the last sequence
        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            longestStart = currentStart;
        }

        // Print the longest sequence
        Console.Write("Longest sequence of equal elements: ");
        for (int i = longestStart; i < longestStart + longestLength; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

