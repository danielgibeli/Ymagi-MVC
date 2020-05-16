using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YmagiWebMvc.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }
        public string InscEstadual { get; set; }
        public string Contato { get; set; }


        public string Cep { get; set; }

        public string Endereço { get; set; }

        [Display(Name = "Número")]
        public string Numero { get; set; }

        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        [Required(ErrorMessage = "{0} obrigatório")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "{0} digite um email válido!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public Membro Membro { get; set; }

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public ICollection<Recebimento> Recebimentos { get; set; } = new List<Recebimento>();



        public Fornecedor()
        {
        }

        public Fornecedor(int id, Membro membro,string razaoSocial, string nomeFantasia,
            string cnpj, string cep, string endereço, string     numero, string complemento,
            string bairro, string cidade, string estado, string contato,
            string telefone, string email)
        {
            Id = id;
            Membro = membro;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            Cep = cep;
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
    }
}
