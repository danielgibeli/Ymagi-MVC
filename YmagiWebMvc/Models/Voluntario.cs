            using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace YmagiWebMvc.Models
{
    public class Voluntario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public double Celular { get; set; }
        public double Telefone { get; set; }

        [Display(Name ="Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Organização Social")]
        public Osc Osc { get; set; }

        [Display(Name = "Selecione uma Organização Social")]
        public int OscId { get; set; }
        public ICollection<Doacao> Doacoes { get; set; } = new List<Doacao  >();

        public Voluntario()
        {
        }

        public Voluntario(int id, string nome, string email, double celular, double telefone, DateTime nascimento, Osc osc)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Celular = celular;
            Telefone = telefone;
            Nascimento = nascimento;
            Osc = osc;
        }

        public void AdDoacao(Doacao doa)
        {
            Doacoes.Add(doa);
        }

        public void ReDoacao(Doacao doa)
        {
            Doacoes.Remove(doa);
        }

        public double TotalDoacoes(DateTime inicial, DateTime final)
        {
            return Doacoes.Where(doa => doa.Data >= inicial && doa.Data <= final).Sum(doa => doa.Total);
        }
    }
}
