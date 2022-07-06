using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditContractEmployerMaterialsItemCommandValidator : AbstractValidator<EditContractEmployerMaterialsItemCommand>
    {
        public EditContractEmployerMaterialsItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
