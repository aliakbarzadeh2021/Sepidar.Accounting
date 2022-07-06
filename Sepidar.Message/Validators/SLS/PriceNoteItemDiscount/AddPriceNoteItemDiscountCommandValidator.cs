using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPriceNoteItemDiscountCommandValidator : AbstractValidator<AddPriceNoteItemDiscountCommand>
    {
        public AddPriceNoteItemDiscountCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
