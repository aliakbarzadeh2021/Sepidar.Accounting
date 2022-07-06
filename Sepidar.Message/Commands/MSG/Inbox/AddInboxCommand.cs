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
    public class AddInboxCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InboxID { get; set; }  
 
		public String Text { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String SenderNumber { get; set; }  
 
		public String ReceiverNumber { get; set; }  
 
		public Nullable<Int32> ContactPhoneRef { get; set; }  
 
		public Nullable<Int32> ContactType { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddInboxCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
