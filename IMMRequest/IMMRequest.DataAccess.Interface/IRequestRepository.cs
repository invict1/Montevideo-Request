using System;
using System.Collections.Generic;

namespace IMMRequest.DataAccess.Interface
{
    public interface IRequestRepository<T, X> where T : class where X : class
    {
        void Add(T entity);

        void Update(T entity);

        IEnumerable<T> GetAll();

        T Get(Guid id);

        X GetTypeWithFields(Guid id);

        void Save();

        bool Exist(Func<T, bool> predicate);

        IEnumerable<T> Query(string query);
    }
}