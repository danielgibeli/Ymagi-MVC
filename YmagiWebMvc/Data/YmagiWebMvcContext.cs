using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace YmagiWebMvc.Models
{
    public class YmagiWebMvcContext : DbContext
    {
        public YmagiWebMvcContext (DbContextOptions<YmagiWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Osc> Osc { get; set; }
        public DbSet<Doacao> Doacao { get; set; }
        public DbSet<Voluntario> Voluntario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Insumo> Insumo { get; set; }
    }
}
