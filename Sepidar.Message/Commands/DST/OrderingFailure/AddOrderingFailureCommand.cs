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
    public class AddOrderingFailureCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OrderingFailureId { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddOrderingFailureCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
