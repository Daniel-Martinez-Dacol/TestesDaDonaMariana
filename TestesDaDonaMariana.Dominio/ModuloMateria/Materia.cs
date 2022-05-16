using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.Dominio.Compartilhado;
using TestesDaDonaMariana.Dominio.ModuloDiciplina;

namespace TestesDaDonaMariana.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string Nome { get; set; }

        public string Serie { get; set; }

        public Diciplina Diciplina { get; set; }

        public override void Atualizar(Materia registro)
        {
        }
    }
}
