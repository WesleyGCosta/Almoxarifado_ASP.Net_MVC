using Dominio.Enums;
using System;

namespace Dominio.Entidades
{
    public class Cliente
    {

        public Cliente(string nome, string telefone, string endereco, string cpf, DateTime dataDeNascimento, string bairro, ESexo sexo)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Cpf = cpf;
            DataDeNascimento = dataDeNascimento;
            Bairro = bairro;
            Sexo = sexo;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
        public string Bairro { get; private set; }
        public ESexo Sexo { get; private set; }

        public void AtualizarCliente(string nome, string cpf,
            DateTime dataDeNascimento, string telefone,
            string endereco, string bairro, ESexo sexo)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataDeNascimento = dataDeNascimento;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Sexo = sexo;
        }
        
    }
}
