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
    public class EditJobCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 JobId { get; set; }  
 
		public String Title_En { get; set; }  
 
		public String HardCode { get; set; }  
 
		public String Title { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Nullable<Int32> GuildType { get; set; } 

        public void Validate()
        {
            new EditJobCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
