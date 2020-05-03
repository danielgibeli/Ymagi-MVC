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
            if (_context.Osc.Any() ||
                _context.Voluntario.Any() ||
                _context.Usuario.Any() ||
                _context.Insumo.Any() ||
                _context.Doacao.Any())
            {
                return; //DB já foi populado
            }

            Osc o1 = new Osc(1, "Resolvi Mudar", "Resolvi Mudar Ltda", "Campos Eliseos", "Paula", "39692429", "paula@resolv");
            Osc o2 = new Osc(2, "Cantinho Ceu", "Cantinho Ltda", "Centro", "Andre", "63632524", "andre@gmail");
            Osc o3 = new Osc(3, "Casa do Vovo", "Casa Ltda", "Ipiranga", "Bob", "36352428", "bob@hotmail");


            Voluntario v1 = new Voluntario(1, "Daniel", "daniel@gibeli", 1125000, 50002, new DateTime(1984, 10, 03), o2);
            Voluntario v2 = new Voluntario(2, "Giseli", "giseli@sebsa", 256330, 0201011, new DateTime(1980, 05, 10), o3);
            Voluntario v3 = new Voluntario(3, "Paula", "paula@resolvi", 789365, 0050500, new DateTime(1981, 06, 02), o1);

            Usuario u1 = new Usuario(1, "Daniel", 219486, 3969, "daniel@", new DateTime(1985, 07, 03), new DateTime(2020, 05, 02),
                14075, "elza dos santos", 78, "casa", "Q2", "ribeirao", "SP", "novo cadastro");
            Usuario u2 = new Usuario(2, "Giseli", 219486, 3969, "daniel@", new DateTime(1985, 07, 03), new DateTime(2020, 05, 02),
                14075, "elza dos santos", 78, "casa", "Q2", "ribeirao", "SP", "novo cadastro");
            Usuario u3 = new Usuario(3, "Paula", 219486, 3969, "daniel@", new DateTime(1985, 07, 03), new DateTime(2020, 05, 02),
                14075, "elza dos santos", 78, "casa", "Q2", "ribeirao", "SP", "novo cadastro");

            Insumo i1 = new Insumo(1, "Cesta Basica", "CX", 10, 2, 100, 200, new DateTime(2020, 05, 03));
            Insumo i2 = new Insumo(2, "Arrox", "KG", 100, 100, 100, 20000, new DateTime(2020, 05, 03));
            Insumo i3 = new Insumo(3, "Feijao", "KG", 50, 50, 10, 1000, new DateTime(2020, 05, 03));

            Doacao d1 = new Doacao(1, new DateTime(1982, 10, 10), 235, DoacoesStatus.Pendente, v1, u1);
            Doacao d2 = new Doacao(2, new DateTime(1985, 10, 10), 235, DoacoesStatus.Pendente, v2, u2);
            Doacao d3 = new Doacao(3, new DateTime(1980, 10, 10), 235, DoacoesStatus.Realizado, v3, u3);
                       
            _context.Osc.AddRange(o1, o2, o3);

            _context.Voluntario.AddRange(v1, v2, v3);

            _context.Usuario.AddRange(u1, u2, u3);

            _context.Insumo.AddRange(i1, i2, i3);

            _context.Doacao.AddRange(d1, d2, d3);

            _context.SaveChanges();

        }
    }
}