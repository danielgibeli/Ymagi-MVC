using System;
using YmagiWebMvc.Models.Enums;

namespace YmagiWebMvc.Models
{
    public class Doacao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public DoacoesStatus Status { get; set; }
        public Voluntario Voluntario { get; set; }

        public Doacao()
        {
        }

        public Doacao(int id, DateTime data, double total, DoacoesStatus status, Voluntario voluntario)
        {
            Id = id;
            Data = data;
            Total = total;
            Status = status;
            Voluntario = voluntario;
        }
    }
}
