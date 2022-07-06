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
    public class EditCustomContactPhoneCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CustomContactPhoneId { get; set; }  
 
		public Int32 CustomContactRef { get; set; }  
 
		public String Phone { get; set; }  
 
		public Boolean IsMain { get; set; } 

        public void Validate()
        {
            new EditCustomContactPhoneCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
