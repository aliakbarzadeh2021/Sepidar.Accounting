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
    public class EditGroupingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GroupingID { get; set; }  
 
		public String EntityType { get; set; }  
 
		public String Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Nullable<Int32> CalculationFormulaRef { get; set; }  
 
		public Nullable<Int32> ParentGroupRef { get; set; }  
 
		public Nullable<Decimal> MaximumCredit { get; set; }  
 
		public Boolean HasCredit { get; set; }  
 
		public Int32 CreditCheckingType { get; set; }  
 
		public String FullCode { get; set; } 

        public void Validate()
        {
            new EditGroupingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
