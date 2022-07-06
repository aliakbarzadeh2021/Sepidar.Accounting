using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ChangeItemDto
    {
          
 
		public Int32 ChangeID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Decimal PrimaryFee { get; set; }  
 
		public Decimal ChangeAmount { get; set; }  
 
		public Int32 ChangeAmountType { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 
    }
}


