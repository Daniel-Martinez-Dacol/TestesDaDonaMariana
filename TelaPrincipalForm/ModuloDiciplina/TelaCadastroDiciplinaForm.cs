using FluentValidation.Results;
using System;
using System.Windows.Forms;
using TestesDaDonaMariana.Dominio.ModuloDiciplina;
using TestesDaDonaMariana.WinApp;

namespace TestesDaDonaMariana.WinApp.ModuloDiciplina
{
    public partial class TelaCadastroDiciplinaForm : Form
    {
        private Diciplina diciplina;

        public TelaCadastroDiciplinaForm()
        {
            InitializeComponent();


        }
        public Func<Diciplina, ValidationResult> GravarRegistro { get; set; }
        
        public Diciplina Diciplina
        {
            get
            {
                return diciplina;
            }
            set
            {
                diciplina = value;
                txtNumero.Text = diciplina.Numero.ToString();
                txtDiciplina.Text = diciplina.nome;
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            diciplina.Nome = txtDiciplina.Text;

            var resultadoValidacao = GravarRegistro(diciplina);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

               // TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaCadastroDiciplinaForm_Load(object sender, EventArgs e)
        {
            //TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }
}
