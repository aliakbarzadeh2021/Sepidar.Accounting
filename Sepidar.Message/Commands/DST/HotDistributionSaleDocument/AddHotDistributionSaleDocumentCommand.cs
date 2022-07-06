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
    public class AddHotDistributionSaleDocumentCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HotDistributionSaleDocumentId { get; set; }  
 
		public Int32 HotDistributionRef { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Boolean IsDocCreatedByHotDistribution { get; set; } 

        public void Validate()
        {
            new AddHotDistributionSaleDocumentCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
