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
    public class EditPriceNoteItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PriceNoteItemID { get; set; }  
 
		public Int32 PriceNoteRef { get; set; }  
 
		public Int32 SaleTypeRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Int32 UnitRef { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Nullable<Int32> CurrencyRef { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Boolean CanChangeInvoiceFee { get; set; }  
 
		public Boolean CanChangeInvoiceDiscount { get; set; }  
 
		public Decimal AdditionRate { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Int32> CustomerGroupingRef { get; set; }  
 
		public Nullable<Decimal> LowerMargin { get; set; }  
 
		public Nullable<Decimal> UpperMargin { get; set; } 

        public void Validate()
        {
            new EditPriceNoteItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
