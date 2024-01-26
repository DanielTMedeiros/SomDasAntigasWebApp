using SomDasAntigasWebApp.Models;

namespace SomDasAntigasWebApp.Services.Memory;

public class DiscService : IDiscService
{
    public DiscService()
    {
        LoadInitialList();
    }

    private IList<Disc> _discList;

    public void LoadInitialList()
    {
        _discList = new List<Disc>() {
            new Disc
            {
                DiscId = 1,
                Name = "Holy Diver",
                Band = "Dio",
                Description = "Magia vocal de Ronnie James Dio, riffs monumentais, um álbum de metal clássico que eleva a potência e a reverência no universo do rock.",
                ImageUri = "/images/holydiver_dio.jpg",
                Price = 130.90,
                Release = 1986,
            },
            new Disc
            {
                DiscId = 2,
                Name = "Angels Cry",
                Band = "Angra",
                Description = "Angra transcende fronteiras, fundindo metal progressivo e melódico com virtuosismo instrumental e vocais arrebatadores, uma obra-prima brasileira.",
                ImageUri = "/images/angelscry_angra.jpg",
                Price = 447.90,
                Release = 1993,
            },
           new Disc
            {
                DiscId = 3,
                Name = "Avalon",
                Band = "Roxy Music",
                Description = "Roxy Music atinge o apogeu do glamour sonoro. Bryan Ferry seduz com vocais envolventes, enquanto sintetizadores criam um éden sonoro sofisticado.",
                ImageUri = "/images/avalon_roxymusic.jpg",
                Price = 153.90,
                Release = 1982,
            },
           new Disc
            {
                DiscId = 4,
                Name = "O Fruto Proibido",
                Band = "Rita Lee & Tutti Frutti ",
                Description = "Rita Lee em rebelião poética, misturando psicodelia e crítica, uma celebração transgressora que desafia tabus musicais e sociais.",
                ImageUri = "/images/frutoproibido_ritalee.jpg",
                Price = 240.00,
                Release = 1975,
            },
        };
    }

    public IList<Disc> GetAll()
    {
        return _discList;
    }

    public Disc Get(int id)
    {
        return GetAll().SingleOrDefault(item => item.DiscId == id);
    }

    public void Include(Disc disc)
    {
        var nextId = _discList.Max(item => item.DiscId) + 1;
        disc.DiscId = nextId;
        _discList.Add(disc);
    }

    public void Edit(Disc disc)
    {
        var discFound = _discList.SingleOrDefault(item => item.DiscId == disc.DiscId);

        discFound.Name = disc.Name;
        discFound.Band = disc.Band;
        discFound.Description = disc.Description;
        discFound.ImageUri = disc.ImageUri;
        discFound.Price = disc.Price;
        discFound.Release = disc.Release;
    }

    public void Delete(int id)
    {
        var discFound = Get(id);
        _discList.Remove(discFound);
    }

    public IList<Genre> GetAllGenres()
    {
        throw new NotImplementedException();
    }
}
