using Core.Commands;
using Core.Entities.Pesticides;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts.Services
{
    public interface IPesticideService
    {
        Pesticide Post<V>(PesticidePostCommand obj) where V : AbstractValidator<Pesticide>;

        Pesticide Put<V>(Pesticide obj) where V : AbstractValidator<Pesticide>;

        void Delete(int id);

        Pesticide Get(int id);

        IList<Pesticide> Get();
    }
}
