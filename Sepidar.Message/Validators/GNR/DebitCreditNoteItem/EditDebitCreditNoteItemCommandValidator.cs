using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditDebitCreditNoteItemCommandValidator : AbstractValidator<EditDebitCreditNoteItemCommand>
    {
        public EditDebitCreditNoteItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
