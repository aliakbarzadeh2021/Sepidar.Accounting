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
    public class AddUserConfigurationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserConfigurationID { get; set; }  
 
		public String Key { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddUserConfigurationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
