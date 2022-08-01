using System.Threading.Tasks;
using TestePratico.src.dtos;
using TestePratico.src.Models;

namespace TestePratico.src.repositories
{
    public interface IMorador
    {
        Task NovoMoradorAsync(NovoMoradorDTO morador);

        Task AtualizarMoradorAsync(AtualizarMoradorDTO morador);

        Task DeletarMoradorAsync(int id);

        Task<MoradorModel> PegarMoradorpeloIdAsync(int id);

    }
}