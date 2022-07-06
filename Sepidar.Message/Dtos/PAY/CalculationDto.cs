using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CalculationDto
    {
          
 
		public Int32 CalculationId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Nullable<Int32> BranchRef { get; set; }  
 
		public Nullable<Int32> PersonnelRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Decimal Value { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 Year { get; set; }  
 
		public Int32 Month { get; set; }  
 
		public Nullable<Int32> ContractRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; } 
    }
}


