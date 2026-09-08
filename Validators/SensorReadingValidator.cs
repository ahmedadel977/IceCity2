using FluentValidation;
using ice_city.DTOs.REGUEST;

namespace ice_city.validators
{
    public class SensorReadingValidator : AbstractValidator<AddSensorReadingRequest>
    {
        public SensorReadingValidator()
        {
            RuleFor(x => x.HeaterId)
            .NotEmpty()
            .WithMessage("HeaterId is required.");

            RuleFor(x => x.HouseId)
                .NotEmpty()
                .WithMessage("HouseId is required.");

            RuleFor(x => x.UsageDate)
                .NotEmpty()
                .WithMessage("UsageDate is required.");

            RuleFor(x => x.HoursWorked)
                .GreaterThanOrEqualTo(0)
                .WithMessage("HoursWorked cannot be negative.");

            RuleFor(x => x.HeaterValue)
                .GreaterThanOrEqualTo(0)
                .WithMessage("HeaterValue cannot be negative.");
        }

    }
}
