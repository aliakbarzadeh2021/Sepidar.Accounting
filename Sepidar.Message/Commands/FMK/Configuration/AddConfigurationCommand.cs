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
    public class AddConfigurationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ConfigurationID { get; set; }  
 
		public String Key { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddConfigurationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
