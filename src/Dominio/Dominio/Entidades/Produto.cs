using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Produto
    {
        public Produto(string nomeDoProduto, 
            int quantidade, 
            decimal preco, 
            Fornecedor fornecedor, 
            string categoria, 
            string cnpj)
        {
            NomeDoProduto = nomeDoProduto;
            Quantidade = quantidade;
            Preco = preco;
            Fornecedor = fornecedor;
            Categoria = categoria;
            Cnpj = cnpj;
        }

        public int Id { get; private set; }
        public string NomeDoProduto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }
        public Fornecedor Fornecedor { get; private set; }
        public string Categoria { get; private set; }
        public string Cnpj { get; private set; }
        public string Descricao { get; private set; }

    }
}
