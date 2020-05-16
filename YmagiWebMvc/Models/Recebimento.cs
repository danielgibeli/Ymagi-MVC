using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YmagiWebMvc.Models.Enums;

namespace YmagiWebMvc.Models
{
    public class Recebimento
    {
        public int Id { get; set; }
        public Produto  Produto { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnit { get; set; }
        public double ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public Usuario Usuario { get; set; }
        public Membro Membro { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DoacoesStatus Status { get; set; }

        public Recebimento()
        {
        }

        public Recebimento(int id, Produto produto, double quantidade, double total, double valorUnit, 
            double valorTotal, DateTime data, Usuario usuario, Membro membro, Fornecedor fornecedor, DoacoesStatus status)
        {
            Id = id;
            Produto = produto;
            Quantidade = quantidade;
            ValorUnit = valorUnit;
            ValorTotal = valorTotal;
            Data = data;
            Usuario = usuario;
            Membro = membro;
            Fornecedor = fornecedor;
            Status = status;
        }
    }
}
