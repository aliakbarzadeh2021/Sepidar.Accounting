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
    public class EditUserReportsInvisibleCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserReportsInvisibleID { get; set; }  
 
		public String Name { get; set; } 

        public void Validate()
        {
            new EditUserReportsInvisibleCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
