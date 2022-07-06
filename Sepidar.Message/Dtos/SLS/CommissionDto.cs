using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CommissionDto
    {
          
 
		public Int32 CommissionId { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public DateTime FromDate { get; set; }  
 
		public DateTime ToDate { get; set; }  
 
		public Int32 CalculationBase { get; set; }  
 
		public Int32 InvoiceSettlementState { get; set; }  
 
		public Int32 SaleVolumeCalculationBase { get; set; }  
 
		public Int32 CalculationType { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 ItemFilterType { get; set; }  
 
		public Nullable<Int32> SaleTypeRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


