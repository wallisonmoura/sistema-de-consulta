﻿using FluentValidation;
using SistemaDeConsulta.ViewModels.TipoExames;

namespace SistemaDeConsulta.Validators.TipoExames
{
    public class EditTipoExameValidator: AbstractValidator<EditTipoExamesViewModel>
    {
        public EditTipoExameValidator() 
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Campo obrigatório.")
                 .MaximumLength(100).WithMessage("O nome deve ter até 100 caracteres.");

            RuleFor(x => x.Descricao).NotEmpty().WithMessage("Campo obrigatório.")
                .MaximumLength(256).WithMessage("A descrição deve ter até 256 caracteres.");
        }
    }
}
