﻿using System;

namespace DBproject.Repository
{
    public interface IRepository<T> : IDisposable where T : class 
    {
        IEquatable<T> GetList();
        T GetItem(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}