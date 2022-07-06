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
    public class AddSchedulingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SchedulingId { get; set; }  
 
		public String Title { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public DateTime EndDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddSchedulingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
