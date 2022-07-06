using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPersonnelInitiateElementCommandValidator : AbstractValidator<AddPersonnelInitiateElementCommand>
    {
        public AddPersonnelInitiateElementCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
