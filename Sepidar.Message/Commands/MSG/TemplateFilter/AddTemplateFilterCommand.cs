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
    public class AddTemplateFilterCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TemplateFilterID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public String ParameterName { get; set; }  
 
		public Int32 FilterCondition { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Operator { get; set; } 

        public void Validate()
        {
            new AddTemplateFilterCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
