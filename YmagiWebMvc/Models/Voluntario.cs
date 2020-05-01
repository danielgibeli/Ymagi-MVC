using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace YmagiWebMvc.Models
{
    public class Voluntario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Celular { get; set; }
        public double Telefone { get; set; }
        public DateTime Nascimento { get; set; }
        public Osc Osc { get; set; }
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
