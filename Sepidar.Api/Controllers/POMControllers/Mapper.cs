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
                
        
        public static BillOfLoading Map(AddBillOfLoadingCommand inputItem)
        {
            var entity = new BillOfLoading() {
                  
  
		BillOfLoadingID = inputItem.BillOfLoadingID,  
  
		TransporterDLRef = inputItem.TransporterDLRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		AllotmentType = inputItem.AllotmentType,  
  
		Description = inputItem.Description,  
  
		TransportSourceRef = inputItem.TransportSourceRef,  
  
		TransportDestinationRef = inputItem.TransportDestinationRef,  
  
		TransportType = inputItem.TransportType,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalDiscount = inputItem.TotalDiscount,  
  
		TotalDiscountInBaseCurrency = inputItem.TotalDiscountInBaseCurrency,  
  
		TotalAddition = inputItem.TotalAddition,  
  
		TotalAdditionInBaseCurrency = inputItem.TotalAdditionInBaseCurrency,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalTaxInBaseCurrency = inputItem.TotalTaxInBaseCurrency,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalDutyInBaseCurrency = inputItem.TotalDutyInBaseCurrency,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
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

        public static BillOfLoading Map(BillOfLoading entity ,EditBillOfLoadingCommand inputItem)
        {
              
  
		entity.BillOfLoadingID = inputItem.BillOfLoadingID;  
  
		entity.TransporterDLRef = inputItem.TransporterDLRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.AllotmentType = inputItem.AllotmentType;  
  
		entity.Description = inputItem.Description;  
  
		entity.TransportSourceRef = inputItem.TransportSourceRef;  
  
		entity.TransportDestinationRef = inputItem.TransportDestinationRef;  
  
		entity.TransportType = inputItem.TransportType;  
  
		entity.TotalPrice = inputItem.TotalPrice;  
  
		entity.TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency;  
  
		entity.TotalDiscount = inputItem.TotalDiscount;  
  
		entity.TotalDiscountInBaseCurrency = inputItem.TotalDiscountInBaseCurrency;  
  
		entity.TotalAddition = inputItem.TotalAddition;  
  
		entity.TotalAdditionInBaseCurrency = inputItem.TotalAdditionInBaseCurrency;  
  
		entity.TotalTax = inputItem.TotalTax;  
  
		entity.TotalTaxInBaseCurrency = inputItem.TotalTaxInBaseCurrency;  
  
		entity.TotalDuty = inputItem.TotalDuty;  
  
		entity.TotalDutyInBaseCurrency = inputItem.TotalDutyInBaseCurrency;  
  
		entity.TotalNetPrice = inputItem.TotalNetPrice;  
  
		entity.TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.SLAccountRef = inputItem.SLAccountRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BillOfLoadingDto Map(BillOfLoading inputItem)
        {
            var dto = new BillOfLoadingDto()
            {
                  
  
		BillOfLoadingID = inputItem.BillOfLoadingID,  
  
		TransporterDLRef = inputItem.TransporterDLRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		AllotmentType = inputItem.AllotmentType,  
  
		Description = inputItem.Description,  
  
		TransportSourceRef = inputItem.TransportSourceRef,  
  
		TransportDestinationRef = inputItem.TransportDestinationRef,  
  
		TransportType = inputItem.TransportType,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalDiscount = inputItem.TotalDiscount,  
  
		TotalDiscountInBaseCurrency = inputItem.TotalDiscountInBaseCurrency,  
  
		TotalAddition = inputItem.TotalAddition,  
  
		TotalAdditionInBaseCurrency = inputItem.TotalAdditionInBaseCurrency,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalTaxInBaseCurrency = inputItem.TotalTaxInBaseCurrency,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalDutyInBaseCurrency = inputItem.TotalDutyInBaseCurrency,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<BillOfLoadingDto> Map(ICollection<BillOfLoading> entities)
        {
            var dtos = new List<BillOfLoadingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BillOfLoadingDto()
                {
                      
  
		BillOfLoadingID = inputItem.BillOfLoadingID,  
  
		TransporterDLRef = inputItem.TransporterDLRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		AllotmentType = inputItem.AllotmentType,  
  
		Description = inputItem.Description,  
  
		TransportSourceRef = inputItem.TransportSourceRef,  
  
		TransportDestinationRef = inputItem.TransportDestinationRef,  
  
		TransportType = inputItem.TransportType,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalDiscount = inputItem.TotalDiscount,  
  
		TotalDiscountInBaseCurrency = inputItem.TotalDiscountInBaseCurrency,  
  
		TotalAddition = inputItem.TotalAddition,  
  
		TotalAdditionInBaseCurrency = inputItem.TotalAdditionInBaseCurrency,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalTaxInBaseCurrency = inputItem.TotalTaxInBaseCurrency,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalDutyInBaseCurrency = inputItem.TotalDutyInBaseCurrency,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
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
        
        public static BillOfLoadingItem Map(AddBillOfLoadingItemCommand inputItem)
        {
            var entity = new BillOfLoadingItem() {
                  
  
		BillOfLoadingItemID = inputItem.BillOfLoadingItemID,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		BasePurchaseInvoiceItemRef = inputItem.BasePurchaseInvoiceItemRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		TotalWeight = inputItem.TotalWeight,  
  
		ItemWeight = inputItem.ItemWeight,  
  
		ItemNetPrice = inputItem.ItemNetPrice,  
  
		ItemNetPriceInBaseCurrency = inputItem.ItemNetPriceInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BillOfLoadingItem Map(BillOfLoadingItem entity ,EditBillOfLoadingItemCommand inputItem)
        {
              
  
		entity.BillOfLoadingItemID = inputItem.BillOfLoadingItemID;  
  
		entity.BillOfLoadingRef = inputItem.BillOfLoadingRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.BasePurchaseInvoiceItemRef = inputItem.BasePurchaseInvoiceItemRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.TotalWeight = inputItem.TotalWeight;  
  
		entity.ItemWeight = inputItem.ItemWeight;  
  
		entity.ItemNetPrice = inputItem.ItemNetPrice;  
  
		entity.ItemNetPriceInBaseCurrency = inputItem.ItemNetPriceInBaseCurrency;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BillOfLoadingItemDto Map(BillOfLoadingItem inputItem)
        {
            var dto = new BillOfLoadingItemDto()
            {
                  
  
		BillOfLoadingItemID = inputItem.BillOfLoadingItemID,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		BasePurchaseInvoiceItemRef = inputItem.BasePurchaseInvoiceItemRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		TotalWeight = inputItem.TotalWeight,  
  
		ItemWeight = inputItem.ItemWeight,  
  
		ItemNetPrice = inputItem.ItemNetPrice,  
  
		ItemNetPriceInBaseCurrency = inputItem.ItemNetPriceInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<BillOfLoadingItemDto> Map(ICollection<BillOfLoadingItem> entities)
        {
            var dtos = new List<BillOfLoadingItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BillOfLoadingItemDto()
                {
                      
  
		BillOfLoadingItemID = inputItem.BillOfLoadingItemID,  
  
		BillOfLoadingRef = inputItem.BillOfLoadingRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		BasePurchaseInvoiceItemRef = inputItem.BasePurchaseInvoiceItemRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		TotalWeight = inputItem.TotalWeight,  
  
		ItemWeight = inputItem.ItemWeight,  
  
		ItemNetPrice = inputItem.ItemNetPrice,  
  
		ItemNetPriceInBaseCurrency = inputItem.ItemNetPriceInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CommercialOrder Map(AddCommercialOrderCommand inputItem)
        {
            var entity = new CommercialOrder() {
                  
  
		CommercialOrderID = inputItem.CommercialOrderID,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ValidityDate = inputItem.ValidityDate,  
  
		DLRef = inputItem.DLRef,  
  
		SLRef = inputItem.SLRef,  
  
		RegisterFee = inputItem.RegisterFee,  
  
		SharingMethod = inputItem.SharingMethod,  
  
		LoadingPlace = inputItem.LoadingPlace,  
  
		InCustomsRef = inputItem.InCustomsRef,  
  
		OutCustomsRef = inputItem.OutCustomsRef,  
  
		OriginCountryRef = inputItem.OriginCountryRef,  
  
		Description = inputItem.Description,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommercialOrder Map(CommercialOrder entity ,EditCommercialOrderCommand inputItem)
        {
              
  
		entity.CommercialOrderID = inputItem.CommercialOrderID;  
  
		entity.PurchaseOrderRef = inputItem.PurchaseOrderRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.ValidityDate = inputItem.ValidityDate;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.SLRef = inputItem.SLRef;  
  
		entity.RegisterFee = inputItem.RegisterFee;  
  
		entity.SharingMethod = inputItem.SharingMethod;  
  
		entity.LoadingPlace = inputItem.LoadingPlace;  
  
		entity.InCustomsRef = inputItem.InCustomsRef;  
  
		entity.OutCustomsRef = inputItem.OutCustomsRef;  
  
		entity.OriginCountryRef = inputItem.OriginCountryRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommercialOrderDto Map(CommercialOrder inputItem)
        {
            var dto = new CommercialOrderDto()
            {
                  
  
		CommercialOrderID = inputItem.CommercialOrderID,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ValidityDate = inputItem.ValidityDate,  
  
		DLRef = inputItem.DLRef,  
  
		SLRef = inputItem.SLRef,  
  
		RegisterFee = inputItem.RegisterFee,  
  
		SharingMethod = inputItem.SharingMethod,  
  
		LoadingPlace = inputItem.LoadingPlace,  
  
		InCustomsRef = inputItem.InCustomsRef,  
  
		OutCustomsRef = inputItem.OutCustomsRef,  
  
		OriginCountryRef = inputItem.OriginCountryRef,  
  
		Description = inputItem.Description,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<CommercialOrderDto> Map(ICollection<CommercialOrder> entities)
        {
            var dtos = new List<CommercialOrderDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommercialOrderDto()
                {
                      
  
		CommercialOrderID = inputItem.CommercialOrderID,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ValidityDate = inputItem.ValidityDate,  
  
		DLRef = inputItem.DLRef,  
  
		SLRef = inputItem.SLRef,  
  
		RegisterFee = inputItem.RegisterFee,  
  
		SharingMethod = inputItem.SharingMethod,  
  
		LoadingPlace = inputItem.LoadingPlace,  
  
		InCustomsRef = inputItem.InCustomsRef,  
  
		OutCustomsRef = inputItem.OutCustomsRef,  
  
		OriginCountryRef = inputItem.OriginCountryRef,  
  
		Description = inputItem.Description,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
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
        
        public static CommercialOrderItem Map(AddCommercialOrderItemCommand inputItem)
        {
            var entity = new CommercialOrderItem() {
                  
  
		CommercialOrderItemID = inputItem.CommercialOrderItemID,  
  
		CommercialOrderRef = inputItem.CommercialOrderRef,  
  
		PurchaseOrderItemRef = inputItem.PurchaseOrderItemRef,  
  
		RegisterFee = inputItem.RegisterFee,  
  
		RowNumber = inputItem.RowNumber, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommercialOrderItem Map(CommercialOrderItem entity ,EditCommercialOrderItemCommand inputItem)
        {
              
  
		entity.CommercialOrderItemID = inputItem.CommercialOrderItemID;  
  
		entity.CommercialOrderRef = inputItem.CommercialOrderRef;  
  
		entity.PurchaseOrderItemRef = inputItem.PurchaseOrderItemRef;  
  
		entity.RegisterFee = inputItem.RegisterFee;  
  
		entity.RowNumber = inputItem.RowNumber; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommercialOrderItemDto Map(CommercialOrderItem inputItem)
        {
            var dto = new CommercialOrderItemDto()
            {
                  
  
		CommercialOrderItemID = inputItem.CommercialOrderItemID,  
  
		CommercialOrderRef = inputItem.CommercialOrderRef,  
  
		PurchaseOrderItemRef = inputItem.PurchaseOrderItemRef,  
  
		RegisterFee = inputItem.RegisterFee,  
  
		RowNumber = inputItem.RowNumber, 
            };
            return dto;
        }

        public static List<CommercialOrderItemDto> Map(ICollection<CommercialOrderItem> entities)
        {
            var dtos = new List<CommercialOrderItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommercialOrderItemDto()
                {
                      
  
		CommercialOrderItemID = inputItem.CommercialOrderItemID,  
  
		CommercialOrderRef = inputItem.CommercialOrderRef,  
  
		PurchaseOrderItemRef = inputItem.PurchaseOrderItemRef,  
  
		RegisterFee = inputItem.RegisterFee,  
  
		RowNumber = inputItem.RowNumber, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Customs Map(AddCustomsCommand inputItem)
        {
            var entity = new Customs() {
                  
  
		CustomsID = inputItem.CustomsID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Customs Map(Customs entity ,EditCustomsCommand inputItem)
        {
              
  
		entity.CustomsID = inputItem.CustomsID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CustomsDto Map(Customs inputItem)
        {
            var dto = new CustomsDto()
            {
                  
  
		CustomsID = inputItem.CustomsID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<CustomsDto> Map(ICollection<Customs> entities)
        {
            var dtos = new List<CustomsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CustomsDto()
                {
                      
  
		CustomsID = inputItem.CustomsID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
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
        
        public static CustomsClearance Map(AddCustomsClearanceCommand inputItem)
        {
            var entity = new CustomsClearance() {
                  
  
		CustomsClearanceID = inputItem.CustomsClearanceID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		DLRef = inputItem.DLRef,  
  
		SLRef = inputItem.SLRef,  
  
		InCustomsRef = inputItem.InCustomsRef,  
  
		AssessCustomsRef = inputItem.AssessCustomsRef,  
  
		OriginCountryRef = inputItem.OriginCountryRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Currencyrate = inputItem.Currencyrate,  
  
		Description = inputItem.Description,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		CustomsCost = inputItem.CustomsCost,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		NetPrice = inputItem.NetPrice,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CustomsClearance Map(CustomsClearance entity ,EditCustomsClearanceCommand inputItem)
        {
              
  
		entity.CustomsClearanceID = inputItem.CustomsClearanceID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.SLRef = inputItem.SLRef;  
  
		entity.InCustomsRef = inputItem.InCustomsRef;  
  
		entity.AssessCustomsRef = inputItem.AssessCustomsRef;  
  
		entity.OriginCountryRef = inputItem.OriginCountryRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Currencyrate = inputItem.Currencyrate;  
  
		entity.Description = inputItem.Description;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.CustomsCost = inputItem.CustomsCost;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CustomsClearanceDto Map(CustomsClearance inputItem)
        {
            var dto = new CustomsClearanceDto()
            {
                  
  
		CustomsClearanceID = inputItem.CustomsClearanceID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		DLRef = inputItem.DLRef,  
  
		SLRef = inputItem.SLRef,  
  
		InCustomsRef = inputItem.InCustomsRef,  
  
		AssessCustomsRef = inputItem.AssessCustomsRef,  
  
		OriginCountryRef = inputItem.OriginCountryRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Currencyrate = inputItem.Currencyrate,  
  
		Description = inputItem.Description,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		CustomsCost = inputItem.CustomsCost,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		NetPrice = inputItem.NetPrice,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<CustomsClearanceDto> Map(ICollection<CustomsClearance> entities)
        {
            var dtos = new List<CustomsClearanceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CustomsClearanceDto()
                {
                      
  
		CustomsClearanceID = inputItem.CustomsClearanceID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		DLRef = inputItem.DLRef,  
  
		SLRef = inputItem.SLRef,  
  
		InCustomsRef = inputItem.InCustomsRef,  
  
		AssessCustomsRef = inputItem.AssessCustomsRef,  
  
		OriginCountryRef = inputItem.OriginCountryRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Currencyrate = inputItem.Currencyrate,  
  
		Description = inputItem.Description,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		CustomsCost = inputItem.CustomsCost,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		NetPrice = inputItem.NetPrice,  
  
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
        
        public static CustomsClearanceItem Map(AddCustomsClearanceItemCommand inputItem)
        {
            var entity = new CustomsClearanceItem() {
                  
  
		CustomsClearanceItemID = inputItem.CustomsClearanceItemID,  
  
		CustomsClearanceRef = inputItem.CustomsClearanceRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Currencyrate = inputItem.Currencyrate,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		PurchaseInvoiceItemNetPrice = inputItem.PurchaseInvoiceItemNetPrice,  
  
		PurchaseInvoiceItemNetPriceInBaseCurrency = inputItem.PurchaseInvoiceItemNetPriceInBaseCurrency,  
  
		CustomsCost = inputItem.CustomsCost,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CustomsClearanceItem Map(CustomsClearanceItem entity ,EditCustomsClearanceItemCommand inputItem)
        {
              
  
		entity.CustomsClearanceItemID = inputItem.CustomsClearanceItemID;  
  
		entity.CustomsClearanceRef = inputItem.CustomsClearanceRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Currencyrate = inputItem.Currencyrate;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.PurchaseInvoiceItemNetPrice = inputItem.PurchaseInvoiceItemNetPrice;  
  
		entity.PurchaseInvoiceItemNetPriceInBaseCurrency = inputItem.PurchaseInvoiceItemNetPriceInBaseCurrency;  
  
		entity.CustomsCost = inputItem.CustomsCost;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.Duty = inputItem.Duty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CustomsClearanceItemDto Map(CustomsClearanceItem inputItem)
        {
            var dto = new CustomsClearanceItemDto()
            {
                  
  
		CustomsClearanceItemID = inputItem.CustomsClearanceItemID,  
  
		CustomsClearanceRef = inputItem.CustomsClearanceRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Currencyrate = inputItem.Currencyrate,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		PurchaseInvoiceItemNetPrice = inputItem.PurchaseInvoiceItemNetPrice,  
  
		PurchaseInvoiceItemNetPriceInBaseCurrency = inputItem.PurchaseInvoiceItemNetPriceInBaseCurrency,  
  
		CustomsCost = inputItem.CustomsCost,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty, 
            };
            return dto;
        }

        public static List<CustomsClearanceItemDto> Map(ICollection<CustomsClearanceItem> entities)
        {
            var dtos = new List<CustomsClearanceItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CustomsClearanceItemDto()
                {
                      
  
		CustomsClearanceItemID = inputItem.CustomsClearanceItemID,  
  
		CustomsClearanceRef = inputItem.CustomsClearanceRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Currencyrate = inputItem.Currencyrate,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		PurchaseInvoiceItemNetPrice = inputItem.PurchaseInvoiceItemNetPrice,  
  
		PurchaseInvoiceItemNetPriceInBaseCurrency = inputItem.PurchaseInvoiceItemNetPriceInBaseCurrency,  
  
		CustomsCost = inputItem.CustomsCost,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InsurancePolicy Map(AddInsurancePolicyCommand inputItem)
        {
            var entity = new InsurancePolicy() {
                  
  
		InsurancePolicyID = inputItem.InsurancePolicyID,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		AgencyDLRef = inputItem.AgencyDLRef,  
  
		CoverType = inputItem.CoverType,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ValidityDate = inputItem.ValidityDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Description = inputItem.Description,  
  
		InputCustomsRef = inputItem.InputCustomsRef,  
  
		TransportSourceRef = inputItem.TransportSourceRef,  
  
		TransportDestinationRef = inputItem.TransportDestinationRef,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalTaxInBaseCurrency = inputItem.TotalTaxInBaseCurrency,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalDutyInBaseCurrency = inputItem.TotalDutyInBaseCurrency,  
  
		AllotmentType = inputItem.AllotmentType,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
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

        public static InsurancePolicy Map(InsurancePolicy entity ,EditInsurancePolicyCommand inputItem)
        {
              
  
		entity.InsurancePolicyID = inputItem.InsurancePolicyID;  
  
		entity.PurchaseOrderRef = inputItem.PurchaseOrderRef;  
  
		entity.AgencyDLRef = inputItem.AgencyDLRef;  
  
		entity.CoverType = inputItem.CoverType;  
  
		entity.SLAccountRef = inputItem.SLAccountRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.ValidityDate = inputItem.ValidityDate;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.Description = inputItem.Description;  
  
		entity.InputCustomsRef = inputItem.InputCustomsRef;  
  
		entity.TransportSourceRef = inputItem.TransportSourceRef;  
  
		entity.TransportDestinationRef = inputItem.TransportDestinationRef;  
  
		entity.TotalPrice = inputItem.TotalPrice;  
  
		entity.TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency;  
  
		entity.TotalNetPrice = inputItem.TotalNetPrice;  
  
		entity.TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency;  
  
		entity.TotalTax = inputItem.TotalTax;  
  
		entity.TotalTaxInBaseCurrency = inputItem.TotalTaxInBaseCurrency;  
  
		entity.TotalDuty = inputItem.TotalDuty;  
  
		entity.TotalDutyInBaseCurrency = inputItem.TotalDutyInBaseCurrency;  
  
		entity.AllotmentType = inputItem.AllotmentType;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InsurancePolicyDto Map(InsurancePolicy inputItem)
        {
            var dto = new InsurancePolicyDto()
            {
                  
  
		InsurancePolicyID = inputItem.InsurancePolicyID,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		AgencyDLRef = inputItem.AgencyDLRef,  
  
		CoverType = inputItem.CoverType,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ValidityDate = inputItem.ValidityDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Description = inputItem.Description,  
  
		InputCustomsRef = inputItem.InputCustomsRef,  
  
		TransportSourceRef = inputItem.TransportSourceRef,  
  
		TransportDestinationRef = inputItem.TransportDestinationRef,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalTaxInBaseCurrency = inputItem.TotalTaxInBaseCurrency,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalDutyInBaseCurrency = inputItem.TotalDutyInBaseCurrency,  
  
		AllotmentType = inputItem.AllotmentType,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<InsurancePolicyDto> Map(ICollection<InsurancePolicy> entities)
        {
            var dtos = new List<InsurancePolicyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InsurancePolicyDto()
                {
                      
  
		InsurancePolicyID = inputItem.InsurancePolicyID,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		AgencyDLRef = inputItem.AgencyDLRef,  
  
		CoverType = inputItem.CoverType,  
  
		SLAccountRef = inputItem.SLAccountRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ValidityDate = inputItem.ValidityDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Description = inputItem.Description,  
  
		InputCustomsRef = inputItem.InputCustomsRef,  
  
		TransportSourceRef = inputItem.TransportSourceRef,  
  
		TransportDestinationRef = inputItem.TransportDestinationRef,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		TotalTax = inputItem.TotalTax,  
  
		TotalTaxInBaseCurrency = inputItem.TotalTaxInBaseCurrency,  
  
		TotalDuty = inputItem.TotalDuty,  
  
		TotalDutyInBaseCurrency = inputItem.TotalDutyInBaseCurrency,  
  
		AllotmentType = inputItem.AllotmentType,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
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
        
        public static InsurancePolicyItem Map(AddInsurancePolicyItemCommand inputItem)
        {
            var entity = new InsurancePolicyItem() {
                  
  
		InsurancePolicyItemID = inputItem.InsurancePolicyItemID,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		BasePurchaseOrderItemRef = inputItem.BasePurchaseOrderItemRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InsurancePolicyItem Map(InsurancePolicyItem entity ,EditInsurancePolicyItemCommand inputItem)
        {
              
  
		entity.InsurancePolicyItemID = inputItem.InsurancePolicyItemID;  
  
		entity.InsurancePolicyRef = inputItem.InsurancePolicyRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.BasePurchaseOrderItemRef = inputItem.BasePurchaseOrderItemRef;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InsurancePolicyItemDto Map(InsurancePolicyItem inputItem)
        {
            var dto = new InsurancePolicyItemDto()
            {
                  
  
		InsurancePolicyItemID = inputItem.InsurancePolicyItemID,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		BasePurchaseOrderItemRef = inputItem.BasePurchaseOrderItemRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<InsurancePolicyItemDto> Map(ICollection<InsurancePolicyItem> entities)
        {
            var dtos = new List<InsurancePolicyItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InsurancePolicyItemDto()
                {
                      
  
		InsurancePolicyItemID = inputItem.InsurancePolicyItemID,  
  
		InsurancePolicyRef = inputItem.InsurancePolicyRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		BasePurchaseOrderItemRef = inputItem.BasePurchaseOrderItemRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Performa Map(AddPerformaCommand inputItem)
        {
            var entity = new Performa() {
                  
  
		PerformaID = inputItem.PerformaID,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		Number = inputItem.Number,  
  
		PerformaNumber = inputItem.PerformaNumber,  
  
		Date = inputItem.Date,  
  
		ValidityDate = inputItem.ValidityDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		ContractType = inputItem.ContractType,  
  
		TransportType = inputItem.TransportType,  
  
		PaymentMethod = inputItem.PaymentMethod,  
  
		Description = inputItem.Description,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		State = inputItem.State,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Performa Map(Performa entity ,EditPerformaCommand inputItem)
        {
              
  
		entity.PerformaID = inputItem.PerformaID;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VendorDLRef = inputItem.VendorDLRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.PerformaNumber = inputItem.PerformaNumber;  
  
		entity.Date = inputItem.Date;  
  
		entity.ValidityDate = inputItem.ValidityDate;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.ContractType = inputItem.ContractType;  
  
		entity.TransportType = inputItem.TransportType;  
  
		entity.PaymentMethod = inputItem.PaymentMethod;  
  
		entity.Description = inputItem.Description;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.State = inputItem.State;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PerformaDto Map(Performa inputItem)
        {
            var dto = new PerformaDto()
            {
                  
  
		PerformaID = inputItem.PerformaID,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		Number = inputItem.Number,  
  
		PerformaNumber = inputItem.PerformaNumber,  
  
		Date = inputItem.Date,  
  
		ValidityDate = inputItem.ValidityDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		ContractType = inputItem.ContractType,  
  
		TransportType = inputItem.TransportType,  
  
		PaymentMethod = inputItem.PaymentMethod,  
  
		Description = inputItem.Description,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		State = inputItem.State,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PerformaDto> Map(ICollection<Performa> entities)
        {
            var dtos = new List<PerformaDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PerformaDto()
                {
                      
  
		PerformaID = inputItem.PerformaID,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		Number = inputItem.Number,  
  
		PerformaNumber = inputItem.PerformaNumber,  
  
		Date = inputItem.Date,  
  
		ValidityDate = inputItem.ValidityDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		ContractType = inputItem.ContractType,  
  
		TransportType = inputItem.TransportType,  
  
		PaymentMethod = inputItem.PaymentMethod,  
  
		Description = inputItem.Description,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		State = inputItem.State,  
  
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
        
        public static PerformaItem Map(AddPerformaItemCommand inputItem)
        {
            var entity = new PerformaItem() {
                  
  
		PerformaItemID = inputItem.PerformaItemID,  
  
		PerformaRef = inputItem.PerformaRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PerformaItem Map(PerformaItem entity ,EditPerformaItemCommand inputItem)
        {
              
  
		entity.PerformaItemID = inputItem.PerformaItemID;  
  
		entity.PerformaRef = inputItem.PerformaRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.FeeInBaseCurrency = inputItem.FeeInBaseCurrency;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Description = inputItem.Description; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PerformaItemDto Map(PerformaItem inputItem)
        {
            var dto = new PerformaItemDto()
            {
                  
  
		PerformaItemID = inputItem.PerformaItemID,  
  
		PerformaRef = inputItem.PerformaRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description, 
            };
            return dto;
        }

        public static List<PerformaItemDto> Map(ICollection<PerformaItem> entities)
        {
            var dtos = new List<PerformaItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PerformaItemDto()
                {
                      
  
		PerformaItemID = inputItem.PerformaItemID,  
  
		PerformaRef = inputItem.PerformaRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PurchaseCost Map(AddPurchaseCostCommand inputItem)
        {
            var entity = new PurchaseCost() {
                  
  
		PurchaseCostID = inputItem.PurchaseCostID,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		Description = inputItem.Description,  
  
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

        public static PurchaseCost Map(PurchaseCost entity ,EditPurchaseCostCommand inputItem)
        {
              
  
		entity.PurchaseCostID = inputItem.PurchaseCostID;  
  
		entity.PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.State = inputItem.State;  
  
		entity.Description = inputItem.Description;  
  
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

        
        public static PurchaseCostDto Map(PurchaseCost inputItem)
        {
            var dto = new PurchaseCostDto()
            {
                  
  
		PurchaseCostID = inputItem.PurchaseCostID,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		Description = inputItem.Description,  
  
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

        public static List<PurchaseCostDto> Map(ICollection<PurchaseCost> entities)
        {
            var dtos = new List<PurchaseCostDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PurchaseCostDto()
                {
                      
  
		PurchaseCostID = inputItem.PurchaseCostID,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		Description = inputItem.Description,  
  
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
        
        public static PurchaseCostItem Map(AddPurchaseCostItemCommand inputItem)
        {
            var entity = new PurchaseCostItem() {
                  
  
		PurchaseCostItemID = inputItem.PurchaseCostItemID,  
  
		PurchaseCostRef = inputItem.PurchaseCostRef,  
  
		PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef,  
  
		CommercialOrderItemRef = inputItem.CommercialOrderItemRef,  
  
		InsurancePolicyItemRef = inputItem.InsurancePolicyItemRef,  
  
		PurchaseInvoiceItemNetPriceInBaseCurrency = inputItem.PurchaseInvoiceItemNetPriceInBaseCurrency,  
  
		TotalCommercialOrder = inputItem.TotalCommercialOrder,  
  
		TotalCommercialOrderInBaseCurrency = inputItem.TotalCommercialOrderInBaseCurrency,  
  
		TotalInsurancePolicy = inputItem.TotalInsurancePolicy,  
  
		TotalInsurancePolicyInBaseCurrency = inputItem.TotalInsurancePolicyInBaseCurrency,  
  
		TotalBillOfLoading = inputItem.TotalBillOfLoading,  
  
		TotalBillOfLoadingInBaseCurrency = inputItem.TotalBillOfLoadingInBaseCurrency,  
  
		TotalCustomsClearance = inputItem.TotalCustomsClearance,  
  
		TotalCustomsClearanceInBaseCurrency = inputItem.TotalCustomsClearanceInBaseCurrency,  
  
		TotalOtherCostsInBaseCurrency = inputItem.TotalOtherCostsInBaseCurrency,  
  
		AllotmenedAmountInBaseCurrency = inputItem.AllotmenedAmountInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		FinalFeeInBaseCurrency = inputItem.FinalFeeInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PurchaseCostItem Map(PurchaseCostItem entity ,EditPurchaseCostItemCommand inputItem)
        {
              
  
		entity.PurchaseCostItemID = inputItem.PurchaseCostItemID;  
  
		entity.PurchaseCostRef = inputItem.PurchaseCostRef;  
  
		entity.PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef;  
  
		entity.CommercialOrderItemRef = inputItem.CommercialOrderItemRef;  
  
		entity.InsurancePolicyItemRef = inputItem.InsurancePolicyItemRef;  
  
		entity.PurchaseInvoiceItemNetPriceInBaseCurrency = inputItem.PurchaseInvoiceItemNetPriceInBaseCurrency;  
  
		entity.TotalCommercialOrder = inputItem.TotalCommercialOrder;  
  
		entity.TotalCommercialOrderInBaseCurrency = inputItem.TotalCommercialOrderInBaseCurrency;  
  
		entity.TotalInsurancePolicy = inputItem.TotalInsurancePolicy;  
  
		entity.TotalInsurancePolicyInBaseCurrency = inputItem.TotalInsurancePolicyInBaseCurrency;  
  
		entity.TotalBillOfLoading = inputItem.TotalBillOfLoading;  
  
		entity.TotalBillOfLoadingInBaseCurrency = inputItem.TotalBillOfLoadingInBaseCurrency;  
  
		entity.TotalCustomsClearance = inputItem.TotalCustomsClearance;  
  
		entity.TotalCustomsClearanceInBaseCurrency = inputItem.TotalCustomsClearanceInBaseCurrency;  
  
		entity.TotalOtherCostsInBaseCurrency = inputItem.TotalOtherCostsInBaseCurrency;  
  
		entity.AllotmenedAmountInBaseCurrency = inputItem.AllotmenedAmountInBaseCurrency;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.FinalFeeInBaseCurrency = inputItem.FinalFeeInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PurchaseCostItemDto Map(PurchaseCostItem inputItem)
        {
            var dto = new PurchaseCostItemDto()
            {
                  
  
		PurchaseCostItemID = inputItem.PurchaseCostItemID,  
  
		PurchaseCostRef = inputItem.PurchaseCostRef,  
  
		PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef,  
  
		CommercialOrderItemRef = inputItem.CommercialOrderItemRef,  
  
		InsurancePolicyItemRef = inputItem.InsurancePolicyItemRef,  
  
		PurchaseInvoiceItemNetPriceInBaseCurrency = inputItem.PurchaseInvoiceItemNetPriceInBaseCurrency,  
  
		TotalCommercialOrder = inputItem.TotalCommercialOrder,  
  
		TotalCommercialOrderInBaseCurrency = inputItem.TotalCommercialOrderInBaseCurrency,  
  
		TotalInsurancePolicy = inputItem.TotalInsurancePolicy,  
  
		TotalInsurancePolicyInBaseCurrency = inputItem.TotalInsurancePolicyInBaseCurrency,  
  
		TotalBillOfLoading = inputItem.TotalBillOfLoading,  
  
		TotalBillOfLoadingInBaseCurrency = inputItem.TotalBillOfLoadingInBaseCurrency,  
  
		TotalCustomsClearance = inputItem.TotalCustomsClearance,  
  
		TotalCustomsClearanceInBaseCurrency = inputItem.TotalCustomsClearanceInBaseCurrency,  
  
		TotalOtherCostsInBaseCurrency = inputItem.TotalOtherCostsInBaseCurrency,  
  
		AllotmenedAmountInBaseCurrency = inputItem.AllotmenedAmountInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		FinalFeeInBaseCurrency = inputItem.FinalFeeInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PurchaseCostItemDto> Map(ICollection<PurchaseCostItem> entities)
        {
            var dtos = new List<PurchaseCostItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PurchaseCostItemDto()
                {
                      
  
		PurchaseCostItemID = inputItem.PurchaseCostItemID,  
  
		PurchaseCostRef = inputItem.PurchaseCostRef,  
  
		PurchaseInvoiceItemRef = inputItem.PurchaseInvoiceItemRef,  
  
		CommercialOrderItemRef = inputItem.CommercialOrderItemRef,  
  
		InsurancePolicyItemRef = inputItem.InsurancePolicyItemRef,  
  
		PurchaseInvoiceItemNetPriceInBaseCurrency = inputItem.PurchaseInvoiceItemNetPriceInBaseCurrency,  
  
		TotalCommercialOrder = inputItem.TotalCommercialOrder,  
  
		TotalCommercialOrderInBaseCurrency = inputItem.TotalCommercialOrderInBaseCurrency,  
  
		TotalInsurancePolicy = inputItem.TotalInsurancePolicy,  
  
		TotalInsurancePolicyInBaseCurrency = inputItem.TotalInsurancePolicyInBaseCurrency,  
  
		TotalBillOfLoading = inputItem.TotalBillOfLoading,  
  
		TotalBillOfLoadingInBaseCurrency = inputItem.TotalBillOfLoadingInBaseCurrency,  
  
		TotalCustomsClearance = inputItem.TotalCustomsClearance,  
  
		TotalCustomsClearanceInBaseCurrency = inputItem.TotalCustomsClearanceInBaseCurrency,  
  
		TotalOtherCostsInBaseCurrency = inputItem.TotalOtherCostsInBaseCurrency,  
  
		AllotmenedAmountInBaseCurrency = inputItem.AllotmenedAmountInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		FinalFeeInBaseCurrency = inputItem.FinalFeeInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PurchaseInvoice Map(AddPurchaseInvoiceCommand inputItem)
        {
            var entity = new PurchaseInvoice() {
                  
  
		PurchaseInvoiceID = inputItem.PurchaseInvoiceID,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		DLRef = inputItem.DLRef,  
  
		Number = inputItem.Number,  
  
		PurchaseNumber = inputItem.PurchaseNumber,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Description = inputItem.Description,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CanTransferNextPeriod = inputItem.CanTransferNextPeriod,  
  
		BasePurchaseInvoiceRef = inputItem.BasePurchaseInvoiceRef,  
  
		IsInitial = inputItem.IsInitial,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PurchaseInvoice Map(PurchaseInvoice entity ,EditPurchaseInvoiceCommand inputItem)
        {
              
  
		entity.PurchaseInvoiceID = inputItem.PurchaseInvoiceID;  
  
		entity.VendorDLRef = inputItem.VendorDLRef;  
  
		entity.PurchaseOrderRef = inputItem.PurchaseOrderRef;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.PurchaseNumber = inputItem.PurchaseNumber;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.Description = inputItem.Description;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.CanTransferNextPeriod = inputItem.CanTransferNextPeriod;  
  
		entity.BasePurchaseInvoiceRef = inputItem.BasePurchaseInvoiceRef;  
  
		entity.IsInitial = inputItem.IsInitial;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PurchaseInvoiceDto Map(PurchaseInvoice inputItem)
        {
            var dto = new PurchaseInvoiceDto()
            {
                  
  
		PurchaseInvoiceID = inputItem.PurchaseInvoiceID,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		DLRef = inputItem.DLRef,  
  
		Number = inputItem.Number,  
  
		PurchaseNumber = inputItem.PurchaseNumber,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Description = inputItem.Description,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CanTransferNextPeriod = inputItem.CanTransferNextPeriod,  
  
		BasePurchaseInvoiceRef = inputItem.BasePurchaseInvoiceRef,  
  
		IsInitial = inputItem.IsInitial,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PurchaseInvoiceDto> Map(ICollection<PurchaseInvoice> entities)
        {
            var dtos = new List<PurchaseInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PurchaseInvoiceDto()
                {
                      
  
		PurchaseInvoiceID = inputItem.PurchaseInvoiceID,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		DLRef = inputItem.DLRef,  
  
		Number = inputItem.Number,  
  
		PurchaseNumber = inputItem.PurchaseNumber,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		Description = inputItem.Description,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CanTransferNextPeriod = inputItem.CanTransferNextPeriod,  
  
		BasePurchaseInvoiceRef = inputItem.BasePurchaseInvoiceRef,  
  
		IsInitial = inputItem.IsInitial,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
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
        
        public static PurchaseInvoiceItem Map(AddPurchaseInvoiceItemCommand inputItem)
        {
            var entity = new PurchaseInvoiceItem() {
                  
  
		PurchaseInvoiceItemID = inputItem.PurchaseInvoiceItemID,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		PurchaseOrderItemRef = inputItem.PurchaseOrderItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		BaseInvoiceCalculatedPriceNoteInBaseCurrency = inputItem.BaseInvoiceCalculatedPriceNoteInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PurchaseInvoiceItem Map(PurchaseInvoiceItem entity ,EditPurchaseInvoiceItemCommand inputItem)
        {
              
  
		entity.PurchaseInvoiceItemID = inputItem.PurchaseInvoiceItemID;  
  
		entity.PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.PurchaseOrderItemRef = inputItem.PurchaseOrderItemRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.FeeInBaseCurrency = inputItem.FeeInBaseCurrency;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.BaseInvoiceCalculatedPriceNoteInBaseCurrency = inputItem.BaseInvoiceCalculatedPriceNoteInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PurchaseInvoiceItemDto Map(PurchaseInvoiceItem inputItem)
        {
            var dto = new PurchaseInvoiceItemDto()
            {
                  
  
		PurchaseInvoiceItemID = inputItem.PurchaseInvoiceItemID,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		PurchaseOrderItemRef = inputItem.PurchaseOrderItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		BaseInvoiceCalculatedPriceNoteInBaseCurrency = inputItem.BaseInvoiceCalculatedPriceNoteInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PurchaseInvoiceItemDto> Map(ICollection<PurchaseInvoiceItem> entities)
        {
            var dtos = new List<PurchaseInvoiceItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PurchaseInvoiceItemDto()
                {
                      
  
		PurchaseInvoiceItemID = inputItem.PurchaseInvoiceItemID,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		PurchaseOrderItemRef = inputItem.PurchaseOrderItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		BaseInvoiceCalculatedPriceNoteInBaseCurrency = inputItem.BaseInvoiceCalculatedPriceNoteInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PurchaseOrder Map(AddPurchaseOrderCommand inputItem)
        {
            var entity = new PurchaseOrder() {
                  
  
		PurchaseOrderID = inputItem.PurchaseOrderID,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		PerformaRef = inputItem.PerformaRef,  
  
		DLRef = inputItem.DLRef,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		TotalDiscount = inputItem.TotalDiscount,  
  
		TotalDiscountInBaseCurrency = inputItem.TotalDiscountInBaseCurrency,  
  
		TotalAddition = inputItem.TotalAddition,  
  
		TotalAdditionInBaseCurrency = inputItem.TotalAdditionInBaseCurrency,  
  
		IsActive = inputItem.IsActive,  
  
		State = inputItem.State,  
  
		Description = inputItem.Description,  
  
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

        public static PurchaseOrder Map(PurchaseOrder entity ,EditPurchaseOrderCommand inputItem)
        {
              
  
		entity.PurchaseOrderID = inputItem.PurchaseOrderID;  
  
		entity.VendorDLRef = inputItem.VendorDLRef;  
  
		entity.PerformaRef = inputItem.PerformaRef;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.TotalPrice = inputItem.TotalPrice;  
  
		entity.TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency;  
  
		entity.TotalNetPrice = inputItem.TotalNetPrice;  
  
		entity.TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency;  
  
		entity.TotalDiscount = inputItem.TotalDiscount;  
  
		entity.TotalDiscountInBaseCurrency = inputItem.TotalDiscountInBaseCurrency;  
  
		entity.TotalAddition = inputItem.TotalAddition;  
  
		entity.TotalAdditionInBaseCurrency = inputItem.TotalAdditionInBaseCurrency;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.State = inputItem.State;  
  
		entity.Description = inputItem.Description;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PurchaseOrderDto Map(PurchaseOrder inputItem)
        {
            var dto = new PurchaseOrderDto()
            {
                  
  
		PurchaseOrderID = inputItem.PurchaseOrderID,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		PerformaRef = inputItem.PerformaRef,  
  
		DLRef = inputItem.DLRef,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		TotalDiscount = inputItem.TotalDiscount,  
  
		TotalDiscountInBaseCurrency = inputItem.TotalDiscountInBaseCurrency,  
  
		TotalAddition = inputItem.TotalAddition,  
  
		TotalAdditionInBaseCurrency = inputItem.TotalAdditionInBaseCurrency,  
  
		IsActive = inputItem.IsActive,  
  
		State = inputItem.State,  
  
		Description = inputItem.Description,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PurchaseOrderDto> Map(ICollection<PurchaseOrder> entities)
        {
            var dtos = new List<PurchaseOrderDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PurchaseOrderDto()
                {
                      
  
		PurchaseOrderID = inputItem.PurchaseOrderID,  
  
		VendorDLRef = inputItem.VendorDLRef,  
  
		PerformaRef = inputItem.PerformaRef,  
  
		DLRef = inputItem.DLRef,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		TotalPrice = inputItem.TotalPrice,  
  
		TotalPriceInBaseCurrency = inputItem.TotalPriceInBaseCurrency,  
  
		TotalNetPrice = inputItem.TotalNetPrice,  
  
		TotalNetPriceInBaseCurrency = inputItem.TotalNetPriceInBaseCurrency,  
  
		TotalDiscount = inputItem.TotalDiscount,  
  
		TotalDiscountInBaseCurrency = inputItem.TotalDiscountInBaseCurrency,  
  
		TotalAddition = inputItem.TotalAddition,  
  
		TotalAdditionInBaseCurrency = inputItem.TotalAdditionInBaseCurrency,  
  
		IsActive = inputItem.IsActive,  
  
		State = inputItem.State,  
  
		Description = inputItem.Description,  
  
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
        
        public static PurchaseOrderItem Map(AddPurchaseOrderItemCommand inputItem)
        {
            var entity = new PurchaseOrderItem() {
                  
  
		PurchaseOrderItemID = inputItem.PurchaseOrderItemID,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		BasePerformaItemRef = inputItem.BasePerformaItemRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PurchaseOrderItem Map(PurchaseOrderItem entity ,EditPurchaseOrderItemCommand inputItem)
        {
              
  
		entity.PurchaseOrderItemID = inputItem.PurchaseOrderItemID;  
  
		entity.PurchaseOrderRef = inputItem.PurchaseOrderRef;  
  
		entity.BasePerformaItemRef = inputItem.BasePerformaItemRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.FeeInBaseCurrency = inputItem.FeeInBaseCurrency;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PurchaseOrderItemDto Map(PurchaseOrderItem inputItem)
        {
            var dto = new PurchaseOrderItemDto()
            {
                  
  
		PurchaseOrderItemID = inputItem.PurchaseOrderItemID,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		BasePerformaItemRef = inputItem.BasePerformaItemRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PurchaseOrderItemDto> Map(ICollection<PurchaseOrderItem> entities)
        {
            var dtos = new List<PurchaseOrderItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PurchaseOrderItemDto()
                {
                      
  
		PurchaseOrderItemID = inputItem.PurchaseOrderItemID,  
  
		PurchaseOrderRef = inputItem.PurchaseOrderRef,  
  
		BasePerformaItemRef = inputItem.BasePerformaItemRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		FeeInBaseCurrency = inputItem.FeeInBaseCurrency,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		NetPrice = inputItem.NetPrice,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PurchaseOtherCostItem Map(AddPurchaseOtherCostItemCommand inputItem)
        {
            var entity = new PurchaseOtherCostItem() {
                  
  
		PurchaseOtherCostItemID = inputItem.PurchaseOtherCostItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		PurchaseCostRef = inputItem.PurchaseCostRef,  
  
		ServiceInventoryPurchaseInvoiceItemRef = inputItem.ServiceInventoryPurchaseInvoiceItemRef,  
  
		CostServiceAccountSLRef = inputItem.CostServiceAccountSLRef,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		EffectiveAmountInBaseCurrency = inputItem.EffectiveAmountInBaseCurrency,  
  
		AllotmentType = inputItem.AllotmentType,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PurchaseOtherCostItem Map(PurchaseOtherCostItem entity ,EditPurchaseOtherCostItemCommand inputItem)
        {
              
  
		entity.PurchaseOtherCostItemID = inputItem.PurchaseOtherCostItemID;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.PurchaseCostRef = inputItem.PurchaseCostRef;  
  
		entity.ServiceInventoryPurchaseInvoiceItemRef = inputItem.ServiceInventoryPurchaseInvoiceItemRef;  
  
		entity.CostServiceAccountSLRef = inputItem.CostServiceAccountSLRef;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.EffectiveAmountInBaseCurrency = inputItem.EffectiveAmountInBaseCurrency;  
  
		entity.AllotmentType = inputItem.AllotmentType;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PurchaseOtherCostItemDto Map(PurchaseOtherCostItem inputItem)
        {
            var dto = new PurchaseOtherCostItemDto()
            {
                  
  
		PurchaseOtherCostItemID = inputItem.PurchaseOtherCostItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		PurchaseCostRef = inputItem.PurchaseCostRef,  
  
		ServiceInventoryPurchaseInvoiceItemRef = inputItem.ServiceInventoryPurchaseInvoiceItemRef,  
  
		CostServiceAccountSLRef = inputItem.CostServiceAccountSLRef,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		EffectiveAmountInBaseCurrency = inputItem.EffectiveAmountInBaseCurrency,  
  
		AllotmentType = inputItem.AllotmentType,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PurchaseOtherCostItemDto> Map(ICollection<PurchaseOtherCostItem> entities)
        {
            var dtos = new List<PurchaseOtherCostItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PurchaseOtherCostItemDto()
                {
                      
  
		PurchaseOtherCostItemID = inputItem.PurchaseOtherCostItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		PurchaseCostRef = inputItem.PurchaseCostRef,  
  
		ServiceInventoryPurchaseInvoiceItemRef = inputItem.ServiceInventoryPurchaseInvoiceItemRef,  
  
		CostServiceAccountSLRef = inputItem.CostServiceAccountSLRef,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		EffectiveAmountInBaseCurrency = inputItem.EffectiveAmountInBaseCurrency,  
  
		AllotmentType = inputItem.AllotmentType,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
