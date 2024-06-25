using System;

namespace Day05_Assignment01;

public static class PrintPyramid
{
    public static void Pyramid()
    {
        // Number of rows for the pyramid
        int numberOfRows = 5;

        for (int i = 1; i <= numberOfRows; i++)
        {
            // Print spaces
            for (int j = 1; j <= numberOfRows - i; j++)
            {
                Console.Write(" ");
            }

            // Print asterisks
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            // Move to the next line after printing each row
            Console.WriteLine();
        }
    }
}
