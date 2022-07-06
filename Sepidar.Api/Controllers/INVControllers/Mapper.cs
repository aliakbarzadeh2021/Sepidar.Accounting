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
                
        
        public static CompoundBarcode Map(AddCompoundBarcodeCommand inputItem)
        {
            var entity = new CompoundBarcode() {
                  
  
		CompoundBarcodeID = inputItem.CompoundBarcodeID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		FixedPart = inputItem.FixedPart,  
  
		FixedPartStart = inputItem.FixedPartStart,  
  
		ItemIdentifier = inputItem.ItemIdentifier,  
  
		CodeStart = inputItem.CodeStart,  
  
		CodeLength = inputItem.CodeLength,  
  
		CodeSeparator = inputItem.CodeSeparator,  
  
		TracingStart = inputItem.TracingStart,  
  
		TracingLength = inputItem.TracingLength,  
  
		TracingSeparator = inputItem.TracingSeparator,  
  
		QuantityStart = inputItem.QuantityStart,  
  
		QuantityWholeLength = inputItem.QuantityWholeLength,  
  
		QuantityDecimalSeparator = inputItem.QuantityDecimalSeparator,  
  
		QuantityDecimalLength = inputItem.QuantityDecimalLength,  
  
		QuantitySeparator = inputItem.QuantitySeparator,  
  
		SecondaryQuantityStart = inputItem.SecondaryQuantityStart,  
  
		SecondaryQuantityWholeLength = inputItem.SecondaryQuantityWholeLength,  
  
		SecondaryQuantityDecimalSeparator = inputItem.SecondaryQuantityDecimalSeparator,  
  
		SecondaryQuantityDecimalLength = inputItem.SecondaryQuantityDecimalLength,  
  
		SecondaryQuantitySeparator = inputItem.SecondaryQuantitySeparator,  
  
		DescriptionStart = inputItem.DescriptionStart,  
  
		DescriptionLength = inputItem.DescriptionLength,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CompoundBarcode Map(CompoundBarcode entity ,EditCompoundBarcodeCommand inputItem)
        {
              
  
		entity.CompoundBarcodeID = inputItem.CompoundBarcodeID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.FixedPart = inputItem.FixedPart;  
  
		entity.FixedPartStart = inputItem.FixedPartStart;  
  
		entity.ItemIdentifier = inputItem.ItemIdentifier;  
  
		entity.CodeStart = inputItem.CodeStart;  
  
		entity.CodeLength = inputItem.CodeLength;  
  
		entity.CodeSeparator = inputItem.CodeSeparator;  
  
		entity.TracingStart = inputItem.TracingStart;  
  
		entity.TracingLength = inputItem.TracingLength;  
  
		entity.TracingSeparator = inputItem.TracingSeparator;  
  
		entity.QuantityStart = inputItem.QuantityStart;  
  
		entity.QuantityWholeLength = inputItem.QuantityWholeLength;  
  
		entity.QuantityDecimalSeparator = inputItem.QuantityDecimalSeparator;  
  
		entity.QuantityDecimalLength = inputItem.QuantityDecimalLength;  
  
		entity.QuantitySeparator = inputItem.QuantitySeparator;  
  
		entity.SecondaryQuantityStart = inputItem.SecondaryQuantityStart;  
  
		entity.SecondaryQuantityWholeLength = inputItem.SecondaryQuantityWholeLength;  
  
		entity.SecondaryQuantityDecimalSeparator = inputItem.SecondaryQuantityDecimalSeparator;  
  
		entity.SecondaryQuantityDecimalLength = inputItem.SecondaryQuantityDecimalLength;  
  
		entity.SecondaryQuantitySeparator = inputItem.SecondaryQuantitySeparator;  
  
		entity.DescriptionStart = inputItem.DescriptionStart;  
  
		entity.DescriptionLength = inputItem.DescriptionLength;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CompoundBarcodeDto Map(CompoundBarcode inputItem)
        {
            var dto = new CompoundBarcodeDto()
            {
                  
  
		CompoundBarcodeID = inputItem.CompoundBarcodeID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		FixedPart = inputItem.FixedPart,  
  
		FixedPartStart = inputItem.FixedPartStart,  
  
		ItemIdentifier = inputItem.ItemIdentifier,  
  
		CodeStart = inputItem.CodeStart,  
  
		CodeLength = inputItem.CodeLength,  
  
		CodeSeparator = inputItem.CodeSeparator,  
  
		TracingStart = inputItem.TracingStart,  
  
		TracingLength = inputItem.TracingLength,  
  
		TracingSeparator = inputItem.TracingSeparator,  
  
		QuantityStart = inputItem.QuantityStart,  
  
		QuantityWholeLength = inputItem.QuantityWholeLength,  
  
		QuantityDecimalSeparator = inputItem.QuantityDecimalSeparator,  
  
		QuantityDecimalLength = inputItem.QuantityDecimalLength,  
  
		QuantitySeparator = inputItem.QuantitySeparator,  
  
		SecondaryQuantityStart = inputItem.SecondaryQuantityStart,  
  
		SecondaryQuantityWholeLength = inputItem.SecondaryQuantityWholeLength,  
  
		SecondaryQuantityDecimalSeparator = inputItem.SecondaryQuantityDecimalSeparator,  
  
		SecondaryQuantityDecimalLength = inputItem.SecondaryQuantityDecimalLength,  
  
		SecondaryQuantitySeparator = inputItem.SecondaryQuantitySeparator,  
  
		DescriptionStart = inputItem.DescriptionStart,  
  
		DescriptionLength = inputItem.DescriptionLength,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<CompoundBarcodeDto> Map(ICollection<CompoundBarcode> entities)
        {
            var dtos = new List<CompoundBarcodeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CompoundBarcodeDto()
                {
                      
  
		CompoundBarcodeID = inputItem.CompoundBarcodeID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		FixedPart = inputItem.FixedPart,  
  
		FixedPartStart = inputItem.FixedPartStart,  
  
		ItemIdentifier = inputItem.ItemIdentifier,  
  
		CodeStart = inputItem.CodeStart,  
  
		CodeLength = inputItem.CodeLength,  
  
		CodeSeparator = inputItem.CodeSeparator,  
  
		TracingStart = inputItem.TracingStart,  
  
		TracingLength = inputItem.TracingLength,  
  
		TracingSeparator = inputItem.TracingSeparator,  
  
		QuantityStart = inputItem.QuantityStart,  
  
		QuantityWholeLength = inputItem.QuantityWholeLength,  
  
		QuantityDecimalSeparator = inputItem.QuantityDecimalSeparator,  
  
		QuantityDecimalLength = inputItem.QuantityDecimalLength,  
  
		QuantitySeparator = inputItem.QuantitySeparator,  
  
		SecondaryQuantityStart = inputItem.SecondaryQuantityStart,  
  
		SecondaryQuantityWholeLength = inputItem.SecondaryQuantityWholeLength,  
  
		SecondaryQuantityDecimalSeparator = inputItem.SecondaryQuantityDecimalSeparator,  
  
		SecondaryQuantityDecimalLength = inputItem.SecondaryQuantityDecimalLength,  
  
		SecondaryQuantitySeparator = inputItem.SecondaryQuantitySeparator,  
  
		DescriptionStart = inputItem.DescriptionStart,  
  
		DescriptionLength = inputItem.DescriptionLength,  
  
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
        
        public static Group Map(AddGroupCommand inputItem)
        {
            var entity = new Group() {
                  
  
		GroupID = inputItem.GroupID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ParentRef = inputItem.ParentRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Group Map(Group entity ,EditGroupCommand inputItem)
        {
              
  
		entity.GroupID = inputItem.GroupID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.ParentRef = inputItem.ParentRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GroupDto Map(Group inputItem)
        {
            var dto = new GroupDto()
            {
                  
  
		GroupID = inputItem.GroupID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ParentRef = inputItem.ParentRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<GroupDto> Map(ICollection<Group> entities)
        {
            var dtos = new List<GroupDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GroupDto()
                {
                      
  
		GroupID = inputItem.GroupID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ParentRef = inputItem.ParentRef,  
  
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
        
        public static InventoryBalancing Map(AddInventoryBalancingCommand inputItem)
        {
            var entity = new InventoryBalancing() {
                  
  
		InventoryBalancingId = inputItem.InventoryBalancingId,  
  
		Number = inputItem.Number,  
  
		State = inputItem.State,  
  
		StockRef = inputItem.StockRef,  
  
		OperatorDLRef = inputItem.OperatorDLRef,  
  
		RedundancySLRef = inputItem.RedundancySLRef,  
  
		RedundancyDLRef = inputItem.RedundancyDLRef,  
  
		ShortageSLRef = inputItem.ShortageSLRef,  
  
		ShortageDLRef = inputItem.ShortageDLRef,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		ItemMinQuantity = inputItem.ItemMinQuantity,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryBalancing Map(InventoryBalancing entity ,EditInventoryBalancingCommand inputItem)
        {
              
  
		entity.InventoryBalancingId = inputItem.InventoryBalancingId;  
  
		entity.Number = inputItem.Number;  
  
		entity.State = inputItem.State;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.OperatorDLRef = inputItem.OperatorDLRef;  
  
		entity.RedundancySLRef = inputItem.RedundancySLRef;  
  
		entity.RedundancyDLRef = inputItem.RedundancyDLRef;  
  
		entity.ShortageSLRef = inputItem.ShortageSLRef;  
  
		entity.ShortageDLRef = inputItem.ShortageDLRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.InventoryReceiptRef = inputItem.InventoryReceiptRef;  
  
		entity.InventoryDeliveryRef = inputItem.InventoryDeliveryRef;  
  
		entity.ItemMinQuantity = inputItem.ItemMinQuantity;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryBalancingDto Map(InventoryBalancing inputItem)
        {
            var dto = new InventoryBalancingDto()
            {
                  
  
		InventoryBalancingId = inputItem.InventoryBalancingId,  
  
		Number = inputItem.Number,  
  
		State = inputItem.State,  
  
		StockRef = inputItem.StockRef,  
  
		OperatorDLRef = inputItem.OperatorDLRef,  
  
		RedundancySLRef = inputItem.RedundancySLRef,  
  
		RedundancyDLRef = inputItem.RedundancyDLRef,  
  
		ShortageSLRef = inputItem.ShortageSLRef,  
  
		ShortageDLRef = inputItem.ShortageDLRef,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		ItemMinQuantity = inputItem.ItemMinQuantity,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<InventoryBalancingDto> Map(ICollection<InventoryBalancing> entities)
        {
            var dtos = new List<InventoryBalancingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryBalancingDto()
                {
                      
  
		InventoryBalancingId = inputItem.InventoryBalancingId,  
  
		Number = inputItem.Number,  
  
		State = inputItem.State,  
  
		StockRef = inputItem.StockRef,  
  
		OperatorDLRef = inputItem.OperatorDLRef,  
  
		RedundancySLRef = inputItem.RedundancySLRef,  
  
		RedundancyDLRef = inputItem.RedundancyDLRef,  
  
		ShortageSLRef = inputItem.ShortageSLRef,  
  
		ShortageDLRef = inputItem.ShortageDLRef,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		ItemMinQuantity = inputItem.ItemMinQuantity,  
  
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
        
        public static InventoryBalancingItem Map(AddInventoryBalancingItemCommand inputItem)
        {
            var entity = new InventoryBalancingItem() {
                  
  
		InventoryBalancingItemId = inputItem.InventoryBalancingItemId,  
  
		InventoryBalancingRef = inputItem.InventoryBalancingRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		TagNumber = inputItem.TagNumber,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryBalancingItem Map(InventoryBalancingItem entity ,EditInventoryBalancingItemCommand inputItem)
        {
              
  
		entity.InventoryBalancingItemId = inputItem.InventoryBalancingItemId;  
  
		entity.InventoryBalancingRef = inputItem.InventoryBalancingRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.TagNumber = inputItem.TagNumber;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryBalancingItemDto Map(InventoryBalancingItem inputItem)
        {
            var dto = new InventoryBalancingItemDto()
            {
                  
  
		InventoryBalancingItemId = inputItem.InventoryBalancingItemId,  
  
		InventoryBalancingRef = inputItem.InventoryBalancingRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		TagNumber = inputItem.TagNumber,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
            };
            return dto;
        }

        public static List<InventoryBalancingItemDto> Map(ICollection<InventoryBalancingItem> entities)
        {
            var dtos = new List<InventoryBalancingItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryBalancingItemDto()
                {
                      
  
		InventoryBalancingItemId = inputItem.InventoryBalancingItemId,  
  
		InventoryBalancingRef = inputItem.InventoryBalancingRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		TagNumber = inputItem.TagNumber,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InventoryDelivery Map(AddInventoryDeliveryCommand inputItem)
        {
            var entity = new InventoryDelivery() {
                  
  
		InventoryDeliveryID = inputItem.InventoryDeliveryID,  
  
		IsReturn = inputItem.IsReturn,  
  
		Type = inputItem.Type,  
  
		StockRef = inputItem.StockRef,  
  
		ReceiverDLRef = inputItem.ReceiverDLRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		DestinationStockRef = inputItem.DestinationStockRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryDelivery Map(InventoryDelivery entity ,EditInventoryDeliveryCommand inputItem)
        {
              
  
		entity.InventoryDeliveryID = inputItem.InventoryDeliveryID;  
  
		entity.IsReturn = inputItem.IsReturn;  
  
		entity.Type = inputItem.Type;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.ReceiverDLRef = inputItem.ReceiverDLRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.TotalPrice = inputItem.TotalPrice;  
  
		entity.AccountingVoucherRef = inputItem.AccountingVoucherRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.DestinationStockRef = inputItem.DestinationStockRef;  
  
		entity.CreatorForm = inputItem.CreatorForm;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryDeliveryDto Map(InventoryDelivery inputItem)
        {
            var dto = new InventoryDeliveryDto()
            {
                  
  
		InventoryDeliveryID = inputItem.InventoryDeliveryID,  
  
		IsReturn = inputItem.IsReturn,  
  
		Type = inputItem.Type,  
  
		StockRef = inputItem.StockRef,  
  
		ReceiverDLRef = inputItem.ReceiverDLRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		DestinationStockRef = inputItem.DestinationStockRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<InventoryDeliveryDto> Map(ICollection<InventoryDelivery> entities)
        {
            var dtos = new List<InventoryDeliveryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryDeliveryDto()
                {
                      
  
		InventoryDeliveryID = inputItem.InventoryDeliveryID,  
  
		IsReturn = inputItem.IsReturn,  
  
		Type = inputItem.Type,  
  
		StockRef = inputItem.StockRef,  
  
		ReceiverDLRef = inputItem.ReceiverDLRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		DestinationStockRef = inputItem.DestinationStockRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
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
        
        public static InventoryDeliveryItem Map(AddInventoryDeliveryItemCommand inputItem)
        {
            var entity = new InventoryDeliveryItem() {
                  
  
		InventoryDeliveryItemID = inputItem.InventoryDeliveryItemID,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		IsReturn = inputItem.IsReturn,  
  
		RowNumber = inputItem.RowNumber,  
  
		BaseInvoiceItem = inputItem.BaseInvoiceItem,  
  
		BaseInventoryDeliveryItem = inputItem.BaseInventoryDeliveryItem,  
  
		BaseReturnedInvoiceItem = inputItem.BaseReturnedInvoiceItem,  
  
		QuotationItemRef = inputItem.QuotationItemRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		RemainingQuantity = inputItem.RemainingQuantity,  
  
		RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Price = inputItem.Price,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		ProductOrderRef = inputItem.ProductOrderRef,  
  
		ParityCheck = inputItem.ParityCheck,  
  
		WeighingRef = inputItem.WeighingRef,  
  
		Fee = inputItem.Fee, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryDeliveryItem Map(InventoryDeliveryItem entity ,EditInventoryDeliveryItemCommand inputItem)
        {
              
  
		entity.InventoryDeliveryItemID = inputItem.InventoryDeliveryItemID;  
  
		entity.InventoryDeliveryRef = inputItem.InventoryDeliveryRef;  
  
		entity.IsReturn = inputItem.IsReturn;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.BaseInvoiceItem = inputItem.BaseInvoiceItem;  
  
		entity.BaseInventoryDeliveryItem = inputItem.BaseInventoryDeliveryItem;  
  
		entity.BaseReturnedInvoiceItem = inputItem.BaseReturnedInvoiceItem;  
  
		entity.QuotationItemRef = inputItem.QuotationItemRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.RemainingQuantity = inputItem.RemainingQuantity;  
  
		entity.RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity;  
  
		entity.SLAccountRef = inputItem.SLAccountRef;  
  
		entity.Price = inputItem.Price;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.ProductOrderRef = inputItem.ProductOrderRef;  
  
		entity.ParityCheck = inputItem.ParityCheck;  
  
		entity.WeighingRef = inputItem.WeighingRef;  
  
		entity.Fee = inputItem.Fee; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryDeliveryItemDto Map(InventoryDeliveryItem inputItem)
        {
            var dto = new InventoryDeliveryItemDto()
            {
                  
  
		InventoryDeliveryItemID = inputItem.InventoryDeliveryItemID,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		IsReturn = inputItem.IsReturn,  
  
		RowNumber = inputItem.RowNumber,  
  
		BaseInvoiceItem = inputItem.BaseInvoiceItem,  
  
		BaseInventoryDeliveryItem = inputItem.BaseInventoryDeliveryItem,  
  
		BaseReturnedInvoiceItem = inputItem.BaseReturnedInvoiceItem,  
  
		QuotationItemRef = inputItem.QuotationItemRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		RemainingQuantity = inputItem.RemainingQuantity,  
  
		RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Price = inputItem.Price,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		ProductOrderRef = inputItem.ProductOrderRef,  
  
		ParityCheck = inputItem.ParityCheck,  
  
		WeighingRef = inputItem.WeighingRef,  
  
		Fee = inputItem.Fee, 
            };
            return dto;
        }

        public static List<InventoryDeliveryItemDto> Map(ICollection<InventoryDeliveryItem> entities)
        {
            var dtos = new List<InventoryDeliveryItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryDeliveryItemDto()
                {
                      
  
		InventoryDeliveryItemID = inputItem.InventoryDeliveryItemID,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		IsReturn = inputItem.IsReturn,  
  
		RowNumber = inputItem.RowNumber,  
  
		BaseInvoiceItem = inputItem.BaseInvoiceItem,  
  
		BaseInventoryDeliveryItem = inputItem.BaseInventoryDeliveryItem,  
  
		BaseReturnedInvoiceItem = inputItem.BaseReturnedInvoiceItem,  
  
		QuotationItemRef = inputItem.QuotationItemRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		RemainingQuantity = inputItem.RemainingQuantity,  
  
		RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Price = inputItem.Price,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		ProductOrderRef = inputItem.ProductOrderRef,  
  
		ParityCheck = inputItem.ParityCheck,  
  
		WeighingRef = inputItem.WeighingRef,  
  
		Fee = inputItem.Fee, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InventoryPricing Map(AddInventoryPricingCommand inputItem)
        {
            var entity = new InventoryPricing() {
                  
  
		InventoryPricingID = inputItem.InventoryPricingID,  
  
		StockRef = inputItem.StockRef,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Inputs = inputItem.Inputs,  
  
		Outputs = inputItem.Outputs,  
  
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

        public static InventoryPricing Map(InventoryPricing entity ,EditInventoryPricingCommand inputItem)
        {
              
  
		entity.InventoryPricingID = inputItem.InventoryPricingID;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.Inputs = inputItem.Inputs;  
  
		entity.Outputs = inputItem.Outputs;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryPricingDto Map(InventoryPricing inputItem)
        {
            var dto = new InventoryPricingDto()
            {
                  
  
		InventoryPricingID = inputItem.InventoryPricingID,  
  
		StockRef = inputItem.StockRef,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Inputs = inputItem.Inputs,  
  
		Outputs = inputItem.Outputs,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<InventoryPricingDto> Map(ICollection<InventoryPricing> entities)
        {
            var dtos = new List<InventoryPricingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryPricingDto()
                {
                      
  
		InventoryPricingID = inputItem.InventoryPricingID,  
  
		StockRef = inputItem.StockRef,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Inputs = inputItem.Inputs,  
  
		Outputs = inputItem.Outputs,  
  
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
        
        public static InventoryPricingVoucher Map(AddInventoryPricingVoucherCommand inputItem)
        {
            var entity = new InventoryPricingVoucher() {
                  
  
		InventoryPricingVoucherID = inputItem.InventoryPricingVoucherID,  
  
		InventoryPricingRef = inputItem.InventoryPricingRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		InventoryVoucherType = inputItem.InventoryVoucherType,  
  
		InventoryVoucherRef = inputItem.InventoryVoucherRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryPricingVoucher Map(InventoryPricingVoucher entity ,EditInventoryPricingVoucherCommand inputItem)
        {
              
  
		entity.InventoryPricingVoucherID = inputItem.InventoryPricingVoucherID;  
  
		entity.InventoryPricingRef = inputItem.InventoryPricingRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.InventoryVoucherType = inputItem.InventoryVoucherType;  
  
		entity.InventoryVoucherRef = inputItem.InventoryVoucherRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryPricingVoucherDto Map(InventoryPricingVoucher inputItem)
        {
            var dto = new InventoryPricingVoucherDto()
            {
                  
  
		InventoryPricingVoucherID = inputItem.InventoryPricingVoucherID,  
  
		InventoryPricingRef = inputItem.InventoryPricingRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		InventoryVoucherType = inputItem.InventoryVoucherType,  
  
		InventoryVoucherRef = inputItem.InventoryVoucherRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<InventoryPricingVoucherDto> Map(ICollection<InventoryPricingVoucher> entities)
        {
            var dtos = new List<InventoryPricingVoucherDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryPricingVoucherDto()
                {
                      
  
		InventoryPricingVoucherID = inputItem.InventoryPricingVoucherID,  
  
		InventoryPricingRef = inputItem.InventoryPricingRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		InventoryVoucherType = inputItem.InventoryVoucherType,  
  
		InventoryVoucherRef = inputItem.InventoryVoucherRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InventoryPricingVoucherItem Map(AddInventoryPricingVoucherItemCommand inputItem)
        {
            var entity = new InventoryPricingVoucherItem() {
                  
  
		InventoryPricingVoucherItemID = inputItem.InventoryPricingVoucherItemID,  
  
		InventoryPricingVoucherRef = inputItem.InventoryPricingVoucherRef,  
  
		InventoryVoucherItemRef = inputItem.InventoryVoucherItemRef,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryPricingVoucherItem Map(InventoryPricingVoucherItem entity ,EditInventoryPricingVoucherItemCommand inputItem)
        {
              
  
		entity.InventoryPricingVoucherItemID = inputItem.InventoryPricingVoucherItemID;  
  
		entity.InventoryPricingVoucherRef = inputItem.InventoryPricingVoucherRef;  
  
		entity.InventoryVoucherItemRef = inputItem.InventoryVoucherItemRef;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryPricingVoucherItemDto Map(InventoryPricingVoucherItem inputItem)
        {
            var dto = new InventoryPricingVoucherItemDto()
            {
                  
  
		InventoryPricingVoucherItemID = inputItem.InventoryPricingVoucherItemID,  
  
		InventoryPricingVoucherRef = inputItem.InventoryPricingVoucherRef,  
  
		InventoryVoucherItemRef = inputItem.InventoryVoucherItemRef,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<InventoryPricingVoucherItemDto> Map(ICollection<InventoryPricingVoucherItem> entities)
        {
            var dtos = new List<InventoryPricingVoucherItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryPricingVoucherItemDto()
                {
                      
  
		InventoryPricingVoucherItemID = inputItem.InventoryPricingVoucherItemID,  
  
		InventoryPricingVoucherRef = inputItem.InventoryPricingVoucherRef,  
  
		InventoryVoucherItemRef = inputItem.InventoryVoucherItemRef,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InventoryPurchaseInvoice Map(AddInventoryPurchaseInvoiceCommand inputItem)
        {
            var entity = new InventoryPurchaseInvoice() {
                  
  
		InventoryPurchaseInvoiceID = inputItem.InventoryPurchaseInvoiceID,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		Number = inputItem.Number,  
  
		InvoiceNumber = inputItem.InvoiceNumber,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalTransportPrice = inputItem.TotalTransportPrice,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		TotalWithHoldingTaxAmount = inputItem.TotalWithHoldingTaxAmount,  
  
		TotalInsuranceAmount = inputItem.TotalInsuranceAmount,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Type = inputItem.Type,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		AssetAcquisitionPurchaseSLRef = inputItem.AssetAcquisitionPurchaseSLRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryPurchaseInvoice Map(InventoryPurchaseInvoice entity ,EditInventoryPurchaseInvoiceCommand inputItem)
        {
              
  
		entity.InventoryPurchaseInvoiceID = inputItem.InventoryPurchaseInvoiceID;  
  
		entity.VendorDLRef = inputItem.VendorDLRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.InvoiceNumber = inputItem.InvoiceNumber;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.TotalPrice = inputItem.TotalPrice;  
  
		entity.TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency;  
  
		entity.TotalTax = inputItem.TotalTax;  
  
		entity.TotalDuty = inputItem.TotalDuty;  
  
		entity.TotalTransportPrice = inputItem.TotalTransportPrice;  
  
		entity.TotalNetPrice = inputItem.TotalNetPrice;  
  
		entity.TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency;  
  
		entity.TotalWithHoldingTaxAmount = inputItem.TotalWithHoldingTaxAmount;  
  
		entity.TotalInsuranceAmount = inputItem.TotalInsuranceAmount;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.AccountingVoucherRef = inputItem.AccountingVoucherRef;  
  
		entity.SLAccountRef = inputItem.SLAccountRef;  
  
		entity.CostCenterRef = inputItem.CostCenterRef;  
  
		entity.AssetAcquisitionPurchaseSLRef = inputItem.AssetAcquisitionPurchaseSLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryPurchaseInvoiceDto Map(InventoryPurchaseInvoice inputItem)
        {
            var dto = new InventoryPurchaseInvoiceDto()
            {
                  
  
		InventoryPurchaseInvoiceID = inputItem.InventoryPurchaseInvoiceID,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		Number = inputItem.Number,  
  
		InvoiceNumber = inputItem.InvoiceNumber,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalTransportPrice = inputItem.TotalTransportPrice,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		TotalWithHoldingTaxAmount = inputItem.TotalWithHoldingTaxAmount,  
  
		TotalInsuranceAmount = inputItem.TotalInsuranceAmount,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Type = inputItem.Type,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		AssetAcquisitionPurchaseSLRef = inputItem.AssetAcquisitionPurchaseSLRef, 
            };
            return dto;
        }

        public static List<InventoryPurchaseInvoiceDto> Map(ICollection<InventoryPurchaseInvoice> entities)
        {
            var dtos = new List<InventoryPurchaseInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryPurchaseInvoiceDto()
                {
                      
  
		InventoryPurchaseInvoiceID = inputItem.InventoryPurchaseInvoiceID,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		Number = inputItem.Number,  
  
		InvoiceNumber = inputItem.InvoiceNumber,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalTransportPrice = inputItem.TotalTransportPrice,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		TotalWithHoldingTaxAmount = inputItem.TotalWithHoldingTaxAmount,  
  
		TotalInsuranceAmount = inputItem.TotalInsuranceAmount,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Type = inputItem.Type,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		AssetAcquisitionPurchaseSLRef = inputItem.AssetAcquisitionPurchaseSLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InventoryPurchaseInvoiceItem Map(AddInventoryPurchaseInvoiceItemCommand inputItem)
        {
            var entity = new InventoryPurchaseInvoiceItem() {
                  
  
		InventoryPurchaseInvoiceItemID = inputItem.InventoryPurchaseInvoiceItemID,  
  
		InventoryPurchaseInvoiceRef = inputItem.InventoryPurchaseInvoiceRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		RemainingQuantity = inputItem.RemainingQuantity,  
  
		RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrentcy = inputItem.DiscountInBaseCurrentcy,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		TransportPrice = inputItem.TransportPrice,  
  
		TransportPriceInBaseCurrency = inputItem.TransportPriceInBaseCurrency,  
  
		TransportTax = inputItem.TransportTax,  
  
		TransportTaxInBaseCurrency = inputItem.TransportTaxInBaseCurrency,  
  
		TransportDuty = inputItem.TransportDuty,  
  
		TransportDutyInBaseCurrency = inputItem.TransportDutyInBaseCurrency,  
  
		TransportDescription = inputItem.TransportDescription,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		CostServiceAccountSLRef = inputItem.CostServiceAccountSLRef,  
  
		InsuranceAmount = inputItem.InsuranceAmount,  
  
		InsuranceAmountInBaseCurrency = inputItem.InsuranceAmountInBaseCurrency,  
  
		WithHoldingTaxAmount = inputItem.WithHoldingTaxAmount,  
  
		WithHoldingTaxAmountInBaseCurrency = inputItem.WithHoldingTaxAmountInBaseCurrency,  
  
		TracingRef = inputItem.TracingRef,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryPurchaseInvoiceItem Map(InventoryPurchaseInvoiceItem entity ,EditInventoryPurchaseInvoiceItemCommand inputItem)
        {
              
  
		entity.InventoryPurchaseInvoiceItemID = inputItem.InventoryPurchaseInvoiceItemID;  
  
		entity.InventoryPurchaseInvoiceRef = inputItem.InventoryPurchaseInvoiceRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.RemainingQuantity = inputItem.RemainingQuantity;  
  
		entity.RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.FeeInBaseCurrency = inputItem.FeeInBaseCurrency;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrentcy = inputItem.DiscountInBaseCurrentcy;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.TransportPrice = inputItem.TransportPrice;  
  
		entity.TransportPriceInBaseCurrency = inputItem.TransportPriceInBaseCurrency;  
  
		entity.TransportTax = inputItem.TransportTax;  
  
		entity.TransportTaxInBaseCurrency = inputItem.TransportTaxInBaseCurrency;  
  
		entity.TransportDuty = inputItem.TransportDuty;  
  
		entity.TransportDutyInBaseCurrency = inputItem.TransportDutyInBaseCurrency;  
  
		entity.TransportDescription = inputItem.TransportDescription;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.CostServiceAccountSLRef = inputItem.CostServiceAccountSLRef;  
  
		entity.InsuranceAmount = inputItem.InsuranceAmount;  
  
		entity.InsuranceAmountInBaseCurrency = inputItem.InsuranceAmountInBaseCurrency;  
  
		entity.WithHoldingTaxAmount = inputItem.WithHoldingTaxAmount;  
  
		entity.WithHoldingTaxAmountInBaseCurrency = inputItem.WithHoldingTaxAmountInBaseCurrency;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryPurchaseInvoiceItemDto Map(InventoryPurchaseInvoiceItem inputItem)
        {
            var dto = new InventoryPurchaseInvoiceItemDto()
            {
                  
  
		InventoryPurchaseInvoiceItemID = inputItem.InventoryPurchaseInvoiceItemID,  
  
		InventoryPurchaseInvoiceRef = inputItem.InventoryPurchaseInvoiceRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		RemainingQuantity = inputItem.RemainingQuantity,  
  
		RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrentcy = inputItem.DiscountInBaseCurrentcy,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		TransportPrice = inputItem.TransportPrice,  
  
		TransportPriceInBaseCurrency = inputItem.TransportPriceInBaseCurrency,  
  
		TransportTax = inputItem.TransportTax,  
  
		TransportTaxInBaseCurrency = inputItem.TransportTaxInBaseCurrency,  
  
		TransportDuty = inputItem.TransportDuty,  
  
		TransportDutyInBaseCurrency = inputItem.TransportDutyInBaseCurrency,  
  
		TransportDescription = inputItem.TransportDescription,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		CostServiceAccountSLRef = inputItem.CostServiceAccountSLRef,  
  
		InsuranceAmount = inputItem.InsuranceAmount,  
  
		InsuranceAmountInBaseCurrency = inputItem.InsuranceAmountInBaseCurrency,  
  
		WithHoldingTaxAmount = inputItem.WithHoldingTaxAmount,  
  
		WithHoldingTaxAmountInBaseCurrency = inputItem.WithHoldingTaxAmountInBaseCurrency,  
  
		TracingRef = inputItem.TracingRef,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<InventoryPurchaseInvoiceItemDto> Map(ICollection<InventoryPurchaseInvoiceItem> entities)
        {
            var dtos = new List<InventoryPurchaseInvoiceItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryPurchaseInvoiceItemDto()
                {
                      
  
		InventoryPurchaseInvoiceItemID = inputItem.InventoryPurchaseInvoiceItemID,  
  
		InventoryPurchaseInvoiceRef = inputItem.InventoryPurchaseInvoiceRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		RemainingQuantity = inputItem.RemainingQuantity,  
  
		RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrentcy = inputItem.DiscountInBaseCurrentcy,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		TransportPrice = inputItem.TransportPrice,  
  
		TransportPriceInBaseCurrency = inputItem.TransportPriceInBaseCurrency,  
  
		TransportTax = inputItem.TransportTax,  
  
		TransportTaxInBaseCurrency = inputItem.TransportTaxInBaseCurrency,  
  
		TransportDuty = inputItem.TransportDuty,  
  
		TransportDutyInBaseCurrency = inputItem.TransportDutyInBaseCurrency,  
  
		TransportDescription = inputItem.TransportDescription,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		CostServiceAccountSLRef = inputItem.CostServiceAccountSLRef,  
  
		InsuranceAmount = inputItem.InsuranceAmount,  
  
		InsuranceAmountInBaseCurrency = inputItem.InsuranceAmountInBaseCurrency,  
  
		WithHoldingTaxAmount = inputItem.WithHoldingTaxAmount,  
  
		WithHoldingTaxAmountInBaseCurrency = inputItem.WithHoldingTaxAmountInBaseCurrency,  
  
		TracingRef = inputItem.TracingRef,  
  
		NetPrice = inputItem.NetPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InventoryReceipt Map(AddInventoryReceiptCommand inputItem)
        {
            var entity = new InventoryReceipt() {
                  
  
		InventoryReceiptID = inputItem.InventoryReceiptID,  
  
		IsReturn = inputItem.IsReturn,  
  
		Type = inputItem.Type,  
  
		PurchaseType = inputItem.PurchaseType,  
  
		StockRef = inputItem.StockRef,  
  
		DelivererDLRef = inputItem.DelivererDLRef,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		TransportBrokerSLAccountRef = inputItem.TransportBrokerSLAccountRef,  
  
		TransporterDLRef = inputItem.TransporterDLRef,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalTransportPrice = inputItem.TotalTransportPrice,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		BasePurchaseInvoiceRef = inputItem.BasePurchaseInvoiceRef,  
  
		BaseInventoryDeliveryRef = inputItem.BaseInventoryDeliveryRef,  
  
		TotalReturnedPrice = inputItem.TotalReturnedPrice,  
  
		TotalReturnedNetPrice = inputItem.TotalReturnedNetPrice,  
  
		BaseImportPurchaseInvoiceRef = inputItem.BaseImportPurchaseInvoiceRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryReceipt Map(InventoryReceipt entity ,EditInventoryReceiptCommand inputItem)
        {
              
  
		entity.InventoryReceiptID = inputItem.InventoryReceiptID;  
  
		entity.IsReturn = inputItem.IsReturn;  
  
		entity.Type = inputItem.Type;  
  
		entity.PurchaseType = inputItem.PurchaseType;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.DelivererDLRef = inputItem.DelivererDLRef;  
  
		entity.SLAccountRef = inputItem.SLAccountRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.AccountingVoucherRef = inputItem.AccountingVoucherRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.TransportBrokerSLAccountRef = inputItem.TransportBrokerSLAccountRef;  
  
		entity.TransporterDLRef = inputItem.TransporterDLRef;  
  
		entity.TotalPrice = inputItem.TotalPrice;  
  
		entity.TotalTax = inputItem.TotalTax;  
  
		entity.TotalDuty = inputItem.TotalDuty;  
  
		entity.TotalTransportPrice = inputItem.TotalTransportPrice;  
  
		entity.TotalNetPrice = inputItem.TotalNetPrice;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.CreatorForm = inputItem.CreatorForm;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.BasePurchaseInvoiceRef = inputItem.BasePurchaseInvoiceRef;  
  
		entity.BaseInventoryDeliveryRef = inputItem.BaseInventoryDeliveryRef;  
  
		entity.TotalReturnedPrice = inputItem.TotalReturnedPrice;  
  
		entity.TotalReturnedNetPrice = inputItem.TotalReturnedNetPrice;  
  
		entity.BaseImportPurchaseInvoiceRef = inputItem.BaseImportPurchaseInvoiceRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryReceiptDto Map(InventoryReceipt inputItem)
        {
            var dto = new InventoryReceiptDto()
            {
                  
  
		InventoryReceiptID = inputItem.InventoryReceiptID,  
  
		IsReturn = inputItem.IsReturn,  
  
		Type = inputItem.Type,  
  
		PurchaseType = inputItem.PurchaseType,  
  
		StockRef = inputItem.StockRef,  
  
		DelivererDLRef = inputItem.DelivererDLRef,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		TransportBrokerSLAccountRef = inputItem.TransportBrokerSLAccountRef,  
  
		TransporterDLRef = inputItem.TransporterDLRef,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalTransportPrice = inputItem.TotalTransportPrice,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		BasePurchaseInvoiceRef = inputItem.BasePurchaseInvoiceRef,  
  
		BaseInventoryDeliveryRef = inputItem.BaseInventoryDeliveryRef,  
  
		TotalReturnedPrice = inputItem.TotalReturnedPrice,  
  
		TotalReturnedNetPrice = inputItem.TotalReturnedNetPrice,  
  
		BaseImportPurchaseInvoiceRef = inputItem.BaseImportPurchaseInvoiceRef, 
            };
            return dto;
        }

        public static List<InventoryReceiptDto> Map(ICollection<InventoryReceipt> entities)
        {
            var dtos = new List<InventoryReceiptDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryReceiptDto()
                {
                      
  
		InventoryReceiptID = inputItem.InventoryReceiptID,  
  
		IsReturn = inputItem.IsReturn,  
  
		Type = inputItem.Type,  
  
		PurchaseType = inputItem.PurchaseType,  
  
		StockRef = inputItem.StockRef,  
  
		DelivererDLRef = inputItem.DelivererDLRef,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		TransportBrokerSLAccountRef = inputItem.TransportBrokerSLAccountRef,  
  
		TransporterDLRef = inputItem.TransporterDLRef,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalTransportPrice = inputItem.TotalTransportPrice,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		BasePurchaseInvoiceRef = inputItem.BasePurchaseInvoiceRef,  
  
		BaseInventoryDeliveryRef = inputItem.BaseInventoryDeliveryRef,  
  
		TotalReturnedPrice = inputItem.TotalReturnedPrice,  
  
		TotalReturnedNetPrice = inputItem.TotalReturnedNetPrice,  
  
		BaseImportPurchaseInvoiceRef = inputItem.BaseImportPurchaseInvoiceRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InventoryReceiptItem Map(AddInventoryReceiptItemCommand inputItem)
        {
            var entity = new InventoryReceiptItem() {
                  
  
		InventoryReceiptItemID = inputItem.InventoryReceiptItemID,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		IsReturn = inputItem.IsReturn,  
  
		RowNumber = inputItem.RowNumber,  
  
		Base = inputItem.Base,  
  
		ReturnBase = inputItem.ReturnBase,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		RemainingQuantity = inputItem.RemainingQuantity,  
  
		RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		CurrencyValue = inputItem.CurrencyValue,  
  
		Price = inputItem.Price,  
  
		Tax = inputItem.Tax,  
  
		TaxCurrencyValue = inputItem.TaxCurrencyValue,  
  
		Duty = inputItem.Duty,  
  
		DutyCurrencyValue = inputItem.DutyCurrencyValue,  
  
		TransportPrice = inputItem.TransportPrice,  
  
		TransportTax = inputItem.TransportTax,  
  
		TransportDuty = inputItem.TransportDuty,  
  
		TransportDescription = inputItem.TransportDescription,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		BasePurchaseInvoiceItemRef = inputItem.BasePurchaseInvoiceItemRef,  
  
		ParityCheck = inputItem.ParityCheck,  
  
		ProductOrderRef = inputItem.ProductOrderRef,  
  
		InventoryDeliveryItemRef = inputItem.InventoryDeliveryItemRef,  
  
		WeighingRef = inputItem.WeighingRef,  
  
		ReturnedPrice = inputItem.ReturnedPrice,  
  
		Fee = inputItem.Fee,  
  
		NetPrice = inputItem.NetPrice,  
  
		ReturnedFee = inputItem.ReturnedFee,  
  
		ReturnedNetPrice = inputItem.ReturnedNetPrice,  
  
		OtherCostsAmount = inputItem.OtherCostsAmount,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		ImportOrderFinalFee = inputItem.ImportOrderFinalFee,  
  
		BaseImportPurchaseInvoiceItemRef = inputItem.BaseImportPurchaseInvoiceItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryReceiptItem Map(InventoryReceiptItem entity ,EditInventoryReceiptItemCommand inputItem)
        {
              
  
		entity.InventoryReceiptItemID = inputItem.InventoryReceiptItemID;  
  
		entity.InventoryReceiptRef = inputItem.InventoryReceiptRef;  
  
		entity.IsReturn = inputItem.IsReturn;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.Base = inputItem.Base;  
  
		entity.ReturnBase = inputItem.ReturnBase;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.RemainingQuantity = inputItem.RemainingQuantity;  
  
		entity.RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.CurrencyValue = inputItem.CurrencyValue;  
  
		entity.Price = inputItem.Price;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxCurrencyValue = inputItem.TaxCurrencyValue;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyCurrencyValue = inputItem.DutyCurrencyValue;  
  
		entity.TransportPrice = inputItem.TransportPrice;  
  
		entity.TransportTax = inputItem.TransportTax;  
  
		entity.TransportDuty = inputItem.TransportDuty;  
  
		entity.TransportDescription = inputItem.TransportDescription;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.BasePurchaseInvoiceItemRef = inputItem.BasePurchaseInvoiceItemRef;  
  
		entity.ParityCheck = inputItem.ParityCheck;  
  
		entity.ProductOrderRef = inputItem.ProductOrderRef;  
  
		entity.InventoryDeliveryItemRef = inputItem.InventoryDeliveryItemRef;  
  
		entity.WeighingRef = inputItem.WeighingRef;  
  
		entity.ReturnedPrice = inputItem.ReturnedPrice;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.ReturnedFee = inputItem.ReturnedFee;  
  
		entity.ReturnedNetPrice = inputItem.ReturnedNetPrice;  
  
		entity.OtherCostsAmount = inputItem.OtherCostsAmount;  
  
		entity.ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef;  
  
		entity.ImportOrderFinalFee = inputItem.ImportOrderFinalFee;  
  
		entity.BaseImportPurchaseInvoiceItemRef = inputItem.BaseImportPurchaseInvoiceItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryReceiptItemDto Map(InventoryReceiptItem inputItem)
        {
            var dto = new InventoryReceiptItemDto()
            {
                  
  
		InventoryReceiptItemID = inputItem.InventoryReceiptItemID,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		IsReturn = inputItem.IsReturn,  
  
		RowNumber = inputItem.RowNumber,  
  
		Base = inputItem.Base,  
  
		ReturnBase = inputItem.ReturnBase,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		RemainingQuantity = inputItem.RemainingQuantity,  
  
		RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		CurrencyValue = inputItem.CurrencyValue,  
  
		Price = inputItem.Price,  
  
		Tax = inputItem.Tax,  
  
		TaxCurrencyValue = inputItem.TaxCurrencyValue,  
  
		Duty = inputItem.Duty,  
  
		DutyCurrencyValue = inputItem.DutyCurrencyValue,  
  
		TransportPrice = inputItem.TransportPrice,  
  
		TransportTax = inputItem.TransportTax,  
  
		TransportDuty = inputItem.TransportDuty,  
  
		TransportDescription = inputItem.TransportDescription,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		BasePurchaseInvoiceItemRef = inputItem.BasePurchaseInvoiceItemRef,  
  
		ParityCheck = inputItem.ParityCheck,  
  
		ProductOrderRef = inputItem.ProductOrderRef,  
  
		InventoryDeliveryItemRef = inputItem.InventoryDeliveryItemRef,  
  
		WeighingRef = inputItem.WeighingRef,  
  
		ReturnedPrice = inputItem.ReturnedPrice,  
  
		Fee = inputItem.Fee,  
  
		NetPrice = inputItem.NetPrice,  
  
		ReturnedFee = inputItem.ReturnedFee,  
  
		ReturnedNetPrice = inputItem.ReturnedNetPrice,  
  
		OtherCostsAmount = inputItem.OtherCostsAmount,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		ImportOrderFinalFee = inputItem.ImportOrderFinalFee,  
  
		BaseImportPurchaseInvoiceItemRef = inputItem.BaseImportPurchaseInvoiceItemRef, 
            };
            return dto;
        }

        public static List<InventoryReceiptItemDto> Map(ICollection<InventoryReceiptItem> entities)
        {
            var dtos = new List<InventoryReceiptItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryReceiptItemDto()
                {
                      
  
		InventoryReceiptItemID = inputItem.InventoryReceiptItemID,  
  
		InventoryReceiptRef = inputItem.InventoryReceiptRef,  
  
		IsReturn = inputItem.IsReturn,  
  
		RowNumber = inputItem.RowNumber,  
  
		Base = inputItem.Base,  
  
		ReturnBase = inputItem.ReturnBase,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		RemainingQuantity = inputItem.RemainingQuantity,  
  
		RemainingSecondaryQuantity = inputItem.RemainingSecondaryQuantity,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		CurrencyValue = inputItem.CurrencyValue,  
  
		Price = inputItem.Price,  
  
		Tax = inputItem.Tax,  
  
		TaxCurrencyValue = inputItem.TaxCurrencyValue,  
  
		Duty = inputItem.Duty,  
  
		DutyCurrencyValue = inputItem.DutyCurrencyValue,  
  
		TransportPrice = inputItem.TransportPrice,  
  
		TransportTax = inputItem.TransportTax,  
  
		TransportDuty = inputItem.TransportDuty,  
  
		TransportDescription = inputItem.TransportDescription,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		BasePurchaseInvoiceItemRef = inputItem.BasePurchaseInvoiceItemRef,  
  
		ParityCheck = inputItem.ParityCheck,  
  
		ProductOrderRef = inputItem.ProductOrderRef,  
  
		InventoryDeliveryItemRef = inputItem.InventoryDeliveryItemRef,  
  
		WeighingRef = inputItem.WeighingRef,  
  
		ReturnedPrice = inputItem.ReturnedPrice,  
  
		Fee = inputItem.Fee,  
  
		NetPrice = inputItem.NetPrice,  
  
		ReturnedFee = inputItem.ReturnedFee,  
  
		ReturnedNetPrice = inputItem.ReturnedNetPrice,  
  
		OtherCostsAmount = inputItem.OtherCostsAmount,  
  
		ServiceInventoryPurchaseInvoiceRef = inputItem.ServiceInventoryPurchaseInvoiceRef,  
  
		ImportOrderFinalFee = inputItem.ImportOrderFinalFee,  
  
		BaseImportPurchaseInvoiceItemRef = inputItem.BaseImportPurchaseInvoiceItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InventoryWeighbridge Map(AddInventoryWeighbridgeCommand inputItem)
        {
            var entity = new InventoryWeighbridge() {
                  
  
		InventoryWeighbridgeID = inputItem.InventoryWeighbridgeID,  
  
		Model = inputItem.Model,  
  
		BaudRate = inputItem.BaudRate,  
  
		DataBits = inputItem.DataBits,  
  
		StopBits = inputItem.StopBits,  
  
		Parity = inputItem.Parity,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryWeighbridge Map(InventoryWeighbridge entity ,EditInventoryWeighbridgeCommand inputItem)
        {
              
  
		entity.InventoryWeighbridgeID = inputItem.InventoryWeighbridgeID;  
  
		entity.Model = inputItem.Model;  
  
		entity.BaudRate = inputItem.BaudRate;  
  
		entity.DataBits = inputItem.DataBits;  
  
		entity.StopBits = inputItem.StopBits;  
  
		entity.Parity = inputItem.Parity;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryWeighbridgeDto Map(InventoryWeighbridge inputItem)
        {
            var dto = new InventoryWeighbridgeDto()
            {
                  
  
		InventoryWeighbridgeID = inputItem.InventoryWeighbridgeID,  
  
		Model = inputItem.Model,  
  
		BaudRate = inputItem.BaudRate,  
  
		DataBits = inputItem.DataBits,  
  
		StopBits = inputItem.StopBits,  
  
		Parity = inputItem.Parity,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<InventoryWeighbridgeDto> Map(ICollection<InventoryWeighbridge> entities)
        {
            var dtos = new List<InventoryWeighbridgeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryWeighbridgeDto()
                {
                      
  
		InventoryWeighbridgeID = inputItem.InventoryWeighbridgeID,  
  
		Model = inputItem.Model,  
  
		BaudRate = inputItem.BaudRate,  
  
		DataBits = inputItem.DataBits,  
  
		StopBits = inputItem.StopBits,  
  
		Parity = inputItem.Parity,  
  
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
        
        public static InventoryWeighbridgeConfiguration Map(AddInventoryWeighbridgeConfigurationCommand inputItem)
        {
            var entity = new InventoryWeighbridgeConfiguration() {
                  
  
		InventoryWeighbridgeConfigurationID = inputItem.InventoryWeighbridgeConfigurationID,  
  
		InventoryWeighbridgeRef = inputItem.InventoryWeighbridgeRef,  
  
		Model = inputItem.Model,  
  
		Port = inputItem.Port,  
  
		UnitRef = inputItem.UnitRef,  
  
		BaudRate = inputItem.BaudRate,  
  
		DataBits = inputItem.DataBits,  
  
		StopBits = inputItem.StopBits,  
  
		Parity = inputItem.Parity,  
  
		AutoClose = inputItem.AutoClose,  
  
		StabilityCheckTime = inputItem.StabilityCheckTime,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryWeighbridgeConfiguration Map(InventoryWeighbridgeConfiguration entity ,EditInventoryWeighbridgeConfigurationCommand inputItem)
        {
              
  
		entity.InventoryWeighbridgeConfigurationID = inputItem.InventoryWeighbridgeConfigurationID;  
  
		entity.InventoryWeighbridgeRef = inputItem.InventoryWeighbridgeRef;  
  
		entity.Model = inputItem.Model;  
  
		entity.Port = inputItem.Port;  
  
		entity.UnitRef = inputItem.UnitRef;  
  
		entity.BaudRate = inputItem.BaudRate;  
  
		entity.DataBits = inputItem.DataBits;  
  
		entity.StopBits = inputItem.StopBits;  
  
		entity.Parity = inputItem.Parity;  
  
		entity.AutoClose = inputItem.AutoClose;  
  
		entity.StabilityCheckTime = inputItem.StabilityCheckTime;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryWeighbridgeConfigurationDto Map(InventoryWeighbridgeConfiguration inputItem)
        {
            var dto = new InventoryWeighbridgeConfigurationDto()
            {
                  
  
		InventoryWeighbridgeConfigurationID = inputItem.InventoryWeighbridgeConfigurationID,  
  
		InventoryWeighbridgeRef = inputItem.InventoryWeighbridgeRef,  
  
		Model = inputItem.Model,  
  
		Port = inputItem.Port,  
  
		UnitRef = inputItem.UnitRef,  
  
		BaudRate = inputItem.BaudRate,  
  
		DataBits = inputItem.DataBits,  
  
		StopBits = inputItem.StopBits,  
  
		Parity = inputItem.Parity,  
  
		AutoClose = inputItem.AutoClose,  
  
		StabilityCheckTime = inputItem.StabilityCheckTime,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<InventoryWeighbridgeConfigurationDto> Map(ICollection<InventoryWeighbridgeConfiguration> entities)
        {
            var dtos = new List<InventoryWeighbridgeConfigurationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryWeighbridgeConfigurationDto()
                {
                      
  
		InventoryWeighbridgeConfigurationID = inputItem.InventoryWeighbridgeConfigurationID,  
  
		InventoryWeighbridgeRef = inputItem.InventoryWeighbridgeRef,  
  
		Model = inputItem.Model,  
  
		Port = inputItem.Port,  
  
		UnitRef = inputItem.UnitRef,  
  
		BaudRate = inputItem.BaudRate,  
  
		DataBits = inputItem.DataBits,  
  
		StopBits = inputItem.StopBits,  
  
		Parity = inputItem.Parity,  
  
		AutoClose = inputItem.AutoClose,  
  
		StabilityCheckTime = inputItem.StabilityCheckTime,  
  
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
        
        public static InventoryWeighing Map(AddInventoryWeighingCommand inputItem)
        {
            var entity = new InventoryWeighing() {
                  
  
		InventoryWeighingID = inputItem.InventoryWeighingID,  
  
		WeighbridgeConfigurationRef = inputItem.WeighbridgeConfigurationRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		ItemRef = inputItem.ItemRef,  
  
		InputTime = inputItem.InputTime,  
  
		OutputTime = inputItem.OutputTime,  
  
		InputQuantity = inputItem.InputQuantity,  
  
		OutputQuantity = inputItem.OutputQuantity,  
  
		WastePercent = inputItem.WastePercent,  
  
		Driver = inputItem.Driver,  
  
		DrivingLicenseNumber = inputItem.DrivingLicenseNumber,  
  
		VehicleType = inputItem.VehicleType,  
  
		VehicleNumber = inputItem.VehicleNumber,  
  
		WayBillNumber = inputItem.WayBillNumber,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		State = inputItem.State,  
  
		IsManual = inputItem.IsManual,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		UnitRefConf = inputItem.UnitRefConf,  
  
		IsPrimaryUnit = inputItem.IsPrimaryUnit,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		VendorDLRef = inputItem.VendorDLRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InventoryWeighing Map(InventoryWeighing entity ,EditInventoryWeighingCommand inputItem)
        {
              
  
		entity.InventoryWeighingID = inputItem.InventoryWeighingID;  
  
		entity.WeighbridgeConfigurationRef = inputItem.WeighbridgeConfigurationRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.Type = inputItem.Type;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.InputTime = inputItem.InputTime;  
  
		entity.OutputTime = inputItem.OutputTime;  
  
		entity.InputQuantity = inputItem.InputQuantity;  
  
		entity.OutputQuantity = inputItem.OutputQuantity;  
  
		entity.WastePercent = inputItem.WastePercent;  
  
		entity.Driver = inputItem.Driver;  
  
		entity.DrivingLicenseNumber = inputItem.DrivingLicenseNumber;  
  
		entity.VehicleType = inputItem.VehicleType;  
  
		entity.VehicleNumber = inputItem.VehicleNumber;  
  
		entity.WayBillNumber = inputItem.WayBillNumber;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.State = inputItem.State;  
  
		entity.IsManual = inputItem.IsManual;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.UnitRefConf = inputItem.UnitRefConf;  
  
		entity.IsPrimaryUnit = inputItem.IsPrimaryUnit;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.VendorDLRef = inputItem.VendorDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InventoryWeighingDto Map(InventoryWeighing inputItem)
        {
            var dto = new InventoryWeighingDto()
            {
                  
  
		InventoryWeighingID = inputItem.InventoryWeighingID,  
  
		WeighbridgeConfigurationRef = inputItem.WeighbridgeConfigurationRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		ItemRef = inputItem.ItemRef,  
  
		InputTime = inputItem.InputTime,  
  
		OutputTime = inputItem.OutputTime,  
  
		InputQuantity = inputItem.InputQuantity,  
  
		OutputQuantity = inputItem.OutputQuantity,  
  
		WastePercent = inputItem.WastePercent,  
  
		Driver = inputItem.Driver,  
  
		DrivingLicenseNumber = inputItem.DrivingLicenseNumber,  
  
		VehicleType = inputItem.VehicleType,  
  
		VehicleNumber = inputItem.VehicleNumber,  
  
		WayBillNumber = inputItem.WayBillNumber,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		State = inputItem.State,  
  
		IsManual = inputItem.IsManual,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		UnitRefConf = inputItem.UnitRefConf,  
  
		IsPrimaryUnit = inputItem.IsPrimaryUnit,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		VendorDLRef = inputItem.VendorDLRef, 
            };
            return dto;
        }

        public static List<InventoryWeighingDto> Map(ICollection<InventoryWeighing> entities)
        {
            var dtos = new List<InventoryWeighingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InventoryWeighingDto()
                {
                      
  
		InventoryWeighingID = inputItem.InventoryWeighingID,  
  
		WeighbridgeConfigurationRef = inputItem.WeighbridgeConfigurationRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		ItemRef = inputItem.ItemRef,  
  
		InputTime = inputItem.InputTime,  
  
		OutputTime = inputItem.OutputTime,  
  
		InputQuantity = inputItem.InputQuantity,  
  
		OutputQuantity = inputItem.OutputQuantity,  
  
		WastePercent = inputItem.WastePercent,  
  
		Driver = inputItem.Driver,  
  
		DrivingLicenseNumber = inputItem.DrivingLicenseNumber,  
  
		VehicleType = inputItem.VehicleType,  
  
		VehicleNumber = inputItem.VehicleNumber,  
  
		WayBillNumber = inputItem.WayBillNumber,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		State = inputItem.State,  
  
		IsManual = inputItem.IsManual,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		UnitRefConf = inputItem.UnitRefConf,  
  
		IsPrimaryUnit = inputItem.IsPrimaryUnit,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		VendorDLRef = inputItem.VendorDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Item Map(AddItemCommand inputItem)
        {
            var entity = new Item() {
                  
  
		ItemID = inputItem.ItemID,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		BarCode = inputItem.BarCode,  
  
		UnitRef = inputItem.UnitRef,  
  
		SecondaryUnitRef = inputItem.SecondaryUnitRef,  
  
		SaleUnitRef = inputItem.SaleUnitRef,  
  
		IsUnitRatioConstant = inputItem.IsUnitRatioConstant,  
  
		UnitsRatio = inputItem.UnitsRatio,  
  
		MinimumAmount = inputItem.MinimumAmount,  
  
		MaximumAmount = inputItem.MaximumAmount,  
  
		CanHaveTracing = inputItem.CanHaveTracing,  
  
		TracingCategoryRef = inputItem.TracingCategoryRef,  
  
		IsPricingBasedOnTracing = inputItem.IsPricingBasedOnTracing,  
  
		TaxExempt = inputItem.TaxExempt,  
  
		TaxExemptPurchase = inputItem.TaxExemptPurchase,  
  
		Sellable = inputItem.Sellable,  
  
		DefaultStockRef = inputItem.DefaultStockRef,  
  
		PurchaseGroupRef = inputItem.PurchaseGroupRef,  
  
		SaleGroupRef = inputItem.SaleGroupRef,  
  
		CompoundBarcodeRef = inputItem.CompoundBarcodeRef,  
  
		ItemCategoryRef = inputItem.ItemCategoryRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		IsActive = inputItem.IsActive,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		TaxRate = inputItem.TaxRate,  
  
		DutyRate = inputItem.DutyRate,  
  
		CodingGroupRef = inputItem.CodingGroupRef,  
  
		SerialTracking = inputItem.SerialTracking,  
  
		Weight = inputItem.Weight,  
  
		Volume = inputItem.Volume,  
  
		IranCode = inputItem.IranCode, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Item Map(Item entity ,EditItemCommand inputItem)
        {
              
  
		entity.ItemID = inputItem.ItemID;  
  
		entity.Type = inputItem.Type;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.BarCode = inputItem.BarCode;  
  
		entity.UnitRef = inputItem.UnitRef;  
  
		entity.SecondaryUnitRef = inputItem.SecondaryUnitRef;  
  
		entity.SaleUnitRef = inputItem.SaleUnitRef;  
  
		entity.IsUnitRatioConstant = inputItem.IsUnitRatioConstant;  
  
		entity.UnitsRatio = inputItem.UnitsRatio;  
  
		entity.MinimumAmount = inputItem.MinimumAmount;  
  
		entity.MaximumAmount = inputItem.MaximumAmount;  
  
		entity.CanHaveTracing = inputItem.CanHaveTracing;  
  
		entity.TracingCategoryRef = inputItem.TracingCategoryRef;  
  
		entity.IsPricingBasedOnTracing = inputItem.IsPricingBasedOnTracing;  
  
		entity.TaxExempt = inputItem.TaxExempt;  
  
		entity.TaxExemptPurchase = inputItem.TaxExemptPurchase;  
  
		entity.Sellable = inputItem.Sellable;  
  
		entity.DefaultStockRef = inputItem.DefaultStockRef;  
  
		entity.PurchaseGroupRef = inputItem.PurchaseGroupRef;  
  
		entity.SaleGroupRef = inputItem.SaleGroupRef;  
  
		entity.CompoundBarcodeRef = inputItem.CompoundBarcodeRef;  
  
		entity.ItemCategoryRef = inputItem.ItemCategoryRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.AccountSLRef = inputItem.AccountSLRef;  
  
		entity.TaxRate = inputItem.TaxRate;  
  
		entity.DutyRate = inputItem.DutyRate;  
  
		entity.CodingGroupRef = inputItem.CodingGroupRef;  
  
		entity.SerialTracking = inputItem.SerialTracking;  
  
		entity.Weight = inputItem.Weight;  
  
		entity.Volume = inputItem.Volume;  
  
		entity.IranCode = inputItem.IranCode; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ItemDto Map(Item inputItem)
        {
            var dto = new ItemDto()
            {
                  
  
		ItemID = inputItem.ItemID,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		BarCode = inputItem.BarCode,  
  
		UnitRef = inputItem.UnitRef,  
  
		SecondaryUnitRef = inputItem.SecondaryUnitRef,  
  
		SaleUnitRef = inputItem.SaleUnitRef,  
  
		IsUnitRatioConstant = inputItem.IsUnitRatioConstant,  
  
		UnitsRatio = inputItem.UnitsRatio,  
  
		MinimumAmount = inputItem.MinimumAmount,  
  
		MaximumAmount = inputItem.MaximumAmount,  
  
		CanHaveTracing = inputItem.CanHaveTracing,  
  
		TracingCategoryRef = inputItem.TracingCategoryRef,  
  
		IsPricingBasedOnTracing = inputItem.IsPricingBasedOnTracing,  
  
		TaxExempt = inputItem.TaxExempt,  
  
		TaxExemptPurchase = inputItem.TaxExemptPurchase,  
  
		Sellable = inputItem.Sellable,  
  
		DefaultStockRef = inputItem.DefaultStockRef,  
  
		PurchaseGroupRef = inputItem.PurchaseGroupRef,  
  
		SaleGroupRef = inputItem.SaleGroupRef,  
  
		CompoundBarcodeRef = inputItem.CompoundBarcodeRef,  
  
		ItemCategoryRef = inputItem.ItemCategoryRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		IsActive = inputItem.IsActive,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		TaxRate = inputItem.TaxRate,  
  
		DutyRate = inputItem.DutyRate,  
  
		CodingGroupRef = inputItem.CodingGroupRef,  
  
		SerialTracking = inputItem.SerialTracking,  
  
		Weight = inputItem.Weight,  
  
		Volume = inputItem.Volume,  
  
		IranCode = inputItem.IranCode, 
            };
            return dto;
        }

        public static List<ItemDto> Map(ICollection<Item> entities)
        {
            var dtos = new List<ItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ItemDto()
                {
                      
  
		ItemID = inputItem.ItemID,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		BarCode = inputItem.BarCode,  
  
		UnitRef = inputItem.UnitRef,  
  
		SecondaryUnitRef = inputItem.SecondaryUnitRef,  
  
		SaleUnitRef = inputItem.SaleUnitRef,  
  
		IsUnitRatioConstant = inputItem.IsUnitRatioConstant,  
  
		UnitsRatio = inputItem.UnitsRatio,  
  
		MinimumAmount = inputItem.MinimumAmount,  
  
		MaximumAmount = inputItem.MaximumAmount,  
  
		CanHaveTracing = inputItem.CanHaveTracing,  
  
		TracingCategoryRef = inputItem.TracingCategoryRef,  
  
		IsPricingBasedOnTracing = inputItem.IsPricingBasedOnTracing,  
  
		TaxExempt = inputItem.TaxExempt,  
  
		TaxExemptPurchase = inputItem.TaxExemptPurchase,  
  
		Sellable = inputItem.Sellable,  
  
		DefaultStockRef = inputItem.DefaultStockRef,  
  
		PurchaseGroupRef = inputItem.PurchaseGroupRef,  
  
		SaleGroupRef = inputItem.SaleGroupRef,  
  
		CompoundBarcodeRef = inputItem.CompoundBarcodeRef,  
  
		ItemCategoryRef = inputItem.ItemCategoryRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		IsActive = inputItem.IsActive,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		TaxRate = inputItem.TaxRate,  
  
		DutyRate = inputItem.DutyRate,  
  
		CodingGroupRef = inputItem.CodingGroupRef,  
  
		SerialTracking = inputItem.SerialTracking,  
  
		Weight = inputItem.Weight,  
  
		Volume = inputItem.Volume,  
  
		IranCode = inputItem.IranCode, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ItemCategory Map(AddItemCategoryCommand inputItem)
        {
            var entity = new ItemCategory() {
                  
  
		ItemCategoryID = inputItem.ItemCategoryID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ItemCategory Map(ItemCategory entity ,EditItemCategoryCommand inputItem)
        {
              
  
		entity.ItemCategoryID = inputItem.ItemCategoryID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ItemCategoryDto Map(ItemCategory inputItem)
        {
            var dto = new ItemCategoryDto()
            {
                  
  
		ItemCategoryID = inputItem.ItemCategoryID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<ItemCategoryDto> Map(ICollection<ItemCategory> entities)
        {
            var dtos = new List<ItemCategoryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ItemCategoryDto()
                {
                      
  
		ItemCategoryID = inputItem.ItemCategoryID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ItemImage Map(AddItemImageCommand inputItem)
        {
            var entity = new ItemImage() {
                  
  
		ItemImageID = inputItem.ItemImageID,  
  
		ItemRef = inputItem.ItemRef,  
  
		Image = inputItem.Image,  
  
		Thumbnail = inputItem.Thumbnail,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ItemImage Map(ItemImage entity ,EditItemImageCommand inputItem)
        {
              
  
		entity.ItemImageID = inputItem.ItemImageID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.Image = inputItem.Image;  
  
		entity.Thumbnail = inputItem.Thumbnail;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ItemImageDto Map(ItemImage inputItem)
        {
            var dto = new ItemImageDto()
            {
                  
  
		ItemImageID = inputItem.ItemImageID,  
  
		ItemRef = inputItem.ItemRef,  
  
		Image = inputItem.Image,  
  
		Thumbnail = inputItem.Thumbnail,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<ItemImageDto> Map(ICollection<ItemImage> entities)
        {
            var dtos = new List<ItemImageDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ItemImageDto()
                {
                      
  
		ItemImageID = inputItem.ItemImageID,  
  
		ItemRef = inputItem.ItemRef,  
  
		Image = inputItem.Image,  
  
		Thumbnail = inputItem.Thumbnail,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ItemPropertyAmount Map(AddItemPropertyAmountCommand inputItem)
        {
            var entity = new ItemPropertyAmount() {
                  
  
		ItemPropertyAmountID = inputItem.ItemPropertyAmountID,  
  
		ItemRef = inputItem.ItemRef,  
  
		PropertyAmount1 = inputItem.PropertyAmount1,  
  
		PropertyAmount2 = inputItem.PropertyAmount2,  
  
		PropertyAmount3 = inputItem.PropertyAmount3,  
  
		PropertyAmount4 = inputItem.PropertyAmount4,  
  
		PropertyAmount5 = inputItem.PropertyAmount5,  
  
		PropertyAmount6 = inputItem.PropertyAmount6,  
  
		PropertyAmount7 = inputItem.PropertyAmount7,  
  
		PropertyAmount8 = inputItem.PropertyAmount8,  
  
		PropertyAmount9 = inputItem.PropertyAmount9,  
  
		PropertyAmount10 = inputItem.PropertyAmount10, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ItemPropertyAmount Map(ItemPropertyAmount entity ,EditItemPropertyAmountCommand inputItem)
        {
              
  
		entity.ItemPropertyAmountID = inputItem.ItemPropertyAmountID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.PropertyAmount1 = inputItem.PropertyAmount1;  
  
		entity.PropertyAmount2 = inputItem.PropertyAmount2;  
  
		entity.PropertyAmount3 = inputItem.PropertyAmount3;  
  
		entity.PropertyAmount4 = inputItem.PropertyAmount4;  
  
		entity.PropertyAmount5 = inputItem.PropertyAmount5;  
  
		entity.PropertyAmount6 = inputItem.PropertyAmount6;  
  
		entity.PropertyAmount7 = inputItem.PropertyAmount7;  
  
		entity.PropertyAmount8 = inputItem.PropertyAmount8;  
  
		entity.PropertyAmount9 = inputItem.PropertyAmount9;  
  
		entity.PropertyAmount10 = inputItem.PropertyAmount10; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ItemPropertyAmountDto Map(ItemPropertyAmount inputItem)
        {
            var dto = new ItemPropertyAmountDto()
            {
                  
  
		ItemPropertyAmountID = inputItem.ItemPropertyAmountID,  
  
		ItemRef = inputItem.ItemRef,  
  
		PropertyAmount1 = inputItem.PropertyAmount1,  
  
		PropertyAmount2 = inputItem.PropertyAmount2,  
  
		PropertyAmount3 = inputItem.PropertyAmount3,  
  
		PropertyAmount4 = inputItem.PropertyAmount4,  
  
		PropertyAmount5 = inputItem.PropertyAmount5,  
  
		PropertyAmount6 = inputItem.PropertyAmount6,  
  
		PropertyAmount7 = inputItem.PropertyAmount7,  
  
		PropertyAmount8 = inputItem.PropertyAmount8,  
  
		PropertyAmount9 = inputItem.PropertyAmount9,  
  
		PropertyAmount10 = inputItem.PropertyAmount10, 
            };
            return dto;
        }

        public static List<ItemPropertyAmountDto> Map(ICollection<ItemPropertyAmount> entities)
        {
            var dtos = new List<ItemPropertyAmountDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ItemPropertyAmountDto()
                {
                      
  
		ItemPropertyAmountID = inputItem.ItemPropertyAmountID,  
  
		ItemRef = inputItem.ItemRef,  
  
		PropertyAmount1 = inputItem.PropertyAmount1,  
  
		PropertyAmount2 = inputItem.PropertyAmount2,  
  
		PropertyAmount3 = inputItem.PropertyAmount3,  
  
		PropertyAmount4 = inputItem.PropertyAmount4,  
  
		PropertyAmount5 = inputItem.PropertyAmount5,  
  
		PropertyAmount6 = inputItem.PropertyAmount6,  
  
		PropertyAmount7 = inputItem.PropertyAmount7,  
  
		PropertyAmount8 = inputItem.PropertyAmount8,  
  
		PropertyAmount9 = inputItem.PropertyAmount9,  
  
		PropertyAmount10 = inputItem.PropertyAmount10, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ItemStock Map(AddItemStockCommand inputItem)
        {
            var entity = new ItemStock() {
                  
  
		ItemStockID = inputItem.ItemStockID,  
  
		ItemRef = inputItem.ItemRef,  
  
		StockRef = inputItem.StockRef,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ItemStock Map(ItemStock entity ,EditItemStockCommand inputItem)
        {
              
  
		entity.ItemStockID = inputItem.ItemStockID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ItemStockDto Map(ItemStock inputItem)
        {
            var dto = new ItemStockDto()
            {
                  
  
		ItemStockID = inputItem.ItemStockID,  
  
		ItemRef = inputItem.ItemRef,  
  
		StockRef = inputItem.StockRef,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<ItemStockDto> Map(ICollection<ItemStock> entities)
        {
            var dtos = new List<ItemStockDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ItemStockDto()
                {
                      
  
		ItemStockID = inputItem.ItemStockID,  
  
		ItemRef = inputItem.ItemRef,  
  
		StockRef = inputItem.StockRef,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ItemStockSummary Map(AddItemStockSummaryCommand inputItem)
        {
            var entity = new ItemStockSummary() {
                  
  
		ItemStockSummaryID = inputItem.ItemStockSummaryID,  
  
		StockRef = inputItem.StockRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Order = inputItem.Order,  
  
		UnitRef = inputItem.UnitRef,  
  
		InputQuantity = inputItem.InputQuantity,  
  
		OutputQuantity = inputItem.OutputQuantity,  
  
		Quantity = inputItem.Quantity,  
  
		SaleQuantity = inputItem.SaleQuantity,  
  
		SaleWithReserveQuantity = inputItem.SaleWithReserveQuantity,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ItemStockSummary Map(ItemStockSummary entity ,EditItemStockSummaryCommand inputItem)
        {
              
  
		entity.ItemStockSummaryID = inputItem.ItemStockSummaryID;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Order = inputItem.Order;  
  
		entity.UnitRef = inputItem.UnitRef;  
  
		entity.InputQuantity = inputItem.InputQuantity;  
  
		entity.OutputQuantity = inputItem.OutputQuantity;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SaleQuantity = inputItem.SaleQuantity;  
  
		entity.SaleWithReserveQuantity = inputItem.SaleWithReserveQuantity;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ItemStockSummaryDto Map(ItemStockSummary inputItem)
        {
            var dto = new ItemStockSummaryDto()
            {
                  
  
		ItemStockSummaryID = inputItem.ItemStockSummaryID,  
  
		StockRef = inputItem.StockRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Order = inputItem.Order,  
  
		UnitRef = inputItem.UnitRef,  
  
		InputQuantity = inputItem.InputQuantity,  
  
		OutputQuantity = inputItem.OutputQuantity,  
  
		Quantity = inputItem.Quantity,  
  
		SaleQuantity = inputItem.SaleQuantity,  
  
		SaleWithReserveQuantity = inputItem.SaleWithReserveQuantity,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
            };
            return dto;
        }

        public static List<ItemStockSummaryDto> Map(ICollection<ItemStockSummary> entities)
        {
            var dtos = new List<ItemStockSummaryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ItemStockSummaryDto()
                {
                      
  
		ItemStockSummaryID = inputItem.ItemStockSummaryID,  
  
		StockRef = inputItem.StockRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Order = inputItem.Order,  
  
		UnitRef = inputItem.UnitRef,  
  
		InputQuantity = inputItem.InputQuantity,  
  
		OutputQuantity = inputItem.OutputQuantity,  
  
		Quantity = inputItem.Quantity,  
  
		SaleQuantity = inputItem.SaleQuantity,  
  
		SaleWithReserveQuantity = inputItem.SaleWithReserveQuantity,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PricingItemPrice Map(AddPricingItemPriceCommand inputItem)
        {
            var entity = new PricingItemPrice() {
                  
  
		PricingItemPriceID = inputItem.PricingItemPriceID,  
  
		InventoryPricingRef = inputItem.InventoryPricingRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PricingItemPrice Map(PricingItemPrice entity ,EditPricingItemPriceCommand inputItem)
        {
              
  
		entity.PricingItemPriceID = inputItem.PricingItemPriceID;  
  
		entity.InventoryPricingRef = inputItem.InventoryPricingRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.TotalPrice = inputItem.TotalPrice;  
  
		entity.Date = inputItem.Date;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PricingItemPriceDto Map(PricingItemPrice inputItem)
        {
            var dto = new PricingItemPriceDto()
            {
                  
  
		PricingItemPriceID = inputItem.PricingItemPriceID,  
  
		InventoryPricingRef = inputItem.InventoryPricingRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PricingItemPriceDto> Map(ICollection<PricingItemPrice> entities)
        {
            var dtos = new List<PricingItemPriceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PricingItemPriceDto()
                {
                      
  
		PricingItemPriceID = inputItem.PricingItemPriceID,  
  
		InventoryPricingRef = inputItem.InventoryPricingRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ProducedItemPrice Map(AddProducedItemPriceCommand inputItem)
        {
            var entity = new ProducedItemPrice() {
                  
  
		ProducedItemPriceID = inputItem.ProducedItemPriceID,  
  
		StockRef = inputItem.StockRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Price = inputItem.Price,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ProducedItemPrice Map(ProducedItemPrice entity ,EditProducedItemPriceCommand inputItem)
        {
              
  
		entity.ProducedItemPriceID = inputItem.ProducedItemPriceID;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.Price = inputItem.Price;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ProducedItemPriceDto Map(ProducedItemPrice inputItem)
        {
            var dto = new ProducedItemPriceDto()
            {
                  
  
		ProducedItemPriceID = inputItem.ProducedItemPriceID,  
  
		StockRef = inputItem.StockRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Price = inputItem.Price,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<ProducedItemPriceDto> Map(ICollection<ProducedItemPrice> entities)
        {
            var dtos = new List<ProducedItemPriceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProducedItemPriceDto()
                {
                      
  
		ProducedItemPriceID = inputItem.ProducedItemPriceID,  
  
		StockRef = inputItem.StockRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Price = inputItem.Price,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Property Map(AddPropertyCommand inputItem)
        {
            var entity = new Property() {
                  
  
		PropertyID = inputItem.PropertyID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsSelectable = inputItem.IsSelectable,  
  
		IsActive = inputItem.IsActive,  
  
		Number = inputItem.Number,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Property Map(Property entity ,EditPropertyCommand inputItem)
        {
              
  
		entity.PropertyID = inputItem.PropertyID;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.IsSelectable = inputItem.IsSelectable;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.Number = inputItem.Number;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PropertyDto Map(Property inputItem)
        {
            var dto = new PropertyDto()
            {
                  
  
		PropertyID = inputItem.PropertyID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsSelectable = inputItem.IsSelectable,  
  
		IsActive = inputItem.IsActive,  
  
		Number = inputItem.Number,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PropertyDto> Map(ICollection<Property> entities)
        {
            var dtos = new List<PropertyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PropertyDto()
                {
                      
  
		PropertyID = inputItem.PropertyID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsSelectable = inputItem.IsSelectable,  
  
		IsActive = inputItem.IsActive,  
  
		Number = inputItem.Number,  
  
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
        
        public static PropertyDetail Map(AddPropertyDetailCommand inputItem)
        {
            var entity = new PropertyDetail() {
                  
  
		PropertyDetailID = inputItem.PropertyDetailID,  
  
		Title = inputItem.Title,  
  
		PropertyRef = inputItem.PropertyRef,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PropertyDetail Map(PropertyDetail entity ,EditPropertyDetailCommand inputItem)
        {
              
  
		entity.PropertyDetailID = inputItem.PropertyDetailID;  
  
		entity.Title = inputItem.Title;  
  
		entity.PropertyRef = inputItem.PropertyRef;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PropertyDetailDto Map(PropertyDetail inputItem)
        {
            var dto = new PropertyDetailDto()
            {
                  
  
		PropertyDetailID = inputItem.PropertyDetailID,  
  
		Title = inputItem.Title,  
  
		PropertyRef = inputItem.PropertyRef,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PropertyDetailDto> Map(ICollection<PropertyDetail> entities)
        {
            var dtos = new List<PropertyDetailDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PropertyDetailDto()
                {
                      
  
		PropertyDetailID = inputItem.PropertyDetailID,  
  
		Title = inputItem.Title,  
  
		PropertyRef = inputItem.PropertyRef,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Stock Map(AddStockCommand inputItem)
        {
            var entity = new Stock() {
                  
  
		StockID = inputItem.StockID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		StockClerk = inputItem.StockClerk,  
  
		Phone = inputItem.Phone,  
  
		Address = inputItem.Address,  
  
		Address_En = inputItem.Address_En,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		IsActive = inputItem.IsActive,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Stock Map(Stock entity ,EditStockCommand inputItem)
        {
              
  
		entity.StockID = inputItem.StockID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.StockClerk = inputItem.StockClerk;  
  
		entity.Phone = inputItem.Phone;  
  
		entity.Address = inputItem.Address;  
  
		entity.Address_En = inputItem.Address_En;  
  
		entity.AccountSLRef = inputItem.AccountSLRef;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StockDto Map(Stock inputItem)
        {
            var dto = new StockDto()
            {
                  
  
		StockID = inputItem.StockID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		StockClerk = inputItem.StockClerk,  
  
		Phone = inputItem.Phone,  
  
		Address = inputItem.Address,  
  
		Address_En = inputItem.Address_En,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		IsActive = inputItem.IsActive,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<StockDto> Map(ICollection<Stock> entities)
        {
            var dtos = new List<StockDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StockDto()
                {
                      
  
		StockID = inputItem.StockID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		StockClerk = inputItem.StockClerk,  
  
		Phone = inputItem.Phone,  
  
		Address = inputItem.Address,  
  
		Address_En = inputItem.Address_En,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		IsActive = inputItem.IsActive,  
  
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
        
        public static Tracing Map(AddTracingCommand inputItem)
        {
            var entity = new Tracing() {
                  
  
		TracingID = inputItem.TracingID,  
  
		TracingCategoryRef = inputItem.TracingCategoryRef,  
  
		Title = inputItem.Title,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Tracing Map(Tracing entity ,EditTracingCommand inputItem)
        {
              
  
		entity.TracingID = inputItem.TracingID;  
  
		entity.TracingCategoryRef = inputItem.TracingCategoryRef;  
  
		entity.Title = inputItem.Title;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TracingDto Map(Tracing inputItem)
        {
            var dto = new TracingDto()
            {
                  
  
		TracingID = inputItem.TracingID,  
  
		TracingCategoryRef = inputItem.TracingCategoryRef,  
  
		Title = inputItem.Title,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<TracingDto> Map(ICollection<Tracing> entities)
        {
            var dtos = new List<TracingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TracingDto()
                {
                      
  
		TracingID = inputItem.TracingID,  
  
		TracingCategoryRef = inputItem.TracingCategoryRef,  
  
		Title = inputItem.Title,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TracingCategory Map(AddTracingCategoryCommand inputItem)
        {
            var entity = new TracingCategory() {
                  
  
		TracingCategoryID = inputItem.TracingCategoryID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsFixed = inputItem.IsFixed,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TracingCategory Map(TracingCategory entity ,EditTracingCategoryCommand inputItem)
        {
              
  
		entity.TracingCategoryID = inputItem.TracingCategoryID;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.IsFixed = inputItem.IsFixed;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TracingCategoryDto Map(TracingCategory inputItem)
        {
            var dto = new TracingCategoryDto()
            {
                  
  
		TracingCategoryID = inputItem.TracingCategoryID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsFixed = inputItem.IsFixed,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<TracingCategoryDto> Map(ICollection<TracingCategory> entities)
        {
            var dtos = new List<TracingCategoryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TracingCategoryDto()
                {
                      
  
		TracingCategoryID = inputItem.TracingCategoryID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsFixed = inputItem.IsFixed,  
  
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
        
        public static Unit Map(AddUnitCommand inputItem)
        {
            var entity = new Unit() {
                  
  
		UnitID = inputItem.UnitID,  
  
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

        public static Unit Map(Unit entity ,EditUnitCommand inputItem)
        {
              
  
		entity.UnitID = inputItem.UnitID;  
  
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

        
        public static UnitDto Map(Unit inputItem)
        {
            var dto = new UnitDto()
            {
                  
  
		UnitID = inputItem.UnitID,  
  
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

        public static List<UnitDto> Map(ICollection<Unit> entities)
        {
            var dtos = new List<UnitDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UnitDto()
                {
                      
  
		UnitID = inputItem.UnitID,  
  
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
        
        public static VoucherItemTracking Map(AddVoucherItemTrackingCommand inputItem)
        {
            var entity = new VoucherItemTracking() {
                  
  
		VoucherItemTrackingID = inputItem.VoucherItemTrackingID,  
  
		Serial = inputItem.Serial,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef,  
  
		InventoryReceiptItemRef = inputItem.InventoryReceiptItemRef,  
  
		InventoryDeliveryItemRef = inputItem.InventoryDeliveryItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static VoucherItemTracking Map(VoucherItemTracking entity ,EditVoucherItemTrackingCommand inputItem)
        {
              
  
		entity.VoucherItemTrackingID = inputItem.VoucherItemTrackingID;  
  
		entity.Serial = inputItem.Serial;  
  
		entity.InvoiceItemRef = inputItem.InvoiceItemRef;  
  
		entity.ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef;  
  
		entity.InventoryReceiptItemRef = inputItem.InventoryReceiptItemRef;  
  
		entity.InventoryDeliveryItemRef = inputItem.InventoryDeliveryItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static VoucherItemTrackingDto Map(VoucherItemTracking inputItem)
        {
            var dto = new VoucherItemTrackingDto()
            {
                  
  
		VoucherItemTrackingID = inputItem.VoucherItemTrackingID,  
  
		Serial = inputItem.Serial,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef,  
  
		InventoryReceiptItemRef = inputItem.InventoryReceiptItemRef,  
  
		InventoryDeliveryItemRef = inputItem.InventoryDeliveryItemRef, 
            };
            return dto;
        }

        public static List<VoucherItemTrackingDto> Map(ICollection<VoucherItemTracking> entities)
        {
            var dtos = new List<VoucherItemTrackingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new VoucherItemTrackingDto()
                {
                      
  
		VoucherItemTrackingID = inputItem.VoucherItemTrackingID,  
  
		Serial = inputItem.Serial,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef,  
  
		InventoryReceiptItemRef = inputItem.InventoryReceiptItemRef,  
  
		InventoryDeliveryItemRef = inputItem.InventoryDeliveryItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
