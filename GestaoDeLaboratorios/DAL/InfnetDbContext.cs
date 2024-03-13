using GestaoDeLaboratorios.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeLaboratorios.DAL
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions<InfnetDbContext> options) : base(options)
        {
        }

        public DbSet<Computadores> Computadores { get; set; }
    }
}
