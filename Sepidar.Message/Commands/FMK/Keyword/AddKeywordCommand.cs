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
    public class AddKeywordCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 KeywordID { get; set; }  
 
		public String ActionKey { get; set; } 

        public void Validate()
        {
            new AddKeywordCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
