using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddCommunicationConfigurationCommandValidator : AbstractValidator<AddCommunicationConfigurationCommand>
    {
        public AddCommunicationConfigurationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
