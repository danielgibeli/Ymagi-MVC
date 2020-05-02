using System;
using System.Collections.Generic;
using System.Linq;
using YmagiWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using YmagiWebMvc.Services.Exceptions;

namespace YmagiWebMvc.Services
{
    public class VoluntariosService
    {
        private readonly YmagiWebMvcContext _context;

        public VoluntariosService(YmagiWebMvcContext context)
        {
            _context = context;
        }

        public List<Voluntario> FindAll()
        {
            return _context.Voluntario.ToList();
        }

        public void Insert(Voluntario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Voluntario FindById(int id)
        {
            return _context.Voluntario.Include(obj => obj.Osc).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Voluntario.Find(id);
            _context.Voluntario.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Voluntario obj)
        {
            if (!_context.Voluntario.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Voluntário não encontrado");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}