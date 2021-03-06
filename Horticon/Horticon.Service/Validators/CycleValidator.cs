﻿using Core.Entities.Cycles;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Validators
{
    public class CycleValidator : AbstractValidator<Cycle>
    {
        public CycleValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não encontrado.");
                    });

            RuleFor(c => c.Sytem)
                .NotEmpty().WithMessage("É necessário informar o sistema.")
                .NotNull().WithMessage("É necessário informar o sistema.");

            RuleFor(c => c.Lot)
                .NotEmpty().WithMessage("É necessário informar o lote.")
                .NotNull().WithMessage("É necessário informar o lote.");
        }
    }
}
