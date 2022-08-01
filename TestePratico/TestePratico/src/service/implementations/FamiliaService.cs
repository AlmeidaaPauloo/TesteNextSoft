using System.Threading.Tasks;
using TestePratico.src.dtos;
using TestePratico.src.Models;
using TestePratico.src.repositories;

namespace TestePratico.src.service.implementations
{
    public class FamiliaService : IFamiliaService
    {
        private readonly IFamilia _familiaRepositorie;
        public FamiliaService(IFamilia familiaRepositorie)
        {
            _familiaRepositorie = familiaRepositorie;
        }
        public Task AtualizarFamiliaAsync(AtualizarFamiliaDTO familia)
        {
            throw new System.NotImplementedException();
        }

        public Task DeletarFamiliaAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<FamiliaModel> ListarFamiliasIDAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task NovaFamiliaAsync(NovaFamiliaDTO familia)
        {
            throw new System.NotImplementedException();
        }

        public Task<FamiliaModel> PegarFamiliaPeloIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
