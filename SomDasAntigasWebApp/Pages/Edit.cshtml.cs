using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SomDasAntigasWebApp.Models;
using SomDasAntigasWebApp.Services;

namespace SomDasAntigasWebApp.Pages;

public class EditModel : PageModel
{
    public SelectList GenreOptionItems { get; set; }

    private IDiscService _service;
    public EditModel(IDiscService service)
    {
        _service = service;
    }

    [BindProperty]
    public Disc Disc { get; set; }

    public IActionResult OnGet(int id)
    {
        Disc = _service.Get(id);

        GenreOptionItems = new SelectList(_service.GetAllGenres(),
nameof(Genre.GenreId),
nameof(Genre.GenreName));

        if (Disc == null)
        {
            return NotFound();
        }

        return Page();
    }

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

    public IActionResult OnPostExclusao()
    {
        _service.Delete(Disc.DiscId);

        return RedirectToPage("/Index");

    }
}
