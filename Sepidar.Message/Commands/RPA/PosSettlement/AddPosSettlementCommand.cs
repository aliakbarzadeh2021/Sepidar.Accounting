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
    public class AddPosSettlementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PosSettlementID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public DateTime SettleReceiptsTo { get; set; }  
 
		public Int32 PosRef { get; set; }  
 
		public Nullable<Int32> SettlementReceiptRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; } 

        public void Validate()
        {
            new AddPosSettlementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
