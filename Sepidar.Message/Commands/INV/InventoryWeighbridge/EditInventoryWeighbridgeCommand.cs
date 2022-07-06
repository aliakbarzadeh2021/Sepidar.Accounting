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
    public class EditInventoryWeighbridgeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InventoryWeighbridgeID { get; set; }  
 
		public Int32 Model { get; set; }  
 
		public Int32 BaudRate { get; set; }  
 
		public Int32 DataBits { get; set; }  
 
		public Int32 StopBits { get; set; }  
 
		public Int32 Parity { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditInventoryWeighbridgeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
