using System;

namespace Day05_Assignment02;

public static class RotateArrays
{
    public static void RotateArray()
    {
        Console.WriteLine("Enter int seperated by space:");
        string[] input = Console.ReadLine().Split(' ');

        int[] array = Array.ConvertAll(input, int.Parse);

        Console.WriteLine("Enter k (number of rotations):");
        int k = int.Parse(Console.ReadLine());

        Rotate(array,k);
    }

    static void Rotate(int[] array, int k)
    {
        int n = array.Length;
        int[] sum = new int[n];

        for(int r = 1; r <= k; r++)
        {
            int[] rotated = new int[n];

            for (int i= 0; i < n; i++)
            {
                rotated[(i + r) % n] = array[i];
            }

            for (int i = 0; i < n; i++)
            {
                sum[i] += rotated[i];
            }
            Console.WriteLine($"rotated{r}[] = " + string.Join(" ", rotated));
        }

        Console.WriteLine("sum[] = " + string.Join(" ", sum));
    }
}