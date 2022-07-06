using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class SaleItemDto
    {
          
 
		public Int32 SaleItemID { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 SaleRef { get; set; }  
 
		public Decimal SalePrice { get; set; }  
 
		public Decimal SalePriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Tax { get; set; }  
 
		public Nullable<Decimal> TaxInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Duty { get; set; }  
 
		public Nullable<Decimal> DutyInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 
    }
}

