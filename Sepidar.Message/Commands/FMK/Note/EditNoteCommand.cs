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
    public class EditNoteCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 NoteID { get; set; }  
 
		public String EntityType { get; set; }  
 
		public Int32 EntityRef { get; set; }  
 
		public String Note1 { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditNoteCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
