using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class MarketingDiskettePartyMapper : BaseEntity
    {
          
 
		public Int32 MarketingDiskettePartyMapperID { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Nullable<Int32> CustomerCategoryForTax95 { get; set; }  
 
		public Nullable<Int32> CustomerCategoryForTax96 { get; set; }  
 
		public Nullable<Int32> VendorCategoryForTax96 { get; set; }  
 
		public Nullable<Int32> VendorLocationRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


