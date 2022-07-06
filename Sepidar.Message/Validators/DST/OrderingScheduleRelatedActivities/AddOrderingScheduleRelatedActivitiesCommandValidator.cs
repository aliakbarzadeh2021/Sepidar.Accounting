using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddOrderingScheduleRelatedActivitiesCommandValidator : AbstractValidator<AddOrderingScheduleRelatedActivitiesCommand>
    {
        public AddOrderingScheduleRelatedActivitiesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
