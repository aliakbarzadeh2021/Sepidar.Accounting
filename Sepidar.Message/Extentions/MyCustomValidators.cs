using FluentValidation;
using Sepidar.Message.Base;
using System.Collections.Generic;

namespace Sepidar.Message.Extentions
{
    public static class MyCustomValidators
    {
        public static IRuleBuilderOptions<T, ICollection<TElement>> ListMustContainMoreThanOrEqual<T, TElement>(this IRuleBuilder<T, ICollection<TElement>> ruleBuilder, string name, int num)
        {

            return ruleBuilder.Must(list => list.Count >= num).WithMessage($"لیست {name} باید حداقل {num} مورد داشته باشد");
        }

        public static IRuleBuilderOptions<T, TElement> NotEmpty<T, TElement>(this IRuleBuilder<T, TElement> ruleBuilder, string name)
        {
            return ruleBuilder.NotEmpty().WithMessage($"{name} الزامی است");
        }

        public static IRuleBuilderOptions<T, TElement> NotNull<T, TElement>(this IRuleBuilder<T, TElement> ruleBuilder, string name)
        {
            return ruleBuilder.NotNull().WithMessage($"{name} الزامی است");
        }

        public static IRuleBuilderOptions<T, TElement> IsNationalCode<T, TElement>(this IRuleBuilder<T, TElement> ruleBuilder)
        {
            return ruleBuilder.Must(x => x.ToString().IsValidNationalCode()).WithMessage($"فرمت کد ملی صحیح نمیباشد");
        }
        public static IRuleBuilderOptions<T, TElement> IsInEnum<T, TElement>(this IRuleBuilder<T, TElement> ruleBuilder, string name)
        {
            return ruleBuilder.IsInEnum().WithMessage($"{name} صحیح نمی باشد");
        }
    }
}
