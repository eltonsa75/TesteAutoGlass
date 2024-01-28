using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.DTO
{
    public class ClienteDTO
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(14)]
        [MinLength(14, ErrorMessage = "O CPF deve ter no minimo, 14 caracteres")]
        [Unicode(false)]
        public string Cpf { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O Nome deve ter no máximo, 50 caracteres")]
        [Unicode(false)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O Endereço deve ter no máximo, 50 caracteres")]
        [Unicode(false)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O Cidade deve ter no máximo, 50 caracteres")]
        [Unicode(false)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O Bairro deve ter no máximo, 50 caracteres")]
        [Unicode(false)]
        public string Bairro { get; set; }

      
    }
}
