using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Produto
    {
        public Produto(int fornecedorId, string nomeDoProduto, 
            int quantidade, decimal preco, Fornecedor fornecedor, 
            ECategoria categoria, string cnpj)
        {
            FornecedorId = fornecedorId;
            NomeDoProduto = nomeDoProduto;
            Quantidade = quantidade;
            Preco = preco;
            Fornecedor = fornecedor;
            Categoria = categoria;
            Cnpj = cnpj;
        }

        public int Id { get; private set; }
        public int FornecedorId { get; private set; }
        public string NomeDoProduto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }
        public Fornecedor Fornecedor { get; private set; }
        public ECategoria Categoria { get; private set; }
        public string Cnpj { get; private set; }
        public string Descricao { get; private set; }

    }
}
