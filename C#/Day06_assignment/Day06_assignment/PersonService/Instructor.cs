using System;

namespace Day06_assignment.PersonService.Interfaces;

using Day06_assignment.PersonService;

public class Instructor : Person, IInstructorService
{
    private Department department;
    private DateTime joinDate;

    public Department Department
    {
        get { return department; }
        private set { department = value; }
    }

    public DateTime JoinDate
    {
        get { return joinDate; }
        set { joinDate = value; }
    }

    public void AssignDepartment(Department department)
    {
        this.department = department;
    }

    public int CalculateYearsOfExperience(DateTime joinDate)
    {
        var today = DateTime.Today;
        var years = today.Year - joinDate.Year;
        if (joinDate.Date > today.AddYears(-years)) years--;
        return years;
    }

    public override decimal CalculateSalary()
    {
        int experienceYears = CalculateYearsOfExperience(joinDate);
        decimal bonus = experienceYears * 500; // Example bonus calculation
        return Salary + bonus;
    }
}
