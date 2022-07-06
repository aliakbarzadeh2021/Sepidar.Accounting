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
    public class AddWorkExperienceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 WorkExperienceId { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public DateTime EndDate { get; set; }  
 
		public Int32 Duration { get; set; }  
 
		public String Company { get; set; }  
 
		public String Career { get; set; }  
 
		public String QuitReason { get; set; }  
 
		public Int32 PersonnelRef { get; set; } 

        public void Validate()
        {
            new AddWorkExperienceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
