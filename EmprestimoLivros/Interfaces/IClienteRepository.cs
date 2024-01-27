using EmprestimoLivros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmprestimoLivros.Interfaces
{
    public interface IClienteRepository
    {
        void Incluir(Cliente cliente);

        void Alterar(Cliente cliente);

        void Excluir(Cliente cliente);
        Task<Cliente> SelecionarByPK(int id);
        Task<IEnumerable<Cliente>> SelecionarTodos();
        Task<bool> SaveAllAsync();
    }
}
