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
    public class AddEmplacementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 EmplacementId { get; set; }  
 
		public String Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_EN { get; set; }  
 
		public Nullable<Int32> ParentRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_EN { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddEmplacementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
