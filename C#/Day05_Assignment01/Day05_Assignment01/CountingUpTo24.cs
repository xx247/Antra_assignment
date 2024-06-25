using System;

namespace Day05_Assignment01;

public static class CountingUpTo24
{
    public static void CountingTo24()
    {
        for (int increment = 1; increment <= 4; increment++)
        {

            // Inner loop to count from 0 to 24 with the current increment
            for (int i = 0; i <= 24; i += increment)
            {

                if (i == 24)
                {
                    Console.WriteLine(i);
                    break;
                }

                Console.Write(i + ", ");
            }

            // Move to the next line after finishing the count for the current increment
            Console.WriteLine();
        }
    }
}
