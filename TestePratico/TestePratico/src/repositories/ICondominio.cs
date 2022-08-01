using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.src.dtos;
using TestePratico.src.Models;

namespace TestePratico.src.repositories
{
    public interface ICondominio
    {        
        Task NovoCondominioAsync(CondominioModel model);
        Task AtualizarCondominioAsync(AtualizarCondominioDTO condominio);
        Task DeletarCondominioAsync(int id);
        Task<List<CondominioModel>> ListarCondominiosIdAsync();
    }
}