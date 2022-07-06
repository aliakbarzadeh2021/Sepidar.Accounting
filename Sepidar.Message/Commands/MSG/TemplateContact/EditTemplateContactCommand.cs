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
    public class EditTemplateContactCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TemplateContactID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public String Phone { get; set; }  
 
		public Nullable<Int32> ContactPhoneRef { get; set; }  
 
		public Nullable<Int32> ContactType { get; set; }  
 
		public String ParameterName { get; set; } 

        public void Validate()
        {
            new EditTemplateContactCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
