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

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="{0} deve conter no mínimo {2} caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "{0} digite um email válido!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [DataType(DataType.PhoneNumber)]
        public double Celular { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [DataType(DataType.PhoneNumber)]
        public double Telefone { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name ="Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Organização Social")]
        public Osc Osc { get; set; }

        [Display(Name = "Selecione uma Organização Social")]
        public int OscId { get; set; }

        public ICollection<Doacao> Doacoes { get; set; } = new List<Doacao>();

        public ICollection<Insumo> Insumos { get; set; } = new List<Insumo>(); 

        public Voluntario()
        {
        }

        public Voluntario(int id, string nome, string email, double celular, double telefone, 
            DateTime nascimento, Osc osc)
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

        public void AdInsumo(Insumo insumo)
        {
            Insumos.Add(insumo);
        }

        public void ReDoacao(Doacao doa)
        {
            Doacoes.Remove(doa);
        }

        public void ReInsumo(Insumo insumo)
        {
            Insumos.Remove(insumo);
        }

        public double TotalDoacoes(DateTime inicial, DateTime final)
        {
            return Doacoes.Where(doa => doa.Data >= inicial && doa.Data <= final).Sum(doa => doa.Total);
        }

        public double TotalInsumos(DateTime inicial, DateTime final)
        {

            return Insumos.Where(ins => ins.Date >= inicial && ins.Date <= final).Sum(ins => ins.SaldoEstoque);
        }
    }
}
