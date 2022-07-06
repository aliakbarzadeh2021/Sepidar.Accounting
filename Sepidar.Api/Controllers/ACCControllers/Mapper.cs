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
                
        
        public static Account Map(AddAccountCommand inputItem)
        {
            var entity = new Account() {
                  
  
		AccountId = inputItem.AccountId,  
  
		ParentAccountRef = inputItem.ParentAccountRef,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsActive = inputItem.IsActive,  
  
		CashFlowCategory = inputItem.CashFlowCategory,  
  
		OpeningBalance = inputItem.OpeningBalance,  
  
		BalanceType = inputItem.BalanceType,  
  
		HasBalanceTypeCheck = inputItem.HasBalanceTypeCheck,  
  
		HasDL = inputItem.HasDL,  
  
		HasCurrency = inputItem.HasCurrency,  
  
		HasCurrencyConversion = inputItem.HasCurrencyConversion,  
  
		HasTracking = inputItem.HasTracking,  
  
		HasTrackingCheck = inputItem.HasTrackingCheck,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Account Map(Account entity ,EditAccountCommand inputItem)
        {
              
  
		entity.AccountId = inputItem.AccountId;  
  
		entity.ParentAccountRef = inputItem.ParentAccountRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.CashFlowCategory = inputItem.CashFlowCategory;  
  
		entity.OpeningBalance = inputItem.OpeningBalance;  
  
		entity.BalanceType = inputItem.BalanceType;  
  
		entity.HasBalanceTypeCheck = inputItem.HasBalanceTypeCheck;  
  
		entity.HasDL = inputItem.HasDL;  
  
		entity.HasCurrency = inputItem.HasCurrency;  
  
		entity.HasCurrencyConversion = inputItem.HasCurrencyConversion;  
  
		entity.HasTracking = inputItem.HasTracking;  
  
		entity.HasTrackingCheck = inputItem.HasTrackingCheck;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccountDto Map(Account inputItem)
        {
            var dto = new AccountDto()
            {
                  
  
		AccountId = inputItem.AccountId,  
  
		ParentAccountRef = inputItem.ParentAccountRef,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsActive = inputItem.IsActive,  
  
		CashFlowCategory = inputItem.CashFlowCategory,  
  
		OpeningBalance = inputItem.OpeningBalance,  
  
		BalanceType = inputItem.BalanceType,  
  
		HasBalanceTypeCheck = inputItem.HasBalanceTypeCheck,  
  
		HasDL = inputItem.HasDL,  
  
		HasCurrency = inputItem.HasCurrency,  
  
		HasCurrencyConversion = inputItem.HasCurrencyConversion,  
  
		HasTracking = inputItem.HasTracking,  
  
		HasTrackingCheck = inputItem.HasTrackingCheck,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<AccountDto> Map(ICollection<Account> entities)
        {
            var dtos = new List<AccountDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccountDto()
                {
                      
  
		AccountId = inputItem.AccountId,  
  
		ParentAccountRef = inputItem.ParentAccountRef,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsActive = inputItem.IsActive,  
  
		CashFlowCategory = inputItem.CashFlowCategory,  
  
		OpeningBalance = inputItem.OpeningBalance,  
  
		BalanceType = inputItem.BalanceType,  
  
		HasBalanceTypeCheck = inputItem.HasBalanceTypeCheck,  
  
		HasDL = inputItem.HasDL,  
  
		HasCurrency = inputItem.HasCurrency,  
  
		HasCurrencyConversion = inputItem.HasCurrencyConversion,  
  
		HasTracking = inputItem.HasTracking,  
  
		HasTrackingCheck = inputItem.HasTrackingCheck,  
  
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
        
        public static AccountTopic Map(AddAccountTopicCommand inputItem)
        {
            var entity = new AccountTopic() {
                  
  
		AccountTopicId = inputItem.AccountTopicId,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		TopicRef = inputItem.TopicRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccountTopic Map(AccountTopic entity ,EditAccountTopicCommand inputItem)
        {
              
  
		entity.AccountTopicId = inputItem.AccountTopicId;  
  
		entity.AccountSLRef = inputItem.AccountSLRef;  
  
		entity.TopicRef = inputItem.TopicRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccountTopicDto Map(AccountTopic inputItem)
        {
            var dto = new AccountTopicDto()
            {
                  
  
		AccountTopicId = inputItem.AccountTopicId,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		TopicRef = inputItem.TopicRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<AccountTopicDto> Map(ICollection<AccountTopic> entities)
        {
            var dtos = new List<AccountTopicDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccountTopicDto()
                {
                      
  
		AccountTopicId = inputItem.AccountTopicId,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		TopicRef = inputItem.TopicRef,  
  
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
        
        public static DL Map(AddDLCommand inputItem)
        {
            var entity = new DL() {
                  
  
		DLId = inputItem.DLId,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		IsActive = inputItem.IsActive, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DL Map(DL entity ,EditDLCommand inputItem)
        {
              
  
		entity.DLId = inputItem.DLId;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Type = inputItem.Type;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.IsActive = inputItem.IsActive; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DLDto Map(DL inputItem)
        {
            var dto = new DLDto()
            {
                  
  
		DLId = inputItem.DLId,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		IsActive = inputItem.IsActive, 
            };
            return dto;
        }

        public static List<DLDto> Map(ICollection<DL> entities)
        {
            var dtos = new List<DLDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DLDto()
                {
                      
  
		DLId = inputItem.DLId,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		IsActive = inputItem.IsActive, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GLVoucher Map(AddGLVoucherCommand inputItem)
        {
            var entity = new GLVoucher() {
                  
  
		GLVoucherId = inputItem.GLVoucherId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
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

        public static GLVoucher Map(GLVoucher entity ,EditGLVoucherCommand inputItem)
        {
              
  
		entity.GLVoucherId = inputItem.GLVoucherId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GLVoucherDto Map(GLVoucher inputItem)
        {
            var dto = new GLVoucherDto()
            {
                  
  
		GLVoucherId = inputItem.GLVoucherId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<GLVoucherDto> Map(ICollection<GLVoucher> entities)
        {
            var dtos = new List<GLVoucherDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GLVoucherDto()
                {
                      
  
		GLVoucherId = inputItem.GLVoucherId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
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
        
        public static GLVoucherItem Map(AddGLVoucherItemCommand inputItem)
        {
            var entity = new GLVoucherItem() {
                  
  
		GLVoucherItemId = inputItem.GLVoucherItemId,  
  
		GLVoucherRef = inputItem.GLVoucherRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GLVoucherItem Map(GLVoucherItem entity ,EditGLVoucherItemCommand inputItem)
        {
              
  
		entity.GLVoucherItemId = inputItem.GLVoucherItemId;  
  
		entity.GLVoucherRef = inputItem.GLVoucherRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GLVoucherItemDto Map(GLVoucherItem inputItem)
        {
            var dto = new GLVoucherItemDto()
            {
                  
  
		GLVoucherItemId = inputItem.GLVoucherItemId,  
  
		GLVoucherRef = inputItem.GLVoucherRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<GLVoucherItemDto> Map(ICollection<GLVoucherItem> entities)
        {
            var dtos = new List<GLVoucherItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GLVoucherItemDto()
                {
                      
  
		GLVoucherItemId = inputItem.GLVoucherItemId,  
  
		GLVoucherRef = inputItem.GLVoucherRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OpeningOperation Map(AddOpeningOperationCommand inputItem)
        {
            var entity = new OpeningOperation() {
                  
  
		OpeningOperationId = inputItem.OpeningOperationId,  
  
		Date = inputItem.Date,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
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

        public static OpeningOperation Map(OpeningOperation entity ,EditOpeningOperationCommand inputItem)
        {
              
  
		entity.OpeningOperationId = inputItem.OpeningOperationId;  
  
		entity.Date = inputItem.Date;  
  
		entity.AccountSLRef = inputItem.AccountSLRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
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

        
        public static OpeningOperationDto Map(OpeningOperation inputItem)
        {
            var dto = new OpeningOperationDto()
            {
                  
  
		OpeningOperationId = inputItem.OpeningOperationId,  
  
		Date = inputItem.Date,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
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

        public static List<OpeningOperationDto> Map(ICollection<OpeningOperation> entities)
        {
            var dtos = new List<OpeningOperationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OpeningOperationDto()
                {
                      
  
		OpeningOperationId = inputItem.OpeningOperationId,  
  
		Date = inputItem.Date,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
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
        
        public static OpeningOperationItem Map(AddOpeningOperationItemCommand inputItem)
        {
            var entity = new OpeningOperationItem() {
                  
  
		OpeningOperationItemId = inputItem.OpeningOperationItemId,  
  
		OpeningOperationRef = inputItem.OpeningOperationRef,  
  
		RecordType = inputItem.RecordType,  
  
		RecordId = inputItem.RecordId,  
  
		Checked = inputItem.Checked,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OpeningOperationItem Map(OpeningOperationItem entity ,EditOpeningOperationItemCommand inputItem)
        {
              
  
		entity.OpeningOperationItemId = inputItem.OpeningOperationItemId;  
  
		entity.OpeningOperationRef = inputItem.OpeningOperationRef;  
  
		entity.RecordType = inputItem.RecordType;  
  
		entity.RecordId = inputItem.RecordId;  
  
		entity.Checked = inputItem.Checked;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OpeningOperationItemDto Map(OpeningOperationItem inputItem)
        {
            var dto = new OpeningOperationItemDto()
            {
                  
  
		OpeningOperationItemId = inputItem.OpeningOperationItemId,  
  
		OpeningOperationRef = inputItem.OpeningOperationRef,  
  
		RecordType = inputItem.RecordType,  
  
		RecordId = inputItem.RecordId,  
  
		Checked = inputItem.Checked,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<OpeningOperationItemDto> Map(ICollection<OpeningOperationItem> entities)
        {
            var dtos = new List<OpeningOperationItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OpeningOperationItemDto()
                {
                      
  
		OpeningOperationItemId = inputItem.OpeningOperationItemId,  
  
		OpeningOperationRef = inputItem.OpeningOperationRef,  
  
		RecordType = inputItem.RecordType,  
  
		RecordId = inputItem.RecordId,  
  
		Checked = inputItem.Checked,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Topic Map(AddTopicCommand inputItem)
        {
            var entity = new Topic() {
                  
  
		TopicId = inputItem.TopicId,  
  
		Type = inputItem.Type,  
  
		Topic1 = inputItem.Topic1,  
  
		Topic_En = inputItem.Topic_En,  
  
		Category = inputItem.Category,  
  
		Category_En = inputItem.Category_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Topic Map(Topic entity ,EditTopicCommand inputItem)
        {
              
  
		entity.TopicId = inputItem.TopicId;  
  
		entity.Type = inputItem.Type;  
  
		entity.Topic1 = inputItem.Topic1;  
  
		entity.Topic_En = inputItem.Topic_En;  
  
		entity.Category = inputItem.Category;  
  
		entity.Category_En = inputItem.Category_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TopicDto Map(Topic inputItem)
        {
            var dto = new TopicDto()
            {
                  
  
		TopicId = inputItem.TopicId,  
  
		Type = inputItem.Type,  
  
		Topic1 = inputItem.Topic1,  
  
		Topic_En = inputItem.Topic_En,  
  
		Category = inputItem.Category,  
  
		Category_En = inputItem.Category_En, 
            };
            return dto;
        }

        public static List<TopicDto> Map(ICollection<Topic> entities)
        {
            var dtos = new List<TopicDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TopicDto()
                {
                      
  
		TopicId = inputItem.TopicId,  
  
		Type = inputItem.Type,  
  
		Topic1 = inputItem.Topic1,  
  
		Topic_En = inputItem.Topic_En,  
  
		Category = inputItem.Category,  
  
		Category_En = inputItem.Category_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Voucher Map(AddVoucherCommand inputItem)
        {
            var entity = new Voucher() {
                  
  
		VoucherId = inputItem.VoucherId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ReferenceNumber = inputItem.ReferenceNumber,  
  
		SecondaryNumber = inputItem.SecondaryNumber,  
  
		State = inputItem.State,  
  
		Type = inputItem.Type,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		DailyNumber = inputItem.DailyNumber,  
  
		IssuerSystem = inputItem.IssuerSystem, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Voucher Map(Voucher entity ,EditVoucherCommand inputItem)
        {
              
  
		entity.VoucherId = inputItem.VoucherId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.ReferenceNumber = inputItem.ReferenceNumber;  
  
		entity.SecondaryNumber = inputItem.SecondaryNumber;  
  
		entity.State = inputItem.State;  
  
		entity.Type = inputItem.Type;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.DailyNumber = inputItem.DailyNumber;  
  
		entity.IssuerSystem = inputItem.IssuerSystem; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static VoucherDto Map(Voucher inputItem)
        {
            var dto = new VoucherDto()
            {
                  
  
		VoucherId = inputItem.VoucherId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ReferenceNumber = inputItem.ReferenceNumber,  
  
		SecondaryNumber = inputItem.SecondaryNumber,  
  
		State = inputItem.State,  
  
		Type = inputItem.Type,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		DailyNumber = inputItem.DailyNumber,  
  
		IssuerSystem = inputItem.IssuerSystem, 
            };
            return dto;
        }

        public static List<VoucherDto> Map(ICollection<Voucher> entities)
        {
            var dtos = new List<VoucherDto>();
            foreach (var inputItem in entities)
            {
                var dto = new VoucherDto()
                {
                      
  
		VoucherId = inputItem.VoucherId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ReferenceNumber = inputItem.ReferenceNumber,  
  
		SecondaryNumber = inputItem.SecondaryNumber,  
  
		State = inputItem.State,  
  
		Type = inputItem.Type,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		DailyNumber = inputItem.DailyNumber,  
  
		IssuerSystem = inputItem.IssuerSystem, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static VoucherItem Map(AddVoucherItemCommand inputItem)
        {
            var entity = new VoucherItem() {
                  
  
		VoucherItemId = inputItem.VoucherItemId,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		DLRef = inputItem.DLRef,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		CurrencyDebit = inputItem.CurrencyDebit,  
  
		CurrencyCredit = inputItem.CurrencyCredit,  
  
		TrackingNumber = inputItem.TrackingNumber,  
  
		TrackingDate = inputItem.TrackingDate,  
  
		IssuerEntityName = inputItem.IssuerEntityName,  
  
		IssuerEntityRef = inputItem.IssuerEntityRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static VoucherItem Map(VoucherItem entity ,EditVoucherItemCommand inputItem)
        {
              
  
		entity.VoucherItemId = inputItem.VoucherItemId;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.AccountSLRef = inputItem.AccountSLRef;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.Debit = inputItem.Debit;  
  
		entity.Credit = inputItem.Credit;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CurrencyRate = inputItem.CurrencyRate;  
  
		entity.CurrencyDebit = inputItem.CurrencyDebit;  
  
		entity.CurrencyCredit = inputItem.CurrencyCredit;  
  
		entity.TrackingNumber = inputItem.TrackingNumber;  
  
		entity.TrackingDate = inputItem.TrackingDate;  
  
		entity.IssuerEntityName = inputItem.IssuerEntityName;  
  
		entity.IssuerEntityRef = inputItem.IssuerEntityRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static VoucherItemDto Map(VoucherItem inputItem)
        {
            var dto = new VoucherItemDto()
            {
                  
  
		VoucherItemId = inputItem.VoucherItemId,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		DLRef = inputItem.DLRef,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		CurrencyDebit = inputItem.CurrencyDebit,  
  
		CurrencyCredit = inputItem.CurrencyCredit,  
  
		TrackingNumber = inputItem.TrackingNumber,  
  
		TrackingDate = inputItem.TrackingDate,  
  
		IssuerEntityName = inputItem.IssuerEntityName,  
  
		IssuerEntityRef = inputItem.IssuerEntityRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<VoucherItemDto> Map(ICollection<VoucherItem> entities)
        {
            var dtos = new List<VoucherItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new VoucherItemDto()
                {
                      
  
		VoucherItemId = inputItem.VoucherItemId,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		AccountSLRef = inputItem.AccountSLRef,  
  
		DLRef = inputItem.DLRef,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CurrencyRate = inputItem.CurrencyRate,  
  
		CurrencyDebit = inputItem.CurrencyDebit,  
  
		CurrencyCredit = inputItem.CurrencyCredit,  
  
		TrackingNumber = inputItem.TrackingNumber,  
  
		TrackingDate = inputItem.TrackingDate,  
  
		IssuerEntityName = inputItem.IssuerEntityName,  
  
		IssuerEntityRef = inputItem.IssuerEntityRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
