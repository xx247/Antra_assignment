using System;

namespace Day06_assignment.PersonService.Interfaces;

public interface IPersonService
{
    int CalculateAge(DateTime birthDate);
    decimal CalculateSalary();
    List<string> GetAddresses();
}
