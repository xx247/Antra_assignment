using System;

namespace Day05_Assignment01;

public static class FizzBuzz
{
    public static void Fb(int countTo)
    {
        for (int i = 1; i <= countTo; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }
}
