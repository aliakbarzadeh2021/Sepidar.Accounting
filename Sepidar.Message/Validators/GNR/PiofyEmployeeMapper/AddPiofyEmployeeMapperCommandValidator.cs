using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPiofyEmployeeMapperCommandValidator : AbstractValidator<AddPiofyEmployeeMapperCommand>
    {
        public AddPiofyEmployeeMapperCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
