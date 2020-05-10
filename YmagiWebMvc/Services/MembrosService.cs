using System;
using System.Collections.Generic;
using System.Linq;
using YmagiWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using YmagiWebMvc.Services.Exceptions;
using System.Threading.Tasks;

namespace YmagiWebMvc.Services
{
    public class MembrosService
    {
        private readonly YmagiWebMvcContext _context;

        public MembrosService(YmagiWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Membro>> FindAllAsync()
        {
            return await _context.Membro.ToListAsync();
        }

        public async Task InsertAsync(Membro obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Membro> FindByIdAsync(int id)
        {
            return await _context.Membro.Include(obj => obj.Osc).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Membro.FindAsync(id);
                _context.Membro.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw new IntegrityException("O voluntário não pode ser excluido, porque ele fez doações!");
            }
        }

        public async Task UpdateAsync(Membro obj)
        {
            bool hasAny = await _context.Membro.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Voluntário não encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}