using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsDbApp.DTO;
using StudentsDbApp.Models;
using StudentsDbApp.Services;

namespace StudentsDbApp.Pages.Students
{
    public class CreateModel : PageModel
    {
        public List<Error> ErrorArray { get; set; } = new();
        
        public StudentInsertDTO StudentInsertDto { get; set; } = new();

        private readonly IStudentService? _studentService;
        private readonly IValidator<StudentInsertDTO> _studentInsertValidator;

        public CreateModel(IStudentService? studentService,
                        IValidator<StudentInsertDTO> studentInsertValidator)

        {
            _studentService = studentService;
            _studentInsertValidator = studentInsertValidator;
        }

        public void OnGet()
        {
        }

        public void OnPost(StudentInsertDTO dto)
        {
            // When Submit cliscked and the Page Refreshes the text-boxes retain the old values
            StudentInsertDto = dto;
            var validationResult = _studentInsertValidator.Validate(dto);
            if  (!validationResult.IsValid) 
            { 
                foreach (var error in validationResult.Errors)
                {
                    ErrorArray!.Add(new Error(error.ErrorCode,error.ErrorMessage,error.PropertyName));
                }
                return;
            }
            try 
            {
                Student student = _studentService?.InsertStudent(dto)!;
                Response.Redirect("/Students/getall");
            } catch (Exception ex)
            {
                ErrorArray!.Add(new Error("", ex.Message, ""));
            }
        }
    }
}
