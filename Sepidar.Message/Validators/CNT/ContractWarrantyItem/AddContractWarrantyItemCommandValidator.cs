using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddContractWarrantyItemCommandValidator : AbstractValidator<AddContractWarrantyItemCommand>
    {
        public AddContractWarrantyItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
