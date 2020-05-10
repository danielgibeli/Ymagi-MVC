﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YmagiWebMvc.Models;

namespace YmagiWebMvc.Services
{
    public class DoacaosService
    {
        private readonly YmagiWebMvcContext _context;

        public DoacaosService(YmagiWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Doacao>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Doacao select obj; 
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Membro)
                .Include(x => x.Membro.Osc)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Osc, Doacao>>> FindByDateGrupoAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Doacao select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Membro)
                .Include(x => x.Membro.Osc)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Membro.Osc)
                .ToListAsync();
        }
    }
}