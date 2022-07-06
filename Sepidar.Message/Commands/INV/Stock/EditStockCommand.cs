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
    public class EditStockCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 StockID { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public String StockClerk { get; set; }  
 
		public String Phone { get; set; }  
 
		public String Address { get; set; }  
 
		public String Address_En { get; set; }  
 
		public Nullable<Int32> AccountSLRef { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditStockCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
