using System.ComponentModel.DataAnnotations;

namespace SomDasAntigasWebApp.Models
{
    //[Table("TBL_DISC")]
    public class Disc
    {
        public int DiscId { get; set; }

        [Required(ErrorMessage = "Campo 'Album' obrigatório.")]
        [Display(Name = "Album")]
        public string Name { get; set; }
        public string NameSlug => Name.ToLower().Replace(" ", "-");

        [Required(ErrorMessage = "Campo 'Banda' obrigatório.")]
        [Display(Name = "Banda")]
        public string Band { get; set; }

        [Required(ErrorMessage = "Campo 'Descrição' obrigatório.")]
        [StringLength(150, MinimumLength = 100, ErrorMessage = "Campo 'Descrição deve ter entre 100 e 150 caracteres.")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Campo 'URL da imagem' obrigatório.")]
        [Display(Name = "Endereço da Imagem")]
        public string ImageUri { get; set; }

        [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Campo 'Lançamento' obrigatório.")]
        [Display(Name = "Lançamento")]
        public int Release { get; set; }

        [Display(Name = "Genero")]

        public int? GenreId { get; set; }

    }
}
