using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class OrderingScheduleDto
    {
          
 
		public Int32 OrderingScheduleId { get; set; }  
 
		public Nullable<Int32> OrderingScheduleRecurrenceRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 AreaAndPathRef { get; set; }  
 
		public Boolean IsLockedByDevice { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


