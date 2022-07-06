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
    public class EditBillCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BillID { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Decimal> LastRemainder { get; set; }  
 
		public Nullable<Decimal> NewRemainder { get; set; }  
 
		public Nullable<Decimal> RPARemainder { get; set; }  
 
		public Nullable<Decimal> ReturnedRemainder { get; set; }  
 
		public Nullable<Decimal> EnteryRemainder { get; set; }  
 
		public Nullable<Decimal> OtherRemainder { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; } 

        public void Validate()
        {
            new EditBillCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
