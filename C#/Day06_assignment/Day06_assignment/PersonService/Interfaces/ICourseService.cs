using System;
using Day06_assignment.PersonType;

namespace Day06_assignment.PersonService.Interfaces;

public interface ICourseService
{
    List<Student> GetEnrolledStudents();
    void AssignGrade(Student student, char grade);
}
