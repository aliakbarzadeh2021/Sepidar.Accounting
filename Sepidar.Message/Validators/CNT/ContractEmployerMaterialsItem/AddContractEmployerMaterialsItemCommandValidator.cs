using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddContractEmployerMaterialsItemCommandValidator : AbstractValidator<AddContractEmployerMaterialsItemCommand>
    {
        public AddContractEmployerMaterialsItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
