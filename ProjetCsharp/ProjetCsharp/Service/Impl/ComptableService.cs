using ProjetCsharp.Data;
using ProjetCsharp.Models;
using System.Data.Entity;

namespace ProjetCsharp.Service.Impl;

public class ComptableService : IComptableService
{
    private readonly ApplicationDbContext _context;

    public ComptableService(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Comptable> GetAllComptables()
    {
        return _context.Comptables.ToList();
    }

    public Comptable GetComptableById(int id)
    {
        return _context.Comptables.Find(id);
    }

    public void AddComptable(Comptable comptable)
    {
        _context.Comptables.Add(comptable);
        _context.SaveChanges();
    }

    public void UpdateComptable(Comptable comptable)
    {
        _context.Entry(comptable).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void DeleteComptable(int id)
    {
        var comptable = _context.Comptables.Find(id);
        if (comptable != null)
        {
            _context.Comptables.Remove(comptable);
            _context.SaveChanges();
        }
    }
}


