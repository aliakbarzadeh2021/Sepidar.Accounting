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
    public class AddPiofyAttendanceFactorCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PiofyAttendanceFactorId { get; set; }  
 
		public String Code { get; set; }  
 
		public Int32 MeasurementUnit { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddPiofyAttendanceFactorCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
