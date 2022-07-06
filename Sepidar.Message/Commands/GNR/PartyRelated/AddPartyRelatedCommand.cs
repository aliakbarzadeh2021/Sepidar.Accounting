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
    public class AddPartyRelatedCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PartyRelatedId { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Nullable<Boolean> IsMain { get; set; }  
 
		public String Name { get; set; }  
 
		public String Post { get; set; }  
 
		public String Name_En { get; set; }  
 
		public String Post_En { get; set; }  
 
		public String Phone { get; set; }  
 
		public String Email { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddPartyRelatedCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
