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
    public class AddMessage1Command : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MessageID { get; set; }  
 
		public String Body { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Boolean IsDraft { get; set; }  
 
		public Nullable<Int32> TemplateRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddMessage1CommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
