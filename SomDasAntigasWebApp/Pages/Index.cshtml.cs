using Microsoft.AspNetCore.Mvc.RazorPages;
using SomDasAntigasWebApp.Models;
using SomDasAntigasWebApp.Services;

namespace SomDasAntigasWebApp.Pages;

public class IndexModel : PageModel
{
    private IDiscService _service;
    public IndexModel(IDiscService service)
    {
        _service = service;
    }
    public IList<Disc> ListDisc { get; private set; }
    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        ListDisc = _service.GetAll();
    }
}
