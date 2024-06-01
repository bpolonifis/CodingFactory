using FluentValidation;
using StudentsDbApp.DTO;

namespace StudentsDbApp.Validators
{
    public class StudentInsertValidator : AbstractValidator<StudentInsertDTO>
    {
        public StudentInsertValidator()
        {
            RuleFor(s => s.Firstname).NotEmpty()
                .WithMessage("Το πεδίο Όνομα δεν μπορεί να είναι κενό")
                .Length(2,255).WithMessage("Το πεδίο Όνομα πρέπει να είναι μεταξύ 2-255");
            RuleFor(s => s.Lastname).NotEmpty()
                .WithMessage("Το πεδίο Επίθετο δεν μπορεί να είναι κενό")
                .Length(2, 255).WithMessage("Το πεδίο Επίθετο πρέπει να είναι μεταξύ 2-255");
        }

    }
}
