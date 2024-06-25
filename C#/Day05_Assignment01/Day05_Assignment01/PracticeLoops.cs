using System;

namespace Day05_Assignment01;

public static class PracticeLoops
{
    public static void Loops (){
        //int max = 500;
        //for (byte i = 0; i < max; i++) {
        //    Console.WriteLine(i);
        //}

        // This is an infinite loop because the max value of byte i is 255, it
        // will never reach 500


        int max = 500;
        byte previous = 0;
        for (byte i = 0; i < max; i++)
        {
            // Check for overflow
            if (i < previous)
            {
                Console.WriteLine("Warning: Overflow detected!");
                break;
            }
            Console.WriteLine(i);
            previous = i;
        }
    }
}
