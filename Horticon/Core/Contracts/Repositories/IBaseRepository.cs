using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T Get(int id);

        IList<T> GetAll();
    }
}
