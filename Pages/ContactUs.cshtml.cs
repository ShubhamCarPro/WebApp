using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class ContactUsModel : PageModel
{
    private readonly ILogger<AboutUsModel> _logger;

    public ContactUsModel(ILogger<AboutUsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}