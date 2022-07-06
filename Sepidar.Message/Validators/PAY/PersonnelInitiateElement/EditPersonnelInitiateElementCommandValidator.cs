using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPersonnelInitiateElementCommandValidator : AbstractValidator<EditPersonnelInitiateElementCommand>
    {
        public EditPersonnelInitiateElementCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
