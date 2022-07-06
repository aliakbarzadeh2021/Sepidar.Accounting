using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddContractCompromiseItemCommandValidator : AbstractValidator<AddContractCompromiseItemCommand>
    {
        public AddContractCompromiseItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
