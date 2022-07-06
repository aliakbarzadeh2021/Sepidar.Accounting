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
    public class AddCostCenterCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CostCenterId { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public Int32 Type { get; set; } 

        public void Validate()
        {
            new AddCostCenterCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
