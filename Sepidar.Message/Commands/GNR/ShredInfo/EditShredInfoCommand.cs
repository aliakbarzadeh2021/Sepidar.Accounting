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
    public class EditShredInfoCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ShredInfoID { get; set; }  
 
		public Int32 ShredRef { get; set; }  
 
		public Int32 ShredLength { get; set; }  
 
		public Int32 ShredCount { get; set; }  
 
		public Int32 InterestType { get; set; }  
 
		public Decimal InterestRate { get; set; }  
 
		public Decimal PenaltyRate { get; set; }  
 
		public Int32 RoundDigCount { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public Int32 TransferType { get; set; }  
 
		public Nullable<Decimal> InterestAmount { get; set; }  
 
		public Nullable<Decimal> ShredAmount { get; set; }  
 
		public Nullable<DateTime> FinishDate { get; set; }  
 
		public Nullable<Int32> Length { get; set; } 

        public void Validate()
        {
            new EditShredInfoCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
