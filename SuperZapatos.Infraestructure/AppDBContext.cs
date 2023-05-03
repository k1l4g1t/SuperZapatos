using Microsoft.EntityFrameworkCore;
using SuperZapatos.Domain.Models;

namespace SuperZapatos.Infraestructure
{
    public  class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Articles> Articles { get; set; }
        public DbSet<Store> Store { get; set; }
    }
}
