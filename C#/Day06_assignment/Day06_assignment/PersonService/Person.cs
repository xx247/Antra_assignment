using Day06_assignment.PersonService.Interfaces;
using System;


namespace Day06_assignment.PersonService;

public abstract class Person : IPersonService
{
    private string name;
    private DateTime birthDate;
    private decimal salary;
    private List<string> addresses = new List<string>();

    public string Name
    {
        get { return name; }
        protected set
        {
            if (!string.IsNullOrEmpty(value)) name = value;
            else throw new ArgumentException("Name can not be empty");
        }
    }

    public DateTime BirthDate
    {
        get { return birthDate; }
        protected set { birthDate = value; }
    }

    public decimal Salary
    {
        get { return salary; }
        protected set
        {
            if (value >= 0) salary = value;
            else throw new ArgumentException("Salary can not be negative");
        }
    }

    public List<string> GetAddresses()
    {
        return addresses;
    }

    public void AddAddresses(string address)
    {
        if (!string.IsNullOrEmpty(address)) addresses.Add(address);
        else throw new ArgumentException("Address cannot be empty");

    }

    public int CalculateAge(DateTime birthDate)
    {
        var today = DateTime.Today;
        var age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age)) age--;
        return age;
    }

    public virtual decimal CalculateSalary()
    {
        return salary;
    }
}
