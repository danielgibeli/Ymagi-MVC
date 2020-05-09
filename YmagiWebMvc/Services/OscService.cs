using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YmagiWebMvc.Models;
using YmagiWebMvc.Services.Exceptions;

namespace YmagiWebMvc.Services
{
    public class OscService
    {
        private readonly YmagiWebMvcContext _context;

        public OscService(YmagiWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Osc>> FindAllAsync()
        {
            return await _context.Osc.OrderBy(x => x.NomeFantasia).ToListAsync();
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Osc.FindAsync(id);
                _context.Osc.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw new IntegrityException("O voluntário não pode ser excluido, porque ele fez doações!");
            }
        }
    }
}
