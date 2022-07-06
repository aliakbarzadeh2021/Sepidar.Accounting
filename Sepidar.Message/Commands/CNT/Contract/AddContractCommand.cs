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
    public class AddContractCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ContractID { get; set; }  
 
		public Int32 ProjectRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 ContractorPartyRef { get; set; }  
 
		public String Location { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public DateTime EndDate { get; set; }  
 
		public Decimal Cost { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public Int32 ContractTypeRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Single AllowedChangePercent { get; set; }  
 
		public Boolean Established { get; set; }  
 
		public Decimal EstimatedCost { get; set; }  
 
		public Decimal DepositSum { get; set; }  
 
		public Decimal MaterialSum { get; set; }  
 
		public Nullable<Single> DepositDepreciationPercent { get; set; }  
 
		public String DocumentNumber { get; set; }  
 
		public Nullable<Int32> TenderRef { get; set; }  
 
		public Nullable<DateTime> CancelDate { get; set; }  
 
		public Nullable<Int32> ContractRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> AffectedChange { get; set; }  
 
		public Nullable<Decimal> PrimaryFee { get; set; }  
 
		public Nullable<Decimal> ChangeAmount { get; set; }  
 
		public Nullable<Int32> ChangeAmountType { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public String AnnexDocumentNumber { get; set; }  
 
		public Nullable<DateTime> AnnexDate { get; set; }  
 
		public Nullable<Int32> OldChangeID { get; set; }  
 
		public Int32 Nature { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public String ContractRowNumber { get; set; }  
 
		public Int32 ContractDLType { get; set; }  
 
		public Nullable<Int32> ParentContractRef { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Nullable<Decimal> OnAccountSum { get; set; }  
 
		public Nullable<Single> OnAccountDepreciationPercent { get; set; }  
 
		public Boolean NeedsBillSerial { get; set; } 

        public void Validate()
        {
            new AddContractCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
