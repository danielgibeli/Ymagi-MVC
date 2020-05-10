using System;
using System.ComponentModel.DataAnnotations;
using YmagiWebMvc.Models.Enums;

namespace YmagiWebMvc.Models
{
    public class Doacao
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyy}")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        public double Total { get; set; }
        public DoacoesStatus Status { get; set; }
        public Membro Membro { get; set; }
        public Usuario Usuario { get; set; }

        public Doacao()
        {
        }

        public Doacao(int id, DateTime data, double total, DoacoesStatus status, Membro membro, Usuario usuario)
        {
            Id = id;
            Data = data;
            Total = total;
            Status = status;
            Membro = membro;
            Usuario = usuario;
        }
    }
}
