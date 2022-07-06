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
    public class AddChequeBookCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ChequeBookId { get; set; }  
 
		public Int32 BankAccountRef { get; set; }  
 
		public String beginNumber { get; set; }  
 
		public Int32 Count { get; set; }  
 
		public String PrintFormat { get; set; }  
 
		public String Series { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddChequeBookCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
