using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class UseableItem : BaseEntity
    {
          
 
		public Int32 UseableItemId { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 UseableRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 
    }
}


