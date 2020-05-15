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
        public Usuario Usuario { get; set; }
        public Produto Produto { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public double Total { get; set; }
        public DoacoesStatus Status { get; set; }

        public Entrega()
        {
        }

        public Entrega(int id, DateTime data, double total, 
        Usuario usuario, int usuarioId, DoacoesStatus status)
        {
            Id = id;
            Data = data;
            Total = total;
            Usuario = usuario;
            Status = status;
        }
    }
}
