using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PathPartyAddressDto
    {
          
 
		public Int32 PathPartyAddressId { get; set; }  
 
		public Int32 RowOrder { get; set; }  
 
		public Int32 AreaAndPathRef { get; set; }  
 
		public Int32 PartyAddressRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


