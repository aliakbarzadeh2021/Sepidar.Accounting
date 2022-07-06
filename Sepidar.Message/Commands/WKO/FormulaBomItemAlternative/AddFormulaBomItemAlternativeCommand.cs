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
    public class AddFormulaBomItemAlternativeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 FormulaBomItemAlternativeID { get; set; }  
 
		public Int32 FormulaBomItemRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Double AlternativeRatio { get; set; } 

        public void Validate()
        {
            new AddFormulaBomItemAlternativeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
