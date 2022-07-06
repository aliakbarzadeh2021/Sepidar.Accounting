using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class UnuseableItem : BaseEntity
    {
          
 
		public Int32 UnuseableItemId { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 UnuseableRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 
    }
}


