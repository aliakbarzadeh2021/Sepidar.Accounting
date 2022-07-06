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
    public class EditPiofyEmployeeMapperCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PiofyEmployeeMapperID { get; set; }  
 
		public Int32 PersonnelRef { get; set; }  
 
		public Nullable<Int32> PiofyEmployeeID { get; set; }  
 
		public Int32 PiofyEmploymentType { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditPiofyEmployeeMapperCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
