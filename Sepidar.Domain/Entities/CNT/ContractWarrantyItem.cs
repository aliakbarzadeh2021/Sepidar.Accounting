using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ContractWarrantyItem : BaseEntity
    {
          
 
		public Int32 ContractWarrantyItemID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 WarrantyRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 Regard { get; set; }  
 
		public Nullable<DateTime> DueDate { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public DateTime DeliveryDate { get; set; }  
 
		public String FurtherInfo { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 
    }
}


