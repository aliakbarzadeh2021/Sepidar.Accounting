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
    public class EditPurchaseCostCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PurchaseCostID { get; set; }  
 
		public Int32 PurchaseInvoiceRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 State { get; set; }  
 
		public String Description { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditPurchaseCostCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
