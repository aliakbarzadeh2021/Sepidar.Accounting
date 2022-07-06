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
    public class AddContractSettlementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SettlementID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; }  
 
		public Nullable<Int32> PaymentRef { get; set; }  
 
		public Nullable<Int32> PartyRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 

        public void Validate()
        {
            new AddContractSettlementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
