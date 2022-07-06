using Sepidar.Repository.Repositories;
using System;
using System.Threading.Tasks;

namespace Sepidar.Repository
{
    public interface IUnitOfWork : IDisposable
    {
         

IFormulaBomItemRepository FormulaBomItemRepository { get; } 

IFormulaBomItemAlternativeRepository FormulaBomItemAlternativeRepository { get; } 

IProductFormulaRepository ProductFormulaRepository { get; } 

IProductOrderRepository ProductOrderRepository { get; } 

IProductOrderBOMItemRepository ProductOrderBOMItemRepository { get; } 

IAdditionFactorRepository AdditionFactorRepository { get; } 

IAdditionFactorItemRepository AdditionFactorItemRepository { get; } 

ICommissionRepository CommissionRepository { get; } 

ICommissionAreaRepository CommissionAreaRepository { get; } 

ICommissionBrokerRepository CommissionBrokerRepository { get; } 

ICommissionCalculationRepository CommissionCalculationRepository { get; } 

ICommissionCalculationInvoiceRepository CommissionCalculationInvoiceRepository { get; } 

ICommissionCalculationItemRepository CommissionCalculationItemRepository { get; } 

ICommissionCalculationXMLResultRepository CommissionCalculationXMLResultRepository { get; } 

ICommissionItemRepository CommissionItemRepository { get; } 

ICommissionStepRepository CommissionStepRepository { get; } 

IDiscountRepository DiscountRepository { get; } 

IDiscountItemRepository DiscountItemRepository { get; } 

IInvoiceRepository InvoiceRepository { get; } 

IInvoiceBrokerRepository InvoiceBrokerRepository { get; } 

IInvoiceCommissionBrokerRepository InvoiceCommissionBrokerRepository { get; } 

IInvoiceItemRepository InvoiceItemRepository { get; } 

IInvoiceItemAdditionFactorRepository InvoiceItemAdditionFactorRepository { get; } 

IInvoiceReceiptChequeInfoRepository InvoiceReceiptChequeInfoRepository { get; } 

IInvoiceReceiptInfoRepository InvoiceReceiptInfoRepository { get; } 

IItemAdditionFactorRepository ItemAdditionFactorRepository { get; } 

IItemDiscountRepository ItemDiscountRepository { get; } 

IPriceNoteRepository PriceNoteRepository { get; } 

IPriceNoteItemRepository PriceNoteItemRepository { get; } 

IPriceNoteItemDiscountRepository PriceNoteItemDiscountRepository { get; } 

IProductPackRepository ProductPackRepository { get; } 

IProductPackDiscountRepository ProductPackDiscountRepository { get; } 

IProductPackItemRepository ProductPackItemRepository { get; } 

IQuotationRepository QuotationRepository { get; } 

IQuotationCommissionBrokerRepository QuotationCommissionBrokerRepository { get; } 

IQuotationItemRepository QuotationItemRepository { get; } 

IQuotationItemAdditionFactorRepository QuotationItemAdditionFactorRepository { get; } 

IReturnedInvoiceRepository ReturnedInvoiceRepository { get; } 

IReturnedInvoiceBrokerRepository ReturnedInvoiceBrokerRepository { get; } 

IReturnedInvoiceCommissionBrokerRepository ReturnedInvoiceCommissionBrokerRepository { get; } 

IReturnedInvoiceItemRepository ReturnedInvoiceItemRepository { get; } 

IReturnedInvoiceItemAdditionFactorRepository ReturnedInvoiceItemAdditionFactorRepository { get; } 

ISaleTypeRepository SaleTypeRepository { get; } 

ISchedulingRepository SchedulingRepository { get; } 

ISchedulingItemRepository SchedulingItemRepository { get; } 

IAccountTypeRepository AccountTypeRepository { get; } 

IBankRepository BankRepository { get; } 

IBankAccountRepository BankAccountRepository { get; } 

IBankAccountBalanceRepository BankAccountBalanceRepository { get; } 

IBankBillRepository BankBillRepository { get; } 

IBankBillItemRepository BankBillItemRepository { get; } 

IBankBranchRepository BankBranchRepository { get; } 

ICashRepository CashRepository { get; } 

ICashBalanceRepository CashBalanceRepository { get; } 

IChequeBookRepository ChequeBookRepository { get; } 

IDocSpecificationRepository DocSpecificationRepository { get; } 

IPartyAccountSettlementRepository PartyAccountSettlementRepository { get; } 

IPartyAccountSettlementItemRepository PartyAccountSettlementItemRepository { get; } 

IPartySettlementRepository PartySettlementRepository { get; } 

IPartySettlementItemRepository PartySettlementItemRepository { get; } 

IPaymentChequeRepository PaymentChequeRepository { get; } 

IPaymentChequeBankingRepository PaymentChequeBankingRepository { get; } 

IPaymentChequeBankingItemRepository PaymentChequeBankingItemRepository { get; } 

IPaymentChequeHistoryRepository PaymentChequeHistoryRepository { get; } 

IPaymentChequeOtherRepository PaymentChequeOtherRepository { get; } 

IPaymentDraftRepository PaymentDraftRepository { get; } 

IPaymentHeaderRepository PaymentHeaderRepository { get; } 

IPosRepository PosRepository { get; } 

IPosBalanceRepository PosBalanceRepository { get; } 

IPosSettlementRepository PosSettlementRepository { get; } 

IPosSettlementReceiptRepository PosSettlementReceiptRepository { get; } 

IReceiptChequeRepository ReceiptChequeRepository { get; } 

IReceiptChequeBankingRepository ReceiptChequeBankingRepository { get; } 

IReceiptChequeBankingItemRepository ReceiptChequeBankingItemRepository { get; } 

IReceiptChequeHistoryRepository ReceiptChequeHistoryRepository { get; } 

IReceiptDraftRepository ReceiptDraftRepository { get; } 

IReceiptHeaderRepository ReceiptHeaderRepository { get; } 

IReceiptPosRepository ReceiptPosRepository { get; } 

IReconciliationRepository ReconciliationRepository { get; } 

IReconciliationBankItemRepository ReconciliationBankItemRepository { get; } 

IReconciliationItemRepository ReconciliationItemRepository { get; } 

IRefundChequeRepository RefundChequeRepository { get; } 

IRefundChequeItemRepository RefundChequeItemRepository { get; } 

ICashierRepository CashierRepository { get; } 

IPOSInvoiceRepository POSInvoiceRepository { get; } 

IPOSInvoiceItemRepository POSInvoiceItemRepository { get; } 

IQuickBarRepository QuickBarRepository { get; } 

IQuickBarItemRepository QuickBarItemRepository { get; } 

IPOSReturnedInvoiceRepository POSReturnedInvoiceRepository { get; } 

IPOSReturnedInvoiceItemRepository POSReturnedInvoiceItemRepository { get; } 

IPOSSettlementRepository POSSettlementRepository { get; } 

IPOSSettlementItemRepository POSSettlementItemRepository { get; } 

IBillOfLoadingRepository BillOfLoadingRepository { get; } 

IBillOfLoadingItemRepository BillOfLoadingItemRepository { get; } 

ICommercialOrderRepository CommercialOrderRepository { get; } 

ICommercialOrderItemRepository CommercialOrderItemRepository { get; } 

ICustomsRepository CustomsRepository { get; } 

ICustomsClearanceRepository CustomsClearanceRepository { get; } 

ICustomsClearanceItemRepository CustomsClearanceItemRepository { get; } 

IInsurancePolicyRepository InsurancePolicyRepository { get; } 

IInsurancePolicyItemRepository InsurancePolicyItemRepository { get; } 

IPerformaRepository PerformaRepository { get; } 

IPerformaItemRepository PerformaItemRepository { get; } 

IPurchaseCostRepository PurchaseCostRepository { get; } 

IPurchaseCostItemRepository PurchaseCostItemRepository { get; } 

IPurchaseInvoiceRepository PurchaseInvoiceRepository { get; } 

IPurchaseInvoiceItemRepository PurchaseInvoiceItemRepository { get; } 

IPurchaseOrderRepository PurchaseOrderRepository { get; } 

IPurchaseOrderItemRepository PurchaseOrderItemRepository { get; } 

IPurchaseOtherCostItemRepository PurchaseOtherCostItemRepository { get; } 

IBranchRepository BranchRepository { get; } 

ICalculationRepository CalculationRepository { get; } 

IPayContractRepository PayContractRepository { get; } 

IContractElementRepository ContractElementRepository { get; } 

IDailyHourMinuteRepository DailyHourMinuteRepository { get; } 

IElementRepository ElementRepository { get; } 

IElementItemRepository ElementItemRepository { get; } 

IJobRepository JobRepository { get; } 

ILeaveRepository LeaveRepository { get; } 

ILoanRepository LoanRepository { get; } 

IMonthlyDataRepository MonthlyDataRepository { get; } 

IMonthlyDataPersonnelRepository MonthlyDataPersonnelRepository { get; } 

IMonthlyDataPersonnelElementRepository MonthlyDataPersonnelElementRepository { get; } 

IPayrollCalendarRepository PayrollCalendarRepository { get; } 

IPayrollConfigurationRepository PayrollConfigurationRepository { get; } 

IPayrollConfigurationElementRepository PayrollConfigurationElementRepository { get; } 

IPersonnelRepository PersonnelRepository { get; } 

IPersonnelInitiateRepository PersonnelInitiateRepository { get; } 

IPersonnelInitiateElementRepository PersonnelInitiateElementRepository { get; } 

IPersonnelTaxFileInfoChangeLogRepository PersonnelTaxFileInfoChangeLogRepository { get; } 

IPiofyAttendanceFactorRepository PiofyAttendanceFactorRepository { get; } 

IPiofyAttendanceFactorMapperRepository PiofyAttendanceFactorMapperRepository { get; } 

IPiofyMonthlyCalculationRepository PiofyMonthlyCalculationRepository { get; } 

IPaySettlementRepository PaySettlementRepository { get; } 

IPaySettlementItemRepository PaySettlementItemRepository { get; } 

ITaxGroupRepository TaxGroupRepository { get; } 

ITaxTableRepository TaxTableRepository { get; } 

ITaxTableItemRepository TaxTableItemRepository { get; } 

IWorkExperienceRepository WorkExperienceRepository { get; } 

IWorksiteRepository WorksiteRepository { get; } 

ICustomContactRepository CustomContactRepository { get; } 

ICustomContactPhoneRepository CustomContactPhoneRepository { get; } 

IInboxRepository InboxRepository { get; } 

IMessage1Repository Message1Repository { get; } 

IMessageContactRepository MessageContactRepository { get; } 

IOutgoingMessageRepository OutgoingMessageRepository { get; } 

IPhoneLineRepository PhoneLineRepository { get; } 

ISentScheduledTemplateSchedulingDateRepository SentScheduledTemplateSchedulingDateRepository { get; } 

ITemplateRepository TemplateRepository { get; } 

ITemplateContactRepository TemplateContactRepository { get; } 

ITemplateEventRepository TemplateEventRepository { get; } 

ITemplateFilterRepository TemplateFilterRepository { get; } 

ITemplateSchedulingRepository TemplateSchedulingRepository { get; } 

ICompoundBarcodeRepository CompoundBarcodeRepository { get; } 

IGroupRepository GroupRepository { get; } 

IInventoryBalancingRepository InventoryBalancingRepository { get; } 

IInventoryBalancingItemRepository InventoryBalancingItemRepository { get; } 

IInventoryDeliveryRepository InventoryDeliveryRepository { get; } 

IInventoryDeliveryItemRepository InventoryDeliveryItemRepository { get; } 

IInventoryPricingRepository InventoryPricingRepository { get; } 

IInventoryPricingVoucherRepository InventoryPricingVoucherRepository { get; } 

IInventoryPricingVoucherItemRepository InventoryPricingVoucherItemRepository { get; } 

IInventoryPurchaseInvoiceRepository InventoryPurchaseInvoiceRepository { get; } 

IInventoryPurchaseInvoiceItemRepository InventoryPurchaseInvoiceItemRepository { get; } 

IInventoryReceiptRepository InventoryReceiptRepository { get; } 

IInventoryReceiptItemRepository InventoryReceiptItemRepository { get; } 

IInventoryWeighbridgeRepository InventoryWeighbridgeRepository { get; } 

IInventoryWeighbridgeConfigurationRepository InventoryWeighbridgeConfigurationRepository { get; } 

IInventoryWeighingRepository InventoryWeighingRepository { get; } 

IItemRepository ItemRepository { get; } 

IItemCategoryRepository ItemCategoryRepository { get; } 

IItemImageRepository ItemImageRepository { get; } 

IItemPropertyAmountRepository ItemPropertyAmountRepository { get; } 

IItemStockRepository ItemStockRepository { get; } 

IItemStockSummaryRepository ItemStockSummaryRepository { get; } 

IPricingItemPriceRepository PricingItemPriceRepository { get; } 

IProducedItemPriceRepository ProducedItemPriceRepository { get; } 

IPropertyRepository PropertyRepository { get; } 

IPropertyDetailRepository PropertyDetailRepository { get; } 

IStockRepository StockRepository { get; } 

ITracingRepository TracingRepository { get; } 

ITracingCategoryRepository TracingCategoryRepository { get; } 

IUnitRepository UnitRepository { get; } 

IVoucherItemTrackingRepository VoucherItemTrackingRepository { get; } 

IAutomaticBackupConfigRepository AutomaticBackupConfigRepository { get; } 

IBackupRepository BackupRepository { get; } 

IBillRepository BillRepository { get; } 

IBillItemRepository BillItemRepository { get; } 

ICalculationElementRepository CalculationElementRepository { get; } 

ICalculationFormulaRepository CalculationFormulaRepository { get; } 

IClosingOperationRepository ClosingOperationRepository { get; } 

ICommunicationRepository CommunicationRepository { get; } 

ICommunicationConfigurationRepository CommunicationConfigurationRepository { get; } 

ICostCenterRepository CostCenterRepository { get; } 

ICurrencyRepository CurrencyRepository { get; } 

ICurrencyExchangeRateRepository CurrencyExchangeRateRepository { get; } 

IDebitCreditNoteRepository DebitCreditNoteRepository { get; } 

IDebitCreditNoteItemRepository DebitCreditNoteItemRepository { get; } 

IDeliveryLocationRepository DeliveryLocationRepository { get; } 

IDeviceRepository DeviceRepository { get; } 

IDeviceUserPartyRepository DeviceUserPartyRepository { get; } 

IElementSavedValueRepository ElementSavedValueRepository { get; } 

IEstablishmentCommunicationRepository EstablishmentCommunicationRepository { get; } 

IFormulaElementRepository FormulaElementRepository { get; } 

IGroupingRepository GroupingRepository { get; } 

ILocationRepository LocationRepository { get; } 

ILogoRepository LogoRepository { get; } 

IMarketingDisketteRepository MarketingDisketteRepository { get; } 

IMarketingDiskette1396Repository MarketingDiskette1396Repository { get; } 

IMarketingDisketteCurrencyRepository MarketingDisketteCurrencyRepository { get; } 

IMarketingDisketteCurrencyMapperRepository MarketingDisketteCurrencyMapperRepository { get; } 

IMarketingDisketteItemRepository MarketingDisketteItemRepository { get; } 

IMarketingDisketteItem1396Repository MarketingDisketteItem1396Repository { get; } 

IMarketingDiskettePartyMapperRepository MarketingDiskettePartyMapperRepository { get; } 

IMarketingDiskettItemCategoryMapperRepository MarketingDiskettItemCategoryMapperRepository { get; } 

IPartyRepository PartyRepository { get; } 

IPartyAddressRepository PartyAddressRepository { get; } 

IPartyOpeningBalanceRepository PartyOpeningBalanceRepository { get; } 

IPartyPhoneRepository PartyPhoneRepository { get; } 

IPartyRelatedRepository PartyRelatedRepository { get; } 

IPiofyEmployeeMapperRepository PiofyEmployeeMapperRepository { get; } 

IShredRepository ShredRepository { get; } 

IShredInfoRepository ShredInfoRepository { get; } 

IShredItemRepository ShredItemRepository { get; } 

ITruckRepository TruckRepository { get; } 

IVatRepository VatRepository { get; } 

IVatItemRepository VatItemRepository { get; } 

IApiLogRepository ApiLogRepository { get; } 

ICheckDataParityRepository CheckDataParityRepository { get; } 

ICheckDataParityItemRepository CheckDataParityItemRepository { get; } 

IConfigurationRepository ConfigurationRepository { get; } 

IExtraColumnDescriptionRepository ExtraColumnDescriptionRepository { get; } 

IExtraDataRepository ExtraDataRepository { get; } 

IFAQRepository FAQRepository { get; } 

IFiscalYearRepository FiscalYearRepository { get; } 

IIDGenerationRepository IDGenerationRepository { get; } 

IImportExportTemplateRepository ImportExportTemplateRepository { get; } 

IKeywordRepository KeywordRepository { get; } 

IKeywordLocaleRepository KeywordLocaleRepository { get; } 

ILookupRepository LookupRepository { get; } 

ILookupLocaleRepository LookupLocaleRepository { get; } 

INoteRepository NoteRepository { get; } 

INumberedEntityRepository NumberedEntityRepository { get; } 

IStandardDescriptionRepository StandardDescriptionRepository { get; } 

IUserRepository UserRepository { get; } 

IUserAccessRepository UserAccessRepository { get; } 

IUserConfigurationRepository UserConfigurationRepository { get; } 

IUserPhoneRepository UserPhoneRepository { get; } 

IUserReportsRepository UserReportsRepository { get; } 

IUserReportsInvisibleRepository UserReportsInvisibleRepository { get; } 

IVersion1Repository Version1Repository { get; } 

IAreaAndPathRepository AreaAndPathRepository { get; } 

IColdDistributionRepository ColdDistributionRepository { get; } 

IColdDistributionInvoiceRepository ColdDistributionInvoiceRepository { get; } 

IColdDistributionReturnedInvoiceRepository ColdDistributionReturnedInvoiceRepository { get; } 

IDebtCollectionListRepository DebtCollectionListRepository { get; } 

IDebtCollectionListInvoiceRepository DebtCollectionListInvoiceRepository { get; } 

IHotDistributionRepository HotDistributionRepository { get; } 

IHotDistributionInventoryDeliveryRepository HotDistributionInventoryDeliveryRepository { get; } 

IHotDistributionItemRepository HotDistributionItemRepository { get; } 

IHotDistributionPathRepository HotDistributionPathRepository { get; } 

IHotDistributionSaleDocumentRepository HotDistributionSaleDocumentRepository { get; } 

IHotDistributionUnexecutedActRepository HotDistributionUnexecutedActRepository { get; } 

IOrderRepository OrderRepository { get; } 

IOrderingFailureRepository OrderingFailureRepository { get; } 

IOrderingFailureItemRepository OrderingFailureItemRepository { get; } 

IOrderingScheduleRepository OrderingScheduleRepository { get; } 

IOrderingScheduleRecurrenceRepository OrderingScheduleRecurrenceRepository { get; } 

IOrderingScheduleRelatedActivitiesRepository OrderingScheduleRelatedActivitiesRepository { get; } 

IOrderItemRepository OrderItemRepository { get; } 

IOrderItemAdditionFactorRepository OrderItemAdditionFactorRepository { get; } 

IPathPartyAddressRepository PathPartyAddressRepository { get; } 

IProductSaleLineRepository ProductSaleLineRepository { get; } 

IProductSaleLineItemRepository ProductSaleLineItemRepository { get; } 

IProductSaleLinePartyRepository ProductSaleLinePartyRepository { get; } 

IReturnOrderRepository ReturnOrderRepository { get; } 

IReturnOrderItemRepository ReturnOrderItemRepository { get; } 

IReturnOrderItemAdditionFactorRepository ReturnOrderItemAdditionFactorRepository { get; } 

IReturnReasonRepository ReturnReasonRepository { get; } 

ISalesLimitRepository SalesLimitRepository { get; } 

ISalesLimitItemRepository SalesLimitItemRepository { get; } 

ISalesLimitItemPartyRepository SalesLimitItemPartyRepository { get; } 

ISaleTypeConstraintRepository SaleTypeConstraintRepository { get; } 

ISaleTypeConstraintItemRepository SaleTypeConstraintItemRepository { get; } 

IUnexecutedActReasonRepository UnexecutedActReasonRepository { get; } 

IChangeItemRepository ChangeItemRepository { get; } 

ICoefficientRepository CoefficientRepository { get; } 

IContractRepository ContractRepository { get; } 

IContractAgreementItemRepository ContractAgreementItemRepository { get; } 

IContractCoefficientItemRepository ContractCoefficientItemRepository { get; } 

IContractCompromiseItemRepository ContractCompromiseItemRepository { get; } 

IContractEmployerMaterialsItemRepository ContractEmployerMaterialsItemRepository { get; } 

IContractPreReceiptItemRepository ContractPreReceiptItemRepository { get; } 

IContractPriceListRepository ContractPriceListRepository { get; } 

IContractRelatedPurchaseInvoiceRepository ContractRelatedPurchaseInvoiceRepository { get; } 

IContractSupportingInsuranceRepository ContractSupportingInsuranceRepository { get; } 

IContractTypeRepository ContractTypeRepository { get; } 

IContractWarrantyItemRepository ContractWarrantyItemRepository { get; } 

IContractWorkshopItemRepository ContractWorkshopItemRepository { get; } 

ICostRepository CostRepository { get; } 

ICostStatementRepository CostStatementRepository { get; } 

ICostStatementItemRepository CostStatementItemRepository { get; } 

IGuaranteeRepository GuaranteeRepository { get; } 

IGuaranteeOperationRepository GuaranteeOperationRepository { get; } 

IGuaranteeRelatedRepository GuaranteeRelatedRepository { get; } 

IProjectRepository ProjectRepository { get; } 

IContractSettlementRepository ContractSettlementRepository { get; } 

ISettlementDebtItemRepository SettlementDebtItemRepository { get; } 

ISettlementItemRepository SettlementItemRepository { get; } 

IStatusRepository StatusRepository { get; } 

IStatusCoefficientItemRepository StatusCoefficientItemRepository { get; } 

IStatusItemRepository StatusItemRepository { get; } 

IStatusOnAccountItemRepository StatusOnAccountItemRepository { get; } 

IStatusReceiptItemRepository StatusReceiptItemRepository { get; } 

ITenderRepository TenderRepository { get; } 

IWarrantyRepository WarrantyRepository { get; } 

IWorkshopRepository WorkshopRepository { get; } 

IAcquisitionReceiptRepository AcquisitionReceiptRepository { get; } 

IAcquisitionReceiptItemRepository AcquisitionReceiptItemRepository { get; } 

IAssetRepository AssetRepository { get; } 

IAssetClassRepository AssetClassRepository { get; } 

IAssetGroupRepository AssetGroupRepository { get; } 

IAssetRelatedPurchaseInvoiceRepository AssetRelatedPurchaseInvoiceRepository { get; } 

IAssetTransactionRepository AssetTransactionRepository { get; } 

IChangeDepreciationMethodRepository ChangeDepreciationMethodRepository { get; } 

IChangeDepreciationMethodItemRepository ChangeDepreciationMethodItemRepository { get; } 

ICostPartRepository CostPartRepository { get; } 

ICostPartTransactionRepository CostPartTransactionRepository { get; } 

IDepreciationRepository DepreciationRepository { get; } 

IDepreciationItemRepository DepreciationItemRepository { get; } 

IDepreciationRuleRepository DepreciationRuleRepository { get; } 

IEliminationRepository EliminationRepository { get; } 

IEliminationItemRepository EliminationItemRepository { get; } 

IEmplacementRepository EmplacementRepository { get; } 

IRepairRepository RepairRepository { get; } 

IRepairItemRepository RepairItemRepository { get; } 

ISaleRepository SaleRepository { get; } 

ISaleItemRepository SaleItemRepository { get; } 

ISalvageRepository SalvageRepository { get; } 

ISalvageItemRepository SalvageItemRepository { get; } 

ITransferRepository TransferRepository { get; } 

ITransferItemRepository TransferItemRepository { get; } 

IUnuseableRepository UnuseableRepository { get; } 

IUnuseableItemRepository UnuseableItemRepository { get; } 

IUseableRepository UseableRepository { get; } 

IUseableItemRepository UseableItemRepository { get; } 

IAccountRepository AccountRepository { get; } 

IAccountTopicRepository AccountTopicRepository { get; } 

IDLRepository DLRepository { get; } 

IGLVoucherRepository GLVoucherRepository { get; } 

IGLVoucherItemRepository GLVoucherItemRepository { get; } 

IOpeningOperationRepository OpeningOperationRepository { get; } 

IOpeningOperationItemRepository OpeningOperationItemRepository { get; } 

ITopicRepository TopicRepository { get; } 

IVoucherRepository VoucherRepository { get; } 

IVoucherItemRepository VoucherItemRepository { get; } 

        Task<int> CommitAsync();
        int Commit();
    }
}
