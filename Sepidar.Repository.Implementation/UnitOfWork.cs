using Sepidar.Repository.Implementation.Implementation;
using Sepidar.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sepidar.Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

         


        private FormulaBomItemRepository _FormulaBomItemRepository;
        
        public IFormulaBomItemRepository FormulaBomItemRepository => _FormulaBomItemRepository = _FormulaBomItemRepository ?? new FormulaBomItemRepository(_context);
 


        private FormulaBomItemAlternativeRepository _FormulaBomItemAlternativeRepository;
        
        public IFormulaBomItemAlternativeRepository FormulaBomItemAlternativeRepository => _FormulaBomItemAlternativeRepository = _FormulaBomItemAlternativeRepository ?? new FormulaBomItemAlternativeRepository(_context);
 


        private ProductFormulaRepository _ProductFormulaRepository;
        
        public IProductFormulaRepository ProductFormulaRepository => _ProductFormulaRepository = _ProductFormulaRepository ?? new ProductFormulaRepository(_context);
 


        private ProductOrderRepository _ProductOrderRepository;
        
        public IProductOrderRepository ProductOrderRepository => _ProductOrderRepository = _ProductOrderRepository ?? new ProductOrderRepository(_context);
 


        private ProductOrderBOMItemRepository _ProductOrderBOMItemRepository;
        
        public IProductOrderBOMItemRepository ProductOrderBOMItemRepository => _ProductOrderBOMItemRepository = _ProductOrderBOMItemRepository ?? new ProductOrderBOMItemRepository(_context);
 


        private AdditionFactorRepository _AdditionFactorRepository;
        
        public IAdditionFactorRepository AdditionFactorRepository => _AdditionFactorRepository = _AdditionFactorRepository ?? new AdditionFactorRepository(_context);
 


        private AdditionFactorItemRepository _AdditionFactorItemRepository;
        
        public IAdditionFactorItemRepository AdditionFactorItemRepository => _AdditionFactorItemRepository = _AdditionFactorItemRepository ?? new AdditionFactorItemRepository(_context);
 


        private CommissionRepository _CommissionRepository;
        
        public ICommissionRepository CommissionRepository => _CommissionRepository = _CommissionRepository ?? new CommissionRepository(_context);
 


        private CommissionAreaRepository _CommissionAreaRepository;
        
        public ICommissionAreaRepository CommissionAreaRepository => _CommissionAreaRepository = _CommissionAreaRepository ?? new CommissionAreaRepository(_context);
 


        private CommissionBrokerRepository _CommissionBrokerRepository;
        
        public ICommissionBrokerRepository CommissionBrokerRepository => _CommissionBrokerRepository = _CommissionBrokerRepository ?? new CommissionBrokerRepository(_context);
 


        private CommissionCalculationRepository _CommissionCalculationRepository;
        
        public ICommissionCalculationRepository CommissionCalculationRepository => _CommissionCalculationRepository = _CommissionCalculationRepository ?? new CommissionCalculationRepository(_context);
 


        private CommissionCalculationInvoiceRepository _CommissionCalculationInvoiceRepository;
        
        public ICommissionCalculationInvoiceRepository CommissionCalculationInvoiceRepository => _CommissionCalculationInvoiceRepository = _CommissionCalculationInvoiceRepository ?? new CommissionCalculationInvoiceRepository(_context);
 


        private CommissionCalculationItemRepository _CommissionCalculationItemRepository;
        
        public ICommissionCalculationItemRepository CommissionCalculationItemRepository => _CommissionCalculationItemRepository = _CommissionCalculationItemRepository ?? new CommissionCalculationItemRepository(_context);
 


        private CommissionCalculationXMLResultRepository _CommissionCalculationXMLResultRepository;
        
        public ICommissionCalculationXMLResultRepository CommissionCalculationXMLResultRepository => _CommissionCalculationXMLResultRepository = _CommissionCalculationXMLResultRepository ?? new CommissionCalculationXMLResultRepository(_context);
 


        private CommissionItemRepository _CommissionItemRepository;
        
        public ICommissionItemRepository CommissionItemRepository => _CommissionItemRepository = _CommissionItemRepository ?? new CommissionItemRepository(_context);
 


        private CommissionStepRepository _CommissionStepRepository;
        
        public ICommissionStepRepository CommissionStepRepository => _CommissionStepRepository = _CommissionStepRepository ?? new CommissionStepRepository(_context);
 


        private DiscountRepository _DiscountRepository;
        
        public IDiscountRepository DiscountRepository => _DiscountRepository = _DiscountRepository ?? new DiscountRepository(_context);
 


        private DiscountItemRepository _DiscountItemRepository;
        
        public IDiscountItemRepository DiscountItemRepository => _DiscountItemRepository = _DiscountItemRepository ?? new DiscountItemRepository(_context);
 


        private InvoiceRepository _InvoiceRepository;
        
        public IInvoiceRepository InvoiceRepository => _InvoiceRepository = _InvoiceRepository ?? new InvoiceRepository(_context);
 


        private InvoiceBrokerRepository _InvoiceBrokerRepository;
        
        public IInvoiceBrokerRepository InvoiceBrokerRepository => _InvoiceBrokerRepository = _InvoiceBrokerRepository ?? new InvoiceBrokerRepository(_context);
 


        private InvoiceCommissionBrokerRepository _InvoiceCommissionBrokerRepository;
        
        public IInvoiceCommissionBrokerRepository InvoiceCommissionBrokerRepository => _InvoiceCommissionBrokerRepository = _InvoiceCommissionBrokerRepository ?? new InvoiceCommissionBrokerRepository(_context);
 


        private InvoiceItemRepository _InvoiceItemRepository;
        
        public IInvoiceItemRepository InvoiceItemRepository => _InvoiceItemRepository = _InvoiceItemRepository ?? new InvoiceItemRepository(_context);
 


        private InvoiceItemAdditionFactorRepository _InvoiceItemAdditionFactorRepository;
        
        public IInvoiceItemAdditionFactorRepository InvoiceItemAdditionFactorRepository => _InvoiceItemAdditionFactorRepository = _InvoiceItemAdditionFactorRepository ?? new InvoiceItemAdditionFactorRepository(_context);
 


        private InvoiceReceiptChequeInfoRepository _InvoiceReceiptChequeInfoRepository;
        
        public IInvoiceReceiptChequeInfoRepository InvoiceReceiptChequeInfoRepository => _InvoiceReceiptChequeInfoRepository = _InvoiceReceiptChequeInfoRepository ?? new InvoiceReceiptChequeInfoRepository(_context);
 


        private InvoiceReceiptInfoRepository _InvoiceReceiptInfoRepository;
        
        public IInvoiceReceiptInfoRepository InvoiceReceiptInfoRepository => _InvoiceReceiptInfoRepository = _InvoiceReceiptInfoRepository ?? new InvoiceReceiptInfoRepository(_context);
 


        private ItemAdditionFactorRepository _ItemAdditionFactorRepository;
        
        public IItemAdditionFactorRepository ItemAdditionFactorRepository => _ItemAdditionFactorRepository = _ItemAdditionFactorRepository ?? new ItemAdditionFactorRepository(_context);
 


        private ItemDiscountRepository _ItemDiscountRepository;
        
        public IItemDiscountRepository ItemDiscountRepository => _ItemDiscountRepository = _ItemDiscountRepository ?? new ItemDiscountRepository(_context);
 


        private PriceNoteRepository _PriceNoteRepository;
        
        public IPriceNoteRepository PriceNoteRepository => _PriceNoteRepository = _PriceNoteRepository ?? new PriceNoteRepository(_context);
 


        private PriceNoteItemRepository _PriceNoteItemRepository;
        
        public IPriceNoteItemRepository PriceNoteItemRepository => _PriceNoteItemRepository = _PriceNoteItemRepository ?? new PriceNoteItemRepository(_context);
 


        private PriceNoteItemDiscountRepository _PriceNoteItemDiscountRepository;
        
        public IPriceNoteItemDiscountRepository PriceNoteItemDiscountRepository => _PriceNoteItemDiscountRepository = _PriceNoteItemDiscountRepository ?? new PriceNoteItemDiscountRepository(_context);
 


        private ProductPackRepository _ProductPackRepository;
        
        public IProductPackRepository ProductPackRepository => _ProductPackRepository = _ProductPackRepository ?? new ProductPackRepository(_context);
 


        private ProductPackDiscountRepository _ProductPackDiscountRepository;
        
        public IProductPackDiscountRepository ProductPackDiscountRepository => _ProductPackDiscountRepository = _ProductPackDiscountRepository ?? new ProductPackDiscountRepository(_context);
 


        private ProductPackItemRepository _ProductPackItemRepository;
        
        public IProductPackItemRepository ProductPackItemRepository => _ProductPackItemRepository = _ProductPackItemRepository ?? new ProductPackItemRepository(_context);
 


        private QuotationRepository _QuotationRepository;
        
        public IQuotationRepository QuotationRepository => _QuotationRepository = _QuotationRepository ?? new QuotationRepository(_context);
 


        private QuotationCommissionBrokerRepository _QuotationCommissionBrokerRepository;
        
        public IQuotationCommissionBrokerRepository QuotationCommissionBrokerRepository => _QuotationCommissionBrokerRepository = _QuotationCommissionBrokerRepository ?? new QuotationCommissionBrokerRepository(_context);
 


        private QuotationItemRepository _QuotationItemRepository;
        
        public IQuotationItemRepository QuotationItemRepository => _QuotationItemRepository = _QuotationItemRepository ?? new QuotationItemRepository(_context);
 


        private QuotationItemAdditionFactorRepository _QuotationItemAdditionFactorRepository;
        
        public IQuotationItemAdditionFactorRepository QuotationItemAdditionFactorRepository => _QuotationItemAdditionFactorRepository = _QuotationItemAdditionFactorRepository ?? new QuotationItemAdditionFactorRepository(_context);
 


        private ReturnedInvoiceRepository _ReturnedInvoiceRepository;
        
        public IReturnedInvoiceRepository ReturnedInvoiceRepository => _ReturnedInvoiceRepository = _ReturnedInvoiceRepository ?? new ReturnedInvoiceRepository(_context);
 


        private ReturnedInvoiceBrokerRepository _ReturnedInvoiceBrokerRepository;
        
        public IReturnedInvoiceBrokerRepository ReturnedInvoiceBrokerRepository => _ReturnedInvoiceBrokerRepository = _ReturnedInvoiceBrokerRepository ?? new ReturnedInvoiceBrokerRepository(_context);
 


        private ReturnedInvoiceCommissionBrokerRepository _ReturnedInvoiceCommissionBrokerRepository;
        
        public IReturnedInvoiceCommissionBrokerRepository ReturnedInvoiceCommissionBrokerRepository => _ReturnedInvoiceCommissionBrokerRepository = _ReturnedInvoiceCommissionBrokerRepository ?? new ReturnedInvoiceCommissionBrokerRepository(_context);
 


        private ReturnedInvoiceItemRepository _ReturnedInvoiceItemRepository;
        
        public IReturnedInvoiceItemRepository ReturnedInvoiceItemRepository => _ReturnedInvoiceItemRepository = _ReturnedInvoiceItemRepository ?? new ReturnedInvoiceItemRepository(_context);
 


        private ReturnedInvoiceItemAdditionFactorRepository _ReturnedInvoiceItemAdditionFactorRepository;
        
        public IReturnedInvoiceItemAdditionFactorRepository ReturnedInvoiceItemAdditionFactorRepository => _ReturnedInvoiceItemAdditionFactorRepository = _ReturnedInvoiceItemAdditionFactorRepository ?? new ReturnedInvoiceItemAdditionFactorRepository(_context);
 


        private SaleTypeRepository _SaleTypeRepository;
        
        public ISaleTypeRepository SaleTypeRepository => _SaleTypeRepository = _SaleTypeRepository ?? new SaleTypeRepository(_context);
 


        private SchedulingRepository _SchedulingRepository;
        
        public ISchedulingRepository SchedulingRepository => _SchedulingRepository = _SchedulingRepository ?? new SchedulingRepository(_context);
 


        private SchedulingItemRepository _SchedulingItemRepository;
        
        public ISchedulingItemRepository SchedulingItemRepository => _SchedulingItemRepository = _SchedulingItemRepository ?? new SchedulingItemRepository(_context);
 


        private AccountTypeRepository _AccountTypeRepository;
        
        public IAccountTypeRepository AccountTypeRepository => _AccountTypeRepository = _AccountTypeRepository ?? new AccountTypeRepository(_context);
 


        private BankRepository _BankRepository;
        
        public IBankRepository BankRepository => _BankRepository = _BankRepository ?? new BankRepository(_context);
 


        private BankAccountRepository _BankAccountRepository;
        
        public IBankAccountRepository BankAccountRepository => _BankAccountRepository = _BankAccountRepository ?? new BankAccountRepository(_context);
 


        private BankAccountBalanceRepository _BankAccountBalanceRepository;
        
        public IBankAccountBalanceRepository BankAccountBalanceRepository => _BankAccountBalanceRepository = _BankAccountBalanceRepository ?? new BankAccountBalanceRepository(_context);
 


        private BankBillRepository _BankBillRepository;
        
        public IBankBillRepository BankBillRepository => _BankBillRepository = _BankBillRepository ?? new BankBillRepository(_context);
 


        private BankBillItemRepository _BankBillItemRepository;
        
        public IBankBillItemRepository BankBillItemRepository => _BankBillItemRepository = _BankBillItemRepository ?? new BankBillItemRepository(_context);
 


        private BankBranchRepository _BankBranchRepository;
        
        public IBankBranchRepository BankBranchRepository => _BankBranchRepository = _BankBranchRepository ?? new BankBranchRepository(_context);
 


        private CashRepository _CashRepository;
        
        public ICashRepository CashRepository => _CashRepository = _CashRepository ?? new CashRepository(_context);
 


        private CashBalanceRepository _CashBalanceRepository;
        
        public ICashBalanceRepository CashBalanceRepository => _CashBalanceRepository = _CashBalanceRepository ?? new CashBalanceRepository(_context);
 


        private ChequeBookRepository _ChequeBookRepository;
        
        public IChequeBookRepository ChequeBookRepository => _ChequeBookRepository = _ChequeBookRepository ?? new ChequeBookRepository(_context);
 


        private DocSpecificationRepository _DocSpecificationRepository;
        
        public IDocSpecificationRepository DocSpecificationRepository => _DocSpecificationRepository = _DocSpecificationRepository ?? new DocSpecificationRepository(_context);
 


        private PartyAccountSettlementRepository _PartyAccountSettlementRepository;
        
        public IPartyAccountSettlementRepository PartyAccountSettlementRepository => _PartyAccountSettlementRepository = _PartyAccountSettlementRepository ?? new PartyAccountSettlementRepository(_context);
 


        private PartyAccountSettlementItemRepository _PartyAccountSettlementItemRepository;
        
        public IPartyAccountSettlementItemRepository PartyAccountSettlementItemRepository => _PartyAccountSettlementItemRepository = _PartyAccountSettlementItemRepository ?? new PartyAccountSettlementItemRepository(_context);
 


        private PartySettlementRepository _PartySettlementRepository;
        
        public IPartySettlementRepository PartySettlementRepository => _PartySettlementRepository = _PartySettlementRepository ?? new PartySettlementRepository(_context);
 


        private PartySettlementItemRepository _PartySettlementItemRepository;
        
        public IPartySettlementItemRepository PartySettlementItemRepository => _PartySettlementItemRepository = _PartySettlementItemRepository ?? new PartySettlementItemRepository(_context);
 


        private PaymentChequeRepository _PaymentChequeRepository;
        
        public IPaymentChequeRepository PaymentChequeRepository => _PaymentChequeRepository = _PaymentChequeRepository ?? new PaymentChequeRepository(_context);
 


        private PaymentChequeBankingRepository _PaymentChequeBankingRepository;
        
        public IPaymentChequeBankingRepository PaymentChequeBankingRepository => _PaymentChequeBankingRepository = _PaymentChequeBankingRepository ?? new PaymentChequeBankingRepository(_context);
 


        private PaymentChequeBankingItemRepository _PaymentChequeBankingItemRepository;
        
        public IPaymentChequeBankingItemRepository PaymentChequeBankingItemRepository => _PaymentChequeBankingItemRepository = _PaymentChequeBankingItemRepository ?? new PaymentChequeBankingItemRepository(_context);
 


        private PaymentChequeHistoryRepository _PaymentChequeHistoryRepository;
        
        public IPaymentChequeHistoryRepository PaymentChequeHistoryRepository => _PaymentChequeHistoryRepository = _PaymentChequeHistoryRepository ?? new PaymentChequeHistoryRepository(_context);
 


        private PaymentChequeOtherRepository _PaymentChequeOtherRepository;
        
        public IPaymentChequeOtherRepository PaymentChequeOtherRepository => _PaymentChequeOtherRepository = _PaymentChequeOtherRepository ?? new PaymentChequeOtherRepository(_context);
 


        private PaymentDraftRepository _PaymentDraftRepository;
        
        public IPaymentDraftRepository PaymentDraftRepository => _PaymentDraftRepository = _PaymentDraftRepository ?? new PaymentDraftRepository(_context);
 


        private PaymentHeaderRepository _PaymentHeaderRepository;
        
        public IPaymentHeaderRepository PaymentHeaderRepository => _PaymentHeaderRepository = _PaymentHeaderRepository ?? new PaymentHeaderRepository(_context);
 


        private PosRepository _PosRepository;
        
        public IPosRepository PosRepository => _PosRepository = _PosRepository ?? new PosRepository(_context);
 


        private PosBalanceRepository _PosBalanceRepository;
        
        public IPosBalanceRepository PosBalanceRepository => _PosBalanceRepository = _PosBalanceRepository ?? new PosBalanceRepository(_context);
 


        private PosSettlementRepository _PosSettlementRepository;
        
        public IPosSettlementRepository PosSettlementRepository => _PosSettlementRepository = _PosSettlementRepository ?? new PosSettlementRepository(_context);
 


        private PosSettlementReceiptRepository _PosSettlementReceiptRepository;
        
        public IPosSettlementReceiptRepository PosSettlementReceiptRepository => _PosSettlementReceiptRepository = _PosSettlementReceiptRepository ?? new PosSettlementReceiptRepository(_context);
 


        private ReceiptChequeRepository _ReceiptChequeRepository;
        
        public IReceiptChequeRepository ReceiptChequeRepository => _ReceiptChequeRepository = _ReceiptChequeRepository ?? new ReceiptChequeRepository(_context);
 


        private ReceiptChequeBankingRepository _ReceiptChequeBankingRepository;
        
        public IReceiptChequeBankingRepository ReceiptChequeBankingRepository => _ReceiptChequeBankingRepository = _ReceiptChequeBankingRepository ?? new ReceiptChequeBankingRepository(_context);
 


        private ReceiptChequeBankingItemRepository _ReceiptChequeBankingItemRepository;
        
        public IReceiptChequeBankingItemRepository ReceiptChequeBankingItemRepository => _ReceiptChequeBankingItemRepository = _ReceiptChequeBankingItemRepository ?? new ReceiptChequeBankingItemRepository(_context);
 


        private ReceiptChequeHistoryRepository _ReceiptChequeHistoryRepository;
        
        public IReceiptChequeHistoryRepository ReceiptChequeHistoryRepository => _ReceiptChequeHistoryRepository = _ReceiptChequeHistoryRepository ?? new ReceiptChequeHistoryRepository(_context);
 


        private ReceiptDraftRepository _ReceiptDraftRepository;
        
        public IReceiptDraftRepository ReceiptDraftRepository => _ReceiptDraftRepository = _ReceiptDraftRepository ?? new ReceiptDraftRepository(_context);
 


        private ReceiptHeaderRepository _ReceiptHeaderRepository;
        
        public IReceiptHeaderRepository ReceiptHeaderRepository => _ReceiptHeaderRepository = _ReceiptHeaderRepository ?? new ReceiptHeaderRepository(_context);
 


        private ReceiptPosRepository _ReceiptPosRepository;
        
        public IReceiptPosRepository ReceiptPosRepository => _ReceiptPosRepository = _ReceiptPosRepository ?? new ReceiptPosRepository(_context);
 


        private ReconciliationRepository _ReconciliationRepository;
        
        public IReconciliationRepository ReconciliationRepository => _ReconciliationRepository = _ReconciliationRepository ?? new ReconciliationRepository(_context);
 


        private ReconciliationBankItemRepository _ReconciliationBankItemRepository;
        
        public IReconciliationBankItemRepository ReconciliationBankItemRepository => _ReconciliationBankItemRepository = _ReconciliationBankItemRepository ?? new ReconciliationBankItemRepository(_context);
 


        private ReconciliationItemRepository _ReconciliationItemRepository;
        
        public IReconciliationItemRepository ReconciliationItemRepository => _ReconciliationItemRepository = _ReconciliationItemRepository ?? new ReconciliationItemRepository(_context);
 


        private RefundChequeRepository _RefundChequeRepository;
        
        public IRefundChequeRepository RefundChequeRepository => _RefundChequeRepository = _RefundChequeRepository ?? new RefundChequeRepository(_context);
 


        private RefundChequeItemRepository _RefundChequeItemRepository;
        
        public IRefundChequeItemRepository RefundChequeItemRepository => _RefundChequeItemRepository = _RefundChequeItemRepository ?? new RefundChequeItemRepository(_context);
 


        private CashierRepository _CashierRepository;
        
        public ICashierRepository CashierRepository => _CashierRepository = _CashierRepository ?? new CashierRepository(_context);
 


        private POSInvoiceRepository _POSInvoiceRepository;
        
        public IPOSInvoiceRepository POSInvoiceRepository => _POSInvoiceRepository = _POSInvoiceRepository ?? new POSInvoiceRepository(_context);
 


        private POSInvoiceItemRepository _POSInvoiceItemRepository;
        
        public IPOSInvoiceItemRepository POSInvoiceItemRepository => _POSInvoiceItemRepository = _POSInvoiceItemRepository ?? new POSInvoiceItemRepository(_context);
 


        private QuickBarRepository _QuickBarRepository;
        
        public IQuickBarRepository QuickBarRepository => _QuickBarRepository = _QuickBarRepository ?? new QuickBarRepository(_context);
 


        private QuickBarItemRepository _QuickBarItemRepository;
        
        public IQuickBarItemRepository QuickBarItemRepository => _QuickBarItemRepository = _QuickBarItemRepository ?? new QuickBarItemRepository(_context);
 


        private POSReturnedInvoiceRepository _POSReturnedInvoiceRepository;
        
        public IPOSReturnedInvoiceRepository POSReturnedInvoiceRepository => _POSReturnedInvoiceRepository = _POSReturnedInvoiceRepository ?? new POSReturnedInvoiceRepository(_context);
 


        private POSReturnedInvoiceItemRepository _POSReturnedInvoiceItemRepository;
        
        public IPOSReturnedInvoiceItemRepository POSReturnedInvoiceItemRepository => _POSReturnedInvoiceItemRepository = _POSReturnedInvoiceItemRepository ?? new POSReturnedInvoiceItemRepository(_context);
 


        private POSSettlementRepository _POSSettlementRepository;
        
        public IPOSSettlementRepository POSSettlementRepository => _POSSettlementRepository = _POSSettlementRepository ?? new POSSettlementRepository(_context);
 


        private POSSettlementItemRepository _POSSettlementItemRepository;
        
        public IPOSSettlementItemRepository POSSettlementItemRepository => _POSSettlementItemRepository = _POSSettlementItemRepository ?? new POSSettlementItemRepository(_context);
 


        private BillOfLoadingRepository _BillOfLoadingRepository;
        
        public IBillOfLoadingRepository BillOfLoadingRepository => _BillOfLoadingRepository = _BillOfLoadingRepository ?? new BillOfLoadingRepository(_context);
 


        private BillOfLoadingItemRepository _BillOfLoadingItemRepository;
        
        public IBillOfLoadingItemRepository BillOfLoadingItemRepository => _BillOfLoadingItemRepository = _BillOfLoadingItemRepository ?? new BillOfLoadingItemRepository(_context);
 


        private CommercialOrderRepository _CommercialOrderRepository;
        
        public ICommercialOrderRepository CommercialOrderRepository => _CommercialOrderRepository = _CommercialOrderRepository ?? new CommercialOrderRepository(_context);
 


        private CommercialOrderItemRepository _CommercialOrderItemRepository;
        
        public ICommercialOrderItemRepository CommercialOrderItemRepository => _CommercialOrderItemRepository = _CommercialOrderItemRepository ?? new CommercialOrderItemRepository(_context);
 


        private CustomsRepository _CustomsRepository;
        
        public ICustomsRepository CustomsRepository => _CustomsRepository = _CustomsRepository ?? new CustomsRepository(_context);
 


        private CustomsClearanceRepository _CustomsClearanceRepository;
        
        public ICustomsClearanceRepository CustomsClearanceRepository => _CustomsClearanceRepository = _CustomsClearanceRepository ?? new CustomsClearanceRepository(_context);
 


        private CustomsClearanceItemRepository _CustomsClearanceItemRepository;
        
        public ICustomsClearanceItemRepository CustomsClearanceItemRepository => _CustomsClearanceItemRepository = _CustomsClearanceItemRepository ?? new CustomsClearanceItemRepository(_context);
 


        private InsurancePolicyRepository _InsurancePolicyRepository;
        
        public IInsurancePolicyRepository InsurancePolicyRepository => _InsurancePolicyRepository = _InsurancePolicyRepository ?? new InsurancePolicyRepository(_context);
 


        private InsurancePolicyItemRepository _InsurancePolicyItemRepository;
        
        public IInsurancePolicyItemRepository InsurancePolicyItemRepository => _InsurancePolicyItemRepository = _InsurancePolicyItemRepository ?? new InsurancePolicyItemRepository(_context);
 


        private PerformaRepository _PerformaRepository;
        
        public IPerformaRepository PerformaRepository => _PerformaRepository = _PerformaRepository ?? new PerformaRepository(_context);
 


        private PerformaItemRepository _PerformaItemRepository;
        
        public IPerformaItemRepository PerformaItemRepository => _PerformaItemRepository = _PerformaItemRepository ?? new PerformaItemRepository(_context);
 


        private PurchaseCostRepository _PurchaseCostRepository;
        
        public IPurchaseCostRepository PurchaseCostRepository => _PurchaseCostRepository = _PurchaseCostRepository ?? new PurchaseCostRepository(_context);
 


        private PurchaseCostItemRepository _PurchaseCostItemRepository;
        
        public IPurchaseCostItemRepository PurchaseCostItemRepository => _PurchaseCostItemRepository = _PurchaseCostItemRepository ?? new PurchaseCostItemRepository(_context);
 


        private PurchaseInvoiceRepository _PurchaseInvoiceRepository;
        
        public IPurchaseInvoiceRepository PurchaseInvoiceRepository => _PurchaseInvoiceRepository = _PurchaseInvoiceRepository ?? new PurchaseInvoiceRepository(_context);
 


        private PurchaseInvoiceItemRepository _PurchaseInvoiceItemRepository;
        
        public IPurchaseInvoiceItemRepository PurchaseInvoiceItemRepository => _PurchaseInvoiceItemRepository = _PurchaseInvoiceItemRepository ?? new PurchaseInvoiceItemRepository(_context);
 


        private PurchaseOrderRepository _PurchaseOrderRepository;
        
        public IPurchaseOrderRepository PurchaseOrderRepository => _PurchaseOrderRepository = _PurchaseOrderRepository ?? new PurchaseOrderRepository(_context);
 


        private PurchaseOrderItemRepository _PurchaseOrderItemRepository;
        
        public IPurchaseOrderItemRepository PurchaseOrderItemRepository => _PurchaseOrderItemRepository = _PurchaseOrderItemRepository ?? new PurchaseOrderItemRepository(_context);
 


        private PurchaseOtherCostItemRepository _PurchaseOtherCostItemRepository;
        
        public IPurchaseOtherCostItemRepository PurchaseOtherCostItemRepository => _PurchaseOtherCostItemRepository = _PurchaseOtherCostItemRepository ?? new PurchaseOtherCostItemRepository(_context);
 


        private BranchRepository _BranchRepository;
        
        public IBranchRepository BranchRepository => _BranchRepository = _BranchRepository ?? new BranchRepository(_context);
 


        private CalculationRepository _CalculationRepository;
        
        public ICalculationRepository CalculationRepository => _CalculationRepository = _CalculationRepository ?? new CalculationRepository(_context);
 


        private PayContractRepository _PayContractRepository;
        
        public IPayContractRepository PayContractRepository => _PayContractRepository = _PayContractRepository ?? new PayContractRepository(_context);
 


        private ContractElementRepository _ContractElementRepository;
        
        public IContractElementRepository ContractElementRepository => _ContractElementRepository = _ContractElementRepository ?? new ContractElementRepository(_context);
 


        private DailyHourMinuteRepository _DailyHourMinuteRepository;
        
        public IDailyHourMinuteRepository DailyHourMinuteRepository => _DailyHourMinuteRepository = _DailyHourMinuteRepository ?? new DailyHourMinuteRepository(_context);
 


        private ElementRepository _ElementRepository;
        
        public IElementRepository ElementRepository => _ElementRepository = _ElementRepository ?? new ElementRepository(_context);
 


        private ElementItemRepository _ElementItemRepository;
        
        public IElementItemRepository ElementItemRepository => _ElementItemRepository = _ElementItemRepository ?? new ElementItemRepository(_context);
 


        private JobRepository _JobRepository;
        
        public IJobRepository JobRepository => _JobRepository = _JobRepository ?? new JobRepository(_context);
 


        private LeaveRepository _LeaveRepository;
        
        public ILeaveRepository LeaveRepository => _LeaveRepository = _LeaveRepository ?? new LeaveRepository(_context);
 


        private LoanRepository _LoanRepository;
        
        public ILoanRepository LoanRepository => _LoanRepository = _LoanRepository ?? new LoanRepository(_context);
 


        private MonthlyDataRepository _MonthlyDataRepository;
        
        public IMonthlyDataRepository MonthlyDataRepository => _MonthlyDataRepository = _MonthlyDataRepository ?? new MonthlyDataRepository(_context);
 


        private MonthlyDataPersonnelRepository _MonthlyDataPersonnelRepository;
        
        public IMonthlyDataPersonnelRepository MonthlyDataPersonnelRepository => _MonthlyDataPersonnelRepository = _MonthlyDataPersonnelRepository ?? new MonthlyDataPersonnelRepository(_context);
 


        private MonthlyDataPersonnelElementRepository _MonthlyDataPersonnelElementRepository;
        
        public IMonthlyDataPersonnelElementRepository MonthlyDataPersonnelElementRepository => _MonthlyDataPersonnelElementRepository = _MonthlyDataPersonnelElementRepository ?? new MonthlyDataPersonnelElementRepository(_context);
 


        private PayrollCalendarRepository _PayrollCalendarRepository;
        
        public IPayrollCalendarRepository PayrollCalendarRepository => _PayrollCalendarRepository = _PayrollCalendarRepository ?? new PayrollCalendarRepository(_context);
 


        private PayrollConfigurationRepository _PayrollConfigurationRepository;
        
        public IPayrollConfigurationRepository PayrollConfigurationRepository => _PayrollConfigurationRepository = _PayrollConfigurationRepository ?? new PayrollConfigurationRepository(_context);
 


        private PayrollConfigurationElementRepository _PayrollConfigurationElementRepository;
        
        public IPayrollConfigurationElementRepository PayrollConfigurationElementRepository => _PayrollConfigurationElementRepository = _PayrollConfigurationElementRepository ?? new PayrollConfigurationElementRepository(_context);
 


        private PersonnelRepository _PersonnelRepository;
        
        public IPersonnelRepository PersonnelRepository => _PersonnelRepository = _PersonnelRepository ?? new PersonnelRepository(_context);
 


        private PersonnelInitiateRepository _PersonnelInitiateRepository;
        
        public IPersonnelInitiateRepository PersonnelInitiateRepository => _PersonnelInitiateRepository = _PersonnelInitiateRepository ?? new PersonnelInitiateRepository(_context);
 


        private PersonnelInitiateElementRepository _PersonnelInitiateElementRepository;
        
        public IPersonnelInitiateElementRepository PersonnelInitiateElementRepository => _PersonnelInitiateElementRepository = _PersonnelInitiateElementRepository ?? new PersonnelInitiateElementRepository(_context);
 


        private PersonnelTaxFileInfoChangeLogRepository _PersonnelTaxFileInfoChangeLogRepository;
        
        public IPersonnelTaxFileInfoChangeLogRepository PersonnelTaxFileInfoChangeLogRepository => _PersonnelTaxFileInfoChangeLogRepository = _PersonnelTaxFileInfoChangeLogRepository ?? new PersonnelTaxFileInfoChangeLogRepository(_context);
 


        private PiofyAttendanceFactorRepository _PiofyAttendanceFactorRepository;
        
        public IPiofyAttendanceFactorRepository PiofyAttendanceFactorRepository => _PiofyAttendanceFactorRepository = _PiofyAttendanceFactorRepository ?? new PiofyAttendanceFactorRepository(_context);
 


        private PiofyAttendanceFactorMapperRepository _PiofyAttendanceFactorMapperRepository;
        
        public IPiofyAttendanceFactorMapperRepository PiofyAttendanceFactorMapperRepository => _PiofyAttendanceFactorMapperRepository = _PiofyAttendanceFactorMapperRepository ?? new PiofyAttendanceFactorMapperRepository(_context);
 


        private PiofyMonthlyCalculationRepository _PiofyMonthlyCalculationRepository;
        
        public IPiofyMonthlyCalculationRepository PiofyMonthlyCalculationRepository => _PiofyMonthlyCalculationRepository = _PiofyMonthlyCalculationRepository ?? new PiofyMonthlyCalculationRepository(_context);
 


        private PaySettlementRepository _PaySettlementRepository;
        
        public IPaySettlementRepository PaySettlementRepository => _PaySettlementRepository = _PaySettlementRepository ?? new PaySettlementRepository(_context);
 


        private PaySettlementItemRepository _PaySettlementItemRepository;
        
        public IPaySettlementItemRepository PaySettlementItemRepository => _PaySettlementItemRepository = _PaySettlementItemRepository ?? new PaySettlementItemRepository(_context);
 


        private TaxGroupRepository _TaxGroupRepository;
        
        public ITaxGroupRepository TaxGroupRepository => _TaxGroupRepository = _TaxGroupRepository ?? new TaxGroupRepository(_context);
 


        private TaxTableRepository _TaxTableRepository;
        
        public ITaxTableRepository TaxTableRepository => _TaxTableRepository = _TaxTableRepository ?? new TaxTableRepository(_context);
 


        private TaxTableItemRepository _TaxTableItemRepository;
        
        public ITaxTableItemRepository TaxTableItemRepository => _TaxTableItemRepository = _TaxTableItemRepository ?? new TaxTableItemRepository(_context);
 


        private WorkExperienceRepository _WorkExperienceRepository;
        
        public IWorkExperienceRepository WorkExperienceRepository => _WorkExperienceRepository = _WorkExperienceRepository ?? new WorkExperienceRepository(_context);
 


        private WorksiteRepository _WorksiteRepository;
        
        public IWorksiteRepository WorksiteRepository => _WorksiteRepository = _WorksiteRepository ?? new WorksiteRepository(_context);
 


        private CustomContactRepository _CustomContactRepository;
        
        public ICustomContactRepository CustomContactRepository => _CustomContactRepository = _CustomContactRepository ?? new CustomContactRepository(_context);
 


        private CustomContactPhoneRepository _CustomContactPhoneRepository;
        
        public ICustomContactPhoneRepository CustomContactPhoneRepository => _CustomContactPhoneRepository = _CustomContactPhoneRepository ?? new CustomContactPhoneRepository(_context);
 


        private InboxRepository _InboxRepository;
        
        public IInboxRepository InboxRepository => _InboxRepository = _InboxRepository ?? new InboxRepository(_context);
 


        private Message1Repository _Message1Repository;
        
        public IMessage1Repository Message1Repository => _Message1Repository = _Message1Repository ?? new Message1Repository(_context);
 


        private MessageContactRepository _MessageContactRepository;
        
        public IMessageContactRepository MessageContactRepository => _MessageContactRepository = _MessageContactRepository ?? new MessageContactRepository(_context);
 


        private OutgoingMessageRepository _OutgoingMessageRepository;
        
        public IOutgoingMessageRepository OutgoingMessageRepository => _OutgoingMessageRepository = _OutgoingMessageRepository ?? new OutgoingMessageRepository(_context);
 


        private PhoneLineRepository _PhoneLineRepository;
        
        public IPhoneLineRepository PhoneLineRepository => _PhoneLineRepository = _PhoneLineRepository ?? new PhoneLineRepository(_context);
 


        private SentScheduledTemplateSchedulingDateRepository _SentScheduledTemplateSchedulingDateRepository;
        
        public ISentScheduledTemplateSchedulingDateRepository SentScheduledTemplateSchedulingDateRepository => _SentScheduledTemplateSchedulingDateRepository = _SentScheduledTemplateSchedulingDateRepository ?? new SentScheduledTemplateSchedulingDateRepository(_context);
 


        private TemplateRepository _TemplateRepository;
        
        public ITemplateRepository TemplateRepository => _TemplateRepository = _TemplateRepository ?? new TemplateRepository(_context);
 


        private TemplateContactRepository _TemplateContactRepository;
        
        public ITemplateContactRepository TemplateContactRepository => _TemplateContactRepository = _TemplateContactRepository ?? new TemplateContactRepository(_context);
 


        private TemplateEventRepository _TemplateEventRepository;
        
        public ITemplateEventRepository TemplateEventRepository => _TemplateEventRepository = _TemplateEventRepository ?? new TemplateEventRepository(_context);
 


        private TemplateFilterRepository _TemplateFilterRepository;
        
        public ITemplateFilterRepository TemplateFilterRepository => _TemplateFilterRepository = _TemplateFilterRepository ?? new TemplateFilterRepository(_context);
 


        private TemplateSchedulingRepository _TemplateSchedulingRepository;
        
        public ITemplateSchedulingRepository TemplateSchedulingRepository => _TemplateSchedulingRepository = _TemplateSchedulingRepository ?? new TemplateSchedulingRepository(_context);
 


        private CompoundBarcodeRepository _CompoundBarcodeRepository;
        
        public ICompoundBarcodeRepository CompoundBarcodeRepository => _CompoundBarcodeRepository = _CompoundBarcodeRepository ?? new CompoundBarcodeRepository(_context);
 


        private GroupRepository _GroupRepository;
        
        public IGroupRepository GroupRepository => _GroupRepository = _GroupRepository ?? new GroupRepository(_context);
 


        private InventoryBalancingRepository _InventoryBalancingRepository;
        
        public IInventoryBalancingRepository InventoryBalancingRepository => _InventoryBalancingRepository = _InventoryBalancingRepository ?? new InventoryBalancingRepository(_context);
 


        private InventoryBalancingItemRepository _InventoryBalancingItemRepository;
        
        public IInventoryBalancingItemRepository InventoryBalancingItemRepository => _InventoryBalancingItemRepository = _InventoryBalancingItemRepository ?? new InventoryBalancingItemRepository(_context);
 


        private InventoryDeliveryRepository _InventoryDeliveryRepository;
        
        public IInventoryDeliveryRepository InventoryDeliveryRepository => _InventoryDeliveryRepository = _InventoryDeliveryRepository ?? new InventoryDeliveryRepository(_context);
 


        private InventoryDeliveryItemRepository _InventoryDeliveryItemRepository;
        
        public IInventoryDeliveryItemRepository InventoryDeliveryItemRepository => _InventoryDeliveryItemRepository = _InventoryDeliveryItemRepository ?? new InventoryDeliveryItemRepository(_context);
 


        private InventoryPricingRepository _InventoryPricingRepository;
        
        public IInventoryPricingRepository InventoryPricingRepository => _InventoryPricingRepository = _InventoryPricingRepository ?? new InventoryPricingRepository(_context);
 


        private InventoryPricingVoucherRepository _InventoryPricingVoucherRepository;
        
        public IInventoryPricingVoucherRepository InventoryPricingVoucherRepository => _InventoryPricingVoucherRepository = _InventoryPricingVoucherRepository ?? new InventoryPricingVoucherRepository(_context);
 


        private InventoryPricingVoucherItemRepository _InventoryPricingVoucherItemRepository;
        
        public IInventoryPricingVoucherItemRepository InventoryPricingVoucherItemRepository => _InventoryPricingVoucherItemRepository = _InventoryPricingVoucherItemRepository ?? new InventoryPricingVoucherItemRepository(_context);
 


        private InventoryPurchaseInvoiceRepository _InventoryPurchaseInvoiceRepository;
        
        public IInventoryPurchaseInvoiceRepository InventoryPurchaseInvoiceRepository => _InventoryPurchaseInvoiceRepository = _InventoryPurchaseInvoiceRepository ?? new InventoryPurchaseInvoiceRepository(_context);
 


        private InventoryPurchaseInvoiceItemRepository _InventoryPurchaseInvoiceItemRepository;
        
        public IInventoryPurchaseInvoiceItemRepository InventoryPurchaseInvoiceItemRepository => _InventoryPurchaseInvoiceItemRepository = _InventoryPurchaseInvoiceItemRepository ?? new InventoryPurchaseInvoiceItemRepository(_context);
 


        private InventoryReceiptRepository _InventoryReceiptRepository;
        
        public IInventoryReceiptRepository InventoryReceiptRepository => _InventoryReceiptRepository = _InventoryReceiptRepository ?? new InventoryReceiptRepository(_context);
 


        private InventoryReceiptItemRepository _InventoryReceiptItemRepository;
        
        public IInventoryReceiptItemRepository InventoryReceiptItemRepository => _InventoryReceiptItemRepository = _InventoryReceiptItemRepository ?? new InventoryReceiptItemRepository(_context);
 


        private InventoryWeighbridgeRepository _InventoryWeighbridgeRepository;
        
        public IInventoryWeighbridgeRepository InventoryWeighbridgeRepository => _InventoryWeighbridgeRepository = _InventoryWeighbridgeRepository ?? new InventoryWeighbridgeRepository(_context);
 


        private InventoryWeighbridgeConfigurationRepository _InventoryWeighbridgeConfigurationRepository;
        
        public IInventoryWeighbridgeConfigurationRepository InventoryWeighbridgeConfigurationRepository => _InventoryWeighbridgeConfigurationRepository = _InventoryWeighbridgeConfigurationRepository ?? new InventoryWeighbridgeConfigurationRepository(_context);
 


        private InventoryWeighingRepository _InventoryWeighingRepository;
        
        public IInventoryWeighingRepository InventoryWeighingRepository => _InventoryWeighingRepository = _InventoryWeighingRepository ?? new InventoryWeighingRepository(_context);
 


        private ItemRepository _ItemRepository;
        
        public IItemRepository ItemRepository => _ItemRepository = _ItemRepository ?? new ItemRepository(_context);
 


        private ItemCategoryRepository _ItemCategoryRepository;
        
        public IItemCategoryRepository ItemCategoryRepository => _ItemCategoryRepository = _ItemCategoryRepository ?? new ItemCategoryRepository(_context);
 


        private ItemImageRepository _ItemImageRepository;
        
        public IItemImageRepository ItemImageRepository => _ItemImageRepository = _ItemImageRepository ?? new ItemImageRepository(_context);
 


        private ItemPropertyAmountRepository _ItemPropertyAmountRepository;
        
        public IItemPropertyAmountRepository ItemPropertyAmountRepository => _ItemPropertyAmountRepository = _ItemPropertyAmountRepository ?? new ItemPropertyAmountRepository(_context);
 


        private ItemStockRepository _ItemStockRepository;
        
        public IItemStockRepository ItemStockRepository => _ItemStockRepository = _ItemStockRepository ?? new ItemStockRepository(_context);
 


        private ItemStockSummaryRepository _ItemStockSummaryRepository;
        
        public IItemStockSummaryRepository ItemStockSummaryRepository => _ItemStockSummaryRepository = _ItemStockSummaryRepository ?? new ItemStockSummaryRepository(_context);
 


        private PricingItemPriceRepository _PricingItemPriceRepository;
        
        public IPricingItemPriceRepository PricingItemPriceRepository => _PricingItemPriceRepository = _PricingItemPriceRepository ?? new PricingItemPriceRepository(_context);
 


        private ProducedItemPriceRepository _ProducedItemPriceRepository;
        
        public IProducedItemPriceRepository ProducedItemPriceRepository => _ProducedItemPriceRepository = _ProducedItemPriceRepository ?? new ProducedItemPriceRepository(_context);
 


        private PropertyRepository _PropertyRepository;
        
        public IPropertyRepository PropertyRepository => _PropertyRepository = _PropertyRepository ?? new PropertyRepository(_context);
 


        private PropertyDetailRepository _PropertyDetailRepository;
        
        public IPropertyDetailRepository PropertyDetailRepository => _PropertyDetailRepository = _PropertyDetailRepository ?? new PropertyDetailRepository(_context);
 


        private StockRepository _StockRepository;
        
        public IStockRepository StockRepository => _StockRepository = _StockRepository ?? new StockRepository(_context);
 


        private TracingRepository _TracingRepository;
        
        public ITracingRepository TracingRepository => _TracingRepository = _TracingRepository ?? new TracingRepository(_context);
 


        private TracingCategoryRepository _TracingCategoryRepository;
        
        public ITracingCategoryRepository TracingCategoryRepository => _TracingCategoryRepository = _TracingCategoryRepository ?? new TracingCategoryRepository(_context);
 


        private UnitRepository _UnitRepository;
        
        public IUnitRepository UnitRepository => _UnitRepository = _UnitRepository ?? new UnitRepository(_context);
 


        private VoucherItemTrackingRepository _VoucherItemTrackingRepository;
        
        public IVoucherItemTrackingRepository VoucherItemTrackingRepository => _VoucherItemTrackingRepository = _VoucherItemTrackingRepository ?? new VoucherItemTrackingRepository(_context);
 


        private AutomaticBackupConfigRepository _AutomaticBackupConfigRepository;
        
        public IAutomaticBackupConfigRepository AutomaticBackupConfigRepository => _AutomaticBackupConfigRepository = _AutomaticBackupConfigRepository ?? new AutomaticBackupConfigRepository(_context);
 


        private BackupRepository _BackupRepository;
        
        public IBackupRepository BackupRepository => _BackupRepository = _BackupRepository ?? new BackupRepository(_context);
 


        private BillRepository _BillRepository;
        
        public IBillRepository BillRepository => _BillRepository = _BillRepository ?? new BillRepository(_context);
 


        private BillItemRepository _BillItemRepository;
        
        public IBillItemRepository BillItemRepository => _BillItemRepository = _BillItemRepository ?? new BillItemRepository(_context);
 


        private CalculationElementRepository _CalculationElementRepository;
        
        public ICalculationElementRepository CalculationElementRepository => _CalculationElementRepository = _CalculationElementRepository ?? new CalculationElementRepository(_context);
 


        private CalculationFormulaRepository _CalculationFormulaRepository;
        
        public ICalculationFormulaRepository CalculationFormulaRepository => _CalculationFormulaRepository = _CalculationFormulaRepository ?? new CalculationFormulaRepository(_context);
 


        private ClosingOperationRepository _ClosingOperationRepository;
        
        public IClosingOperationRepository ClosingOperationRepository => _ClosingOperationRepository = _ClosingOperationRepository ?? new ClosingOperationRepository(_context);
 


        private CommunicationRepository _CommunicationRepository;
        
        public ICommunicationRepository CommunicationRepository => _CommunicationRepository = _CommunicationRepository ?? new CommunicationRepository(_context);
 


        private CommunicationConfigurationRepository _CommunicationConfigurationRepository;
        
        public ICommunicationConfigurationRepository CommunicationConfigurationRepository => _CommunicationConfigurationRepository = _CommunicationConfigurationRepository ?? new CommunicationConfigurationRepository(_context);
 


        private CostCenterRepository _CostCenterRepository;
        
        public ICostCenterRepository CostCenterRepository => _CostCenterRepository = _CostCenterRepository ?? new CostCenterRepository(_context);
 


        private CurrencyRepository _CurrencyRepository;
        
        public ICurrencyRepository CurrencyRepository => _CurrencyRepository = _CurrencyRepository ?? new CurrencyRepository(_context);
 


        private CurrencyExchangeRateRepository _CurrencyExchangeRateRepository;
        
        public ICurrencyExchangeRateRepository CurrencyExchangeRateRepository => _CurrencyExchangeRateRepository = _CurrencyExchangeRateRepository ?? new CurrencyExchangeRateRepository(_context);
 


        private DebitCreditNoteRepository _DebitCreditNoteRepository;
        
        public IDebitCreditNoteRepository DebitCreditNoteRepository => _DebitCreditNoteRepository = _DebitCreditNoteRepository ?? new DebitCreditNoteRepository(_context);
 


        private DebitCreditNoteItemRepository _DebitCreditNoteItemRepository;
        
        public IDebitCreditNoteItemRepository DebitCreditNoteItemRepository => _DebitCreditNoteItemRepository = _DebitCreditNoteItemRepository ?? new DebitCreditNoteItemRepository(_context);
 


        private DeliveryLocationRepository _DeliveryLocationRepository;
        
        public IDeliveryLocationRepository DeliveryLocationRepository => _DeliveryLocationRepository = _DeliveryLocationRepository ?? new DeliveryLocationRepository(_context);
 


        private DeviceRepository _DeviceRepository;
        
        public IDeviceRepository DeviceRepository => _DeviceRepository = _DeviceRepository ?? new DeviceRepository(_context);
 


        private DeviceUserPartyRepository _DeviceUserPartyRepository;
        
        public IDeviceUserPartyRepository DeviceUserPartyRepository => _DeviceUserPartyRepository = _DeviceUserPartyRepository ?? new DeviceUserPartyRepository(_context);
 


        private ElementSavedValueRepository _ElementSavedValueRepository;
        
        public IElementSavedValueRepository ElementSavedValueRepository => _ElementSavedValueRepository = _ElementSavedValueRepository ?? new ElementSavedValueRepository(_context);
 


        private EstablishmentCommunicationRepository _EstablishmentCommunicationRepository;
        
        public IEstablishmentCommunicationRepository EstablishmentCommunicationRepository => _EstablishmentCommunicationRepository = _EstablishmentCommunicationRepository ?? new EstablishmentCommunicationRepository(_context);
 


        private FormulaElementRepository _FormulaElementRepository;
        
        public IFormulaElementRepository FormulaElementRepository => _FormulaElementRepository = _FormulaElementRepository ?? new FormulaElementRepository(_context);
 


        private GroupingRepository _GroupingRepository;
        
        public IGroupingRepository GroupingRepository => _GroupingRepository = _GroupingRepository ?? new GroupingRepository(_context);
 


        private LocationRepository _LocationRepository;
        
        public ILocationRepository LocationRepository => _LocationRepository = _LocationRepository ?? new LocationRepository(_context);
 


        private LogoRepository _LogoRepository;
        
        public ILogoRepository LogoRepository => _LogoRepository = _LogoRepository ?? new LogoRepository(_context);
 


        private MarketingDisketteRepository _MarketingDisketteRepository;
        
        public IMarketingDisketteRepository MarketingDisketteRepository => _MarketingDisketteRepository = _MarketingDisketteRepository ?? new MarketingDisketteRepository(_context);
 


        private MarketingDiskette1396Repository _MarketingDiskette1396Repository;
        
        public IMarketingDiskette1396Repository MarketingDiskette1396Repository => _MarketingDiskette1396Repository = _MarketingDiskette1396Repository ?? new MarketingDiskette1396Repository(_context);
 


        private MarketingDisketteCurrencyRepository _MarketingDisketteCurrencyRepository;
        
        public IMarketingDisketteCurrencyRepository MarketingDisketteCurrencyRepository => _MarketingDisketteCurrencyRepository = _MarketingDisketteCurrencyRepository ?? new MarketingDisketteCurrencyRepository(_context);
 


        private MarketingDisketteCurrencyMapperRepository _MarketingDisketteCurrencyMapperRepository;
        
        public IMarketingDisketteCurrencyMapperRepository MarketingDisketteCurrencyMapperRepository => _MarketingDisketteCurrencyMapperRepository = _MarketingDisketteCurrencyMapperRepository ?? new MarketingDisketteCurrencyMapperRepository(_context);
 


        private MarketingDisketteItemRepository _MarketingDisketteItemRepository;
        
        public IMarketingDisketteItemRepository MarketingDisketteItemRepository => _MarketingDisketteItemRepository = _MarketingDisketteItemRepository ?? new MarketingDisketteItemRepository(_context);
 


        private MarketingDisketteItem1396Repository _MarketingDisketteItem1396Repository;
        
        public IMarketingDisketteItem1396Repository MarketingDisketteItem1396Repository => _MarketingDisketteItem1396Repository = _MarketingDisketteItem1396Repository ?? new MarketingDisketteItem1396Repository(_context);
 


        private MarketingDiskettePartyMapperRepository _MarketingDiskettePartyMapperRepository;
        
        public IMarketingDiskettePartyMapperRepository MarketingDiskettePartyMapperRepository => _MarketingDiskettePartyMapperRepository = _MarketingDiskettePartyMapperRepository ?? new MarketingDiskettePartyMapperRepository(_context);
 


        private MarketingDiskettItemCategoryMapperRepository _MarketingDiskettItemCategoryMapperRepository;
        
        public IMarketingDiskettItemCategoryMapperRepository MarketingDiskettItemCategoryMapperRepository => _MarketingDiskettItemCategoryMapperRepository = _MarketingDiskettItemCategoryMapperRepository ?? new MarketingDiskettItemCategoryMapperRepository(_context);
 


        private PartyRepository _PartyRepository;
        
        public IPartyRepository PartyRepository => _PartyRepository = _PartyRepository ?? new PartyRepository(_context);
 


        private PartyAddressRepository _PartyAddressRepository;
        
        public IPartyAddressRepository PartyAddressRepository => _PartyAddressRepository = _PartyAddressRepository ?? new PartyAddressRepository(_context);
 


        private PartyOpeningBalanceRepository _PartyOpeningBalanceRepository;
        
        public IPartyOpeningBalanceRepository PartyOpeningBalanceRepository => _PartyOpeningBalanceRepository = _PartyOpeningBalanceRepository ?? new PartyOpeningBalanceRepository(_context);
 


        private PartyPhoneRepository _PartyPhoneRepository;
        
        public IPartyPhoneRepository PartyPhoneRepository => _PartyPhoneRepository = _PartyPhoneRepository ?? new PartyPhoneRepository(_context);
 


        private PartyRelatedRepository _PartyRelatedRepository;
        
        public IPartyRelatedRepository PartyRelatedRepository => _PartyRelatedRepository = _PartyRelatedRepository ?? new PartyRelatedRepository(_context);
 


        private PiofyEmployeeMapperRepository _PiofyEmployeeMapperRepository;
        
        public IPiofyEmployeeMapperRepository PiofyEmployeeMapperRepository => _PiofyEmployeeMapperRepository = _PiofyEmployeeMapperRepository ?? new PiofyEmployeeMapperRepository(_context);
 


        private ShredRepository _ShredRepository;
        
        public IShredRepository ShredRepository => _ShredRepository = _ShredRepository ?? new ShredRepository(_context);
 


        private ShredInfoRepository _ShredInfoRepository;
        
        public IShredInfoRepository ShredInfoRepository => _ShredInfoRepository = _ShredInfoRepository ?? new ShredInfoRepository(_context);
 


        private ShredItemRepository _ShredItemRepository;
        
        public IShredItemRepository ShredItemRepository => _ShredItemRepository = _ShredItemRepository ?? new ShredItemRepository(_context);
 


        private TruckRepository _TruckRepository;
        
        public ITruckRepository TruckRepository => _TruckRepository = _TruckRepository ?? new TruckRepository(_context);
 


        private VatRepository _VatRepository;
        
        public IVatRepository VatRepository => _VatRepository = _VatRepository ?? new VatRepository(_context);
 


        private VatItemRepository _VatItemRepository;
        
        public IVatItemRepository VatItemRepository => _VatItemRepository = _VatItemRepository ?? new VatItemRepository(_context);
 


        private ApiLogRepository _ApiLogRepository;
        
        public IApiLogRepository ApiLogRepository => _ApiLogRepository = _ApiLogRepository ?? new ApiLogRepository(_context);
 


        private CheckDataParityRepository _CheckDataParityRepository;
        
        public ICheckDataParityRepository CheckDataParityRepository => _CheckDataParityRepository = _CheckDataParityRepository ?? new CheckDataParityRepository(_context);
 


        private CheckDataParityItemRepository _CheckDataParityItemRepository;
        
        public ICheckDataParityItemRepository CheckDataParityItemRepository => _CheckDataParityItemRepository = _CheckDataParityItemRepository ?? new CheckDataParityItemRepository(_context);
 


        private ConfigurationRepository _ConfigurationRepository;
        
        public IConfigurationRepository ConfigurationRepository => _ConfigurationRepository = _ConfigurationRepository ?? new ConfigurationRepository(_context);
 


        private ExtraColumnDescriptionRepository _ExtraColumnDescriptionRepository;
        
        public IExtraColumnDescriptionRepository ExtraColumnDescriptionRepository => _ExtraColumnDescriptionRepository = _ExtraColumnDescriptionRepository ?? new ExtraColumnDescriptionRepository(_context);
 


        private ExtraDataRepository _ExtraDataRepository;
        
        public IExtraDataRepository ExtraDataRepository => _ExtraDataRepository = _ExtraDataRepository ?? new ExtraDataRepository(_context);
 


        private FAQRepository _FAQRepository;
        
        public IFAQRepository FAQRepository => _FAQRepository = _FAQRepository ?? new FAQRepository(_context);
 


        private FiscalYearRepository _FiscalYearRepository;
        
        public IFiscalYearRepository FiscalYearRepository => _FiscalYearRepository = _FiscalYearRepository ?? new FiscalYearRepository(_context);
 


        private IDGenerationRepository _IDGenerationRepository;
        
        public IIDGenerationRepository IDGenerationRepository => _IDGenerationRepository = _IDGenerationRepository ?? new IDGenerationRepository(_context);
 


        private ImportExportTemplateRepository _ImportExportTemplateRepository;
        
        public IImportExportTemplateRepository ImportExportTemplateRepository => _ImportExportTemplateRepository = _ImportExportTemplateRepository ?? new ImportExportTemplateRepository(_context);
 


        private KeywordRepository _KeywordRepository;
        
        public IKeywordRepository KeywordRepository => _KeywordRepository = _KeywordRepository ?? new KeywordRepository(_context);
 


        private KeywordLocaleRepository _KeywordLocaleRepository;
        
        public IKeywordLocaleRepository KeywordLocaleRepository => _KeywordLocaleRepository = _KeywordLocaleRepository ?? new KeywordLocaleRepository(_context);
 


        private LookupRepository _LookupRepository;
        
        public ILookupRepository LookupRepository => _LookupRepository = _LookupRepository ?? new LookupRepository(_context);
 


        private LookupLocaleRepository _LookupLocaleRepository;
        
        public ILookupLocaleRepository LookupLocaleRepository => _LookupLocaleRepository = _LookupLocaleRepository ?? new LookupLocaleRepository(_context);
 


        private NoteRepository _NoteRepository;
        
        public INoteRepository NoteRepository => _NoteRepository = _NoteRepository ?? new NoteRepository(_context);
 


        private NumberedEntityRepository _NumberedEntityRepository;
        
        public INumberedEntityRepository NumberedEntityRepository => _NumberedEntityRepository = _NumberedEntityRepository ?? new NumberedEntityRepository(_context);
 


        private StandardDescriptionRepository _StandardDescriptionRepository;
        
        public IStandardDescriptionRepository StandardDescriptionRepository => _StandardDescriptionRepository = _StandardDescriptionRepository ?? new StandardDescriptionRepository(_context);
 


        private UserRepository _UserRepository;
        
        public IUserRepository UserRepository => _UserRepository = _UserRepository ?? new UserRepository(_context);
 


        private UserAccessRepository _UserAccessRepository;
        
        public IUserAccessRepository UserAccessRepository => _UserAccessRepository = _UserAccessRepository ?? new UserAccessRepository(_context);
 


        private UserConfigurationRepository _UserConfigurationRepository;
        
        public IUserConfigurationRepository UserConfigurationRepository => _UserConfigurationRepository = _UserConfigurationRepository ?? new UserConfigurationRepository(_context);
 


        private UserPhoneRepository _UserPhoneRepository;
        
        public IUserPhoneRepository UserPhoneRepository => _UserPhoneRepository = _UserPhoneRepository ?? new UserPhoneRepository(_context);
 


        private UserReportsRepository _UserReportsRepository;
        
        public IUserReportsRepository UserReportsRepository => _UserReportsRepository = _UserReportsRepository ?? new UserReportsRepository(_context);
 


        private UserReportsInvisibleRepository _UserReportsInvisibleRepository;
        
        public IUserReportsInvisibleRepository UserReportsInvisibleRepository => _UserReportsInvisibleRepository = _UserReportsInvisibleRepository ?? new UserReportsInvisibleRepository(_context);
 


        private Version1Repository _Version1Repository;
        
        public IVersion1Repository Version1Repository => _Version1Repository = _Version1Repository ?? new Version1Repository(_context);
 


        private AreaAndPathRepository _AreaAndPathRepository;
        
        public IAreaAndPathRepository AreaAndPathRepository => _AreaAndPathRepository = _AreaAndPathRepository ?? new AreaAndPathRepository(_context);
 


        private ColdDistributionRepository _ColdDistributionRepository;
        
        public IColdDistributionRepository ColdDistributionRepository => _ColdDistributionRepository = _ColdDistributionRepository ?? new ColdDistributionRepository(_context);
 


        private ColdDistributionInvoiceRepository _ColdDistributionInvoiceRepository;
        
        public IColdDistributionInvoiceRepository ColdDistributionInvoiceRepository => _ColdDistributionInvoiceRepository = _ColdDistributionInvoiceRepository ?? new ColdDistributionInvoiceRepository(_context);
 


        private ColdDistributionReturnedInvoiceRepository _ColdDistributionReturnedInvoiceRepository;
        
        public IColdDistributionReturnedInvoiceRepository ColdDistributionReturnedInvoiceRepository => _ColdDistributionReturnedInvoiceRepository = _ColdDistributionReturnedInvoiceRepository ?? new ColdDistributionReturnedInvoiceRepository(_context);
 


        private DebtCollectionListRepository _DebtCollectionListRepository;
        
        public IDebtCollectionListRepository DebtCollectionListRepository => _DebtCollectionListRepository = _DebtCollectionListRepository ?? new DebtCollectionListRepository(_context);
 


        private DebtCollectionListInvoiceRepository _DebtCollectionListInvoiceRepository;
        
        public IDebtCollectionListInvoiceRepository DebtCollectionListInvoiceRepository => _DebtCollectionListInvoiceRepository = _DebtCollectionListInvoiceRepository ?? new DebtCollectionListInvoiceRepository(_context);
 


        private HotDistributionRepository _HotDistributionRepository;
        
        public IHotDistributionRepository HotDistributionRepository => _HotDistributionRepository = _HotDistributionRepository ?? new HotDistributionRepository(_context);
 


        private HotDistributionInventoryDeliveryRepository _HotDistributionInventoryDeliveryRepository;
        
        public IHotDistributionInventoryDeliveryRepository HotDistributionInventoryDeliveryRepository => _HotDistributionInventoryDeliveryRepository = _HotDistributionInventoryDeliveryRepository ?? new HotDistributionInventoryDeliveryRepository(_context);
 


        private HotDistributionItemRepository _HotDistributionItemRepository;
        
        public IHotDistributionItemRepository HotDistributionItemRepository => _HotDistributionItemRepository = _HotDistributionItemRepository ?? new HotDistributionItemRepository(_context);
 


        private HotDistributionPathRepository _HotDistributionPathRepository;
        
        public IHotDistributionPathRepository HotDistributionPathRepository => _HotDistributionPathRepository = _HotDistributionPathRepository ?? new HotDistributionPathRepository(_context);
 


        private HotDistributionSaleDocumentRepository _HotDistributionSaleDocumentRepository;
        
        public IHotDistributionSaleDocumentRepository HotDistributionSaleDocumentRepository => _HotDistributionSaleDocumentRepository = _HotDistributionSaleDocumentRepository ?? new HotDistributionSaleDocumentRepository(_context);
 


        private HotDistributionUnexecutedActRepository _HotDistributionUnexecutedActRepository;
        
        public IHotDistributionUnexecutedActRepository HotDistributionUnexecutedActRepository => _HotDistributionUnexecutedActRepository = _HotDistributionUnexecutedActRepository ?? new HotDistributionUnexecutedActRepository(_context);
 


        private OrderRepository _OrderRepository;
        
        public IOrderRepository OrderRepository => _OrderRepository = _OrderRepository ?? new OrderRepository(_context);
 


        private OrderingFailureRepository _OrderingFailureRepository;
        
        public IOrderingFailureRepository OrderingFailureRepository => _OrderingFailureRepository = _OrderingFailureRepository ?? new OrderingFailureRepository(_context);
 


        private OrderingFailureItemRepository _OrderingFailureItemRepository;
        
        public IOrderingFailureItemRepository OrderingFailureItemRepository => _OrderingFailureItemRepository = _OrderingFailureItemRepository ?? new OrderingFailureItemRepository(_context);
 


        private OrderingScheduleRepository _OrderingScheduleRepository;
        
        public IOrderingScheduleRepository OrderingScheduleRepository => _OrderingScheduleRepository = _OrderingScheduleRepository ?? new OrderingScheduleRepository(_context);
 


        private OrderingScheduleRecurrenceRepository _OrderingScheduleRecurrenceRepository;
        
        public IOrderingScheduleRecurrenceRepository OrderingScheduleRecurrenceRepository => _OrderingScheduleRecurrenceRepository = _OrderingScheduleRecurrenceRepository ?? new OrderingScheduleRecurrenceRepository(_context);
 


        private OrderingScheduleRelatedActivitiesRepository _OrderingScheduleRelatedActivitiesRepository;
        
        public IOrderingScheduleRelatedActivitiesRepository OrderingScheduleRelatedActivitiesRepository => _OrderingScheduleRelatedActivitiesRepository = _OrderingScheduleRelatedActivitiesRepository ?? new OrderingScheduleRelatedActivitiesRepository(_context);
 


        private OrderItemRepository _OrderItemRepository;
        
        public IOrderItemRepository OrderItemRepository => _OrderItemRepository = _OrderItemRepository ?? new OrderItemRepository(_context);
 


        private OrderItemAdditionFactorRepository _OrderItemAdditionFactorRepository;
        
        public IOrderItemAdditionFactorRepository OrderItemAdditionFactorRepository => _OrderItemAdditionFactorRepository = _OrderItemAdditionFactorRepository ?? new OrderItemAdditionFactorRepository(_context);
 


        private PathPartyAddressRepository _PathPartyAddressRepository;
        
        public IPathPartyAddressRepository PathPartyAddressRepository => _PathPartyAddressRepository = _PathPartyAddressRepository ?? new PathPartyAddressRepository(_context);
 


        private ProductSaleLineRepository _ProductSaleLineRepository;
        
        public IProductSaleLineRepository ProductSaleLineRepository => _ProductSaleLineRepository = _ProductSaleLineRepository ?? new ProductSaleLineRepository(_context);
 


        private ProductSaleLineItemRepository _ProductSaleLineItemRepository;
        
        public IProductSaleLineItemRepository ProductSaleLineItemRepository => _ProductSaleLineItemRepository = _ProductSaleLineItemRepository ?? new ProductSaleLineItemRepository(_context);
 


        private ProductSaleLinePartyRepository _ProductSaleLinePartyRepository;
        
        public IProductSaleLinePartyRepository ProductSaleLinePartyRepository => _ProductSaleLinePartyRepository = _ProductSaleLinePartyRepository ?? new ProductSaleLinePartyRepository(_context);
 


        private ReturnOrderRepository _ReturnOrderRepository;
        
        public IReturnOrderRepository ReturnOrderRepository => _ReturnOrderRepository = _ReturnOrderRepository ?? new ReturnOrderRepository(_context);
 


        private ReturnOrderItemRepository _ReturnOrderItemRepository;
        
        public IReturnOrderItemRepository ReturnOrderItemRepository => _ReturnOrderItemRepository = _ReturnOrderItemRepository ?? new ReturnOrderItemRepository(_context);
 


        private ReturnOrderItemAdditionFactorRepository _ReturnOrderItemAdditionFactorRepository;
        
        public IReturnOrderItemAdditionFactorRepository ReturnOrderItemAdditionFactorRepository => _ReturnOrderItemAdditionFactorRepository = _ReturnOrderItemAdditionFactorRepository ?? new ReturnOrderItemAdditionFactorRepository(_context);
 


        private ReturnReasonRepository _ReturnReasonRepository;
        
        public IReturnReasonRepository ReturnReasonRepository => _ReturnReasonRepository = _ReturnReasonRepository ?? new ReturnReasonRepository(_context);
 


        private SalesLimitRepository _SalesLimitRepository;
        
        public ISalesLimitRepository SalesLimitRepository => _SalesLimitRepository = _SalesLimitRepository ?? new SalesLimitRepository(_context);
 


        private SalesLimitItemRepository _SalesLimitItemRepository;
        
        public ISalesLimitItemRepository SalesLimitItemRepository => _SalesLimitItemRepository = _SalesLimitItemRepository ?? new SalesLimitItemRepository(_context);
 


        private SalesLimitItemPartyRepository _SalesLimitItemPartyRepository;
        
        public ISalesLimitItemPartyRepository SalesLimitItemPartyRepository => _SalesLimitItemPartyRepository = _SalesLimitItemPartyRepository ?? new SalesLimitItemPartyRepository(_context);
 


        private SaleTypeConstraintRepository _SaleTypeConstraintRepository;
        
        public ISaleTypeConstraintRepository SaleTypeConstraintRepository => _SaleTypeConstraintRepository = _SaleTypeConstraintRepository ?? new SaleTypeConstraintRepository(_context);
 


        private SaleTypeConstraintItemRepository _SaleTypeConstraintItemRepository;
        
        public ISaleTypeConstraintItemRepository SaleTypeConstraintItemRepository => _SaleTypeConstraintItemRepository = _SaleTypeConstraintItemRepository ?? new SaleTypeConstraintItemRepository(_context);
 


        private UnexecutedActReasonRepository _UnexecutedActReasonRepository;
        
        public IUnexecutedActReasonRepository UnexecutedActReasonRepository => _UnexecutedActReasonRepository = _UnexecutedActReasonRepository ?? new UnexecutedActReasonRepository(_context);
 


        private ChangeItemRepository _ChangeItemRepository;
        
        public IChangeItemRepository ChangeItemRepository => _ChangeItemRepository = _ChangeItemRepository ?? new ChangeItemRepository(_context);
 


        private CoefficientRepository _CoefficientRepository;
        
        public ICoefficientRepository CoefficientRepository => _CoefficientRepository = _CoefficientRepository ?? new CoefficientRepository(_context);
 


        private ContractRepository _ContractRepository;
        
        public IContractRepository ContractRepository => _ContractRepository = _ContractRepository ?? new ContractRepository(_context);
 


        private ContractAgreementItemRepository _ContractAgreementItemRepository;
        
        public IContractAgreementItemRepository ContractAgreementItemRepository => _ContractAgreementItemRepository = _ContractAgreementItemRepository ?? new ContractAgreementItemRepository(_context);
 


        private ContractCoefficientItemRepository _ContractCoefficientItemRepository;
        
        public IContractCoefficientItemRepository ContractCoefficientItemRepository => _ContractCoefficientItemRepository = _ContractCoefficientItemRepository ?? new ContractCoefficientItemRepository(_context);
 


        private ContractCompromiseItemRepository _ContractCompromiseItemRepository;
        
        public IContractCompromiseItemRepository ContractCompromiseItemRepository => _ContractCompromiseItemRepository = _ContractCompromiseItemRepository ?? new ContractCompromiseItemRepository(_context);
 


        private ContractEmployerMaterialsItemRepository _ContractEmployerMaterialsItemRepository;
        
        public IContractEmployerMaterialsItemRepository ContractEmployerMaterialsItemRepository => _ContractEmployerMaterialsItemRepository = _ContractEmployerMaterialsItemRepository ?? new ContractEmployerMaterialsItemRepository(_context);
 


        private ContractPreReceiptItemRepository _ContractPreReceiptItemRepository;
        
        public IContractPreReceiptItemRepository ContractPreReceiptItemRepository => _ContractPreReceiptItemRepository = _ContractPreReceiptItemRepository ?? new ContractPreReceiptItemRepository(_context);
 


        private ContractPriceListRepository _ContractPriceListRepository;
        
        public IContractPriceListRepository ContractPriceListRepository => _ContractPriceListRepository = _ContractPriceListRepository ?? new ContractPriceListRepository(_context);
 


        private ContractRelatedPurchaseInvoiceRepository _ContractRelatedPurchaseInvoiceRepository;
        
        public IContractRelatedPurchaseInvoiceRepository ContractRelatedPurchaseInvoiceRepository => _ContractRelatedPurchaseInvoiceRepository = _ContractRelatedPurchaseInvoiceRepository ?? new ContractRelatedPurchaseInvoiceRepository(_context);
 


        private ContractSupportingInsuranceRepository _ContractSupportingInsuranceRepository;
        
        public IContractSupportingInsuranceRepository ContractSupportingInsuranceRepository => _ContractSupportingInsuranceRepository = _ContractSupportingInsuranceRepository ?? new ContractSupportingInsuranceRepository(_context);
 


        private ContractTypeRepository _ContractTypeRepository;
        
        public IContractTypeRepository ContractTypeRepository => _ContractTypeRepository = _ContractTypeRepository ?? new ContractTypeRepository(_context);
 


        private ContractWarrantyItemRepository _ContractWarrantyItemRepository;
        
        public IContractWarrantyItemRepository ContractWarrantyItemRepository => _ContractWarrantyItemRepository = _ContractWarrantyItemRepository ?? new ContractWarrantyItemRepository(_context);
 


        private ContractWorkshopItemRepository _ContractWorkshopItemRepository;
        
        public IContractWorkshopItemRepository ContractWorkshopItemRepository => _ContractWorkshopItemRepository = _ContractWorkshopItemRepository ?? new ContractWorkshopItemRepository(_context);
 


        private CostRepository _CostRepository;
        
        public ICostRepository CostRepository => _CostRepository = _CostRepository ?? new CostRepository(_context);
 


        private CostStatementRepository _CostStatementRepository;
        
        public ICostStatementRepository CostStatementRepository => _CostStatementRepository = _CostStatementRepository ?? new CostStatementRepository(_context);
 


        private CostStatementItemRepository _CostStatementItemRepository;
        
        public ICostStatementItemRepository CostStatementItemRepository => _CostStatementItemRepository = _CostStatementItemRepository ?? new CostStatementItemRepository(_context);
 


        private GuaranteeRepository _GuaranteeRepository;
        
        public IGuaranteeRepository GuaranteeRepository => _GuaranteeRepository = _GuaranteeRepository ?? new GuaranteeRepository(_context);
 


        private GuaranteeOperationRepository _GuaranteeOperationRepository;
        
        public IGuaranteeOperationRepository GuaranteeOperationRepository => _GuaranteeOperationRepository = _GuaranteeOperationRepository ?? new GuaranteeOperationRepository(_context);
 


        private GuaranteeRelatedRepository _GuaranteeRelatedRepository;
        
        public IGuaranteeRelatedRepository GuaranteeRelatedRepository => _GuaranteeRelatedRepository = _GuaranteeRelatedRepository ?? new GuaranteeRelatedRepository(_context);
 


        private ProjectRepository _ProjectRepository;
        
        public IProjectRepository ProjectRepository => _ProjectRepository = _ProjectRepository ?? new ProjectRepository(_context);
 


        private ContractSettlementRepository _ContractSettlementRepository;
        
        public IContractSettlementRepository ContractSettlementRepository => _ContractSettlementRepository = _ContractSettlementRepository ?? new ContractSettlementRepository(_context);
 


        private SettlementDebtItemRepository _SettlementDebtItemRepository;
        
        public ISettlementDebtItemRepository SettlementDebtItemRepository => _SettlementDebtItemRepository = _SettlementDebtItemRepository ?? new SettlementDebtItemRepository(_context);
 


        private SettlementItemRepository _SettlementItemRepository;
        
        public ISettlementItemRepository SettlementItemRepository => _SettlementItemRepository = _SettlementItemRepository ?? new SettlementItemRepository(_context);
 


        private StatusRepository _StatusRepository;
        
        public IStatusRepository StatusRepository => _StatusRepository = _StatusRepository ?? new StatusRepository(_context);
 


        private StatusCoefficientItemRepository _StatusCoefficientItemRepository;
        
        public IStatusCoefficientItemRepository StatusCoefficientItemRepository => _StatusCoefficientItemRepository = _StatusCoefficientItemRepository ?? new StatusCoefficientItemRepository(_context);
 


        private StatusItemRepository _StatusItemRepository;
        
        public IStatusItemRepository StatusItemRepository => _StatusItemRepository = _StatusItemRepository ?? new StatusItemRepository(_context);
 


        private StatusOnAccountItemRepository _StatusOnAccountItemRepository;
        
        public IStatusOnAccountItemRepository StatusOnAccountItemRepository => _StatusOnAccountItemRepository = _StatusOnAccountItemRepository ?? new StatusOnAccountItemRepository(_context);
 


        private StatusReceiptItemRepository _StatusReceiptItemRepository;
        
        public IStatusReceiptItemRepository StatusReceiptItemRepository => _StatusReceiptItemRepository = _StatusReceiptItemRepository ?? new StatusReceiptItemRepository(_context);
 


        private TenderRepository _TenderRepository;
        
        public ITenderRepository TenderRepository => _TenderRepository = _TenderRepository ?? new TenderRepository(_context);
 


        private WarrantyRepository _WarrantyRepository;
        
        public IWarrantyRepository WarrantyRepository => _WarrantyRepository = _WarrantyRepository ?? new WarrantyRepository(_context);
 


        private WorkshopRepository _WorkshopRepository;
        
        public IWorkshopRepository WorkshopRepository => _WorkshopRepository = _WorkshopRepository ?? new WorkshopRepository(_context);
 


        private AcquisitionReceiptRepository _AcquisitionReceiptRepository;
        
        public IAcquisitionReceiptRepository AcquisitionReceiptRepository => _AcquisitionReceiptRepository = _AcquisitionReceiptRepository ?? new AcquisitionReceiptRepository(_context);
 


        private AcquisitionReceiptItemRepository _AcquisitionReceiptItemRepository;
        
        public IAcquisitionReceiptItemRepository AcquisitionReceiptItemRepository => _AcquisitionReceiptItemRepository = _AcquisitionReceiptItemRepository ?? new AcquisitionReceiptItemRepository(_context);
 


        private AssetRepository _AssetRepository;
        
        public IAssetRepository AssetRepository => _AssetRepository = _AssetRepository ?? new AssetRepository(_context);
 


        private AssetClassRepository _AssetClassRepository;
        
        public IAssetClassRepository AssetClassRepository => _AssetClassRepository = _AssetClassRepository ?? new AssetClassRepository(_context);
 


        private AssetGroupRepository _AssetGroupRepository;
        
        public IAssetGroupRepository AssetGroupRepository => _AssetGroupRepository = _AssetGroupRepository ?? new AssetGroupRepository(_context);
 


        private AssetRelatedPurchaseInvoiceRepository _AssetRelatedPurchaseInvoiceRepository;
        
        public IAssetRelatedPurchaseInvoiceRepository AssetRelatedPurchaseInvoiceRepository => _AssetRelatedPurchaseInvoiceRepository = _AssetRelatedPurchaseInvoiceRepository ?? new AssetRelatedPurchaseInvoiceRepository(_context);
 


        private AssetTransactionRepository _AssetTransactionRepository;
        
        public IAssetTransactionRepository AssetTransactionRepository => _AssetTransactionRepository = _AssetTransactionRepository ?? new AssetTransactionRepository(_context);
 


        private ChangeDepreciationMethodRepository _ChangeDepreciationMethodRepository;
        
        public IChangeDepreciationMethodRepository ChangeDepreciationMethodRepository => _ChangeDepreciationMethodRepository = _ChangeDepreciationMethodRepository ?? new ChangeDepreciationMethodRepository(_context);
 


        private ChangeDepreciationMethodItemRepository _ChangeDepreciationMethodItemRepository;
        
        public IChangeDepreciationMethodItemRepository ChangeDepreciationMethodItemRepository => _ChangeDepreciationMethodItemRepository = _ChangeDepreciationMethodItemRepository ?? new ChangeDepreciationMethodItemRepository(_context);
 


        private CostPartRepository _CostPartRepository;
        
        public ICostPartRepository CostPartRepository => _CostPartRepository = _CostPartRepository ?? new CostPartRepository(_context);
 


        private CostPartTransactionRepository _CostPartTransactionRepository;
        
        public ICostPartTransactionRepository CostPartTransactionRepository => _CostPartTransactionRepository = _CostPartTransactionRepository ?? new CostPartTransactionRepository(_context);
 


        private DepreciationRepository _DepreciationRepository;
        
        public IDepreciationRepository DepreciationRepository => _DepreciationRepository = _DepreciationRepository ?? new DepreciationRepository(_context);
 


        private DepreciationItemRepository _DepreciationItemRepository;
        
        public IDepreciationItemRepository DepreciationItemRepository => _DepreciationItemRepository = _DepreciationItemRepository ?? new DepreciationItemRepository(_context);
 


        private DepreciationRuleRepository _DepreciationRuleRepository;
        
        public IDepreciationRuleRepository DepreciationRuleRepository => _DepreciationRuleRepository = _DepreciationRuleRepository ?? new DepreciationRuleRepository(_context);
 


        private EliminationRepository _EliminationRepository;
        
        public IEliminationRepository EliminationRepository => _EliminationRepository = _EliminationRepository ?? new EliminationRepository(_context);
 


        private EliminationItemRepository _EliminationItemRepository;
        
        public IEliminationItemRepository EliminationItemRepository => _EliminationItemRepository = _EliminationItemRepository ?? new EliminationItemRepository(_context);
 


        private EmplacementRepository _EmplacementRepository;
        
        public IEmplacementRepository EmplacementRepository => _EmplacementRepository = _EmplacementRepository ?? new EmplacementRepository(_context);
 


        private RepairRepository _RepairRepository;
        
        public IRepairRepository RepairRepository => _RepairRepository = _RepairRepository ?? new RepairRepository(_context);
 


        private RepairItemRepository _RepairItemRepository;
        
        public IRepairItemRepository RepairItemRepository => _RepairItemRepository = _RepairItemRepository ?? new RepairItemRepository(_context);
 


        private SaleRepository _SaleRepository;
        
        public ISaleRepository SaleRepository => _SaleRepository = _SaleRepository ?? new SaleRepository(_context);
 


        private SaleItemRepository _SaleItemRepository;
        
        public ISaleItemRepository SaleItemRepository => _SaleItemRepository = _SaleItemRepository ?? new SaleItemRepository(_context);
 


        private SalvageRepository _SalvageRepository;
        
        public ISalvageRepository SalvageRepository => _SalvageRepository = _SalvageRepository ?? new SalvageRepository(_context);
 


        private SalvageItemRepository _SalvageItemRepository;
        
        public ISalvageItemRepository SalvageItemRepository => _SalvageItemRepository = _SalvageItemRepository ?? new SalvageItemRepository(_context);
 


        private TransferRepository _TransferRepository;
        
        public ITransferRepository TransferRepository => _TransferRepository = _TransferRepository ?? new TransferRepository(_context);
 


        private TransferItemRepository _TransferItemRepository;
        
        public ITransferItemRepository TransferItemRepository => _TransferItemRepository = _TransferItemRepository ?? new TransferItemRepository(_context);
 


        private UnuseableRepository _UnuseableRepository;
        
        public IUnuseableRepository UnuseableRepository => _UnuseableRepository = _UnuseableRepository ?? new UnuseableRepository(_context);
 


        private UnuseableItemRepository _UnuseableItemRepository;
        
        public IUnuseableItemRepository UnuseableItemRepository => _UnuseableItemRepository = _UnuseableItemRepository ?? new UnuseableItemRepository(_context);
 


        private UseableRepository _UseableRepository;
        
        public IUseableRepository UseableRepository => _UseableRepository = _UseableRepository ?? new UseableRepository(_context);
 


        private UseableItemRepository _UseableItemRepository;
        
        public IUseableItemRepository UseableItemRepository => _UseableItemRepository = _UseableItemRepository ?? new UseableItemRepository(_context);
 


        private AccountRepository _AccountRepository;
        
        public IAccountRepository AccountRepository => _AccountRepository = _AccountRepository ?? new AccountRepository(_context);
 


        private AccountTopicRepository _AccountTopicRepository;
        
        public IAccountTopicRepository AccountTopicRepository => _AccountTopicRepository = _AccountTopicRepository ?? new AccountTopicRepository(_context);
 


        private DLRepository _DLRepository;
        
        public IDLRepository DLRepository => _DLRepository = _DLRepository ?? new DLRepository(_context);
 


        private GLVoucherRepository _GLVoucherRepository;
        
        public IGLVoucherRepository GLVoucherRepository => _GLVoucherRepository = _GLVoucherRepository ?? new GLVoucherRepository(_context);
 


        private GLVoucherItemRepository _GLVoucherItemRepository;
        
        public IGLVoucherItemRepository GLVoucherItemRepository => _GLVoucherItemRepository = _GLVoucherItemRepository ?? new GLVoucherItemRepository(_context);
 


        private OpeningOperationRepository _OpeningOperationRepository;
        
        public IOpeningOperationRepository OpeningOperationRepository => _OpeningOperationRepository = _OpeningOperationRepository ?? new OpeningOperationRepository(_context);
 


        private OpeningOperationItemRepository _OpeningOperationItemRepository;
        
        public IOpeningOperationItemRepository OpeningOperationItemRepository => _OpeningOperationItemRepository = _OpeningOperationItemRepository ?? new OpeningOperationItemRepository(_context);
 


        private TopicRepository _TopicRepository;
        
        public ITopicRepository TopicRepository => _TopicRepository = _TopicRepository ?? new TopicRepository(_context);
 


        private VoucherRepository _VoucherRepository;
        
        public IVoucherRepository VoucherRepository => _VoucherRepository = _VoucherRepository ?? new VoucherRepository(_context);
 


        private VoucherItemRepository _VoucherItemRepository;
        
        public IVoucherItemRepository VoucherItemRepository => _VoucherItemRepository = _VoucherItemRepository ?? new VoucherItemRepository(_context);
 

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
