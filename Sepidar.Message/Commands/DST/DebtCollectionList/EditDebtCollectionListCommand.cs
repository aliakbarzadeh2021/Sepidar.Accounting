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
    public class EditDebtCollectionListCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DebtCollectionListId { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Int32 DebtCollectorPartyRef { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditDebtCollectionListCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
