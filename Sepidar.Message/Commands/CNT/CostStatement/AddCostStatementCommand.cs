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
    public class AddCostStatementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CostStatementID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Nullable<Int32> WorkshopRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 VoucherType { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Nullable<Int32> FundResponderDLRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Boolean Established { get; set; } 

        public void Validate()
        {
            new AddCostStatementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
