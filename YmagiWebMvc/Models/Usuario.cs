using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YmagiWebMvc.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Cep { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Observacao { get; set; }
        public ICollection<Doacao> Doacaos { get; set; } = new List<Doacao>();

        public Usuario()
        {
        }

        public Usuario(int id, string nome, int cpf, int telefone, string email, 
            DateTime nascimento, DateTime dataCadastro, int cep, string rua, int numero, 
            string complemento, string bairro, string cidade, string estado, string observacao)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Nascimento = nascimento;
            DataCadastro = dataCadastro;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Observacao = observacao;
        }
    }
}
