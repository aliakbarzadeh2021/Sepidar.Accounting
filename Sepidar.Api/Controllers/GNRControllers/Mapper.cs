using Sepidar.Domain.Entities;
using Sepidar.Message.Commands;
using Sepidar.Message.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sepidar.Api.Controllers
{
    public partial class Mapper
    {
                
        
        public static AutomaticBackupConfig Map(AddAutomaticBackupConfigCommand inputItem)
        {
            var entity = new AutomaticBackupConfig() {
                  
  
		AutomaticBackupConfigID = inputItem.AutomaticBackupConfigID,  
  
		IsActive = inputItem.IsActive,  
  
		BackupPath = inputItem.BackupPath,  
  
		Filename = inputItem.Filename,  
  
		BackupPeriod = inputItem.BackupPeriod,  
  
		BackupFrequency = inputItem.BackupFrequency,  
  
		BackupStartDateTime = inputItem.BackupStartDateTime,  
  
		LastBackupDate = inputItem.LastBackupDate,  
  
		IsPasswordProtected = inputItem.IsPasswordProtected,  
  
		Password = inputItem.Password,  
  
		DeleteOldFiles = inputItem.DeleteOldFiles,  
  
		NumberOfFiles = inputItem.NumberOfFiles,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AutomaticBackupConfig Map(AutomaticBackupConfig entity ,EditAutomaticBackupConfigCommand inputItem)
        {
              
  
		entity.AutomaticBackupConfigID = inputItem.AutomaticBackupConfigID;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.BackupPath = inputItem.BackupPath;  
  
		entity.Filename = inputItem.Filename;  
  
		entity.BackupPeriod = inputItem.BackupPeriod;  
  
		entity.BackupFrequency = inputItem.BackupFrequency;  
  
		entity.BackupStartDateTime = inputItem.BackupStartDateTime;  
  
		entity.LastBackupDate = inputItem.LastBackupDate;  
  
		entity.IsPasswordProtected = inputItem.IsPasswordProtected;  
  
		entity.Password = inputItem.Password;  
  
		entity.DeleteOldFiles = inputItem.DeleteOldFiles;  
  
		entity.NumberOfFiles = inputItem.NumberOfFiles;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AutomaticBackupConfigDto Map(AutomaticBackupConfig inputItem)
        {
            var dto = new AutomaticBackupConfigDto()
            {
                  
  
		AutomaticBackupConfigID = inputItem.AutomaticBackupConfigID,  
  
		IsActive = inputItem.IsActive,  
  
		BackupPath = inputItem.BackupPath,  
  
		Filename = inputItem.Filename,  
  
		BackupPeriod = inputItem.BackupPeriod,  
  
		BackupFrequency = inputItem.BackupFrequency,  
  
		BackupStartDateTime = inputItem.BackupStartDateTime,  
  
		LastBackupDate = inputItem.LastBackupDate,  
  
		IsPasswordProtected = inputItem.IsPasswordProtected,  
  
		Password = inputItem.Password,  
  
		DeleteOldFiles = inputItem.DeleteOldFiles,  
  
		NumberOfFiles = inputItem.NumberOfFiles,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<AutomaticBackupConfigDto> Map(ICollection<AutomaticBackupConfig> entities)
        {
            var dtos = new List<AutomaticBackupConfigDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AutomaticBackupConfigDto()
                {
                      
  
		AutomaticBackupConfigID = inputItem.AutomaticBackupConfigID,  
  
		IsActive = inputItem.IsActive,  
  
		BackupPath = inputItem.BackupPath,  
  
		Filename = inputItem.Filename,  
  
		BackupPeriod = inputItem.BackupPeriod,  
  
		BackupFrequency = inputItem.BackupFrequency,  
  
		BackupStartDateTime = inputItem.BackupStartDateTime,  
  
		LastBackupDate = inputItem.LastBackupDate,  
  
		IsPasswordProtected = inputItem.IsPasswordProtected,  
  
		Password = inputItem.Password,  
  
		DeleteOldFiles = inputItem.DeleteOldFiles,  
  
		NumberOfFiles = inputItem.NumberOfFiles,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Backup Map(AddBackupCommand inputItem)
        {
            var entity = new Backup() {
                  
  
		BackupID = inputItem.BackupID,  
  
		Label = inputItem.Label,  
  
		Date = inputItem.Date,  
  
		Path = inputItem.Path,  
  
		RestoreDate = inputItem.RestoreDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Filename = inputItem.Filename,  
  
		ServerName = inputItem.ServerName,  
  
		IsOk = inputItem.IsOk,  
  
		IsAutomatic = inputItem.IsAutomatic,  
  
		IsPasswordProtected = inputItem.IsPasswordProtected,  
  
		Password = inputItem.Password, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Backup Map(Backup entity ,EditBackupCommand inputItem)
        {
              
  
		entity.BackupID = inputItem.BackupID;  
  
		entity.Label = inputItem.Label;  
  
		entity.Date = inputItem.Date;  
  
		entity.Path = inputItem.Path;  
  
		entity.RestoreDate = inputItem.RestoreDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Filename = inputItem.Filename;  
  
		entity.ServerName = inputItem.ServerName;  
  
		entity.IsOk = inputItem.IsOk;  
  
		entity.IsAutomatic = inputItem.IsAutomatic;  
  
		entity.IsPasswordProtected = inputItem.IsPasswordProtected;  
  
		entity.Password = inputItem.Password; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BackupDto Map(Backup inputItem)
        {
            var dto = new BackupDto()
            {
                  
  
		BackupID = inputItem.BackupID,  
  
		Label = inputItem.Label,  
  
		Date = inputItem.Date,  
  
		Path = inputItem.Path,  
  
		RestoreDate = inputItem.RestoreDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Filename = inputItem.Filename,  
  
		ServerName = inputItem.ServerName,  
  
		IsOk = inputItem.IsOk,  
  
		IsAutomatic = inputItem.IsAutomatic,  
  
		IsPasswordProtected = inputItem.IsPasswordProtected,  
  
		Password = inputItem.Password, 
            };
            return dto;
        }

        public static List<BackupDto> Map(ICollection<Backup> entities)
        {
            var dtos = new List<BackupDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BackupDto()
                {
                      
  
		BackupID = inputItem.BackupID,  
  
		Label = inputItem.Label,  
  
		Date = inputItem.Date,  
  
		Path = inputItem.Path,  
  
		RestoreDate = inputItem.RestoreDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Filename = inputItem.Filename,  
  
		ServerName = inputItem.ServerName,  
  
		IsOk = inputItem.IsOk,  
  
		IsAutomatic = inputItem.IsAutomatic,  
  
		IsPasswordProtected = inputItem.IsPasswordProtected,  
  
		Password = inputItem.Password, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Bill Map(AddBillCommand inputItem)
        {
            var entity = new Bill() {
                  
  
		BillID = inputItem.BillID,  
  
		Type = inputItem.Type,  
  
		PartyRef = inputItem.PartyRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		LastRemainder = inputItem.LastRemainder,  
  
		NewRemainder = inputItem.NewRemainder,  
  
		RPARemainder = inputItem.RPARemainder,  
  
		ReturnedRemainder = inputItem.ReturnedRemainder,  
  
		EnteryRemainder = inputItem.EnteryRemainder,  
  
		OtherRemainder = inputItem.OtherRemainder,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		VoucherRef = inputItem.VoucherRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Bill Map(Bill entity ,EditBillCommand inputItem)
        {
              
  
		entity.BillID = inputItem.BillID;  
  
		entity.Type = inputItem.Type;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.LastRemainder = inputItem.LastRemainder;  
  
		entity.NewRemainder = inputItem.NewRemainder;  
  
		entity.RPARemainder = inputItem.RPARemainder;  
  
		entity.ReturnedRemainder = inputItem.ReturnedRemainder;  
  
		entity.EnteryRemainder = inputItem.EnteryRemainder;  
  
		entity.OtherRemainder = inputItem.OtherRemainder;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.VoucherRef = inputItem.VoucherRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BillDto Map(Bill inputItem)
        {
            var dto = new BillDto()
            {
                  
  
		BillID = inputItem.BillID,  
  
		Type = inputItem.Type,  
  
		PartyRef = inputItem.PartyRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		LastRemainder = inputItem.LastRemainder,  
  
		NewRemainder = inputItem.NewRemainder,  
  
		RPARemainder = inputItem.RPARemainder,  
  
		ReturnedRemainder = inputItem.ReturnedRemainder,  
  
		EnteryRemainder = inputItem.EnteryRemainder,  
  
		OtherRemainder = inputItem.OtherRemainder,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		VoucherRef = inputItem.VoucherRef, 
            };
            return dto;
        }

        public static List<BillDto> Map(ICollection<Bill> entities)
        {
            var dtos = new List<BillDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BillDto()
                {
                      
  
		BillID = inputItem.BillID,  
  
		Type = inputItem.Type,  
  
		PartyRef = inputItem.PartyRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		LastRemainder = inputItem.LastRemainder,  
  
		NewRemainder = inputItem.NewRemainder,  
  
		RPARemainder = inputItem.RPARemainder,  
  
		ReturnedRemainder = inputItem.ReturnedRemainder,  
  
		EnteryRemainder = inputItem.EnteryRemainder,  
  
		OtherRemainder = inputItem.OtherRemainder,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		VoucherRef = inputItem.VoucherRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BillItem Map(AddBillItemCommand inputItem)
        {
            var entity = new BillItem() {
                  
  
		BillItemID = inputItem.BillItemID,  
  
		BillRef = inputItem.BillRef,  
  
		RowID = inputItem.RowID,  
  
		Type = inputItem.Type,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		DebitCreditNoteRef = inputItem.DebitCreditNoteRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		RefundChequeRef = inputItem.RefundChequeRef,  
  
		ShredRef = inputItem.ShredRef,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		Amount = inputItem.Amount,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef,  
  
		CommercialOrderRef = inputItem.CommercialOrderRef,  
  
		CustomsClearanceRef = inputItem.CustomsClearanceRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BillItem Map(BillItem entity ,EditBillItemCommand inputItem)
        {
              
  
		entity.BillItemID = inputItem.BillItemID;  
  
		entity.BillRef = inputItem.BillRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.Type = inputItem.Type;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.DebitCreditNoteRef = inputItem.DebitCreditNoteRef;  
  
		entity.InventoryReceiptRef = inputItem.InventoryReceiptRef;  
  
		entity.ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.ReceiptHeaderRef = inputItem.ReceiptHeaderRef;  
  
		entity.RefundChequeRef = inputItem.RefundChequeRef;  
  
		entity.ShredRef = inputItem.ShredRef;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.EntityFullName = inputItem.EntityFullName;  
  
		entity.PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef;  
  
		entity.BillOfLoadingRef = inputItem.BillOfLoadingRef;  
  
		entity.InsurancePolicyRef = inputItem.InsurancePolicyRef;  
  
		entity.CommercialOrderRef = inputItem.CommercialOrderRef;  
  
		entity.CustomsClearanceRef = inputItem.CustomsClearanceRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BillItemDto Map(BillItem inputItem)
        {
            var dto = new BillItemDto()
            {
                  
  
		BillItemID = inputItem.BillItemID,  
  
		BillRef = inputItem.BillRef,  
  
		RowID = inputItem.RowID,  
  
		Type = inputItem.Type,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		DebitCreditNoteRef = inputItem.DebitCreditNoteRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		RefundChequeRef = inputItem.RefundChequeRef,  
  
		ShredRef = inputItem.ShredRef,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		Amount = inputItem.Amount,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef,  
  
		CommercialOrderRef = inputItem.CommercialOrderRef,  
  
		CustomsClearanceRef = inputItem.CustomsClearanceRef, 
            };
            return dto;
        }

        public static List<BillItemDto> Map(ICollection<BillItem> entities)
        {
            var dtos = new List<BillItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BillItemDto()
                {
                      
  
		BillItemID = inputItem.BillItemID,  
  
		BillRef = inputItem.BillRef,  
  
		RowID = inputItem.RowID,  
  
		Type = inputItem.Type,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		DebitCreditNoteRef = inputItem.DebitCreditNoteRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		RefundChequeRef = inputItem.RefundChequeRef,  
  
		ShredRef = inputItem.ShredRef,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		Amount = inputItem.Amount,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef,  
  
		CommercialOrderRef = inputItem.CommercialOrderRef,  
  
		CustomsClearanceRef = inputItem.CustomsClearanceRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CalculationElement Map(AddCalculationElementCommand inputItem)
        {
            var entity = new CalculationElement() {
                  
  
		CalculationElementID = inputItem.CalculationElementID,  
  
		Symbol = inputItem.Symbol,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CalculationElement Map(CalculationElement entity ,EditCalculationElementCommand inputItem)
        {
              
  
		entity.CalculationElementID = inputItem.CalculationElementID;  
  
		entity.Symbol = inputItem.Symbol;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CalculationElementDto Map(CalculationElement inputItem)
        {
            var dto = new CalculationElementDto()
            {
                  
  
		CalculationElementID = inputItem.CalculationElementID,  
  
		Symbol = inputItem.Symbol,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<CalculationElementDto> Map(ICollection<CalculationElement> entities)
        {
            var dtos = new List<CalculationElementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CalculationElementDto()
                {
                      
  
		CalculationElementID = inputItem.CalculationElementID,  
  
		Symbol = inputItem.Symbol,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CalculationFormula Map(AddCalculationFormulaCommand inputItem)
        {
            var entity = new CalculationFormula() {
                  
  
		CalculationFormulaID = inputItem.CalculationFormulaID,  
  
		Code = inputItem.Code,  
  
		Text = inputItem.Text,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CalculationFormula Map(CalculationFormula entity ,EditCalculationFormulaCommand inputItem)
        {
              
  
		entity.CalculationFormulaID = inputItem.CalculationFormulaID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Text = inputItem.Text;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CalculationFormulaDto Map(CalculationFormula inputItem)
        {
            var dto = new CalculationFormulaDto()
            {
                  
  
		CalculationFormulaID = inputItem.CalculationFormulaID,  
  
		Code = inputItem.Code,  
  
		Text = inputItem.Text,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<CalculationFormulaDto> Map(ICollection<CalculationFormula> entities)
        {
            var dtos = new List<CalculationFormulaDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CalculationFormulaDto()
                {
                      
  
		CalculationFormulaID = inputItem.CalculationFormulaID,  
  
		Code = inputItem.Code,  
  
		Text = inputItem.Text,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ClosingOperation Map(AddClosingOperationCommand inputItem)
        {
            var entity = new ClosingOperation() {
                  
  
		ClosingOperationId = inputItem.ClosingOperationId,  
  
		ClosingGroup = inputItem.ClosingGroup,  
  
		ItemId = inputItem.ItemId,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ClosingOperation Map(ClosingOperation entity ,EditClosingOperationCommand inputItem)
        {
              
  
		entity.ClosingOperationId = inputItem.ClosingOperationId;  
  
		entity.ClosingGroup = inputItem.ClosingGroup;  
  
		entity.ItemId = inputItem.ItemId;  
  
		entity.State = inputItem.State;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ClosingOperationDto Map(ClosingOperation inputItem)
        {
            var dto = new ClosingOperationDto()
            {
                  
  
		ClosingOperationId = inputItem.ClosingOperationId,  
  
		ClosingGroup = inputItem.ClosingGroup,  
  
		ItemId = inputItem.ItemId,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
            };
            return dto;
        }

        public static List<ClosingOperationDto> Map(ICollection<ClosingOperation> entities)
        {
            var dtos = new List<ClosingOperationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ClosingOperationDto()
                {
                      
  
		ClosingOperationId = inputItem.ClosingOperationId,  
  
		ClosingGroup = inputItem.ClosingGroup,  
  
		ItemId = inputItem.ItemId,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Communication Map(AddCommunicationCommand inputItem)
        {
            var entity = new Communication() {
                  
  
		CommunicationId = inputItem.CommunicationId,  
  
		System = inputItem.System,  
  
		Method = inputItem.Method,  
  
		RequestHttpMethod = inputItem.RequestHttpMethod,  
  
		RequestUrl = inputItem.RequestUrl,  
  
		RequestBody = inputItem.RequestBody,  
  
		SendingState = inputItem.SendingState,  
  
		NumberOfAttempts = inputItem.NumberOfAttempts,  
  
		LastAttemptTime = inputItem.LastAttemptTime,  
  
		UniqueId = inputItem.UniqueId,  
  
		ResponseStatusCode = inputItem.ResponseStatusCode,  
  
		ResponseRawText = inputItem.ResponseRawText,  
  
		ErrorMessage = inputItem.ErrorMessage,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Communication Map(Communication entity ,EditCommunicationCommand inputItem)
        {
              
  
		entity.CommunicationId = inputItem.CommunicationId;  
  
		entity.System = inputItem.System;  
  
		entity.Method = inputItem.Method;  
  
		entity.RequestHttpMethod = inputItem.RequestHttpMethod;  
  
		entity.RequestUrl = inputItem.RequestUrl;  
  
		entity.RequestBody = inputItem.RequestBody;  
  
		entity.SendingState = inputItem.SendingState;  
  
		entity.NumberOfAttempts = inputItem.NumberOfAttempts;  
  
		entity.LastAttemptTime = inputItem.LastAttemptTime;  
  
		entity.UniqueId = inputItem.UniqueId;  
  
		entity.ResponseStatusCode = inputItem.ResponseStatusCode;  
  
		entity.ResponseRawText = inputItem.ResponseRawText;  
  
		entity.ErrorMessage = inputItem.ErrorMessage;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommunicationDto Map(Communication inputItem)
        {
            var dto = new CommunicationDto()
            {
                  
  
		CommunicationId = inputItem.CommunicationId,  
  
		System = inputItem.System,  
  
		Method = inputItem.Method,  
  
		RequestHttpMethod = inputItem.RequestHttpMethod,  
  
		RequestUrl = inputItem.RequestUrl,  
  
		RequestBody = inputItem.RequestBody,  
  
		SendingState = inputItem.SendingState,  
  
		NumberOfAttempts = inputItem.NumberOfAttempts,  
  
		LastAttemptTime = inputItem.LastAttemptTime,  
  
		UniqueId = inputItem.UniqueId,  
  
		ResponseStatusCode = inputItem.ResponseStatusCode,  
  
		ResponseRawText = inputItem.ResponseRawText,  
  
		ErrorMessage = inputItem.ErrorMessage,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<CommunicationDto> Map(ICollection<Communication> entities)
        {
            var dtos = new List<CommunicationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommunicationDto()
                {
                      
  
		CommunicationId = inputItem.CommunicationId,  
  
		System = inputItem.System,  
  
		Method = inputItem.Method,  
  
		RequestHttpMethod = inputItem.RequestHttpMethod,  
  
		RequestUrl = inputItem.RequestUrl,  
  
		RequestBody = inputItem.RequestBody,  
  
		SendingState = inputItem.SendingState,  
  
		NumberOfAttempts = inputItem.NumberOfAttempts,  
  
		LastAttemptTime = inputItem.LastAttemptTime,  
  
		UniqueId = inputItem.UniqueId,  
  
		ResponseStatusCode = inputItem.ResponseStatusCode,  
  
		ResponseRawText = inputItem.ResponseRawText,  
  
		ErrorMessage = inputItem.ErrorMessage,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CommunicationConfiguration Map(AddCommunicationConfigurationCommand inputItem)
        {
            var entity = new CommunicationConfiguration() {
                  
  
		CommunicationConfigurationID = inputItem.CommunicationConfigurationID,  
  
		System = inputItem.System,  
  
		Key = inputItem.Key,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommunicationConfiguration Map(CommunicationConfiguration entity ,EditCommunicationConfigurationCommand inputItem)
        {
              
  
		entity.CommunicationConfigurationID = inputItem.CommunicationConfigurationID;  
  
		entity.System = inputItem.System;  
  
		entity.Key = inputItem.Key;  
  
		entity.Value = inputItem.Value;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommunicationConfigurationDto Map(CommunicationConfiguration inputItem)
        {
            var dto = new CommunicationConfigurationDto()
            {
                  
  
		CommunicationConfigurationID = inputItem.CommunicationConfigurationID,  
  
		System = inputItem.System,  
  
		Key = inputItem.Key,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<CommunicationConfigurationDto> Map(ICollection<CommunicationConfiguration> entities)
        {
            var dtos = new List<CommunicationConfigurationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommunicationConfigurationDto()
                {
                      
  
		CommunicationConfigurationID = inputItem.CommunicationConfigurationID,  
  
		System = inputItem.System,  
  
		Key = inputItem.Key,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CostCenter Map(AddCostCenterCommand inputItem)
        {
            var entity = new CostCenter() {
                  
  
		CostCenterId = inputItem.CostCenterId,  
  
		DLRef = inputItem.DLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Type = inputItem.Type, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CostCenter Map(CostCenter entity ,EditCostCenterCommand inputItem)
        {
              
  
		entity.CostCenterId = inputItem.CostCenterId;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Type = inputItem.Type; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CostCenterDto Map(CostCenter inputItem)
        {
            var dto = new CostCenterDto()
            {
                  
  
		CostCenterId = inputItem.CostCenterId,  
  
		DLRef = inputItem.DLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Type = inputItem.Type, 
            };
            return dto;
        }

        public static List<CostCenterDto> Map(ICollection<CostCenter> entities)
        {
            var dtos = new List<CostCenterDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CostCenterDto()
                {
                      
  
		CostCenterId = inputItem.CostCenterId,  
  
		DLRef = inputItem.DLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Type = inputItem.Type, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Currency Map(AddCurrencyCommand inputItem)
        {
            var entity = new Currency() {
                  
  
		CurrencyID = inputItem.CurrencyID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ExchangeUnit = inputItem.ExchangeUnit,  
  
		PrecisionCount = inputItem.PrecisionCount,  
  
		PrecisionName = inputItem.PrecisionName,  
  
		PrecisionName_En = inputItem.PrecisionName_En,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Currency Map(Currency entity ,EditCurrencyCommand inputItem)
        {
              
  
		entity.CurrencyID = inputItem.CurrencyID;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.ExchangeUnit = inputItem.ExchangeUnit;  
  
		entity.PrecisionCount = inputItem.PrecisionCount;  
  
		entity.PrecisionName = inputItem.PrecisionName;  
  
		entity.PrecisionName_En = inputItem.PrecisionName_En;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CurrencyDto Map(Currency inputItem)
        {
            var dto = new CurrencyDto()
            {
                  
  
		CurrencyID = inputItem.CurrencyID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ExchangeUnit = inputItem.ExchangeUnit,  
  
		PrecisionCount = inputItem.PrecisionCount,  
  
		PrecisionName = inputItem.PrecisionName,  
  
		PrecisionName_En = inputItem.PrecisionName_En,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<CurrencyDto> Map(ICollection<Currency> entities)
        {
            var dtos = new List<CurrencyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CurrencyDto()
                {
                      
  
		CurrencyID = inputItem.CurrencyID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ExchangeUnit = inputItem.ExchangeUnit,  
  
		PrecisionCount = inputItem.PrecisionCount,  
  
		PrecisionName = inputItem.PrecisionName,  
  
		PrecisionName_En = inputItem.PrecisionName_En,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CurrencyExchangeRate Map(AddCurrencyExchangeRateCommand inputItem)
        {
            var entity = new CurrencyExchangeRate() {
                  
  
		CurrencyExchangeRateId = inputItem.CurrencyExchangeRateId,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		EffectiveDate = inputItem.EffectiveDate,  
  
		ExchangeRate = inputItem.ExchangeRate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CurrencyExchangeRate Map(CurrencyExchangeRate entity ,EditCurrencyExchangeRateCommand inputItem)
        {
              
  
		entity.CurrencyExchangeRateId = inputItem.CurrencyExchangeRateId;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.EffectiveDate = inputItem.EffectiveDate;  
  
		entity.ExchangeRate = inputItem.ExchangeRate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CurrencyExchangeRateDto Map(CurrencyExchangeRate inputItem)
        {
            var dto = new CurrencyExchangeRateDto()
            {
                  
  
		CurrencyExchangeRateId = inputItem.CurrencyExchangeRateId,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		EffectiveDate = inputItem.EffectiveDate,  
  
		ExchangeRate = inputItem.ExchangeRate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
            };
            return dto;
        }

        public static List<CurrencyExchangeRateDto> Map(ICollection<CurrencyExchangeRate> entities)
        {
            var dtos = new List<CurrencyExchangeRateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CurrencyExchangeRateDto()
                {
                      
  
		CurrencyExchangeRateId = inputItem.CurrencyExchangeRateId,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		EffectiveDate = inputItem.EffectiveDate,  
  
		ExchangeRate = inputItem.ExchangeRate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static DebitCreditNote Map(AddDebitCreditNoteCommand inputItem)
        {
            var entity = new DebitCreditNote() {
                  
  
		DebitCreditNoteID = inputItem.DebitCreditNoteID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		SumAmount = inputItem.SumAmount,  
  
		SumAmountInBaseCurrency = inputItem.SumAmountInBaseCurrency, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DebitCreditNote Map(DebitCreditNote entity ,EditDebitCreditNoteCommand inputItem)
        {
              
  
		entity.DebitCreditNoteID = inputItem.DebitCreditNoteID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.SumAmount = inputItem.SumAmount;  
  
		entity.SumAmountInBaseCurrency = inputItem.SumAmountInBaseCurrency; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DebitCreditNoteDto Map(DebitCreditNote inputItem)
        {
            var dto = new DebitCreditNoteDto()
            {
                  
  
		DebitCreditNoteID = inputItem.DebitCreditNoteID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		SumAmount = inputItem.SumAmount,  
  
		SumAmountInBaseCurrency = inputItem.SumAmountInBaseCurrency, 
            };
            return dto;
        }

        public static List<DebitCreditNoteDto> Map(ICollection<DebitCreditNote> entities)
        {
            var dtos = new List<DebitCreditNoteDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DebitCreditNoteDto()
                {
                      
  
		DebitCreditNoteID = inputItem.DebitCreditNoteID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		SumAmount = inputItem.SumAmount,  
  
		SumAmountInBaseCurrency = inputItem.SumAmountInBaseCurrency, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static DebitCreditNoteItem Map(AddDebitCreditNoteItemCommand inputItem)
        {
            var entity = new DebitCreditNoteItem() {
                  
  
		DebitCreditNoteItemID = inputItem.DebitCreditNoteItemID,  
  
		DebitCreditNoteRef = inputItem.DebitCreditNoteRef,  
  
		RowID = inputItem.RowID,  
  
		DebitSLRef = inputItem.DebitSLRef,  
  
		CreditSLRef = inputItem.CreditSLRef,  
  
		DebitDLRef = inputItem.DebitDLRef,  
  
		CreditDLRef = inputItem.CreditDLRef,  
  
		DebitType = inputItem.DebitType,  
  
		CreditType = inputItem.CreditType,  
  
		Amount = inputItem.Amount,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DebitCreditNoteItem Map(DebitCreditNoteItem entity ,EditDebitCreditNoteItemCommand inputItem)
        {
              
  
		entity.DebitCreditNoteItemID = inputItem.DebitCreditNoteItemID;  
  
		entity.DebitCreditNoteRef = inputItem.DebitCreditNoteRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.DebitSLRef = inputItem.DebitSLRef;  
  
		entity.CreditSLRef = inputItem.CreditSLRef;  
  
		entity.DebitDLRef = inputItem.DebitDLRef;  
  
		entity.CreditDLRef = inputItem.CreditDLRef;  
  
		entity.DebitType = inputItem.DebitType;  
  
		entity.CreditType = inputItem.CreditType;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DebitCreditNoteItemDto Map(DebitCreditNoteItem inputItem)
        {
            var dto = new DebitCreditNoteItemDto()
            {
                  
  
		DebitCreditNoteItemID = inputItem.DebitCreditNoteItemID,  
  
		DebitCreditNoteRef = inputItem.DebitCreditNoteRef,  
  
		RowID = inputItem.RowID,  
  
		DebitSLRef = inputItem.DebitSLRef,  
  
		CreditSLRef = inputItem.CreditSLRef,  
  
		DebitDLRef = inputItem.DebitDLRef,  
  
		CreditDLRef = inputItem.CreditDLRef,  
  
		DebitType = inputItem.DebitType,  
  
		CreditType = inputItem.CreditType,  
  
		Amount = inputItem.Amount,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<DebitCreditNoteItemDto> Map(ICollection<DebitCreditNoteItem> entities)
        {
            var dtos = new List<DebitCreditNoteItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DebitCreditNoteItemDto()
                {
                      
  
		DebitCreditNoteItemID = inputItem.DebitCreditNoteItemID,  
  
		DebitCreditNoteRef = inputItem.DebitCreditNoteRef,  
  
		RowID = inputItem.RowID,  
  
		DebitSLRef = inputItem.DebitSLRef,  
  
		CreditSLRef = inputItem.CreditSLRef,  
  
		DebitDLRef = inputItem.DebitDLRef,  
  
		CreditDLRef = inputItem.CreditDLRef,  
  
		DebitType = inputItem.DebitType,  
  
		CreditType = inputItem.CreditType,  
  
		Amount = inputItem.Amount,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static DeliveryLocation Map(AddDeliveryLocationCommand inputItem)
        {
            var entity = new DeliveryLocation() {
                  
  
		DeliveryLocationID = inputItem.DeliveryLocationID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DeliveryLocation Map(DeliveryLocation entity ,EditDeliveryLocationCommand inputItem)
        {
              
  
		entity.DeliveryLocationID = inputItem.DeliveryLocationID;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DeliveryLocationDto Map(DeliveryLocation inputItem)
        {
            var dto = new DeliveryLocationDto()
            {
                  
  
		DeliveryLocationID = inputItem.DeliveryLocationID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<DeliveryLocationDto> Map(ICollection<DeliveryLocation> entities)
        {
            var dtos = new List<DeliveryLocationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DeliveryLocationDto()
                {
                      
  
		DeliveryLocationID = inputItem.DeliveryLocationID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Device Map(AddDeviceCommand inputItem)
        {
            var entity = new Device() {
                  
  
		DeviceId = inputItem.DeviceId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Code = inputItem.Code,  
  
		Key = inputItem.Key,  
  
		TempKey = inputItem.TempKey,  
  
		IntegrationId = inputItem.IntegrationId,  
  
		IsRegistered = inputItem.IsRegistered,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		DeviceType = inputItem.DeviceType, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Device Map(Device entity ,EditDeviceCommand inputItem)
        {
              
  
		entity.DeviceId = inputItem.DeviceId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Code = inputItem.Code;  
  
		entity.Key = inputItem.Key;  
  
		entity.TempKey = inputItem.TempKey;  
  
		entity.IntegrationId = inputItem.IntegrationId;  
  
		entity.IsRegistered = inputItem.IsRegistered;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.DeviceType = inputItem.DeviceType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DeviceDto Map(Device inputItem)
        {
            var dto = new DeviceDto()
            {
                  
  
		DeviceId = inputItem.DeviceId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Code = inputItem.Code,  
  
		Key = inputItem.Key,  
  
		TempKey = inputItem.TempKey,  
  
		IntegrationId = inputItem.IntegrationId,  
  
		IsRegistered = inputItem.IsRegistered,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		DeviceType = inputItem.DeviceType, 
            };
            return dto;
        }

        public static List<DeviceDto> Map(ICollection<Device> entities)
        {
            var dtos = new List<DeviceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DeviceDto()
                {
                      
  
		DeviceId = inputItem.DeviceId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Code = inputItem.Code,  
  
		Key = inputItem.Key,  
  
		TempKey = inputItem.TempKey,  
  
		IntegrationId = inputItem.IntegrationId,  
  
		IsRegistered = inputItem.IsRegistered,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		DeviceType = inputItem.DeviceType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static DeviceUserParty Map(AddDeviceUserPartyCommand inputItem)
        {
            var entity = new DeviceUserParty() {
                  
  
		DeviceUserPartyId = inputItem.DeviceUserPartyId,  
  
		DeviceRef = inputItem.DeviceRef,  
  
		UserRef = inputItem.UserRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DeviceUserParty Map(DeviceUserParty entity ,EditDeviceUserPartyCommand inputItem)
        {
              
  
		entity.DeviceUserPartyId = inputItem.DeviceUserPartyId;  
  
		entity.DeviceRef = inputItem.DeviceRef;  
  
		entity.UserRef = inputItem.UserRef;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DeviceUserPartyDto Map(DeviceUserParty inputItem)
        {
            var dto = new DeviceUserPartyDto()
            {
                  
  
		DeviceUserPartyId = inputItem.DeviceUserPartyId,  
  
		DeviceRef = inputItem.DeviceRef,  
  
		UserRef = inputItem.UserRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<DeviceUserPartyDto> Map(ICollection<DeviceUserParty> entities)
        {
            var dtos = new List<DeviceUserPartyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DeviceUserPartyDto()
                {
                      
  
		DeviceUserPartyId = inputItem.DeviceUserPartyId,  
  
		DeviceRef = inputItem.DeviceRef,  
  
		UserRef = inputItem.UserRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ElementSavedValue Map(AddElementSavedValueCommand inputItem)
        {
            var entity = new ElementSavedValue() {
                  
  
		ElementSavedValueID = inputItem.ElementSavedValueID,  
  
		CalculationFormulaRef = inputItem.CalculationFormulaRef,  
  
		Key = inputItem.Key,  
  
		Values = inputItem.Values, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ElementSavedValue Map(ElementSavedValue entity ,EditElementSavedValueCommand inputItem)
        {
              
  
		entity.ElementSavedValueID = inputItem.ElementSavedValueID;  
  
		entity.CalculationFormulaRef = inputItem.CalculationFormulaRef;  
  
		entity.Key = inputItem.Key;  
  
		entity.Values = inputItem.Values; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ElementSavedValueDto Map(ElementSavedValue inputItem)
        {
            var dto = new ElementSavedValueDto()
            {
                  
  
		ElementSavedValueID = inputItem.ElementSavedValueID,  
  
		CalculationFormulaRef = inputItem.CalculationFormulaRef,  
  
		Key = inputItem.Key,  
  
		Values = inputItem.Values, 
            };
            return dto;
        }

        public static List<ElementSavedValueDto> Map(ICollection<ElementSavedValue> entities)
        {
            var dtos = new List<ElementSavedValueDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ElementSavedValueDto()
                {
                      
  
		ElementSavedValueID = inputItem.ElementSavedValueID,  
  
		CalculationFormulaRef = inputItem.CalculationFormulaRef,  
  
		Key = inputItem.Key,  
  
		Values = inputItem.Values, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static EstablishmentCommunication Map(AddEstablishmentCommunicationCommand inputItem)
        {
            var entity = new EstablishmentCommunication() {
                  
  
		EstablishmentCommunicationId = inputItem.EstablishmentCommunicationId,  
  
		EntityName = inputItem.EntityName,  
  
		EntityCode = inputItem.EntityCode,  
  
		IsSynchronized = inputItem.IsSynchronized,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static EstablishmentCommunication Map(EstablishmentCommunication entity ,EditEstablishmentCommunicationCommand inputItem)
        {
              
  
		entity.EstablishmentCommunicationId = inputItem.EstablishmentCommunicationId;  
  
		entity.EntityName = inputItem.EntityName;  
  
		entity.EntityCode = inputItem.EntityCode;  
  
		entity.IsSynchronized = inputItem.IsSynchronized;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static EstablishmentCommunicationDto Map(EstablishmentCommunication inputItem)
        {
            var dto = new EstablishmentCommunicationDto()
            {
                  
  
		EstablishmentCommunicationId = inputItem.EstablishmentCommunicationId,  
  
		EntityName = inputItem.EntityName,  
  
		EntityCode = inputItem.EntityCode,  
  
		IsSynchronized = inputItem.IsSynchronized,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<EstablishmentCommunicationDto> Map(ICollection<EstablishmentCommunication> entities)
        {
            var dtos = new List<EstablishmentCommunicationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new EstablishmentCommunicationDto()
                {
                      
  
		EstablishmentCommunicationId = inputItem.EstablishmentCommunicationId,  
  
		EntityName = inputItem.EntityName,  
  
		EntityCode = inputItem.EntityCode,  
  
		IsSynchronized = inputItem.IsSynchronized,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static FormulaElement Map(AddFormulaElementCommand inputItem)
        {
            var entity = new FormulaElement() {
                  
  
		FormulaElementID = inputItem.FormulaElementID,  
  
		CalculationFormulaRef = inputItem.CalculationFormulaRef,  
  
		CalculationElementRef = inputItem.CalculationElementRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static FormulaElement Map(FormulaElement entity ,EditFormulaElementCommand inputItem)
        {
              
  
		entity.FormulaElementID = inputItem.FormulaElementID;  
  
		entity.CalculationFormulaRef = inputItem.CalculationFormulaRef;  
  
		entity.CalculationElementRef = inputItem.CalculationElementRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static FormulaElementDto Map(FormulaElement inputItem)
        {
            var dto = new FormulaElementDto()
            {
                  
  
		FormulaElementID = inputItem.FormulaElementID,  
  
		CalculationFormulaRef = inputItem.CalculationFormulaRef,  
  
		CalculationElementRef = inputItem.CalculationElementRef, 
            };
            return dto;
        }

        public static List<FormulaElementDto> Map(ICollection<FormulaElement> entities)
        {
            var dtos = new List<FormulaElementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new FormulaElementDto()
                {
                      
  
		FormulaElementID = inputItem.FormulaElementID,  
  
		CalculationFormulaRef = inputItem.CalculationFormulaRef,  
  
		CalculationElementRef = inputItem.CalculationElementRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Grouping Map(AddGroupingCommand inputItem)
        {
            var entity = new Grouping() {
                  
  
		GroupingID = inputItem.GroupingID,  
  
		EntityType = inputItem.EntityType,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		CalculationFormulaRef = inputItem.CalculationFormulaRef,  
  
		ParentGroupRef = inputItem.ParentGroupRef,  
  
		MaximumCredit = inputItem.MaximumCredit,  
  
		HasCredit = inputItem.HasCredit,  
  
		CreditCheckingType = inputItem.CreditCheckingType,  
  
		FullCode = inputItem.FullCode, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Grouping Map(Grouping entity ,EditGroupingCommand inputItem)
        {
              
  
		entity.GroupingID = inputItem.GroupingID;  
  
		entity.EntityType = inputItem.EntityType;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.CalculationFormulaRef = inputItem.CalculationFormulaRef;  
  
		entity.ParentGroupRef = inputItem.ParentGroupRef;  
  
		entity.MaximumCredit = inputItem.MaximumCredit;  
  
		entity.HasCredit = inputItem.HasCredit;  
  
		entity.CreditCheckingType = inputItem.CreditCheckingType;  
  
		entity.FullCode = inputItem.FullCode; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GroupingDto Map(Grouping inputItem)
        {
            var dto = new GroupingDto()
            {
                  
  
		GroupingID = inputItem.GroupingID,  
  
		EntityType = inputItem.EntityType,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		CalculationFormulaRef = inputItem.CalculationFormulaRef,  
  
		ParentGroupRef = inputItem.ParentGroupRef,  
  
		MaximumCredit = inputItem.MaximumCredit,  
  
		HasCredit = inputItem.HasCredit,  
  
		CreditCheckingType = inputItem.CreditCheckingType,  
  
		FullCode = inputItem.FullCode, 
            };
            return dto;
        }

        public static List<GroupingDto> Map(ICollection<Grouping> entities)
        {
            var dtos = new List<GroupingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GroupingDto()
                {
                      
  
		GroupingID = inputItem.GroupingID,  
  
		EntityType = inputItem.EntityType,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		CalculationFormulaRef = inputItem.CalculationFormulaRef,  
  
		ParentGroupRef = inputItem.ParentGroupRef,  
  
		MaximumCredit = inputItem.MaximumCredit,  
  
		HasCredit = inputItem.HasCredit,  
  
		CreditCheckingType = inputItem.CreditCheckingType,  
  
		FullCode = inputItem.FullCode, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Location Map(AddLocationCommand inputItem)
        {
            var entity = new Location() {
                  
  
		LocationId = inputItem.LocationId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Code = inputItem.Code,  
  
		Parent = inputItem.Parent,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		MinistryofFinanceCode = inputItem.MinistryofFinanceCode,  
  
		TaxFileCode = inputItem.TaxFileCode, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Location Map(Location entity ,EditLocationCommand inputItem)
        {
              
  
		entity.LocationId = inputItem.LocationId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Code = inputItem.Code;  
  
		entity.Parent = inputItem.Parent;  
  
		entity.Type = inputItem.Type;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.MinistryofFinanceCode = inputItem.MinistryofFinanceCode;  
  
		entity.TaxFileCode = inputItem.TaxFileCode; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static LocationDto Map(Location inputItem)
        {
            var dto = new LocationDto()
            {
                  
  
		LocationId = inputItem.LocationId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Code = inputItem.Code,  
  
		Parent = inputItem.Parent,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		MinistryofFinanceCode = inputItem.MinistryofFinanceCode,  
  
		TaxFileCode = inputItem.TaxFileCode, 
            };
            return dto;
        }

        public static List<LocationDto> Map(ICollection<Location> entities)
        {
            var dtos = new List<LocationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new LocationDto()
                {
                      
  
		LocationId = inputItem.LocationId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Code = inputItem.Code,  
  
		Parent = inputItem.Parent,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		MinistryofFinanceCode = inputItem.MinistryofFinanceCode,  
  
		TaxFileCode = inputItem.TaxFileCode, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Logo Map(AddLogoCommand inputItem)
        {
            var entity = new Logo() {
                  
  
		Logo1 = inputItem.Logo1, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Logo Map(Logo entity ,EditLogoCommand inputItem)
        {
              
  
		entity.Logo1 = inputItem.Logo1; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static LogoDto Map(Logo inputItem)
        {
            var dto = new LogoDto()
            {
                  
  
		Logo1 = inputItem.Logo1, 
            };
            return dto;
        }

        public static List<LogoDto> Map(ICollection<Logo> entities)
        {
            var dtos = new List<LogoDto>();
            foreach (var inputItem in entities)
            {
                var dto = new LogoDto()
                {
                      
  
		Logo1 = inputItem.Logo1, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MarketingDiskette Map(AddMarketingDisketteCommand inputItem)
        {
            var entity = new MarketingDiskette() {
                  
  
		MarketingDisketteID = inputItem.MarketingDisketteID,  
  
		year = inputItem.year,  
  
		Season = inputItem.Season,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Month = inputItem.Month,  
  
		PeriodType = inputItem.PeriodType,  
  
		FillItemNameByCategory = inputItem.FillItemNameByCategory, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MarketingDiskette Map(MarketingDiskette entity ,EditMarketingDisketteCommand inputItem)
        {
              
  
		entity.MarketingDisketteID = inputItem.MarketingDisketteID;  
  
		entity.year = inputItem.year;  
  
		entity.Season = inputItem.Season;  
  
		entity.Type = inputItem.Type;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Month = inputItem.Month;  
  
		entity.PeriodType = inputItem.PeriodType;  
  
		entity.FillItemNameByCategory = inputItem.FillItemNameByCategory; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MarketingDisketteDto Map(MarketingDiskette inputItem)
        {
            var dto = new MarketingDisketteDto()
            {
                  
  
		MarketingDisketteID = inputItem.MarketingDisketteID,  
  
		year = inputItem.year,  
  
		Season = inputItem.Season,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Month = inputItem.Month,  
  
		PeriodType = inputItem.PeriodType,  
  
		FillItemNameByCategory = inputItem.FillItemNameByCategory, 
            };
            return dto;
        }

        public static List<MarketingDisketteDto> Map(ICollection<MarketingDiskette> entities)
        {
            var dtos = new List<MarketingDisketteDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MarketingDisketteDto()
                {
                      
  
		MarketingDisketteID = inputItem.MarketingDisketteID,  
  
		year = inputItem.year,  
  
		Season = inputItem.Season,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Month = inputItem.Month,  
  
		PeriodType = inputItem.PeriodType,  
  
		FillItemNameByCategory = inputItem.FillItemNameByCategory, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MarketingDiskette1396 Map(AddMarketingDiskette1396Command inputItem)
        {
            var entity = new MarketingDiskette1396() {
                  
  
		MarketingDisketteID = inputItem.MarketingDisketteID,  
  
		year = inputItem.year,  
  
		Season = inputItem.Season,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MarketingDiskette1396 Map(MarketingDiskette1396 entity ,EditMarketingDiskette1396Command inputItem)
        {
              
  
		entity.MarketingDisketteID = inputItem.MarketingDisketteID;  
  
		entity.year = inputItem.year;  
  
		entity.Season = inputItem.Season;  
  
		entity.Type = inputItem.Type;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MarketingDiskette1396Dto Map(MarketingDiskette1396 inputItem)
        {
            var dto = new MarketingDiskette1396Dto()
            {
                  
  
		MarketingDisketteID = inputItem.MarketingDisketteID,  
  
		year = inputItem.year,  
  
		Season = inputItem.Season,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<MarketingDiskette1396Dto> Map(ICollection<MarketingDiskette1396> entities)
        {
            var dtos = new List<MarketingDiskette1396Dto>();
            foreach (var inputItem in entities)
            {
                var dto = new MarketingDiskette1396Dto()
                {
                      
  
		MarketingDisketteID = inputItem.MarketingDisketteID,  
  
		year = inputItem.year,  
  
		Season = inputItem.Season,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MarketingDisketteCurrency Map(AddMarketingDisketteCurrencyCommand inputItem)
        {
            var entity = new MarketingDisketteCurrency() {
                  
  
		MarketingDisketteCurrencyID = inputItem.MarketingDisketteCurrencyID,  
  
		Code = inputItem.Code,  
  
		Ttile = inputItem.Ttile,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MarketingDisketteCurrency Map(MarketingDisketteCurrency entity ,EditMarketingDisketteCurrencyCommand inputItem)
        {
              
  
		entity.MarketingDisketteCurrencyID = inputItem.MarketingDisketteCurrencyID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Ttile = inputItem.Ttile;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MarketingDisketteCurrencyDto Map(MarketingDisketteCurrency inputItem)
        {
            var dto = new MarketingDisketteCurrencyDto()
            {
                  
  
		MarketingDisketteCurrencyID = inputItem.MarketingDisketteCurrencyID,  
  
		Code = inputItem.Code,  
  
		Ttile = inputItem.Ttile,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<MarketingDisketteCurrencyDto> Map(ICollection<MarketingDisketteCurrency> entities)
        {
            var dtos = new List<MarketingDisketteCurrencyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MarketingDisketteCurrencyDto()
                {
                      
  
		MarketingDisketteCurrencyID = inputItem.MarketingDisketteCurrencyID,  
  
		Code = inputItem.Code,  
  
		Ttile = inputItem.Ttile,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MarketingDisketteCurrencyMapper Map(AddMarketingDisketteCurrencyMapperCommand inputItem)
        {
            var entity = new MarketingDisketteCurrencyMapper() {
                  
  
		MarketingDisketteCurrencyMapperID = inputItem.MarketingDisketteCurrencyMapperID,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		MarketingDisketteCurrencyRef = inputItem.MarketingDisketteCurrencyRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MarketingDisketteCurrencyMapper Map(MarketingDisketteCurrencyMapper entity ,EditMarketingDisketteCurrencyMapperCommand inputItem)
        {
              
  
		entity.MarketingDisketteCurrencyMapperID = inputItem.MarketingDisketteCurrencyMapperID;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.MarketingDisketteCurrencyRef = inputItem.MarketingDisketteCurrencyRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MarketingDisketteCurrencyMapperDto Map(MarketingDisketteCurrencyMapper inputItem)
        {
            var dto = new MarketingDisketteCurrencyMapperDto()
            {
                  
  
		MarketingDisketteCurrencyMapperID = inputItem.MarketingDisketteCurrencyMapperID,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		MarketingDisketteCurrencyRef = inputItem.MarketingDisketteCurrencyRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<MarketingDisketteCurrencyMapperDto> Map(ICollection<MarketingDisketteCurrencyMapper> entities)
        {
            var dtos = new List<MarketingDisketteCurrencyMapperDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MarketingDisketteCurrencyMapperDto()
                {
                      
  
		MarketingDisketteCurrencyMapperID = inputItem.MarketingDisketteCurrencyMapperID,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		MarketingDisketteCurrencyRef = inputItem.MarketingDisketteCurrencyRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MarketingDisketteItem Map(AddMarketingDisketteItemCommand inputItem)
        {
            var entity = new MarketingDisketteItem() {
                  
  
		MarketingDisketteItemID = inputItem.MarketingDisketteItemID,  
  
		MarketingDisketteRef = inputItem.MarketingDisketteRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		ReturnedInventoryReceiptRef = inputItem.ReturnedInventoryReceiptRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		StatusRef = inputItem.StatusRef,  
  
		UsedInDiskette = inputItem.UsedInDiskette,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		ISDealTypeLowerThanTenPercent = inputItem.ISDealTypeLowerThanTenPercent,  
  
		IsRefusal = inputItem.IsRefusal,  
  
		IsTransport = inputItem.IsTransport, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MarketingDisketteItem Map(MarketingDisketteItem entity ,EditMarketingDisketteItemCommand inputItem)
        {
              
  
		entity.MarketingDisketteItemID = inputItem.MarketingDisketteItemID;  
  
		entity.MarketingDisketteRef = inputItem.MarketingDisketteRef;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.InventoryReceiptRef = inputItem.InventoryReceiptRef;  
  
		entity.ReturnedInventoryReceiptRef = inputItem.ReturnedInventoryReceiptRef;  
  
		entity.ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef;  
  
		entity.StatusRef = inputItem.StatusRef;  
  
		entity.UsedInDiskette = inputItem.UsedInDiskette;  
  
		entity.EntityFullName = inputItem.EntityFullName;  
  
		entity.ISDealTypeLowerThanTenPercent = inputItem.ISDealTypeLowerThanTenPercent;  
  
		entity.IsRefusal = inputItem.IsRefusal;  
  
		entity.IsTransport = inputItem.IsTransport; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MarketingDisketteItemDto Map(MarketingDisketteItem inputItem)
        {
            var dto = new MarketingDisketteItemDto()
            {
                  
  
		MarketingDisketteItemID = inputItem.MarketingDisketteItemID,  
  
		MarketingDisketteRef = inputItem.MarketingDisketteRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		ReturnedInventoryReceiptRef = inputItem.ReturnedInventoryReceiptRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		StatusRef = inputItem.StatusRef,  
  
		UsedInDiskette = inputItem.UsedInDiskette,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		ISDealTypeLowerThanTenPercent = inputItem.ISDealTypeLowerThanTenPercent,  
  
		IsRefusal = inputItem.IsRefusal,  
  
		IsTransport = inputItem.IsTransport, 
            };
            return dto;
        }

        public static List<MarketingDisketteItemDto> Map(ICollection<MarketingDisketteItem> entities)
        {
            var dtos = new List<MarketingDisketteItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MarketingDisketteItemDto()
                {
                      
  
		MarketingDisketteItemID = inputItem.MarketingDisketteItemID,  
  
		MarketingDisketteRef = inputItem.MarketingDisketteRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		ReturnedInventoryReceiptRef = inputItem.ReturnedInventoryReceiptRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		StatusRef = inputItem.StatusRef,  
  
		UsedInDiskette = inputItem.UsedInDiskette,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		ISDealTypeLowerThanTenPercent = inputItem.ISDealTypeLowerThanTenPercent,  
  
		IsRefusal = inputItem.IsRefusal,  
  
		IsTransport = inputItem.IsTransport, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MarketingDisketteItem1396 Map(AddMarketingDisketteItem1396Command inputItem)
        {
            var entity = new MarketingDisketteItem1396() {
                  
  
		MarketingDisketteItemID = inputItem.MarketingDisketteItemID,  
  
		MarketingDisketteRef = inputItem.MarketingDisketteRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		ReturnedInventoryReceiptRef = inputItem.ReturnedInventoryReceiptRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		StatusRef = inputItem.StatusRef,  
  
		AssetPurchaseInvoiceRef = inputItem.AssetPurchaseInvoiceRef,  
  
		AssetSaleRef = inputItem.AssetSaleRef,  
  
		UsedInDiskette = inputItem.UsedInDiskette,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		ISDealTypeLowerThanMinPercent = inputItem.ISDealTypeLowerThanMinPercent,  
  
		IsTransport = inputItem.IsTransport,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef,  
  
		CustomsClearanceItemRef = inputItem.CustomsClearanceItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MarketingDisketteItem1396 Map(MarketingDisketteItem1396 entity ,EditMarketingDisketteItem1396Command inputItem)
        {
              
  
		entity.MarketingDisketteItemID = inputItem.MarketingDisketteItemID;  
  
		entity.MarketingDisketteRef = inputItem.MarketingDisketteRef;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.InventoryReceiptRef = inputItem.InventoryReceiptRef;  
  
		entity.ReturnedInventoryReceiptRef = inputItem.ReturnedInventoryReceiptRef;  
  
		entity.ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef;  
  
		entity.StatusRef = inputItem.StatusRef;  
  
		entity.AssetPurchaseInvoiceRef = inputItem.AssetPurchaseInvoiceRef;  
  
		entity.AssetSaleRef = inputItem.AssetSaleRef;  
  
		entity.UsedInDiskette = inputItem.UsedInDiskette;  
  
		entity.EntityFullName = inputItem.EntityFullName;  
  
		entity.ISDealTypeLowerThanMinPercent = inputItem.ISDealTypeLowerThanMinPercent;  
  
		entity.IsTransport = inputItem.IsTransport;  
  
		entity.BillOfLoadingRef = inputItem.BillOfLoadingRef;  
  
		entity.InsurancePolicyRef = inputItem.InsurancePolicyRef;  
  
		entity.CustomsClearanceItemRef = inputItem.CustomsClearanceItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MarketingDisketteItem1396Dto Map(MarketingDisketteItem1396 inputItem)
        {
            var dto = new MarketingDisketteItem1396Dto()
            {
                  
  
		MarketingDisketteItemID = inputItem.MarketingDisketteItemID,  
  
		MarketingDisketteRef = inputItem.MarketingDisketteRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		ReturnedInventoryReceiptRef = inputItem.ReturnedInventoryReceiptRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		StatusRef = inputItem.StatusRef,  
  
		AssetPurchaseInvoiceRef = inputItem.AssetPurchaseInvoiceRef,  
  
		AssetSaleRef = inputItem.AssetSaleRef,  
  
		UsedInDiskette = inputItem.UsedInDiskette,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		ISDealTypeLowerThanMinPercent = inputItem.ISDealTypeLowerThanMinPercent,  
  
		IsTransport = inputItem.IsTransport,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef,  
  
		CustomsClearanceItemRef = inputItem.CustomsClearanceItemRef, 
            };
            return dto;
        }

        public static List<MarketingDisketteItem1396Dto> Map(ICollection<MarketingDisketteItem1396> entities)
        {
            var dtos = new List<MarketingDisketteItem1396Dto>();
            foreach (var inputItem in entities)
            {
                var dto = new MarketingDisketteItem1396Dto()
                {
                      
  
		MarketingDisketteItemID = inputItem.MarketingDisketteItemID,  
  
		MarketingDisketteRef = inputItem.MarketingDisketteRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		ReturnedInventoryReceiptRef = inputItem.ReturnedInventoryReceiptRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		StatusRef = inputItem.StatusRef,  
  
		AssetPurchaseInvoiceRef = inputItem.AssetPurchaseInvoiceRef,  
  
		AssetSaleRef = inputItem.AssetSaleRef,  
  
		UsedInDiskette = inputItem.UsedInDiskette,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		ISDealTypeLowerThanMinPercent = inputItem.ISDealTypeLowerThanMinPercent,  
  
		IsTransport = inputItem.IsTransport,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef,  
  
		CustomsClearanceItemRef = inputItem.CustomsClearanceItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MarketingDiskettePartyMapper Map(AddMarketingDiskettePartyMapperCommand inputItem)
        {
            var entity = new MarketingDiskettePartyMapper() {
                  
  
		MarketingDiskettePartyMapperID = inputItem.MarketingDiskettePartyMapperID,  
  
		PartyRef = inputItem.PartyRef,  
  
		CustomerCategoryForTax95 = inputItem.CustomerCategoryForTax95,  
  
		CustomerCategoryForTax96 = inputItem.CustomerCategoryForTax96,  
  
		VendorCategoryForTax96 = inputItem.VendorCategoryForTax96,  
  
		VendorLocationRef = inputItem.VendorLocationRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MarketingDiskettePartyMapper Map(MarketingDiskettePartyMapper entity ,EditMarketingDiskettePartyMapperCommand inputItem)
        {
              
  
		entity.MarketingDiskettePartyMapperID = inputItem.MarketingDiskettePartyMapperID;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.CustomerCategoryForTax95 = inputItem.CustomerCategoryForTax95;  
  
		entity.CustomerCategoryForTax96 = inputItem.CustomerCategoryForTax96;  
  
		entity.VendorCategoryForTax96 = inputItem.VendorCategoryForTax96;  
  
		entity.VendorLocationRef = inputItem.VendorLocationRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MarketingDiskettePartyMapperDto Map(MarketingDiskettePartyMapper inputItem)
        {
            var dto = new MarketingDiskettePartyMapperDto()
            {
                  
  
		MarketingDiskettePartyMapperID = inputItem.MarketingDiskettePartyMapperID,  
  
		PartyRef = inputItem.PartyRef,  
  
		CustomerCategoryForTax95 = inputItem.CustomerCategoryForTax95,  
  
		CustomerCategoryForTax96 = inputItem.CustomerCategoryForTax96,  
  
		VendorCategoryForTax96 = inputItem.VendorCategoryForTax96,  
  
		VendorLocationRef = inputItem.VendorLocationRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<MarketingDiskettePartyMapperDto> Map(ICollection<MarketingDiskettePartyMapper> entities)
        {
            var dtos = new List<MarketingDiskettePartyMapperDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MarketingDiskettePartyMapperDto()
                {
                      
  
		MarketingDiskettePartyMapperID = inputItem.MarketingDiskettePartyMapperID,  
  
		PartyRef = inputItem.PartyRef,  
  
		CustomerCategoryForTax95 = inputItem.CustomerCategoryForTax95,  
  
		CustomerCategoryForTax96 = inputItem.CustomerCategoryForTax96,  
  
		VendorCategoryForTax96 = inputItem.VendorCategoryForTax96,  
  
		VendorLocationRef = inputItem.VendorLocationRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MarketingDiskettItemCategoryMapper Map(AddMarketingDiskettItemCategoryMapperCommand inputItem)
        {
            var entity = new MarketingDiskettItemCategoryMapper() {
                  
  
		MarketingDiskettItemCategoryMapperID = inputItem.MarketingDiskettItemCategoryMapperID,  
  
		ItemRef = inputItem.ItemRef,  
  
		ItemCategory95Ref = inputItem.ItemCategory95Ref,  
  
		ItemCategory96 = inputItem.ItemCategory96,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MarketingDiskettItemCategoryMapper Map(MarketingDiskettItemCategoryMapper entity ,EditMarketingDiskettItemCategoryMapperCommand inputItem)
        {
              
  
		entity.MarketingDiskettItemCategoryMapperID = inputItem.MarketingDiskettItemCategoryMapperID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.ItemCategory95Ref = inputItem.ItemCategory95Ref;  
  
		entity.ItemCategory96 = inputItem.ItemCategory96;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MarketingDiskettItemCategoryMapperDto Map(MarketingDiskettItemCategoryMapper inputItem)
        {
            var dto = new MarketingDiskettItemCategoryMapperDto()
            {
                  
  
		MarketingDiskettItemCategoryMapperID = inputItem.MarketingDiskettItemCategoryMapperID,  
  
		ItemRef = inputItem.ItemRef,  
  
		ItemCategory95Ref = inputItem.ItemCategory95Ref,  
  
		ItemCategory96 = inputItem.ItemCategory96,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<MarketingDiskettItemCategoryMapperDto> Map(ICollection<MarketingDiskettItemCategoryMapper> entities)
        {
            var dtos = new List<MarketingDiskettItemCategoryMapperDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MarketingDiskettItemCategoryMapperDto()
                {
                      
  
		MarketingDiskettItemCategoryMapperID = inputItem.MarketingDiskettItemCategoryMapperID,  
  
		ItemRef = inputItem.ItemRef,  
  
		ItemCategory95Ref = inputItem.ItemCategory95Ref,  
  
		ItemCategory96 = inputItem.ItemCategory96,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Party Map(AddPartyCommand inputItem)
        {
            var entity = new Party() {
                  
  
		PartyId = inputItem.PartyId,  
  
		Type = inputItem.Type,  
  
		SubType = inputItem.SubType,  
  
		Name = inputItem.Name,  
  
		LastName = inputItem.LastName,  
  
		Name_En = inputItem.Name_En,  
  
		LastName_En = inputItem.LastName_En,  
  
		EconomicCode = inputItem.EconomicCode,  
  
		IdentificationCode = inputItem.IdentificationCode,  
  
		RegistrationCode = inputItem.RegistrationCode,  
  
		Website = inputItem.Website,  
  
		Email = inputItem.Email,  
  
		DLRef = inputItem.DLRef,  
  
		IsInBlacklist = inputItem.IsInBlacklist,  
  
		IsVendor = inputItem.IsVendor,  
  
		VendorGroupingRef = inputItem.VendorGroupingRef,  
  
		IsBroker = inputItem.IsBroker,  
  
		BrokerGroupingRef = inputItem.BrokerGroupingRef,  
  
		CommissionRate = inputItem.CommissionRate,  
  
		BrokerOpeningBalance = inputItem.BrokerOpeningBalance,  
  
		BrokerOpeningBalanceType = inputItem.BrokerOpeningBalanceType,  
  
		IsEmployee = inputItem.IsEmployee,  
  
		IsCustomer = inputItem.IsCustomer,  
  
		SalespersonPartyRef = inputItem.SalespersonPartyRef,  
  
		DiscountRate = inputItem.DiscountRate,  
  
		MaximumCredit = inputItem.MaximumCredit,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef,  
  
		CustomerCategoryForTax = inputItem.CustomerCategoryForTax,  
  
		BirthDate = inputItem.BirthDate,  
  
		MarriageDate = inputItem.MarriageDate,  
  
		HasCredit = inputItem.HasCredit,  
  
		CreditCheckingType = inputItem.CreditCheckingType,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Guid = inputItem.Guid,  
  
		CustomerRemaining = inputItem.CustomerRemaining, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Party Map(Party entity ,EditPartyCommand inputItem)
        {
              
  
		entity.PartyId = inputItem.PartyId;  
  
		entity.Type = inputItem.Type;  
  
		entity.SubType = inputItem.SubType;  
  
		entity.Name = inputItem.Name;  
  
		entity.LastName = inputItem.LastName;  
  
		entity.Name_En = inputItem.Name_En;  
  
		entity.LastName_En = inputItem.LastName_En;  
  
		entity.EconomicCode = inputItem.EconomicCode;  
  
		entity.IdentificationCode = inputItem.IdentificationCode;  
  
		entity.RegistrationCode = inputItem.RegistrationCode;  
  
		entity.Website = inputItem.Website;  
  
		entity.Email = inputItem.Email;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.IsInBlacklist = inputItem.IsInBlacklist;  
  
		entity.IsVendor = inputItem.IsVendor;  
  
		entity.VendorGroupingRef = inputItem.VendorGroupingRef;  
  
		entity.IsBroker = inputItem.IsBroker;  
  
		entity.BrokerGroupingRef = inputItem.BrokerGroupingRef;  
  
		entity.CommissionRate = inputItem.CommissionRate;  
  
		entity.BrokerOpeningBalance = inputItem.BrokerOpeningBalance;  
  
		entity.BrokerOpeningBalanceType = inputItem.BrokerOpeningBalanceType;  
  
		entity.IsEmployee = inputItem.IsEmployee;  
  
		entity.IsCustomer = inputItem.IsCustomer;  
  
		entity.SalespersonPartyRef = inputItem.SalespersonPartyRef;  
  
		entity.DiscountRate = inputItem.DiscountRate;  
  
		entity.MaximumCredit = inputItem.MaximumCredit;  
  
		entity.CustomerGroupingRef = inputItem.CustomerGroupingRef;  
  
		entity.CustomerCategoryForTax = inputItem.CustomerCategoryForTax;  
  
		entity.BirthDate = inputItem.BirthDate;  
  
		entity.MarriageDate = inputItem.MarriageDate;  
  
		entity.HasCredit = inputItem.HasCredit;  
  
		entity.CreditCheckingType = inputItem.CreditCheckingType;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.CustomerRemaining = inputItem.CustomerRemaining; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartyDto Map(Party inputItem)
        {
            var dto = new PartyDto()
            {
                  
  
		PartyId = inputItem.PartyId,  
  
		Type = inputItem.Type,  
  
		SubType = inputItem.SubType,  
  
		Name = inputItem.Name,  
  
		LastName = inputItem.LastName,  
  
		Name_En = inputItem.Name_En,  
  
		LastName_En = inputItem.LastName_En,  
  
		EconomicCode = inputItem.EconomicCode,  
  
		IdentificationCode = inputItem.IdentificationCode,  
  
		RegistrationCode = inputItem.RegistrationCode,  
  
		Website = inputItem.Website,  
  
		Email = inputItem.Email,  
  
		DLRef = inputItem.DLRef,  
  
		IsInBlacklist = inputItem.IsInBlacklist,  
  
		IsVendor = inputItem.IsVendor,  
  
		VendorGroupingRef = inputItem.VendorGroupingRef,  
  
		IsBroker = inputItem.IsBroker,  
  
		BrokerGroupingRef = inputItem.BrokerGroupingRef,  
  
		CommissionRate = inputItem.CommissionRate,  
  
		BrokerOpeningBalance = inputItem.BrokerOpeningBalance,  
  
		BrokerOpeningBalanceType = inputItem.BrokerOpeningBalanceType,  
  
		IsEmployee = inputItem.IsEmployee,  
  
		IsCustomer = inputItem.IsCustomer,  
  
		SalespersonPartyRef = inputItem.SalespersonPartyRef,  
  
		DiscountRate = inputItem.DiscountRate,  
  
		MaximumCredit = inputItem.MaximumCredit,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef,  
  
		CustomerCategoryForTax = inputItem.CustomerCategoryForTax,  
  
		BirthDate = inputItem.BirthDate,  
  
		MarriageDate = inputItem.MarriageDate,  
  
		HasCredit = inputItem.HasCredit,  
  
		CreditCheckingType = inputItem.CreditCheckingType,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Guid = inputItem.Guid,  
  
		CustomerRemaining = inputItem.CustomerRemaining, 
            };
            return dto;
        }

        public static List<PartyDto> Map(ICollection<Party> entities)
        {
            var dtos = new List<PartyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartyDto()
                {
                      
  
		PartyId = inputItem.PartyId,  
  
		Type = inputItem.Type,  
  
		SubType = inputItem.SubType,  
  
		Name = inputItem.Name,  
  
		LastName = inputItem.LastName,  
  
		Name_En = inputItem.Name_En,  
  
		LastName_En = inputItem.LastName_En,  
  
		EconomicCode = inputItem.EconomicCode,  
  
		IdentificationCode = inputItem.IdentificationCode,  
  
		RegistrationCode = inputItem.RegistrationCode,  
  
		Website = inputItem.Website,  
  
		Email = inputItem.Email,  
  
		DLRef = inputItem.DLRef,  
  
		IsInBlacklist = inputItem.IsInBlacklist,  
  
		IsVendor = inputItem.IsVendor,  
  
		VendorGroupingRef = inputItem.VendorGroupingRef,  
  
		IsBroker = inputItem.IsBroker,  
  
		BrokerGroupingRef = inputItem.BrokerGroupingRef,  
  
		CommissionRate = inputItem.CommissionRate,  
  
		BrokerOpeningBalance = inputItem.BrokerOpeningBalance,  
  
		BrokerOpeningBalanceType = inputItem.BrokerOpeningBalanceType,  
  
		IsEmployee = inputItem.IsEmployee,  
  
		IsCustomer = inputItem.IsCustomer,  
  
		SalespersonPartyRef = inputItem.SalespersonPartyRef,  
  
		DiscountRate = inputItem.DiscountRate,  
  
		MaximumCredit = inputItem.MaximumCredit,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef,  
  
		CustomerCategoryForTax = inputItem.CustomerCategoryForTax,  
  
		BirthDate = inputItem.BirthDate,  
  
		MarriageDate = inputItem.MarriageDate,  
  
		HasCredit = inputItem.HasCredit,  
  
		CreditCheckingType = inputItem.CreditCheckingType,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Guid = inputItem.Guid,  
  
		CustomerRemaining = inputItem.CustomerRemaining, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartyAddress Map(AddPartyAddressCommand inputItem)
        {
            var entity = new PartyAddress() {
                  
  
		PartyAddressId = inputItem.PartyAddressId,  
  
		PartyRef = inputItem.PartyRef,  
  
		IsMain = inputItem.IsMain,  
  
		Type = inputItem.Type,  
  
		Address = inputItem.Address,  
  
		LocationRef = inputItem.LocationRef,  
  
		ZipCode = inputItem.ZipCode,  
  
		Adress_En = inputItem.Adress_En,  
  
		Title = inputItem.Title,  
  
		Latitude = inputItem.Latitude,  
  
		Longitude = inputItem.Longitude,  
  
		Version = inputItem.Version,  
  
		Guid = inputItem.Guid, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartyAddress Map(PartyAddress entity ,EditPartyAddressCommand inputItem)
        {
              
  
		entity.PartyAddressId = inputItem.PartyAddressId;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.IsMain = inputItem.IsMain;  
  
		entity.Type = inputItem.Type;  
  
		entity.Address = inputItem.Address;  
  
		entity.LocationRef = inputItem.LocationRef;  
  
		entity.ZipCode = inputItem.ZipCode;  
  
		entity.Adress_En = inputItem.Adress_En;  
  
		entity.Title = inputItem.Title;  
  
		entity.Latitude = inputItem.Latitude;  
  
		entity.Longitude = inputItem.Longitude;  
  
		entity.Version = inputItem.Version;  
  
		entity.Guid = inputItem.Guid; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartyAddressDto Map(PartyAddress inputItem)
        {
            var dto = new PartyAddressDto()
            {
                  
  
		PartyAddressId = inputItem.PartyAddressId,  
  
		PartyRef = inputItem.PartyRef,  
  
		IsMain = inputItem.IsMain,  
  
		Type = inputItem.Type,  
  
		Address = inputItem.Address,  
  
		LocationRef = inputItem.LocationRef,  
  
		ZipCode = inputItem.ZipCode,  
  
		Adress_En = inputItem.Adress_En,  
  
		Title = inputItem.Title,  
  
		Latitude = inputItem.Latitude,  
  
		Longitude = inputItem.Longitude,  
  
		Version = inputItem.Version,  
  
		Guid = inputItem.Guid, 
            };
            return dto;
        }

        public static List<PartyAddressDto> Map(ICollection<PartyAddress> entities)
        {
            var dtos = new List<PartyAddressDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartyAddressDto()
                {
                      
  
		PartyAddressId = inputItem.PartyAddressId,  
  
		PartyRef = inputItem.PartyRef,  
  
		IsMain = inputItem.IsMain,  
  
		Type = inputItem.Type,  
  
		Address = inputItem.Address,  
  
		LocationRef = inputItem.LocationRef,  
  
		ZipCode = inputItem.ZipCode,  
  
		Adress_En = inputItem.Adress_En,  
  
		Title = inputItem.Title,  
  
		Latitude = inputItem.Latitude,  
  
		Longitude = inputItem.Longitude,  
  
		Version = inputItem.Version,  
  
		Guid = inputItem.Guid, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartyOpeningBalance Map(AddPartyOpeningBalanceCommand inputItem)
        {
            var entity = new PartyOpeningBalance() {
                  
  
		PartyOpeningBalanceID = inputItem.PartyOpeningBalanceID,  
  
		Type = inputItem.Type,  
  
		OpeningBalance = inputItem.OpeningBalance,  
  
		PartyRef = inputItem.PartyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		OpeningBalanceType = inputItem.OpeningBalanceType,  
  
		FeedFromClosingOperation = inputItem.FeedFromClosingOperation, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartyOpeningBalance Map(PartyOpeningBalance entity ,EditPartyOpeningBalanceCommand inputItem)
        {
              
  
		entity.PartyOpeningBalanceID = inputItem.PartyOpeningBalanceID;  
  
		entity.Type = inputItem.Type;  
  
		entity.OpeningBalance = inputItem.OpeningBalance;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.OpeningBalanceType = inputItem.OpeningBalanceType;  
  
		entity.FeedFromClosingOperation = inputItem.FeedFromClosingOperation; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartyOpeningBalanceDto Map(PartyOpeningBalance inputItem)
        {
            var dto = new PartyOpeningBalanceDto()
            {
                  
  
		PartyOpeningBalanceID = inputItem.PartyOpeningBalanceID,  
  
		Type = inputItem.Type,  
  
		OpeningBalance = inputItem.OpeningBalance,  
  
		PartyRef = inputItem.PartyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		OpeningBalanceType = inputItem.OpeningBalanceType,  
  
		FeedFromClosingOperation = inputItem.FeedFromClosingOperation, 
            };
            return dto;
        }

        public static List<PartyOpeningBalanceDto> Map(ICollection<PartyOpeningBalance> entities)
        {
            var dtos = new List<PartyOpeningBalanceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartyOpeningBalanceDto()
                {
                      
  
		PartyOpeningBalanceID = inputItem.PartyOpeningBalanceID,  
  
		Type = inputItem.Type,  
  
		OpeningBalance = inputItem.OpeningBalance,  
  
		PartyRef = inputItem.PartyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		OpeningBalanceType = inputItem.OpeningBalanceType,  
  
		FeedFromClosingOperation = inputItem.FeedFromClosingOperation, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartyPhone Map(AddPartyPhoneCommand inputItem)
        {
            var entity = new PartyPhone() {
                  
  
		PartyPhoneId = inputItem.PartyPhoneId,  
  
		PartyRef = inputItem.PartyRef,  
  
		IsMain = inputItem.IsMain,  
  
		Type = inputItem.Type,  
  
		Phone = inputItem.Phone,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartyPhone Map(PartyPhone entity ,EditPartyPhoneCommand inputItem)
        {
              
  
		entity.PartyPhoneId = inputItem.PartyPhoneId;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.IsMain = inputItem.IsMain;  
  
		entity.Type = inputItem.Type;  
  
		entity.Phone = inputItem.Phone;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartyPhoneDto Map(PartyPhone inputItem)
        {
            var dto = new PartyPhoneDto()
            {
                  
  
		PartyPhoneId = inputItem.PartyPhoneId,  
  
		PartyRef = inputItem.PartyRef,  
  
		IsMain = inputItem.IsMain,  
  
		Type = inputItem.Type,  
  
		Phone = inputItem.Phone,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PartyPhoneDto> Map(ICollection<PartyPhone> entities)
        {
            var dtos = new List<PartyPhoneDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartyPhoneDto()
                {
                      
  
		PartyPhoneId = inputItem.PartyPhoneId,  
  
		PartyRef = inputItem.PartyRef,  
  
		IsMain = inputItem.IsMain,  
  
		Type = inputItem.Type,  
  
		Phone = inputItem.Phone,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartyRelated Map(AddPartyRelatedCommand inputItem)
        {
            var entity = new PartyRelated() {
                  
  
		PartyRelatedId = inputItem.PartyRelatedId,  
  
		PartyRef = inputItem.PartyRef,  
  
		IsMain = inputItem.IsMain,  
  
		Name = inputItem.Name,  
  
		Post = inputItem.Post,  
  
		Name_En = inputItem.Name_En,  
  
		Post_En = inputItem.Post_En,  
  
		Phone = inputItem.Phone,  
  
		Email = inputItem.Email,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartyRelated Map(PartyRelated entity ,EditPartyRelatedCommand inputItem)
        {
              
  
		entity.PartyRelatedId = inputItem.PartyRelatedId;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.IsMain = inputItem.IsMain;  
  
		entity.Name = inputItem.Name;  
  
		entity.Post = inputItem.Post;  
  
		entity.Name_En = inputItem.Name_En;  
  
		entity.Post_En = inputItem.Post_En;  
  
		entity.Phone = inputItem.Phone;  
  
		entity.Email = inputItem.Email;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartyRelatedDto Map(PartyRelated inputItem)
        {
            var dto = new PartyRelatedDto()
            {
                  
  
		PartyRelatedId = inputItem.PartyRelatedId,  
  
		PartyRef = inputItem.PartyRef,  
  
		IsMain = inputItem.IsMain,  
  
		Name = inputItem.Name,  
  
		Post = inputItem.Post,  
  
		Name_En = inputItem.Name_En,  
  
		Post_En = inputItem.Post_En,  
  
		Phone = inputItem.Phone,  
  
		Email = inputItem.Email,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PartyRelatedDto> Map(ICollection<PartyRelated> entities)
        {
            var dtos = new List<PartyRelatedDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartyRelatedDto()
                {
                      
  
		PartyRelatedId = inputItem.PartyRelatedId,  
  
		PartyRef = inputItem.PartyRef,  
  
		IsMain = inputItem.IsMain,  
  
		Name = inputItem.Name,  
  
		Post = inputItem.Post,  
  
		Name_En = inputItem.Name_En,  
  
		Post_En = inputItem.Post_En,  
  
		Phone = inputItem.Phone,  
  
		Email = inputItem.Email,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PiofyEmployeeMapper Map(AddPiofyEmployeeMapperCommand inputItem)
        {
            var entity = new PiofyEmployeeMapper() {
                  
  
		PiofyEmployeeMapperID = inputItem.PiofyEmployeeMapperID,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		PiofyEmployeeID = inputItem.PiofyEmployeeID,  
  
		PiofyEmploymentType = inputItem.PiofyEmploymentType,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PiofyEmployeeMapper Map(PiofyEmployeeMapper entity ,EditPiofyEmployeeMapperCommand inputItem)
        {
              
  
		entity.PiofyEmployeeMapperID = inputItem.PiofyEmployeeMapperID;  
  
		entity.PersonnelRef = inputItem.PersonnelRef;  
  
		entity.PiofyEmployeeID = inputItem.PiofyEmployeeID;  
  
		entity.PiofyEmploymentType = inputItem.PiofyEmploymentType;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PiofyEmployeeMapperDto Map(PiofyEmployeeMapper inputItem)
        {
            var dto = new PiofyEmployeeMapperDto()
            {
                  
  
		PiofyEmployeeMapperID = inputItem.PiofyEmployeeMapperID,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		PiofyEmployeeID = inputItem.PiofyEmployeeID,  
  
		PiofyEmploymentType = inputItem.PiofyEmploymentType,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<PiofyEmployeeMapperDto> Map(ICollection<PiofyEmployeeMapper> entities)
        {
            var dtos = new List<PiofyEmployeeMapperDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PiofyEmployeeMapperDto()
                {
                      
  
		PiofyEmployeeMapperID = inputItem.PiofyEmployeeMapperID,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		PiofyEmployeeID = inputItem.PiofyEmployeeID,  
  
		PiofyEmploymentType = inputItem.PiofyEmploymentType,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Shred Map(AddShredCommand inputItem)
        {
            var entity = new Shred() {
                  
  
		ShredID = inputItem.ShredID,  
  
		Number = inputItem.Number,  
  
		Key = inputItem.Key,  
  
		TargetRef = inputItem.TargetRef,  
  
		DLRef = inputItem.DLRef,  
  
		Date = inputItem.Date,  
  
		Amount = inputItem.Amount,  
  
		InterestAmount = inputItem.InterestAmount,  
  
		TotalAmount = inputItem.TotalAmount,  
  
		RemainedAmount = inputItem.RemainedAmount,  
  
		PenaltyRate = inputItem.PenaltyRate,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		InterestAccountSLRef = inputItem.InterestAccountSLRef,  
  
		PenaltyAccountSLRef = inputItem.PenaltyAccountSLRef,  
  
		RPType = inputItem.RPType, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Shred Map(Shred entity ,EditShredCommand inputItem)
        {
              
  
		entity.ShredID = inputItem.ShredID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Key = inputItem.Key;  
  
		entity.TargetRef = inputItem.TargetRef;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.InterestAmount = inputItem.InterestAmount;  
  
		entity.TotalAmount = inputItem.TotalAmount;  
  
		entity.RemainedAmount = inputItem.RemainedAmount;  
  
		entity.PenaltyRate = inputItem.PenaltyRate;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.InterestAccountSLRef = inputItem.InterestAccountSLRef;  
  
		entity.PenaltyAccountSLRef = inputItem.PenaltyAccountSLRef;  
  
		entity.RPType = inputItem.RPType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ShredDto Map(Shred inputItem)
        {
            var dto = new ShredDto()
            {
                  
  
		ShredID = inputItem.ShredID,  
  
		Number = inputItem.Number,  
  
		Key = inputItem.Key,  
  
		TargetRef = inputItem.TargetRef,  
  
		DLRef = inputItem.DLRef,  
  
		Date = inputItem.Date,  
  
		Amount = inputItem.Amount,  
  
		InterestAmount = inputItem.InterestAmount,  
  
		TotalAmount = inputItem.TotalAmount,  
  
		RemainedAmount = inputItem.RemainedAmount,  
  
		PenaltyRate = inputItem.PenaltyRate,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		InterestAccountSLRef = inputItem.InterestAccountSLRef,  
  
		PenaltyAccountSLRef = inputItem.PenaltyAccountSLRef,  
  
		RPType = inputItem.RPType, 
            };
            return dto;
        }

        public static List<ShredDto> Map(ICollection<Shred> entities)
        {
            var dtos = new List<ShredDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ShredDto()
                {
                      
  
		ShredID = inputItem.ShredID,  
  
		Number = inputItem.Number,  
  
		Key = inputItem.Key,  
  
		TargetRef = inputItem.TargetRef,  
  
		DLRef = inputItem.DLRef,  
  
		Date = inputItem.Date,  
  
		Amount = inputItem.Amount,  
  
		InterestAmount = inputItem.InterestAmount,  
  
		TotalAmount = inputItem.TotalAmount,  
  
		RemainedAmount = inputItem.RemainedAmount,  
  
		PenaltyRate = inputItem.PenaltyRate,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		InterestAccountSLRef = inputItem.InterestAccountSLRef,  
  
		PenaltyAccountSLRef = inputItem.PenaltyAccountSLRef,  
  
		RPType = inputItem.RPType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ShredInfo Map(AddShredInfoCommand inputItem)
        {
            var entity = new ShredInfo() {
                  
  
		ShredInfoID = inputItem.ShredInfoID,  
  
		ShredRef = inputItem.ShredRef,  
  
		ShredLength = inputItem.ShredLength,  
  
		ShredCount = inputItem.ShredCount,  
  
		InterestType = inputItem.InterestType,  
  
		InterestRate = inputItem.InterestRate,  
  
		PenaltyRate = inputItem.PenaltyRate,  
  
		RoundDigCount = inputItem.RoundDigCount,  
  
		StartDate = inputItem.StartDate,  
  
		TransferType = inputItem.TransferType,  
  
		InterestAmount = inputItem.InterestAmount,  
  
		ShredAmount = inputItem.ShredAmount,  
  
		FinishDate = inputItem.FinishDate,  
  
		Length = inputItem.Length, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ShredInfo Map(ShredInfo entity ,EditShredInfoCommand inputItem)
        {
              
  
		entity.ShredInfoID = inputItem.ShredInfoID;  
  
		entity.ShredRef = inputItem.ShredRef;  
  
		entity.ShredLength = inputItem.ShredLength;  
  
		entity.ShredCount = inputItem.ShredCount;  
  
		entity.InterestType = inputItem.InterestType;  
  
		entity.InterestRate = inputItem.InterestRate;  
  
		entity.PenaltyRate = inputItem.PenaltyRate;  
  
		entity.RoundDigCount = inputItem.RoundDigCount;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.TransferType = inputItem.TransferType;  
  
		entity.InterestAmount = inputItem.InterestAmount;  
  
		entity.ShredAmount = inputItem.ShredAmount;  
  
		entity.FinishDate = inputItem.FinishDate;  
  
		entity.Length = inputItem.Length; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ShredInfoDto Map(ShredInfo inputItem)
        {
            var dto = new ShredInfoDto()
            {
                  
  
		ShredInfoID = inputItem.ShredInfoID,  
  
		ShredRef = inputItem.ShredRef,  
  
		ShredLength = inputItem.ShredLength,  
  
		ShredCount = inputItem.ShredCount,  
  
		InterestType = inputItem.InterestType,  
  
		InterestRate = inputItem.InterestRate,  
  
		PenaltyRate = inputItem.PenaltyRate,  
  
		RoundDigCount = inputItem.RoundDigCount,  
  
		StartDate = inputItem.StartDate,  
  
		TransferType = inputItem.TransferType,  
  
		InterestAmount = inputItem.InterestAmount,  
  
		ShredAmount = inputItem.ShredAmount,  
  
		FinishDate = inputItem.FinishDate,  
  
		Length = inputItem.Length, 
            };
            return dto;
        }

        public static List<ShredInfoDto> Map(ICollection<ShredInfo> entities)
        {
            var dtos = new List<ShredInfoDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ShredInfoDto()
                {
                      
  
		ShredInfoID = inputItem.ShredInfoID,  
  
		ShredRef = inputItem.ShredRef,  
  
		ShredLength = inputItem.ShredLength,  
  
		ShredCount = inputItem.ShredCount,  
  
		InterestType = inputItem.InterestType,  
  
		InterestRate = inputItem.InterestRate,  
  
		PenaltyRate = inputItem.PenaltyRate,  
  
		RoundDigCount = inputItem.RoundDigCount,  
  
		StartDate = inputItem.StartDate,  
  
		TransferType = inputItem.TransferType,  
  
		InterestAmount = inputItem.InterestAmount,  
  
		ShredAmount = inputItem.ShredAmount,  
  
		FinishDate = inputItem.FinishDate,  
  
		Length = inputItem.Length, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ShredItem Map(AddShredItemCommand inputItem)
        {
            var entity = new ShredItem() {
                  
  
		ShredItemID = inputItem.ShredItemID,  
  
		ShredRef = inputItem.ShredRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		UsanceDate = inputItem.UsanceDate,  
  
		Amount = inputItem.Amount,  
  
		InterestAmount = inputItem.InterestAmount,  
  
		PenaltyAmount = inputItem.PenaltyAmount,  
  
		PenaltyRate = inputItem.PenaltyRate,  
  
		Status = inputItem.Status,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PartySettlementRef = inputItem.PartySettlementRef,  
  
		PaymentDate = inputItem.PaymentDate,  
  
		IsPaid = inputItem.IsPaid,  
  
		PaidDate = inputItem.PaidDate,  
  
		PaidDesc = inputItem.PaidDesc, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ShredItem Map(ShredItem entity ,EditShredItemCommand inputItem)
        {
              
  
		entity.ShredItemID = inputItem.ShredItemID;  
  
		entity.ShredRef = inputItem.ShredRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.UsanceDate = inputItem.UsanceDate;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.InterestAmount = inputItem.InterestAmount;  
  
		entity.PenaltyAmount = inputItem.PenaltyAmount;  
  
		entity.PenaltyRate = inputItem.PenaltyRate;  
  
		entity.Status = inputItem.Status;  
  
		entity.PaymentRef = inputItem.PaymentRef;  
  
		entity.ReceiptRef = inputItem.ReceiptRef;  
  
		entity.PartySettlementRef = inputItem.PartySettlementRef;  
  
		entity.PaymentDate = inputItem.PaymentDate;  
  
		entity.IsPaid = inputItem.IsPaid;  
  
		entity.PaidDate = inputItem.PaidDate;  
  
		entity.PaidDesc = inputItem.PaidDesc; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ShredItemDto Map(ShredItem inputItem)
        {
            var dto = new ShredItemDto()
            {
                  
  
		ShredItemID = inputItem.ShredItemID,  
  
		ShredRef = inputItem.ShredRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		UsanceDate = inputItem.UsanceDate,  
  
		Amount = inputItem.Amount,  
  
		InterestAmount = inputItem.InterestAmount,  
  
		PenaltyAmount = inputItem.PenaltyAmount,  
  
		PenaltyRate = inputItem.PenaltyRate,  
  
		Status = inputItem.Status,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PartySettlementRef = inputItem.PartySettlementRef,  
  
		PaymentDate = inputItem.PaymentDate,  
  
		IsPaid = inputItem.IsPaid,  
  
		PaidDate = inputItem.PaidDate,  
  
		PaidDesc = inputItem.PaidDesc, 
            };
            return dto;
        }

        public static List<ShredItemDto> Map(ICollection<ShredItem> entities)
        {
            var dtos = new List<ShredItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ShredItemDto()
                {
                      
  
		ShredItemID = inputItem.ShredItemID,  
  
		ShredRef = inputItem.ShredRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		UsanceDate = inputItem.UsanceDate,  
  
		Amount = inputItem.Amount,  
  
		InterestAmount = inputItem.InterestAmount,  
  
		PenaltyAmount = inputItem.PenaltyAmount,  
  
		PenaltyRate = inputItem.PenaltyRate,  
  
		Status = inputItem.Status,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PartySettlementRef = inputItem.PartySettlementRef,  
  
		PaymentDate = inputItem.PaymentDate,  
  
		IsPaid = inputItem.IsPaid,  
  
		PaidDate = inputItem.PaidDate,  
  
		PaidDesc = inputItem.PaidDesc, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Truck Map(AddTruckCommand inputItem)
        {
            var entity = new Truck() {
                  
  
		TruckID = inputItem.TruckID,  
  
		BrokerPartyRef = inputItem.BrokerPartyRef,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		VehicleNumber = inputItem.VehicleNumber,  
  
		DrivingLicenseNumber = inputItem.DrivingLicenseNumber,  
  
		MinimumWeight = inputItem.MinimumWeight,  
  
		MaximumWeight = inputItem.MaximumWeight,  
  
		MinimumVolumeCapacity = inputItem.MinimumVolumeCapacity,  
  
		MaximumVolumeCapacity = inputItem.MaximumVolumeCapacity,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		BrokerPartyCode = inputItem.BrokerPartyCode,  
  
		IsActive = inputItem.IsActive, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Truck Map(Truck entity ,EditTruckCommand inputItem)
        {
              
  
		entity.TruckID = inputItem.TruckID;  
  
		entity.BrokerPartyRef = inputItem.BrokerPartyRef;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.VehicleNumber = inputItem.VehicleNumber;  
  
		entity.DrivingLicenseNumber = inputItem.DrivingLicenseNumber;  
  
		entity.MinimumWeight = inputItem.MinimumWeight;  
  
		entity.MaximumWeight = inputItem.MaximumWeight;  
  
		entity.MinimumVolumeCapacity = inputItem.MinimumVolumeCapacity;  
  
		entity.MaximumVolumeCapacity = inputItem.MaximumVolumeCapacity;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.BrokerPartyCode = inputItem.BrokerPartyCode;  
  
		entity.IsActive = inputItem.IsActive; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TruckDto Map(Truck inputItem)
        {
            var dto = new TruckDto()
            {
                  
  
		TruckID = inputItem.TruckID,  
  
		BrokerPartyRef = inputItem.BrokerPartyRef,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		VehicleNumber = inputItem.VehicleNumber,  
  
		DrivingLicenseNumber = inputItem.DrivingLicenseNumber,  
  
		MinimumWeight = inputItem.MinimumWeight,  
  
		MaximumWeight = inputItem.MaximumWeight,  
  
		MinimumVolumeCapacity = inputItem.MinimumVolumeCapacity,  
  
		MaximumVolumeCapacity = inputItem.MaximumVolumeCapacity,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		BrokerPartyCode = inputItem.BrokerPartyCode,  
  
		IsActive = inputItem.IsActive, 
            };
            return dto;
        }

        public static List<TruckDto> Map(ICollection<Truck> entities)
        {
            var dtos = new List<TruckDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TruckDto()
                {
                      
  
		TruckID = inputItem.TruckID,  
  
		BrokerPartyRef = inputItem.BrokerPartyRef,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		VehicleNumber = inputItem.VehicleNumber,  
  
		DrivingLicenseNumber = inputItem.DrivingLicenseNumber,  
  
		MinimumWeight = inputItem.MinimumWeight,  
  
		MaximumWeight = inputItem.MaximumWeight,  
  
		MinimumVolumeCapacity = inputItem.MinimumVolumeCapacity,  
  
		MaximumVolumeCapacity = inputItem.MaximumVolumeCapacity,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		BrokerPartyCode = inputItem.BrokerPartyCode,  
  
		IsActive = inputItem.IsActive, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Vat Map(AddVatCommand inputItem)
        {
            var entity = new Vat() {
                  
  
		VatID = inputItem.VatID,  
  
		Number = inputItem.Number,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		NonDiminutionTaxAndDuty = inputItem.NonDiminutionTaxAndDuty,  
  
		NonDiminutionDuty = inputItem.NonDiminutionDuty,  
  
		DomesticSaleNonTaxExemptItems = inputItem.DomesticSaleNonTaxExemptItems,  
  
		DomesticSaleNonTaxExemptServices = inputItem.DomesticSaleNonTaxExemptServices,  
  
		DomesticSaleTaxExemptItems = inputItem.DomesticSaleTaxExemptItems,  
  
		DomesticSaleTaxExemptServices = inputItem.DomesticSaleTaxExemptServices,  
  
		ExportSaleItems = inputItem.ExportSaleItems,  
  
		ExportSaleServices = inputItem.ExportSaleServices,  
  
		ReceiptTaxDomesticSaleNonTaxExemptItems = inputItem.ReceiptTaxDomesticSaleNonTaxExemptItems,  
  
		ReceiptTaxDomesticSaleNonTaxExemptServices = inputItem.ReceiptTaxDomesticSaleNonTaxExemptServices,  
  
		ReceiptTaxDomesticSaleTaxExemptItems = inputItem.ReceiptTaxDomesticSaleTaxExemptItems,  
  
		ReceiptTaxDomesticSaleTaxExemptServices = inputItem.ReceiptTaxDomesticSaleTaxExemptServices,  
  
		ReceiptTaxExportSaleItems = inputItem.ReceiptTaxExportSaleItems,  
  
		ReceiptTaxExportSaleServices = inputItem.ReceiptTaxExportSaleServices,  
  
		DomesticPurchaseNonTaxExemptItems = inputItem.DomesticPurchaseNonTaxExemptItems,  
  
		DomesticPurchaseNonTaxExemptServices = inputItem.DomesticPurchaseNonTaxExemptServices,  
  
		DomesticPurchaseTaxExemptItems = inputItem.DomesticPurchaseTaxExemptItems,  
  
		DomesticPurchaseTaxExemptServices = inputItem.DomesticPurchaseTaxExemptServices,  
  
		ImportPurchaseNonTaxExemptItems = inputItem.ImportPurchaseNonTaxExemptItems,  
  
		ImportPurchaseNonTaxExemptServices = inputItem.ImportPurchaseNonTaxExemptServices,  
  
		ImportPurchaseTaxExemptItems = inputItem.ImportPurchaseTaxExemptItems,  
  
		ImportPurchaseTaxExemptServices = inputItem.ImportPurchaseTaxExemptServices,  
  
		PayedTaxDomesticPurchaseNonTaxExemptItems = inputItem.PayedTaxDomesticPurchaseNonTaxExemptItems,  
  
		PayedTaxDomesticPurchaseNonTaxExemptServices = inputItem.PayedTaxDomesticPurchaseNonTaxExemptServices,  
  
		PayedTaxDomesticPurchaseTaxExemptItems = inputItem.PayedTaxDomesticPurchaseTaxExemptItems,  
  
		PayedTaxDomesticPurchaseTaxExemptServices = inputItem.PayedTaxDomesticPurchaseTaxExemptServices,  
  
		PayedTaxImportPurchaseNonTaxExemptItems = inputItem.PayedTaxImportPurchaseNonTaxExemptItems,  
  
		PayedTaxImportPurchaseNonTaxExemptServices = inputItem.PayedTaxImportPurchaseNonTaxExemptServices,  
  
		PayedTaxImportPurchaseTaxExemptItems = inputItem.PayedTaxImportPurchaseTaxExemptItems,  
  
		PayedTaxImportPurchaseTaxExemptServices = inputItem.PayedTaxImportPurchaseTaxExemptServices, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Vat Map(Vat entity ,EditVatCommand inputItem)
        {
              
  
		entity.VatID = inputItem.VatID;  
  
		entity.Number = inputItem.Number;  
  
		entity.FromDate = inputItem.FromDate;  
  
		entity.ToDate = inputItem.ToDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.NonDiminutionTaxAndDuty = inputItem.NonDiminutionTaxAndDuty;  
  
		entity.NonDiminutionDuty = inputItem.NonDiminutionDuty;  
  
		entity.DomesticSaleNonTaxExemptItems = inputItem.DomesticSaleNonTaxExemptItems;  
  
		entity.DomesticSaleNonTaxExemptServices = inputItem.DomesticSaleNonTaxExemptServices;  
  
		entity.DomesticSaleTaxExemptItems = inputItem.DomesticSaleTaxExemptItems;  
  
		entity.DomesticSaleTaxExemptServices = inputItem.DomesticSaleTaxExemptServices;  
  
		entity.ExportSaleItems = inputItem.ExportSaleItems;  
  
		entity.ExportSaleServices = inputItem.ExportSaleServices;  
  
		entity.ReceiptTaxDomesticSaleNonTaxExemptItems = inputItem.ReceiptTaxDomesticSaleNonTaxExemptItems;  
  
		entity.ReceiptTaxDomesticSaleNonTaxExemptServices = inputItem.ReceiptTaxDomesticSaleNonTaxExemptServices;  
  
		entity.ReceiptTaxDomesticSaleTaxExemptItems = inputItem.ReceiptTaxDomesticSaleTaxExemptItems;  
  
		entity.ReceiptTaxDomesticSaleTaxExemptServices = inputItem.ReceiptTaxDomesticSaleTaxExemptServices;  
  
		entity.ReceiptTaxExportSaleItems = inputItem.ReceiptTaxExportSaleItems;  
  
		entity.ReceiptTaxExportSaleServices = inputItem.ReceiptTaxExportSaleServices;  
  
		entity.DomesticPurchaseNonTaxExemptItems = inputItem.DomesticPurchaseNonTaxExemptItems;  
  
		entity.DomesticPurchaseNonTaxExemptServices = inputItem.DomesticPurchaseNonTaxExemptServices;  
  
		entity.DomesticPurchaseTaxExemptItems = inputItem.DomesticPurchaseTaxExemptItems;  
  
		entity.DomesticPurchaseTaxExemptServices = inputItem.DomesticPurchaseTaxExemptServices;  
  
		entity.ImportPurchaseNonTaxExemptItems = inputItem.ImportPurchaseNonTaxExemptItems;  
  
		entity.ImportPurchaseNonTaxExemptServices = inputItem.ImportPurchaseNonTaxExemptServices;  
  
		entity.ImportPurchaseTaxExemptItems = inputItem.ImportPurchaseTaxExemptItems;  
  
		entity.ImportPurchaseTaxExemptServices = inputItem.ImportPurchaseTaxExemptServices;  
  
		entity.PayedTaxDomesticPurchaseNonTaxExemptItems = inputItem.PayedTaxDomesticPurchaseNonTaxExemptItems;  
  
		entity.PayedTaxDomesticPurchaseNonTaxExemptServices = inputItem.PayedTaxDomesticPurchaseNonTaxExemptServices;  
  
		entity.PayedTaxDomesticPurchaseTaxExemptItems = inputItem.PayedTaxDomesticPurchaseTaxExemptItems;  
  
		entity.PayedTaxDomesticPurchaseTaxExemptServices = inputItem.PayedTaxDomesticPurchaseTaxExemptServices;  
  
		entity.PayedTaxImportPurchaseNonTaxExemptItems = inputItem.PayedTaxImportPurchaseNonTaxExemptItems;  
  
		entity.PayedTaxImportPurchaseNonTaxExemptServices = inputItem.PayedTaxImportPurchaseNonTaxExemptServices;  
  
		entity.PayedTaxImportPurchaseTaxExemptItems = inputItem.PayedTaxImportPurchaseTaxExemptItems;  
  
		entity.PayedTaxImportPurchaseTaxExemptServices = inputItem.PayedTaxImportPurchaseTaxExemptServices; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static VatDto Map(Vat inputItem)
        {
            var dto = new VatDto()
            {
                  
  
		VatID = inputItem.VatID,  
  
		Number = inputItem.Number,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		NonDiminutionTaxAndDuty = inputItem.NonDiminutionTaxAndDuty,  
  
		NonDiminutionDuty = inputItem.NonDiminutionDuty,  
  
		DomesticSaleNonTaxExemptItems = inputItem.DomesticSaleNonTaxExemptItems,  
  
		DomesticSaleNonTaxExemptServices = inputItem.DomesticSaleNonTaxExemptServices,  
  
		DomesticSaleTaxExemptItems = inputItem.DomesticSaleTaxExemptItems,  
  
		DomesticSaleTaxExemptServices = inputItem.DomesticSaleTaxExemptServices,  
  
		ExportSaleItems = inputItem.ExportSaleItems,  
  
		ExportSaleServices = inputItem.ExportSaleServices,  
  
		ReceiptTaxDomesticSaleNonTaxExemptItems = inputItem.ReceiptTaxDomesticSaleNonTaxExemptItems,  
  
		ReceiptTaxDomesticSaleNonTaxExemptServices = inputItem.ReceiptTaxDomesticSaleNonTaxExemptServices,  
  
		ReceiptTaxDomesticSaleTaxExemptItems = inputItem.ReceiptTaxDomesticSaleTaxExemptItems,  
  
		ReceiptTaxDomesticSaleTaxExemptServices = inputItem.ReceiptTaxDomesticSaleTaxExemptServices,  
  
		ReceiptTaxExportSaleItems = inputItem.ReceiptTaxExportSaleItems,  
  
		ReceiptTaxExportSaleServices = inputItem.ReceiptTaxExportSaleServices,  
  
		DomesticPurchaseNonTaxExemptItems = inputItem.DomesticPurchaseNonTaxExemptItems,  
  
		DomesticPurchaseNonTaxExemptServices = inputItem.DomesticPurchaseNonTaxExemptServices,  
  
		DomesticPurchaseTaxExemptItems = inputItem.DomesticPurchaseTaxExemptItems,  
  
		DomesticPurchaseTaxExemptServices = inputItem.DomesticPurchaseTaxExemptServices,  
  
		ImportPurchaseNonTaxExemptItems = inputItem.ImportPurchaseNonTaxExemptItems,  
  
		ImportPurchaseNonTaxExemptServices = inputItem.ImportPurchaseNonTaxExemptServices,  
  
		ImportPurchaseTaxExemptItems = inputItem.ImportPurchaseTaxExemptItems,  
  
		ImportPurchaseTaxExemptServices = inputItem.ImportPurchaseTaxExemptServices,  
  
		PayedTaxDomesticPurchaseNonTaxExemptItems = inputItem.PayedTaxDomesticPurchaseNonTaxExemptItems,  
  
		PayedTaxDomesticPurchaseNonTaxExemptServices = inputItem.PayedTaxDomesticPurchaseNonTaxExemptServices,  
  
		PayedTaxDomesticPurchaseTaxExemptItems = inputItem.PayedTaxDomesticPurchaseTaxExemptItems,  
  
		PayedTaxDomesticPurchaseTaxExemptServices = inputItem.PayedTaxDomesticPurchaseTaxExemptServices,  
  
		PayedTaxImportPurchaseNonTaxExemptItems = inputItem.PayedTaxImportPurchaseNonTaxExemptItems,  
  
		PayedTaxImportPurchaseNonTaxExemptServices = inputItem.PayedTaxImportPurchaseNonTaxExemptServices,  
  
		PayedTaxImportPurchaseTaxExemptItems = inputItem.PayedTaxImportPurchaseTaxExemptItems,  
  
		PayedTaxImportPurchaseTaxExemptServices = inputItem.PayedTaxImportPurchaseTaxExemptServices, 
            };
            return dto;
        }

        public static List<VatDto> Map(ICollection<Vat> entities)
        {
            var dtos = new List<VatDto>();
            foreach (var inputItem in entities)
            {
                var dto = new VatDto()
                {
                      
  
		VatID = inputItem.VatID,  
  
		Number = inputItem.Number,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		NonDiminutionTaxAndDuty = inputItem.NonDiminutionTaxAndDuty,  
  
		NonDiminutionDuty = inputItem.NonDiminutionDuty,  
  
		DomesticSaleNonTaxExemptItems = inputItem.DomesticSaleNonTaxExemptItems,  
  
		DomesticSaleNonTaxExemptServices = inputItem.DomesticSaleNonTaxExemptServices,  
  
		DomesticSaleTaxExemptItems = inputItem.DomesticSaleTaxExemptItems,  
  
		DomesticSaleTaxExemptServices = inputItem.DomesticSaleTaxExemptServices,  
  
		ExportSaleItems = inputItem.ExportSaleItems,  
  
		ExportSaleServices = inputItem.ExportSaleServices,  
  
		ReceiptTaxDomesticSaleNonTaxExemptItems = inputItem.ReceiptTaxDomesticSaleNonTaxExemptItems,  
  
		ReceiptTaxDomesticSaleNonTaxExemptServices = inputItem.ReceiptTaxDomesticSaleNonTaxExemptServices,  
  
		ReceiptTaxDomesticSaleTaxExemptItems = inputItem.ReceiptTaxDomesticSaleTaxExemptItems,  
  
		ReceiptTaxDomesticSaleTaxExemptServices = inputItem.ReceiptTaxDomesticSaleTaxExemptServices,  
  
		ReceiptTaxExportSaleItems = inputItem.ReceiptTaxExportSaleItems,  
  
		ReceiptTaxExportSaleServices = inputItem.ReceiptTaxExportSaleServices,  
  
		DomesticPurchaseNonTaxExemptItems = inputItem.DomesticPurchaseNonTaxExemptItems,  
  
		DomesticPurchaseNonTaxExemptServices = inputItem.DomesticPurchaseNonTaxExemptServices,  
  
		DomesticPurchaseTaxExemptItems = inputItem.DomesticPurchaseTaxExemptItems,  
  
		DomesticPurchaseTaxExemptServices = inputItem.DomesticPurchaseTaxExemptServices,  
  
		ImportPurchaseNonTaxExemptItems = inputItem.ImportPurchaseNonTaxExemptItems,  
  
		ImportPurchaseNonTaxExemptServices = inputItem.ImportPurchaseNonTaxExemptServices,  
  
		ImportPurchaseTaxExemptItems = inputItem.ImportPurchaseTaxExemptItems,  
  
		ImportPurchaseTaxExemptServices = inputItem.ImportPurchaseTaxExemptServices,  
  
		PayedTaxDomesticPurchaseNonTaxExemptItems = inputItem.PayedTaxDomesticPurchaseNonTaxExemptItems,  
  
		PayedTaxDomesticPurchaseNonTaxExemptServices = inputItem.PayedTaxDomesticPurchaseNonTaxExemptServices,  
  
		PayedTaxDomesticPurchaseTaxExemptItems = inputItem.PayedTaxDomesticPurchaseTaxExemptItems,  
  
		PayedTaxDomesticPurchaseTaxExemptServices = inputItem.PayedTaxDomesticPurchaseTaxExemptServices,  
  
		PayedTaxImportPurchaseNonTaxExemptItems = inputItem.PayedTaxImportPurchaseNonTaxExemptItems,  
  
		PayedTaxImportPurchaseNonTaxExemptServices = inputItem.PayedTaxImportPurchaseNonTaxExemptServices,  
  
		PayedTaxImportPurchaseTaxExemptItems = inputItem.PayedTaxImportPurchaseTaxExemptItems,  
  
		PayedTaxImportPurchaseTaxExemptServices = inputItem.PayedTaxImportPurchaseTaxExemptServices, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static VatItem Map(AddVatItemCommand inputItem)
        {
            var entity = new VatItem() {
                  
  
		VatItemID = inputItem.VatItemID,  
  
		VatRef = inputItem.VatRef,  
  
		RowID = inputItem.RowID,  
  
		VatItemType = inputItem.VatItemType,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		InventoryReceiptReturnRef = inputItem.InventoryReceiptReturnRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		AssetPurchaseInvoiceRef = inputItem.AssetPurchaseInvoiceRef,  
  
		AssetSaleRef = inputItem.AssetSaleRef,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TaxExemptItemPriceInBaseCurrency = inputItem.TaxExemptItemPriceInBaseCurrency,  
  
		TaxExemptServicePriceInBaseCurrency = inputItem.TaxExemptServicePriceInBaseCurrency,  
  
		NonTaxExemptItemPriceInBaseCurrency = inputItem.NonTaxExemptItemPriceInBaseCurrency,  
  
		NonTaxExemptServicePriceInBaseCurrency = inputItem.NonTaxExemptServicePriceInBaseCurrency,  
  
		NonTaxExemptItemTaxInBaseCurrency = inputItem.NonTaxExemptItemTaxInBaseCurrency,  
  
		TaxExemptItemTaxInBaseCurrency = inputItem.TaxExemptItemTaxInBaseCurrency,  
  
		NonTaxExemptItemDutyInBaseCurrency = inputItem.NonTaxExemptItemDutyInBaseCurrency,  
  
		TaxExemptItemDutyInBaseCurrency = inputItem.TaxExemptItemDutyInBaseCurrency,  
  
		NonTaxExemptServiceTaxInBaseCurrency = inputItem.NonTaxExemptServiceTaxInBaseCurrency,  
  
		TaxExemptServiceTaxInBaseCurrency = inputItem.TaxExemptServiceTaxInBaseCurrency,  
  
		NonTaxExemptServiceDutyInBaseCurrency = inputItem.NonTaxExemptServiceDutyInBaseCurrency,  
  
		TaxExemptServiceDutyInBaseCurrency = inputItem.TaxExemptServiceDutyInBaseCurrency,  
  
		DomesticType = inputItem.DomesticType,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		StatusRef = inputItem.StatusRef,  
  
		CustomsClearanceRef = inputItem.CustomsClearanceRef,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static VatItem Map(VatItem entity ,EditVatItemCommand inputItem)
        {
              
  
		entity.VatItemID = inputItem.VatItemID;  
  
		entity.VatRef = inputItem.VatRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.VatItemType = inputItem.VatItemType;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.InventoryReceiptRef = inputItem.InventoryReceiptRef;  
  
		entity.InventoryReceiptReturnRef = inputItem.InventoryReceiptReturnRef;  
  
		entity.ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef;  
  
		entity.AssetPurchaseInvoiceRef = inputItem.AssetPurchaseInvoiceRef;  
  
		entity.AssetSaleRef = inputItem.AssetSaleRef;  
  
		entity.TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency;  
  
		entity.TaxExemptItemPriceInBaseCurrency = inputItem.TaxExemptItemPriceInBaseCurrency;  
  
		entity.TaxExemptServicePriceInBaseCurrency = inputItem.TaxExemptServicePriceInBaseCurrency;  
  
		entity.NonTaxExemptItemPriceInBaseCurrency = inputItem.NonTaxExemptItemPriceInBaseCurrency;  
  
		entity.NonTaxExemptServicePriceInBaseCurrency = inputItem.NonTaxExemptServicePriceInBaseCurrency;  
  
		entity.NonTaxExemptItemTaxInBaseCurrency = inputItem.NonTaxExemptItemTaxInBaseCurrency;  
  
		entity.TaxExemptItemTaxInBaseCurrency = inputItem.TaxExemptItemTaxInBaseCurrency;  
  
		entity.NonTaxExemptItemDutyInBaseCurrency = inputItem.NonTaxExemptItemDutyInBaseCurrency;  
  
		entity.TaxExemptItemDutyInBaseCurrency = inputItem.TaxExemptItemDutyInBaseCurrency;  
  
		entity.NonTaxExemptServiceTaxInBaseCurrency = inputItem.NonTaxExemptServiceTaxInBaseCurrency;  
  
		entity.TaxExemptServiceTaxInBaseCurrency = inputItem.TaxExemptServiceTaxInBaseCurrency;  
  
		entity.NonTaxExemptServiceDutyInBaseCurrency = inputItem.NonTaxExemptServiceDutyInBaseCurrency;  
  
		entity.TaxExemptServiceDutyInBaseCurrency = inputItem.TaxExemptServiceDutyInBaseCurrency;  
  
		entity.DomesticType = inputItem.DomesticType;  
  
		entity.EntityFullName = inputItem.EntityFullName;  
  
		entity.StatusRef = inputItem.StatusRef;  
  
		entity.CustomsClearanceRef = inputItem.CustomsClearanceRef;  
  
		entity.BillOfLoadingRef = inputItem.BillOfLoadingRef;  
  
		entity.InsurancePolicyRef = inputItem.InsurancePolicyRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static VatItemDto Map(VatItem inputItem)
        {
            var dto = new VatItemDto()
            {
                  
  
		VatItemID = inputItem.VatItemID,  
  
		VatRef = inputItem.VatRef,  
  
		RowID = inputItem.RowID,  
  
		VatItemType = inputItem.VatItemType,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		InventoryReceiptReturnRef = inputItem.InventoryReceiptReturnRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		AssetPurchaseInvoiceRef = inputItem.AssetPurchaseInvoiceRef,  
  
		AssetSaleRef = inputItem.AssetSaleRef,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TaxExemptItemPriceInBaseCurrency = inputItem.TaxExemptItemPriceInBaseCurrency,  
  
		TaxExemptServicePriceInBaseCurrency = inputItem.TaxExemptServicePriceInBaseCurrency,  
  
		NonTaxExemptItemPriceInBaseCurrency = inputItem.NonTaxExemptItemPriceInBaseCurrency,  
  
		NonTaxExemptServicePriceInBaseCurrency = inputItem.NonTaxExemptServicePriceInBaseCurrency,  
  
		NonTaxExemptItemTaxInBaseCurrency = inputItem.NonTaxExemptItemTaxInBaseCurrency,  
  
		TaxExemptItemTaxInBaseCurrency = inputItem.TaxExemptItemTaxInBaseCurrency,  
  
		NonTaxExemptItemDutyInBaseCurrency = inputItem.NonTaxExemptItemDutyInBaseCurrency,  
  
		TaxExemptItemDutyInBaseCurrency = inputItem.TaxExemptItemDutyInBaseCurrency,  
  
		NonTaxExemptServiceTaxInBaseCurrency = inputItem.NonTaxExemptServiceTaxInBaseCurrency,  
  
		TaxExemptServiceTaxInBaseCurrency = inputItem.TaxExemptServiceTaxInBaseCurrency,  
  
		NonTaxExemptServiceDutyInBaseCurrency = inputItem.NonTaxExemptServiceDutyInBaseCurrency,  
  
		TaxExemptServiceDutyInBaseCurrency = inputItem.TaxExemptServiceDutyInBaseCurrency,  
  
		DomesticType = inputItem.DomesticType,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		StatusRef = inputItem.StatusRef,  
  
		CustomsClearanceRef = inputItem.CustomsClearanceRef,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef, 
            };
            return dto;
        }

        public static List<VatItemDto> Map(ICollection<VatItem> entities)
        {
            var dtos = new List<VatItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new VatItemDto()
                {
                      
  
		VatItemID = inputItem.VatItemID,  
  
		VatRef = inputItem.VatRef,  
  
		RowID = inputItem.RowID,  
  
		VatItemType = inputItem.VatItemType,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		InventoryReceiptReturnRef = inputItem.InventoryReceiptReturnRef,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		AssetPurchaseInvoiceRef = inputItem.AssetPurchaseInvoiceRef,  
  
		AssetSaleRef = inputItem.AssetSaleRef,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TaxExemptItemPriceInBaseCurrency = inputItem.TaxExemptItemPriceInBaseCurrency,  
  
		TaxExemptServicePriceInBaseCurrency = inputItem.TaxExemptServicePriceInBaseCurrency,  
  
		NonTaxExemptItemPriceInBaseCurrency = inputItem.NonTaxExemptItemPriceInBaseCurrency,  
  
		NonTaxExemptServicePriceInBaseCurrency = inputItem.NonTaxExemptServicePriceInBaseCurrency,  
  
		NonTaxExemptItemTaxInBaseCurrency = inputItem.NonTaxExemptItemTaxInBaseCurrency,  
  
		TaxExemptItemTaxInBaseCurrency = inputItem.TaxExemptItemTaxInBaseCurrency,  
  
		NonTaxExemptItemDutyInBaseCurrency = inputItem.NonTaxExemptItemDutyInBaseCurrency,  
  
		TaxExemptItemDutyInBaseCurrency = inputItem.TaxExemptItemDutyInBaseCurrency,  
  
		NonTaxExemptServiceTaxInBaseCurrency = inputItem.NonTaxExemptServiceTaxInBaseCurrency,  
  
		TaxExemptServiceTaxInBaseCurrency = inputItem.TaxExemptServiceTaxInBaseCurrency,  
  
		NonTaxExemptServiceDutyInBaseCurrency = inputItem.NonTaxExemptServiceDutyInBaseCurrency,  
  
		TaxExemptServiceDutyInBaseCurrency = inputItem.TaxExemptServiceDutyInBaseCurrency,  
  
		DomesticType = inputItem.DomesticType,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		StatusRef = inputItem.StatusRef,  
  
		CustomsClearanceRef = inputItem.CustomsClearanceRef,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
