using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ContractEmployerMaterialsItemDto
    {
          
 
		public Int32 EmployerMaterialsID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> StockRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; }  
 
		public Nullable<Int32> ReceiptNumber { get; set; }  
 
		public Nullable<Int32> InventoryDeliveryRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Decimal> TotalPrice { get; set; } 
    }
}


