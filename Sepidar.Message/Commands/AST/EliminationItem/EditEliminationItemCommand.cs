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
    public class EditEliminationItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 EliminationItemID { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 EliminationRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 

        public void Validate()
        {
            new EditEliminationItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
