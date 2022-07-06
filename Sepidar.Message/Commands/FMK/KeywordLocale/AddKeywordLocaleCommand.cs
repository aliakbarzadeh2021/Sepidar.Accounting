using Sepidar.Message.Base;
using Sepidar.Message.Extentions;
using Sepidar.Message.Validators;
using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class AddKeywordLocaleCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 KeywordRef { get; set; }  
 
		public String LocaleName { get; set; }  
 
		public String Value { get; set; } 

        public void Validate()
        {
            new AddKeywordLocaleCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
