using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDaDonaMariana.Dominio.ModuloQuestao
{
    public class Alternativa
    {
        public Guid Id { get; set; }

        public string Resposta { get; set; }

        public bool Correta { get; set; }
    }
}
