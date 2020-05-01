using System;
using System.Linq;
using YmagiWebMvc.Models;
using YmagiWebMvc.Models.Enums;

namespace YmagiWebMvc.Data
{
    public class SeendingService
    {
        private YmagiWebMvcContext _context;

        public SeendingService(YmagiWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Osc.Any() || 
                _context.Doacao.Any() ||
                _context.Voluntario.Any())
            {
                return; //DB já foi populado
            }

            Osc o1 = new Osc(1, "resolvi", "mm","mmm","mmm","mmm","mmm");

            Voluntario v1 = new Voluntario(1, "daniel", "daniel", 1125000, 50002, new DateTime(1984, 10, 03), o1);

            Doacao d1 = new Doacao(1, new DateTime(1982, 10, 10), 235, DoacoesStatus.Pendente, v1);

            _context.Osc.AddRange(o1);
            _context.Voluntario.AddRange(v1);
            _context.Doacao.AddRange(d1);

            _context.SaveChanges();

        }
    }
}
