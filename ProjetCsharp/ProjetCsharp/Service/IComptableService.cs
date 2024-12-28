using ProjetCsharp.Models;

namespace ProjetCsharp.Service;

public interface IComptableService
{
    IEnumerable<Comptable> GetAllComptables();
    Comptable GetComptableById(int id);
    void AddComptable(Comptable comptable);
    void UpdateComptable(Comptable comptable);
    void DeleteComptable(int id);
}


