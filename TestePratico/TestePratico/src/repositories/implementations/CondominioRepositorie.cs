using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TestePratico.src.repositories;
using TestePratico.src.dtos;
using TestePratico.src.Models;
using TestePratico.src.Data;

namespace TestePredio.src.repositories.implementacoes
{
    public class CondominioRepositorie : ICondominio
    {
        #region Atributos
        private readonly TestePraticoContext _context;
        #endregion Atributos

        #region Construtores
        public CondominioRepositorie(TestePraticoContext context)
        {
            _context = context;
        }
        #endregion Construtores

        #region Metodos     

        public async Task NovoCondominioAsync(CondominioModel model)
        {
            try
            {
                await _context.Condominio.AddAsync(model);
                await _context.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                var x = ex;
                throw;
            }
            
        }

        public async Task AtualizarCondominioAsync(AtualizarCondominioDTO condominio)
        {
            var CondominioModel = await PegarCondominiopeloIdAsync(condominio.Id);
            CondominioModel.Nome = condominio.Nome;
            CondominioModel.Bairro = condominio.Bairro;
            _context.Condominio.Update(CondominioModel);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarCondominioAsync(int id)
        {
            _context.Remove(await PegarCondominiopeloIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<CondominioModel> PegarCondominiopeloIdAsync(int id)
        {
            return await _context.Condominio.Include("Familia").Include("Condominio").FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<CondominioModel>> ListarCondominiosIdAsync()
        {
            return await _context.Condominio                
                .ToListAsync();
        }

        #endregion Metodos
    }
}