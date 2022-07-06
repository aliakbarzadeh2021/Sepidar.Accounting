using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PriceNoteDto
    {
          
 
		public Int32 PriceNoteID { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; } 
    }
}


