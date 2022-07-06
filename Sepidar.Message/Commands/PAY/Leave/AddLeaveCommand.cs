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
    public class AddLeaveCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 LeaveId { get; set; }  
 
		public Int32 PersonnelRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 SystemRemainder { get; set; }  
 
		public Nullable<Int32> UserRemainder { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Solaryear { get; set; }  
 
		public Int32 Month { get; set; } 

        public void Validate()
        {
            new AddLeaveCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
