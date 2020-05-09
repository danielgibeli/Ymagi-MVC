using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YmagiWebMvc.Models;

namespace YmagiWebMvc.Services
{
    public class UsuariosService
    {
        private readonly YmagiWebMvcContext _context;

        public UsuariosService(YmagiWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> FindAllAsync()
        {
            return await _context.Usuario.ToListAsync();
        }

        public async Task InsertAsync(Usuario obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
