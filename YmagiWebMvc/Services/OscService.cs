using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YmagiWebMvc.Models;

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
    }
}
