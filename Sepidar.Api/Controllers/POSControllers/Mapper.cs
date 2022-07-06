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
                
        
        public static Cashier Map(AddCashierCommand inputItem)
        {
            var entity = new Cashier() {
                  
  
		CashierID = inputItem.CashierID,  
  
		Title = inputItem.Title,  
  
		PartyRef = inputItem.PartyRef,  
  
		UserRef = inputItem.UserRef,  
  
		IsActive = inputItem.IsActive,  
  
		CanChangeDiscount = inputItem.CanChangeDiscount,  
  
		CanReceiveCash = inputItem.CanReceiveCash,  
  
		CanReceiveCheque = inputItem.CanReceiveCheque,  
  
		CanReceivePos = inputItem.CanReceivePos,  
  
		CanReceiveOther = inputItem.CanReceiveOther,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Cashier Map(Cashier entity ,EditCashierCommand inputItem)
        {
              
  
		entity.CashierID = inputItem.CashierID;  
  
		entity.Title = inputItem.Title;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.UserRef = inputItem.UserRef;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.CanChangeDiscount = inputItem.CanChangeDiscount;  
  
		entity.CanReceiveCash = inputItem.CanReceiveCash;  
  
		entity.CanReceiveCheque = inputItem.CanReceiveCheque;  
  
		entity.CanReceivePos = inputItem.CanReceivePos;  
  
		entity.CanReceiveOther = inputItem.CanReceiveOther;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CashierDto Map(Cashier inputItem)
        {
            var dto = new CashierDto()
            {
                  
  
		CashierID = inputItem.CashierID,  
  
		Title = inputItem.Title,  
  
		PartyRef = inputItem.PartyRef,  
  
		UserRef = inputItem.UserRef,  
  
		IsActive = inputItem.IsActive,  
  
		CanChangeDiscount = inputItem.CanChangeDiscount,  
  
		CanReceiveCash = inputItem.CanReceiveCash,  
  
		CanReceiveCheque = inputItem.CanReceiveCheque,  
  
		CanReceivePos = inputItem.CanReceivePos,  
  
		CanReceiveOther = inputItem.CanReceiveOther,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<CashierDto> Map(ICollection<Cashier> entities)
        {
            var dtos = new List<CashierDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CashierDto()
                {
                      
  
		CashierID = inputItem.CashierID,  
  
		Title = inputItem.Title,  
  
		PartyRef = inputItem.PartyRef,  
  
		UserRef = inputItem.UserRef,  
  
		IsActive = inputItem.IsActive,  
  
		CanChangeDiscount = inputItem.CanChangeDiscount,  
  
		CanReceiveCash = inputItem.CanReceiveCash,  
  
		CanReceiveCheque = inputItem.CanReceiveCheque,  
  
		CanReceivePos = inputItem.CanReceivePos,  
  
		CanReceiveOther = inputItem.CanReceiveOther,  
  
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
        
        public static POSInvoice Map(AddPOSInvoiceCommand inputItem)
        {
            var entity = new POSInvoice() {
                  
  
		InvoiceId = inputItem.InvoiceId,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		CashierRef = inputItem.CashierRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		StockRef = inputItem.StockRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		State = inputItem.State,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		InvoiceDiscount = inputItem.InvoiceDiscount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CashAmount = inputItem.CashAmount,  
  
		CardReaderAmount = inputItem.CardReaderAmount,  
  
		PosRef = inputItem.PosRef,  
  
		TransactionNumber = inputItem.TransactionNumber,  
  
		ChequeAmount = inputItem.ChequeAmount,  
  
		ChequeSecondaryNumber = inputItem.ChequeSecondaryNumber,  
  
		OtherAmount = inputItem.OtherAmount,  
  
		OtherDescription = inputItem.OtherDescription,  
  
		CashPaidAmount = inputItem.CashPaidAmount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static POSInvoice Map(POSInvoice entity ,EditPOSInvoiceCommand inputItem)
        {
              
  
		entity.InvoiceId = inputItem.InvoiceId;  
  
		entity.CustomerRealName = inputItem.CustomerRealName;  
  
		entity.CustomerRealName_En = inputItem.CustomerRealName_En;  
  
		entity.CashierRef = inputItem.CashierRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.State = inputItem.State;  
  
		entity.Price = inputItem.Price;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.InvoiceDiscount = inputItem.InvoiceDiscount;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.CashAmount = inputItem.CashAmount;  
  
		entity.CardReaderAmount = inputItem.CardReaderAmount;  
  
		entity.PosRef = inputItem.PosRef;  
  
		entity.TransactionNumber = inputItem.TransactionNumber;  
  
		entity.ChequeAmount = inputItem.ChequeAmount;  
  
		entity.ChequeSecondaryNumber = inputItem.ChequeSecondaryNumber;  
  
		entity.OtherAmount = inputItem.OtherAmount;  
  
		entity.OtherDescription = inputItem.OtherDescription;  
  
		entity.CashPaidAmount = inputItem.CashPaidAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static POSInvoiceDto Map(POSInvoice inputItem)
        {
            var dto = new POSInvoiceDto()
            {
                  
  
		InvoiceId = inputItem.InvoiceId,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		CashierRef = inputItem.CashierRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		StockRef = inputItem.StockRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		State = inputItem.State,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		InvoiceDiscount = inputItem.InvoiceDiscount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CashAmount = inputItem.CashAmount,  
  
		CardReaderAmount = inputItem.CardReaderAmount,  
  
		PosRef = inputItem.PosRef,  
  
		TransactionNumber = inputItem.TransactionNumber,  
  
		ChequeAmount = inputItem.ChequeAmount,  
  
		ChequeSecondaryNumber = inputItem.ChequeSecondaryNumber,  
  
		OtherAmount = inputItem.OtherAmount,  
  
		OtherDescription = inputItem.OtherDescription,  
  
		CashPaidAmount = inputItem.CashPaidAmount, 
            };
            return dto;
        }

        public static List<POSInvoiceDto> Map(ICollection<POSInvoice> entities)
        {
            var dtos = new List<POSInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new POSInvoiceDto()
                {
                      
  
		InvoiceId = inputItem.InvoiceId,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		CashierRef = inputItem.CashierRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		StockRef = inputItem.StockRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		State = inputItem.State,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		InvoiceDiscount = inputItem.InvoiceDiscount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CashAmount = inputItem.CashAmount,  
  
		CardReaderAmount = inputItem.CardReaderAmount,  
  
		PosRef = inputItem.PosRef,  
  
		TransactionNumber = inputItem.TransactionNumber,  
  
		ChequeAmount = inputItem.ChequeAmount,  
  
		ChequeSecondaryNumber = inputItem.ChequeSecondaryNumber,  
  
		OtherAmount = inputItem.OtherAmount,  
  
		OtherDescription = inputItem.OtherDescription,  
  
		CashPaidAmount = inputItem.CashPaidAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static POSInvoiceItem Map(AddPOSInvoiceItemCommand inputItem)
        {
            var entity = new POSInvoiceItem() {
                  
  
		InvoiceItemID = inputItem.InvoiceItemID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static POSInvoiceItem Map(POSInvoiceItem entity ,EditPOSInvoiceItemCommand inputItem)
        {
              
  
		entity.InvoiceItemID = inputItem.InvoiceItemID;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.Price = inputItem.Price;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static POSInvoiceItemDto Map(POSInvoiceItem inputItem)
        {
            var dto = new POSInvoiceItemDto()
            {
                  
  
		InvoiceItemID = inputItem.InvoiceItemID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<POSInvoiceItemDto> Map(ICollection<POSInvoiceItem> entities)
        {
            var dtos = new List<POSInvoiceItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new POSInvoiceItemDto()
                {
                      
  
		InvoiceItemID = inputItem.InvoiceItemID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QuickBar Map(AddQuickBarCommand inputItem)
        {
            var entity = new QuickBar() {
                  
  
		QuickBarID = inputItem.QuickBarID,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QuickBar Map(QuickBar entity ,EditQuickBarCommand inputItem)
        {
              
  
		entity.QuickBarID = inputItem.QuickBarID;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QuickBarDto Map(QuickBar inputItem)
        {
            var dto = new QuickBarDto()
            {
                  
  
		QuickBarID = inputItem.QuickBarID,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<QuickBarDto> Map(ICollection<QuickBar> entities)
        {
            var dtos = new List<QuickBarDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QuickBarDto()
                {
                      
  
		QuickBarID = inputItem.QuickBarID,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QuickBarItem Map(AddQuickBarItemCommand inputItem)
        {
            var entity = new QuickBarItem() {
                  
  
		QuickBarItemID = inputItem.QuickBarItemID,  
  
		QuickBarRef = inputItem.QuickBarRef,  
  
		ItemIndex = inputItem.ItemIndex,  
  
		ItemRef = inputItem.ItemRef,  
  
		Shortcut = inputItem.Shortcut, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QuickBarItem Map(QuickBarItem entity ,EditQuickBarItemCommand inputItem)
        {
              
  
		entity.QuickBarItemID = inputItem.QuickBarItemID;  
  
		entity.QuickBarRef = inputItem.QuickBarRef;  
  
		entity.ItemIndex = inputItem.ItemIndex;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.Shortcut = inputItem.Shortcut; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QuickBarItemDto Map(QuickBarItem inputItem)
        {
            var dto = new QuickBarItemDto()
            {
                  
  
		QuickBarItemID = inputItem.QuickBarItemID,  
  
		QuickBarRef = inputItem.QuickBarRef,  
  
		ItemIndex = inputItem.ItemIndex,  
  
		ItemRef = inputItem.ItemRef,  
  
		Shortcut = inputItem.Shortcut, 
            };
            return dto;
        }

        public static List<QuickBarItemDto> Map(ICollection<QuickBarItem> entities)
        {
            var dtos = new List<QuickBarItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QuickBarItemDto()
                {
                      
  
		QuickBarItemID = inputItem.QuickBarItemID,  
  
		QuickBarRef = inputItem.QuickBarRef,  
  
		ItemIndex = inputItem.ItemIndex,  
  
		ItemRef = inputItem.ItemRef,  
  
		Shortcut = inputItem.Shortcut, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static POSReturnedInvoice Map(AddPOSReturnedInvoiceCommand inputItem)
        {
            var entity = new POSReturnedInvoice() {
                  
  
		ReturnedInvoiceId = inputItem.ReturnedInvoiceId,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		StockRef = inputItem.StockRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		State = inputItem.State,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		InvoiceDiscount = inputItem.InvoiceDiscount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CashAmount = inputItem.CashAmount,  
  
		CardReaderAmount = inputItem.CardReaderAmount,  
  
		PosRef = inputItem.PosRef,  
  
		TransactionNumber = inputItem.TransactionNumber,  
  
		ChequeAmount = inputItem.ChequeAmount,  
  
		ChequeSecondaryNumber = inputItem.ChequeSecondaryNumber,  
  
		OtherAmount = inputItem.OtherAmount,  
  
		OtherDescription = inputItem.OtherDescription,  
  
		CashPaidAmount = inputItem.CashPaidAmount,  
  
		CashierRef = inputItem.CashierRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static POSReturnedInvoice Map(POSReturnedInvoice entity ,EditPOSReturnedInvoiceCommand inputItem)
        {
              
  
		entity.ReturnedInvoiceId = inputItem.ReturnedInvoiceId;  
  
		entity.CustomerRealName = inputItem.CustomerRealName;  
  
		entity.CustomerRealName_En = inputItem.CustomerRealName_En;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.State = inputItem.State;  
  
		entity.Price = inputItem.Price;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.InvoiceDiscount = inputItem.InvoiceDiscount;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.NetPrice = inputItem.NetPrice;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.CashAmount = inputItem.CashAmount;  
  
		entity.CardReaderAmount = inputItem.CardReaderAmount;  
  
		entity.PosRef = inputItem.PosRef;  
  
		entity.TransactionNumber = inputItem.TransactionNumber;  
  
		entity.ChequeAmount = inputItem.ChequeAmount;  
  
		entity.ChequeSecondaryNumber = inputItem.ChequeSecondaryNumber;  
  
		entity.OtherAmount = inputItem.OtherAmount;  
  
		entity.OtherDescription = inputItem.OtherDescription;  
  
		entity.CashPaidAmount = inputItem.CashPaidAmount;  
  
		entity.CashierRef = inputItem.CashierRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static POSReturnedInvoiceDto Map(POSReturnedInvoice inputItem)
        {
            var dto = new POSReturnedInvoiceDto()
            {
                  
  
		ReturnedInvoiceId = inputItem.ReturnedInvoiceId,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		StockRef = inputItem.StockRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		State = inputItem.State,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		InvoiceDiscount = inputItem.InvoiceDiscount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CashAmount = inputItem.CashAmount,  
  
		CardReaderAmount = inputItem.CardReaderAmount,  
  
		PosRef = inputItem.PosRef,  
  
		TransactionNumber = inputItem.TransactionNumber,  
  
		ChequeAmount = inputItem.ChequeAmount,  
  
		ChequeSecondaryNumber = inputItem.ChequeSecondaryNumber,  
  
		OtherAmount = inputItem.OtherAmount,  
  
		OtherDescription = inputItem.OtherDescription,  
  
		CashPaidAmount = inputItem.CashPaidAmount,  
  
		CashierRef = inputItem.CashierRef, 
            };
            return dto;
        }

        public static List<POSReturnedInvoiceDto> Map(ICollection<POSReturnedInvoice> entities)
        {
            var dtos = new List<POSReturnedInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new POSReturnedInvoiceDto()
                {
                      
  
		ReturnedInvoiceId = inputItem.ReturnedInvoiceId,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		StockRef = inputItem.StockRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		State = inputItem.State,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		InvoiceDiscount = inputItem.InvoiceDiscount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CashAmount = inputItem.CashAmount,  
  
		CardReaderAmount = inputItem.CardReaderAmount,  
  
		PosRef = inputItem.PosRef,  
  
		TransactionNumber = inputItem.TransactionNumber,  
  
		ChequeAmount = inputItem.ChequeAmount,  
  
		ChequeSecondaryNumber = inputItem.ChequeSecondaryNumber,  
  
		OtherAmount = inputItem.OtherAmount,  
  
		OtherDescription = inputItem.OtherDescription,  
  
		CashPaidAmount = inputItem.CashPaidAmount,  
  
		CashierRef = inputItem.CashierRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static POSReturnedInvoiceItem Map(AddPOSReturnedInvoiceItemCommand inputItem)
        {
            var entity = new POSReturnedInvoiceItem() {
                  
  
		ReturnedInvoiceItemID = inputItem.ReturnedInvoiceItemID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static POSReturnedInvoiceItem Map(POSReturnedInvoiceItem entity ,EditPOSReturnedInvoiceItemCommand inputItem)
        {
              
  
		entity.ReturnedInvoiceItemID = inputItem.ReturnedInvoiceItemID;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.Price = inputItem.Price;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static POSReturnedInvoiceItemDto Map(POSReturnedInvoiceItem inputItem)
        {
            var dto = new POSReturnedInvoiceItemDto()
            {
                  
  
		ReturnedInvoiceItemID = inputItem.ReturnedInvoiceItemID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<POSReturnedInvoiceItemDto> Map(ICollection<POSReturnedInvoiceItem> entities)
        {
            var dtos = new List<POSReturnedInvoiceItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new POSReturnedInvoiceItemDto()
                {
                      
  
		ReturnedInvoiceItemID = inputItem.ReturnedInvoiceItemID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		Discount = inputItem.Discount,  
  
		Addition = inputItem.Addition,  
  
		Tax = inputItem.Tax,  
  
		Duty = inputItem.Duty,  
  
		NetPrice = inputItem.NetPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static POSSettlement Map(AddPOSSettlementCommand inputItem)
        {
            var entity = new POSSettlement() {
                  
  
		SettlementID = inputItem.SettlementID,  
  
		CashierRef = inputItem.CashierRef,  
  
		Number = inputItem.Number,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
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

        public static POSSettlement Map(POSSettlement entity ,EditPOSSettlementCommand inputItem)
        {
              
  
		entity.SettlementID = inputItem.SettlementID;  
  
		entity.CashierRef = inputItem.CashierRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.FromDate = inputItem.FromDate;  
  
		entity.ToDate = inputItem.ToDate;  
  
		entity.ReceiptHeaderRef = inputItem.ReceiptHeaderRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static POSSettlementDto Map(POSSettlement inputItem)
        {
            var dto = new POSSettlementDto()
            {
                  
  
		SettlementID = inputItem.SettlementID,  
  
		CashierRef = inputItem.CashierRef,  
  
		Number = inputItem.Number,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<POSSettlementDto> Map(ICollection<POSSettlement> entities)
        {
            var dtos = new List<POSSettlementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new POSSettlementDto()
                {
                      
  
		SettlementID = inputItem.SettlementID,  
  
		CashierRef = inputItem.CashierRef,  
  
		Number = inputItem.Number,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
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
        
        public static POSSettlementItem Map(AddPOSSettlementItemCommand inputItem)
        {
            var entity = new POSSettlementItem() {
                  
  
		SettlementItemID = inputItem.SettlementItemID,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		RowID = inputItem.RowID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		SalesInvoiceRef = inputItem.SalesInvoiceRef,  
  
		SalesReturnedInvoiceRef = inputItem.SalesReturnedInvoiceRef,  
  
		EntityFullName = inputItem.EntityFullName, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static POSSettlementItem Map(POSSettlementItem entity ,EditPOSSettlementItemCommand inputItem)
        {
              
  
		entity.SettlementItemID = inputItem.SettlementItemID;  
  
		entity.SettlementRef = inputItem.SettlementRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.SalesInvoiceRef = inputItem.SalesInvoiceRef;  
  
		entity.SalesReturnedInvoiceRef = inputItem.SalesReturnedInvoiceRef;  
  
		entity.EntityFullName = inputItem.EntityFullName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static POSSettlementItemDto Map(POSSettlementItem inputItem)
        {
            var dto = new POSSettlementItemDto()
            {
                  
  
		SettlementItemID = inputItem.SettlementItemID,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		RowID = inputItem.RowID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		SalesInvoiceRef = inputItem.SalesInvoiceRef,  
  
		SalesReturnedInvoiceRef = inputItem.SalesReturnedInvoiceRef,  
  
		EntityFullName = inputItem.EntityFullName, 
            };
            return dto;
        }

        public static List<POSSettlementItemDto> Map(ICollection<POSSettlementItem> entities)
        {
            var dtos = new List<POSSettlementItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new POSSettlementItemDto()
                {
                      
  
		SettlementItemID = inputItem.SettlementItemID,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		RowID = inputItem.RowID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		SalesInvoiceRef = inputItem.SalesInvoiceRef,  
  
		SalesReturnedInvoiceRef = inputItem.SalesReturnedInvoiceRef,  
  
		EntityFullName = inputItem.EntityFullName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
