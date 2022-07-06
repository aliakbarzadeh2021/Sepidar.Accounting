using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class InventoryDelivery : BaseEntity
    {
          
 
		public Int32 InventoryDeliveryID { get; set; }  
 
		public Boolean IsReturn { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Nullable<Int32> ReceiverDLRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Decimal> TotalPrice { get; set; }  
 
		public Nullable<Int32> AccountingVoucherRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> DestinationStockRef { get; set; }  
 
		public Int32 CreatorForm { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


