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
    public class AddCommissionCalculationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommissionCalculationID { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Int32 BrokerPartyRef_ { get; set; }  
 
		public DateTime FromDate { get; set; }  
 
		public DateTime ToDate { get; set; }  
 
		public Nullable<Int32> SLRef { get; set; }  
 
		public Nullable<Int32> DLRef { get; set; }  
 
		public Nullable<Int32> AccountingVoucherRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddCommissionCalculationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
