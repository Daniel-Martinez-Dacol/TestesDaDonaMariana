using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.Dominio.Compartilhado;
using TestesDaDonaMariana.Dominio.ModuloDiciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public Questao()
        {
            Alternativas = new List<Alternativa>();
        }

        public string Bimestre { get; set; }

        public Materia Materia { get; set; }

        public Diciplina Disciplina { get; set; }

        public string Enunciado { get; set; }

        public List<Alternativa> Alternativas { get; set; }

        public override void Atualizar(Questao registro)
        {
        }
    }
}
