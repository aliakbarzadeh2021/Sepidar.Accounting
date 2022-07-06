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
    public class EditOrderingFailureItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OrderingFailureItemId { get; set; }  
 
		public Int32 OrderingFailureRef { get; set; }  
 
		public Int32 AreaAndPathRef { get; set; }  
 
		public Nullable<Int32> PartyAddressRef { get; set; }  
 
		public Nullable<Int32> UnexecutedActReasonRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public String Guid { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditOrderingFailureItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
