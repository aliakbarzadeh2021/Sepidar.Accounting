using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditProductOrderBOMItemCommandValidator : AbstractValidator<EditProductOrderBOMItemCommand>
    {
        public EditProductOrderBOMItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
