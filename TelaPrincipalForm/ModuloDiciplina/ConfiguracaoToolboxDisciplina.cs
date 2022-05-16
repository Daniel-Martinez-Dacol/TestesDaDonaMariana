using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloDiciplina
{
    public class ConfiguracaoToolboxDisciplina : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Disciplinas";

        public override string TooltipInserir { get { return "Inserir uma nova Disciplina"; } }

        public override string TooltipEditar { get { return "Editar uma Disciplina existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma Disciplina existente"; } }
    }
}
