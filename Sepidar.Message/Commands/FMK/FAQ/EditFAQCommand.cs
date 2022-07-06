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
    public class EditFAQCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 FAQID { get; set; }  
 
		public Int32 ClubFAQRef { get; set; }  
 
		public Int32 ClubVersion { get; set; }  
 
		public String Question { get; set; }  
 
		public String Answer { get; set; }  
 
		public String Location { get; set; }  
 
		public String Key { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditFAQCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
