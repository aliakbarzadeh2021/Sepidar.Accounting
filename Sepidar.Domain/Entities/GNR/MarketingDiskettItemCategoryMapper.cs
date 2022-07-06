using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class MarketingDiskettItemCategoryMapper : BaseEntity
    {
          
 
		public Int32 MarketingDiskettItemCategoryMapperID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> ItemCategory95Ref { get; set; }  
 
		public Int32 ItemCategory96 { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


