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
    public class EditLookupCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 LookupID { get; set; }  
 
		public String Type { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 DisplayOrder { get; set; }  
 
		public String Extra { get; set; }  
 
		public String System { get; set; } 

        public void Validate()
        {
            new EditLookupCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
