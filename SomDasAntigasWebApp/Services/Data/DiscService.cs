using SomDasAntigasWebApp.Data;
using SomDasAntigasWebApp.Models;

namespace SomDasAntigasWebApp.Services.Data;

public class DiscService : IDiscService
{
    private DiscDbContext _context;
    public DiscService(DiscDbContext context) { _context = context; }
    public void Delete(int id)
    {
        var discFound = Get(id);
        _context.Disc.Remove(discFound);
        _context.SaveChanges();
    }

    public void Edit(Disc disc)
    {
        var discFound = Get(disc.DiscId);
        discFound.Name = disc.Name;
        discFound.Band = disc.Band;
        discFound.Description = disc.Description;
        discFound.ImageUri = disc.ImageUri;
        discFound.Price = disc.Price;
        discFound.Release = disc.Release;
        discFound.GenreId = disc.GenreId;
        _context.SaveChanges();
    }

    public Disc Get(int id)
    {
        return _context.Disc.SingleOrDefault(item => item.DiscId == id);
    }

    public IList<Disc> GetAll() => _context.Disc.ToList();

    public void Include(Disc disc)
    {
        _context.Disc.Add(disc);
        _context.SaveChanges();
    }
    public IList<Genre> GetAllGenres() => _context.Genre.ToList();
}
