using System;
using System.Collections.Generic;
using System.Linq;
using YmagiWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using YmagiWebMvc.Services.Exceptions;
using System.Threading.Tasks;

namespace YmagiWebMvc.Services
{
    public class VoluntariosService
    {
        private readonly YmagiWebMvcContext _context;

        public VoluntariosService(YmagiWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Voluntario>> FindAllAsync()
        {
            return await _context.Voluntario.ToListAsync();
        }

        public async Task InsertAsync(Voluntario obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Voluntario> FindByIdAsync(int id)
        {
            return await _context.Voluntario.Include(obj => obj.Osc).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Voluntario.FindAsync(id);
                _context.Voluntario.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw new IntegrityException("O voluntário não pode ser excluido, porque ele fez doações!");
            }
        }

        public async Task UpdateAsync(Voluntario obj)
        {
            bool hasAny = await _context.Voluntario.AnyAsync(x => x.Id == obj.Id);
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