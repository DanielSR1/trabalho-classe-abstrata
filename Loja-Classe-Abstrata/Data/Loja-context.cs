using Loja_Classe_Abstrata.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja_Classe_Abstrata.Data
{
    public class Loja_context: DbContext
    {
        public Loja_context(DbContextOptions<Loja_context> options): base(options) { }
        public DbSet <Produto> Produtos { get; set; }
        public DbSet <Carro> Carros { get; set; }
        public DbSet <Moto> Motos { get; set; }
    }
}
