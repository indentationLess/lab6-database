using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab6.Pages;

public class IndexModel : PageModel
{
    public static List<string> Tasks { get; set; } = new List<string>();

    public void OnGet() { }
}
