using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.WinApp.Compartilhado;
using TestesDaDonaMariana.Arquivos.ModuloDiciplina;
using TestesDaDonaMariana.Arquivos;
using TestesDaDonaMariana.Arquivos.Compartilhado;
using TestesDaDonaMariana.WinApp.ModuloDiciplina;

namespace TestesDaDonaMariana.WinForm
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;
        public TelaPrincipalForm()
        {
            InitializeComponent();

            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            IncializadorControladores();
        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public void IncializadorControladores()
        {
            var repositorioDiciplina = new RepositorioDiciplinaEmArquivo(contextoDados);
           

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Diciplinas", new ControladorDisciplina(repositorioDiciplina));

        }

        private void TelaPrincipalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
