using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class HotDistributionDto
    {
          
 
		public Int32 HotDistributionId { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Int32 DistributorPartyRef { get; set; }  
 
		public Int32 TruckRef { get; set; }  
 
		public Nullable<Int32> DriverPartyRef { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Nullable<Int32> InventoryDeliveryRef { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Boolean IsModifiedByDevice { get; set; } 
    }
}


