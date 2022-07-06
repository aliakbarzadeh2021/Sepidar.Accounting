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
    public class AddPOSSettlementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SettlementID { get; set; }  
 
		public Int32 CashierRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime FromDate { get; set; }  
 
		public DateTime ToDate { get; set; }  
 
		public Nullable<Int32> ReceiptHeaderRef { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddPOSSettlementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
