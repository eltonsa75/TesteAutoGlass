using AutoMapper;
using EmprestimoLivros.DTO;
using EmprestimoLivros.Interfaces;
using EmprestimoLivros.Models;
using EmprestimoLivros.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;


        public ClienteController(IClienteRepository clienteRepository, IMapper mapper)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            var clientes = await _clienteRepository.SelecionarTodos();
            var clientesDTO = _mapper.Map<IEnumerable<ClienteDTO>>(clientes);
            return Ok(clientesDTO);
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarCliente(ClienteDTO clienteDTO)
        {

            var cliente = _mapper.Map<Cliente>(clienteDTO);
            _clienteRepository.Incluir(cliente);
            if(await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente cadastrado com Sucesso!");
            }

            return BadRequest("Ocorreu um erro ao salvar o cliente. ");
        }
        [HttpPut]
        public async Task<ActionResult> AlterarCliente(ClienteDTO clienteDTO)
        {
            if(clienteDTO.Id == null)
            {
                return BadRequest("Não foi possivel alterar os dados do cliente, precisa informar o ID.");
            }

            var clienteExitente = await _clienteRepository.SelecionarByPK(clienteDTO.Id);
            if(clienteExitente == null)
            {
                return NotFound("Esse cliente não existe");
            }

            var cliente = _mapper.Map<Cliente>(clienteDTO);
            _clienteRepository.Alterar(cliente);

            if ( await _clienteRepository.SaveAllAsync()) {

                return Ok("Cliente atualizado com sucesso! ");
            }
            return BadRequest("Ocorreu um erro durante atualização dados do Cliente.");
                
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluirCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPK(id);

            if (cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }
            _clienteRepository.Excluir(cliente);

            if( await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente excluido com sucesso!");
            }
            return BadRequest("Ocorreu um erro ao excluir um clinete.");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> SelecionarCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPK(id);

            if(cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            var clienteDTO = _mapper.Map<ClienteDTO>(cliente);

            return Ok(clienteDTO);
        }

        
    }
}
