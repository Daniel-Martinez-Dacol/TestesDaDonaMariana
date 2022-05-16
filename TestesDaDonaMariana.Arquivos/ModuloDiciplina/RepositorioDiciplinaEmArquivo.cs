using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.Arquivos.Compartilhado;
using TestesDaDonaMariana.Dominio.ModuloDiciplina;

namespace TestesDaDonaMariana.Arquivos.ModuloDiciplina
{
   public class RepositorioDiciplinaEmArquivo : RepositorioEmArquivoBase<Diciplina>, IRepositorioDiciplina
    {
        public RepositorioDiciplinaEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Diciplinas.Count > 0)
                contador = dataContext.Diciplinas.Max(x => x.Numero);
        }

        public override List<Diciplina> ObterRegistros()
        {
            return dataContext.Diciplinas;
        }

        public override AbstractValidator<Diciplina> ObterValidador()
        {
            return new ValidadorDiciplina();
        }

    }
}
