using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class SalvageItem : BaseEntity
    {
          
 
		public Int32 SalvageItemID { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 SalvageRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 
    }
}


