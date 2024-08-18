using Activity.Dto.Product;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Validations.Validators.Product;
public class UpdateProductRequestValidation : AbstractValidator<UpdateProductRequestDto>
{
    public UpdateProductRequestValidation()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
    }
}
