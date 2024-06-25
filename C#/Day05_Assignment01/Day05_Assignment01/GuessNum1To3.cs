using System;

namespace Day05_Assignment01;

public static class GuessNum
{
    public static void Guess()
    {
        int correctNumber = new Random().Next(3) + 1;
        //Console.WriteLine(correctNumber);

        int guessedNumber = 0;
        while (guessedNumber != correctNumber)
        {
            Console.WriteLine("Please enter guess number:");
            guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Out of range");
            }
            if (guessedNumber < correctNumber)
            {
                Console.WriteLine("guess low");
            }
            if (guessedNumber > correctNumber)
            {
                Console.WriteLine("guess high");
            }
            if (guessedNumber == correctNumber)
            {
                Console.WriteLine("you are right!");
                break;
            }

        }
    }
}
