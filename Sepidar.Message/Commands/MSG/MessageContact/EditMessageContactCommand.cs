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
    public class EditMessageContactCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MessageContactID { get; set; }  
 
		public Int32 MessageRef { get; set; }  
 
		public String Phone { get; set; }  
 
		public Nullable<Int32> ContactPhoneRef { get; set; }  
 
		public Nullable<Int32> ContactType { get; set; } 

        public void Validate()
        {
            new EditMessageContactCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
