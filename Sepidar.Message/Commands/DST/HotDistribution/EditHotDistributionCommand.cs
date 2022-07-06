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
    public class EditHotDistributionCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HotDistributionId { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Int32 DistributorPartyRef { get; set; }  
 
		public Int32 TruckRef { get; set; }  
 
		public Nullable<Int32> DriverPartyRef { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Nullable<Int32> InventoryDeliveryRef { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Boolean IsModifiedByDevice { get; set; } 

        public void Validate()
        {
            new EditHotDistributionCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
