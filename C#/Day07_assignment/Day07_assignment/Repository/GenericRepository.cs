using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_assignment.Repository;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private readonly List<T> _context;

    public GenericRepository()
    {

    _context = new List<T>(); }

    public void Add(T item)
    {
        if(item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }
    }

    public void Remove(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        _context.Remove(item);
    }

    public void Save()
    {
        // For in-memory data, there's nothing to do here.
        // For database implementations, this would save changes to the database.
    }

    public IEnumerable<T> GetAll()
    {
        return _context.AsReadOnly();
    }

    public T GetById(int id)
    {
        return _context.FirstOrDefault(e => e.Id == id);
    }

}
