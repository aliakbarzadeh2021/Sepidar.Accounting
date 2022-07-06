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
    public class EditStandardDescriptionCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 StandardDescriptionId { get; set; }  
 
		public String EntityTypeName { get; set; }  
 
		public Int32 Key { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditStandardDescriptionCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
