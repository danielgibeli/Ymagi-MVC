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
            if (
                _context.Osc.Any() ||
                _context.Membro.Any() ||
                _context.Usuario.Any() ||
                _context.Produto.Any() ||
                _context.Fornecedor.Any() ||
                _context.Recebimento.Any() ||
                _context.Doacao.Any()||
                _context.Entrega.Any()
                )
            {
                return; //DB já foi populado
            }

            Osc osc1 = new Osc(1, "Ymagi Social", "Ymagi", "123456789",
                "Daniel", "daniel@ymagi", "1234567", "Cep", "Holanda", "1054", "2",
                "Vila Mariana", "Ribeirao Preto", "SP", "Daniel", "Adm");
            Osc osc2 = new Osc(2, "Mentoria Social", "Mentoria", "123456789",
                "Gisele", "daniel@ymagi", "1234567", "Cep", "Holanda", "1054", "2",
                "Vila Mariana", "Ribeirao Preto", "SP", "Daniel", "Adm");
            Osc osc3 = new Osc(3, "Resolvi Mudar", "Resolvi Mudar", "123456789",
               "Paula", "daniel@ymagi", "1234567", "Cep", "Holanda", "1054", "2",
               "Vila Mariana", "Ribeirao Preto", "SP", "Daniel", "Adm");

            Membro mem1 = new Membro(1, "Daniel Gibeli", "12345678", "2548255", "254455225", "email",
                new DateTime(1984, 08, 03), "Masc", "Solteiro", "3", new DateTime(2020, 09, 05), "14075240",
                "Holanda", "1054", "m", "vl mariana", "ribeirao", "SP", osc1);
            Membro mem2 = new Membro(2, "Gisele", "12345678", "2548255", "254455225", "email",
                new DateTime(1984, 08, 03), "Masc", "Solteiro", "2", new DateTime(2020, 09, 05), "14075240",
                "Holanda", "1054", "m", "vl mariana", "ribeirao", "SP", osc2);

            Usuario us1 = new Usuario(1, "Daniel", "123456", "123456", "25487", "daniel@gmail", new DateTime(1980, 05, 03),
                "Masc", "Casado", "2", new DateTime(2020, 09, 05), "14075210", "Guiana", "450", "34m", "Vl Mariana", "Ribs", "SP",mem1);
            Usuario us2 = new Usuario(2, "Giseli", "123456", "12345", "25487", "daniel@gmail", new DateTime(1980, 05, 03),
                "Masc", "Casado", "1", new DateTime(2020, 09, 05), "14075210", "Guiana", "450", "34m", "Vl Mariana", "Ribs", "SP", mem2);


            Fornecedor for1 = new Fornecedor(1, mem1, "Ymagi Gestao Ltda", "Ymagi", "123456789", "Cep", "Holanda",
                "1054", "casa", "Vl Mariana", "Ribeirao Preto", "SP", "Daniel", "999945651", "daniel@ymagi.com");
            Fornecedor for2 = new Fornecedor(2, mem1, "Copapar", "Copapar", "123456789", "Cep", "Holanda",
               "1054", "casa", "Vl Mariana", "Ribeirao Preto", "SP", "Daniel", "999945651", "daniel@ymagi.com");

            Produto p1 = new Produto(1, "Arroz", "KG", 10, 10, 15, 15, new DateTime(1985, 07, 03), for1);
            Produto p2 = new Produto(2, "Feijão", "KG", 10, 10, 15, 15, new DateTime(1985, 07, 03), for2);

            Entrega en1 = new Entrega(1, new DateTime(2020, 09, 05), 100, us1,2,DoacoesStatus.Programado);
            Entrega en2 = new Entrega(2, new DateTime(2020, 08, 03), 100, us2,2, DoacoesStatus.Cancelado);
            Entrega en3 = new Entrega(3, new DateTime(2020, 10, 11), 100, us2,1, DoacoesStatus.Realizado);

            Recebimento rec1 = new Recebimento(1, new DateTime(2020, 09, 05), 200, us1, mem1,for1,DoacoesStatus.Programado);
            Recebimento rec2 = new Recebimento(2, new DateTime(2020, 02, 12), 150, us1, mem1,for2,DoacoesStatus.Realizado);

            Doacao doa1 = new Doacao(1, new DateTime(2020, 02, 10), 100, DoacoesStatus.Realizado, mem1, us2);
            Doacao doa2 = new Doacao(2, new DateTime(2020, 08, 03), 100, DoacoesStatus.Realizado, mem2, us1);


            _context.Osc.AddRange(osc1, osc2, osc3);
            _context.Membro.AddRange(mem1, mem2);
            _context.Usuario.AddRange(us1, us2);
            _context.Fornecedor.AddRange(for1, for2);
            _context.Produto.AddRange(p1, p2);
            _context.Entrega.AddRange(en1, en2);
            _context.Recebimento.AddRange(rec1, rec2);
            _context.Doacao.AddRange(doa1, doa2);

            _context.SaveChanges();

        }
    }
}
