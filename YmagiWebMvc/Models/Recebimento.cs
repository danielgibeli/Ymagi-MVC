﻿using System;
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
        public double Total { get; set; }
        public double ValorUnit { get; set; }
        public double ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public Usuario Usuario { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public DoacoesStatus Status { get; set; }

        public Recebimento()
        {
        }

        public Recebimento(int id, DateTime data, double total, Usuario usuario, 
            Membro membro, Fornecedor fornecedor, DoacoesStatus status)
        {
            Id = id;
            Data = data;
            Total = total;
            Usuario = usuario;
            Fornecedor = fornecedor;
            Status = status;
        }
    }
}
