using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PurchaseOtherCostItem : BaseEntity
    {
          
 
		public Int32 PurchaseOtherCostItemID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 PurchaseCostRef { get; set; }  
 
		public Int32 ServiceInventoryPurchaseInvoiceItemRef { get; set; }  
 
		public Nullable<Int32> CostServiceAccountSLRef { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public Decimal EffectiveAmountInBaseCurrency { get; set; }  
 
		public Int32 AllotmentType { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


