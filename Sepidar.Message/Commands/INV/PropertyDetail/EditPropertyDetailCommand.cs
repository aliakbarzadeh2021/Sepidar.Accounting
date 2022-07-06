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
    public class EditPropertyDetailCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PropertyDetailID { get; set; }  
 
		public String Title { get; set; }  
 
		public Int32 PropertyRef { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditPropertyDetailCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
