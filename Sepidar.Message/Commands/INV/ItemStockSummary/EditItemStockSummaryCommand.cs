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
    public class EditItemStockSummaryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ItemStockSummaryID { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Int32> Order { get; set; }  
 
		public Int32 UnitRef { get; set; }  
 
		public Decimal InputQuantity { get; set; }  
 
		public Decimal OutputQuantity { get; set; }  
 
		public Nullable<Decimal> Quantity { get; set; }  
 
		public Nullable<Decimal> SaleQuantity { get; set; }  
 
		public Nullable<Decimal> SaleWithReserveQuantity { get; set; }  
 
		public Int32 FiscalYearRef { get; set; } 

        public void Validate()
        {
            new EditItemStockSummaryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
