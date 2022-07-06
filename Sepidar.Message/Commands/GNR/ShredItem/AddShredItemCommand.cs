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
    public class AddShredItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ShredItemID { get; set; }  
 
		public Int32 ShredRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public DateTime UsanceDate { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<Decimal> InterestAmount { get; set; }  
 
		public Nullable<Decimal> PenaltyAmount { get; set; }  
 
		public Nullable<Decimal> PenaltyRate { get; set; }  
 
		public Int32 Status { get; set; }  
 
		public Nullable<Int32> PaymentRef { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; }  
 
		public Nullable<Int32> PartySettlementRef { get; set; }  
 
		public Nullable<DateTime> PaymentDate { get; set; }  
 
		public Boolean IsPaid { get; set; }  
 
		public Nullable<DateTime> PaidDate { get; set; }  
 
		public String PaidDesc { get; set; } 

        public void Validate()
        {
            new AddShredItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
