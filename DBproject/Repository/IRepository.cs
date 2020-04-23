using System;
using System.Collections.Generic;

namespace DBproject.Repository
{
    public interface IRepository<T> : IDisposable where T : class 
    {
        IEnumerable<T> GetList();
        T GetItem(int id);
        int Create(T item);
        int Update(T item);
        void Delete(int id);
        void Save();
    }
}
