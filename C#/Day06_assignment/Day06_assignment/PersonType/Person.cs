using Day06_assignment.PersonType;
using System;


namespace Day06_assignment.PersonType;

public abstract class Person
{
    public string Name { get; set; }

    public int Age {  get; set; }

    public abstract void Behavior();

    // Virtual method for salary calculation
    public virtual decimal CalSalary()
    {
        return 0;
    }
}
