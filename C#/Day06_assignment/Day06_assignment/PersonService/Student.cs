using Day06_assignment.PersonService.Interfaces;
using System;

namespace Day06_assignment.PersonService;

public class Student : Person, IStudentService
{
    private List<Course> courses = new List<Course>();
    private Dictionary<Course, char> grades = new Dictionary<Course, char>();

    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
        course.AddStudent(this);
    }

    public double CalculateGPA()
    {
        // Simple GPA calculation (A=4, B=3, C=2, D=1, F=0)
        double totalPoints = 0;
        int totalCourses = grades.Count;

        foreach (var grade in grades.Values)
        {
            switch (grade)
            {
                case 'A':
                    totalPoints += 4;
                    break;
                case 'B':
                    totalPoints += 3;
                    break;
                case 'C':
                    totalPoints += 2;
                    break;
                case 'D':
                    totalPoints += 1;
                    break;
                case 'F':
                    totalPoints += 0;
                    break;
            }
        }

        return totalCourses > 0 ? totalPoints / totalCourses : 0;
    }

    public void AssignGrade(Course course, char grade)
    {
        if (grades.ContainsKey(course))
        {
            grades[course] = grade;
        }
        else
        {
            grades.Add(course, grade);
        }
    }
}
