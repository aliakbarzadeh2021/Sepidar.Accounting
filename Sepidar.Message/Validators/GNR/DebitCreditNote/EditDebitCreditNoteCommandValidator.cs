using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditDebitCreditNoteCommandValidator : AbstractValidator<EditDebitCreditNoteCommand>
    {
        public EditDebitCreditNoteCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
