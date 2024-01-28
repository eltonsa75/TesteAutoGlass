using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoLivros.Domain.Entities
{
    public class LivroAlugado
    {
        public int Id { get; private set; }
        public int IdCliente {  get; private set; }
        public int IdLivro {  get; private set; }
        public DateTime DataEmprestimo {  get; private set; }
        public DateTime DataDevolucao { get; private set; }
        public bool Entregue {  get; private set; }

        public LivroAlugado(int id, int idCliente, int idLivro, DateTime dataEmprestimo, DateTime dataDevolucao, bool entregue)
        {
            this.Id = id;
        }
    }


}
