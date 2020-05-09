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

        public Voluntario Voluntario { get; set; }

        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

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

        [Display(Name = "Fornecedores")]
        public ICollection<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();

        public Fornecedor()
        {
        }

        public Fornecedor(int id, Voluntario voluntario,string razaoSocial, string nomeFantasia,
            string cnpj, string endereço, int numero, string complemento,
            string bairro, string cidade, string estado, string contato,
            string telefone, string email)
        {
            Id = id;
            Voluntario = voluntario;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
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
