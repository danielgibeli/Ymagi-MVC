using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YmagiWebMvc.Models;

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
    }
}
