using Core.Contracts.Services;
using System;
using System.Collections.Generic;
using FluentValidation;
using Core.Contracts.Repositories;

namespace Service.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private IBaseRepository<T> repository;

        public BaseService(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }

        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            repository.Remove(id);
        }

        public IList<T> Get() => repository.GetAll();

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            return repository.Get(id);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
