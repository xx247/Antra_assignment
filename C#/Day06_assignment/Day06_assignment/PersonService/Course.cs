using Day06_assignment.PersonService.Interfaces;
using System;


namespace Day06_assignment.PersonService;

public class Course : ICourseService
{
    private string courseName;
    private List<Student> enrolledStudents = new List<Student>();

    public string CourseName
    {
        get { return courseName; }
        private set
        {
            if (!string.IsNullOrEmpty(value)) courseName = value;
            else throw new ArgumentException("Course name can not be empty");

        }
    }

    public Course(string courseName)
    {
        CourseName = courseName;
        
    }

    public void AddStudent(Student student)
    {
        enrolledStudents.Add(student);
    }

    public List<Student> GetEnrolledStudents()
    {
        return enrolledStudents;
    }

    public void AssignGrade(Student student, char grade)
    {
        student.AssignGrade(this, grade);
    }

}
