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
    public class AddVersion1Command : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 VersionID { get; set; }  
 
		public Int32 Major { get; set; }  
 
		public Int32 Minor { get; set; }  
 
		public Int32 Build { get; set; }  
 
		public Int32 Revision { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version2 { get; set; } 

        public void Validate()
        {
            new AddVersion1CommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
