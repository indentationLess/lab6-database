using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab6.Pages
{
	public class CreateModel : PageModel
	{
		[BindProperty]
		public string TaskTitle { get; set; }

		public IActionResult OnPost()
		{
			IndexModel.Tasks.Add(TaskTitle);
			TempData["SuccessMessage"] = "task has been added successfully";
			return RedirectToPage("Index");
		}
	}

}