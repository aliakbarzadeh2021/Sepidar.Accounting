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
    public class AddMarketingDiskettePartyMapperCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MarketingDiskettePartyMapperID { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Nullable<Int32> CustomerCategoryForTax95 { get; set; }  
 
		public Nullable<Int32> CustomerCategoryForTax96 { get; set; }  
 
		public Nullable<Int32> VendorCategoryForTax96 { get; set; }  
 
		public Nullable<Int32> VendorLocationRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddMarketingDiskettePartyMapperCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
