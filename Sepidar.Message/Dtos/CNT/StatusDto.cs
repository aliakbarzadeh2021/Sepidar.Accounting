using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class StatusDto
    {
          
 
		public Int32 StatusID { get; set; }  
 
		public Int32 Nature { get; set; }  
 
		public Boolean Established { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Nullable<Decimal> InitialSettledValue { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> StatusRef { get; set; }  
 
		public Int32 StatusRefType { get; set; }  
 
		public Decimal ConfirmedCost { get; set; }  
 
		public Decimal CurrentCost { get; set; }  
 
		public Decimal Material { get; set; }  
 
		public Decimal PreReceipt { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Int32 SLRef { get; set; }  
 
		public Int32 ConfirmationState { get; set; }  
 
		public Nullable<DateTime> ConfirmationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> BillSerial { get; set; }  
 
		public Decimal Duty { get; set; } 
    }
}


