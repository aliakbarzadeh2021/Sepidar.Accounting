using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PriceNoteItemDiscountDto
    {
          
 
		public Int32 PriceNoteItemDiscountID { get; set; }  
 
		public Int32 PriceNoteItemRef { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public Nullable<DateTime> EndDate { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Nullable<Int32> Converted { get; set; } 
    }
}


