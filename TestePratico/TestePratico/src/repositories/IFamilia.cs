using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.src.dtos;
using TestePratico.src.Models;

namespace TestePratico.src.repositories
{
    public interface IFamilia
    {
        Task NovaFamiliaAsync(NovaFamiliaDTO familia);

        Task AtualizarFamiliaAsync(AtualizarFamiliaDTO familia);

        Task DeletarFamiliaAsync(int id);
        Task<FamiliaModel> PegarFamiliaPeloIdAsync(int id);
        Task<List<FamiliaModel>> ListarFamiliasIdAsync();
    }
}