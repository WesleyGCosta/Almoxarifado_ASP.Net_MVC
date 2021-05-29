using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Produto
    {
        public Produto(int fornecedorId, int clienteId, string nomeDoProduto, int quantidade, decimal preco, ECategoria categoria, string cnpj)
        {
            FornecedorId = fornecedorId;
            ClienteId = clienteId;
            NomeDoProduto = nomeDoProduto;
            Quantidade = quantidade;
            Preco = preco;
            Categoria = categoria;
            Cnpj = cnpj;
        }

        public int Id { get; private set; }
        public int FornecedorId { get; private set; }
        public int ClienteId { get; private set; }
        public string NomeDoProduto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }
        public ECategoria Categoria { get; private set; }
        public string Cnpj { get; private set; }
        public string Descricao { get; private set; }

        public Fornecedor Fornecedor { get; private set; }
        public Cliente Cliente { get; private set; }


        public void AtualizarProduto(string nomeDoProduto, int quantidade, decimal preco, ECategoria categoria, string cnpj)
        {
            this.NomeDoProduto = nomeDoProduto;
            this.Quantidade = quantidade;
            this.Preco = preco;
            this.Categoria = categoria;
            this.Cnpj = cnpj;
        }
    }
}
