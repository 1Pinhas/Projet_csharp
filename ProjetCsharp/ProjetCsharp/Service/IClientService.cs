using ProjetCsharp.Models;

namespace ProjetCsharp.Service;

public interface IClientService
{
    IEnumerable<Client> GetAllClients();
    Client GetClientById(int id);
    void AddClient(Client client);
    void UpdateClient(Client client);
    void DeleteClient(int id);


}

