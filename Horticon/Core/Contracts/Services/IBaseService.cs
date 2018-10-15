using Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts.Services
{
    public interface IBaseService<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}
