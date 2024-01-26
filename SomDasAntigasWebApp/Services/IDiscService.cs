using SomDasAntigasWebApp.Models;

namespace SomDasAntigasWebApp.Services;

public interface IDiscService
{
    IList<Disc> GetAll();

    void Edit(Disc disc);

    void Delete(int id);

    Disc Get(int id);

    void Include(Disc disc);

    IList<Genre> GetAllGenres();




}
