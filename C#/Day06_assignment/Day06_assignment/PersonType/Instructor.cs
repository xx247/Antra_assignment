using System;


namespace Day06_assignment.PersonType;

public class Instructor : Person
{
    private string subject;
    private decimal salary;

    public string Subject
    {
        get { return subject; }
        private set
        {
            if (!string.IsNullOrEmpty(value))
                subject = value;
            else
                throw new ArgumentException("Subject cannot be empty");
        }
    }
    public decimal Salary
    {
        get { return salary; }
        private set
        {
            if (value >= 0)
                salary = value;
            else
                throw new ArgumentException("Salary cannot be negative");
        }
    }

    public Instructor(string name,int age, string subject, decimal salary)
    {
        Name = name;
        Age = age;
        Subject = subject;
        Salary = salary;
    }
    public override void Behavior()
    {
        Console.WriteLine($"{Name} is teaching {Subject}.");
    }

    public override decimal CalSalary()
    {
        return Salary;
    }
}