using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditOrderingScheduleRelatedActivitiesCommandValidator : AbstractValidator<EditOrderingScheduleRelatedActivitiesCommand>
    {
        public EditOrderingScheduleRelatedActivitiesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
