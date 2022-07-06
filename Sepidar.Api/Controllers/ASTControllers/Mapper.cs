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
                
        
        public static AcquisitionReceipt Map(AddAcquisitionReceiptCommand inputItem)
        {
            var entity = new AcquisitionReceipt() {
                  
  
		AcquisitionReceiptID = inputItem.AcquisitionReceiptID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Type = inputItem.Type,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AccountingDLRef = inputItem.AccountingDLRef,  
  
		AccountingSLRef = inputItem.AccountingSLRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AcquisitionReceipt Map(AcquisitionReceipt entity ,EditAcquisitionReceiptCommand inputItem)
        {
              
  
		entity.AcquisitionReceiptID = inputItem.AcquisitionReceiptID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.Type = inputItem.Type;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.AccountingDLRef = inputItem.AccountingDLRef;  
  
		entity.AccountingSLRef = inputItem.AccountingSLRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AcquisitionReceiptDto Map(AcquisitionReceipt inputItem)
        {
            var dto = new AcquisitionReceiptDto()
            {
                  
  
		AcquisitionReceiptID = inputItem.AcquisitionReceiptID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Type = inputItem.Type,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AccountingDLRef = inputItem.AccountingDLRef,  
  
		AccountingSLRef = inputItem.AccountingSLRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<AcquisitionReceiptDto> Map(ICollection<AcquisitionReceipt> entities)
        {
            var dtos = new List<AcquisitionReceiptDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AcquisitionReceiptDto()
                {
                      
  
		AcquisitionReceiptID = inputItem.AcquisitionReceiptID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Type = inputItem.Type,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AccountingDLRef = inputItem.AccountingDLRef,  
  
		AccountingSLRef = inputItem.AccountingSLRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
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
        
        public static AcquisitionReceiptItem Map(AddAcquisitionReceiptItemCommand inputItem)
        {
            var entity = new AcquisitionReceiptItem() {
                  
  
		AcquisitionReceiptItemID = inputItem.AcquisitionReceiptItemID,  
  
		AcquisitionReceiptRef = inputItem.AcquisitionReceiptRef,  
  
		PlaqueNumber = inputItem.PlaqueNumber,  
  
		OldPlaqueNumber = inputItem.OldPlaqueNumber,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		AssetGroupRef = inputItem.AssetGroupRef,  
  
		AssetRef = inputItem.AssetRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef,  
  
		Description = inputItem.Description,  
  
		Details = inputItem.Details,  
  
		UtilizationDate = inputItem.UtilizationDate,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		TotalCost = inputItem.TotalCost,  
  
		TotalCostInBasecurrency = inputItem.TotalCostInBasecurrency,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AcquisitionReceiptItem Map(AcquisitionReceiptItem entity ,EditAcquisitionReceiptItemCommand inputItem)
        {
              
  
		entity.AcquisitionReceiptItemID = inputItem.AcquisitionReceiptItemID;  
  
		entity.AcquisitionReceiptRef = inputItem.AcquisitionReceiptRef;  
  
		entity.PlaqueNumber = inputItem.PlaqueNumber;  
  
		entity.OldPlaqueNumber = inputItem.OldPlaqueNumber;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.AssetGroupRef = inputItem.AssetGroupRef;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.CostCenterDlRef = inputItem.CostCenterDlRef;  
  
		entity.EmplacementRef = inputItem.EmplacementRef;  
  
		entity.ReceiverPartyRef = inputItem.ReceiverPartyRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Details = inputItem.Details;  
  
		entity.UtilizationDate = inputItem.UtilizationDate;  
  
		entity.AccumulatedDepreciation = inputItem.AccumulatedDepreciation;  
  
		entity.TotalCost = inputItem.TotalCost;  
  
		entity.TotalCostInBasecurrency = inputItem.TotalCostInBasecurrency;  
  
		entity.DepreciationRate = inputItem.DepreciationRate;  
  
		entity.DepreciationMethodType = inputItem.DepreciationMethodType;  
  
		entity.UsefulLife = inputItem.UsefulLife;  
  
		entity.MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue;  
  
		entity.SalvageValue = inputItem.SalvageValue;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AcquisitionReceiptItemDto Map(AcquisitionReceiptItem inputItem)
        {
            var dto = new AcquisitionReceiptItemDto()
            {
                  
  
		AcquisitionReceiptItemID = inputItem.AcquisitionReceiptItemID,  
  
		AcquisitionReceiptRef = inputItem.AcquisitionReceiptRef,  
  
		PlaqueNumber = inputItem.PlaqueNumber,  
  
		OldPlaqueNumber = inputItem.OldPlaqueNumber,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		AssetGroupRef = inputItem.AssetGroupRef,  
  
		AssetRef = inputItem.AssetRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef,  
  
		Description = inputItem.Description,  
  
		Details = inputItem.Details,  
  
		UtilizationDate = inputItem.UtilizationDate,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		TotalCost = inputItem.TotalCost,  
  
		TotalCostInBasecurrency = inputItem.TotalCostInBasecurrency,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
            };
            return dto;
        }

        public static List<AcquisitionReceiptItemDto> Map(ICollection<AcquisitionReceiptItem> entities)
        {
            var dtos = new List<AcquisitionReceiptItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AcquisitionReceiptItemDto()
                {
                      
  
		AcquisitionReceiptItemID = inputItem.AcquisitionReceiptItemID,  
  
		AcquisitionReceiptRef = inputItem.AcquisitionReceiptRef,  
  
		PlaqueNumber = inputItem.PlaqueNumber,  
  
		OldPlaqueNumber = inputItem.OldPlaqueNumber,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		AssetGroupRef = inputItem.AssetGroupRef,  
  
		AssetRef = inputItem.AssetRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef,  
  
		Description = inputItem.Description,  
  
		Details = inputItem.Details,  
  
		UtilizationDate = inputItem.UtilizationDate,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		TotalCost = inputItem.TotalCost,  
  
		TotalCostInBasecurrency = inputItem.TotalCostInBasecurrency,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Asset Map(AddAssetCommand inputItem)
        {
            var entity = new Asset() {
                  
  
		AssetId = inputItem.AssetId,  
  
		PlaqueNumber = inputItem.PlaqueNumber,  
  
		OldPlaqueNumber = inputItem.OldPlaqueNumber,  
  
		PlaqueSerial = inputItem.PlaqueSerial,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		State = inputItem.State,  
  
		AssetGroupRef = inputItem.AssetGroupRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef,  
  
		Description = inputItem.Description,  
  
		Details = inputItem.Details,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		IsInitial = inputItem.IsInitial, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Asset Map(Asset entity ,EditAssetCommand inputItem)
        {
              
  
		entity.AssetId = inputItem.AssetId;  
  
		entity.PlaqueNumber = inputItem.PlaqueNumber;  
  
		entity.OldPlaqueNumber = inputItem.OldPlaqueNumber;  
  
		entity.PlaqueSerial = inputItem.PlaqueSerial;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.State = inputItem.State;  
  
		entity.AssetGroupRef = inputItem.AssetGroupRef;  
  
		entity.CostCenterDlRef = inputItem.CostCenterDlRef;  
  
		entity.EmplacementRef = inputItem.EmplacementRef;  
  
		entity.ReceiverPartyRef = inputItem.ReceiverPartyRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Details = inputItem.Details;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.IsInitial = inputItem.IsInitial; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AssetDto Map(Asset inputItem)
        {
            var dto = new AssetDto()
            {
                  
  
		AssetId = inputItem.AssetId,  
  
		PlaqueNumber = inputItem.PlaqueNumber,  
  
		OldPlaqueNumber = inputItem.OldPlaqueNumber,  
  
		PlaqueSerial = inputItem.PlaqueSerial,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		State = inputItem.State,  
  
		AssetGroupRef = inputItem.AssetGroupRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef,  
  
		Description = inputItem.Description,  
  
		Details = inputItem.Details,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		IsInitial = inputItem.IsInitial, 
            };
            return dto;
        }

        public static List<AssetDto> Map(ICollection<Asset> entities)
        {
            var dtos = new List<AssetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AssetDto()
                {
                      
  
		AssetId = inputItem.AssetId,  
  
		PlaqueNumber = inputItem.PlaqueNumber,  
  
		OldPlaqueNumber = inputItem.OldPlaqueNumber,  
  
		PlaqueSerial = inputItem.PlaqueSerial,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		State = inputItem.State,  
  
		AssetGroupRef = inputItem.AssetGroupRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef,  
  
		Description = inputItem.Description,  
  
		Details = inputItem.Details,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		IsInitial = inputItem.IsInitial, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AssetClass Map(AddAssetClassCommand inputItem)
        {
            var entity = new AssetClass() {
                  
  
		AssetClassID = inputItem.AssetClassID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		AssetSLRef = inputItem.AssetSLRef,  
  
		DepreciationSLRef = inputItem.DepreciationSLRef,  
  
		AccumulatedDepreciationSLRef = inputItem.AccumulatedDepreciationSLRef,  
  
		AssetClassRef = inputItem.AssetClassRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AssetClass Map(AssetClass entity ,EditAssetClassCommand inputItem)
        {
              
  
		entity.AssetClassID = inputItem.AssetClassID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.AssetSLRef = inputItem.AssetSLRef;  
  
		entity.DepreciationSLRef = inputItem.DepreciationSLRef;  
  
		entity.AccumulatedDepreciationSLRef = inputItem.AccumulatedDepreciationSLRef;  
  
		entity.AssetClassRef = inputItem.AssetClassRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AssetClassDto Map(AssetClass inputItem)
        {
            var dto = new AssetClassDto()
            {
                  
  
		AssetClassID = inputItem.AssetClassID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		AssetSLRef = inputItem.AssetSLRef,  
  
		DepreciationSLRef = inputItem.DepreciationSLRef,  
  
		AccumulatedDepreciationSLRef = inputItem.AccumulatedDepreciationSLRef,  
  
		AssetClassRef = inputItem.AssetClassRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<AssetClassDto> Map(ICollection<AssetClass> entities)
        {
            var dtos = new List<AssetClassDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AssetClassDto()
                {
                      
  
		AssetClassID = inputItem.AssetClassID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		AssetSLRef = inputItem.AssetSLRef,  
  
		DepreciationSLRef = inputItem.DepreciationSLRef,  
  
		AccumulatedDepreciationSLRef = inputItem.AccumulatedDepreciationSLRef,  
  
		AssetClassRef = inputItem.AssetClassRef,  
  
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
        
        public static AssetGroup Map(AddAssetGroupCommand inputItem)
        {
            var entity = new AssetGroup() {
                  
  
		AssetGroupID = inputItem.AssetGroupID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		DepreciationMethod = inputItem.DepreciationMethod,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AssetClassRef = inputItem.AssetClassRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AssetGroup Map(AssetGroup entity ,EditAssetGroupCommand inputItem)
        {
              
  
		entity.AssetGroupID = inputItem.AssetGroupID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.DepreciationRate = inputItem.DepreciationRate;  
  
		entity.UsefulLife = inputItem.UsefulLife;  
  
		entity.DepreciationMethod = inputItem.DepreciationMethod;  
  
		entity.MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue;  
  
		entity.SalvageValue = inputItem.SalvageValue;  
  
		entity.AssetClassRef = inputItem.AssetClassRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AssetGroupDto Map(AssetGroup inputItem)
        {
            var dto = new AssetGroupDto()
            {
                  
  
		AssetGroupID = inputItem.AssetGroupID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		DepreciationMethod = inputItem.DepreciationMethod,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AssetClassRef = inputItem.AssetClassRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<AssetGroupDto> Map(ICollection<AssetGroup> entities)
        {
            var dtos = new List<AssetGroupDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AssetGroupDto()
                {
                      
  
		AssetGroupID = inputItem.AssetGroupID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		DepreciationMethod = inputItem.DepreciationMethod,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AssetClassRef = inputItem.AssetClassRef,  
  
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
        
        public static AssetRelatedPurchaseInvoice Map(AddAssetRelatedPurchaseInvoiceCommand inputItem)
        {
            var entity = new AssetRelatedPurchaseInvoice() {
                  
  
		AssetRelatedPurchaseInvoiceId = inputItem.AssetRelatedPurchaseInvoiceId,  
  
		AssetPurchaseInvoiceItemRef = inputItem.AssetPurchaseInvoiceItemRef,  
  
		AcquisitionReceiptItemRef = inputItem.AcquisitionReceiptItemRef,  
  
		RepairItemRef = inputItem.RepairItemRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AssetRelatedPurchaseInvoice Map(AssetRelatedPurchaseInvoice entity ,EditAssetRelatedPurchaseInvoiceCommand inputItem)
        {
              
  
		entity.AssetRelatedPurchaseInvoiceId = inputItem.AssetRelatedPurchaseInvoiceId;  
  
		entity.AssetPurchaseInvoiceItemRef = inputItem.AssetPurchaseInvoiceItemRef;  
  
		entity.AcquisitionReceiptItemRef = inputItem.AcquisitionReceiptItemRef;  
  
		entity.RepairItemRef = inputItem.RepairItemRef;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AssetRelatedPurchaseInvoiceDto Map(AssetRelatedPurchaseInvoice inputItem)
        {
            var dto = new AssetRelatedPurchaseInvoiceDto()
            {
                  
  
		AssetRelatedPurchaseInvoiceId = inputItem.AssetRelatedPurchaseInvoiceId,  
  
		AssetPurchaseInvoiceItemRef = inputItem.AssetPurchaseInvoiceItemRef,  
  
		AcquisitionReceiptItemRef = inputItem.AcquisitionReceiptItemRef,  
  
		RepairItemRef = inputItem.RepairItemRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef, 
            };
            return dto;
        }

        public static List<AssetRelatedPurchaseInvoiceDto> Map(ICollection<AssetRelatedPurchaseInvoice> entities)
        {
            var dtos = new List<AssetRelatedPurchaseInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AssetRelatedPurchaseInvoiceDto()
                {
                      
  
		AssetRelatedPurchaseInvoiceId = inputItem.AssetRelatedPurchaseInvoiceId,  
  
		AssetPurchaseInvoiceItemRef = inputItem.AssetPurchaseInvoiceItemRef,  
  
		AcquisitionReceiptItemRef = inputItem.AcquisitionReceiptItemRef,  
  
		RepairItemRef = inputItem.RepairItemRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AssetTransaction Map(AddAssetTransactionCommand inputItem)
        {
            var entity = new AssetTransaction() {
                  
  
		AssetTransactionID = inputItem.AssetTransactionID,  
  
		TransactionType = inputItem.TransactionType,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		AssetRef = inputItem.AssetRef,  
  
		AssetState = inputItem.AssetState,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		AssetGroupRef = inputItem.AssetGroupRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		ActivityDate = inputItem.ActivityDate,  
  
		ActivityNumber = inputItem.ActivityNumber,  
  
		ActivityRef = inputItem.ActivityRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AssetTransaction Map(AssetTransaction entity ,EditAssetTransactionCommand inputItem)
        {
              
  
		entity.AssetTransactionID = inputItem.AssetTransactionID;  
  
		entity.TransactionType = inputItem.TransactionType;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.AssetState = inputItem.AssetState;  
  
		entity.CostCenterDlRef = inputItem.CostCenterDlRef;  
  
		entity.AssetGroupRef = inputItem.AssetGroupRef;  
  
		entity.EmplacementRef = inputItem.EmplacementRef;  
  
		entity.ReceiverPartyRef = inputItem.ReceiverPartyRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.ActivityDate = inputItem.ActivityDate;  
  
		entity.ActivityNumber = inputItem.ActivityNumber;  
  
		entity.ActivityRef = inputItem.ActivityRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AssetTransactionDto Map(AssetTransaction inputItem)
        {
            var dto = new AssetTransactionDto()
            {
                  
  
		AssetTransactionID = inputItem.AssetTransactionID,  
  
		TransactionType = inputItem.TransactionType,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		AssetRef = inputItem.AssetRef,  
  
		AssetState = inputItem.AssetState,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		AssetGroupRef = inputItem.AssetGroupRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		ActivityDate = inputItem.ActivityDate,  
  
		ActivityNumber = inputItem.ActivityNumber,  
  
		ActivityRef = inputItem.ActivityRef, 
            };
            return dto;
        }

        public static List<AssetTransactionDto> Map(ICollection<AssetTransaction> entities)
        {
            var dtos = new List<AssetTransactionDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AssetTransactionDto()
                {
                      
  
		AssetTransactionID = inputItem.AssetTransactionID,  
  
		TransactionType = inputItem.TransactionType,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		AssetRef = inputItem.AssetRef,  
  
		AssetState = inputItem.AssetState,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		AssetGroupRef = inputItem.AssetGroupRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		ActivityDate = inputItem.ActivityDate,  
  
		ActivityNumber = inputItem.ActivityNumber,  
  
		ActivityRef = inputItem.ActivityRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ChangeDepreciationMethod Map(AddChangeDepreciationMethodCommand inputItem)
        {
            var entity = new ChangeDepreciationMethod() {
                  
  
		ChangeDepreciationMethodId = inputItem.ChangeDepreciationMethodId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		AssetRef = inputItem.AssetRef,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ChangeDepreciationMethod Map(ChangeDepreciationMethod entity ,EditChangeDepreciationMethodCommand inputItem)
        {
              
  
		entity.ChangeDepreciationMethodId = inputItem.ChangeDepreciationMethodId;  
  
		entity.Date = inputItem.Date;  
  
		entity.Number = inputItem.Number;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ChangeDepreciationMethodDto Map(ChangeDepreciationMethod inputItem)
        {
            var dto = new ChangeDepreciationMethodDto()
            {
                  
  
		ChangeDepreciationMethodId = inputItem.ChangeDepreciationMethodId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		AssetRef = inputItem.AssetRef,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<ChangeDepreciationMethodDto> Map(ICollection<ChangeDepreciationMethod> entities)
        {
            var dtos = new List<ChangeDepreciationMethodDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ChangeDepreciationMethodDto()
                {
                      
  
		ChangeDepreciationMethodId = inputItem.ChangeDepreciationMethodId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		AssetRef = inputItem.AssetRef,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
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
        
        public static ChangeDepreciationMethodItem Map(AddChangeDepreciationMethodItemCommand inputItem)
        {
            var entity = new ChangeDepreciationMethodItem() {
                  
  
		ChangeDepreciationMethodItemId = inputItem.ChangeDepreciationMethodItemId,  
  
		ChangeDepreciationMethodRef = inputItem.ChangeDepreciationMethodRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		CostPartTransactionRef = inputItem.CostPartTransactionRef,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		AssetElapsedLife = inputItem.AssetElapsedLife,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		DepreciableBookValue = inputItem.DepreciableBookValue, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ChangeDepreciationMethodItem Map(ChangeDepreciationMethodItem entity ,EditChangeDepreciationMethodItemCommand inputItem)
        {
              
  
		entity.ChangeDepreciationMethodItemId = inputItem.ChangeDepreciationMethodItemId;  
  
		entity.ChangeDepreciationMethodRef = inputItem.ChangeDepreciationMethodRef;  
  
		entity.CostPartRef = inputItem.CostPartRef;  
  
		entity.CostPartTransactionRef = inputItem.CostPartTransactionRef;  
  
		entity.DepreciationMethodType = inputItem.DepreciationMethodType;  
  
		entity.DepreciationRate = inputItem.DepreciationRate;  
  
		entity.UsefulLife = inputItem.UsefulLife;  
  
		entity.MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue;  
  
		entity.AssetElapsedLife = inputItem.AssetElapsedLife;  
  
		entity.AccumulatedDepreciation = inputItem.AccumulatedDepreciation;  
  
		entity.DepreciableBookValue = inputItem.DepreciableBookValue; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ChangeDepreciationMethodItemDto Map(ChangeDepreciationMethodItem inputItem)
        {
            var dto = new ChangeDepreciationMethodItemDto()
            {
                  
  
		ChangeDepreciationMethodItemId = inputItem.ChangeDepreciationMethodItemId,  
  
		ChangeDepreciationMethodRef = inputItem.ChangeDepreciationMethodRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		CostPartTransactionRef = inputItem.CostPartTransactionRef,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		AssetElapsedLife = inputItem.AssetElapsedLife,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		DepreciableBookValue = inputItem.DepreciableBookValue, 
            };
            return dto;
        }

        public static List<ChangeDepreciationMethodItemDto> Map(ICollection<ChangeDepreciationMethodItem> entities)
        {
            var dtos = new List<ChangeDepreciationMethodItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ChangeDepreciationMethodItemDto()
                {
                      
  
		ChangeDepreciationMethodItemId = inputItem.ChangeDepreciationMethodItemId,  
  
		ChangeDepreciationMethodRef = inputItem.ChangeDepreciationMethodRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		CostPartTransactionRef = inputItem.CostPartTransactionRef,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		AssetElapsedLife = inputItem.AssetElapsedLife,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		DepreciableBookValue = inputItem.DepreciableBookValue, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CostPart Map(AddCostPartCommand inputItem)
        {
            var entity = new CostPart() {
                  
  
		CostPartId = inputItem.CostPartId,  
  
		AssetRef = inputItem.AssetRef,  
  
		CostPartType = inputItem.CostPartType,  
  
		TotalCost = inputItem.TotalCost,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		EstablishmentAccumulatedDepreciation = inputItem.EstablishmentAccumulatedDepreciation,  
  
		EffectiveDate = inputItem.EffectiveDate,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AcquisingElapsedLife = inputItem.AcquisingElapsedLife,  
  
		DepreciationState = inputItem.DepreciationState,  
  
		IsInitial = inputItem.IsInitial, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CostPart Map(CostPart entity ,EditCostPartCommand inputItem)
        {
              
  
		entity.CostPartId = inputItem.CostPartId;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.CostPartType = inputItem.CostPartType;  
  
		entity.TotalCost = inputItem.TotalCost;  
  
		entity.AccumulatedDepreciation = inputItem.AccumulatedDepreciation;  
  
		entity.EstablishmentAccumulatedDepreciation = inputItem.EstablishmentAccumulatedDepreciation;  
  
		entity.EffectiveDate = inputItem.EffectiveDate;  
  
		entity.DepreciationRate = inputItem.DepreciationRate;  
  
		entity.DepreciationMethodType = inputItem.DepreciationMethodType;  
  
		entity.UsefulLife = inputItem.UsefulLife;  
  
		entity.MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue;  
  
		entity.SalvageValue = inputItem.SalvageValue;  
  
		entity.AcquisingElapsedLife = inputItem.AcquisingElapsedLife;  
  
		entity.DepreciationState = inputItem.DepreciationState;  
  
		entity.IsInitial = inputItem.IsInitial; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CostPartDto Map(CostPart inputItem)
        {
            var dto = new CostPartDto()
            {
                  
  
		CostPartId = inputItem.CostPartId,  
  
		AssetRef = inputItem.AssetRef,  
  
		CostPartType = inputItem.CostPartType,  
  
		TotalCost = inputItem.TotalCost,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		EstablishmentAccumulatedDepreciation = inputItem.EstablishmentAccumulatedDepreciation,  
  
		EffectiveDate = inputItem.EffectiveDate,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AcquisingElapsedLife = inputItem.AcquisingElapsedLife,  
  
		DepreciationState = inputItem.DepreciationState,  
  
		IsInitial = inputItem.IsInitial, 
            };
            return dto;
        }

        public static List<CostPartDto> Map(ICollection<CostPart> entities)
        {
            var dtos = new List<CostPartDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CostPartDto()
                {
                      
  
		CostPartId = inputItem.CostPartId,  
  
		AssetRef = inputItem.AssetRef,  
  
		CostPartType = inputItem.CostPartType,  
  
		TotalCost = inputItem.TotalCost,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		EstablishmentAccumulatedDepreciation = inputItem.EstablishmentAccumulatedDepreciation,  
  
		EffectiveDate = inputItem.EffectiveDate,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AcquisingElapsedLife = inputItem.AcquisingElapsedLife,  
  
		DepreciationState = inputItem.DepreciationState,  
  
		IsInitial = inputItem.IsInitial, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CostPartTransaction Map(AddCostPartTransactionCommand inputItem)
        {
            var entity = new CostPartTransaction() {
                  
  
		CostPartTransactionID = inputItem.CostPartTransactionID,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		TotalCost = inputItem.TotalCost,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		EffectiveDate = inputItem.EffectiveDate,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		DepreciationValue = inputItem.DepreciationValue,  
  
		CreationDate = inputItem.CreationDate,  
  
		Duration = inputItem.Duration,  
  
		CalculationDate = inputItem.CalculationDate,  
  
		DepreciationState = inputItem.DepreciationState,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AcquisingElapsedLife = inputItem.AcquisingElapsedLife,  
  
		AssetElapsedLife = inputItem.AssetElapsedLife,  
  
		RemainingRoundingDepreciation = inputItem.RemainingRoundingDepreciation, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CostPartTransaction Map(CostPartTransaction entity ,EditCostPartTransactionCommand inputItem)
        {
              
  
		entity.CostPartTransactionID = inputItem.CostPartTransactionID;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef;  
  
		entity.CostPartRef = inputItem.CostPartRef;  
  
		entity.TotalCost = inputItem.TotalCost;  
  
		entity.DepreciationMethodType = inputItem.DepreciationMethodType;  
  
		entity.UsefulLife = inputItem.UsefulLife;  
  
		entity.MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue;  
  
		entity.DepreciationRate = inputItem.DepreciationRate;  
  
		entity.EffectiveDate = inputItem.EffectiveDate;  
  
		entity.AccumulatedDepreciation = inputItem.AccumulatedDepreciation;  
  
		entity.DepreciationValue = inputItem.DepreciationValue;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.Duration = inputItem.Duration;  
  
		entity.CalculationDate = inputItem.CalculationDate;  
  
		entity.DepreciationState = inputItem.DepreciationState;  
  
		entity.SalvageValue = inputItem.SalvageValue;  
  
		entity.AcquisingElapsedLife = inputItem.AcquisingElapsedLife;  
  
		entity.AssetElapsedLife = inputItem.AssetElapsedLife;  
  
		entity.RemainingRoundingDepreciation = inputItem.RemainingRoundingDepreciation; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CostPartTransactionDto Map(CostPartTransaction inputItem)
        {
            var dto = new CostPartTransactionDto()
            {
                  
  
		CostPartTransactionID = inputItem.CostPartTransactionID,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		TotalCost = inputItem.TotalCost,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		EffectiveDate = inputItem.EffectiveDate,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		DepreciationValue = inputItem.DepreciationValue,  
  
		CreationDate = inputItem.CreationDate,  
  
		Duration = inputItem.Duration,  
  
		CalculationDate = inputItem.CalculationDate,  
  
		DepreciationState = inputItem.DepreciationState,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AcquisingElapsedLife = inputItem.AcquisingElapsedLife,  
  
		AssetElapsedLife = inputItem.AssetElapsedLife,  
  
		RemainingRoundingDepreciation = inputItem.RemainingRoundingDepreciation, 
            };
            return dto;
        }

        public static List<CostPartTransactionDto> Map(ICollection<CostPartTransaction> entities)
        {
            var dtos = new List<CostPartTransactionDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CostPartTransactionDto()
                {
                      
  
		CostPartTransactionID = inputItem.CostPartTransactionID,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		TotalCost = inputItem.TotalCost,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		EffectiveDate = inputItem.EffectiveDate,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		DepreciationValue = inputItem.DepreciationValue,  
  
		CreationDate = inputItem.CreationDate,  
  
		Duration = inputItem.Duration,  
  
		CalculationDate = inputItem.CalculationDate,  
  
		DepreciationState = inputItem.DepreciationState,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		AcquisingElapsedLife = inputItem.AcquisingElapsedLife,  
  
		AssetElapsedLife = inputItem.AssetElapsedLife,  
  
		RemainingRoundingDepreciation = inputItem.RemainingRoundingDepreciation, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Depreciation Map(AddDepreciationCommand inputItem)
        {
            var entity = new Depreciation() {
                  
  
		DepreciationID = inputItem.DepreciationID,  
  
		Date = inputItem.Date,  
  
		AssetRef = inputItem.AssetRef,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		LastAssetTransactionRef = inputItem.LastAssetTransactionRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Depreciation Map(Depreciation entity ,EditDepreciationCommand inputItem)
        {
              
  
		entity.DepreciationID = inputItem.DepreciationID;  
  
		entity.Date = inputItem.Date;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef;  
  
		entity.LastAssetTransactionRef = inputItem.LastAssetTransactionRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DepreciationDto Map(Depreciation inputItem)
        {
            var dto = new DepreciationDto()
            {
                  
  
		DepreciationID = inputItem.DepreciationID,  
  
		Date = inputItem.Date,  
  
		AssetRef = inputItem.AssetRef,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		LastAssetTransactionRef = inputItem.LastAssetTransactionRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<DepreciationDto> Map(ICollection<Depreciation> entities)
        {
            var dtos = new List<DepreciationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DepreciationDto()
                {
                      
  
		DepreciationID = inputItem.DepreciationID,  
  
		Date = inputItem.Date,  
  
		AssetRef = inputItem.AssetRef,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		LastAssetTransactionRef = inputItem.LastAssetTransactionRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
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
        
        public static DepreciationItem Map(AddDepreciationItemCommand inputItem)
        {
            var entity = new DepreciationItem() {
                  
  
		DepreciationItemID = inputItem.DepreciationItemID,  
  
		DepreciationRef = inputItem.DepreciationRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		CostPartTransactionRef = inputItem.CostPartTransactionRef,  
  
		LastCostPartTransactionRef = inputItem.LastCostPartTransactionRef,  
  
		CalculationDate = inputItem.CalculationDate,  
  
		DepreciationValue = inputItem.DepreciationValue,  
  
		Duration = inputItem.Duration,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		DepreciationState = inputItem.DepreciationState,  
  
		AssetElapsedLife = inputItem.AssetElapsedLife,  
  
		RemainingRoundingDepreciation = inputItem.RemainingRoundingDepreciation,  
  
		pDepreciationRate = inputItem.pDepreciationRate,  
  
		pUsefulLife = inputItem.pUsefulLife,  
  
		pRemainingBookValue = inputItem.pRemainingBookValue, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DepreciationItem Map(DepreciationItem entity ,EditDepreciationItemCommand inputItem)
        {
              
  
		entity.DepreciationItemID = inputItem.DepreciationItemID;  
  
		entity.DepreciationRef = inputItem.DepreciationRef;  
  
		entity.CostPartRef = inputItem.CostPartRef;  
  
		entity.CostPartTransactionRef = inputItem.CostPartTransactionRef;  
  
		entity.LastCostPartTransactionRef = inputItem.LastCostPartTransactionRef;  
  
		entity.CalculationDate = inputItem.CalculationDate;  
  
		entity.DepreciationValue = inputItem.DepreciationValue;  
  
		entity.Duration = inputItem.Duration;  
  
		entity.AccumulatedDepreciation = inputItem.AccumulatedDepreciation;  
  
		entity.DepreciationState = inputItem.DepreciationState;  
  
		entity.AssetElapsedLife = inputItem.AssetElapsedLife;  
  
		entity.RemainingRoundingDepreciation = inputItem.RemainingRoundingDepreciation;  
  
		entity.pDepreciationRate = inputItem.pDepreciationRate;  
  
		entity.pUsefulLife = inputItem.pUsefulLife;  
  
		entity.pRemainingBookValue = inputItem.pRemainingBookValue; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DepreciationItemDto Map(DepreciationItem inputItem)
        {
            var dto = new DepreciationItemDto()
            {
                  
  
		DepreciationItemID = inputItem.DepreciationItemID,  
  
		DepreciationRef = inputItem.DepreciationRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		CostPartTransactionRef = inputItem.CostPartTransactionRef,  
  
		LastCostPartTransactionRef = inputItem.LastCostPartTransactionRef,  
  
		CalculationDate = inputItem.CalculationDate,  
  
		DepreciationValue = inputItem.DepreciationValue,  
  
		Duration = inputItem.Duration,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		DepreciationState = inputItem.DepreciationState,  
  
		AssetElapsedLife = inputItem.AssetElapsedLife,  
  
		RemainingRoundingDepreciation = inputItem.RemainingRoundingDepreciation,  
  
		pDepreciationRate = inputItem.pDepreciationRate,  
  
		pUsefulLife = inputItem.pUsefulLife,  
  
		pRemainingBookValue = inputItem.pRemainingBookValue, 
            };
            return dto;
        }

        public static List<DepreciationItemDto> Map(ICollection<DepreciationItem> entities)
        {
            var dtos = new List<DepreciationItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DepreciationItemDto()
                {
                      
  
		DepreciationItemID = inputItem.DepreciationItemID,  
  
		DepreciationRef = inputItem.DepreciationRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		CostPartTransactionRef = inputItem.CostPartTransactionRef,  
  
		LastCostPartTransactionRef = inputItem.LastCostPartTransactionRef,  
  
		CalculationDate = inputItem.CalculationDate,  
  
		DepreciationValue = inputItem.DepreciationValue,  
  
		Duration = inputItem.Duration,  
  
		AccumulatedDepreciation = inputItem.AccumulatedDepreciation,  
  
		DepreciationState = inputItem.DepreciationState,  
  
		AssetElapsedLife = inputItem.AssetElapsedLife,  
  
		RemainingRoundingDepreciation = inputItem.RemainingRoundingDepreciation,  
  
		pDepreciationRate = inputItem.pDepreciationRate,  
  
		pUsefulLife = inputItem.pUsefulLife,  
  
		pRemainingBookValue = inputItem.pRemainingBookValue, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static DepreciationRule Map(AddDepreciationRuleCommand inputItem)
        {
            var entity = new DepreciationRule() {
                  
  
		DepreciationRuleID = inputItem.DepreciationRuleID,  
  
		GroupNo = inputItem.GroupNo,  
  
		GroupTitle = inputItem.GroupTitle,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		DepreciationMethod = inputItem.DepreciationMethod,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DepreciationRule Map(DepreciationRule entity ,EditDepreciationRuleCommand inputItem)
        {
              
  
		entity.DepreciationRuleID = inputItem.DepreciationRuleID;  
  
		entity.GroupNo = inputItem.GroupNo;  
  
		entity.GroupTitle = inputItem.GroupTitle;  
  
		entity.DepreciationRate = inputItem.DepreciationRate;  
  
		entity.UsefulLife = inputItem.UsefulLife;  
  
		entity.DepreciationMethod = inputItem.DepreciationMethod;  
  
		entity.Description = inputItem.Description;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DepreciationRuleDto Map(DepreciationRule inputItem)
        {
            var dto = new DepreciationRuleDto()
            {
                  
  
		DepreciationRuleID = inputItem.DepreciationRuleID,  
  
		GroupNo = inputItem.GroupNo,  
  
		GroupTitle = inputItem.GroupTitle,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		DepreciationMethod = inputItem.DepreciationMethod,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<DepreciationRuleDto> Map(ICollection<DepreciationRule> entities)
        {
            var dtos = new List<DepreciationRuleDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DepreciationRuleDto()
                {
                      
  
		DepreciationRuleID = inputItem.DepreciationRuleID,  
  
		GroupNo = inputItem.GroupNo,  
  
		GroupTitle = inputItem.GroupTitle,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		DepreciationMethod = inputItem.DepreciationMethod,  
  
		Description = inputItem.Description,  
  
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
        
        public static Elimination Map(AddEliminationCommand inputItem)
        {
            var entity = new Elimination() {
                  
  
		EliminationID = inputItem.EliminationID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		LossSLRef = inputItem.LossSLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Elimination Map(Elimination entity ,EditEliminationCommand inputItem)
        {
              
  
		entity.EliminationID = inputItem.EliminationID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.LossSLRef = inputItem.LossSLRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static EliminationDto Map(Elimination inputItem)
        {
            var dto = new EliminationDto()
            {
                  
  
		EliminationID = inputItem.EliminationID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		LossSLRef = inputItem.LossSLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<EliminationDto> Map(ICollection<Elimination> entities)
        {
            var dtos = new List<EliminationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new EliminationDto()
                {
                      
  
		EliminationID = inputItem.EliminationID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		LossSLRef = inputItem.LossSLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
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
        
        public static EliminationItem Map(AddEliminationItemCommand inputItem)
        {
            var entity = new EliminationItem() {
                  
  
		EliminationItemID = inputItem.EliminationItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		EliminationRef = inputItem.EliminationRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static EliminationItem Map(EliminationItem entity ,EditEliminationItemCommand inputItem)
        {
              
  
		entity.EliminationItemID = inputItem.EliminationItemID;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.EliminationRef = inputItem.EliminationRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static EliminationItemDto Map(EliminationItem inputItem)
        {
            var dto = new EliminationItemDto()
            {
                  
  
		EliminationItemID = inputItem.EliminationItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		EliminationRef = inputItem.EliminationRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
            };
            return dto;
        }

        public static List<EliminationItemDto> Map(ICollection<EliminationItem> entities)
        {
            var dtos = new List<EliminationItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new EliminationItemDto()
                {
                      
  
		EliminationItemID = inputItem.EliminationItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		EliminationRef = inputItem.EliminationRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Emplacement Map(AddEmplacementCommand inputItem)
        {
            var entity = new Emplacement() {
                  
  
		EmplacementId = inputItem.EmplacementId,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_EN = inputItem.Title_EN,  
  
		ParentRef = inputItem.ParentRef,  
  
		Description = inputItem.Description,  
  
		Description_EN = inputItem.Description_EN,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Emplacement Map(Emplacement entity ,EditEmplacementCommand inputItem)
        {
              
  
		entity.EmplacementId = inputItem.EmplacementId;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_EN = inputItem.Title_EN;  
  
		entity.ParentRef = inputItem.ParentRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_EN = inputItem.Description_EN;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static EmplacementDto Map(Emplacement inputItem)
        {
            var dto = new EmplacementDto()
            {
                  
  
		EmplacementId = inputItem.EmplacementId,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_EN = inputItem.Title_EN,  
  
		ParentRef = inputItem.ParentRef,  
  
		Description = inputItem.Description,  
  
		Description_EN = inputItem.Description_EN,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<EmplacementDto> Map(ICollection<Emplacement> entities)
        {
            var dtos = new List<EmplacementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new EmplacementDto()
                {
                      
  
		EmplacementId = inputItem.EmplacementId,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_EN = inputItem.Title_EN,  
  
		ParentRef = inputItem.ParentRef,  
  
		Description = inputItem.Description,  
  
		Description_EN = inputItem.Description_EN,  
  
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
        
        public static Repair Map(AddRepairCommand inputItem)
        {
            var entity = new Repair() {
                  
  
		RepairId = inputItem.RepairId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		DLRef = inputItem.DLRef,  
  
		AccountSlRef = inputItem.AccountSlRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Repair Map(Repair entity ,EditRepairCommand inputItem)
        {
              
  
		entity.RepairId = inputItem.RepairId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.AccountSlRef = inputItem.AccountSlRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static RepairDto Map(Repair inputItem)
        {
            var dto = new RepairDto()
            {
                  
  
		RepairId = inputItem.RepairId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		DLRef = inputItem.DLRef,  
  
		AccountSlRef = inputItem.AccountSlRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<RepairDto> Map(ICollection<Repair> entities)
        {
            var dtos = new List<RepairDto>();
            foreach (var inputItem in entities)
            {
                var dto = new RepairDto()
                {
                      
  
		RepairId = inputItem.RepairId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		DLRef = inputItem.DLRef,  
  
		AccountSlRef = inputItem.AccountSlRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
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
        
        public static RepairItem Map(AddRepairItemCommand inputItem)
        {
            var entity = new RepairItem() {
                  
  
		RepairItemId = inputItem.RepairItemId,  
  
		RepairRef = inputItem.RepairRef,  
  
		AssetRef = inputItem.AssetRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		CostPartType = inputItem.CostPartType,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		TotalCost = inputItem.TotalCost,  
  
		EffectiveDate = inputItem.EffectiveDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static RepairItem Map(RepairItem entity ,EditRepairItemCommand inputItem)
        {
              
  
		entity.RepairItemId = inputItem.RepairItemId;  
  
		entity.RepairRef = inputItem.RepairRef;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.CostPartRef = inputItem.CostPartRef;  
  
		entity.CostPartType = inputItem.CostPartType;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef;  
  
		entity.DepreciationMethodType = inputItem.DepreciationMethodType;  
  
		entity.DepreciationRate = inputItem.DepreciationRate;  
  
		entity.UsefulLife = inputItem.UsefulLife;  
  
		entity.MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue;  
  
		entity.SalvageValue = inputItem.SalvageValue;  
  
		entity.TotalCost = inputItem.TotalCost;  
  
		entity.EffectiveDate = inputItem.EffectiveDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static RepairItemDto Map(RepairItem inputItem)
        {
            var dto = new RepairItemDto()
            {
                  
  
		RepairItemId = inputItem.RepairItemId,  
  
		RepairRef = inputItem.RepairRef,  
  
		AssetRef = inputItem.AssetRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		CostPartType = inputItem.CostPartType,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		TotalCost = inputItem.TotalCost,  
  
		EffectiveDate = inputItem.EffectiveDate, 
            };
            return dto;
        }

        public static List<RepairItemDto> Map(ICollection<RepairItem> entities)
        {
            var dtos = new List<RepairItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new RepairItemDto()
                {
                      
  
		RepairItemId = inputItem.RepairItemId,  
  
		RepairRef = inputItem.RepairRef,  
  
		AssetRef = inputItem.AssetRef,  
  
		CostPartRef = inputItem.CostPartRef,  
  
		CostPartType = inputItem.CostPartType,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		DepreciationMethodType = inputItem.DepreciationMethodType,  
  
		DepreciationRate = inputItem.DepreciationRate,  
  
		UsefulLife = inputItem.UsefulLife,  
  
		MaxDepreciableBookValue = inputItem.MaxDepreciableBookValue,  
  
		SalvageValue = inputItem.SalvageValue,  
  
		TotalCost = inputItem.TotalCost,  
  
		EffectiveDate = inputItem.EffectiveDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Sale Map(AddSaleCommand inputItem)
        {
            var entity = new Sale() {
                  
  
		SaleID = inputItem.SaleID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		PartyRef = inputItem.PartyRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Sale Map(Sale entity ,EditSaleCommand inputItem)
        {
              
  
		entity.SaleID = inputItem.SaleID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.SLAccountRef = inputItem.SLAccountRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SaleDto Map(Sale inputItem)
        {
            var dto = new SaleDto()
            {
                  
  
		SaleID = inputItem.SaleID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		PartyRef = inputItem.PartyRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<SaleDto> Map(ICollection<Sale> entities)
        {
            var dtos = new List<SaleDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SaleDto()
                {
                      
  
		SaleID = inputItem.SaleID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		PartyRef = inputItem.PartyRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
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
        
        public static SaleItem Map(AddSaleItemCommand inputItem)
        {
            var entity = new SaleItem() {
                  
  
		SaleItemID = inputItem.SaleItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		SaleRef = inputItem.SaleRef,  
  
		SalePrice = inputItem.SalePrice,  
  
		SalePriceInBaseCurrency = inputItem.SalePriceInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SaleItem Map(SaleItem entity ,EditSaleItemCommand inputItem)
        {
              
  
		entity.SaleItemID = inputItem.SaleItemID;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.SaleRef = inputItem.SaleRef;  
  
		entity.SalePrice = inputItem.SalePrice;  
  
		entity.SalePriceInBaseCurrency = inputItem.SalePriceInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SaleItemDto Map(SaleItem inputItem)
        {
            var dto = new SaleItemDto()
            {
                  
  
		SaleItemID = inputItem.SaleItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		SaleRef = inputItem.SaleRef,  
  
		SalePrice = inputItem.SalePrice,  
  
		SalePriceInBaseCurrency = inputItem.SalePriceInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
            };
            return dto;
        }

        public static List<SaleItemDto> Map(ICollection<SaleItem> entities)
        {
            var dtos = new List<SaleItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SaleItemDto()
                {
                      
  
		SaleItemID = inputItem.SaleItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		SaleRef = inputItem.SaleRef,  
  
		SalePrice = inputItem.SalePrice,  
  
		SalePriceInBaseCurrency = inputItem.SalePriceInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Salvage Map(AddSalvageCommand inputItem)
        {
            var entity = new Salvage() {
                  
  
		SalvageID = inputItem.SalvageID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		LossSLRef = inputItem.LossSLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Salvage Map(Salvage entity ,EditSalvageCommand inputItem)
        {
              
  
		entity.SalvageID = inputItem.SalvageID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.LossSLRef = inputItem.LossSLRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SalvageDto Map(Salvage inputItem)
        {
            var dto = new SalvageDto()
            {
                  
  
		SalvageID = inputItem.SalvageID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		LossSLRef = inputItem.LossSLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<SalvageDto> Map(ICollection<Salvage> entities)
        {
            var dtos = new List<SalvageDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SalvageDto()
                {
                      
  
		SalvageID = inputItem.SalvageID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		LossSLRef = inputItem.LossSLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
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
        
        public static SalvageItem Map(AddSalvageItemCommand inputItem)
        {
            var entity = new SalvageItem() {
                  
  
		SalvageItemID = inputItem.SalvageItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		SalvageRef = inputItem.SalvageRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SalvageItem Map(SalvageItem entity ,EditSalvageItemCommand inputItem)
        {
              
  
		entity.SalvageItemID = inputItem.SalvageItemID;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.SalvageRef = inputItem.SalvageRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SalvageItemDto Map(SalvageItem inputItem)
        {
            var dto = new SalvageItemDto()
            {
                  
  
		SalvageItemID = inputItem.SalvageItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		SalvageRef = inputItem.SalvageRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
            };
            return dto;
        }

        public static List<SalvageItemDto> Map(ICollection<SalvageItem> entities)
        {
            var dtos = new List<SalvageItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SalvageItemDto()
                {
                      
  
		SalvageItemID = inputItem.SalvageItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		SalvageRef = inputItem.SalvageRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Transfer Map(AddTransferCommand inputItem)
        {
            var entity = new Transfer() {
                  
  
		TransferID = inputItem.TransferID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Transfer Map(Transfer entity ,EditTransferCommand inputItem)
        {
              
  
		entity.TransferID = inputItem.TransferID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TransferDto Map(Transfer inputItem)
        {
            var dto = new TransferDto()
            {
                  
  
		TransferID = inputItem.TransferID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<TransferDto> Map(ICollection<Transfer> entities)
        {
            var dtos = new List<TransferDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TransferDto()
                {
                      
  
		TransferID = inputItem.TransferID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
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
        
        public static TransferItem Map(AddTransferItemCommand inputItem)
        {
            var entity = new TransferItem() {
                  
  
		TransferItemID = inputItem.TransferItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		TransferRef = inputItem.TransferRef,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		PreCostCenterDlRef = inputItem.PreCostCenterDlRef,  
  
		PreEmplacementRef = inputItem.PreEmplacementRef,  
  
		PreReceiverPartyRef = inputItem.PreReceiverPartyRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TransferItem Map(TransferItem entity ,EditTransferItemCommand inputItem)
        {
              
  
		entity.TransferItemID = inputItem.TransferItemID;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.TransferRef = inputItem.TransferRef;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef;  
  
		entity.PreCostCenterDlRef = inputItem.PreCostCenterDlRef;  
  
		entity.PreEmplacementRef = inputItem.PreEmplacementRef;  
  
		entity.PreReceiverPartyRef = inputItem.PreReceiverPartyRef;  
  
		entity.CostCenterDlRef = inputItem.CostCenterDlRef;  
  
		entity.EmplacementRef = inputItem.EmplacementRef;  
  
		entity.ReceiverPartyRef = inputItem.ReceiverPartyRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TransferItemDto Map(TransferItem inputItem)
        {
            var dto = new TransferItemDto()
            {
                  
  
		TransferItemID = inputItem.TransferItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		TransferRef = inputItem.TransferRef,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		PreCostCenterDlRef = inputItem.PreCostCenterDlRef,  
  
		PreEmplacementRef = inputItem.PreEmplacementRef,  
  
		PreReceiverPartyRef = inputItem.PreReceiverPartyRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef, 
            };
            return dto;
        }

        public static List<TransferItemDto> Map(ICollection<TransferItem> entities)
        {
            var dtos = new List<TransferItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TransferItemDto()
                {
                      
  
		TransferItemID = inputItem.TransferItemID,  
  
		AssetRef = inputItem.AssetRef,  
  
		TransferRef = inputItem.TransferRef,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef,  
  
		PreCostCenterDlRef = inputItem.PreCostCenterDlRef,  
  
		PreEmplacementRef = inputItem.PreEmplacementRef,  
  
		PreReceiverPartyRef = inputItem.PreReceiverPartyRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		EmplacementRef = inputItem.EmplacementRef,  
  
		ReceiverPartyRef = inputItem.ReceiverPartyRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Unuseable Map(AddUnuseableCommand inputItem)
        {
            var entity = new Unuseable() {
                  
  
		UnuseableId = inputItem.UnuseableId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Unuseable Map(Unuseable entity ,EditUnuseableCommand inputItem)
        {
              
  
		entity.UnuseableId = inputItem.UnuseableId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UnuseableDto Map(Unuseable inputItem)
        {
            var dto = new UnuseableDto()
            {
                  
  
		UnuseableId = inputItem.UnuseableId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<UnuseableDto> Map(ICollection<Unuseable> entities)
        {
            var dtos = new List<UnuseableDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UnuseableDto()
                {
                      
  
		UnuseableId = inputItem.UnuseableId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
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
        
        public static UnuseableItem Map(AddUnuseableItemCommand inputItem)
        {
            var entity = new UnuseableItem() {
                  
  
		UnuseableItemId = inputItem.UnuseableItemId,  
  
		AssetRef = inputItem.AssetRef,  
  
		UnuseableRef = inputItem.UnuseableRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UnuseableItem Map(UnuseableItem entity ,EditUnuseableItemCommand inputItem)
        {
              
  
		entity.UnuseableItemId = inputItem.UnuseableItemId;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.UnuseableRef = inputItem.UnuseableRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UnuseableItemDto Map(UnuseableItem inputItem)
        {
            var dto = new UnuseableItemDto()
            {
                  
  
		UnuseableItemId = inputItem.UnuseableItemId,  
  
		AssetRef = inputItem.AssetRef,  
  
		UnuseableRef = inputItem.UnuseableRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
            };
            return dto;
        }

        public static List<UnuseableItemDto> Map(ICollection<UnuseableItem> entities)
        {
            var dtos = new List<UnuseableItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UnuseableItemDto()
                {
                      
  
		UnuseableItemId = inputItem.UnuseableItemId,  
  
		AssetRef = inputItem.AssetRef,  
  
		UnuseableRef = inputItem.UnuseableRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Useable Map(AddUseableCommand inputItem)
        {
            var entity = new Useable() {
                  
  
		UseableId = inputItem.UseableId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Useable Map(Useable entity ,EditUseableCommand inputItem)
        {
              
  
		entity.UseableId = inputItem.UseableId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UseableDto Map(Useable inputItem)
        {
            var dto = new UseableDto()
            {
                  
  
		UseableId = inputItem.UseableId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<UseableDto> Map(ICollection<Useable> entities)
        {
            var dtos = new List<UseableDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UseableDto()
                {
                      
  
		UseableId = inputItem.UseableId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
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
        
        public static UseableItem Map(AddUseableItemCommand inputItem)
        {
            var entity = new UseableItem() {
                  
  
		UseableItemId = inputItem.UseableItemId,  
  
		AssetRef = inputItem.AssetRef,  
  
		UseableRef = inputItem.UseableRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UseableItem Map(UseableItem entity ,EditUseableItemCommand inputItem)
        {
              
  
		entity.UseableItemId = inputItem.UseableItemId;  
  
		entity.AssetRef = inputItem.AssetRef;  
  
		entity.UseableRef = inputItem.UseableRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.AssetTransactionRef = inputItem.AssetTransactionRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UseableItemDto Map(UseableItem inputItem)
        {
            var dto = new UseableItemDto()
            {
                  
  
		UseableItemId = inputItem.UseableItemId,  
  
		AssetRef = inputItem.AssetRef,  
  
		UseableRef = inputItem.UseableRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
            };
            return dto;
        }

        public static List<UseableItemDto> Map(ICollection<UseableItem> entities)
        {
            var dtos = new List<UseableItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UseableItemDto()
                {
                      
  
		UseableItemId = inputItem.UseableItemId,  
  
		AssetRef = inputItem.AssetRef,  
  
		UseableRef = inputItem.UseableRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		AssetTransactionRef = inputItem.AssetTransactionRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
