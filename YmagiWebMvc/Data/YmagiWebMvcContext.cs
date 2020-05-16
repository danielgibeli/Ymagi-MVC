using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YmagiWebMvc.Models;

namespace YmagiWebMvc.Models
{
    public class YmagiWebMvcContext : IdentityDbContext
    {
        public YmagiWebMvcContext (DbContextOptions<YmagiWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Osc> Osc { get; set; }
        public DbSet<Membro> Membro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Entrega> Entrega { get; set; }
        public DbSet<Recebimento> Recebimento { get; set; }
    }
}
