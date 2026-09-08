using FluentValidation;
using JWTRefreshTokenInDotNet6.Models;

namespace ice_city.validators
{
    public class RegisterModelValidator : AbstractValidator<RegisterModel>
        {
            public RegisterModelValidator()
            {
                RuleFor(x => x.Username)
                    .NotEmpty()
                    .WithMessage("Username is required.")
                    .MinimumLength(3)
                    .MaximumLength(50);

                RuleFor(x => x.Email)
                    .NotEmpty()
                    .WithMessage("Email is required.")
                    .EmailAddress()
                    .WithMessage("Invalid email format.");

                RuleFor(x => x.Password)
                    .NotEmpty()
                    .WithMessage("Password is required.")
                    .MinimumLength(8)
                    .WithMessage("Password must be at least 8 characters.");

                RuleFor(x => x.FirstName)
                    .NotEmpty()
                    .WithMessage("First name is required.")
                    .MaximumLength(50);

                RuleFor(x => x.LastName)
                    .NotEmpty()
                    .WithMessage("Last name is required.")
                    .MaximumLength(50);

                RuleFor(x => x.Role)
                    .NotEmpty()
                    .WithMessage("Role is required.")
                    .Must(role =>
                        role.Equals("User", StringComparison.OrdinalIgnoreCase) ||
                        role.Equals("Owner", StringComparison.OrdinalIgnoreCase) ||
                        role.Equals("Operator", StringComparison.OrdinalIgnoreCase))
                    .WithMessage("Role must be User, Owner, or Operator.");
            }
        }
    }

}
