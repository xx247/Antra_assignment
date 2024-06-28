using System;


namespace Day06_assignment;

public static class ReverseArray
{
    public static void Reverse()
    {
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    private static int[] GenerateNumbers()
    {
        return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }

    private static void Reverse(int[] numbers)
    {
        int start = 0;
        int end = numbers.Length - 1;

        while (start < end)
        {
            int temp = numbers[start];
            numbers[start] = numbers[end];
            numbers[end] = temp;

            start++;
            end--;
        }
    }

    private static void PrintNumbers(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

