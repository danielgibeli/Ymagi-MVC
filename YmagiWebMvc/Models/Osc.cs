﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace YmagiWebMvc.Models
{
    public class Osc
    {
        public int Id { get; set; }

        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Display(Name = "Endereço: Rua, Avenida, etc...")]
        public string Endereço { get; set; }

        [Display(Name = "Número")]
        public int Numero { get; set; }

        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public string Contato { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "{0} digite um email válido!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Voluntários")]
        public ICollection<Voluntario> Voluntarios { get; set; } = new List<Voluntario>();

        public Osc()
        {
        }

        public Osc(int id, string razaoSocial, string nomeFantasia, string endereço, int numero, 
            string complemento, string bairro, string cidade, string estado, string contato, string telefone, string email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Endereço = endereço;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public void AddVoluntario(Voluntario voluntario)
        {
            Voluntarios.Add(voluntario);
        }

        public void RemVoluntario(Voluntario voluntario)
        {
            Voluntarios.Remove(voluntario);
        }

        public double TotalDoacoes(DateTime inicial, DateTime final)
        {
            return Voluntarios.Sum(Voluntarios => Voluntarios.TotalDoacoes(inicial, final));
        }
    }
}
