using Entities;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class PropertyValidator:AbstractValidator<Property>
{
    public PropertyValidator()
    {
        RuleFor(p => p.Title).NotEmpty();
        RuleFor(p => p.Title).MinimumLength(2);
        RuleFor(p => p.NumRooms).NotEmpty();
        RuleFor(p => p.NumBedrooms).NotEmpty();
        RuleFor(p => p.NumBathrooms).NotEmpty();
        RuleFor(p => p.Price).NotEmpty();
    }
}
