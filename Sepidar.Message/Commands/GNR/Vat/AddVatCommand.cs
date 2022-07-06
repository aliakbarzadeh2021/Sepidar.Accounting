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
    public class AddVatCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 VatID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime FromDate { get; set; }  
 
		public DateTime ToDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Decimal NonDiminutionTaxAndDuty { get; set; }  
 
		public Decimal NonDiminutionDuty { get; set; }  
 
		public Decimal DomesticSaleNonTaxExemptItems { get; set; }  
 
		public Decimal DomesticSaleNonTaxExemptServices { get; set; }  
 
		public Decimal DomesticSaleTaxExemptItems { get; set; }  
 
		public Decimal DomesticSaleTaxExemptServices { get; set; }  
 
		public Decimal ExportSaleItems { get; set; }  
 
		public Decimal ExportSaleServices { get; set; }  
 
		public Decimal ReceiptTaxDomesticSaleNonTaxExemptItems { get; set; }  
 
		public Decimal ReceiptTaxDomesticSaleNonTaxExemptServices { get; set; }  
 
		public Decimal ReceiptTaxDomesticSaleTaxExemptItems { get; set; }  
 
		public Decimal ReceiptTaxDomesticSaleTaxExemptServices { get; set; }  
 
		public Decimal ReceiptTaxExportSaleItems { get; set; }  
 
		public Decimal ReceiptTaxExportSaleServices { get; set; }  
 
		public Decimal DomesticPurchaseNonTaxExemptItems { get; set; }  
 
		public Decimal DomesticPurchaseNonTaxExemptServices { get; set; }  
 
		public Decimal DomesticPurchaseTaxExemptItems { get; set; }  
 
		public Decimal DomesticPurchaseTaxExemptServices { get; set; }  
 
		public Decimal ImportPurchaseNonTaxExemptItems { get; set; }  
 
		public Decimal ImportPurchaseNonTaxExemptServices { get; set; }  
 
		public Decimal ImportPurchaseTaxExemptItems { get; set; }  
 
		public Decimal ImportPurchaseTaxExemptServices { get; set; }  
 
		public Decimal PayedTaxDomesticPurchaseNonTaxExemptItems { get; set; }  
 
		public Decimal PayedTaxDomesticPurchaseNonTaxExemptServices { get; set; }  
 
		public Decimal PayedTaxDomesticPurchaseTaxExemptItems { get; set; }  
 
		public Decimal PayedTaxDomesticPurchaseTaxExemptServices { get; set; }  
 
		public Decimal PayedTaxImportPurchaseNonTaxExemptItems { get; set; }  
 
		public Decimal PayedTaxImportPurchaseNonTaxExemptServices { get; set; }  
 
		public Decimal PayedTaxImportPurchaseTaxExemptItems { get; set; }  
 
		public Decimal PayedTaxImportPurchaseTaxExemptServices { get; set; } 

        public void Validate()
        {
            new AddVatCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
