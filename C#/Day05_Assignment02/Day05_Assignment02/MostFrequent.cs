using System;

namespace Day05_Assignment02;

public static class FindMostFrequent
{
    public static void MostFrequent()
    {
        Console.WriteLine("Enter integers separated by space:");
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(input, int.Parse);

        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Count occurrences of each number
        foreach (int number in numbers)
        {
            if (frequencyMap.ContainsKey(number))
            {
                frequencyMap[number]++;
            }
            else
            {
                frequencyMap[number] = 1;
            }
        }

        // Find the number with the highest frequency
        int maxFrequency = frequencyMap.Values.Max();
        List<int> mostFrequentNumbers = frequencyMap.Where(kv => kv.Value == maxFrequency)
                                                    .Select(kv => kv.Key)
                                                    .ToList();

        // Print the result
        if (mostFrequentNumbers.Count == 1)
        {
            int mostFrequentNumber = mostFrequentNumbers.First();
            Console.WriteLine($"The number {mostFrequentNumber} is the most frequent (occurs {maxFrequency} times)");
        }
        else
        {
            Console.Write("The numbers ");
            for (int i = 0; i < mostFrequentNumbers.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(mostFrequentNumbers[i]);
            }
            Console.WriteLine($" have the same maximal frequency (each occurs {maxFrequency} times). " +
                              $"The leftmost of them is {mostFrequentNumbers.First()}");
        }
    }
}