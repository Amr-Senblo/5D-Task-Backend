using _5D_Task.Models;
using _5D_Task.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _5D_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClients()
        {
            var clients = await _clientService.GetAll();

            return Ok(clients);
        }

        [HttpGet("{id}")]

        public async Task <IActionResult> GetOneClient(int id )
        {
            var client = await _clientService.GetById(id);
            return Ok(client);
        }

        [HttpPost]
        public async Task <IActionResult> AddClient(ClientDTO ClientDTO)
        {
            var client = new Client { Name = ClientDTO.Name ,Weight = ClientDTO.Weight , Photo = ClientDTO.Photo, DateOfBirth = ClientDTO.DateOfBirth};

            await _clientService.Add(client);

            return Ok(client);
        }


        [HttpPut("{id}")]
        public async Task <IActionResult> UpdateClient(int id , ClientDTO clientDTO)
        {
            var client = await _clientService.GetById(id);
            
            if (client is null )
            {
                return NotFound($"No clinet was found with ID: {id}");
            }

            client.Name = clientDTO.Name;
            client.Weight = clientDTO.Weight;
            client.Photo = clientDTO.Photo;
            client .DateOfBirth = clientDTO.DateOfBirth;

            _clientService.Update(client);

            return Ok(client);
        }


        [HttpDelete("{id}")]
        public async Task <IActionResult> DeleteClient(int id )
        {
            var client = await _clientService.GetById(id);

            if (client is null)
            {
                return NotFound($"No clinet was found with ID: {id}");
            }

            _clientService.Delete(client);
                
            return Ok(client);

        }
    }
}
