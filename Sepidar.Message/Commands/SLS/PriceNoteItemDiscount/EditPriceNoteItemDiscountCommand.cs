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
    public class EditPriceNoteItemDiscountCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PriceNoteItemDiscountID { get; set; }  
 
		public Int32 PriceNoteItemRef { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public Nullable<DateTime> EndDate { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Nullable<Int32> Converted { get; set; } 

        public void Validate()
        {
            new EditPriceNoteItemDiscountCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
