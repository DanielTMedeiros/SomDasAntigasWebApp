namespace SomDasAntigasWebApp.Models;

public class Genre
{
    public int GenreId { get; set; }
    public string GenreName { get; set; }

    public ICollection<Disc> Discs { get; set; }
}
