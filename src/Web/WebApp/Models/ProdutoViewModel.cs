using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebApp.Models
{
    public class ProdutoViewModel
    {
        [DisplayName("Nome do produto")]
        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public string NomeDoProduto { get; set; }

        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public int Quantidade{ get; set; }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public string Fornecedor { get; set; }

        [DisplayName("CNPJ")]
        [Required(ErrorMessage = "*Campo é Obrigatório!")]
        public string Cnpj { get; set; }
        
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}
