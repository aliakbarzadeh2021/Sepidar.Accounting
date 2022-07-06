using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class InventoryWeighbridge : BaseEntity
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


