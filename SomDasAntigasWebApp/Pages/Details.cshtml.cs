using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SomDasAntigasWebApp.Models;
using SomDasAntigasWebApp.Services;

namespace SomDasAntigasWebApp.Pages
{
    public class DetailsModel : PageModel
    {
        private IDiscService _service;
        public DetailsModel(IDiscService service)
        {
            _service = service;
        }
        public Disc Disc { get; private set; }
        public IActionResult OnGet(int id)
        {
            Disc = _service.Get(id);

            if (Disc == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
