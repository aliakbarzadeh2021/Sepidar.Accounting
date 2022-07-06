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
    public class EditVoucherItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 VoucherItemId { get; set; }  
 
		public Int32 VoucherRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 AccountSLRef { get; set; }  
 
		public Nullable<Int32> DLRef { get; set; }  
 
		public Decimal Debit { get; set; }  
 
		public Decimal Credit { get; set; }  
 
		public Nullable<Int32> CurrencyRef { get; set; }  
 
		public Nullable<Decimal> CurrencyRate { get; set; }  
 
		public Nullable<Decimal> CurrencyDebit { get; set; }  
 
		public Nullable<Decimal> CurrencyCredit { get; set; }  
 
		public String TrackingNumber { get; set; }  
 
		public Nullable<DateTime> TrackingDate { get; set; }  
 
		public String IssuerEntityName { get; set; }  
 
		public Int32 IssuerEntityRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditVoucherItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
