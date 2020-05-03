﻿using System;
using System.ComponentModel.DataAnnotations;
using YmagiWebMvc.Models.Enums;

namespace YmagiWebMvc.Models
{
    public class Doacao
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyy}")]

        public DateTime Data { get; set; }
        public double Total { get; set; }
        public DoacoesStatus Status { get; set; }
        public Voluntario Voluntario { get; set; }
        public Usuario Usuario { get; set; }

        public Doacao()
        {
        }

        public Doacao(int id, DateTime data, double total, DoacoesStatus status, Voluntario voluntario, Usuario usuario)
        {
            Id = id;
            Data = data;
            Total = total;
            Status = status;
            Voluntario = voluntario;
            Usuario = usuario;
        }
    }
}
