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
    public class AddDepreciationRuleCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DepreciationRuleID { get; set; }  
 
		public Nullable<Int32> GroupNo { get; set; }  
 
		public String GroupTitle { get; set; }  
 
		public Nullable<Decimal> DepreciationRate { get; set; }  
 
		public Nullable<Decimal> UsefulLife { get; set; }  
 
		public Int32 DepreciationMethod { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddDepreciationRuleCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
