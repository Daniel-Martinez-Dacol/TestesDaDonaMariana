using System.Collections.Generic;
using System.Windows.Forms;
using TestesDaDonaMariana.Dominio.ModuloDiciplina;

namespace TestesDaDonaMariana.WinApp.ModuloDiciplina
{
    public partial class ListagemDiciplinasControl : UserControl
    {
        public ListagemDiciplinasControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Diciplina> diciplinas)
        {
            CarregarDiciplinas(diciplinas);
        }

        public Diciplina ObtemDiciplinaSelecionada()
        {
            return (Diciplina)listDiciplinas.SelectedItem; 
        }

        private void CarregarDiciplinas(List<Diciplina> diciplinas)
        {
            listDiciplinas.Items.Clear();

            foreach (Diciplina t in diciplinas)
            {
                listDiciplinas.Items.Add(t); 
            }
        }

        private void listTarefas_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
