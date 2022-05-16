using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.Dominio.Compartilhado;

namespace TestesDaDonaMariana.Dominio.ModuloMateria
{
    public interface IRepositorioMateria : IRepositorio<Materia>
    {
        List<Materia> SelecionarTodos();
        bool ExisteMateriaPeloNumeroDisciplina(int numero);
    }
}
