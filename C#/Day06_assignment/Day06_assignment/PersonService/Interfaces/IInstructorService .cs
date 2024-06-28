using System;


namespace Day06_assignment.PersonService.Interfaces;

public interface IInstructorService : IPersonService
{
    void AssignDepartment(Department department);
    int CalculateYearsOfExperience(DateTime joinDate);
}