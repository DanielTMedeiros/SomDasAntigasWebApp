using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SomDasAntigasWebApp.Models;
using SomDasAntigasWebApp.Services;

namespace SomDasAntigasWebApp.Pages;

public class CreateModel : PageModel
{
    public SelectList GenreOptionItems { get; set; }
    private IDiscService _service;
    public CreateModel(IDiscService service)
    {
        _service = service;
    }

    public void OnGet()
    {
        GenreOptionItems = new SelectList(_service.GetAllGenres(),
        nameof(Genre.GenreId),
        nameof(Genre.GenreName));
    }

    [BindProperty]
    public Disc Disc { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Include(Disc);

        //com o modelo valido, o usuario sera encaminhado para a pag principal
        return RedirectToPage("/Index");
    }
}
