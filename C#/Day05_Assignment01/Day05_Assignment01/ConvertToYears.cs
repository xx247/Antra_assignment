using System;

namespace Day05_Assignment01;

public static class ConvertToyears
{
    public static void Convert()
    {
        Console.Write("Enter number of centuries: ");
        int centuries = int.Parse(Console.ReadLine());
        Console.WriteLine("Input:" + centuries);

        const int YearsPerCentury = 100;
        const int DaysPerYear = 365;
        const int HoursPerDay = 24;
        const int MinutesPerHour = 60;
        const int SecondsPerMinute = 60;
        const long MillisecondsPerSecond = 1000;
        const long MicrosecondsPerMillisecond = 1000;
        const long NanosecondsPerMicrosecond = 1000;

        long years = (long)centuries * YearsPerCentury;
        long days = years * DaysPerYear;
        long hours = days * HoursPerDay;
        long minutes = hours * MinutesPerHour;
        long seconds = minutes * SecondsPerMinute;
        long milliseconds = seconds * MillisecondsPerSecond;
        long microseconds = milliseconds * MicrosecondsPerMillisecond;
        long nanoseconds = microseconds * NanosecondsPerMicrosecond;

        Console.WriteLine("Output:");
        Console.Write($"{centuries} centuries = ");
        Console.Write($"{years} years = ");
        Console.Write($"{days} days = ");
        Console.Write($"{hours} hours = ");
        Console.Write($"{minutes} minutes = ");
        Console.Write($"{seconds} seconds = ");
        Console.Write($"{milliseconds} milliseconds = ");
        Console.Write($"{microseconds} microseconds = ");
        Console.Write($"{nanoseconds} nanoseconds");
    }
}

