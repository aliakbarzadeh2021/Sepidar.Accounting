using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PriceNoteItemDiscount : BaseEntity
    {
          
 
		public Int32 PriceNoteItemDiscountID { get; set; }  
 
		public Int32 PriceNoteItemRef { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public Nullable<DateTime> EndDate { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Nullable<Int32> Converted { get; set; } 
    }
}


