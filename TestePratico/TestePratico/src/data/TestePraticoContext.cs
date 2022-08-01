using Microsoft.EntityFrameworkCore;
using TestePratico.src.Models;

namespace TestePratico.src.Data
{
    /// <summary>
    /// <para>Resume> Criado o contexto para o banco de dados</para>
    /// <para>By:Paulo Almeida </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 30/07/2022</para>
    /// </summary>
    public class TestePraticoContext : DbContext
    {
        public DbSet<MoradorModel> Morador { get; set; }
        public DbSet<FamiliaModel> Familia { get; set; }
        public DbSet<CondominioModel> Condominio { get; set; }
        public TestePraticoContext(DbContextOptions<TestePraticoContext> opt) : base(opt)
        {
        }
    }
}
