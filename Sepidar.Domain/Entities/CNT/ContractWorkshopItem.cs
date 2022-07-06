using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ContractWorkshopItem : BaseEntity
    {
          
 
		public Int32 ContractWorkshopItemID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 WorkshopRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 
    }
}


