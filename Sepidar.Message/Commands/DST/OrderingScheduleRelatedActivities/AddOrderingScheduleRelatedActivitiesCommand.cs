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
    public class AddOrderingScheduleRelatedActivitiesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OrderingScheduleRelatedActivitiesId { get; set; }  
 
		public Int64 ScheduleId { get; set; }  
 
		public Nullable<Int32> OrderRef { get; set; }  
 
		public Nullable<Int32> OrderingFailureItemRef { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddOrderingScheduleRelatedActivitiesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
