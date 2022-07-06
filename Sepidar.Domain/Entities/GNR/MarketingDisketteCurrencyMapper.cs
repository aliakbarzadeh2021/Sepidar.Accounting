using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class MarketingDisketteCurrencyMapper : BaseEntity
    {
          
 
		public Int32 MarketingDisketteCurrencyMapperID { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Nullable<Int32> MarketingDisketteCurrencyRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


