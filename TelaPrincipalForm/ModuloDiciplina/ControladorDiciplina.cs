using eAgenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesDaDonaMariana.Arquivos.ModuloDiciplina;
using TestesDaDonaMariana.Dominio.ModuloDiciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloDiciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private readonly IRepositorioDiciplina repositorioDiciplina;
        private readonly IRepositorioMateria repositorioMateria;
        private TabelaDiciplinasControl tabelaDiciplinas;

        public ControladorDisciplina(IRepositorioDiciplina repositorioDiciplina, IRepositorioMateria repositorioMateria)
        {
            this.repositorioDiciplina = repositorioDiciplina;
            this.repositorioMateria = repositorioMateria;
        }

        public ControladorDisciplina(RepositorioDiciplinaEmArquivo repositorioDiciplina)
        {
            this.repositorioDiciplina = repositorioDiciplina;
        }

        public override void Inserir()
        {
            TelaCadastroDiciplinaForm tela = new TelaCadastroDiciplinaForm();
            tela.Diciplina = new Diciplina();

            tela.GravarRegistro = repositorioDiciplina.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        public override void Editar()
        {
            Diciplina DisciplinaSelecionada = ObtemDiciplinaSelecionada();

            if (DisciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione um Disciplina primeiro",
                "Edição de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroDiciplinaForm tela = new TelaCadastroDiciplinaForm();

            tela.Disciplina = DisciplinaSelecionada;

            tela.GravarRegistro = repositorioDiciplina.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        public override void Excluir()
        {
            Diciplina disciplinaSelecionada = ObtemDiciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione um Disciplina primeiro",
                "Exclusão de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (repositorioMateria.ExisteMateriaPeloNumeroDisciplina(disciplinaSelecionada.Numero))
            {
                MessageBox.Show("Não é possível excluir! A Disciplina está relacionada com uma matéria.",
               "Exclusão de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a Disciplina?",
                "Exclusão de Disciplinas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioDiciplina.Excluir(disciplinaSelecionada);
                CarregarDisciplinas();
            }
        }


        public override UserControl ObtemListagem()
        {
            if (tabelaDiciplinas == null)
                tabelaDiciplinas = new TabelaDiciplinasControl();

            CarregarDisciplinas();

            return tabelaDiciplinas;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxDisciplina(); // implementar
        }


        private Diciplina ObtemDiciplinaSelecionada()
        {
            var numero = tabelaDiciplinas.ObtemNumeroDiciplinaSelecionada();

            return repositorioDiciplina.SelecionarPorNumero(numero);
        }

        private void CarregarDisciplinas()
        {
            List<Diciplina> Disciplinas = repositorioDiciplina.SelecionarTodos();

            tabelaDiciplinas.AtualizarRegistros(Disciplinas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {Disciplinas.Count} Disciplina(s)"); // implementar
        }
    }
}
