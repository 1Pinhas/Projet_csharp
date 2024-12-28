using Microsoft.AspNetCore.Mvc;
using ProjetCsharp.Models;
using ProjetCsharp.Service.Impl;

namespace ProjetCsharp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly ClientService _clientService;

    public ClientController(ClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Client>> GetAllClients()
    {
        var clients = _clientService.GetAllClients();
        return Ok(clients);
    }

    [HttpGet("{id}")]
    public ActionResult<Client> GetClientById(int id)
    {
        var client = _clientService.GetClientById(id);
        if (client == null)
        {
            return NotFound();
        }
        return Ok(client);
    }

    [HttpPost]
    public ActionResult AddClient(Client client)
    {
        _clientService.AddClient(client);
        return CreatedAtAction(nameof(GetClientById), new { id = client.ClientId }, client);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateClient(int id, Client client)
    {
        if (id != client.ClientId)
        {
            return BadRequest();
        }
        _clientService.UpdateClient(client);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteClient(int id)
    {
        _clientService.DeleteClient(id);
        return NoContent();
    }
}

