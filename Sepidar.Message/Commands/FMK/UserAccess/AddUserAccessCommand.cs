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
    public class AddUserAccessCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserAccessID { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public String LogicalResource { get; set; }  
 
		public Boolean HasAccess { get; set; } 

        public void Validate()
        {
            new AddUserAccessCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
