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
    public class AddContractWarrantyItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ContractWarrantyItemID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 WarrantyRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 Regard { get; set; }  
 
		public Nullable<DateTime> DueDate { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public DateTime DeliveryDate { get; set; }  
 
		public String FurtherInfo { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 

        public void Validate()
        {
            new AddContractWarrantyItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
