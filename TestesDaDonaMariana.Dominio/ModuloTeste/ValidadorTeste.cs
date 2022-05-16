using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace TestesDaDonaMariana.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Teste>
    {
        public ValidadorTeste()
        {
            RuleFor(x => x.Titulo)
               .NotNull().NotEmpty();

            RuleFor(x => x.Data)
              .NotNull().NotEmpty();

            RuleFor(x => x.Diciplina)
               .NotNull().NotEmpty();

            RuleFor(x => x.Materia)
               .NotNull().NotEmpty();

            RuleFor(x => x.NumeroQuestoes)
               .NotNull().NotEmpty();
        }

    }
}
