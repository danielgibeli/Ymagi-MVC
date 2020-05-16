                                                                                                                                                    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YmagiWebMvc.Models.Enums;

namespace YmagiWebMvc.Models
{
    public class Entrega
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnit { get; set; }
        public double ValorTotal { get; set; }
        public Usuario Usuario { get; set; }
        public Membro Membro { get; set; }
        public DoacoesStatus Status { get; set; }



        public Entrega()
        {
        }

        public Entrega(int id, Usuario usuario, Produto produto, Membro membro, 
            DateTime data, double quantidade, double total, DoacoesStatus status)
        {
            Id = id;
            Usuario = usuario;
            Produto = produto;
            Membro = membro;
            Data = data;
            Quantidade = quantidade;
            Status = status;
        }
    }
}
