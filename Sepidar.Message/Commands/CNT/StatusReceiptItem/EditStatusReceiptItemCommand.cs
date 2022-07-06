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
    public class EditStatusReceiptItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 StatusReceiptItemID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 StatusRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; } 

        public void Validate()
        {
            new EditStatusReceiptItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
