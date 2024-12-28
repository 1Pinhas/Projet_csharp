using ProjetCsharp.Models;

namespace ProjetCsharp.Service;

public interface IRsService
{
    IEnumerable<RS> GetAllRS(); 
    RS GetRSById(int id); 
    void AddRS(RS rs); 
    void UpdateRS(RS rs); 
    void DeleteRS(int id);
}
