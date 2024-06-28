using System;
using Day06_assignment.PersonType;

namespace Day06_assignment.PersonService.Interfaces;

public interface IDepartmentService
{
    void SetHeadInstructor(Instructor instructor);
    List<Course> GetCourses();
    decimal GetBudget();
}