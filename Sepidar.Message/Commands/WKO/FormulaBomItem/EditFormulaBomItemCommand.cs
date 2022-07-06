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
    public class EditFormulaBomItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 FormulaBomItemID { get; set; }  
 
		public Int32 ProductFormulaRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public String Description { get; set; } 

        public void Validate()
        {
            new EditFormulaBomItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
