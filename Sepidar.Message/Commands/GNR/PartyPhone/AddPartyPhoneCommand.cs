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
    public class AddPartyPhoneCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PartyPhoneId { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 IsMain { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Phone { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddPartyPhoneCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
