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

        public List<Osc> FindAll()
        {
            return _context.Osc.OrderBy(x => x.NomeFantasia).ToList();
        }
    }
}
