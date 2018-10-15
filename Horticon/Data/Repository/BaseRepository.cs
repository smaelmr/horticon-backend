using Core.Contracts.Repositories;
using Core.Entities;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private MySqlContext context;

        public BaseRepository(MySqlContext context)
        {
            this.context = context;
        }

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<T>().Remove(Get(id));
            context.SaveChanges();
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IList<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
