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
    public class EditUserPhoneCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserPhoneId { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Phone { get; set; }  
 
		public Boolean IsMain { get; set; } 

        public void Validate()
        {
            new EditUserPhoneCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
