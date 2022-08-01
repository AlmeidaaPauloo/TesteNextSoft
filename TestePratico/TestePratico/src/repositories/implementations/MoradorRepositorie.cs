using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TestePratico.src.Data;
using TestePratico.src.dtos;
using TestePratico.src.Models;

namespace TestePratico.src.repositories.implementations
{   
    public class MoradorRepositorie : IMorador
    {
        #region Atributos
        private readonly TestePraticoContext _context;
        #endregion Atributos

        #region Construtores
        public MoradorRepositorie(TestePraticoContext context)
        {
            _context = context;
        }
        #endregion Construtores
         /// <summary>
         /// Função atualizar morador
         /// </summary>
         /// <param name="morador"></param>
         /// <returns></returns>
        public async Task AtualizarMoradorAsync(AtualizarMoradorDTO morador)
        {
            var MoradorModel = await PegarMoradorpeloIdAsync(morador.Id);
            MoradorModel.Nome = morador.Nome;
            MoradorModel.Apto = morador.Apto;
            _context.Morador.Update(MoradorModel);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarMoradorAsync(int id)
        {
            _context.Remove(await PegarMoradorpeloIdAsync(id));
            await _context.SaveChangesAsync();
        }        

        #region Metodos        
        
        public async Task NovoMoradorAsync(NovoMoradorDTO morador)
        {
            await _context.Morador.AddAsync(new MoradorModel
            {
                Nome = morador.Nome,
                Idade = morador.Idade,
            });
            await _context.SaveChangesAsync();
        }

        public async Task<MoradorModel> PegarMoradorpeloIdAsync(int id)
        {
            return await _context.Morador
               .FirstOrDefaultAsync(u => u.Id == id);
        }
    }  
    #endregion
}
