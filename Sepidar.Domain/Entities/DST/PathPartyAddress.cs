using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PathPartyAddress : BaseEntity
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


