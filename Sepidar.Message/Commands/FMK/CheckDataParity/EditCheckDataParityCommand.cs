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
    public class EditCheckDataParityCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Byte[] Column1 { get; set; }  
 
		public Byte[] Column2 { get; set; }  
 
		public Byte[] Column3 { get; set; }  
 
		public Byte[] Column4 { get; set; }  
 
		public Byte[] Column5 { get; set; } 

        public void Validate()
        {
            new EditCheckDataParityCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
