using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.Dominio.Compartilhado;

namespace TestesDaDonaMariana.Dominio.ModuloDiciplina
{
    public class Diciplina : EntidadeBase<Diciplina>
    {
        public string nome;
        public Diciplina()
        {

        }
        public Diciplina(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public override void Atualizar(Diciplina registro)
        {
        }
    }
}
