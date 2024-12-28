using ProjetCsharp.Data;
using ProjetCsharp.Models;
using System.Data.Entity;

namespace ProjetCsharp.Service.Impl;

public class RsService : IRsService
{
    private readonly ApplicationDbContext _context;

    public RsService(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<RS> GetAllRS()
    {
        return _context.RS.ToList();
    }

    public RS GetRSById(int id)
    {
        return _context.RS.Find(id);
    }

    public void AddRS(RS rs)
    {
        _context.RS.Add(rs);
        _context.SaveChanges();
    }

    public void UpdateRS(RS rs)
    {
        _context.Entry(rs).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void DeleteRS(int id)
    {
        var rs = _context.RS.Find(id);
        if (rs != null)
        {
            _context.RS.Remove(rs);
            _context.SaveChanges();
        }
    }
}

