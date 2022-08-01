using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.src.dtos;
using TestePratico.src.Models;

namespace TestePratico.src.service
{
    public interface ICondominioService
    {       
        Task NovoCondominioAsync(NovoCondominioDTO dto);
        Task AtualizarCondominioAsync(AtualizarCondominioDTO condominio);
        Task DeletarCondominioAsync(int id);
        Task<List<CondominioModel>> ListarCondominiosIdAsync();

    }
}
