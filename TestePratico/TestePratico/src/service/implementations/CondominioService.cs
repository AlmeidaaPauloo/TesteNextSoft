using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.src.dtos;
using TestePratico.src.Models;
using TestePratico.src.repositories;

namespace TestePratico.src.service.implementations
{
    public class CondominioService : ICondominioService
    {
        private readonly ICondominio _condominioRepositorie;
        public CondominioService(ICondominio condominioRepositorie)
        {
            _condominioRepositorie = condominioRepositorie;
        }

        public async Task AtualizarCondominioAsync(AtualizarCondominioDTO condominio)
        {            
            await _condominioRepositorie.AtualizarCondominioAsync(condominio);            
        }

        public async Task DeletarCondominioAsync(int idCondominio)
        {
           await _condominioRepositorie.DeletarCondominioAsync(idCondominio);   

        }

        public async Task<List<CondominioModel>> ListarCondominiosIdAsync()
        {
            return await _condominioRepositorie.ListarCondominiosIdAsync();
                
        }

        public async Task NovoCondominioAsync(NovoCondominioDTO novocondominio)
        {
            await _condominioRepositorie.NovoCondominioAsync(new CondominioModel
            {
                Id = novocondominio.Id,
                Nome = novocondominio.Nome,
                Bairro = novocondominio.Bairro,
                ValorIPTU = novocondominio.ValorIPTU,
                AreaTotal = novocondominio.AreaTotal,
            });
           
        }
    }
}
