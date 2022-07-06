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
    public class EditCustomContactCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CustomContactId { get; set; }  
 
		public String FullName { get; set; }  
 
		public Nullable<DateTime> MarriageDate { get; set; }  
 
		public Nullable<DateTime> BirthDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditCustomContactCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
