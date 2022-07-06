using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class VoucherDto
    {
          
 
		public Int32 VoucherId { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 ReferenceNumber { get; set; }  
 
		public Nullable<Int32> SecondaryNumber { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 DailyNumber { get; set; }  
 
		public Int32 IssuerSystem { get; set; } 
    }
}


