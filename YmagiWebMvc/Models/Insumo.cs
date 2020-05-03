using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YmagiWebMvc.Models
{
    public class Insumo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public double Quantidade { get; set; }
        public double SaldoEstoque { get; set; }
        public double ValorUnit { get; set; }
        public double ValorTotal { get; set; }
        public DateTime Date { get; set; }

        public ICollection<Insumo> Insumos { get; set; } = new List<Insumo>();

        public Insumo()
        {
        }

        public Insumo(int id, string nome, string unidade, double quantidade,
            double saldoEstoque, double valorUnit, double valorTotal, DateTime date)
        {
            Id = id;
            Nome = nome;
            Unidade = unidade;
            Quantidade = quantidade;
            SaldoEstoque = saldoEstoque;
            ValorUnit = valorUnit;
            ValorTotal = valorTotal;
            Date = date;
        }

        public double TotalInsumos(DateTime inicial, DateTime final)
        {

            return Insumos.Where(ins => ins.Date >= inicial && ins.Date <= final).Sum(ins => ins.SaldoEstoque);
        }
    }
}
