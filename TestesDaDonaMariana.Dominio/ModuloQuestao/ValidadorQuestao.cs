using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace TestesDaDonaMariana.Dominio.ModuloQuestao
{
    public class ValidadorQuestao : AbstractValidator<Questao>
    {
        public ValidadorQuestao()
        {
            RuleFor(x => x.Materia)
               .NotNull().NotEmpty();

            RuleFor(x => x.Disciplina)
              .NotNull().NotEmpty();

            RuleFor(x => x.Bimestre)
               .NotNull().NotEmpty();

            RuleFor(x => x.Alternativas)
               .NotNull().NotEmpty();

            RuleFor(x => x.Enunciado)
              .NotNull().NotEmpty();

            RuleFor(x => x.Alternativas)
                .Must(lista => lista.Any(x => x.Correta))
                .WithMessage("É Preciso selecionar um alternativa!");
        }
    }
}
