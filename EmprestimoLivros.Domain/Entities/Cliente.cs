using EmprestimoLivros.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoLivros.Domain.Entities
{
    public  class Cliente
    {
        public int Id {  get; private set; }
        public string CPF { get; private set; }
        public string Nome { get; private set; } 
        public string Endereco { get; private set; }  
        public string Cidade { get; private set; } 
        public string Bairro { get; private set; } 
        public string Numero { get; private set; }
        public string TelefoneCelular { get; private set; }
        public string TelefoneFixo { get; private set; }

        public Cliente(int id, string cpf, string nome, string endereco, string cidade, string bairro, string numero, string telefoneCelular, string telefoneFixo)
        {
            DomainExceptionValidation.When(id < 0, "O ID não pode ser negativo");
            this.Id = id;
            ValidateDomain(cpf, nome, endereco, cidade, bairro, numero, telefoneCelular, telefoneFixo);
        }


        public Cliente( string cpf, string nome, string endereco, string cidade, string bairro, string numero, string telefoneCelular, string telefoneFixo)
        {

            ValidateDomain(cpf, nome, endereco, cidade, bairro, numero, telefoneCelular, telefoneFixo);
        }

        public void Update(string cpf, string nome, string endereco, string cidade, string bairro, string numero, string telefoneCelular, string telefoneFixo)
        {
            ValidateDomain(cpf, nome, endereco, cidade, bairro, numero, telefoneCelular, telefoneFixo);
        }

        public void ValidateDomain(string cpf, string nome, string endereco, string cidade, string bairro, string numero, string telefoneCelular, string telefoneFixo)
        {

            DomainExceptionValidation.When(cpf.Length != 11, "O CPF deve ter 11 caracteres.");
            DomainExceptionValidation.When(nome.Length > 200, "O Nome deve ter, no máximo, 200 caracteres.");
            DomainExceptionValidation.When(endereco.Length > 50, "O Endereço deve ter, no máximo 50 caracteres.");
            DomainExceptionValidation.When(cidade.Length > 50, "A Cidade deve ter, no máximo, 50 caracteres.");
            DomainExceptionValidation.When(bairro.Length > 50, "O Bairro deve ter, no máximo, 50 caracteres.");
            DomainExceptionValidation.When(numero.Length > 20, "O Número deve ter, no máximo, 20 caracteres.");
            DomainExceptionValidation.When(telefoneCelular.Length > 11, "O Telefone Celular deve ter, no máximo, 11 caracteres.");
            DomainExceptionValidation.When(telefoneFixo.Length > 10, "O Telefone Fixo deve ter, no máximo, 10 caracteres.");


            this.CPF = cpf;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Numero = numero;
            this.TelefoneCelular = telefoneCelular;
            this.TelefoneFixo = telefoneFixo;
        }
    }
}
