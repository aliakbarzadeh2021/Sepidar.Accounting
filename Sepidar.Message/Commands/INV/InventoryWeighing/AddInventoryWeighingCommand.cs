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
    public class AddInventoryWeighingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InventoryWeighingID { get; set; }  
 
		public Int32 WeighbridgeConfigurationRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<DateTime> InputTime { get; set; }  
 
		public Nullable<DateTime> OutputTime { get; set; }  
 
		public Nullable<Decimal> InputQuantity { get; set; }  
 
		public Nullable<Decimal> OutputQuantity { get; set; }  
 
		public Decimal WastePercent { get; set; }  
 
		public String Driver { get; set; }  
 
		public String DrivingLicenseNumber { get; set; }  
 
		public String VehicleType { get; set; }  
 
		public String VehicleNumber { get; set; }  
 
		public String WayBillNumber { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Boolean IsManual { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 UnitRefConf { get; set; }  
 
		public Boolean IsPrimaryUnit { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> VendorDLRef { get; set; } 

        public void Validate()
        {
            new AddInventoryWeighingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
