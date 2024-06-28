using System;


namespace Day06_assignment.PersonService.Interfaces;

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGPA();
}