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
    public class AddContractPreReceiptItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PreReceiptID { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; }  
 
		public Nullable<Int32> ReceiptNumber { get; set; }  
 
		public Nullable<Int32> PaymentRef { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 

        public void Validate()
        {
            new AddContractPreReceiptItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
