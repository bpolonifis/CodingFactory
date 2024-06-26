using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsDbApp.Models;
using StudentsDbApp.Services;

namespace StudentsDbApp.Pages.Students
{
    public class DeleteModel : PageModel
    {
        public List<Error> ErrorArray { get; set; } = new();
        private readonly IStudentService _studentService;

        public DeleteModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void OnGet()
        {
            try
            {
                Student student = _studentService.DeleteStudent(  id);
                Response.Redirect("/Students/getall");
            } catch (Exception ex)
            {
                ErrorArray.Add(new Error("", ex.Message,""));

            }
        }
    }
}
