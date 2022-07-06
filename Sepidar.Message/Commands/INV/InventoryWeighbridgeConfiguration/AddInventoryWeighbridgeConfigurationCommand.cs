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
    public class AddInventoryWeighbridgeConfigurationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InventoryWeighbridgeConfigurationID { get; set; }  
 
		public Int32 InventoryWeighbridgeRef { get; set; }  
 
		public Int32 Model { get; set; }  
 
		public Int32 Port { get; set; }  
 
		public Int32 UnitRef { get; set; }  
 
		public Int32 BaudRate { get; set; }  
 
		public Int32 DataBits { get; set; }  
 
		public Int32 StopBits { get; set; }  
 
		public Int32 Parity { get; set; }  
 
		public Int32 AutoClose { get; set; }  
 
		public Int32 StabilityCheckTime { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddInventoryWeighbridgeConfigurationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
