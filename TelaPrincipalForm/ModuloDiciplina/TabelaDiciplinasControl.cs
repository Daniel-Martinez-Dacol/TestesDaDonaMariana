
using System.Collections.Generic;
using System.Windows.Forms;
using TestesDaDonaMariana.Dominio.ModuloDiciplina;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TabelaDiciplinasControl : UserControl
    {
        public TabelaDiciplinasControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Diciplina", HeaderText = "Título"}
            };

            return colunas;
        }

        public int ObtemNumeroTarefaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Diciplina> diciplinas)
        {
            grid.Rows.Clear();

            foreach (Diciplina diciplina in diciplinas)
            {
                grid.Rows.Add(diciplina.Numero, diciplina.Nome);
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
