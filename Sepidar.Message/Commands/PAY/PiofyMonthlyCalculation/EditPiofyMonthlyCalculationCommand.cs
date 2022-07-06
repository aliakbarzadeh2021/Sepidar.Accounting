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
    public class EditPiofyMonthlyCalculationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PiofyMonthlyCalculationId { get; set; }  
 
		public Int32 YMCode { get; set; }  
 
		public Int32 EmployeeID { get; set; }  
 
		public String FactorCode { get; set; }  
 
		public Nullable<Int32> DayValue { get; set; }  
 
		public Nullable<Int32> HourValue { get; set; }  
 
		public Nullable<Int32> MinuteValue { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 State { get; set; } 

        public void Validate()
        {
            new EditPiofyMonthlyCalculationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
