using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class FornecedorViewModel
    {
        [Required(ErrorMessage = "*Campo Obrigatório!")]
        [StringLength(50, ErrorMessage = "O nome precisa ter no mínimo 8 letras!", MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        [DisplayName("e-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        public string Bairro { get; set; }

        public string Complemento { get; set; }

    }
}
