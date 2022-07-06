using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class GuaranteeDto
    {
          
 
		public Int32 GuaranteeID { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 DocumentNumber { get; set; }  
 
		public Nullable<Int32> TenderRef { get; set; }  
 
		public Nullable<Int32> ContractRef { get; set; }  
 
		public Int32 WarrantyRef { get; set; }  
 
		public Int32 Regard { get; set; }  
 
		public Int32 DlRef { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Nullable<DateTime> DueDate { get; set; }  
 
		public DateTime DeliveryDate { get; set; }  
 
		public String FurtherInfo { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; }  
 
		public String Number { get; set; }  
 
		public Nullable<Int32> BankBranchRef { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Nullable<Int32> PaymentRef { get; set; }  
 
		public Int32 Nature { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; }  
 
		public Nullable<Int32> BankRef { get; set; }  
 
		public String AccountNo { get; set; }  
 
		public Nullable<Int32> SLref { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> OldContractWarrantyItemId { get; set; } 
    }
}


