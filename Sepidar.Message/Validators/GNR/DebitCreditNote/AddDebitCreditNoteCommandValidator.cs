using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddDebitCreditNoteCommandValidator : AbstractValidator<AddDebitCreditNoteCommand>
    {
        public AddDebitCreditNoteCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
