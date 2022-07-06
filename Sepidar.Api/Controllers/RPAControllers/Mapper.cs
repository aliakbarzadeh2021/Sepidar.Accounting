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
                
        
        public static AccountType Map(AddAccountTypeCommand inputItem)
        {
            var entity = new AccountType() {
                  
  
		AccountTypeId = inputItem.AccountTypeId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Type = inputItem.Type,  
  
		HasChequeBook = inputItem.HasChequeBook,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccountType Map(AccountType entity ,EditAccountTypeCommand inputItem)
        {
              
  
		entity.AccountTypeId = inputItem.AccountTypeId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Type = inputItem.Type;  
  
		entity.HasChequeBook = inputItem.HasChequeBook;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccountTypeDto Map(AccountType inputItem)
        {
            var dto = new AccountTypeDto()
            {
                  
  
		AccountTypeId = inputItem.AccountTypeId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Type = inputItem.Type,  
  
		HasChequeBook = inputItem.HasChequeBook,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<AccountTypeDto> Map(ICollection<AccountType> entities)
        {
            var dtos = new List<AccountTypeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccountTypeDto()
                {
                      
  
		AccountTypeId = inputItem.AccountTypeId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Type = inputItem.Type,  
  
		HasChequeBook = inputItem.HasChequeBook,  
  
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
        
        public static Bank Map(AddBankCommand inputItem)
        {
            var entity = new Bank() {
                  
  
		BankId = inputItem.BankId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		TaxFileCode = inputItem.TaxFileCode, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Bank Map(Bank entity ,EditBankCommand inputItem)
        {
              
  
		entity.BankId = inputItem.BankId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.TaxFileCode = inputItem.TaxFileCode; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BankDto Map(Bank inputItem)
        {
            var dto = new BankDto()
            {
                  
  
		BankId = inputItem.BankId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		TaxFileCode = inputItem.TaxFileCode, 
            };
            return dto;
        }

        public static List<BankDto> Map(ICollection<Bank> entities)
        {
            var dtos = new List<BankDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BankDto()
                {
                      
  
		BankId = inputItem.BankId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		TaxFileCode = inputItem.TaxFileCode, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BankAccount Map(AddBankAccountCommand inputItem)
        {
            var entity = new BankAccount() {
                  
  
		BankAccountId = inputItem.BankAccountId,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		AccountNo = inputItem.AccountNo,  
  
		AccountTypeRef = inputItem.AccountTypeRef,  
  
		DlRef = inputItem.DlRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		FirstAmount = inputItem.FirstAmount,  
  
		FirstDate = inputItem.FirstDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Balance = inputItem.Balance,  
  
		BillFirstAmount = inputItem.BillFirstAmount,  
  
		BlockedAmount = inputItem.BlockedAmount,  
  
		ClearFormatName = inputItem.ClearFormatName,  
  
		Owner = inputItem.Owner,  
  
		Owner_En = inputItem.Owner_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BankAccount Map(BankAccount entity ,EditBankAccountCommand inputItem)
        {
              
  
		entity.BankAccountId = inputItem.BankAccountId;  
  
		entity.BankBranchRef = inputItem.BankBranchRef;  
  
		entity.AccountNo = inputItem.AccountNo;  
  
		entity.AccountTypeRef = inputItem.AccountTypeRef;  
  
		entity.DlRef = inputItem.DlRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.FirstAmount = inputItem.FirstAmount;  
  
		entity.FirstDate = inputItem.FirstDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Balance = inputItem.Balance;  
  
		entity.BillFirstAmount = inputItem.BillFirstAmount;  
  
		entity.BlockedAmount = inputItem.BlockedAmount;  
  
		entity.ClearFormatName = inputItem.ClearFormatName;  
  
		entity.Owner = inputItem.Owner;  
  
		entity.Owner_En = inputItem.Owner_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BankAccountDto Map(BankAccount inputItem)
        {
            var dto = new BankAccountDto()
            {
                  
  
		BankAccountId = inputItem.BankAccountId,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		AccountNo = inputItem.AccountNo,  
  
		AccountTypeRef = inputItem.AccountTypeRef,  
  
		DlRef = inputItem.DlRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		FirstAmount = inputItem.FirstAmount,  
  
		FirstDate = inputItem.FirstDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Balance = inputItem.Balance,  
  
		BillFirstAmount = inputItem.BillFirstAmount,  
  
		BlockedAmount = inputItem.BlockedAmount,  
  
		ClearFormatName = inputItem.ClearFormatName,  
  
		Owner = inputItem.Owner,  
  
		Owner_En = inputItem.Owner_En, 
            };
            return dto;
        }

        public static List<BankAccountDto> Map(ICollection<BankAccount> entities)
        {
            var dtos = new List<BankAccountDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BankAccountDto()
                {
                      
  
		BankAccountId = inputItem.BankAccountId,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		AccountNo = inputItem.AccountNo,  
  
		AccountTypeRef = inputItem.AccountTypeRef,  
  
		DlRef = inputItem.DlRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		FirstAmount = inputItem.FirstAmount,  
  
		FirstDate = inputItem.FirstDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Balance = inputItem.Balance,  
  
		BillFirstAmount = inputItem.BillFirstAmount,  
  
		BlockedAmount = inputItem.BlockedAmount,  
  
		ClearFormatName = inputItem.ClearFormatName,  
  
		Owner = inputItem.Owner,  
  
		Owner_En = inputItem.Owner_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BankAccountBalance Map(AddBankAccountBalanceCommand inputItem)
        {
            var entity = new BankAccountBalance() {
                  
  
		BankAccountBalanceId = inputItem.BankAccountBalanceId,  
  
		Balance = inputItem.Balance,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BankAccountRef = inputItem.BankAccountRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BankAccountBalance Map(BankAccountBalance entity ,EditBankAccountBalanceCommand inputItem)
        {
              
  
		entity.BankAccountBalanceId = inputItem.BankAccountBalanceId;  
  
		entity.Balance = inputItem.Balance;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.BankAccountRef = inputItem.BankAccountRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BankAccountBalanceDto Map(BankAccountBalance inputItem)
        {
            var dto = new BankAccountBalanceDto()
            {
                  
  
		BankAccountBalanceId = inputItem.BankAccountBalanceId,  
  
		Balance = inputItem.Balance,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BankAccountRef = inputItem.BankAccountRef, 
            };
            return dto;
        }

        public static List<BankAccountBalanceDto> Map(ICollection<BankAccountBalance> entities)
        {
            var dtos = new List<BankAccountBalanceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BankAccountBalanceDto()
                {
                      
  
		BankAccountBalanceId = inputItem.BankAccountBalanceId,  
  
		Balance = inputItem.Balance,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BankAccountRef = inputItem.BankAccountRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BankBill Map(AddBankBillCommand inputItem)
        {
            var entity = new BankBill() {
                  
  
		BankBillId = inputItem.BankBillId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
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

        public static BankBill Map(BankBill entity ,EditBankBillCommand inputItem)
        {
              
  
		entity.BankBillId = inputItem.BankBillId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
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

        
        public static BankBillDto Map(BankBill inputItem)
        {
            var dto = new BankBillDto()
            {
                  
  
		BankBillId = inputItem.BankBillId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
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

        public static List<BankBillDto> Map(ICollection<BankBill> entities)
        {
            var dtos = new List<BankBillDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BankBillDto()
                {
                      
  
		BankBillId = inputItem.BankBillId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
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
        
        public static BankBillItem Map(AddBankBillItemCommand inputItem)
        {
            var entity = new BankBillItem() {
                  
  
		BankBillItemId = inputItem.BankBillItemId,  
  
		BankBillRef = inputItem.BankBillRef,  
  
		VoucherNumber = inputItem.VoucherNumber,  
  
		VoucherDate = inputItem.VoucherDate,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BankBillItem Map(BankBillItem entity ,EditBankBillItemCommand inputItem)
        {
              
  
		entity.BankBillItemId = inputItem.BankBillItemId;  
  
		entity.BankBillRef = inputItem.BankBillRef;  
  
		entity.VoucherNumber = inputItem.VoucherNumber;  
  
		entity.VoucherDate = inputItem.VoucherDate;  
  
		entity.Debit = inputItem.Debit;  
  
		entity.Credit = inputItem.Credit;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BankBillItemDto Map(BankBillItem inputItem)
        {
            var dto = new BankBillItemDto()
            {
                  
  
		BankBillItemId = inputItem.BankBillItemId,  
  
		BankBillRef = inputItem.BankBillRef,  
  
		VoucherNumber = inputItem.VoucherNumber,  
  
		VoucherDate = inputItem.VoucherDate,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<BankBillItemDto> Map(ICollection<BankBillItem> entities)
        {
            var dtos = new List<BankBillItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BankBillItemDto()
                {
                      
  
		BankBillItemId = inputItem.BankBillItemId,  
  
		BankBillRef = inputItem.BankBillRef,  
  
		VoucherNumber = inputItem.VoucherNumber,  
  
		VoucherDate = inputItem.VoucherDate,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BankBranch Map(AddBankBranchCommand inputItem)
        {
            var entity = new BankBranch() {
                  
  
		BankBranchId = inputItem.BankBranchId,  
  
		BankRef = inputItem.BankRef,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		LocationRef = inputItem.LocationRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BankBranch Map(BankBranch entity ,EditBankBranchCommand inputItem)
        {
              
  
		entity.BankBranchId = inputItem.BankBranchId;  
  
		entity.BankRef = inputItem.BankRef;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.LocationRef = inputItem.LocationRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BankBranchDto Map(BankBranch inputItem)
        {
            var dto = new BankBranchDto()
            {
                  
  
		BankBranchId = inputItem.BankBranchId,  
  
		BankRef = inputItem.BankRef,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		LocationRef = inputItem.LocationRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<BankBranchDto> Map(ICollection<BankBranch> entities)
        {
            var dtos = new List<BankBranchDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BankBranchDto()
                {
                      
  
		BankBranchId = inputItem.BankBranchId,  
  
		BankRef = inputItem.BankRef,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		LocationRef = inputItem.LocationRef,  
  
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
        
        public static Cash Map(AddCashCommand inputItem)
        {
            var entity = new Cash() {
                  
  
		CashId = inputItem.CashId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		DlRef = inputItem.DlRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		FirstAmount = inputItem.FirstAmount,  
  
		FirstDate = inputItem.FirstDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Balance = inputItem.Balance, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Cash Map(Cash entity ,EditCashCommand inputItem)
        {
              
  
		entity.CashId = inputItem.CashId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.DlRef = inputItem.DlRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.FirstAmount = inputItem.FirstAmount;  
  
		entity.FirstDate = inputItem.FirstDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Balance = inputItem.Balance; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CashDto Map(Cash inputItem)
        {
            var dto = new CashDto()
            {
                  
  
		CashId = inputItem.CashId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		DlRef = inputItem.DlRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		FirstAmount = inputItem.FirstAmount,  
  
		FirstDate = inputItem.FirstDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Balance = inputItem.Balance, 
            };
            return dto;
        }

        public static List<CashDto> Map(ICollection<Cash> entities)
        {
            var dtos = new List<CashDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CashDto()
                {
                      
  
		CashId = inputItem.CashId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		DlRef = inputItem.DlRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		FirstAmount = inputItem.FirstAmount,  
  
		FirstDate = inputItem.FirstDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Balance = inputItem.Balance, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CashBalance Map(AddCashBalanceCommand inputItem)
        {
            var entity = new CashBalance() {
                  
  
		CashBalanceId = inputItem.CashBalanceId,  
  
		Balance = inputItem.Balance,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CashRef = inputItem.CashRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CashBalance Map(CashBalance entity ,EditCashBalanceCommand inputItem)
        {
              
  
		entity.CashBalanceId = inputItem.CashBalanceId;  
  
		entity.Balance = inputItem.Balance;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.CashRef = inputItem.CashRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CashBalanceDto Map(CashBalance inputItem)
        {
            var dto = new CashBalanceDto()
            {
                  
  
		CashBalanceId = inputItem.CashBalanceId,  
  
		Balance = inputItem.Balance,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CashRef = inputItem.CashRef, 
            };
            return dto;
        }

        public static List<CashBalanceDto> Map(ICollection<CashBalance> entities)
        {
            var dtos = new List<CashBalanceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CashBalanceDto()
                {
                      
  
		CashBalanceId = inputItem.CashBalanceId,  
  
		Balance = inputItem.Balance,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CashRef = inputItem.CashRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ChequeBook Map(AddChequeBookCommand inputItem)
        {
            var entity = new ChequeBook() {
                  
  
		ChequeBookId = inputItem.ChequeBookId,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		beginNumber = inputItem.beginNumber,  
  
		Count = inputItem.Count,  
  
		PrintFormat = inputItem.PrintFormat,  
  
		Series = inputItem.Series,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ChequeBook Map(ChequeBook entity ,EditChequeBookCommand inputItem)
        {
              
  
		entity.ChequeBookId = inputItem.ChequeBookId;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.beginNumber = inputItem.beginNumber;  
  
		entity.Count = inputItem.Count;  
  
		entity.PrintFormat = inputItem.PrintFormat;  
  
		entity.Series = inputItem.Series;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ChequeBookDto Map(ChequeBook inputItem)
        {
            var dto = new ChequeBookDto()
            {
                  
  
		ChequeBookId = inputItem.ChequeBookId,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		beginNumber = inputItem.beginNumber,  
  
		Count = inputItem.Count,  
  
		PrintFormat = inputItem.PrintFormat,  
  
		Series = inputItem.Series,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<ChequeBookDto> Map(ICollection<ChequeBook> entities)
        {
            var dtos = new List<ChequeBookDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ChequeBookDto()
                {
                      
  
		ChequeBookId = inputItem.ChequeBookId,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		beginNumber = inputItem.beginNumber,  
  
		Count = inputItem.Count,  
  
		PrintFormat = inputItem.PrintFormat,  
  
		Series = inputItem.Series,  
  
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
        
        public static DocSpecification Map(AddDocSpecificationCommand inputItem)
        {
            var entity = new DocSpecification() {
                  
  
		DocSpecificationId = inputItem.DocSpecificationId,  
  
		TableName = inputItem.TableName,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DocSpecification Map(DocSpecification entity ,EditDocSpecificationCommand inputItem)
        {
              
  
		entity.DocSpecificationId = inputItem.DocSpecificationId;  
  
		entity.TableName = inputItem.TableName;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DocSpecificationDto Map(DocSpecification inputItem)
        {
            var dto = new DocSpecificationDto()
            {
                  
  
		DocSpecificationId = inputItem.DocSpecificationId,  
  
		TableName = inputItem.TableName,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<DocSpecificationDto> Map(ICollection<DocSpecification> entities)
        {
            var dtos = new List<DocSpecificationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DocSpecificationDto()
                {
                      
  
		DocSpecificationId = inputItem.DocSpecificationId,  
  
		TableName = inputItem.TableName,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartyAccountSettlement Map(AddPartyAccountSettlementCommand inputItem)
        {
            var entity = new PartyAccountSettlement() {
                  
  
		PartyAccountSettlementID = inputItem.PartyAccountSettlementID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		PartyRef = inputItem.PartyRef,  
  
		PartyAccountSettlementType = inputItem.PartyAccountSettlementType,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		OldPartySettlementID = inputItem.OldPartySettlementID, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartyAccountSettlement Map(PartyAccountSettlement entity ,EditPartyAccountSettlementCommand inputItem)
        {
              
  
		entity.PartyAccountSettlementID = inputItem.PartyAccountSettlementID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.State = inputItem.State;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.PartyAccountSettlementType = inputItem.PartyAccountSettlementType;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.CreatorForm = inputItem.CreatorForm;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.OldPartySettlementID = inputItem.OldPartySettlementID; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartyAccountSettlementDto Map(PartyAccountSettlement inputItem)
        {
            var dto = new PartyAccountSettlementDto()
            {
                  
  
		PartyAccountSettlementID = inputItem.PartyAccountSettlementID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		PartyRef = inputItem.PartyRef,  
  
		PartyAccountSettlementType = inputItem.PartyAccountSettlementType,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		OldPartySettlementID = inputItem.OldPartySettlementID, 
            };
            return dto;
        }

        public static List<PartyAccountSettlementDto> Map(ICollection<PartyAccountSettlement> entities)
        {
            var dtos = new List<PartyAccountSettlementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartyAccountSettlementDto()
                {
                      
  
		PartyAccountSettlementID = inputItem.PartyAccountSettlementID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		PartyRef = inputItem.PartyRef,  
  
		PartyAccountSettlementType = inputItem.PartyAccountSettlementType,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		OldPartySettlementID = inputItem.OldPartySettlementID, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartyAccountSettlementItem Map(AddPartyAccountSettlementItemCommand inputItem)
        {
            var entity = new PartyAccountSettlementItem() {
                  
  
		PartyAccountSettlementItemID = inputItem.PartyAccountSettlementItemID,  
  
		PartyAccountSettlementRef = inputItem.PartyAccountSettlementRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Amount = inputItem.Amount,  
  
		DebitEntityType = inputItem.DebitEntityType,  
  
		DebitEntityRef = inputItem.DebitEntityRef,  
  
		CreditEntityType = inputItem.CreditEntityType,  
  
		CreditEntityRef = inputItem.CreditEntityRef,  
  
		IsSettled = inputItem.IsSettled,  
  
		OldPartySettlementItemID = inputItem.OldPartySettlementItemID,  
  
		OldPartySettlementID = inputItem.OldPartySettlementID, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartyAccountSettlementItem Map(PartyAccountSettlementItem entity ,EditPartyAccountSettlementItemCommand inputItem)
        {
              
  
		entity.PartyAccountSettlementItemID = inputItem.PartyAccountSettlementItemID;  
  
		entity.PartyAccountSettlementRef = inputItem.PartyAccountSettlementRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.DebitEntityType = inputItem.DebitEntityType;  
  
		entity.DebitEntityRef = inputItem.DebitEntityRef;  
  
		entity.CreditEntityType = inputItem.CreditEntityType;  
  
		entity.CreditEntityRef = inputItem.CreditEntityRef;  
  
		entity.IsSettled = inputItem.IsSettled;  
  
		entity.OldPartySettlementItemID = inputItem.OldPartySettlementItemID;  
  
		entity.OldPartySettlementID = inputItem.OldPartySettlementID; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartyAccountSettlementItemDto Map(PartyAccountSettlementItem inputItem)
        {
            var dto = new PartyAccountSettlementItemDto()
            {
                  
  
		PartyAccountSettlementItemID = inputItem.PartyAccountSettlementItemID,  
  
		PartyAccountSettlementRef = inputItem.PartyAccountSettlementRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Amount = inputItem.Amount,  
  
		DebitEntityType = inputItem.DebitEntityType,  
  
		DebitEntityRef = inputItem.DebitEntityRef,  
  
		CreditEntityType = inputItem.CreditEntityType,  
  
		CreditEntityRef = inputItem.CreditEntityRef,  
  
		IsSettled = inputItem.IsSettled,  
  
		OldPartySettlementItemID = inputItem.OldPartySettlementItemID,  
  
		OldPartySettlementID = inputItem.OldPartySettlementID, 
            };
            return dto;
        }

        public static List<PartyAccountSettlementItemDto> Map(ICollection<PartyAccountSettlementItem> entities)
        {
            var dtos = new List<PartyAccountSettlementItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartyAccountSettlementItemDto()
                {
                      
  
		PartyAccountSettlementItemID = inputItem.PartyAccountSettlementItemID,  
  
		PartyAccountSettlementRef = inputItem.PartyAccountSettlementRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Amount = inputItem.Amount,  
  
		DebitEntityType = inputItem.DebitEntityType,  
  
		DebitEntityRef = inputItem.DebitEntityRef,  
  
		CreditEntityType = inputItem.CreditEntityType,  
  
		CreditEntityRef = inputItem.CreditEntityRef,  
  
		IsSettled = inputItem.IsSettled,  
  
		OldPartySettlementItemID = inputItem.OldPartySettlementItemID,  
  
		OldPartySettlementID = inputItem.OldPartySettlementID, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartySettlement Map(AddPartySettlementCommand inputItem)
        {
            var entity = new PartySettlement() {
                  
  
		PartySettlementID = inputItem.PartySettlementID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		PartyRef = inputItem.PartyRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		SettlementByRemainingAmount = inputItem.SettlementByRemainingAmount,  
  
		SettlementByRemainingAmountInBaseCurrency = inputItem.SettlementByRemainingAmountInBaseCurrency,  
  
		SettlementByRemainingRate = inputItem.SettlementByRemainingRate,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		SettlementType = inputItem.SettlementType,  
  
		Description = inputItem.Description,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
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

        public static PartySettlement Map(PartySettlement entity ,EditPartySettlementCommand inputItem)
        {
              
  
		entity.PartySettlementID = inputItem.PartySettlementID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.State = inputItem.State;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.SettlementByRemainingAmount = inputItem.SettlementByRemainingAmount;  
  
		entity.SettlementByRemainingAmountInBaseCurrency = inputItem.SettlementByRemainingAmountInBaseCurrency;  
  
		entity.SettlementByRemainingRate = inputItem.SettlementByRemainingRate;  
  
		entity.ReceiptHeaderRef = inputItem.ReceiptHeaderRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.SettlementType = inputItem.SettlementType;  
  
		entity.Description = inputItem.Description;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.CreatorForm = inputItem.CreatorForm;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartySettlementDto Map(PartySettlement inputItem)
        {
            var dto = new PartySettlementDto()
            {
                  
  
		PartySettlementID = inputItem.PartySettlementID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		PartyRef = inputItem.PartyRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		SettlementByRemainingAmount = inputItem.SettlementByRemainingAmount,  
  
		SettlementByRemainingAmountInBaseCurrency = inputItem.SettlementByRemainingAmountInBaseCurrency,  
  
		SettlementByRemainingRate = inputItem.SettlementByRemainingRate,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		SettlementType = inputItem.SettlementType,  
  
		Description = inputItem.Description,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PartySettlementDto> Map(ICollection<PartySettlement> entities)
        {
            var dtos = new List<PartySettlementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartySettlementDto()
                {
                      
  
		PartySettlementID = inputItem.PartySettlementID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		PartyRef = inputItem.PartyRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		SettlementByRemainingAmount = inputItem.SettlementByRemainingAmount,  
  
		SettlementByRemainingAmountInBaseCurrency = inputItem.SettlementByRemainingAmountInBaseCurrency,  
  
		SettlementByRemainingRate = inputItem.SettlementByRemainingRate,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		SettlementType = inputItem.SettlementType,  
  
		Description = inputItem.Description,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
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
        
        public static PartySettlementItem Map(AddPartySettlementItemCommand inputItem)
        {
            var entity = new PartySettlementItem() {
                  
  
		PartySettlementItemID = inputItem.PartySettlementItemID,  
  
		PartySettlementRef = inputItem.PartySettlementRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		RemainingAmount = inputItem.RemainingAmount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartySettlementItem Map(PartySettlementItem entity ,EditPartySettlementItemCommand inputItem)
        {
              
  
		entity.PartySettlementItemID = inputItem.PartySettlementItemID;  
  
		entity.PartySettlementRef = inputItem.PartySettlementRef;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.CommissionCalculationRef = inputItem.CommissionCalculationRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.RemainingAmount = inputItem.RemainingAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartySettlementItemDto Map(PartySettlementItem inputItem)
        {
            var dto = new PartySettlementItemDto()
            {
                  
  
		PartySettlementItemID = inputItem.PartySettlementItemID,  
  
		PartySettlementRef = inputItem.PartySettlementRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		RemainingAmount = inputItem.RemainingAmount, 
            };
            return dto;
        }

        public static List<PartySettlementItemDto> Map(ICollection<PartySettlementItem> entities)
        {
            var dtos = new List<PartySettlementItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartySettlementItemDto()
                {
                      
  
		PartySettlementItemID = inputItem.PartySettlementItemID,  
  
		PartySettlementRef = inputItem.PartySettlementRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		RemainingAmount = inputItem.RemainingAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaymentCheque Map(AddPaymentChequeCommand inputItem)
        {
            var entity = new PaymentCheque() {
                  
  
		PaymentChequeId = inputItem.PaymentChequeId,  
  
		Number = inputItem.Number,  
  
		SecondNumber = inputItem.SecondNumber,  
  
		IsGuarantee = inputItem.IsGuarantee,  
  
		Amount = inputItem.Amount,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		DurationType = inputItem.DurationType,  
  
		DlRef = inputItem.DlRef,  
  
		Type = inputItem.Type, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaymentCheque Map(PaymentCheque entity ,EditPaymentChequeCommand inputItem)
        {
              
  
		entity.PaymentChequeId = inputItem.PaymentChequeId;  
  
		entity.Number = inputItem.Number;  
  
		entity.SecondNumber = inputItem.SecondNumber;  
  
		entity.IsGuarantee = inputItem.IsGuarantee;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.Date = inputItem.Date;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.State = inputItem.State;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.HeaderNumber = inputItem.HeaderNumber;  
  
		entity.HeaderDate = inputItem.HeaderDate;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.DurationType = inputItem.DurationType;  
  
		entity.DlRef = inputItem.DlRef;  
  
		entity.Type = inputItem.Type; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaymentChequeDto Map(PaymentCheque inputItem)
        {
            var dto = new PaymentChequeDto()
            {
                  
  
		PaymentChequeId = inputItem.PaymentChequeId,  
  
		Number = inputItem.Number,  
  
		SecondNumber = inputItem.SecondNumber,  
  
		IsGuarantee = inputItem.IsGuarantee,  
  
		Amount = inputItem.Amount,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		DurationType = inputItem.DurationType,  
  
		DlRef = inputItem.DlRef,  
  
		Type = inputItem.Type, 
            };
            return dto;
        }

        public static List<PaymentChequeDto> Map(ICollection<PaymentCheque> entities)
        {
            var dtos = new List<PaymentChequeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaymentChequeDto()
                {
                      
  
		PaymentChequeId = inputItem.PaymentChequeId,  
  
		Number = inputItem.Number,  
  
		SecondNumber = inputItem.SecondNumber,  
  
		IsGuarantee = inputItem.IsGuarantee,  
  
		Amount = inputItem.Amount,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		DurationType = inputItem.DurationType,  
  
		DlRef = inputItem.DlRef,  
  
		Type = inputItem.Type, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaymentChequeBanking Map(AddPaymentChequeBankingCommand inputItem)
        {
            var entity = new PaymentChequeBanking() {
                  
  
		PaymentChequeBankingId = inputItem.PaymentChequeBankingId,  
  
		Date = inputItem.Date,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Number = inputItem.Number,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaymentChequeBanking Map(PaymentChequeBanking entity ,EditPaymentChequeBankingCommand inputItem)
        {
              
  
		entity.PaymentChequeBankingId = inputItem.PaymentChequeBankingId;  
  
		entity.Date = inputItem.Date;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.State = inputItem.State;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaymentChequeBankingDto Map(PaymentChequeBanking inputItem)
        {
            var dto = new PaymentChequeBankingDto()
            {
                  
  
		PaymentChequeBankingId = inputItem.PaymentChequeBankingId,  
  
		Date = inputItem.Date,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Number = inputItem.Number,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef, 
            };
            return dto;
        }

        public static List<PaymentChequeBankingDto> Map(ICollection<PaymentChequeBanking> entities)
        {
            var dtos = new List<PaymentChequeBankingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaymentChequeBankingDto()
                {
                      
  
		PaymentChequeBankingId = inputItem.PaymentChequeBankingId,  
  
		Date = inputItem.Date,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Number = inputItem.Number,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaymentChequeBankingItem Map(AddPaymentChequeBankingItemCommand inputItem)
        {
            var entity = new PaymentChequeBankingItem() {
                  
  
		PaymentChequeBankingItemId = inputItem.PaymentChequeBankingItemId,  
  
		PaymentChequeBankingRef = inputItem.PaymentChequeBankingRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		BankAccountRef = inputItem.BankAccountRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaymentChequeBankingItem Map(PaymentChequeBankingItem entity ,EditPaymentChequeBankingItemCommand inputItem)
        {
              
  
		entity.PaymentChequeBankingItemId = inputItem.PaymentChequeBankingItemId;  
  
		entity.PaymentChequeBankingRef = inputItem.PaymentChequeBankingRef;  
  
		entity.PaymentChequeRef = inputItem.PaymentChequeRef;  
  
		entity.HeaderDate = inputItem.HeaderDate;  
  
		entity.HeaderNumber = inputItem.HeaderNumber;  
  
		entity.BankAccountRef = inputItem.BankAccountRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaymentChequeBankingItemDto Map(PaymentChequeBankingItem inputItem)
        {
            var dto = new PaymentChequeBankingItemDto()
            {
                  
  
		PaymentChequeBankingItemId = inputItem.PaymentChequeBankingItemId,  
  
		PaymentChequeBankingRef = inputItem.PaymentChequeBankingRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		BankAccountRef = inputItem.BankAccountRef, 
            };
            return dto;
        }

        public static List<PaymentChequeBankingItemDto> Map(ICollection<PaymentChequeBankingItem> entities)
        {
            var dtos = new List<PaymentChequeBankingItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaymentChequeBankingItemDto()
                {
                      
  
		PaymentChequeBankingItemId = inputItem.PaymentChequeBankingItemId,  
  
		PaymentChequeBankingRef = inputItem.PaymentChequeBankingRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		BankAccountRef = inputItem.BankAccountRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaymentChequeHistory Map(AddPaymentChequeHistoryCommand inputItem)
        {
            var entity = new PaymentChequeHistory() {
                  
  
		PaymentChequeHistoryId = inputItem.PaymentChequeHistoryId,  
  
		State = inputItem.State,  
  
		Type = inputItem.Type,  
  
		Date = inputItem.Date,  
  
		DurationType = inputItem.DurationType,  
  
		PaymentChequeHistoryRef = inputItem.PaymentChequeHistoryRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		PaymentChequeBankingItemRef = inputItem.PaymentChequeBankingItemRef,  
  
		RefundChequeItemRef = inputItem.RefundChequeItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaymentChequeHistory Map(PaymentChequeHistory entity ,EditPaymentChequeHistoryCommand inputItem)
        {
              
  
		entity.PaymentChequeHistoryId = inputItem.PaymentChequeHistoryId;  
  
		entity.State = inputItem.State;  
  
		entity.Type = inputItem.Type;  
  
		entity.Date = inputItem.Date;  
  
		entity.DurationType = inputItem.DurationType;  
  
		entity.PaymentChequeHistoryRef = inputItem.PaymentChequeHistoryRef;  
  
		entity.PaymentChequeRef = inputItem.PaymentChequeRef;  
  
		entity.PaymentChequeBankingItemRef = inputItem.PaymentChequeBankingItemRef;  
  
		entity.RefundChequeItemRef = inputItem.RefundChequeItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaymentChequeHistoryDto Map(PaymentChequeHistory inputItem)
        {
            var dto = new PaymentChequeHistoryDto()
            {
                  
  
		PaymentChequeHistoryId = inputItem.PaymentChequeHistoryId,  
  
		State = inputItem.State,  
  
		Type = inputItem.Type,  
  
		Date = inputItem.Date,  
  
		DurationType = inputItem.DurationType,  
  
		PaymentChequeHistoryRef = inputItem.PaymentChequeHistoryRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		PaymentChequeBankingItemRef = inputItem.PaymentChequeBankingItemRef,  
  
		RefundChequeItemRef = inputItem.RefundChequeItemRef, 
            };
            return dto;
        }

        public static List<PaymentChequeHistoryDto> Map(ICollection<PaymentChequeHistory> entities)
        {
            var dtos = new List<PaymentChequeHistoryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaymentChequeHistoryDto()
                {
                      
  
		PaymentChequeHistoryId = inputItem.PaymentChequeHistoryId,  
  
		State = inputItem.State,  
  
		Type = inputItem.Type,  
  
		Date = inputItem.Date,  
  
		DurationType = inputItem.DurationType,  
  
		PaymentChequeHistoryRef = inputItem.PaymentChequeHistoryRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		PaymentChequeBankingItemRef = inputItem.PaymentChequeBankingItemRef,  
  
		RefundChequeItemRef = inputItem.RefundChequeItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaymentChequeOther Map(AddPaymentChequeOtherCommand inputItem)
        {
            var entity = new PaymentChequeOther() {
                  
  
		PaymentChequeOtherId = inputItem.PaymentChequeOtherId,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaymentChequeOther Map(PaymentChequeOther entity ,EditPaymentChequeOtherCommand inputItem)
        {
              
  
		entity.PaymentChequeOtherId = inputItem.PaymentChequeOtherId;  
  
		entity.ReceiptChequeRef = inputItem.ReceiptChequeRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.HeaderNumber = inputItem.HeaderNumber;  
  
		entity.HeaderDate = inputItem.HeaderDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaymentChequeOtherDto Map(PaymentChequeOther inputItem)
        {
            var dto = new PaymentChequeOtherDto()
            {
                  
  
		PaymentChequeOtherId = inputItem.PaymentChequeOtherId,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate, 
            };
            return dto;
        }

        public static List<PaymentChequeOtherDto> Map(ICollection<PaymentChequeOther> entities)
        {
            var dtos = new List<PaymentChequeOtherDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaymentChequeOtherDto()
                {
                      
  
		PaymentChequeOtherId = inputItem.PaymentChequeOtherId,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaymentDraft Map(AddPaymentDraftCommand inputItem)
        {
            var entity = new PaymentDraft() {
                  
  
		PaymentDraftId = inputItem.PaymentDraftId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Amount = inputItem.Amount,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		BankFeeAmount = inputItem.BankFeeAmount,  
  
		BankFeeAmountInBaseCurrency = inputItem.BankFeeAmountInBaseCurrency,  
  
		BankFeeAmountRate = inputItem.BankFeeAmountRate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaymentDraft Map(PaymentDraft entity ,EditPaymentDraftCommand inputItem)
        {
              
  
		entity.PaymentDraftId = inputItem.PaymentDraftId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.HeaderNumber = inputItem.HeaderNumber;  
  
		entity.HeaderDate = inputItem.HeaderDate;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.BankFeeAmount = inputItem.BankFeeAmount;  
  
		entity.BankFeeAmountInBaseCurrency = inputItem.BankFeeAmountInBaseCurrency;  
  
		entity.BankFeeAmountRate = inputItem.BankFeeAmountRate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaymentDraftDto Map(PaymentDraft inputItem)
        {
            var dto = new PaymentDraftDto()
            {
                  
  
		PaymentDraftId = inputItem.PaymentDraftId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Amount = inputItem.Amount,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		BankFeeAmount = inputItem.BankFeeAmount,  
  
		BankFeeAmountInBaseCurrency = inputItem.BankFeeAmountInBaseCurrency,  
  
		BankFeeAmountRate = inputItem.BankFeeAmountRate, 
            };
            return dto;
        }

        public static List<PaymentDraftDto> Map(ICollection<PaymentDraft> entities)
        {
            var dtos = new List<PaymentDraftDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaymentDraftDto()
                {
                      
  
		PaymentDraftId = inputItem.PaymentDraftId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Amount = inputItem.Amount,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		BankFeeAmount = inputItem.BankFeeAmount,  
  
		BankFeeAmountInBaseCurrency = inputItem.BankFeeAmountInBaseCurrency,  
  
		BankFeeAmountRate = inputItem.BankFeeAmountRate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaymentHeader Map(AddPaymentHeaderCommand inputItem)
        {
            var entity = new PaymentHeader() {
                  
  
		PaymentHeaderId = inputItem.PaymentHeaderId,  
  
		Type = inputItem.Type,  
  
		AccountSlRef = inputItem.AccountSlRef,  
  
		DlRef = inputItem.DlRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Discount = inputItem.Discount,  
  
		TotalAmount = inputItem.TotalAmount,  
  
		ItemType = inputItem.ItemType,  
  
		State = inputItem.State,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		Rate = inputItem.Rate,  
  
		CashRef = inputItem.CashRef,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		DiscountRate = inputItem.DiscountRate,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		BankFeeSlRef = inputItem.BankFeeSlRef,  
  
		TotalAmountInBaseCurrency = inputItem.TotalAmountInBaseCurrency,  
  
		PaymentAmount = inputItem.PaymentAmount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaymentHeader Map(PaymentHeader entity ,EditPaymentHeaderCommand inputItem)
        {
              
  
		entity.PaymentHeaderId = inputItem.PaymentHeaderId;  
  
		entity.Type = inputItem.Type;  
  
		entity.AccountSlRef = inputItem.AccountSlRef;  
  
		entity.DlRef = inputItem.DlRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.TotalAmount = inputItem.TotalAmount;  
  
		entity.ItemType = inputItem.ItemType;  
  
		entity.State = inputItem.State;  
  
		entity.CreatorForm = inputItem.CreatorForm;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.CashRef = inputItem.CashRef;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.ReceiptHeaderRef = inputItem.ReceiptHeaderRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.DiscountRate = inputItem.DiscountRate;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.BankFeeSlRef = inputItem.BankFeeSlRef;  
  
		entity.TotalAmountInBaseCurrency = inputItem.TotalAmountInBaseCurrency;  
  
		entity.PaymentAmount = inputItem.PaymentAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaymentHeaderDto Map(PaymentHeader inputItem)
        {
            var dto = new PaymentHeaderDto()
            {
                  
  
		PaymentHeaderId = inputItem.PaymentHeaderId,  
  
		Type = inputItem.Type,  
  
		AccountSlRef = inputItem.AccountSlRef,  
  
		DlRef = inputItem.DlRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Discount = inputItem.Discount,  
  
		TotalAmount = inputItem.TotalAmount,  
  
		ItemType = inputItem.ItemType,  
  
		State = inputItem.State,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		Rate = inputItem.Rate,  
  
		CashRef = inputItem.CashRef,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		DiscountRate = inputItem.DiscountRate,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		BankFeeSlRef = inputItem.BankFeeSlRef,  
  
		TotalAmountInBaseCurrency = inputItem.TotalAmountInBaseCurrency,  
  
		PaymentAmount = inputItem.PaymentAmount, 
            };
            return dto;
        }

        public static List<PaymentHeaderDto> Map(ICollection<PaymentHeader> entities)
        {
            var dtos = new List<PaymentHeaderDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaymentHeaderDto()
                {
                      
  
		PaymentHeaderId = inputItem.PaymentHeaderId,  
  
		Type = inputItem.Type,  
  
		AccountSlRef = inputItem.AccountSlRef,  
  
		DlRef = inputItem.DlRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Discount = inputItem.Discount,  
  
		TotalAmount = inputItem.TotalAmount,  
  
		ItemType = inputItem.ItemType,  
  
		State = inputItem.State,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		Rate = inputItem.Rate,  
  
		CashRef = inputItem.CashRef,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		DiscountRate = inputItem.DiscountRate,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		BankFeeSlRef = inputItem.BankFeeSlRef,  
  
		TotalAmountInBaseCurrency = inputItem.TotalAmountInBaseCurrency,  
  
		PaymentAmount = inputItem.PaymentAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Pos Map(AddPosCommand inputItem)
        {
            var entity = new Pos() {
                  
  
		PosId = inputItem.PosId,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		TerminalNo = inputItem.TerminalNo,  
  
		DlRef = inputItem.DlRef,  
  
		FirstAmount = inputItem.FirstAmount,  
  
		Rate = inputItem.Rate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Balance = inputItem.Balance, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Pos Map(Pos entity ,EditPosCommand inputItem)
        {
              
  
		entity.PosId = inputItem.PosId;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.TerminalNo = inputItem.TerminalNo;  
  
		entity.DlRef = inputItem.DlRef;  
  
		entity.FirstAmount = inputItem.FirstAmount;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Balance = inputItem.Balance; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PosDto Map(Pos inputItem)
        {
            var dto = new PosDto()
            {
                  
  
		PosId = inputItem.PosId,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		TerminalNo = inputItem.TerminalNo,  
  
		DlRef = inputItem.DlRef,  
  
		FirstAmount = inputItem.FirstAmount,  
  
		Rate = inputItem.Rate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Balance = inputItem.Balance, 
            };
            return dto;
        }

        public static List<PosDto> Map(ICollection<Pos> entities)
        {
            var dtos = new List<PosDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PosDto()
                {
                      
  
		PosId = inputItem.PosId,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		TerminalNo = inputItem.TerminalNo,  
  
		DlRef = inputItem.DlRef,  
  
		FirstAmount = inputItem.FirstAmount,  
  
		Rate = inputItem.Rate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Balance = inputItem.Balance, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PosBalance Map(AddPosBalanceCommand inputItem)
        {
            var entity = new PosBalance() {
                  
  
		PosBalanceId = inputItem.PosBalanceId,  
  
		Balance = inputItem.Balance,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		PosRef = inputItem.PosRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PosBalance Map(PosBalance entity ,EditPosBalanceCommand inputItem)
        {
              
  
		entity.PosBalanceId = inputItem.PosBalanceId;  
  
		entity.Balance = inputItem.Balance;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.PosRef = inputItem.PosRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PosBalanceDto Map(PosBalance inputItem)
        {
            var dto = new PosBalanceDto()
            {
                  
  
		PosBalanceId = inputItem.PosBalanceId,  
  
		Balance = inputItem.Balance,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		PosRef = inputItem.PosRef, 
            };
            return dto;
        }

        public static List<PosBalanceDto> Map(ICollection<PosBalance> entities)
        {
            var dtos = new List<PosBalanceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PosBalanceDto()
                {
                      
  
		PosBalanceId = inputItem.PosBalanceId,  
  
		Balance = inputItem.Balance,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		PosRef = inputItem.PosRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PosSettlement Map(AddPosSettlementCommand inputItem)
        {
            var entity = new PosSettlement() {
                  
  
		PosSettlementID = inputItem.PosSettlementID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		SettleReceiptsTo = inputItem.SettleReceiptsTo,  
  
		PosRef = inputItem.PosRef,  
  
		SettlementReceiptRef = inputItem.SettlementReceiptRef,  
  
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

        public static PosSettlement Map(PosSettlement entity ,EditPosSettlementCommand inputItem)
        {
              
  
		entity.PosSettlementID = inputItem.PosSettlementID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.SettleReceiptsTo = inputItem.SettleReceiptsTo;  
  
		entity.PosRef = inputItem.PosRef;  
  
		entity.SettlementReceiptRef = inputItem.SettlementReceiptRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PosSettlementDto Map(PosSettlement inputItem)
        {
            var dto = new PosSettlementDto()
            {
                  
  
		PosSettlementID = inputItem.PosSettlementID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		SettleReceiptsTo = inputItem.SettleReceiptsTo,  
  
		PosRef = inputItem.PosRef,  
  
		SettlementReceiptRef = inputItem.SettlementReceiptRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
            };
            return dto;
        }

        public static List<PosSettlementDto> Map(ICollection<PosSettlement> entities)
        {
            var dtos = new List<PosSettlementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PosSettlementDto()
                {
                      
  
		PosSettlementID = inputItem.PosSettlementID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		SettleReceiptsTo = inputItem.SettleReceiptsTo,  
  
		PosRef = inputItem.PosRef,  
  
		SettlementReceiptRef = inputItem.SettlementReceiptRef,  
  
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
        
        public static PosSettlementReceipt Map(AddPosSettlementReceiptCommand inputItem)
        {
            var entity = new PosSettlementReceipt() {
                  
  
		PosSettlementReceiptID = inputItem.PosSettlementReceiptID,  
  
		PosSettlementRef = inputItem.PosSettlementRef,  
  
		ReceiptPosRef = inputItem.ReceiptPosRef,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PosSettlementReceipt Map(PosSettlementReceipt entity ,EditPosSettlementReceiptCommand inputItem)
        {
              
  
		entity.PosSettlementReceiptID = inputItem.PosSettlementReceiptID;  
  
		entity.PosSettlementRef = inputItem.PosSettlementRef;  
  
		entity.ReceiptPosRef = inputItem.ReceiptPosRef;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PosSettlementReceiptDto Map(PosSettlementReceipt inputItem)
        {
            var dto = new PosSettlementReceiptDto()
            {
                  
  
		PosSettlementReceiptID = inputItem.PosSettlementReceiptID,  
  
		PosSettlementRef = inputItem.PosSettlementRef,  
  
		ReceiptPosRef = inputItem.ReceiptPosRef,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PosSettlementReceiptDto> Map(ICollection<PosSettlementReceipt> entities)
        {
            var dtos = new List<PosSettlementReceiptDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PosSettlementReceiptDto()
                {
                      
  
		PosSettlementReceiptID = inputItem.PosSettlementReceiptID,  
  
		PosSettlementRef = inputItem.PosSettlementRef,  
  
		ReceiptPosRef = inputItem.ReceiptPosRef,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReceiptCheque Map(AddReceiptChequeCommand inputItem)
        {
            var entity = new ReceiptCheque() {
                  
  
		ReceiptChequeId = inputItem.ReceiptChequeId,  
  
		Number = inputItem.Number,  
  
		SecondNumber = inputItem.SecondNumber,  
  
		IsGuarantee = inputItem.IsGuarantee,  
  
		AccountNo = inputItem.AccountNo,  
  
		Amount = inputItem.Amount,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		CashRef = inputItem.CashRef,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		BankRef = inputItem.BankRef,  
  
		BranchCode = inputItem.BranchCode,  
  
		BranchTitle = inputItem.BranchTitle,  
  
		LocationRef = inputItem.LocationRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		DlRef = inputItem.DlRef,  
  
		Type = inputItem.Type,  
  
		InitState = inputItem.InitState, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReceiptCheque Map(ReceiptCheque entity ,EditReceiptChequeCommand inputItem)
        {
              
  
		entity.ReceiptChequeId = inputItem.ReceiptChequeId;  
  
		entity.Number = inputItem.Number;  
  
		entity.SecondNumber = inputItem.SecondNumber;  
  
		entity.IsGuarantee = inputItem.IsGuarantee;  
  
		entity.AccountNo = inputItem.AccountNo;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.Date = inputItem.Date;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.State = inputItem.State;  
  
		entity.CashRef = inputItem.CashRef;  
  
		entity.ReceiptHeaderRef = inputItem.ReceiptHeaderRef;  
  
		entity.BankRef = inputItem.BankRef;  
  
		entity.BranchCode = inputItem.BranchCode;  
  
		entity.BranchTitle = inputItem.BranchTitle;  
  
		entity.LocationRef = inputItem.LocationRef;  
  
		entity.HeaderNumber = inputItem.HeaderNumber;  
  
		entity.HeaderDate = inputItem.HeaderDate;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.BankBranchRef = inputItem.BankBranchRef;  
  
		entity.DlRef = inputItem.DlRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.InitState = inputItem.InitState; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReceiptChequeDto Map(ReceiptCheque inputItem)
        {
            var dto = new ReceiptChequeDto()
            {
                  
  
		ReceiptChequeId = inputItem.ReceiptChequeId,  
  
		Number = inputItem.Number,  
  
		SecondNumber = inputItem.SecondNumber,  
  
		IsGuarantee = inputItem.IsGuarantee,  
  
		AccountNo = inputItem.AccountNo,  
  
		Amount = inputItem.Amount,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		CashRef = inputItem.CashRef,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		BankRef = inputItem.BankRef,  
  
		BranchCode = inputItem.BranchCode,  
  
		BranchTitle = inputItem.BranchTitle,  
  
		LocationRef = inputItem.LocationRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		DlRef = inputItem.DlRef,  
  
		Type = inputItem.Type,  
  
		InitState = inputItem.InitState, 
            };
            return dto;
        }

        public static List<ReceiptChequeDto> Map(ICollection<ReceiptCheque> entities)
        {
            var dtos = new List<ReceiptChequeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReceiptChequeDto()
                {
                      
  
		ReceiptChequeId = inputItem.ReceiptChequeId,  
  
		Number = inputItem.Number,  
  
		SecondNumber = inputItem.SecondNumber,  
  
		IsGuarantee = inputItem.IsGuarantee,  
  
		AccountNo = inputItem.AccountNo,  
  
		Amount = inputItem.Amount,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		CashRef = inputItem.CashRef,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		BankRef = inputItem.BankRef,  
  
		BranchCode = inputItem.BranchCode,  
  
		BranchTitle = inputItem.BranchTitle,  
  
		LocationRef = inputItem.LocationRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		DlRef = inputItem.DlRef,  
  
		Type = inputItem.Type,  
  
		InitState = inputItem.InitState, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReceiptChequeBanking Map(AddReceiptChequeBankingCommand inputItem)
        {
            var entity = new ReceiptChequeBanking() {
                  
  
		ReceiptChequeBankingId = inputItem.ReceiptChequeBankingId,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		RelationNo = inputItem.RelationNo,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Number = inputItem.Number,  
  
		Creator = inputItem.Creator,  
  
		Version = inputItem.Version,  
  
		ReceiptChequeBankingRef = inputItem.ReceiptChequeBankingRef,  
  
		CashRef = inputItem.CashRef,  
  
		State = inputItem.State,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		SubmitNumber = inputItem.SubmitNumber, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReceiptChequeBanking Map(ReceiptChequeBanking entity ,EditReceiptChequeBankingCommand inputItem)
        {
              
  
		entity.ReceiptChequeBankingId = inputItem.ReceiptChequeBankingId;  
  
		entity.Date = inputItem.Date;  
  
		entity.Type = inputItem.Type;  
  
		entity.RelationNo = inputItem.RelationNo;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Version = inputItem.Version;  
  
		entity.ReceiptChequeBankingRef = inputItem.ReceiptChequeBankingRef;  
  
		entity.CashRef = inputItem.CashRef;  
  
		entity.State = inputItem.State;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.SubmitNumber = inputItem.SubmitNumber; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReceiptChequeBankingDto Map(ReceiptChequeBanking inputItem)
        {
            var dto = new ReceiptChequeBankingDto()
            {
                  
  
		ReceiptChequeBankingId = inputItem.ReceiptChequeBankingId,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		RelationNo = inputItem.RelationNo,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Number = inputItem.Number,  
  
		Creator = inputItem.Creator,  
  
		Version = inputItem.Version,  
  
		ReceiptChequeBankingRef = inputItem.ReceiptChequeBankingRef,  
  
		CashRef = inputItem.CashRef,  
  
		State = inputItem.State,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		SubmitNumber = inputItem.SubmitNumber, 
            };
            return dto;
        }

        public static List<ReceiptChequeBankingDto> Map(ICollection<ReceiptChequeBanking> entities)
        {
            var dtos = new List<ReceiptChequeBankingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReceiptChequeBankingDto()
                {
                      
  
		ReceiptChequeBankingId = inputItem.ReceiptChequeBankingId,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		RelationNo = inputItem.RelationNo,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Number = inputItem.Number,  
  
		Creator = inputItem.Creator,  
  
		Version = inputItem.Version,  
  
		ReceiptChequeBankingRef = inputItem.ReceiptChequeBankingRef,  
  
		CashRef = inputItem.CashRef,  
  
		State = inputItem.State,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		SubmitNumber = inputItem.SubmitNumber, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReceiptChequeBankingItem Map(AddReceiptChequeBankingItemCommand inputItem)
        {
            var entity = new ReceiptChequeBankingItem() {
                  
  
		ReceiptChequeBankingItemId = inputItem.ReceiptChequeBankingItemId,  
  
		ReceiptChequeBankingRef = inputItem.ReceiptChequeBankingRef,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef,  
  
		ForcastDate = inputItem.ForcastDate,  
  
		State = inputItem.State,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		CashRef = inputItem.CashRef,  
  
		HeaderState = inputItem.HeaderState, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReceiptChequeBankingItem Map(ReceiptChequeBankingItem entity ,EditReceiptChequeBankingItemCommand inputItem)
        {
              
  
		entity.ReceiptChequeBankingItemId = inputItem.ReceiptChequeBankingItemId;  
  
		entity.ReceiptChequeBankingRef = inputItem.ReceiptChequeBankingRef;  
  
		entity.ReceiptChequeRef = inputItem.ReceiptChequeRef;  
  
		entity.ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef;  
  
		entity.ForcastDate = inputItem.ForcastDate;  
  
		entity.State = inputItem.State;  
  
		entity.HeaderDate = inputItem.HeaderDate;  
  
		entity.HeaderNumber = inputItem.HeaderNumber;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.CashRef = inputItem.CashRef;  
  
		entity.HeaderState = inputItem.HeaderState; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReceiptChequeBankingItemDto Map(ReceiptChequeBankingItem inputItem)
        {
            var dto = new ReceiptChequeBankingItemDto()
            {
                  
  
		ReceiptChequeBankingItemId = inputItem.ReceiptChequeBankingItemId,  
  
		ReceiptChequeBankingRef = inputItem.ReceiptChequeBankingRef,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef,  
  
		ForcastDate = inputItem.ForcastDate,  
  
		State = inputItem.State,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		CashRef = inputItem.CashRef,  
  
		HeaderState = inputItem.HeaderState, 
            };
            return dto;
        }

        public static List<ReceiptChequeBankingItemDto> Map(ICollection<ReceiptChequeBankingItem> entities)
        {
            var dtos = new List<ReceiptChequeBankingItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReceiptChequeBankingItemDto()
                {
                      
  
		ReceiptChequeBankingItemId = inputItem.ReceiptChequeBankingItemId,  
  
		ReceiptChequeBankingRef = inputItem.ReceiptChequeBankingRef,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef,  
  
		ForcastDate = inputItem.ForcastDate,  
  
		State = inputItem.State,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		CashRef = inputItem.CashRef,  
  
		HeaderState = inputItem.HeaderState, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReceiptChequeHistory Map(AddReceiptChequeHistoryCommand inputItem)
        {
            var entity = new ReceiptChequeHistory() {
                  
  
		ReceiptChequeHistoryId = inputItem.ReceiptChequeHistoryId,  
  
		State = inputItem.State,  
  
		Type = inputItem.Type,  
  
		Date = inputItem.Date,  
  
		ReceiptChequeHistoryRef = inputItem.ReceiptChequeHistoryRef,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef,  
  
		PaymentChequeOtherRef = inputItem.PaymentChequeOtherRef,  
  
		RefundChequeItemRef = inputItem.RefundChequeItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReceiptChequeHistory Map(ReceiptChequeHistory entity ,EditReceiptChequeHistoryCommand inputItem)
        {
              
  
		entity.ReceiptChequeHistoryId = inputItem.ReceiptChequeHistoryId;  
  
		entity.State = inputItem.State;  
  
		entity.Type = inputItem.Type;  
  
		entity.Date = inputItem.Date;  
  
		entity.ReceiptChequeHistoryRef = inputItem.ReceiptChequeHistoryRef;  
  
		entity.ReceiptChequeRef = inputItem.ReceiptChequeRef;  
  
		entity.ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef;  
  
		entity.PaymentChequeOtherRef = inputItem.PaymentChequeOtherRef;  
  
		entity.RefundChequeItemRef = inputItem.RefundChequeItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReceiptChequeHistoryDto Map(ReceiptChequeHistory inputItem)
        {
            var dto = new ReceiptChequeHistoryDto()
            {
                  
  
		ReceiptChequeHistoryId = inputItem.ReceiptChequeHistoryId,  
  
		State = inputItem.State,  
  
		Type = inputItem.Type,  
  
		Date = inputItem.Date,  
  
		ReceiptChequeHistoryRef = inputItem.ReceiptChequeHistoryRef,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef,  
  
		PaymentChequeOtherRef = inputItem.PaymentChequeOtherRef,  
  
		RefundChequeItemRef = inputItem.RefundChequeItemRef, 
            };
            return dto;
        }

        public static List<ReceiptChequeHistoryDto> Map(ICollection<ReceiptChequeHistory> entities)
        {
            var dtos = new List<ReceiptChequeHistoryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReceiptChequeHistoryDto()
                {
                      
  
		ReceiptChequeHistoryId = inputItem.ReceiptChequeHistoryId,  
  
		State = inputItem.State,  
  
		Type = inputItem.Type,  
  
		Date = inputItem.Date,  
  
		ReceiptChequeHistoryRef = inputItem.ReceiptChequeHistoryRef,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef,  
  
		PaymentChequeOtherRef = inputItem.PaymentChequeOtherRef,  
  
		RefundChequeItemRef = inputItem.RefundChequeItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReceiptDraft Map(AddReceiptDraftCommand inputItem)
        {
            var entity = new ReceiptDraft() {
                  
  
		ReceiptDraftId = inputItem.ReceiptDraftId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Amount = inputItem.Amount,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReceiptDraft Map(ReceiptDraft entity ,EditReceiptDraftCommand inputItem)
        {
              
  
		entity.ReceiptDraftId = inputItem.ReceiptDraftId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.ReceiptHeaderRef = inputItem.ReceiptHeaderRef;  
  
		entity.HeaderNumber = inputItem.HeaderNumber;  
  
		entity.HeaderDate = inputItem.HeaderDate;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReceiptDraftDto Map(ReceiptDraft inputItem)
        {
            var dto = new ReceiptDraftDto()
            {
                  
  
		ReceiptDraftId = inputItem.ReceiptDraftId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Amount = inputItem.Amount,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency, 
            };
            return dto;
        }

        public static List<ReceiptDraftDto> Map(ICollection<ReceiptDraft> entities)
        {
            var dtos = new List<ReceiptDraftDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReceiptDraftDto()
                {
                      
  
		ReceiptDraftId = inputItem.ReceiptDraftId,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Amount = inputItem.Amount,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReceiptHeader Map(AddReceiptHeaderCommand inputItem)
        {
            var entity = new ReceiptHeader() {
                  
  
		ReceiptHeaderId = inputItem.ReceiptHeaderId,  
  
		Type = inputItem.Type,  
  
		AccountSlRef = inputItem.AccountSlRef,  
  
		DlRef = inputItem.DlRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Discount = inputItem.Discount,  
  
		TotalAmount = inputItem.TotalAmount,  
  
		ItemType = inputItem.ItemType,  
  
		State = inputItem.State,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		Rate = inputItem.Rate,  
  
		CashRef = inputItem.CashRef,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		DiscountRate = inputItem.DiscountRate,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		TotalAmountInBaseCurrency = inputItem.TotalAmountInBaseCurrency,  
  
		Guid = inputItem.Guid,  
  
		ReceiptAmount = inputItem.ReceiptAmount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReceiptHeader Map(ReceiptHeader entity ,EditReceiptHeaderCommand inputItem)
        {
              
  
		entity.ReceiptHeaderId = inputItem.ReceiptHeaderId;  
  
		entity.Type = inputItem.Type;  
  
		entity.AccountSlRef = inputItem.AccountSlRef;  
  
		entity.DlRef = inputItem.DlRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.TotalAmount = inputItem.TotalAmount;  
  
		entity.ItemType = inputItem.ItemType;  
  
		entity.State = inputItem.State;  
  
		entity.CreatorForm = inputItem.CreatorForm;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.CashRef = inputItem.CashRef;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.DiscountRate = inputItem.DiscountRate;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.TotalAmountInBaseCurrency = inputItem.TotalAmountInBaseCurrency;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.ReceiptAmount = inputItem.ReceiptAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReceiptHeaderDto Map(ReceiptHeader inputItem)
        {
            var dto = new ReceiptHeaderDto()
            {
                  
  
		ReceiptHeaderId = inputItem.ReceiptHeaderId,  
  
		Type = inputItem.Type,  
  
		AccountSlRef = inputItem.AccountSlRef,  
  
		DlRef = inputItem.DlRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Discount = inputItem.Discount,  
  
		TotalAmount = inputItem.TotalAmount,  
  
		ItemType = inputItem.ItemType,  
  
		State = inputItem.State,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		Rate = inputItem.Rate,  
  
		CashRef = inputItem.CashRef,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		DiscountRate = inputItem.DiscountRate,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		TotalAmountInBaseCurrency = inputItem.TotalAmountInBaseCurrency,  
  
		Guid = inputItem.Guid,  
  
		ReceiptAmount = inputItem.ReceiptAmount, 
            };
            return dto;
        }

        public static List<ReceiptHeaderDto> Map(ICollection<ReceiptHeader> entities)
        {
            var dtos = new List<ReceiptHeaderDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReceiptHeaderDto()
                {
                      
  
		ReceiptHeaderId = inputItem.ReceiptHeaderId,  
  
		Type = inputItem.Type,  
  
		AccountSlRef = inputItem.AccountSlRef,  
  
		DlRef = inputItem.DlRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Discount = inputItem.Discount,  
  
		TotalAmount = inputItem.TotalAmount,  
  
		ItemType = inputItem.ItemType,  
  
		State = inputItem.State,  
  
		CreatorForm = inputItem.CreatorForm,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		Rate = inputItem.Rate,  
  
		CashRef = inputItem.CashRef,  
  
		Amount = inputItem.Amount,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		DiscountRate = inputItem.DiscountRate,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		TotalAmountInBaseCurrency = inputItem.TotalAmountInBaseCurrency,  
  
		Guid = inputItem.Guid,  
  
		ReceiptAmount = inputItem.ReceiptAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReceiptPos Map(AddReceiptPosCommand inputItem)
        {
            var entity = new ReceiptPos() {
                  
  
		ReceiptPosId = inputItem.ReceiptPosId,  
  
		PosRef = inputItem.PosRef,  
  
		Amount = inputItem.Amount,  
  
		state = inputItem.state,  
  
		Version = inputItem.Version,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		TrackingCode = inputItem.TrackingCode, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReceiptPos Map(ReceiptPos entity ,EditReceiptPosCommand inputItem)
        {
              
  
		entity.ReceiptPosId = inputItem.ReceiptPosId;  
  
		entity.PosRef = inputItem.PosRef;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.state = inputItem.state;  
  
		entity.Version = inputItem.Version;  
  
		entity.ReceiptHeaderRef = inputItem.ReceiptHeaderRef;  
  
		entity.HeaderNumber = inputItem.HeaderNumber;  
  
		entity.HeaderDate = inputItem.HeaderDate;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.AmountInBaseCurrency = inputItem.AmountInBaseCurrency;  
  
		entity.TrackingCode = inputItem.TrackingCode; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReceiptPosDto Map(ReceiptPos inputItem)
        {
            var dto = new ReceiptPosDto()
            {
                  
  
		ReceiptPosId = inputItem.ReceiptPosId,  
  
		PosRef = inputItem.PosRef,  
  
		Amount = inputItem.Amount,  
  
		state = inputItem.state,  
  
		Version = inputItem.Version,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		TrackingCode = inputItem.TrackingCode, 
            };
            return dto;
        }

        public static List<ReceiptPosDto> Map(ICollection<ReceiptPos> entities)
        {
            var dtos = new List<ReceiptPosDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReceiptPosDto()
                {
                      
  
		ReceiptPosId = inputItem.ReceiptPosId,  
  
		PosRef = inputItem.PosRef,  
  
		Amount = inputItem.Amount,  
  
		state = inputItem.state,  
  
		Version = inputItem.Version,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		AmountInBaseCurrency = inputItem.AmountInBaseCurrency,  
  
		TrackingCode = inputItem.TrackingCode, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Reconciliation Map(AddReconciliationCommand inputItem)
        {
            var entity = new Reconciliation() {
                  
  
		ReconciliationId = inputItem.ReconciliationId,  
  
		Number = inputItem.Number,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		BankBillRef = inputItem.BankBillRef,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BankBalance = inputItem.BankBalance,  
  
		BankBillBalance = inputItem.BankBillBalance,  
  
		BankBalanceInBaseCurrency = inputItem.BankBalanceInBaseCurrency,  
  
		BankBillBalanceInBaseCurrency = inputItem.BankBillBalanceInBaseCurrency, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Reconciliation Map(Reconciliation entity ,EditReconciliationCommand inputItem)
        {
              
  
		entity.ReconciliationId = inputItem.ReconciliationId;  
  
		entity.Number = inputItem.Number;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.BankBillRef = inputItem.BankBillRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.State = inputItem.State;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.BankBalance = inputItem.BankBalance;  
  
		entity.BankBillBalance = inputItem.BankBillBalance;  
  
		entity.BankBalanceInBaseCurrency = inputItem.BankBalanceInBaseCurrency;  
  
		entity.BankBillBalanceInBaseCurrency = inputItem.BankBillBalanceInBaseCurrency; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReconciliationDto Map(Reconciliation inputItem)
        {
            var dto = new ReconciliationDto()
            {
                  
  
		ReconciliationId = inputItem.ReconciliationId,  
  
		Number = inputItem.Number,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		BankBillRef = inputItem.BankBillRef,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BankBalance = inputItem.BankBalance,  
  
		BankBillBalance = inputItem.BankBillBalance,  
  
		BankBalanceInBaseCurrency = inputItem.BankBalanceInBaseCurrency,  
  
		BankBillBalanceInBaseCurrency = inputItem.BankBillBalanceInBaseCurrency, 
            };
            return dto;
        }

        public static List<ReconciliationDto> Map(ICollection<Reconciliation> entities)
        {
            var dtos = new List<ReconciliationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReconciliationDto()
                {
                      
  
		ReconciliationId = inputItem.ReconciliationId,  
  
		Number = inputItem.Number,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		BankBillRef = inputItem.BankBillRef,  
  
		Date = inputItem.Date,  
  
		State = inputItem.State,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BankBalance = inputItem.BankBalance,  
  
		BankBillBalance = inputItem.BankBillBalance,  
  
		BankBalanceInBaseCurrency = inputItem.BankBalanceInBaseCurrency,  
  
		BankBillBalanceInBaseCurrency = inputItem.BankBillBalanceInBaseCurrency, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReconciliationBankItem Map(AddReconciliationBankItemCommand inputItem)
        {
            var entity = new ReconciliationBankItem() {
                  
  
		ReconciliationBankItemId = inputItem.ReconciliationBankItemId,  
  
		BankBillItemRef = inputItem.BankBillItemRef,  
  
		RelationNo = inputItem.RelationNo,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		ReconciliationRef = inputItem.ReconciliationRef,  
  
		ReconciliationBankItemRef = inputItem.ReconciliationBankItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReconciliationBankItem Map(ReconciliationBankItem entity ,EditReconciliationBankItemCommand inputItem)
        {
              
  
		entity.ReconciliationBankItemId = inputItem.ReconciliationBankItemId;  
  
		entity.BankBillItemRef = inputItem.BankBillItemRef;  
  
		entity.RelationNo = inputItem.RelationNo;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.Debit = inputItem.Debit;  
  
		entity.Credit = inputItem.Credit;  
  
		entity.ReconciliationRef = inputItem.ReconciliationRef;  
  
		entity.ReconciliationBankItemRef = inputItem.ReconciliationBankItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReconciliationBankItemDto Map(ReconciliationBankItem inputItem)
        {
            var dto = new ReconciliationBankItemDto()
            {
                  
  
		ReconciliationBankItemId = inputItem.ReconciliationBankItemId,  
  
		BankBillItemRef = inputItem.BankBillItemRef,  
  
		RelationNo = inputItem.RelationNo,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		ReconciliationRef = inputItem.ReconciliationRef,  
  
		ReconciliationBankItemRef = inputItem.ReconciliationBankItemRef, 
            };
            return dto;
        }

        public static List<ReconciliationBankItemDto> Map(ICollection<ReconciliationBankItem> entities)
        {
            var dtos = new List<ReconciliationBankItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReconciliationBankItemDto()
                {
                      
  
		ReconciliationBankItemId = inputItem.ReconciliationBankItemId,  
  
		BankBillItemRef = inputItem.BankBillItemRef,  
  
		RelationNo = inputItem.RelationNo,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		ReconciliationRef = inputItem.ReconciliationRef,  
  
		ReconciliationBankItemRef = inputItem.ReconciliationBankItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReconciliationItem Map(AddReconciliationItemCommand inputItem)
        {
            var entity = new ReconciliationItem() {
                  
  
		ReconciliationItemId = inputItem.ReconciliationItemId,  
  
		ReceiptDraftRef = inputItem.ReceiptDraftRef,  
  
		PaymentDraftRef = inputItem.PaymentDraftRef,  
  
		ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef,  
  
		PaymentChequeBankingItemRef = inputItem.PaymentChequeBankingItemRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		RefundChequeItemRef = inputItem.RefundChequeItemRef,  
  
		RelationNo = inputItem.RelationNo,  
  
		Type = inputItem.Type,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		ReconciliationRef = inputItem.ReconciliationRef,  
  
		ReconciliationItemRef = inputItem.ReconciliationItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReconciliationItem Map(ReconciliationItem entity ,EditReconciliationItemCommand inputItem)
        {
              
  
		entity.ReconciliationItemId = inputItem.ReconciliationItemId;  
  
		entity.ReceiptDraftRef = inputItem.ReceiptDraftRef;  
  
		entity.PaymentDraftRef = inputItem.PaymentDraftRef;  
  
		entity.ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef;  
  
		entity.PaymentChequeBankingItemRef = inputItem.PaymentChequeBankingItemRef;  
  
		entity.PaymentChequeRef = inputItem.PaymentChequeRef;  
  
		entity.RefundChequeItemRef = inputItem.RefundChequeItemRef;  
  
		entity.RelationNo = inputItem.RelationNo;  
  
		entity.Type = inputItem.Type;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.Debit = inputItem.Debit;  
  
		entity.Credit = inputItem.Credit;  
  
		entity.ReconciliationRef = inputItem.ReconciliationRef;  
  
		entity.ReconciliationItemRef = inputItem.ReconciliationItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReconciliationItemDto Map(ReconciliationItem inputItem)
        {
            var dto = new ReconciliationItemDto()
            {
                  
  
		ReconciliationItemId = inputItem.ReconciliationItemId,  
  
		ReceiptDraftRef = inputItem.ReceiptDraftRef,  
  
		PaymentDraftRef = inputItem.PaymentDraftRef,  
  
		ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef,  
  
		PaymentChequeBankingItemRef = inputItem.PaymentChequeBankingItemRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		RefundChequeItemRef = inputItem.RefundChequeItemRef,  
  
		RelationNo = inputItem.RelationNo,  
  
		Type = inputItem.Type,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		ReconciliationRef = inputItem.ReconciliationRef,  
  
		ReconciliationItemRef = inputItem.ReconciliationItemRef, 
            };
            return dto;
        }

        public static List<ReconciliationItemDto> Map(ICollection<ReconciliationItem> entities)
        {
            var dtos = new List<ReconciliationItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReconciliationItemDto()
                {
                      
  
		ReconciliationItemId = inputItem.ReconciliationItemId,  
  
		ReceiptDraftRef = inputItem.ReceiptDraftRef,  
  
		PaymentDraftRef = inputItem.PaymentDraftRef,  
  
		ReceiptChequeBankingItemRef = inputItem.ReceiptChequeBankingItemRef,  
  
		PaymentChequeBankingItemRef = inputItem.PaymentChequeBankingItemRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		RefundChequeItemRef = inputItem.RefundChequeItemRef,  
  
		RelationNo = inputItem.RelationNo,  
  
		Type = inputItem.Type,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Debit = inputItem.Debit,  
  
		Credit = inputItem.Credit,  
  
		ReconciliationRef = inputItem.ReconciliationRef,  
  
		ReconciliationItemRef = inputItem.ReconciliationItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static RefundCheque Map(AddRefundChequeCommand inputItem)
        {
            var entity = new RefundCheque() {
                  
  
		RefundChequeId = inputItem.RefundChequeId,  
  
		DlRef = inputItem.DlRef,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		Number = inputItem.Number,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static RefundCheque Map(RefundCheque entity ,EditRefundChequeCommand inputItem)
        {
              
  
		entity.RefundChequeId = inputItem.RefundChequeId;  
  
		entity.DlRef = inputItem.DlRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.Type = inputItem.Type;  
  
		entity.Number = inputItem.Number;  
  
		entity.ReceiptHeaderRef = inputItem.ReceiptHeaderRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.State = inputItem.State;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static RefundChequeDto Map(RefundCheque inputItem)
        {
            var dto = new RefundChequeDto()
            {
                  
  
		RefundChequeId = inputItem.RefundChequeId,  
  
		DlRef = inputItem.DlRef,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		Number = inputItem.Number,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef, 
            };
            return dto;
        }

        public static List<RefundChequeDto> Map(ICollection<RefundCheque> entities)
        {
            var dtos = new List<RefundChequeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new RefundChequeDto()
                {
                      
  
		RefundChequeId = inputItem.RefundChequeId,  
  
		DlRef = inputItem.DlRef,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		Number = inputItem.Number,  
  
		ReceiptHeaderRef = inputItem.ReceiptHeaderRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static RefundChequeItem Map(AddRefundChequeItemCommand inputItem)
        {
            var entity = new RefundChequeItem() {
                  
  
		RefundChequeItemID = inputItem.RefundChequeItemID,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		RefundChequeRef = inputItem.RefundChequeRef,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		State = inputItem.State, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static RefundChequeItem Map(RefundChequeItem entity ,EditRefundChequeItemCommand inputItem)
        {
              
  
		entity.RefundChequeItemID = inputItem.RefundChequeItemID;  
  
		entity.ReceiptChequeRef = inputItem.ReceiptChequeRef;  
  
		entity.PaymentChequeRef = inputItem.PaymentChequeRef;  
  
		entity.RefundChequeRef = inputItem.RefundChequeRef;  
  
		entity.HeaderDate = inputItem.HeaderDate;  
  
		entity.HeaderNumber = inputItem.HeaderNumber;  
  
		entity.State = inputItem.State; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static RefundChequeItemDto Map(RefundChequeItem inputItem)
        {
            var dto = new RefundChequeItemDto()
            {
                  
  
		RefundChequeItemID = inputItem.RefundChequeItemID,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		RefundChequeRef = inputItem.RefundChequeRef,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		State = inputItem.State, 
            };
            return dto;
        }

        public static List<RefundChequeItemDto> Map(ICollection<RefundChequeItem> entities)
        {
            var dtos = new List<RefundChequeItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new RefundChequeItemDto()
                {
                      
  
		RefundChequeItemID = inputItem.RefundChequeItemID,  
  
		ReceiptChequeRef = inputItem.ReceiptChequeRef,  
  
		PaymentChequeRef = inputItem.PaymentChequeRef,  
  
		RefundChequeRef = inputItem.RefundChequeRef,  
  
		HeaderDate = inputItem.HeaderDate,  
  
		HeaderNumber = inputItem.HeaderNumber,  
  
		State = inputItem.State, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
