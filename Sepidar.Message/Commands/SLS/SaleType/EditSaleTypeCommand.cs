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
    public class EditSaleTypeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SaleTypeId { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 SaleTypeMarket { get; set; }  
 
		public Nullable<Int32> PartSalesSLRef { get; set; }  
 
		public Nullable<Int32> ServiceSalesSLRef { get; set; }  
 
		public Nullable<Int32> PartSalesReturnSLRef { get; set; }  
 
		public Nullable<Int32> ServiceSalesReturnSLRef { get; set; }  
 
		public Nullable<Int32> PartSalesDiscountSLRef { get; set; }  
 
		public Nullable<Int32> ServiceSalesDiscountSLRef { get; set; }  
 
		public Nullable<Int32> SalesAdditionSLRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditSaleTypeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
