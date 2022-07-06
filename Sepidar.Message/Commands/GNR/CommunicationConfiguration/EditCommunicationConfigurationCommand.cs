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
    public class EditCommunicationConfigurationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommunicationConfigurationID { get; set; }  
 
		public Int32 System { get; set; }  
 
		public String Key { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditCommunicationConfigurationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
