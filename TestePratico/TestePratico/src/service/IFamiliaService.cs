using System.Threading.Tasks;
using TestePratico.src.dtos;
using TestePratico.src.Models;

namespace TestePratico.src.service
{
    public interface IFamiliaService
    {
        Task NovaFamiliaAsync(NovaFamiliaDTO familia);
        Task AtualizarFamiliaAsync(AtualizarFamiliaDTO familia);        
        Task DeletarFamiliaAsync(int id);
        Task<FamiliaModel> PegarFamiliaPeloIdAsync(int id);
        Task<FamiliaModel> ListarFamiliasIDAsync();
    }
}
