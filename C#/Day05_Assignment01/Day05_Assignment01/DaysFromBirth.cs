using System;
using System.Reflection.PortableExecutable;

namespace Day05_Assignment01;

public static class DaysFromBirth
{
    public static void Days()
    {
        // Define a variable for the birth date
        DateTime birthDate = new DateTime(1990, 1, 1);
        DateTime currentDate = DateTime.Now;

        // Calculate the number of days old
        TimeSpan ageSpan = currentDate - birthDate;
        int daysOld = (int)ageSpan.TotalDays;

        // Output the number of days old
        Console.WriteLine($"You are {daysOld} days old.");

        // Calculate the days until the next 10,000-day anniversary
        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversaryDate = currentDate.AddDays(daysToNextAnniversary);

        // Output the date of the next 10,000-day anniversary
        Console.WriteLine($"Your next 10,000-day anniversary is on {nextAnniversaryDate.ToShortDateString()}.");
    }
}
