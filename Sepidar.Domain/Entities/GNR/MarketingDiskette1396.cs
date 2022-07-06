using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class MarketingDiskette1396 : BaseEntity
    {
          
 
		public Int32 MarketingDisketteID { get; set; }  
 
		public Int32 year { get; set; }  
 
		public Int32 Season { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


