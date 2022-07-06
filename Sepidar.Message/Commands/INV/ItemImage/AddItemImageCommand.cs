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
    public class AddItemImageCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ItemImageID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Byte[] Image { get; set; }  
 
		public Byte[] Thumbnail { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddItemImageCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
