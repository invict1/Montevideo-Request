﻿using System;
using System.Collections.Generic;

namespace IMMRequest.DataAccess.Interface
{
    public interface IRepository<T, X> 
    {
        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);

        IEnumerable<T> GetAll();

        T Get(Guid id);

        X GetParent(Guid id);

        void Save();

        bool Exist(Func<T, bool> predicate);

        IEnumerable<T> Query(string query);

        bool Exist(T entity);
    }
}
