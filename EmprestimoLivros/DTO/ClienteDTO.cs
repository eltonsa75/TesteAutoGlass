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
        [MinLength(14)]
        [Unicode(false)]
        public string Cpf { get; set; }

        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Bairro { get; set; }

      
    }
}
