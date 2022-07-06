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
    public class EditCalculationElementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CalculationElementID { get; set; }  
 
		public String Symbol { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditCalculationElementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
