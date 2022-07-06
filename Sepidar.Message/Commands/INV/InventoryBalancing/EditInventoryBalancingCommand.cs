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
    public class EditInventoryBalancingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InventoryBalancingId { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Int32 OperatorDLRef { get; set; }  
 
		public Nullable<Int32> RedundancySLRef { get; set; }  
 
		public Nullable<Int32> RedundancyDLRef { get; set; }  
 
		public Nullable<Int32> ShortageSLRef { get; set; }  
 
		public Nullable<Int32> ShortageDLRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Nullable<Int32> InventoryReceiptRef { get; set; }  
 
		public Nullable<Int32> InventoryDeliveryRef { get; set; }  
 
		public Decimal ItemMinQuantity { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditInventoryBalancingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
