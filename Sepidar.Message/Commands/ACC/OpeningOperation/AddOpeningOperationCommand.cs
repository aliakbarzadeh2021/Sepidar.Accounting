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
    public class AddOpeningOperationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OpeningOperationId { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> AccountSLRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddOpeningOperationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
