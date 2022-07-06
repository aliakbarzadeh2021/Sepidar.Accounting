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
    public class EditPOSSettlementItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SettlementItemID { get; set; }  
 
		public Int32 SettlementRef { get; set; }  
 
		public Int32 RowID { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Nullable<Int32> SalesInvoiceRef { get; set; }  
 
		public Nullable<Int32> SalesReturnedInvoiceRef { get; set; }  
 
		public String EntityFullName { get; set; } 

        public void Validate()
        {
            new EditPOSSettlementItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
