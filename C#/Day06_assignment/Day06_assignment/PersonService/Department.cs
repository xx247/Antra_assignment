using Day06_assignment.PersonService.Interfaces;
using System;

namespace Day06_assignment.PersonService;

public class Department : IDepartmentService
{
    private string departmentName;
    private Instructor headInstructor;
    private List<Course> courses = new List<Course>();
    private decimal budget;
    private DateTime startDate;
    private DateTime endDate;

    public string DepartmentName
    {
        get { return departmentName; }
        private set
        {
            if (!string.IsNullOrEmpty(value))
                departmentName = value;
            else
                throw new ArgumentException("Department name cannot be empty");
        }
    }

    public decimal Budget
    {
        get { return budget; }
        private set
        {
            if (value >= 0)
                budget = value;
            else
                throw new ArgumentException("Budget cannot be negative");
        }
    }

    public DateTime StartDate
    {
        get { return startDate; }
        private set { startDate = value; }
    }

    public DateTime EndDate
    {
        get { return endDate; }
        private set { endDate = value; }
    }

    public Department(string departmentName, decimal budget, DateTime startDate, DateTime endDate)
    {
        DepartmentName = departmentName;
        Budget = budget;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void SetHeadInstructor(Instructor instructor)
    {
        headInstructor = instructor;
    }

    public List<Course> GetCourses()
    {
        return courses;
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public decimal GetBudget()
    {
        return Budget;
    }
}

