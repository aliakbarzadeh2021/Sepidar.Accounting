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
    public class AddQuickBarItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QuickBarItemID { get; set; }  
 
		public Int32 QuickBarRef { get; set; }  
 
		public Int32 ItemIndex { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Int32 Shortcut { get; set; } 

        public void Validate()
        {
            new AddQuickBarItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
