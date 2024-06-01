using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter.Models;

namespace WebAppStarter.Pages.Students
{
    public class IndexModel : PageModel
    {
        public List<Student> Students { get; set; } = null!;
        public IActionResult OnGet()
        {

            ViewData["Title"] = "Coding Factory Students";

            if (Request.Query.TryGetValue("Lastname", out var lastname))
            {
                if (lastname == "Androutsos")
                {
                    Students = new List<Student>()
                    {
                        new Student() { Id = 1, Firstname = "George", Lastname = "Androutsos" }
                    };
                }
                return Page();
            }

            Students = new List<Student>()
            {
            new Student() { Id = 1, Firstname = "George", Lastname = "Androutsos" },
            new Student() { Id = 2, Firstname = "Alice", Lastname = "A." },
            new Student() { Id = 3, Firstname = "Bob", Lastname = "B." },
            new Student() { Id = 4, Firstname = "Chris", Lastname = "C." }
            };
            return Page();

        }
    }
}
