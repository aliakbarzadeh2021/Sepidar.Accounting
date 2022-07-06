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
    public class EditLookupLocaleCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 LookupRef { get; set; }  
 
		public String LocaleName { get; set; }  
 
		public String Title { get; set; } 

        public void Validate()
        {
            new EditLookupLocaleCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
