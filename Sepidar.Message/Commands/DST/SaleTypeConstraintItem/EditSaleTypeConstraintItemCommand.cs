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
    public class EditSaleTypeConstraintItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SaleTypeConstraintItemID { get; set; }  
 
		public Int32 SaleTypeConstraintRef { get; set; }  
 
		public Int32 SaleTypeRef { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditSaleTypeConstraintItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
