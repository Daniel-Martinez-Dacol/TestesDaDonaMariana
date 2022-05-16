using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.Dominio.Compartilhado;
using TestesDaDonaMariana.Dominio.ModuloDiciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public string Titulo { get; set; }

        public DateTime Data { get; set; }

        public Diciplina Diciplina { get; set; }

        public Materia Materia { get; set; }

        public bool Recuperacao { get; set; }

        public int NumeroQuestoes { get; set; }

        public List<Questao> Questoes { get; set; }

        public override void Atualizar(Teste registro)
        {
        }

        public Teste Clone()
        {
            var questoesCopiadas = new Questao[this.Questoes.Count];

            this.Questoes.CopyTo(questoesCopiadas);

            return new Teste
            {
                Titulo = this.Titulo,
                Data = this.Data,
                Diciplina = this.Diciplina,
                Materia = this.Materia,
                Recuperacao = this.Recuperacao,
                NumeroQuestoes = this.NumeroQuestoes,
                Questoes = questoesCopiadas.ToList()
            };
        }
    }
}
