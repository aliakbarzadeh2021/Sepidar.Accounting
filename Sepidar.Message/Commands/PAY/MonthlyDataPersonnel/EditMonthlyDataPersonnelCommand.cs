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
    public class EditMonthlyDataPersonnelCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MonthlyDataPersonnelId { get; set; }  
 
		public Int32 MonthlyDataRef { get; set; }  
 
		public Int32 PersonnelRef { get; set; } 

        public void Validate()
        {
            new EditMonthlyDataPersonnelCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
