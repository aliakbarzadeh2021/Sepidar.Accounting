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
    public class AddPayrollCalendarCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayrollCalendarId { get; set; }  
 
		public Int32 Year { get; set; }  
 
		public Int32 Month { get; set; }  
 
		public Nullable<Int32> Day { get; set; }  
 
		public Nullable<Int32> HourMinute { get; set; }  
 
		public Nullable<Int32> TotalHourMinute { get; set; }  
 
		public Int32 PayrollConfigurationRef { get; set; } 

        public void Validate()
        {
            new AddPayrollCalendarCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
