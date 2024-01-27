using EmprestimoLivros.Interfaces;
using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ControleEmprestimoLivroContext _context;
           
        public ClienteRepository(ControleEmprestimoLivroContext context)
        {
            _context = context;
        }

        public void Alterar(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
        }

        public void Excluir(Cliente cliente)
        {
           _context.Cliente.Remove(cliente);
        }

        public void Incluir(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
        }

        public async Task<bool> SaveAllAsync()
        {
           return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Cliente> SelecionarByPK(int id)
        {
            return await _context.Cliente.Where(x => x.Id == id).FirstOrDefaultAsync();
            
        }

        public async Task<IEnumerable<Cliente>> SelecionarTodos()
        {
           return await _context.Cliente.ToListAsync();
        }
    }
}
