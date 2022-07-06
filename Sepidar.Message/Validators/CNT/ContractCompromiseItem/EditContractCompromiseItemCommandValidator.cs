using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditContractCompromiseItemCommandValidator : AbstractValidator<EditContractCompromiseItemCommand>
    {
        public EditContractCompromiseItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
