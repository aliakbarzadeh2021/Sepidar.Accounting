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
    public class AddBankBillItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BankBillItemId { get; set; }  
 
		public Int32 BankBillRef { get; set; }  
 
		public String VoucherNumber { get; set; }  
 
		public DateTime VoucherDate { get; set; }  
 
		public Decimal Debit { get; set; }  
 
		public Decimal Credit { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddBankBillItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
