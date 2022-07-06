using FluentValidation;
using FluentValidation.Results;
using System.Linq;

namespace Sepidar.Message.Extentions
{
    public static class ValidationResultExtension
    {
        public static void RaiseExceptionIfRequired(this ValidationResult validationResult)
        {
            if (!validationResult.IsValid)
                throw new ValidationException(string.Join("\n", validationResult.Errors.Select(x => x.ErrorMessage)));
        }
    }
}
