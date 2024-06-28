using System;
using System.Diagnostics;


namespace Day06_assignment.PersonType;

public class Students : Person
{
    private int gradeLevel;

    public int GradeLevel
    {
        get { return gradeLevel; }
        private set
        {
            if (value >= 1 && value <= 12)
                gradeLevel = value;
            else
                throw new ArgumentException("Grade level must be between 1 and 12");
        }
    }

    public Students(string name, int age, int gradeLevel)
    {
        Name = name; Age = age; GradeLevel = gradeLevel;
    }

    public override void Behavior()
    {
        Console.WriteLine($"{Name} is studying for exams.");
    }

}
