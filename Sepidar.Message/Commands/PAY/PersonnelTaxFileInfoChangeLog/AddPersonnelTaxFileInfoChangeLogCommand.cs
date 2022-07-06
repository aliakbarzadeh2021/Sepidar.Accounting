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
    public class AddPersonnelTaxFileInfoChangeLogCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersonnelTaxFileInfoChangeLogId { get; set; }  
 
		public Int32 PersonnelRef { get; set; }  
 
		public DateTime ChangeInfoDate { get; set; } 

        public void Validate()
        {
            new AddPersonnelTaxFileInfoChangeLogCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
