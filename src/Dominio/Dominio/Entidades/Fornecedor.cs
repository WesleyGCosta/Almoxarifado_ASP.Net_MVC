using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Fornecedor
    {
        public Fornecedor(string nome, string razaoSocial, string cnpj, string telefone, string email, string endereco, string bairro, string complemento)
        {
            Nome = nome;
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Bairro = bairro;
            Complemento = complemento;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
        public string Bairro { get; private set; }
        public string Complemento { get; private set; }

        public IEnumerable<Produto> Produtos { get; private set; }

        public void AtualizarFornecedor(string nome, string razaoSocial, string cnpj, string telefone, string email, string endereco, string bairro, string complemento)
        {
            this.Nome = nome;
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.Telefone = telefone;
            this.Email = email;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Complemento = complemento;
        }
    }
}
