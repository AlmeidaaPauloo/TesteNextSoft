using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TestePratico.src.repositories;
using TestePratico.src.Data;
using TestePratico.src.dtos;
using TestePratico.src.Models;
using Microsoft.AspNetCore.Mvc;

namespace TestePratico.src.repositories.implementations
{
    public class FamiliaRepositorie : IFamilia
    {
        #region Atributos
        private readonly TestePraticoContext _context;
        #endregion Atributos

        #region Construtores
        public FamiliaRepositorie(TestePraticoContext context)
        {
            _context = context;
        }
        #endregion Construtores

        #region Metodos

        public async Task<List<FamiliaModel>> ListarFamiliasIdAsync()
        {
            return await _context.Familia
                .ToListAsync();
        }
        public async Task AtualizarFamiliaAsync(AtualizarFamiliaDTO familia)
        {
            var FamiliaModel = await PegarFamiliaPeloIdAsync(familia.Id);
            FamiliaModel.Nome = familia.Nome;
            FamiliaModel.Apto = familia.Apto;
            _context.Familia.Update(FamiliaModel);
            await _context.SaveChangesAsync();
        }
        public async Task<FamiliaModel> PegarFamiliaPeloIdAsync(int id)
        {
            return await _context.Familia.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task DeletarFamiliaAsync(int id)
        {
            _context.Remove(await PegarFamiliaPeloIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task NovaFamiliaAsync(NovaFamiliaDTO familia)
        {
            var FamiliaModel = await PegarFamiliaPeloIdAsync(familia.Id);
            FamiliaModel.Nome = familia.Nome;
            FamiliaModel.Apto = familia.Apto;
            _context.Familia.Update(FamiliaModel);
            await _context.SaveChangesAsync();

        }      
        #endregion Metodos
    }
}