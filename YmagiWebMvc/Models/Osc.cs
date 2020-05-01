using System;
using System.Collections.Generic;
using System.Linq;


namespace YmagiWebMvc.Models
{
    public class Osc
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereço { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public ICollection<Voluntario> Voluntarios { get; set; } = new List<Voluntario>();

        public Osc()
        {
        }

        public Osc(int id, string razaoSocial, string nomeFantasia, string endereço, string contato, string telefone, string email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Endereço = endereço;
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
