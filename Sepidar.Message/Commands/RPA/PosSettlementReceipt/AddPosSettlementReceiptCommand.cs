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
    public class AddPosSettlementReceiptCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PosSettlementReceiptID { get; set; }  
 
		public Int32 PosSettlementRef { get; set; }  
 
		public Int32 ReceiptPosRef { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddPosSettlementReceiptCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
