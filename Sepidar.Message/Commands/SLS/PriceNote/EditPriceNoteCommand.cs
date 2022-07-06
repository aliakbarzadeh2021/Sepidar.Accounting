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
    public class EditPriceNoteCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PriceNoteID { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditPriceNoteCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
