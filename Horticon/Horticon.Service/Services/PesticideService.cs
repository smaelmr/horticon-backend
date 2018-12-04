using Core.Commands;
using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Entities.Pesticides;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Service.Services
{
    public class PesticideService : IPesticideService
    {

        private IPesticideRepository repository;

        public PesticideService(IPesticideRepository repository)
        {
            this.repository = repository;
        }

        public Pesticide Post<V>(PesticidePostCommand obj) where V : AbstractValidator<Pesticide>
        {
            Pesticide o = new Pesticide()
            {
                Id = Guid.NewGuid(),
                ActivePrinciple = obj.ActivePrinciple,
                CommercialName = obj.CommercialName,
                Date = obj.Date,
                DoseL = obj.DoseL,
                Hour = obj.Hour,
                Lack = obj.Lack,
                Lot = obj.Lot,
                Sytem = obj.System,
                PesticideType = obj.PesticideType
            };

            Validate(o, Activator.CreateInstance<V>());

    

            repository.Insert(o);
            return o;
        }

        public Pesticide Put<V>(Pesticide obj) where V : AbstractValidator<Pesticide>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("Identificador inválido.");

            repository.Remove(id);
        }

        public Pesticide Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("Identificador inválido.");

            return repository.Get(id);
        }

        public IList<Pesticide> Get() => repository.GetAll();

        private void Validate(Pesticide obj, AbstractValidator<Pesticide> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
