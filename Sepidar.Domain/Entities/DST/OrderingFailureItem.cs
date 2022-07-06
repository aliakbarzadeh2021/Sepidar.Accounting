using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class OrderingFailureItem : BaseEntity
    {
          
 
		public Int32 OrderingFailureItemId { get; set; }  
 
		public Int32 OrderingFailureRef { get; set; }  
 
		public Int32 AreaAndPathRef { get; set; }  
 
		public Nullable<Int32> PartyAddressRef { get; set; }  
 
		public Nullable<Int32> UnexecutedActReasonRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public String Guid { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


