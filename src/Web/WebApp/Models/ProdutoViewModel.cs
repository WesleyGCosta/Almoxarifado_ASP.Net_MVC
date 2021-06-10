using Dominio.Entidades;
using Dominio.Enums;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebApp.Models
{
    public class ProdutoViewModel
    {

        [HiddenInput]
        public int Id { get; set; }

        [DisplayName("Produto")]
        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public string NomeDoProduto { get; set; }

        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public int Quantidade{ get; set; }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public ECategoria Categoria { get; set; }

        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public Fornecedor Fornecedor { get; set; }

        [DisplayName("CNPJ")]
        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public string Cnpj { get; set; }
        
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}
