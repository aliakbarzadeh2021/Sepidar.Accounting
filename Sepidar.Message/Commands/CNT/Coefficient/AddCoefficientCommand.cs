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
    public class AddCoefficientCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CoefficientID { get; set; }  
 
		public Int32 Nature { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Single Percent { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> SLRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddCoefficientCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
