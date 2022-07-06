using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPersonnelInitiateCommandValidator : AbstractValidator<AddPersonnelInitiateCommand>
    {
        public AddPersonnelInitiateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
