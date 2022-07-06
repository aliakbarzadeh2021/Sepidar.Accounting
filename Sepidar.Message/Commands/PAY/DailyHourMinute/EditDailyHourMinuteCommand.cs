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
    public class EditDailyHourMinuteCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DailyHourMinuteId { get; set; }  
 
		public Int32 PayrollConfigurationRef { get; set; }  
 
		public Int32 Year { get; set; }  
 
		public Int32 DailyHourMinute1 { get; set; } 

        public void Validate()
        {
            new EditDailyHourMinuteCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
