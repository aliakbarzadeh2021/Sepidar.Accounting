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
    public class AddCheckDataParityCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Byte[] Column1 { get; set; }  
 
		public Byte[] Column2 { get; set; }  
 
		public Byte[] Column3 { get; set; }  
 
		public Byte[] Column4 { get; set; }  
 
		public Byte[] Column5 { get; set; } 

        public void Validate()
        {
            new AddCheckDataParityCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
