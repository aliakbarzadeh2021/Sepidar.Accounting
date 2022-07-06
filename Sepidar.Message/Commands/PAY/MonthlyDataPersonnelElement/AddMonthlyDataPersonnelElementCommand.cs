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
    public class AddMonthlyDataPersonnelElementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MonthlyDataPersonnelElementlId { get; set; }  
 
		public Int32 MonthlyDataPersonnelRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> ElementRef { get; set; }  
 
		public Nullable<Decimal> Value { get; set; } 

        public void Validate()
        {
            new AddMonthlyDataPersonnelElementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
