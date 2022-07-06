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
    public class AddItemPropertyAmountCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ItemPropertyAmountID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public String PropertyAmount1 { get; set; }  
 
		public String PropertyAmount2 { get; set; }  
 
		public String PropertyAmount3 { get; set; }  
 
		public String PropertyAmount4 { get; set; }  
 
		public String PropertyAmount5 { get; set; }  
 
		public String PropertyAmount6 { get; set; }  
 
		public String PropertyAmount7 { get; set; }  
 
		public String PropertyAmount8 { get; set; }  
 
		public String PropertyAmount9 { get; set; }  
 
		public String PropertyAmount10 { get; set; } 

        public void Validate()
        {
            new AddItemPropertyAmountCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
