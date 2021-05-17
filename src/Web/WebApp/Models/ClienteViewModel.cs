using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "*Campo Obrigatório!")]
        [StringLength(50, ErrorMessage = "* O Nome precisa ter no mínimo 8 Letras!", MinimumLength = 8)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        public string Sexo{ get; set; }

    }
}
