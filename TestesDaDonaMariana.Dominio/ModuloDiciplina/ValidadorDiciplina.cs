using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace TestesDaDonaMariana.Dominio.ModuloDiciplina
{
    public class ValidadorDiciplina : AbstractValidator<Diciplina>
    {
        public ValidadorDiciplina()
        {
            RuleFor(x => x._nome)
                .NotEmpty().NotNull();
        }
    }
}
