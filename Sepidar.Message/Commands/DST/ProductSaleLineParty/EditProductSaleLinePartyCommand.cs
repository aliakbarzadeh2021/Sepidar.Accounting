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
    public class EditProductSaleLinePartyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ProductSaleLinePartyId { get; set; }  
 
		public Int32 ProductSaleLineRef { get; set; }  
 
		public Int32 PartyRef { get; set; } 

        public void Validate()
        {
            new EditProductSaleLinePartyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
