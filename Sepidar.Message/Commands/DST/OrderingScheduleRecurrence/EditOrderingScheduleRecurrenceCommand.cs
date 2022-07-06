using Sepidar.Message.Base;
using Sepidar.Message.Extentions;
using Sepidar.Message.Validators;
using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class EditOrderingScheduleRecurrenceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OrderingScheduleRecurrenceId { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public DateTime EndDate { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> DayInterval { get; set; }  
 
		public Nullable<Int32> WeekInterval { get; set; }  
 
		public Nullable<Int32> Weekdays { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditOrderingScheduleRecurrenceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
