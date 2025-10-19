//Meio de campo entre o DB e o código C#
//Auxilia a fazer a conexão
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Web_API_Produtos.Models;

namespace Web_API_Produtos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produtos {get; set;}
    }
}
