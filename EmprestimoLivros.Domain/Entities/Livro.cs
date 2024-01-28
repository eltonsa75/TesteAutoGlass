using EmprestimoLivros.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoLivros.Domain.Entities
{
    public  class Livro
    {

        public int Id {  get; private set; }
        public string Nome {  get; private set; }
        public string Autor {  get; private set; }
        public string Editora { get; private set; }

        public Livro(int id, string nome, string autor, string editora)
        {
            DomainExceptionValidation.When(id < 0, "O Id não pode ser negativo");
            this.Id = id;
            ValidateDomain(nome, autor, editora);
        }

        public Livro(string nome, string autor, string editora)
        {
            ValidateDomain(nome, autor, editora);
        }

        public void ValidateDomain( string nome, string autor, string editora )
        {

            DomainExceptionValidation.When(nome.Length > 50, "O Nome deve ter no máximo 50 caracteres.");
            DomainExceptionValidation.When(autor.Length > 20, "O Autor deve ter no máximo 20 caractertes");
            DomainExceptionValidation.When(editora.Length > 20, "A Editora deve ter no máximo 20 caracteres");

            this.Nome = nome;
            this.Autor = autor;
            this.Editora = editora;
        }
    }

}
