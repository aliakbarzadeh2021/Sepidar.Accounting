using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InventoryWeighbridgeDto
    {
          
 
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
    }
}


