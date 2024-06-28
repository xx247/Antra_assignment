using System;
using System.Collections.Generic;


namespace Day07_assignment.Repository;

internal interface IRepository<T> where T : Entity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}
