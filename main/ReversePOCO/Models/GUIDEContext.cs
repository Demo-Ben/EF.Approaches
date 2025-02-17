using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GUIDEContext : DbContext
    {
        public GUIDEContext()
        {
        }

        public GUIDEContext(DbContextOptions<GUIDEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AreaCode> AreaCodes { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AuditEvent> AuditEvents { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<AuditMurexGuideRateChange> AuditMurexGuideRateChanges { get; set; }
        public virtual DbSet<AuditTrail> AuditTrails { get; set; }
        public virtual DbSet<BankInf> BankInfs { get; set; }
        public virtual DbSet<BankInfCorr> BankInfCorrs { get; set; }
        public virtual DbSet<BaseRate> BaseRates { get; set; }
        public virtual DbSet<BisRate> BisRates { get; set; }
        public virtual DbSet<BusinessConditionA> BusinessConditionAs { get; set; }
        public virtual DbSet<BusinessConditionB> BusinessConditionBs { get; set; }
        public virtual DbSet<BusinessConditionC> BusinessConditionCs { get; set; }
        public virtual DbSet<CcyCodeTable> CcyCodeTables { get; set; }
        public virtual DbSet<CmpCode> CmpCodes { get; set; }
        public virtual DbSet<ConfigVal> ConfigVals { get; set; }
        public virtual DbSet<CorpSettlementAccount> CorpSettlementAccounts { get; set; }
        public virtual DbSet<CurrExchangeRate> CurrExchangeRates { get; set; }
        public virtual DbSet<CustAccountNo> CustAccountNoes { get; set; }
        public virtual DbSet<CustGradeCode> CustGradeCodes { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMasters { get; set; }
        public virtual DbSet<CustomerMasterBakMurexRelease> CustomerMasterBakMurexReleases { get; set; }
        public virtual DbSet<CustomerMasterLog> CustomerMasterLogs { get; set; }
        public virtual DbSet<CustomerMasterModCodesMurexRelease> CustomerMasterModCodesMurexReleases { get; set; }
        public virtual DbSet<DataDrivenSubscriptionSetting> DataDrivenSubscriptionSettings { get; set; }
        public virtual DbSet<DealTypeGroup> DealTypeGroups { get; set; }
        public virtual DbSet<DealingSettlementOfficeMap> DealingSettlementOfficeMaps { get; set; }
        public virtual DbSet<DepositsRate> DepositsRates { get; set; }
        public virtual DbSet<DistributionChannel> DistributionChannels { get; set; }
        public virtual DbSet<DistributionPassword> DistributionPasswords { get; set; }
        public virtual DbSet<DistributionPreference> DistributionPreferences { get; set; }
        public virtual DbSet<DistributionType> DistributionTypes { get; set; }
        public virtual DbSet<DomesticClearingAnzSummary> DomesticClearingAnzSummaries { get; set; }
        public virtual DbSet<DomesticClearingBsb> DomesticClearingBsbs { get; set; }
        public virtual DbSet<DomesticClearingBsbFile> DomesticClearingBsbFiles { get; set; }
        public virtual DbSet<DomesticClearingBulkPaymentDetail> DomesticClearingBulkPaymentDetails { get; set; }
        public virtual DbSet<DomesticClearingBulkPaymentSummary> DomesticClearingBulkPaymentSummaries { get; set; }
        public virtual DbSet<DomesticClearingDeposit> DomesticClearingDeposits { get; set; }
        public virtual DbSet<DomesticClearingDirectEntry> DomesticClearingDirectEntries { get; set; }
        public virtual DbSet<DomesticClearingDirection> DomesticClearingDirections { get; set; }
        public virtual DbSet<DomesticClearingFee> DomesticClearingFees { get; set; }
        public virtual DbSet<DomesticClearingFeeLog> DomesticClearingFeeLogs { get; set; }
        public virtual DbSet<DomesticClearingGasStatu> DomesticClearingGasStatus { get; set; }
        public virtual DbSet<DomesticClearingGde> DomesticClearingGdes { get; set; }
        public virtual DbSet<DomesticClearingGoposting> DomesticClearingGopostings { get; set; }
        public virtual DbSet<DomesticClearingMultiPurposeInstructionAttachment> DomesticClearingMultiPurposeInstructionAttachments { get; set; }
        public virtual DbSet<DomesticClearingMultiPurposeInstructionDetail> DomesticClearingMultiPurposeInstructionDetails { get; set; }
        public virtual DbSet<DomesticClearingNotification> DomesticClearingNotifications { get; set; }
        public virtual DbSet<DomesticClearingPayment> DomesticClearingPayments { get; set; }
        public virtual DbSet<DomesticClearingPaymentLine> DomesticClearingPaymentLines { get; set; }
        public virtual DbSet<DomesticClearingPaymentLineValidationError> DomesticClearingPaymentLineValidationErrors { get; set; }
        public virtual DbSet<DomesticClearingPaymentLog> DomesticClearingPaymentLogs { get; set; }
        public virtual DbSet<DomesticClearingPaymentMethod> DomesticClearingPaymentMethods { get; set; }
        public virtual DbSet<DomesticClearingPaymentMethodValidation> DomesticClearingPaymentMethodValidations { get; set; }
        public virtual DbSet<DomesticClearingPaymentValidationError> DomesticClearingPaymentValidationErrors { get; set; }
        public virtual DbSet<DomesticClearingPostingType> DomesticClearingPostingTypes { get; set; }
        public virtual DbSet<DomesticClearingPresentment> DomesticClearingPresentments { get; set; }
        public virtual DbSet<DomesticClearingProduct> DomesticClearingProducts { get; set; }
        public virtual DbSet<DomesticClearingProductLog> DomesticClearingProductLogs { get; set; }
        public virtual DbSet<DomesticClearingRecBatch> DomesticClearingRecBatches { get; set; }
        public virtual DbSet<DomesticClearingRecCollateGo> DomesticClearingRecCollateGoes { get; set; }
        public virtual DbSet<DomesticClearingRecCollateInwardClearing> DomesticClearingRecCollateInwardClearings { get; set; }
        public virtual DbSet<DomesticClearingRecCollatePayment> DomesticClearingRecCollatePayments { get; set; }
        public virtual DbSet<DomesticClearingRecCollatePaymentCreation> DomesticClearingRecCollatePaymentCreations { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoEuconDemandLogAccount> DomesticClearingRecCollectGoEuconDemandLogAccounts { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoEuconDemandLogCommon> DomesticClearingRecCollectGoEuconDemandLogCommons { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoGasGoCredit> DomesticClearingRecCollectGoGasGoCredits { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoGasGoDebit> DomesticClearingRecCollectGoGasGoDebits { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoGoposting> DomesticClearingRecCollectGoGopostings { get; set; }
        public virtual DbSet<DomesticClearingRecCollectInwardClearingAnzSummary> DomesticClearingRecCollectInwardClearingAnzSummaries { get; set; }
        public virtual DbSet<DomesticClearingRecCollectInwardClearingPayment> DomesticClearingRecCollectInwardClearingPayments { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentBulkPaymentSummary> DomesticClearingRecCollectPaymentBulkPaymentSummaries { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentCreationBulkPaymentSummary> DomesticClearingRecCollectPaymentCreationBulkPaymentSummaries { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachment> DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachments { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetail> DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetails { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentCreationPayment> DomesticClearingRecCollectPaymentCreationPayments { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentDereplyDetail> DomesticClearingRecCollectPaymentDereplyDetails { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentDereplyHeader> DomesticClearingRecCollectPaymentDereplyHeaders { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachment> DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachments { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentMultiPurposeInstructionDetail> DomesticClearingRecCollectPaymentMultiPurposeInstructionDetails { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentPayment> DomesticClearingRecCollectPaymentPayments { get; set; }
        public virtual DbSet<DomesticClearingRecCollection> DomesticClearingRecCollections { get; set; }
        public virtual DbSet<DomesticClearingRecKeyStatu> DomesticClearingRecKeyStatus { get; set; }
        public virtual DbSet<DomesticClearingRecRecGo> DomesticClearingRecRecGoes { get; set; }
        public virtual DbSet<DomesticClearingRecRecInwardClearing> DomesticClearingRecRecInwardClearings { get; set; }
        public virtual DbSet<DomesticClearingRecRecPayment> DomesticClearingRecRecPayments { get; set; }
        public virtual DbSet<DomesticClearingRecRecPaymentCreation> DomesticClearingRecRecPaymentCreations { get; set; }
        public virtual DbSet<DomesticClearingRecSource> DomesticClearingRecSources { get; set; }
        public virtual DbSet<DomesticClearingRecType> DomesticClearingRecTypes { get; set; }
        public virtual DbSet<DomesticClearingRecValueStatu> DomesticClearingRecValueStatus { get; set; }
        public virtual DbSet<DomesticClearingRemitter> DomesticClearingRemitters { get; set; }
        public virtual DbSet<DomesticClearingRemitterLog> DomesticClearingRemitterLogs { get; set; }
        public virtual DbSet<DomesticClearingReturnRefusalCode> DomesticClearingReturnRefusalCodes { get; set; }
        public virtual DbSet<DomesticClearingSource> DomesticClearingSources { get; set; }
        public virtual DbSet<DomesticClearingStatu> DomesticClearingStatus { get; set; }
        public virtual DbSet<DomesticClearingUnitCodeAccount> DomesticClearingUnitCodeAccounts { get; set; }
        public virtual DbSet<DomesticClearingUnitCodeAccountLog> DomesticClearingUnitCodeAccountLogs { get; set; }
        public virtual DbSet<DomesticClearingValidationError> DomesticClearingValidationErrors { get; set; }
        public virtual DbSet<DreamsUploadException> DreamsUploadExceptions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EndOfDayStart> EndOfDayStarts { get; set; }
        public virtual DbSet<EucCcyCode> EucCcyCodes { get; set; }
        public virtual DbSet<EucCollateralCode> EucCollateralCodes { get; set; }
        public virtual DbSet<EucCountryCode> EucCountryCodes { get; set; }
        public virtual DbSet<EucCustAttributeCode> EucCustAttributeCodes { get; set; }
        public virtual DbSet<EucCustomerAccountNo> EucCustomerAccountNoes { get; set; }
        public virtual DbSet<EucDeptCode> EucDeptCodes { get; set; }
        public virtual DbSet<EucIndustryCode> EucIndustryCodes { get; set; }
        public virtual DbSet<EucTaxCode> EucTaxCodes { get; set; }
        public virtual DbSet<FuturesRate> FuturesRates { get; set; }
        public virtual DbSet<FxRate> FxRates { get; set; }
        public virtual DbSet<FxSettlementInf> FxSettlementInfs { get; set; }
        public virtual DbSet<FxTransaction> FxTransactions { get; set; }
        public virtual DbSet<FxTransactionExt> FxTransactionExts { get; set; }
        public virtual DbSet<FxTransactionExtBakMurexRelease> FxTransactionExtBakMurexReleases { get; set; }
        public virtual DbSet<FxTransactionModCodesMurexRelease> FxTransactionModCodesMurexReleases { get; set; }
        public virtual DbSet<FxTransactionUploadGipStatu> FxTransactionUploadGipStatus { get; set; }
        public virtual DbSet<Fxfarbitrage> Fxfarbitrages { get; set; }
        public virtual DbSet<FxfbusCenter> FxfbusCenters { get; set; }
        public virtual DbSet<Fxfcalendar> Fxfcalendars { get; set; }
        public virtual DbSet<Fxfccy> Fxfccies { get; set; }
        public virtual DbSet<FxfcreditCustType> FxfcreditCustTypes { get; set; }
        public virtual DbSet<FxfcreditParent> FxfcreditParents { get; set; }
        public virtual DbSet<Fxfcust> Fxfcusts { get; set; }
        public virtual DbSet<FxfcustBakMurexRelease> FxfcustBakMurexReleases { get; set; }
        public virtual DbSet<Fxfcustthreshold> Fxfcustthresholds { get; set; }
        public virtual DbSet<FxfdealType> FxfdealTypes { get; set; }
        public virtual DbSet<Fxfinstitution> Fxfinstitutions { get; set; }
        public virtual DbSet<Fxfswift> Fxfswifts { get; set; }
        public virtual DbSet<FxfswiftModCodesMurexRelease> FxfswiftModCodesMurexReleases { get; set; }
        public virtual DbSet<GasGoCredit> GasGoCredits { get; set; }
        public virtual DbSet<GasGoDebit> GasGoDebits { get; set; }
        public virtual DbSet<GasGoParameter> GasGoParameters { get; set; }
        public virtual DbSet<GasGoUploadParameter> GasGoUploadParameters { get; set; }
        public virtual DbSet<GasTemplate> GasTemplates { get; set; }
        public virtual DbSet<GasTemplateDetail> GasTemplateDetails { get; set; }
        public virtual DbSet<GasUploadHistory> GasUploadHistories { get; set; }
        public virtual DbSet<GasUploadStatu> GasUploadStatus { get; set; }
        public virtual DbSet<GasUploadTexception> GasUploadTexceptions { get; set; }
        public virtual DbSet<GbaseErrorCode> GbaseErrorCodes { get; set; }
        public virtual DbSet<GbaseRateConversionByCcyPair> GbaseRateConversionByCcyPairs { get; set; }
        public virtual DbSet<GbaseReferenceNo> GbaseReferenceNoes { get; set; }
        public virtual DbSet<GbaseReferenceNoLastUsed> GbaseReferenceNoLastUseds { get; set; }
        public virtual DbSet<GeneralisedCode> GeneralisedCodes { get; set; }
        public virtual DbSet<GlinkQueueManagerAction> GlinkQueueManagerActions { get; set; }
        public virtual DbSet<GuideBisRateTempl> GuideBisRateTempls { get; set; }
        public virtual DbSet<GuideDepositRateTempl> GuideDepositRateTempls { get; set; }
        public virtual DbSet<GuideExchangeRateTempl> GuideExchangeRateTempls { get; set; }
        public virtual DbSet<GuideLog> GuideLogs { get; set; }
        public virtual DbSet<GuideRevaluationRateTempl> GuideRevaluationRateTempls { get; set; }
        public virtual DbSet<GuideSwapRateTempl> GuideSwapRateTempls { get; set; }
        public virtual DbSet<InterbankAccountNo> InterbankAccountNoes { get; set; }
        public virtual DbSet<MassApprovalInput> MassApprovalInputs { get; set; }
        public virtual DbSet<MassDreamsApprovalAccess> MassDreamsApprovalAccesses { get; set; }
        public virtual DbSet<MassGbaseMenuAccess> MassGbaseMenuAccesses { get; set; }
        public virtual DbSet<MassTransaction> MassTransactions { get; set; }
        public virtual DbSet<MassTransactionHistory> MassTransactionHistories { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<MoneyMarketTicket> MoneyMarketTickets { get; set; }
        public virtual DbSet<MoneyMarketTicketExt> MoneyMarketTicketExts { get; set; }
        public virtual DbSet<MsmqMessageData> MsmqMessageDatas { get; set; }
        public virtual DbSet<MsmqMessageHistoryData> MsmqMessageHistoryDatas { get; set; }
        public virtual DbSet<MurexHolidayCalendar> MurexHolidayCalendars { get; set; }
        public virtual DbSet<MurexRamSummary> MurexRamSummaries { get; set; }
        public virtual DbSet<MurexRateExportControl> MurexRateExportControls { get; set; }
        public virtual DbSet<MxCategory> MxCategories { get; set; }
        public virtual DbSet<MxCounterpartyType> MxCounterpartyTypes { get; set; }
        public virtual DbSet<MxCtpyTypeAttrCode> MxCtpyTypeAttrCodes { get; set; }
        public virtual DbSet<MxCustCounterpartyType> MxCustCounterpartyTypes { get; set; }
        public virtual DbSet<MxCustCounterpartyTypeBakMurexRelease> MxCustCounterpartyTypeBakMurexReleases { get; set; }
        public virtual DbSet<MxCustomerEvent> MxCustomerEvents { get; set; }
        public virtual DbSet<MxCustomerStatu> MxCustomerStatus { get; set; }
        public virtual DbSet<MxEucBalanceEvent> MxEucBalanceEvents { get; set; }
        public virtual DbSet<MxGuideCustDetail> MxGuideCustDetails { get; set; }
        public virtual DbSet<MxGuideCustDetailBakMurexRelease> MxGuideCustDetailBakMurexReleases { get; set; }
        public virtual DbSet<MxInboundEvent> MxInboundEvents { get; set; }
        public virtual DbSet<MxInboundEventLog> MxInboundEventLogs { get; set; }
        public virtual DbSet<MxInboundMessageStatu> MxInboundMessageStatus { get; set; }
        public virtual DbSet<MxIndustryCodeSector> MxIndustryCodeSectors { get; set; }
        public virtual DbSet<MxTaxCode> MxTaxCodes { get; set; }
        public virtual DbSet<NetWrixAuditError> NetWrixAuditErrors { get; set; }
        public virtual DbSet<ObsBasisExportMapping> ObsBasisExportMappings { get; set; }
        public virtual DbSet<ObsBasisRate> ObsBasisRates { get; set; }
        public virtual DbSet<ObsYieldExportMapping> ObsYieldExportMappings { get; set; }
        public virtual DbSet<ObsYieldFutureMaturity> ObsYieldFutureMaturities { get; set; }
        public virtual DbSet<ObsYieldRate> ObsYieldRates { get; set; }
        public virtual DbSet<PasswordHistory> PasswordHistories { get; set; }
        public virtual DbSet<PaymentControlAccordConfirmation> PaymentControlAccordConfirmations { get; set; }
        public virtual DbSet<PaymentControlMatchFx> PaymentControlMatchFxes { get; set; }
        public virtual DbSet<PaymentControlMatchMoneyMarket> PaymentControlMatchMoneyMarkets { get; set; }
        public virtual DbSet<PaymentControlMisysConfirmation> PaymentControlMisysConfirmations { get; set; }
        public virtual DbSet<PaymentControlPayment> PaymentControlPayments { get; set; }
        public virtual DbSet<PaymentControlPaymentLog> PaymentControlPaymentLogs { get; set; }
        public virtual DbSet<PaymentControlProduct> PaymentControlProducts { get; set; }
        public virtual DbSet<PaymentControlProductReference> PaymentControlProductReferences { get; set; }
        public virtual DbSet<PaymentControlRemittance> PaymentControlRemittances { get; set; }
        public virtual DbSet<PaymentControlRtgsSwiftCodeTranslation> PaymentControlRtgsSwiftCodeTranslations { get; set; }
        public virtual DbSet<PaymentControlStatu> PaymentControlStatus { get; set; }
        public virtual DbSet<PaymentControlSwiftAck> PaymentControlSwiftAcks { get; set; }
        public virtual DbSet<PaymentControlSwiftPayment> PaymentControlSwiftPayments { get; set; }
        public virtual DbSet<PaymentControlSwiftPaymentLog> PaymentControlSwiftPaymentLogs { get; set; }
        public virtual DbSet<RacfSystemId> RacfSystemIds { get; set; }
        public virtual DbSet<RacfSystemIdHistory> RacfSystemIdHistories { get; set; }
        public virtual DbSet<RamBaseRecord> RamBaseRecords { get; set; }
        public virtual DbSet<RamGbaseTotal> RamGbaseTotals { get; set; }
        public virtual DbSet<RamReconSummary> RamReconSummaries { get; set; }
        public virtual DbSet<RatesGbaseUploadCriteria> RatesGbaseUploadCriterias { get; set; }
        public virtual DbSet<RatesGbaseUploadCtl> RatesGbaseUploadCtls { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<RevaluationRate> RevaluationRates { get; set; }
        public virtual DbSet<RmbDefault> RmbDefaults { get; set; }
        public virtual DbSet<SecurityGroup> SecurityGroups { get; set; }
        public virtual DbSet<SecurityGroupFunction> SecurityGroupFunctions { get; set; }
        public virtual DbSet<SettlementCorpCustDefault> SettlementCorpCustDefaults { get; set; }
        public virtual DbSet<SettlementCorpCustDefault2> SettlementCorpCustDefault2 { get; set; }
        public virtual DbSet<SettlementInf> SettlementInfs { get; set; }
        public virtual DbSet<SettlementInterbankDefault> SettlementInterbankDefaults { get; set; }
        public virtual DbSet<ShipUploadingHistory> ShipUploadingHistories { get; set; }
        public virtual DbSet<SpotRateUsdEquiv> SpotRateUsdEquivs { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SwapRate> SwapRates { get; set; }
        public virtual DbSet<SystemFunction> SystemFunctions { get; set; }
        public virtual DbSet<SystemMessage> SystemMessages { get; set; }
        public virtual DbSet<SystemModule> SystemModules { get; set; }
        public virtual DbSet<SystemModuleGroup> SystemModuleGroups { get; set; }
        public virtual DbSet<SystemParameter> SystemParameters { get; set; }
        public virtual DbSet<SystemRegistryParameter> SystemRegistryParameters { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<TransactionKindAdvancedNotice> TransactionKindAdvancedNotices { get; set; }
        public virtual DbSet<TransactionKindMoneyMarket> TransactionKindMoneyMarkets { get; set; }
        public virtual DbSet<TransactionKindOverrideCode> TransactionKindOverrideCodes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSecurityGroup> UserSecurityGroups { get; set; }
        public virtual DbSet<UsersExt> UsersExts { get; set; }
        public virtual DbSet<UsrGbaseSplTransaction> UsrGbaseSplTransactions { get; set; }
        public virtual DbSet<VgasGeneraloperation> VgasGeneraloperations { get; set; }
        public virtual DbSet<VgasSelectwebgastransaction> VgasSelectwebgastransactions { get; set; }
        public virtual DbSet<ViewEucBankInfPrepare1> ViewEucBankInfPrepare1 { get; set; }
        public virtual DbSet<ViewEucBankInfPrepare2> ViewEucBankInfPrepare2 { get; set; }
        public virtual DbSet<ViewEucCcyCode> ViewEucCcyCodes { get; set; }
        public virtual DbSet<ViewFxsystemCreditparent> ViewFxsystemCreditparents { get; set; }
        public virtual DbSet<ViewGipFxTransaction> ViewGipFxTransactions { get; set; }
        public virtual DbSet<ViewGuideCorpCustomerAccount> ViewGuideCorpCustomerAccounts { get; set; }
        public virtual DbSet<ViewGuideCustomerMasterAll> ViewGuideCustomerMasterAlls { get; set; }
        public virtual DbSet<ViewGuideFxTransaction> ViewGuideFxTransactions { get; set; }
        public virtual DbSet<ViewMmTicketDetail> ViewMmTicketDetails { get; set; }
        public virtual DbSet<ViewRamReconSummary> ViewRamReconSummaries { get; set; }
        public virtual DbSet<ViewRatesGuideBisRate> ViewRatesGuideBisRates { get; set; }
        public virtual DbSet<ViewRatesGuideDepositRate> ViewRatesGuideDepositRates { get; set; }
        public virtual DbSet<ViewRatesGuideSwapRate> ViewRatesGuideSwapRates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

                optionsBuilder.UseSqlServer("Server=HP6300-BEN\\MIZSQL2016;Database=GUIDE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaCode>(entity =>
            {
                entity.HasKey(e => e.AreaCode1);

                entity.ToTable("AREA_CODE");

                entity.Property(e => e.AreaCode1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AREA_CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId, "IX_RoleId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AuditEvent>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("AUDIT_EVENTS");

                entity.Property(e => e.Identifier)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("IDENTIFIER");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ExceptionFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXCEPTION_FLAG");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.ToTable("AUDIT_LOG");

                entity.Property(e => e.AuditId).HasColumnName("AUDIT_ID");

                entity.Property(e => e.AppName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APP_NAME");

                entity.Property(e => e.AuditDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AUDIT_DATE");

                entity.Property(e => e.AuditDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AUDIT_DESC");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("NEW_VALUE");

                entity.Property(e => e.OriginalValue)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINAL_VALUE");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REF_NO");

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.TransNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_NO");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AuditMurexGuideRateChange>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("AUDIT_MUREX_GUIDE_RATE_CHANGE");

                entity.Property(e => e.Identifier).HasColumnName("IDENTIFIER");

                entity.Property(e => e.Detail)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("DETAIL");

                entity.Property(e => e.Logdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGDATE");

                entity.Property(e => e.RateType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RATE_TYPE");
            });

            modelBuilder.Entity<AuditTrail>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("AUDIT_TRAIL");

                entity.Property(e => e.Identifier)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("IDENTIFIER");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DETAILS");

                entity.Property(e => e.EventDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EVENT_DATE");

                entity.Property(e => e.EventIdentifier)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("EVENT_IDENTIFIER");

                entity.Property(e => e.SmIdentifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("SM_IDENTIFIER");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<BankInf>(entity =>
            {
                entity.HasKey(e => new { e.SwiftId, e.SettlBranchNo });

                entity.ToTable("BANK_INF");

                entity.Property(e => e.SwiftId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_ID");

                entity.Property(e => e.SettlBranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SETTL_BRANCH_NO")
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.Acronym)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACRONYM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.ChapsSortCd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CHAPS_SORT_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChipsAba)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CHIPS_ABA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChipsUid)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CHIPS_UID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CorBankCd)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("COR_BANK_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FedId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("FED_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GIP_DESCRIPTION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_COUNTRY")
                    .HasDefaultValueSql("('AU')");

                entity.Property(e => e.MhcbBrAbbr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MHCB_BR_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.NameAddr1)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("NAME_ADDR_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameAddr2)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("NAME_ADDR_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameAddr3)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("NAME_ADDR_3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameAddr4)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("NAME_ADDR_4")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SwiftFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BankInfCorr>(entity =>
            {
                entity.HasKey(e => new { e.SwiftId, e.CcyCd, e.SettlBranchNo });

                entity.ToTable("BANK_INF_CORR");

                entity.HasIndex(e => e.MmSettlBankId, "IX_BANK_INF_CORR_SETTLE_BANK_ID");

                entity.HasIndex(e => e.SwiftId, "IX_BANK_INF_CORR_SWIFT_id");

                entity.Property(e => e.SwiftId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_ID");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.SettlBranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SETTL_BRANCH_NO")
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.BankInfId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BANK_INF_ID");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeletionStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MmSettlBankActno)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("MM_SETTL_BANK_ACTNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MmSettlBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MM_SETTL_BANK_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.BankInfCorrs)
                    .HasForeignKey(d => new { d.SwiftId, d.SettlBranchNo })
                    .HasConstraintName("FK_BANK_INF_BANK_INF_CORR");
            });

            modelBuilder.Entity<BaseRate>(entity =>
            {
                entity.HasKey(e => new { e.OperationDate, e.StartDate, e.Ccy, e.Source, e.Duration });

                entity.ToTable("BASE_RATE");

                entity.Property(e => e.OperationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OPERATION_DATE");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.Source)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Duration)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("DURATION");

                entity.Property(e => e.ImportedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IMPORTED_BY");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("RATE");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS");
            });

            modelBuilder.Entity<BisRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Duration, e.DurationUnit });

                entity.ToTable("BIS_RATE");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.DurationUnit)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURATION_UNIT");

                entity.Property(e => e.BaseRate)
                    .HasColumnType("decimal(16, 7)")
                    .HasColumnName("BASE_RATE");

                entity.Property(e => e.ImportedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IMPORTED_BY")
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.ImportedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("IMPORTED_TIME")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BusinessConditionA>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Business_Condition_A");

                entity.Property(e => e.Code)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<BusinessConditionB>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Business_Condition_B");

                entity.Property(e => e.Code)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<BusinessConditionC>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Business_Condition_C");

                entity.Property(e => e.Code)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<CcyCodeTable>(entity =>
            {
                entity.HasKey(e => e.CcyCd);

                entity.ToTable("CCY_CODE_Table");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.DecimalPoint).HasColumnName("DECIMAL_POINT");

                entity.Property(e => e.DkbSpecialRateJpy)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DKB_SPECIAL_RATE_JPY");

                entity.Property(e => e.DkbSpecialRateUsd)
                    .HasColumnType("decimal(8, 6)")
                    .HasColumnName("DKB_SPECIAL_RATE_USD");

                entity.Property(e => e.Mark3Cd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MARK3_CD");

                entity.Property(e => e.SetpsCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SETPS_CD");

                entity.Property(e => e.SwiftCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_CD");
            });

            modelBuilder.Entity<CmpCode>(entity =>
            {
                entity.HasKey(e => e.CmpCode1);

                entity.ToTable("CMP_CODE");

                entity.Property(e => e.CmpCode1)
                    .ValueGeneratedNever()
                    .HasColumnName("CMP_CODE");

                entity.Property(e => e.CmpAbbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CMP_ABBR");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<ConfigVal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Config_val");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(1500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorpSettlementAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CORP_SETTLEMENT_ACCOUNT");

                entity.Property(e => e.AddBy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON");

                entity.Property(e => e.AdviceRecFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADVICE_REC_FLG");

                entity.Property(e => e.AdviceRecLimit)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("ADVICE_REC_LIMIT");

                entity.Property(e => e.AuthorizeBy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON");

                entity.Property(e => e.BankFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANK_FLG");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.CoverPoFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COVER_PO_FLG");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.FxId).HasColumnName("FX_ID");

                entity.Property(e => e.PayActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_CD");

                entity.Property(e => e.PayMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PAY_MESSAGE_TYPE");

                entity.Property(e => e.PayMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_METHOD");

                entity.Property(e => e.PayRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_RMT_FLG");

                entity.Property(e => e.PaySettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SETTL_CODE");

                entity.Property(e => e.PriortyFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PRIORTY_FLG");

                entity.Property(e => e.RecActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_CD");

                entity.Property(e => e.RecBankId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_BANK_ID");

                entity.Property(e => e.RecMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REC_MESSAGE_TYPE");

                entity.Property(e => e.RecMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_METHOD");

                entity.Property(e => e.RecRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_RMT_FLG");

                entity.Property(e => e.RecSettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_SETTL_CODE");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<CurrExchangeRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CURR_EXCHANGE_RATES");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFECTIVE_DATE");

                entity.Property(e => e.FromCcyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FROM_CCY_CODE");

                entity.Property(e => e.MeanRate)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("MEAN_RATE");

                entity.Property(e => e.OdbRate)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("ODB_RATE");

                entity.Property(e => e.OdsRate)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("ODS_RATE");

                entity.Property(e => e.ToCcyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TO_CCY_CODE");

                entity.Property(e => e.TtbRate)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("TTB_RATE");

                entity.Property(e => e.TtsRate)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("TTS_RATE");
            });

            modelBuilder.Entity<CustAccountNo>(entity =>
            {
                entity.HasKey(e => e.ActId);

                entity.ToTable("CUST_ACCOUNT_NO");

                entity.Property(e => e.ActId)
                    .ValueGeneratedNever()
                    .HasColumnName("ACT_ID");

                entity.Property(e => e.ActCd)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACT_CD");

                entity.Property(e => e.ActDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ACT_DESCRIPTION");

                entity.Property(e => e.ActNo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ACT_NO");

                entity.Property(e => e.AddBy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON");

                entity.Property(e => e.AuthorizeBy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyCd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Ubo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UBO");
            });

            modelBuilder.Entity<CustGradeCode>(entity =>
            {
                entity.HasKey(e => e.GradeCode);

                entity.ToTable("CUST_GRADE_CODE");

                entity.Property(e => e.GradeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GRADE_CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.GradeAbbr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GRADE_ABBR");
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.CustAbbr });

                entity.ToTable("CUSTOMER_MASTER");

                entity.HasIndex(e => e.CustAbbr, "IX_CUSTOMER_MASTER_CUST_ABBR");

                entity.HasIndex(e => e.CustId, "IX_CUSTOMER_MASTER_CUST_ID");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO")
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Address)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AreaCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AREA_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AttributeCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AttributeSubCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_SUB_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.BankFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANK_FLG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankGroupAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BANK_GROUP_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankManagementCd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BANK_MANAGEMENT_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BoeCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BOE_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BusinessCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_CONDITION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CfsIo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CFS_IO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CollateralNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COLLATERAL_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyCd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CorresBankCd)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CORRES_BANK_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditSupervision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_SUPERVISION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustId)
                    .HasColumnName("CUST_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CustName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DepartmentCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DkbCompanyCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DKB_COMPANY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GIP_DESCRIPTION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GoodAssetFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GOOD_ASSET_FLG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GradeCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GRADE_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupCd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("GROUP_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupCompanyCd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GROUP_COMPANY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorAttrCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_ATTR_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_COUNTRY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_NAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IndustryCd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("INDUSTRY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JapaneseFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JAPANESE_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LAST_UPDATED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LicenceFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LICENCE_FLG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocalIndustryCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LOCAL_INDUSTRY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_COUNTRY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MailCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_COUNTRY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mark3Cd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MARK3_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NATIONALITY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NextReviewDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NEXT_REVIEW_DATE")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.ObligorSupervision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OBLIGOR_SUPERVISION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OfficerCd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("OFFICER_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OffshoreCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OFFSHORE_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpeningDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("OPENING_DATE")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ParentCustCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_CUST_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentNationality)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_NATIONALITY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RatingDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("RATING_DATE")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.RatingPoint)
                    .HasColumnName("RATING_POINT")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.RatioOfInvDkb)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("RATIO_OF_INV_DKB")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RatioOfInvGvn)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("RATIO_OF_INV_GVN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RatioOfInvJp)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("RATIO_OF_INV_JP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Remarks1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RetailActNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RETAIL_ACT_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StaffLoanFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_LOAN_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Stance)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STANCE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StepsCustCd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STEPS_CUST_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SublimitBankAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SUBLIMIT_BANK_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TAX_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TAX_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TAX_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelexNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TELEX_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CustomerMasterBakMurexRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CUSTOMER_MASTER_Bak_MurexRelease");

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON");

                entity.Property(e => e.Address)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS2");

                entity.Property(e => e.AreaCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AREA_CD");

                entity.Property(e => e.AttributeCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CD");

                entity.Property(e => e.AttributeSubCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_SUB_CD");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON");

                entity.Property(e => e.BankFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANK_FLG");

                entity.Property(e => e.BankGroupAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BANK_GROUP_ABBR");

                entity.Property(e => e.BankManagementCd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BANK_MANAGEMENT_CD");

                entity.Property(e => e.BoeCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BOE_CD");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.BusinessCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_CONDITION");

                entity.Property(e => e.CfsIo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CFS_IO");

                entity.Property(e => e.CollateralNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COLLATERAL_NO");

                entity.Property(e => e.CompanyCd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_CD");

                entity.Property(e => e.CorresBankCd)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CORRES_BANK_CD");

                entity.Property(e => e.CreditSupervision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_SUPERVISION");

                entity.Property(e => e.CustAbbr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE");

                entity.Property(e => e.CustId).HasColumnName("CUST_ID");

                entity.Property(e => e.CustName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON");

                entity.Property(e => e.DeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS");

                entity.Property(e => e.DepartmentCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_CD");

                entity.Property(e => e.DkbCompanyCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DKB_COMPANY_CD");

                entity.Property(e => e.GipDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GIP_DESCRIPTION");

                entity.Property(e => e.GipStatus)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS");

                entity.Property(e => e.GoodAssetFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GOOD_ASSET_FLG");

                entity.Property(e => e.GradeCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GRADE_CD");

                entity.Property(e => e.GroupCd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("GROUP_CD");

                entity.Property(e => e.GroupCompanyCd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GROUP_COMPANY_CD");

                entity.Property(e => e.GuarantorAttrCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_ATTR_CD");

                entity.Property(e => e.GuarantorCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_CD");

                entity.Property(e => e.GuarantorCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_COUNTRY");

                entity.Property(e => e.GuarantorName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_NAME");

                entity.Property(e => e.IndustryCd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("INDUSTRY_CD");

                entity.Property(e => e.JapaneseFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JAPANESE_FLG");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LAST_UPDATED");

                entity.Property(e => e.LicenceFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LICENCE_FLG");

                entity.Property(e => e.LocalIndustryCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LOCAL_INDUSTRY_CD");

                entity.Property(e => e.LocationCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_COUNTRY");

                entity.Property(e => e.MailCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_COUNTRY");

                entity.Property(e => e.Mark3Cd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MARK3_CD");

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NATIONALITY");

                entity.Property(e => e.NextReviewDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NEXT_REVIEW_DATE");

                entity.Property(e => e.ObligorSupervision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OBLIGOR_SUPERVISION");

                entity.Property(e => e.OfficerCd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("OFFICER_CD");

                entity.Property(e => e.OffshoreCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OFFSHORE_CD");

                entity.Property(e => e.OpeningDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("OPENING_DATE");

                entity.Property(e => e.ParentCustCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_CUST_CD");

                entity.Property(e => e.ParentNationality)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_NATIONALITY");

                entity.Property(e => e.RatingDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("RATING_DATE");

                entity.Property(e => e.RatingPoint).HasColumnName("RATING_POINT");

                entity.Property(e => e.RatioOfInvDkb)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("RATIO_OF_INV_DKB");

                entity.Property(e => e.RatioOfInvGvn)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("RATIO_OF_INV_GVN");

                entity.Property(e => e.RatioOfInvJp)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("RATIO_OF_INV_JP");

                entity.Property(e => e.Remarks1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_1");

                entity.Property(e => e.Remarks2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_2");

                entity.Property(e => e.Remarks3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_3");

                entity.Property(e => e.RetailActNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RETAIL_ACT_NO");

                entity.Property(e => e.StaffLoanFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_LOAN_FLG");

                entity.Property(e => e.Stance)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STANCE");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD");

                entity.Property(e => e.StepsCustCd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STEPS_CUST_CD");

                entity.Property(e => e.SublimitBankAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SUBLIMIT_BANK_ABBR");

                entity.Property(e => e.TaxCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TAX_CD");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TAX_ID");

                entity.Property(e => e.TaxNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TAX_NO");

                entity.Property(e => e.TelNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL_NO");

                entity.Property(e => e.TelexNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TELEX_NO");

                entity.Property(e => e.TranNo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO");
            });

            modelBuilder.Entity<CustomerMasterLog>(entity =>
            {
                entity.ToTable("CUSTOMER_MASTER_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON");

                entity.Property(e => e.Address)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS2");

                entity.Property(e => e.AreaCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AREA_CD");

                entity.Property(e => e.AttributeCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CD");

                entity.Property(e => e.AttributeSubCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_SUB_CD");

                entity.Property(e => e.AuthorizeBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON");

                entity.Property(e => e.BankFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANK_FLG");

                entity.Property(e => e.BankGroupAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BANK_GROUP_ABBR");

                entity.Property(e => e.BankManagementCd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BANK_MANAGEMENT_CD");

                entity.Property(e => e.BoeCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BOE_CD");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.BusinessCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_CONDITION");

                entity.Property(e => e.CfsIo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CFS_IO");

                entity.Property(e => e.CollateralNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COLLATERAL_NO");

                entity.Property(e => e.CompanyCd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_CD");

                entity.Property(e => e.CorresBankCd)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CORRES_BANK_CD");

                entity.Property(e => e.CreditSupervision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_SUPERVISION");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE");

                entity.Property(e => e.CustId).HasColumnName("CUST_ID");

                entity.Property(e => e.CustName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.DeleteBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON");

                entity.Property(e => e.DeletionStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS");

                entity.Property(e => e.DepartmentCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_CD");

                entity.Property(e => e.DkbCompanyCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DKB_COMPANY_CD");

                entity.Property(e => e.GipDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GIP_DESCRIPTION");

                entity.Property(e => e.GipStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS");

                entity.Property(e => e.GoodAssetFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GOOD_ASSET_FLG");

                entity.Property(e => e.GradeCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GRADE_CD");

                entity.Property(e => e.GroupCd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("GROUP_CD");

                entity.Property(e => e.GroupCompanyCd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GROUP_COMPANY_CD");

                entity.Property(e => e.GuarantorAttrCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_ATTR_CD");

                entity.Property(e => e.GuarantorCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_CD");

                entity.Property(e => e.GuarantorCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_COUNTRY");

                entity.Property(e => e.GuarantorName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTOR_NAME");

                entity.Property(e => e.IndustryCd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("INDUSTRY_CD");

                entity.Property(e => e.JapaneseFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JAPANESE_FLG");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LAST_UPDATED");

                entity.Property(e => e.LicenceFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LICENCE_FLG");

                entity.Property(e => e.LocalIndustryCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LOCAL_INDUSTRY_CD");

                entity.Property(e => e.LocationCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_COUNTRY");

                entity.Property(e => e.LogTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MailCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_COUNTRY");

                entity.Property(e => e.Mark3Cd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MARK3_CD");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NATIONALITY");

                entity.Property(e => e.NextReviewDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NEXT_REVIEW_DATE");

                entity.Property(e => e.ObligorSupervision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OBLIGOR_SUPERVISION");

                entity.Property(e => e.OfficerCd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("OFFICER_CD");

                entity.Property(e => e.OffshoreCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OFFSHORE_CD");

                entity.Property(e => e.OpeningDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("OPENING_DATE");

                entity.Property(e => e.ParentCustCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_CUST_CD");

                entity.Property(e => e.ParentNationality)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_NATIONALITY");

                entity.Property(e => e.RatingDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("RATING_DATE");

                entity.Property(e => e.RatingPoint).HasColumnName("RATING_POINT");

                entity.Property(e => e.RatioOfInvDkb)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("RATIO_OF_INV_DKB");

                entity.Property(e => e.RatioOfInvGvn)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("RATIO_OF_INV_GVN");

                entity.Property(e => e.RatioOfInvJp)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("RATIO_OF_INV_JP");

                entity.Property(e => e.Remarks1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_1");

                entity.Property(e => e.Remarks2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_2");

                entity.Property(e => e.Remarks3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_3");

                entity.Property(e => e.RetailActNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RETAIL_ACT_NO");

                entity.Property(e => e.StaffLoanFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_LOAN_FLG");

                entity.Property(e => e.Stance)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STANCE");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD");

                entity.Property(e => e.StepsCustCd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STEPS_CUST_CD");

                entity.Property(e => e.SublimitBankAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SUBLIMIT_BANK_ABBR");

                entity.Property(e => e.TaxCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TAX_CD");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TAX_ID");

                entity.Property(e => e.TaxNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TAX_NO");

                entity.Property(e => e.TelNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL_NO");

                entity.Property(e => e.TelexNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TELEX_NO");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO");
            });

            modelBuilder.Entity<CustomerMasterModCodesMurexRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CUSTOMER_MASTER_Mod_Codes_MurexRelease");

                entity.Property(e => e.CustAbbr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Cust_Abbr");

                entity.Property(e => e.ParallelCustCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ParallelCustId).HasColumnName("ParallelCustID");

                entity.Property(e => e.ProdBranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ProdBRANCH_NO");

                entity.Property(e => e.ProdCustCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProdCustId).HasColumnName("ProdCustID");
            });

            modelBuilder.Entity<DataDrivenSubscriptionSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DataDrivenSubscription_Setting");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Email_Address")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndOfDay)
                    .HasColumnName("End_of_Day")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FileExtn)
                    .HasColumnName("FileEXTN")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("File_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Linked)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('\\\\mizweb01\\AppData$\\guide\\report')");

                entity.Property(e => e.PwExpired)
                    .HasColumnName("PW_Expired")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.RenderFormat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Render_Format")
                    .HasDefaultValueSql("('MHTML')");

                entity.Property(e => e.ReportInclude)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Report_Include")
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.WriteMode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AutoIncrement')");
            });

            modelBuilder.Entity<DealTypeGroup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FamilyCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.ThreeLetterCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DealingSettlementOfficeMap>(entity =>
            {
                entity.HasKey(e => e.DealingSettlementOfficeId)
                    .HasName("PK_Dealing_SettlementOffice");

                entity.ToTable("Dealing_SettlementOfficeMap");

                entity.Property(e => e.DealingSettlementOfficeId).HasColumnName("Dealing_SettlementOfficeID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By")
                    .HasDefaultValueSql("('DTS Upload')");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DealingOfficeCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DealingOfficeLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DealingOfficeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealingSystem)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Modified_By")
                    .HasDefaultValueSql("('DTS Upload')");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SettlementOfficeCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepositsRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Period });

                entity.ToTable("DEPOSITS_RATE");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Period)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD")
                    .HasDefaultValueSql("('1M')");

                entity.Property(e => e.Bid)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("BID");

                entity.Property(e => e.ImportedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IMPORTED_BY")
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.ImportedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("IMPORTED_TIME")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Offer)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("OFFER");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("RATE");

                entity.Property(e => e.RecStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DistributionChannel>(entity =>
            {
                entity.ToTable("DISTRIBUTION_CHANNEL");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DistributionPassword>(entity =>
            {
                entity.ToTable("DISTRIBUTION_PASSWORD");

                entity.Property(e => e.CustomerAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBranch)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DistributionPreference>(entity =>
            {
                entity.ToTable("DISTRIBUTION_PREFERENCE");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.AuthorisedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorisedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.CustomerAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBranch)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.DistributionChannelNavigation)
                    .WithMany(p => p.DistributionPreferences)
                    .HasForeignKey(d => d.DistributionChannel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DISTRIBUTION_PREFERENCE_DISTRIBUTION_CHANNEL");

                entity.HasOne(d => d.DistributionTypeNavigation)
                    .WithMany(p => p.DistributionPreferences)
                    .HasForeignKey(d => d.DistributionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DISTRIBUTION_PREFERENCE_DISTRIBUTION_TYPE");
            });

            modelBuilder.Entity<DistributionType>(entity =>
            {
                entity.ToTable("DISTRIBUTION_TYPE");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DefaultDistributionStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DistributionType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DistributionType");

                entity.Property(e => e.TemplateName).IsUnicode(false);

                entity.Property(e => e.VisableToSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DomesticClearingAnzSummary>(entity =>
            {
                entity.HasKey(e => e.AnzSummaryId);

                entity.ToTable("DomesticClearing_AnzSummary");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.DebitValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Description).HasMaxLength(25);

                entity.Property(e => e.Direction).HasMaxLength(10);

                entity.Property(e => e.Filename).HasMaxLength(1024);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.TotalValueOfTransactions).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DomesticClearingBsb>(entity =>
            {
                entity.HasKey(e => e.BsbId);

                entity.ToTable("DomesticClearing_BSB");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.BsbNo).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mnemonic).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(50);

                entity.Property(e => e.Pt)
                    .HasMaxLength(50)
                    .HasColumnName("PT");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Suburb).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingBsbFile>(entity =>
            {
                entity.HasKey(e => e.BsbFileId);

                entity.ToTable("DomesticClearing_BsbFile");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Filename).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingBulkPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.BulkPaymentDetailId);

                entity.ToTable("DomesticClearing_BulkPaymentDetail");

                entity.Property(e => e.AbanumberBeneficiaryBank)
                    .HasMaxLength(50)
                    .HasColumnName("ABANumberBeneficiaryBank");

                entity.Property(e => e.AbanumberIntermediaryBank)
                    .HasMaxLength(50)
                    .HasColumnName("ABANumberIntermediaryBank");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ApproveDate1).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate2).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate3).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate4).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate5).HasColumnType("datetime");

                entity.Property(e => e.Approver1).HasMaxLength(50);

                entity.Property(e => e.Approver2).HasMaxLength(50);

                entity.Property(e => e.Approver3).HasMaxLength(50);

                entity.Property(e => e.Approver4).HasMaxLength(50);

                entity.Property(e => e.Approver5).HasMaxLength(50);

                entity.Property(e => e.Attachment).HasMaxLength(50);

                entity.Property(e => e.BankCharges).HasMaxLength(50);

                entity.Property(e => e.BankCodeBeneficiaryBank).HasMaxLength(50);

                entity.Property(e => e.BankCodeBeneficiaryBankforChinese).HasMaxLength(50);

                entity.Property(e => e.BankCodeIntermediaryBank).HasMaxLength(50);

                entity.Property(e => e.BankCodeIntermediaryBankforChinese).HasMaxLength(50);

                entity.Property(e => e.BankStaffName).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryAccountNumber).HasMaxLength(50);

                entity.Property(e => e.BeneficiaryAddress1).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryAddress2).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryBankAddress1).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryBankAddress2).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryBankChineseSimplified).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryBankName1).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryBankName2).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryName1).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryName2).HasMaxLength(255);

                entity.Property(e => e.BeneficiarysNameChineseSimplified).HasMaxLength(255);

                entity.Property(e => e.BeneficiarysNameDoubleByteCharacter).HasMaxLength(255);

                entity.Property(e => e.BlankColumn).HasMaxLength(50);

                entity.Property(e => e.ChargeAccount).HasMaxLength(50);

                entity.Property(e => e.ChipsBeneficiaryBank).HasMaxLength(50);

                entity.Property(e => e.ChipsIntermediaryBank).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.CustomerCode).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.CustomerReferenceNumber).HasMaxLength(50);

                entity.Property(e => e.DebitAccountCurrency).HasMaxLength(50);

                entity.Property(e => e.DetailStatusType).HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ExchangeRateInput).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationNumber1).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationNumber2).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationNumber3).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationNumber4).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationNumber5).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationRate1).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationRate2).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationRate3).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationRate4).HasMaxLength(50);

                entity.Property(e => e.ExchangeReservationRate5).HasMaxLength(50);

                entity.Property(e => e.Explanation).HasMaxLength(1024);

                entity.Property(e => e.Field1).HasMaxLength(255);

                entity.Property(e => e.Field10).HasMaxLength(255);

                entity.Property(e => e.Field11).HasMaxLength(255);

                entity.Property(e => e.Field12).HasMaxLength(255);

                entity.Property(e => e.Field13).HasMaxLength(255);

                entity.Property(e => e.Field14).HasMaxLength(255);

                entity.Property(e => e.Field15).HasMaxLength(255);

                entity.Property(e => e.Field16).HasMaxLength(255);

                entity.Property(e => e.Field17).HasMaxLength(255);

                entity.Property(e => e.Field18).HasMaxLength(255);

                entity.Property(e => e.Field19).HasMaxLength(255);

                entity.Property(e => e.Field2).HasMaxLength(255);

                entity.Property(e => e.Field20).HasMaxLength(255);

                entity.Property(e => e.Field21).HasMaxLength(255);

                entity.Property(e => e.Field22).HasMaxLength(255);

                entity.Property(e => e.Field23).HasMaxLength(255);

                entity.Property(e => e.Field24).HasMaxLength(255);

                entity.Property(e => e.Field25).HasMaxLength(255);

                entity.Property(e => e.Field26).HasMaxLength(255);

                entity.Property(e => e.Field27).HasMaxLength(255);

                entity.Property(e => e.Field28).HasMaxLength(255);

                entity.Property(e => e.Field29).HasMaxLength(255);

                entity.Property(e => e.Field3).HasMaxLength(255);

                entity.Property(e => e.Field30).HasMaxLength(255);

                entity.Property(e => e.Field31).HasMaxLength(255);

                entity.Property(e => e.Field32).HasMaxLength(255);

                entity.Property(e => e.Field33).HasMaxLength(255);

                entity.Property(e => e.Field34).HasMaxLength(255);

                entity.Property(e => e.Field35).HasMaxLength(255);

                entity.Property(e => e.Field36).HasMaxLength(255);

                entity.Property(e => e.Field37).HasMaxLength(255);

                entity.Property(e => e.Field38).HasMaxLength(255);

                entity.Property(e => e.Field39).HasMaxLength(255);

                entity.Property(e => e.Field4).HasMaxLength(255);

                entity.Property(e => e.Field40).HasMaxLength(255);

                entity.Property(e => e.Field41).HasMaxLength(255);

                entity.Property(e => e.Field42).HasMaxLength(255);

                entity.Property(e => e.Field43).HasMaxLength(255);

                entity.Property(e => e.Field44).HasMaxLength(255);

                entity.Property(e => e.Field45).HasMaxLength(255);

                entity.Property(e => e.Field46).HasMaxLength(255);

                entity.Property(e => e.Field47).HasMaxLength(255);

                entity.Property(e => e.Field48).HasMaxLength(255);

                entity.Property(e => e.Field49).HasMaxLength(255);

                entity.Property(e => e.Field5).HasMaxLength(255);

                entity.Property(e => e.Field50).HasMaxLength(255);

                entity.Property(e => e.Field6).HasMaxLength(255);

                entity.Property(e => e.Field7).HasMaxLength(255);

                entity.Property(e => e.Field8).HasMaxLength(255);

                entity.Property(e => e.Field9).HasMaxLength(255);

                entity.Property(e => e.FinancialInstitutionCodeBeneficiaryBank).HasMaxLength(50);

                entity.Property(e => e.FinancialInstitutionCodeIntermediaryBank).HasMaxLength(50);

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.Ibancode)
                    .HasMaxLength(50)
                    .HasColumnName("IBANcode");

                entity.Property(e => e.InstructionCode).HasMaxLength(50);

                entity.Property(e => e.IntermediaryBankAddress1).HasMaxLength(255);

                entity.Property(e => e.IntermediaryBankAddress2).HasMaxLength(255);

                entity.Property(e => e.IntermediaryBankChineseSimplified).HasMaxLength(255);

                entity.Property(e => e.IntermediaryBankName1).HasMaxLength(255);

                entity.Property(e => e.IntermediaryBankName2).HasMaxLength(255);

                entity.Property(e => e.MessagetoBranch).HasMaxLength(1024);

                entity.Property(e => e.NewPaymentMethod).HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.RecordNumber).HasMaxLength(50);

                entity.Property(e => e.ReferenceAuthority).HasMaxLength(50);

                entity.Property(e => e.RegisteredAccountAddress).HasMaxLength(255);

                entity.Property(e => e.RegulatoryReporting).HasMaxLength(255);

                entity.Property(e => e.RejectedReason).HasMaxLength(1024);

                entity.Property(e => e.RemarksChineseSimplified).HasMaxLength(1024);

                entity.Property(e => e.RemittanceAmount).HasMaxLength(50);

                entity.Property(e => e.RemittanceCurrency).HasMaxLength(50);

                entity.Property(e => e.RemittanceInformation).HasMaxLength(1024);

                entity.Property(e => e.RemittancetoPersonalAccount).HasMaxLength(50);

                entity.Property(e => e.SortCodeBeneficiaryBank).HasMaxLength(50);

                entity.Property(e => e.SortcodeIntermediaryBank).HasMaxLength(50);

                entity.Property(e => e.SwiftbicbeneficiaryBank)
                    .HasMaxLength(50)
                    .HasColumnName("SWIFTBICBeneficiaryBank");

                entity.Property(e => e.SwiftbicintermediaryBank)
                    .HasMaxLength(50)
                    .HasColumnName("SWIFTBICIntermediaryBank");

                entity.Property(e => e.TakeupAmount1).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.TakeupAmount2).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.TakeupAmount3).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.TakeupAmount4).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.TakeupAmount5).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.TransactionStatusType).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.Usage).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingBulkPaymentDetails)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_BulkPaymentDetail_DomesticClearing_Payment");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingBulkPaymentDetails)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_BulkPaymentDetail_DomesticClearing_PaymentLine");
            });

            modelBuilder.Entity<DomesticClearingBulkPaymentSummary>(entity =>
            {
                entity.HasKey(e => e.BulkPaymentSummaryId);

                entity.ToTable("DomesticClearing_BulkPaymentSummary");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ApproveDate1).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate2).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate3).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate4).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate5).HasColumnType("datetime");

                entity.Property(e => e.Approver1).HasMaxLength(50);

                entity.Property(e => e.Approver2).HasMaxLength(50);

                entity.Property(e => e.Approver3).HasMaxLength(50);

                entity.Property(e => e.Approver4).HasMaxLength(50);

                entity.Property(e => e.Approver5).HasMaxLength(50);

                entity.Property(e => e.BulkTransactionFormatDefinitionName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomerUnitCode).HasMaxLength(50);

                entity.Property(e => e.DateFormat).HasMaxLength(50);

                entity.Property(e => e.DebitAccountNumber).HasMaxLength(50);

                entity.Property(e => e.DecimalPointSymbol).HasMaxLength(50);

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceAuthority).HasMaxLength(50);

                entity.Property(e => e.RejectionFlag).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(1024);

                entity.Property(e => e.TransactionStatusType).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DomesticClearingDeposit>(entity =>
            {
                entity.HasKey(e => e.DepositId);

                entity.ToTable("DomesticClearing_Deposit");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.CashValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ChequesValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepositValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.DomicileBsb)
                    .HasMaxLength(50)
                    .HasColumnName("DomicileBSB");

                entity.Property(e => e.Filename).HasMaxLength(1024);

                entity.Property(e => e.OriginalBsb)
                    .HasMaxLength(50)
                    .HasColumnName("OriginalBSB");

                entity.Property(e => e.TransmissionDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingDeposits)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_Deposit_DomesticClearing_Payment");
            });

            modelBuilder.Entity<DomesticClearingDirectEntry>(entity =>
            {
                entity.HasKey(e => e.DirectEntryId);

                entity.ToTable("DomesticClearing_DirectEntry");

                entity.Property(e => e.AccountNumberToBeCreditedDebited).HasMaxLength(9);

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Bsbnumber)
                    .HasMaxLength(7)
                    .HasColumnName("BSBNumber");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateToBeProcessed).HasColumnType("datetime");

                entity.Property(e => e.Filename).HasMaxLength(1024);

                entity.Property(e => e.Indicator).HasMaxLength(1);

                entity.Property(e => e.LodgementReference).HasMaxLength(18);

                entity.Property(e => e.NumberOfUserSupplyingFile).HasMaxLength(6);

                entity.Property(e => e.RemitterName).HasMaxLength(16);

                entity.Property(e => e.TitleOfAccountCreditedDebited).HasMaxLength(32);

                entity.Property(e => e.TraceRecordAccountNumber).HasMaxLength(9);

                entity.Property(e => e.TraceRecordBsb)
                    .HasMaxLength(7)
                    .HasColumnName("TraceRecordBSB");

                entity.Property(e => e.TrasactionCode).HasMaxLength(2);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.WithHoldingTaxAmount).HasColumnType("decimal(22, 8)");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingDirectEntries)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_DirectEntry_DomesticClearing_Payment");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingDirectEntries)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_DirectEntry_DomesticClearing_PaymentLine");
            });

            modelBuilder.Entity<DomesticClearingDirection>(entity =>
            {
                entity.HasKey(e => e.DirectionId);

                entity.ToTable("DomesticClearing_Direction");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingFee>(entity =>
            {
                entity.HasKey(e => e.FeeId)
                    .IsClustered(false);

                entity.ToTable("DomesticClearing_Fee");

                entity.HasIndex(e => new { e.Account, e.StatusId, e.EffectiveDate }, "IX_DomesticClearing_Fee_AccountStatusIdEffectiveDate")
                    .IsClustered();

                entity.HasIndex(e => e.FeeId, "PK_DomesticClearing_Fee_FeeId");

                entity.HasIndex(e => new { e.Account, e.EffectiveDate, e.PaymentMethodId }, "UQ_DomesticClearing_Fee_AccountEffectiveDatePaymentMethod")
                    .IsUnique();

                entity.Property(e => e.Account).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.DishonourAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.DomesticClearingFees)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Fee_DomesticClearing_PaymentMethod");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingFees)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_Fee_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingFeeLog>(entity =>
            {
                entity.HasKey(e => e.FeeLogId);

                entity.ToTable("DomesticClearing_FeeLog");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Fee)
                    .WithMany(p => p.DomesticClearingFeeLogs)
                    .HasForeignKey(d => d.FeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_FeeLog_DomesticClearing_Fee");
            });

            modelBuilder.Entity<DomesticClearingGasStatu>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("DomesticClearing_GasStatus");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingGde>(entity =>
            {
                entity.HasKey(e => e.Gdesid);

                entity.ToTable("DomesticClearing_GDES");

                entity.Property(e => e.Gdesid).HasColumnName("GDESId");

                entity.Property(e => e.AccountNumberToBeCreditedDebited).HasMaxLength(9);

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Bsbnumber)
                    .HasMaxLength(7)
                    .HasColumnName("BSBNumber");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateToBeProcessed).HasColumnType("datetime");

                entity.Property(e => e.Filename).HasMaxLength(1024);

                entity.Property(e => e.Indicator).HasMaxLength(1);

                entity.Property(e => e.LodgementReference).HasMaxLength(18);

                entity.Property(e => e.NumberOfUserSupplyingFile).HasMaxLength(6);

                entity.Property(e => e.RemitterName).HasMaxLength(16);

                entity.Property(e => e.TitleOfAccountCreditedDebited).HasMaxLength(32);

                entity.Property(e => e.TraceRecordAccountNumber).HasMaxLength(9);

                entity.Property(e => e.TraceRecordBsb)
                    .HasMaxLength(7)
                    .HasColumnName("TraceRecordBSB");

                entity.Property(e => e.TrasactionCode).HasMaxLength(2);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.WithHoldingTaxAmount).HasColumnType("decimal(22, 8)");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingGdes)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_GDES_DomesticClearing_Payment");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingGdes)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_GDES_DomesticClearing_PaymentLine");
            });

            modelBuilder.Entity<DomesticClearingGoposting>(entity =>
            {
                entity.HasKey(e => e.GopostingId)
                    .HasName("PK_DomesticClearing_GOPosting_1");

                entity.ToTable("DomesticClearing_GOPosting");

                entity.Property(e => e.GopostingId).HasColumnName("GOPostingId");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.AvailableDate).HasColumnType("datetime");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAccountCode).HasMaxLength(20);

                entity.Property(e => e.CreditAccountNo).HasMaxLength(20);

                entity.Property(e => e.CreditCustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.CreditMinNo).HasMaxLength(18);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAccountCode).HasMaxLength(20);

                entity.Property(e => e.DebitAccountNo).HasMaxLength(20);

                entity.Property(e => e.DebitCustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.DebitMinNo).HasMaxLength(18);

                entity.Property(e => e.FileType).HasMaxLength(2);

                entity.Property(e => e.GasDescription).HasMaxLength(1024);

                entity.Property(e => e.GbaseRefNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("GBaseRefNo");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.TransNo).HasMaxLength(5);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.DebitMinNoNavigation)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.DebitMinNo)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_GAS_GO_DEBIT");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_DomesticClearing_Direction");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_DomesticClearing_PaymentLine");

                entity.HasOne(d => d.PostingType)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.PostingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_DomesticClearing_PostingType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_DomesticClearing_GasStatus");
            });

            modelBuilder.Entity<DomesticClearingMultiPurposeInstructionAttachment>(entity =>
            {
                entity.HasKey(e => e.MultiPurposeInstructionAttachmentId);

                entity.ToTable("DomesticClearing_MultiPurposeInstructionAttachment");

                entity.Property(e => e.Account).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.BeneficiaryName).HasMaxLength(255);

                entity.Property(e => e.Bsb)
                    .HasMaxLength(255)
                    .HasColumnName("BSB");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerCurrentAccount).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Reference).HasMaxLength(255);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.MultiPurposeInstructionDetail)
                    .WithMany(p => p.DomesticClearingMultiPurposeInstructionAttachments)
                    .HasForeignKey(d => d.MultiPurposeInstructionDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_MultiPurposeInstructionAttachment_DomesticClearing_MultiPurposeInstructionDetail");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingMultiPurposeInstructionAttachments)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_MultiPurposeInstructionAttachment_DomesticClearing_PaymentLine");
            });

            modelBuilder.Entity<DomesticClearingMultiPurposeInstructionDetail>(entity =>
            {
                entity.HasKey(e => e.MultiPurposeInstructionDetailId);

                entity.ToTable("DomesticClearing_MultiPurposeInstructionDetail");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Attachment).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomerUnitCode).HasMaxLength(50);

                entity.Property(e => e.CustomerUnitName).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RejectedReason).HasMaxLength(1024);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TransactionMethod).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingMultiPurposeInstructionDetails)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_MultiPurposeInstructionDetail_DomesticClearing_Payment");
            });

            modelBuilder.Entity<DomesticClearingNotification>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .IsClustered(false);

                entity.ToTable("DomesticClearing_Notification");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(12);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("DomesticClearing_Payment");

                entity.HasIndex(e => e.FeePostId, "UQ_DomesticClearing_Payment_FeePostId")
                    .IsUnique()
                    .HasFilter("([FeePostId] IS NOT NULL)");

                entity.HasIndex(e => e.MainPostId, "UQ_DomesticClearing_Payment_MainPostId")
                    .IsUnique()
                    .HasFilter("([MainPostId] IS NOT NULL)");

                entity.Property(e => e.AccountName).HasMaxLength(50);

                entity.Property(e => e.AvailableDate).HasColumnType("datetime");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((751))");

                entity.Property(e => e.Bsb)
                    .HasMaxLength(255)
                    .HasColumnName("BSB");

                entity.Property(e => e.CashValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ChequeFrontImageName).HasMaxLength(1024);

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.ChequeReverseImageName).HasMaxLength(1024);

                entity.Property(e => e.ChequesValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ClearerExtractFileName).HasMaxLength(100);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.CustomerCurrentAccount).HasMaxLength(255);

                entity.Property(e => e.DereplyFilename)
                    .HasMaxLength(1024)
                    .HasColumnName("DEReplyFilename");

                entity.Property(e => e.Fees).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.IsClearerExtracted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFeeGoposted).HasColumnName("IsFeeGOPosted");

                entity.Property(e => e.IsPaymentGoposted).HasColumnName("IsPaymentGOPosted");

                entity.Property(e => e.LowPriorityWhen).HasColumnType("datetime");

                entity.Property(e => e.OriginalAccountName).HasMaxLength(255);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(30);

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.UnitCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.DomesticClearingPayments)
                    .HasForeignKey(d => d.DirectionId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_Direction");

                entity.HasOne(d => d.FeePost)
                    .WithOne(p => p.DomesticClearingPaymentFeePost)
                    .HasForeignKey<DomesticClearingPayment>(d => d.FeePostId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_FeePosting");

                entity.HasOne(d => d.MainPost)
                    .WithOne(p => p.DomesticClearingPaymentMainPost)
                    .HasForeignKey<DomesticClearingPayment>(d => d.MainPostId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_GOPosting");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.DomesticClearingPayments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_PaymentMethod");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DomesticClearingPayments)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_Product");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingPayments)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingPaymentLine>(entity =>
            {
                entity.HasKey(e => e.PaymentLineId);

                entity.ToTable("DomesticClearing_PaymentLine");

                entity.Property(e => e.Account).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.BeneficiaryName).HasMaxLength(255);

                entity.Property(e => e.Bsb)
                    .HasMaxLength(255)
                    .HasColumnName("BSB");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reference).HasMaxLength(255);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnFee).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingPaymentLines)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_Payment");

                entity.HasOne(d => d.ReturnFeePost)
                    .WithMany(p => p.DomesticClearingPaymentLineReturnFeePosts)
                    .HasForeignKey(d => d.ReturnFeePostId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_GOPosting1");

                entity.HasOne(d => d.ReturnPost)
                    .WithMany(p => p.DomesticClearingPaymentLineReturnPosts)
                    .HasForeignKey(d => d.ReturnPostId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_GOPosting");

                entity.HasOne(d => d.ReturnRefusalCode)
                    .WithMany(p => p.DomesticClearingPaymentLines)
                    .HasForeignKey(d => d.ReturnRefusalCodeId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_ReturnCode");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingPaymentLines)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingPaymentLineValidationError>(entity =>
            {
                entity.HasKey(e => e.PaymentLineValidationErrorId);

                entity.ToTable("DomesticClearing_PaymentLineValidationError");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingPaymentLineValidationErrors)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLineValidationError_DomesticClearing_PaymentLine");

                entity.HasOne(d => d.ValidationError)
                    .WithMany(p => p.DomesticClearingPaymentLineValidationErrors)
                    .HasForeignKey(d => d.ValidationErrorId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLineValidationError_DomesticClearing_ValidationError");
            });

            modelBuilder.Entity<DomesticClearingPaymentLog>(entity =>
            {
                entity.HasKey(e => e.PaymentLogId);

                entity.ToTable("DomesticClearing_PaymentLog");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingPaymentLogs)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_PaymentLog_DomesticClearing_Payment");
            });

            modelBuilder.Entity<DomesticClearingPaymentMethod>(entity =>
            {
                entity.HasKey(e => e.PaymentMethodId);

                entity.ToTable("DomesticClearing_PaymentMethod");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.GasfileType)
                    .HasMaxLength(50)
                    .HasColumnName("GASFileType");

                entity.Property(e => e.GbaseRefPrefix)
                    .HasMaxLength(50)
                    .HasColumnName("GBaseRefPrefix");

                entity.Property(e => e.Remarks).HasMaxLength(30);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.DomesticClearingPaymentMethods)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_PaymentMethod_DomesticClearing_Direction");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.DomesticClearingPaymentMethods)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_PaymentMethod_DomesticClearing_Source");
            });

            modelBuilder.Entity<DomesticClearingPaymentMethodValidation>(entity =>
            {
                entity.HasKey(e => e.PaymentMethodValidationId);

                entity.ToTable("DomesticClearing_PaymentMethodValidation");

                entity.Property(e => e.CreatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingPaymentValidationError>(entity =>
            {
                entity.HasKey(e => e.PaymentValidationErrorId);

                entity.ToTable("DomesticClearing_PaymentValidationError");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingPaymentValidationErrors)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_PaymentValidationError_DomesticClearing_Payment");

                entity.HasOne(d => d.ValidationError)
                    .WithMany(p => p.DomesticClearingPaymentValidationErrors)
                    .HasForeignKey(d => d.ValidationErrorId)
                    .HasConstraintName("FK_DomesticClearing_PaymentValidationError_DomesticClearing_ValidationError");
            });

            modelBuilder.Entity<DomesticClearingPostingType>(entity =>
            {
                entity.HasKey(e => e.PostingTypeId);

                entity.ToTable("DomesticClearing_PostingType");

                entity.Property(e => e.CreatedWhen).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingPresentment>(entity =>
            {
                entity.HasKey(e => e.PresentmentId);

                entity.ToTable("DomesticClearing_Presentment");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.AuxillaryDomestic).HasMaxLength(50);

                entity.Property(e => e.BsbDepositorsNominatedFi).HasMaxLength(50);

                entity.Property(e => e.BsbcapturingFi)
                    .HasMaxLength(50)
                    .HasColumnName("BSBCapturingFI");

                entity.Property(e => e.BsbcollectingFi)
                    .HasMaxLength(50)
                    .HasColumnName("BSBCollectingFI");

                entity.Property(e => e.BsbledgerFi)
                    .HasMaxLength(50)
                    .HasColumnName("BSBLedgerFI");

                entity.Property(e => e.BsbreceivingFi)
                    .HasMaxLength(50)
                    .HasColumnName("BSBReceivingFI");

                entity.Property(e => e.BsbsendingFi)
                    .HasMaxLength(50)
                    .HasColumnName("BSBSendingFI");

                entity.Property(e => e.CaptureDeviceIdentifier).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepositorNominatedAccountNumber).HasMaxLength(50);

                entity.Property(e => e.DrawerAccountNo).HasMaxLength(50);

                entity.Property(e => e.ExtraAuxiliaryDomestic).HasMaxLength(50);

                entity.Property(e => e.Filename).HasMaxLength(1024);

                entity.Property(e => e.ManualRepair).HasMaxLength(50);

                entity.Property(e => e.TransactionCode).HasMaxLength(3);

                entity.Property(e => e.TransactionIdentifier).HasMaxLength(50);

                entity.Property(e => e.TransmissionDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.VoucherIndicator).HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingPresentments)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_Presentment_DomesticClearing_Payment");
            });

            modelBuilder.Entity<DomesticClearingProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("DomesticClearing_Product");

                entity.HasIndex(e => e.Type, "UQ_DomesticClearing_Product_Description")
                    .IsUnique();

                entity.HasIndex(e => e.Type, "UQ_DomesticClearing_Product_Type")
                    .IsUnique();

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingProducts)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_Product_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingProductLog>(entity =>
            {
                entity.HasKey(e => e.ProductLogId);

                entity.ToTable("DomesticClearing_ProductLog");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DomesticClearingProductLogs)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_ProductLog_DomesticClearing_Product");
            });

            modelBuilder.Entity<DomesticClearingRecBatch>(entity =>
            {
                entity.HasKey(e => e.RecBatchId);

                entity.ToTable("DomesticClearing_Rec_Batch");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationDateFrom).HasColumnType("datetime");

                entity.Property(e => e.CreationDateTo).HasColumnType("datetime");

                entity.Property(e => e.OperationDateFrom).HasColumnType("datetime");

                entity.Property(e => e.OperationDateTo).HasColumnType("datetime");

                entity.Property(e => e.ProcessingDateFrom).HasColumnType("datetime");

                entity.Property(e => e.ProcessingDateTo).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDateFrom).HasColumnType("datetime");

                entity.Property(e => e.ValueDateTo).HasColumnType("datetime");

                entity.HasOne(d => d.RecType)
                    .WithMany(p => p.DomesticClearingRecBatches)
                    .HasForeignKey(d => d.RecTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Batch_DomesticClearing_Rec_Type");
            });

            modelBuilder.Entity<DomesticClearingRecCollateGo>(entity =>
            {
                entity.HasKey(e => e.RecCollateGoid);

                entity.ToTable("DomesticClearing_Rec_Collate_GO");

                entity.Property(e => e.RecCollateGoid).HasColumnName("RecCollateGOId");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAccountCode).HasMaxLength(20);

                entity.Property(e => e.CreditAccountNumber).HasMaxLength(20);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.CreditCurrency).HasMaxLength(4);

                entity.Property(e => e.CreditCustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.DebitAccountCode).HasMaxLength(20);

                entity.Property(e => e.DebitAccountNumber).HasMaxLength(20);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.DebitCurrency).HasMaxLength(4);

                entity.Property(e => e.DebitCustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(30);

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecCollateGoes)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_GO_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollateGoes)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_GO_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollateInwardClearing>(entity =>
            {
                entity.HasKey(e => e.RecCollateInwardClearingId);

                entity.ToTable("DomesticClearing_Rec_Collate_InwardClearing");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecCollateInwardClearings)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_InwardClearing_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollateInwardClearings)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_InwardClearing_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollatePayment>(entity =>
            {
                entity.HasKey(e => e.RecCollatePaymentId);

                entity.ToTable("DomesticClearing_Rec_Collate_Payment");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecCollatePayments)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_Payment_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollatePayments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_Payment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollatePaymentCreation>(entity =>
            {
                entity.HasKey(e => e.RecCollatePaymentCreationId);

                entity.ToTable("DomesticClearing_Rec_Collate_PaymentCreation");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.CustomerCurrentAccount).HasMaxLength(255);

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecCollatePaymentCreations)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_PaymentCreation_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollatePaymentCreations)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_PaymentCreation_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoEuconDemandLogAccount>(entity =>
            {
                entity.HasKey(e => e.RecCollectGoeuconDemandLogAccountId);

                entity.ToTable("DomesticClearing_Rec_Collect_GO_EUCOnDemandLogAccount");

                entity.Property(e => e.RecCollectGoeuconDemandLogAccountId).HasColumnName("RecCollectGOEUCOnDemandLogAccountId");

                entity.Property(e => e.ActAbbr)
                    .HasMaxLength(15)
                    .HasColumnName("ACT_ABBR");

                entity.Property(e => e.ActCd)
                    .HasMaxLength(5)
                    .HasColumnName("ACT_CD");

                entity.Property(e => e.ActId)
                    .HasMaxLength(1)
                    .HasColumnName("ACT_ID");

                entity.Property(e => e.ActType)
                    .HasMaxLength(1)
                    .HasColumnName("ACT_TYPE");

                entity.Property(e => e.AmountBc)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("AMOUNT_BC");

                entity.Property(e => e.AmountFc)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("AMOUNT_FC");

                entity.Property(e => e.ApproveEmpCd)
                    .HasMaxLength(4)
                    .HasColumnName("APPROVE_EMP_CD");

                entity.Property(e => e.ApproveOpeId)
                    .HasMaxLength(3)
                    .HasColumnName("APPROVE_OPE_ID");

                entity.Property(e => e.AvailabilityFlg)
                    .HasMaxLength(1)
                    .HasColumnName("AVAILABILITY_FLG");

                entity.Property(e => e.AvailableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AVAILABLE_DATE");

                entity.Property(e => e.BatchNumber).HasColumnName("BATCH_NUMBER");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyAbbr)
                    .HasMaxLength(4)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.CcyCode)
                    .HasMaxLength(2)
                    .HasColumnName("CCY_CODE");

                entity.Property(e => e.CheckNo)
                    .HasMaxLength(10)
                    .HasColumnName("CHECK_NO");

                entity.Property(e => e.ConversionRate)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("CONVERSION_RATE");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrtDate)
                    .HasMaxLength(19)
                    .HasColumnName("CRT_DATE");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.CustLiabAccount)
                    .HasMaxLength(5)
                    .HasColumnName("CUST_LIAB_ACCOUNT");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.DdNo)
                    .HasMaxLength(3)
                    .HasColumnName("DD_NO");

                entity.Property(e => e.DepartmentCd)
                    .HasMaxLength(2)
                    .HasColumnName("DEPARTMENT_CD");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(1)
                    .HasColumnName("DR_CR");

                entity.Property(e => e.EquivCcyAmount)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_AMOUNT");

                entity.Property(e => e.EquivCcyCd)
                    .HasMaxLength(2)
                    .HasColumnName("EQUIV_CCY_CD");

                entity.Property(e => e.EquivRate)
                    .HasColumnType("decimal(13, 8)")
                    .HasColumnName("EQUIV_RATE");

                entity.Property(e => e.IbfId)
                    .HasMaxLength(1)
                    .HasColumnName("IBF_ID");

                entity.Property(e => e.IbfId2)
                    .HasMaxLength(1)
                    .HasColumnName("IBF_ID_2");

                entity.Property(e => e.InputEmpCd)
                    .HasMaxLength(4)
                    .HasColumnName("INPUT_EMP_CD");

                entity.Property(e => e.InputOpeId)
                    .HasMaxLength(3)
                    .HasColumnName("INPUT_OPE_ID");

                entity.Property(e => e.IntPayerCountry)
                    .HasMaxLength(2)
                    .HasColumnName("INT_PAYER_COUNTRY");

                entity.Property(e => e.IrregularTransFlg)
                    .HasMaxLength(2)
                    .HasColumnName("IRREGULAR_TRANS_FLG");

                entity.Property(e => e.LastTransNo)
                    .HasMaxLength(5)
                    .HasColumnName("LAST_TRANS_NO");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_UPDATE");

                entity.Property(e => e.NoUpdateFlg)
                    .HasMaxLength(1)
                    .HasColumnName("NO_UPDATE_FLG");

                entity.Property(e => e.OdFlg)
                    .HasMaxLength(1)
                    .HasColumnName("OD_FLG");

                entity.Property(e => e.OnlineCd)
                    .HasMaxLength(4)
                    .HasColumnName("ONLINE_CD");

                entity.Property(e => e.OpeKind)
                    .HasMaxLength(1)
                    .HasColumnName("OPE_KIND");

                entity.Property(e => e.PaFlg)
                    .HasMaxLength(1)
                    .HasColumnName("PA_FLG");

                entity.Property(e => e.ProgramNo)
                    .HasMaxLength(8)
                    .HasColumnName("PROGRAM_NO");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(12)
                    .HasColumnName("REF_NO");

                entity.Property(e => e.RefNo2)
                    .HasMaxLength(12)
                    .HasColumnName("REF_NO_2");

                entity.Property(e => e.RemarksFlg)
                    .HasMaxLength(1)
                    .HasColumnName("REMARKS_FLG");

                entity.Property(e => e.RoNo)
                    .HasMaxLength(3)
                    .HasColumnName("RO_NO");

                entity.Property(e => e.RoNo2)
                    .HasMaxLength(3)
                    .HasColumnName("RO_NO_2");

                entity.Property(e => e.SegmentType)
                    .HasMaxLength(2)
                    .HasColumnName("SEGMENT_TYPE");

                entity.Property(e => e.SeqNo)
                    .HasMaxLength(2)
                    .HasColumnName("SEQ_NO");

                entity.Property(e => e.TransCd)
                    .HasMaxLength(1)
                    .HasColumnName("TRANS_CD");

                entity.Property(e => e.TransNo)
                    .HasMaxLength(5)
                    .HasColumnName("TRANS_NO");

                entity.Property(e => e.UpdateFlg)
                    .HasMaxLength(1)
                    .HasColumnName("UPDATE_FLG");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDATE");

                entity.Property(e => e.ValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALUE_DATE");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoEuconDemandLogAccounts)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_EUCOnDemandLogAccount_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoEuconDemandLogCommon>(entity =>
            {
                entity.HasKey(e => e.RecCollectGoeuconDemandLogCommonId);

                entity.ToTable("DomesticClearing_Rec_Collect_GO_EUCOnDemandLogCommon");

                entity.Property(e => e.RecCollectGoeuconDemandLogCommonId).HasColumnName("RecCollectGOEUCOnDemandLogCommonId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.ApproveEmpCd)
                    .HasMaxLength(4)
                    .HasColumnName("APPROVE_EMP_CD");

                entity.Property(e => e.ApproveFlg)
                    .HasMaxLength(1)
                    .HasColumnName("APPROVE_FLG");

                entity.Property(e => e.ApproveOpeId)
                    .HasMaxLength(3)
                    .HasColumnName("APPROVE_OPE_ID");

                entity.Property(e => e.ApproveTime)
                    .HasMaxLength(6)
                    .HasColumnName("APPROVE_TIME");

                entity.Property(e => e.BatchNumber).HasColumnName("BATCH_NUMBER");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyAbbr)
                    .HasMaxLength(4)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.CcyCode)
                    .HasMaxLength(2)
                    .HasColumnName("CCY_CODE");

                entity.Property(e => e.ContractDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONTRACT_DATE");

                entity.Property(e => e.CorrectFlg)
                    .HasMaxLength(2)
                    .HasColumnName("CORRECT_FLG");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrtDate)
                    .HasMaxLength(19)
                    .HasColumnName("CRT_DATE");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.Days)
                    .HasMaxLength(4)
                    .HasColumnName("DAYS");

                entity.Property(e => e.DdNo)
                    .HasMaxLength(3)
                    .HasColumnName("DD_NO");

                entity.Property(e => e.DdValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DD_VALUE_DATE");

                entity.Property(e => e.DeleteFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DELETE_FLG");

                entity.Property(e => e.DeleteTime)
                    .HasMaxLength(6)
                    .HasColumnName("DELETE_TIME");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELIVERY_DATE");

                entity.Property(e => e.DepartmentCd)
                    .HasMaxLength(2)
                    .HasColumnName("DEPARTMENT_CD");

                entity.Property(e => e.DiscountFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DISCOUNT_FLG");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.FinalDueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FINAL_DUE_DATE");

                entity.Property(e => e.IbfId)
                    .HasMaxLength(1)
                    .HasColumnName("IBF_ID");

                entity.Property(e => e.InputEmpCd)
                    .HasMaxLength(4)
                    .HasColumnName("INPUT_EMP_CD");

                entity.Property(e => e.InputOpeId)
                    .HasMaxLength(3)
                    .HasColumnName("INPUT_OPE_ID");

                entity.Property(e => e.IntAmount)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("INT_AMOUNT");

                entity.Property(e => e.IntPayerFlg)
                    .HasMaxLength(1)
                    .HasColumnName("INT_PAYER_FLG");

                entity.Property(e => e.IntRate)
                    .HasColumnType("decimal(9, 6)")
                    .HasColumnName("INT_RATE");

                entity.Property(e => e.IrregularTransFlg)
                    .HasMaxLength(2)
                    .HasColumnName("IRREGULAR_TRANS_FLG");

                entity.Property(e => e.OnlineCd)
                    .HasMaxLength(4)
                    .HasColumnName("ONLINE_CD");

                entity.Property(e => e.OpeKind)
                    .HasMaxLength(1)
                    .HasColumnName("OPE_KIND");

                entity.Property(e => e.OrgTransNo)
                    .HasMaxLength(5)
                    .HasColumnName("ORG_TRANS_NO");

                entity.Property(e => e.OrgTransOnlineCd)
                    .HasMaxLength(4)
                    .HasColumnName("ORG_TRANS_ONLINE_CD");

                entity.Property(e => e.OrgTransOpeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ORG_TRANS_OPE_DATE");

                entity.Property(e => e.PrevAmount)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("PREV_AMOUNT");

                entity.Property(e => e.PrevCcyAbbr)
                    .HasMaxLength(4)
                    .HasColumnName("PREV_CCY_ABBR");

                entity.Property(e => e.PrevCcyCode)
                    .HasMaxLength(2)
                    .HasColumnName("PREV_CCY_CODE");

                entity.Property(e => e.PrevDays)
                    .HasMaxLength(4)
                    .HasColumnName("PREV_DAYS");

                entity.Property(e => e.PrevDueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PREV_DUE_DATE");

                entity.Property(e => e.PrevIntAmount)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("PREV_INT_AMOUNT");

                entity.Property(e => e.PrevIntRate)
                    .HasColumnType("decimal(9, 6)")
                    .HasColumnName("PREV_INT_RATE");

                entity.Property(e => e.PrevValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PREV_VALUE_DATE");

                entity.Property(e => e.RecoveryFlg)
                    .HasMaxLength(1)
                    .HasColumnName("RECOVERY_FLG");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(12)
                    .HasColumnName("REF_NO");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(30)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.RoNo)
                    .HasMaxLength(3)
                    .HasColumnName("RO_NO");

                entity.Property(e => e.SeqNo)
                    .HasMaxLength(2)
                    .HasColumnName("SEQ_NO");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(4)
                    .HasColumnName("TERMINAL_ID");

                entity.Property(e => e.TransNo)
                    .HasMaxLength(5)
                    .HasColumnName("TRANS_NO");

                entity.Property(e => e.TransTime)
                    .HasMaxLength(6)
                    .HasColumnName("TRANS_TIME");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDATE");

                entity.Property(e => e.ValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALUE_DATE");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoEuconDemandLogCommons)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_EUCOnDemandLogCommon_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoGasGoCredit>(entity =>
            {
                entity.HasKey(e => e.RecCollectGogasGoCreditId);

                entity.ToTable("DomesticClearing_Rec_Collect_GO_GasGoCredit");

                entity.Property(e => e.RecCollectGogasGoCreditId).HasColumnName("RecCollectGOGasGoCreditId");

                entity.Property(e => e.AccCdTx)
                    .HasMaxLength(5)
                    .HasColumnName("ACC_CD_TX");

                entity.Property(e => e.AccnumTx)
                    .HasMaxLength(12)
                    .HasColumnName("ACCNUM_TX");

                entity.Property(e => e.AdviseprintTx)
                    .HasMaxLength(1)
                    .HasColumnName("ADVISEPRINT_TX");

                entity.Property(e => e.AmountAmt)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNT_AMT");

                entity.Property(e => e.AvailableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AVAILABLE_DATE");

                entity.Property(e => e.CcyTx)
                    .HasMaxLength(4)
                    .HasColumnName("CCY_TX");

                entity.Property(e => e.ChecknoTx)
                    .HasMaxLength(10)
                    .HasColumnName("CHECKNO_TX");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustidTx)
                    .HasMaxLength(12)
                    .HasColumnName("CUSTID_TX");

                entity.Property(e => e.DetailsTx)
                    .HasMaxLength(30)
                    .HasColumnName("DETAILS_TX");

                entity.Property(e => e.DivisionTx)
                    .HasMaxLength(2)
                    .HasColumnName("DIVISION_TX");

                entity.Property(e => e.EntityTx)
                    .HasMaxLength(3)
                    .HasColumnName("ENTITY_TX");

                entity.Property(e => e.ExchrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("EXCHRATE_INT");

                entity.Property(e => e.FundTx)
                    .HasMaxLength(1)
                    .HasColumnName("FUND_TX");

                entity.Property(e => e.FxccyTx)
                    .HasMaxLength(4)
                    .HasColumnName("FXCCY_TX");

                entity.Property(e => e.GroupnoTx)
                    .HasMaxLength(2)
                    .HasColumnName("GROUPNO_TX");

                entity.Property(e => e.IbfTx)
                    .HasMaxLength(1)
                    .HasColumnName("IBF_TX");

                entity.Property(e => e.InterrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("INTERRATE_INT");

                entity.Property(e => e.MinNo)
                    .HasMaxLength(18)
                    .HasColumnName("MIN_NO");

                entity.Property(e => e.TypeTx)
                    .HasMaxLength(1)
                    .HasColumnName("TYPE_TX");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoGasGoCredits)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_GasGoCredit_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoGasGoDebit>(entity =>
            {
                entity.HasKey(e => e.RecCollectGogasGoDebitId);

                entity.ToTable("DomesticClearing_Rec_Collect_GO_GasGoDebit");

                entity.Property(e => e.RecCollectGogasGoDebitId).HasColumnName("RecCollectGOGasGoDebitId");

                entity.Property(e => e.AccCdTx)
                    .HasMaxLength(5)
                    .HasColumnName("ACC_CD_TX");

                entity.Property(e => e.AccnumTx)
                    .HasMaxLength(12)
                    .HasColumnName("ACCNUM_TX");

                entity.Property(e => e.AcubuTx)
                    .HasMaxLength(3)
                    .HasColumnName("ACUBU_TX");

                entity.Property(e => e.AdviseprintTx)
                    .HasMaxLength(1)
                    .HasColumnName("ADVISEPRINT_TX");

                entity.Property(e => e.AmountAmt)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNT_AMT");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(8)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.AvailableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AVAILABLE_DATE");

                entity.Property(e => e.BackvalueInd)
                    .HasMaxLength(1)
                    .HasColumnName("BACKVALUE_IND");

                entity.Property(e => e.BulkUploadInd)
                    .HasMaxLength(1)
                    .HasColumnName("BULK_UPLOAD_IND");

                entity.Property(e => e.CcyTx)
                    .HasMaxLength(4)
                    .HasColumnName("CCY_TX");

                entity.Property(e => e.ChecknoTx)
                    .HasMaxLength(10)
                    .HasColumnName("CHECKNO_TX");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(8)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustidTx)
                    .HasMaxLength(12)
                    .HasColumnName("CUSTID_TX");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(8)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_DATE");

                entity.Property(e => e.DeletionInd)
                    .HasMaxLength(1)
                    .HasColumnName("DELETION_IND");

                entity.Property(e => e.DescriptionTx)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION_TX");

                entity.Property(e => e.DetailsTx)
                    .HasMaxLength(30)
                    .HasColumnName("DETAILS_TX");

                entity.Property(e => e.DivisionTx)
                    .HasMaxLength(2)
                    .HasColumnName("DIVISION_TX");

                entity.Property(e => e.DreamsRefCode)
                    .HasMaxLength(12)
                    .HasColumnName("DREAMS_REF_CODE");

                entity.Property(e => e.EntityTx)
                    .HasMaxLength(3)
                    .HasColumnName("ENTITY_TX");

                entity.Property(e => e.ExchrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("EXCHRATE_INT");

                entity.Property(e => e.ExportedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPORTED_DT");

                entity.Property(e => e.FundTx)
                    .HasMaxLength(1)
                    .HasColumnName("FUND_TX");

                entity.Property(e => e.FxccyTx)
                    .HasMaxLength(4)
                    .HasColumnName("FXCCY_TX");

                entity.Property(e => e.GroupnoTx)
                    .HasMaxLength(2)
                    .HasColumnName("GROUPNO_TX");

                entity.Property(e => e.IbfTx)
                    .HasMaxLength(1)
                    .HasColumnName("IBF_TX");

                entity.Property(e => e.InterrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("INTERRATE_INT");

                entity.Property(e => e.LastEditedBy)
                    .HasMaxLength(8)
                    .HasColumnName("LAST_EDITED_BY");

                entity.Property(e => e.LastEditedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_EDITED_DATE");

                entity.Property(e => e.MinNo)
                    .HasMaxLength(18)
                    .HasColumnName("MIN_NO");

                entity.Property(e => e.PushFlag)
                    .HasMaxLength(1)
                    .HasColumnName("PUSH_FLAG");

                entity.Property(e => e.PushTxnFlag)
                    .HasMaxLength(1)
                    .HasColumnName("PUSH_TXN_FLAG");

                entity.Property(e => e.ReasonTx)
                    .HasMaxLength(30)
                    .HasColumnName("REASON_TX");

                entity.Property(e => e.RemarksTx)
                    .HasMaxLength(30)
                    .HasColumnName("REMARKS_TX");

                entity.Property(e => e.ReversedBy)
                    .HasMaxLength(8)
                    .HasColumnName("REVERSED_BY");

                entity.Property(e => e.ReversedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REVERSED_DATE");

                entity.Property(e => e.SeqNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SEQ_NO");

                entity.Property(e => e.StatusInt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STATUS_INT");

                entity.Property(e => e.TranType)
                    .HasMaxLength(1)
                    .HasColumnName("TRAN_TYPE");

                entity.Property(e => e.TransnoTx)
                    .HasMaxLength(5)
                    .HasColumnName("TRANSNO_TX");

                entity.Property(e => e.TypeTx)
                    .HasMaxLength(2)
                    .HasColumnName("TYPE_TX");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(8)
                    .HasColumnName("UPLOADED_BY");

                entity.Property(e => e.UploadedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPLOADED_DATE");

                entity.Property(e => e.ValuedateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("VALUEDATE_DT");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoGasGoDebits)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_GasGoDebit_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoGoposting>(entity =>
            {
                entity.HasKey(e => e.RecCollectGogopostingId);

                entity.ToTable("DomesticClearing_Rec_Collect_GO_GOPosting");

                entity.Property(e => e.RecCollectGogopostingId).HasColumnName("RecCollectGOGOPostingId");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAccountCode).HasMaxLength(20);

                entity.Property(e => e.CreditAccountNo).HasMaxLength(20);

                entity.Property(e => e.CreditCustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.CreditMinNo).HasMaxLength(18);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAccountCode).HasMaxLength(20);

                entity.Property(e => e.DebitAccountNo).HasMaxLength(20);

                entity.Property(e => e.DebitCustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.DebitMinNo).HasMaxLength(18);

                entity.Property(e => e.GbaseRefNo)
                    .HasMaxLength(20)
                    .HasColumnName("GBaseRefNo");

                entity.Property(e => e.GopostingId).HasColumnName("GOPostingId");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(30);

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.TransNo).HasMaxLength(5);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoGopostings)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_GOPosting_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectInwardClearingAnzSummary>(entity =>
            {
                entity.HasKey(e => e.RecCollectInwardClearingAnzSummaryId);

                entity.ToTable("DomesticClearing_Rec_Collect_InwardClearing_AnzSummary");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.DebitValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Description).HasMaxLength(25);

                entity.Property(e => e.Direction).HasMaxLength(10);

                entity.Property(e => e.Filename).HasMaxLength(1024);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.TotalValueOfTransactions).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectInwardClearingAnzSummaries)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_InwardClearing_AnzSummary_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectInwardClearingPayment>(entity =>
            {
                entity.HasKey(e => e.RecCollectInwardClearingPaymentId);

                entity.ToTable("DomesticClearing_Rec_Collect_InwardClearing_Payment");

                entity.Property(e => e.AccountName).HasMaxLength(50);

                entity.Property(e => e.AvailableDate).HasColumnType("datetime");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bsb)
                    .HasMaxLength(255)
                    .HasColumnName("BSB");

                entity.Property(e => e.CashValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.ChequesValue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ClearerExtractFileName).HasMaxLength(100);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.CustomerCurrentAccount).HasMaxLength(255);

                entity.Property(e => e.Fees).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.IsFeeGoposted).HasColumnName("IsFeeGOPosted");

                entity.Property(e => e.IsPaymentGoposted).HasColumnName("IsPaymentGOPosted");

                entity.Property(e => e.OriginalAccountName).HasMaxLength(255);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(30);

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.UnitCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectInwardClearingPayments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_InwardClearing_Payment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentBulkPaymentSummary>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentBulkPaymentSummaryId);

                entity.ToTable("DomesticClearing_Rec_Collect_Payment_BulkPaymentSummary");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ApproveDate1).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate2).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate3).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate4).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate5).HasColumnType("datetime");

                entity.Property(e => e.Approver1).HasMaxLength(50);

                entity.Property(e => e.Approver2).HasMaxLength(50);

                entity.Property(e => e.Approver3).HasMaxLength(50);

                entity.Property(e => e.Approver4).HasMaxLength(50);

                entity.Property(e => e.Approver5).HasMaxLength(50);

                entity.Property(e => e.BulkPaymnetSummaryCreatedWhen).HasColumnType("datetime");

                entity.Property(e => e.BulkTransactionFormatDefinitionName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomerUnitCode).HasMaxLength(50);

                entity.Property(e => e.DateFormat).HasMaxLength(50);

                entity.Property(e => e.DebitAccountNumber).HasMaxLength(50);

                entity.Property(e => e.DecimalPointSymbol).HasMaxLength(50);

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceAuthority).HasMaxLength(50);

                entity.Property(e => e.RejectionFlag).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(1024);

                entity.Property(e => e.TransactionStatusType).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentBulkPaymentSummaries)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_BulkPaymentSummary_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentCreationBulkPaymentSummary>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentCreationBulkPaymentSummaryId);

                entity.ToTable("DomesticClearing_Rec_Collect_PaymentCreation_BulkPaymentSummary");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ApproveDate1).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate2).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate3).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate4).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate5).HasColumnType("datetime");

                entity.Property(e => e.Approver1).HasMaxLength(50);

                entity.Property(e => e.Approver2).HasMaxLength(50);

                entity.Property(e => e.Approver3).HasMaxLength(50);

                entity.Property(e => e.Approver4).HasMaxLength(50);

                entity.Property(e => e.Approver5).HasMaxLength(50);

                entity.Property(e => e.BulkPaymentSummaryCreatedWhen).HasColumnType("datetime");

                entity.Property(e => e.BulkTransactionFormatDefinitionName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomerUnitCode).HasMaxLength(50);

                entity.Property(e => e.DateFormat).HasMaxLength(50);

                entity.Property(e => e.DebitAccountNumber).HasMaxLength(50);

                entity.Property(e => e.DecimalPointSymbol).HasMaxLength(50);

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceAuthority).HasMaxLength(50);

                entity.Property(e => e.RejectionFlag).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(1024);

                entity.Property(e => e.TransactionStatusType).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentCreationBulkPaymentSummaries)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_PaymentCreation_BulkPaymentSummary_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachment>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentCreationMultiPurposeInstructionAttachment);

                entity.ToTable("DomesticClearing_Rec_Collect_PaymentCreation_MultiPurposeInstructionAttachment");

                entity.Property(e => e.Account).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.BeneficiaryName).HasMaxLength(255);

                entity.Property(e => e.Bsb)
                    .HasMaxLength(255)
                    .HasColumnName("BSB");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerCurrentAccount).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Reference).HasMaxLength(255);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_PaymentCreation_MultiPurposeInstructionAttachment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetail>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentCreationMultiPurposeInstructionDetailId);

                entity.ToTable("DomesticClearing_Rec_Collect_PaymentCreation_MultiPurposeInstructionDetail");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Attachment).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomerUnitCode).HasMaxLength(50);

                entity.Property(e => e.CustomerUnitName).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.MultipurposeInstructionDetailCreatedWhen).HasColumnType("datetime");

                entity.Property(e => e.RejectedReason).HasMaxLength(1024);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TransactionMethod).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetails)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_PaymentCreation_MultiPurposeInstructionDetail_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentCreationPayment>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentCreationPaymentId);

                entity.ToTable("DomesticClearing_Rec_Collect_PaymentCreation_Payment");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.CustomerCurrentAccount).HasMaxLength(255);

                entity.Property(e => e.Fees).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.PaymentCreatedWhen).HasColumnType("datetime");

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentCreationPayments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_PaymentCreation_Payment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentDereplyDetail>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentDereplyDetailId);

                entity.ToTable("DomesticClearing_Rec_Collect_Payment_DEReplyDetail");

                entity.Property(e => e.RecCollectPaymentDereplyDetailId).HasColumnName("RecCollectPaymentDEReplyDetailId");

                entity.Property(e => e.AccountNumberDebitCredit).HasMaxLength(9);

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Bsbnumber)
                    .HasMaxLength(7)
                    .HasColumnName("BSBNumber");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Indicator).HasMaxLength(1);

                entity.Property(e => e.LodgementReference).HasMaxLength(18);

                entity.Property(e => e.RecordType).HasMaxLength(1);

                entity.Property(e => e.RemitterName).HasMaxLength(16);

                entity.Property(e => e.SequenceNumber).HasMaxLength(6);

                entity.Property(e => e.StatusCode).HasMaxLength(4);

                entity.Property(e => e.StatusText).HasMaxLength(40);

                entity.Property(e => e.TitleOfAccountCreditedDebited).HasMaxLength(32);

                entity.Property(e => e.TraceAccountNumber).HasMaxLength(9);

                entity.Property(e => e.TraceBsbNumber).HasMaxLength(7);

                entity.Property(e => e.TransactionCode).HasMaxLength(2);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.WithholdingTaxAmount).HasColumnType("decimal(22, 8)");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentDereplyDetails)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_DEReplyDetail_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentDereplyHeader>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentDereplyHeaderId);

                entity.ToTable("DomesticClearing_Rec_Collect_Payment_DEReplyHeader");

                entity.Property(e => e.RecCollectPaymentDereplyHeaderId).HasColumnName("RecCollectPaymentDEReplyHeaderId");

                entity.Property(e => e.AccountNumberDebitCredit).HasMaxLength(9);

                entity.Property(e => e.Bsbnumber)
                    .HasMaxLength(7)
                    .HasColumnName("BSBNumber");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditTotalsOfFailedItems).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.CreditTotalsOfValidItems).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.CustomerReference).HasMaxLength(22);

                entity.Property(e => e.DateTimeProcessed).HasMaxLength(16);

                entity.Property(e => e.DateToBeProcessed).HasMaxLength(8);

                entity.Property(e => e.DebitTotalsOfFailedItems).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.DebitTotalsOfValidItems).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.EntriesDescription).HasMaxLength(12);

                entity.Property(e => e.FailReasonCode).HasMaxLength(4);

                entity.Property(e => e.FailReasonText).HasMaxLength(40);

                entity.Property(e => e.PaymentReferenceNumber).HasMaxLength(14);

                entity.Property(e => e.PendingAuthorisation).HasMaxLength(1);

                entity.Property(e => e.RecordType).HasMaxLength(1);

                entity.Property(e => e.ReportingMethod).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.UserIdNumber).HasMaxLength(16);

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentDereplyHeaders)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_DEReplyHeader_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachment>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentMultiPurposeInstructionAttachment);

                entity.ToTable("DomesticClearing_Rec_Collect_Payment_MultiPurposeInstructionAttachment");

                entity.Property(e => e.Account).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.BeneficiaryName).HasMaxLength(255);

                entity.Property(e => e.Bsb)
                    .HasMaxLength(255)
                    .HasColumnName("BSB");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerCurrentAccount).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Reference).HasMaxLength(255);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_MultiPurposeInstructionAttachment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentMultiPurposeInstructionDetail>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentMultiPurposeInstructionDetailId);

                entity.ToTable("DomesticClearing_Rec_Collect_Payment_MultiPurposeInstructionDetail");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Attachment).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomerUnitCode).HasMaxLength(50);

                entity.Property(e => e.CustomerUnitName).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RejectedReason).HasMaxLength(1024);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TransactionMethod).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentMultiPurposeInstructionDetails)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_MultiPurposeInstructionDetail_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentPayment>(entity =>
            {
                entity.HasKey(e => e.RecCollectPaymentPaymentId);

                entity.ToTable("DomesticClearing_Rec_Collect_Payment_Payment");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAbbreviation).HasMaxLength(12);

                entity.Property(e => e.CustomerCurrentAccount).HasMaxLength(255);

                entity.Property(e => e.Fees).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentPayments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_Payment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollection>(entity =>
            {
                entity.HasKey(e => e.RecCollectionId);

                entity.ToTable("DomesticClearing_Rec_Collection");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.RecSource)
                    .WithMany(p => p.DomesticClearingRecCollections)
                    .HasForeignKey(d => d.RecSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Batch_DomesticClearing_Rec_Source");
            });

            modelBuilder.Entity<DomesticClearingRecKeyStatu>(entity =>
            {
                entity.HasKey(e => e.RecKeyStatusId);

                entity.ToTable("DomesticClearing_Rec_KeyStatus");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingRecRecGo>(entity =>
            {
                entity.HasKey(e => e.RecRecGoid);

                entity.ToTable("DomesticClearing_Rec_Rec_GO");

                entity.Property(e => e.RecRecGoid).HasColumnName("RecRecGOId");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EucCreditAccountCode)
                    .HasMaxLength(20)
                    .HasColumnName("EUC_CreditAccountCode");

                entity.Property(e => e.EucCreditAccountNumber)
                    .HasMaxLength(20)
                    .HasColumnName("EUC_CreditAccountNumber");

                entity.Property(e => e.EucCreditAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("EUC_CreditAmount");

                entity.Property(e => e.EucCreditCurrency)
                    .HasMaxLength(4)
                    .HasColumnName("EUC_CreditCurrency");

                entity.Property(e => e.EucCreditCustomerAbbreviation)
                    .HasMaxLength(12)
                    .HasColumnName("EUC_CreditCustomerAbbreviation");

                entity.Property(e => e.EucDebitAccountCode)
                    .HasMaxLength(20)
                    .HasColumnName("EUC_DebitAccountCode");

                entity.Property(e => e.EucDebitAccountNumber)
                    .HasMaxLength(20)
                    .HasColumnName("EUC_DebitAccountNumber");

                entity.Property(e => e.EucDebitAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("EUC_DebitAmount");

                entity.Property(e => e.EucDebitCurrency)
                    .HasMaxLength(4)
                    .HasColumnName("EUC_DebitCurrency");

                entity.Property(e => e.EucDebitCustomerAbbreviation)
                    .HasMaxLength(12)
                    .HasColumnName("EUC_DebitCustomerAbbreviation");

                entity.Property(e => e.EucRecCollateGoid).HasColumnName("EUC_RecCollateGOId");

                entity.Property(e => e.EucRemark)
                    .HasMaxLength(30)
                    .HasColumnName("EUC_Remark");

                entity.Property(e => e.EucValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EUC_ValueDate");

                entity.Property(e => e.GasCreditAccountCode)
                    .HasMaxLength(20)
                    .HasColumnName("GAS_CreditAccountCode");

                entity.Property(e => e.GasCreditAccountNumber)
                    .HasMaxLength(20)
                    .HasColumnName("GAS_CreditAccountNumber");

                entity.Property(e => e.GasCreditAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("GAS_CreditAmount");

                entity.Property(e => e.GasCreditCurrency)
                    .HasMaxLength(4)
                    .HasColumnName("GAS_CreditCurrency");

                entity.Property(e => e.GasCreditCustomerAbbreviation)
                    .HasMaxLength(12)
                    .HasColumnName("GAS_CreditCustomerAbbreviation");

                entity.Property(e => e.GasDebitAccountCode)
                    .HasMaxLength(20)
                    .HasColumnName("GAS_DebitAccountCode");

                entity.Property(e => e.GasDebitAccountNumber)
                    .HasMaxLength(20)
                    .HasColumnName("GAS_DebitAccountNumber");

                entity.Property(e => e.GasDebitAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("GAS_DebitAmount");

                entity.Property(e => e.GasDebitCurrency)
                    .HasMaxLength(4)
                    .HasColumnName("GAS_DebitCurrency");

                entity.Property(e => e.GasDebitCustomerAbbreviation)
                    .HasMaxLength(12)
                    .HasColumnName("GAS_DebitCustomerAbbreviation");

                entity.Property(e => e.GasRecCollateGoid).HasColumnName("GAS_RecCollateGOId");

                entity.Property(e => e.GasRemark)
                    .HasMaxLength(30)
                    .HasColumnName("GAS_Remark");

                entity.Property(e => e.GasValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GAS_ValueDate");

                entity.Property(e => e.GoCreditAccountCode)
                    .HasMaxLength(20)
                    .HasColumnName("GO_CreditAccountCode");

                entity.Property(e => e.GoCreditAccountNumber)
                    .HasMaxLength(20)
                    .HasColumnName("GO_CreditAccountNumber");

                entity.Property(e => e.GoCreditAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("GO_CreditAmount");

                entity.Property(e => e.GoCreditCurrency)
                    .HasMaxLength(4)
                    .HasColumnName("GO_CreditCurrency");

                entity.Property(e => e.GoCreditCustomerAbbreviation)
                    .HasMaxLength(12)
                    .HasColumnName("GO_CreditCustomerAbbreviation");

                entity.Property(e => e.GoDebitAccountCode)
                    .HasMaxLength(20)
                    .HasColumnName("GO_DebitAccountCode");

                entity.Property(e => e.GoDebitAccountNumber)
                    .HasMaxLength(20)
                    .HasColumnName("GO_DebitAccountNumber");

                entity.Property(e => e.GoDebitAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("GO_DebitAmount");

                entity.Property(e => e.GoDebitCurrency)
                    .HasMaxLength(4)
                    .HasColumnName("GO_DebitCurrency");

                entity.Property(e => e.GoDebitCustomerAbbreviation)
                    .HasMaxLength(12)
                    .HasColumnName("GO_DebitCustomerAbbreviation");

                entity.Property(e => e.GoRecCollateGoid).HasColumnName("GO_RecCollateGOId");

                entity.Property(e => e.GoRemark)
                    .HasMaxLength(30)
                    .HasColumnName("GO_Remark");

                entity.Property(e => e.GoValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GO_ValueDate");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecRecGoes)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_GO_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecKeyStatus)
                    .WithMany(p => p.DomesticClearingRecRecGoes)
                    .HasForeignKey(d => d.RecKeyStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_GO_DomesticClearing_Rec_KeyStatus");

                entity.HasOne(d => d.RecValueStatus)
                    .WithMany(p => p.DomesticClearingRecRecGoes)
                    .HasForeignKey(d => d.RecValueStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_GO_DomesticClearing_Rec_ValueStatus");
            });

            modelBuilder.Entity<DomesticClearingRecRecInwardClearing>(entity =>
            {
                entity.HasKey(e => e.RecRecInwardClearingId);

                entity.ToTable("DomesticClearing_Rec_Rec_InwardClearing");

                entity.Property(e => e.ClrAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("CLR_Amount");

                entity.Property(e => e.ClrItems).HasColumnName("CLR_Items");

                entity.Property(e => e.ClrRecCollateInwardClearingId).HasColumnName("CLR_RecCollateInwardClearingId");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.PmtAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("PMT_Amount");

                entity.Property(e => e.PmtItems).HasColumnName("PMT_Items");

                entity.Property(e => e.PmtRecCollateInwardClearingId).HasColumnName("PMT_RecCollateInwardClearingId");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecRecInwardClearings)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_InwardClearing_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecKeyStatus)
                    .WithMany(p => p.DomesticClearingRecRecInwardClearings)
                    .HasForeignKey(d => d.RecKeyStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_InwardClearing_DomesticClearing_Rec_KeyStatus");

                entity.HasOne(d => d.RecValueStatus)
                    .WithMany(p => p.DomesticClearingRecRecInwardClearings)
                    .HasForeignKey(d => d.RecValueStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_InwardClearing_DomesticClearing_Rec_ValueStatus");
            });

            modelBuilder.Entity<DomesticClearingRecRecPayment>(entity =>
            {
                entity.HasKey(e => e.RecRecPaymentId);

                entity.ToTable("DomesticClearing_Rec_Rec_Payment");

                entity.Property(e => e.ClrAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("CLR_Amount");

                entity.Property(e => e.ClrNumberOfTrans).HasColumnName("CLR_NumberOfTrans");

                entity.Property(e => e.ClrRecCollatePaymentId).HasColumnName("CLR_RecCollatePaymentId");

                entity.Property(e => e.ClrValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CLR_ValueDate");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.GebAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("GEB_Amount");

                entity.Property(e => e.GebNumberOfTrans).HasColumnName("GEB_NumberOfTrans");

                entity.Property(e => e.GebRecCollatePaymentId).HasColumnName("GEB_RecCollatePaymentId");

                entity.Property(e => e.GebValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GEB_ValueDate");

                entity.Property(e => e.PmtAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("PMT_Amount");

                entity.Property(e => e.PmtNumberOfTrans).HasColumnName("PMT_NumberOfTrans");

                entity.Property(e => e.PmtRecCollatePaymentId).HasColumnName("PMT_RecCollatePaymentId");

                entity.Property(e => e.PmtValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PMT_ValueDate");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecRecPayments)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_Payment_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecKeyStatus)
                    .WithMany(p => p.DomesticClearingRecRecPayments)
                    .HasForeignKey(d => d.RecKeyStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_Payment_DomesticClearing_Rec_KeyStatus");

                entity.HasOne(d => d.RecValueStatus)
                    .WithMany(p => p.DomesticClearingRecRecPayments)
                    .HasForeignKey(d => d.RecValueStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_Payment_DomesticClearing_Rec_ValueStatus");
            });

            modelBuilder.Entity<DomesticClearingRecRecPaymentCreation>(entity =>
            {
                entity.HasKey(e => e.RecRecPaymentCreationId);

                entity.ToTable("DomesticClearing_Rec_Rec_PaymentCreation");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GcmsreferenceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GCMSReferenceNumber");

                entity.Property(e => e.GebAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("GEB_Amount");

                entity.Property(e => e.GebCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GEB_CreationDate");

                entity.Property(e => e.GebCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("GEB_Currency");

                entity.Property(e => e.GebCustomerAbbreviation)
                    .HasMaxLength(12)
                    .HasColumnName("GEB_CustomerAbbreviation");

                entity.Property(e => e.GebCustomerCurrentAccount)
                    .HasMaxLength(255)
                    .HasColumnName("GEB_CustomerCurrentAccount");

                entity.Property(e => e.GebNumberOfTrans).HasColumnName("GEB_NumberOfTrans");

                entity.Property(e => e.GebPaymentMethodId).HasColumnName("GEB_PaymentMethodId");

                entity.Property(e => e.GebRecCollatePaymentCreationId).HasColumnName("GEB_RecCollatePaymentCreationId");

                entity.Property(e => e.GebValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GEB_ValueDate");

                entity.Property(e => e.PmtAmount)
                    .HasColumnType("decimal(22, 8)")
                    .HasColumnName("PMT_Amount");

                entity.Property(e => e.PmtCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PMT_CreationDate");

                entity.Property(e => e.PmtCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("PMT_Currency");

                entity.Property(e => e.PmtCustomerAbbreviation)
                    .HasMaxLength(12)
                    .HasColumnName("PMT_CustomerAbbreviation");

                entity.Property(e => e.PmtCustomerCurrentAccount)
                    .HasMaxLength(255)
                    .HasColumnName("PMT_CustomerCurrentAccount");

                entity.Property(e => e.PmtNumberOfTrans).HasColumnName("PMT_NumberOfTrans");

                entity.Property(e => e.PmtPaymentMethodId).HasColumnName("PMT_PaymentMethodId");

                entity.Property(e => e.PmtRecCollatePaymentCreationId).HasColumnName("PMT_RecCollatePaymentCreationId");

                entity.Property(e => e.PmtValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PMT_ValueDate");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecRecPaymentCreations)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_PaymentCreation_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecKeyStatus)
                    .WithMany(p => p.DomesticClearingRecRecPaymentCreations)
                    .HasForeignKey(d => d.RecKeyStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_PaymentCreation_DomesticClearing_Rec_KeyStatus");

                entity.HasOne(d => d.RecValueStatus)
                    .WithMany(p => p.DomesticClearingRecRecPaymentCreations)
                    .HasForeignKey(d => d.RecValueStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_PaymentCreation_DomesticClearing_Rec_ValueStatus");
            });

            modelBuilder.Entity<DomesticClearingRecSource>(entity =>
            {
                entity.HasKey(e => e.RecSourceId);

                entity.ToTable("DomesticClearing_Rec_Source");

                entity.Property(e => e.Abbreviation).HasMaxLength(10);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingRecType>(entity =>
            {
                entity.HasKey(e => e.RecTypeId);

                entity.ToTable("DomesticClearing_Rec_Type");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingRecValueStatu>(entity =>
            {
                entity.HasKey(e => e.RecValueStatusId);

                entity.ToTable("DomesticClearing_Rec_ValueStatus");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingRemitter>(entity =>
            {
                entity.HasKey(e => e.RemitterId);

                entity.ToTable("DomesticClearing_Remitter");

                entity.HasIndex(e => e.CustomerAbbreviation, "UQ_DomesticClearing_Remitter_CustomerAbbreviation")
                    .IsUnique();

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerAbbreviation)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.RemitterName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingRemitters)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_Remitter_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingRemitterLog>(entity =>
            {
                entity.HasKey(e => e.RemitterLogId);

                entity.ToTable("DomesticClearing_RemitterLog");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Remitter)
                    .WithMany(p => p.DomesticClearingRemitterLogs)
                    .HasForeignKey(d => d.RemitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_RemitterLog_DomesticClearing_Remitter");
            });

            modelBuilder.Entity<DomesticClearingReturnRefusalCode>(entity =>
            {
                entity.HasKey(e => e.ReturnRefusalCodeId)
                    .HasName("PK_DomesticClearing_ReturnCode");

                entity.ToTable("DomesticClearing_ReturnRefusalCode");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingSource>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.ToTable("DomesticClearing_Source");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingStatu>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("DomesticClearing_Status");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DomesticClearingUnitCodeAccount>(entity =>
            {
                entity.HasKey(e => e.UnitCodeAccountId)
                    .HasName("PK_DomesticClearing_UnitCodeAccounts");

                entity.ToTable("DomesticClearing_UnitCodeAccount");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerCurrentAccount)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.UnitCode)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingUnitCodeAccounts)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_UnitCodeAccounts_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingUnitCodeAccountLog>(entity =>
            {
                entity.HasKey(e => e.UnitCodeAccountLogId);

                entity.ToTable("DomesticClearing_UnitCodeAccountLog");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.UnitCodeAccount)
                    .WithMany(p => p.DomesticClearingUnitCodeAccountLogs)
                    .HasForeignKey(d => d.UnitCodeAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_UnitCodeAccountLog_DomesticClearing_UnitCodeAccount");
            });

            modelBuilder.Entity<DomesticClearingValidationError>(entity =>
            {
                entity.HasKey(e => e.ValidationErrorId);

                entity.ToTable("DomesticClearing_ValidationError");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<DreamsUploadException>(entity =>
            {
                entity.HasKey(e => e.ExceptionId);

                entity.ToTable("DREAMS_UPLOAD_EXCEPTION");

                entity.Property(e => e.ExceptionId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EXCEPTION_ID");

                entity.Property(e => e.ExceptionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXCEPTION_DATE");

                entity.Property(e => e.RecordId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_ID");

                entity.Property(e => e.UploadError)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UPLOAD_ERROR");

                entity.Property(e => e.UploadType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPLOAD_TYPE");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EndOfDayStart>(entity =>
            {
                entity.ToTable("EndOfDayStart");

                entity.Property(e => e.AuthorisedWhen).HasColumnType("datetime");

                entity.Property(e => e.AuthorisedWho).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.VerifiedWhen).HasColumnType("datetime");

                entity.Property(e => e.VerifiedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<EucCcyCode>(entity =>
            {
                entity.HasKey(e => new { e.CcyCd, e.BranchNo });

                entity.ToTable("EUC_CCY_CODE");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.CcyName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CCY_NAME");

                entity.Property(e => e.DecimalPoint)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DECIMAL_POINT");

                entity.Property(e => e.DkbSpecialRateJpy)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DKB_SPECIAL_RATE_JPY");

                entity.Property(e => e.DkbSpecialRateUsd)
                    .HasColumnType("decimal(8, 6)")
                    .HasColumnName("DKB_SPECIAL_RATE_USD");

                entity.Property(e => e.Mark3Cd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MARK3_CD");

                entity.Property(e => e.StepsCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STEPS_CD");

                entity.Property(e => e.SwiftCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_CD");
            });

            modelBuilder.Entity<EucCollateralCode>(entity =>
            {
                entity.HasKey(e => new { e.CollateralCd, e.BranchNo });

                entity.ToTable("EUC_COLLATERAL_CODE");

                entity.Property(e => e.CollateralCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLLATERAL_CD");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CollateralName)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("COLLATERAL_NAME");

                entity.Property(e => e.CollateralRank)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLLATERAL_RANK");
            });

            modelBuilder.Entity<EucCountryCode>(entity =>
            {
                entity.HasKey(e => e.CountryCd);

                entity.ToTable("EUC_COUNTRY_CODE");

                entity.Property(e => e.CountryCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_CD");

                entity.Property(e => e.AreaCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AREA_CD");

                entity.Property(e => e.BoeAreaCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BOE_AREA_CD");

                entity.Property(e => e.BoeCd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BOE_CD");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_NAME");

                entity.Property(e => e.FrbCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FRB_CD");

                entity.Property(e => e.HomeCcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("HOME_CCY_CD");
            });

            modelBuilder.Entity<EucCustAttributeCode>(entity =>
            {
                entity.HasKey(e => new { e.AttributeCd, e.BranchNo });

                entity.ToTable("EUC_CUST_ATTRIBUTE_CODE");

                entity.Property(e => e.AttributeCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CD");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NAME");
            });

            modelBuilder.Entity<EucCustomerAccountNo>(entity =>
            {
                entity.HasKey(e => new { e.CustAbbr, e.ActCd, e.ActNo, e.IbfId, e.CcyCd, e.StatusCd });

                entity.ToTable("EUC_CUSTOMER_ACCOUNT_NO");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACT_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActNo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ACT_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IbfId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IBF_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActAbbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ACT_ABBR ");

                entity.Property(e => e.ActName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ACT_NAME");

                entity.Property(e => e.ActShortName)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ACT_SHORT_NAME");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");
            });

            modelBuilder.Entity<EucDeptCode>(entity =>
            {
                entity.HasKey(e => new { e.DeptCd, e.BranchNo });

                entity.ToTable("EUC_DEPT_CODE");

                entity.Property(e => e.DeptCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CD");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.DeptAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_ABBR");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_NAME");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD");
            });

            modelBuilder.Entity<EucIndustryCode>(entity =>
            {
                entity.HasKey(e => new { e.IndustryCd, e.BranchNo });

                entity.ToTable("EUC_INDUSTRY_CODE");

                entity.Property(e => e.IndustryCd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("INDUSTRY_CD");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.IndustryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INDUSTRY_NAME");
            });

            modelBuilder.Entity<EucTaxCode>(entity =>
            {
                entity.HasKey(e => new { e.TaxId, e.TaxCd, e.BranchNo });

                entity.ToTable("EUC_TAX_CODE");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TAX_ID");

                entity.Property(e => e.TaxCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TAX_CD");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(10, 7)")
                    .HasColumnName("TAX_RATE");
            });

            modelBuilder.Entity<FuturesRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Period });

                entity.ToTable("FUTURES_RATE");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.Period)
                    .HasColumnType("datetime")
                    .HasColumnName("PERIOD");

                entity.Property(e => e.ImportedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IMPORTED_BY");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(16, 9)")
                    .HasColumnName("RATE");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS");
            });

            modelBuilder.Entity<FxRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy });

                entity.ToTable("FX_RATE");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Bid)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("BID");

                entity.Property(e => e.ImportedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IMPORTED_BY");

                entity.Property(e => e.ImportedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("IMPORTED_TIME")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Offer)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("OFFER");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("RATE");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FxSettlementInf>(entity =>
            {
                entity.ToTable("FX_SETTLEMENT_INF");

                entity.HasIndex(e => e.RefNo, "IX_FX_SETTLEMENT_INF")
                    .IsUnique();

                entity.HasIndex(e => new { e.AuthorizeOn, e.RefNo, e.TranNo, e.GipStatus }, "IX_FX_SETTLEMENT_INF_GIP_SEARCH");

                entity.HasIndex(e => e.Status, "IX_FX_SETTLEMENT_INF_STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.AdviceRecLimit)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("ADVICE_REC_LIMIT");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.BankFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANK_FLG");

                entity.Property(e => e.BankToBankInf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.ContractCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("CONTRACT_CCY_AMT");

                entity.Property(e => e.CoverPoFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COVER_PO_FLG");

                entity.Property(e => e.CustAbbr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.DeleteBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_AMT");

                entity.Property(e => e.GipDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GIP_DESCRIPTION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OPERATION_ID")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.PayAccBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Pay_ACC_Bank")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_CD");

                entity.Property(e => e.PayActNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_NO");

                entity.Property(e => e.PayAdviceRecFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ADVICE_REC_FLG");

                entity.Property(e => e.PayBeneficiary)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Pay_Beneficiary")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayCcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_CCY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayCustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAY_CUST_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayHoFavorMt202)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pay_HO_FAVOR_MT202")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayIntermediaryBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Pay_INTERMEDIARY_BANK");

                entity.Property(e => e.PayKihyoIrai)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pay_KIHYO_IRAI");

                entity.Property(e => e.PayMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PAY_MESSAGE_TYPE");

                entity.Property(e => e.PayMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_METHOD");

                entity.Property(e => e.PayOrderingCustomer)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Pay_Ordering_Customer")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherCr)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("Pay_OTHER_CR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherDr)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("Pay_OTHER_DR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Pay_OTHER_METHOD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pay_OTHER_RMT_FLG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails1)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Pay_Payment_Details1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails2)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Pay_Payment_Details2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails3)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Pay_Payment_Details3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails4)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Pay_Payment_Details4")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPriortyFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_PRIORTY_FLG");

                entity.Property(e => e.PayRecBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Pay_REC_BANK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayReceiverCorres)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Pay_Receiver_Corres")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_RMT_FLG");

                entity.Property(e => e.PaySenderCorres)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Pay_Sender_Corres")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaySettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SETTL_CODE");

                entity.Property(e => e.PriortyFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PRIORTY_FLG");

                entity.Property(e => e.RecActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_CD");

                entity.Property(e => e.RecActNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_NO");

                entity.Property(e => e.RecAdviceRecFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_ADVICE_REC_FLG");

                entity.Property(e => e.RecCcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_CCY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecCustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_CUST_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecHoFavorMt202)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Rec_HO_FAVOR_MT202")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecIntermediaryBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Rec_INTERMEDIARY_BANK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecKihyoIrai)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Rec_KIHYO_IRAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REC_MESSAGE_TYPE");

                entity.Property(e => e.RecMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_METHOD");

                entity.Property(e => e.RecOrderingBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Rec_Ordering_Bank")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOrderingCustomer)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Rec_Ordering_Customer")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherCr)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("Rec_OTHER_CR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherDr)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("Rec_OTHER_DR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Rec_OTHER_METHOD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Rec_OTHER_RMT_FLG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecPriortyFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_PRIORTY_FLG");

                entity.Property(e => e.RecRecBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Rec_REC_BANK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_RMT_FLG");

                entity.Property(e => e.RecSettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_SETTL_CODE");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REF_NO");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("VERIFY_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.HasOne(d => d.RefNoNavigation)
                    .WithOne(p => p.FxSettlementInf)
                    .HasForeignKey<FxSettlementInf>(d => d.RefNo)
                    .HasConstraintName("FK_FX_TRANSACTION_FX_SETTLEMENT_INF");
            });

            modelBuilder.Entity<FxTransaction>(entity =>
            {
                entity.HasKey(e => e.RefNo);

                entity.ToTable("FX_TRANSACTION");

                entity.HasIndex(e => e.ExecutionRefNo, "IX_FX_TRANSACTION_ExecutionRefNo");

                entity.HasIndex(e => new { e.RefNo, e.BranchNo }, "IX_FX_TRANSACTION_Ref_Branch_No");

                entity.HasIndex(e => e.Status, "IX_FX_TRANSACTION_STATUS");

                entity.HasIndex(e => e.SchemeNo, "IX_FX_TRANSACTION_Scheme_No");

                entity.HasIndex(e => e.SwapRefNo, "IX_FX_TRANSACTION_Swap_Ref_No");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REF_NO");

                entity.Property(e => e.AccountEntry)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_ENTRY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccrualFrom)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ACCRUAL_FROM")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AccrualTo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ACCRUAL_TO")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ActAbbr)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ACT_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActCd)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACT_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Addressee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESSEE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Authorized)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZED")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO")
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.Broker)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BROKER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code56)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE56")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code57)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE57")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code57a)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE57A")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code58)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE58")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractCcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_CCY_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("CONTRACT_CCY_AMT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractCcyBal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("CONTRACT_CCY_BAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractCcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_CCY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractCcyTtb)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("CONTRACT_CCY_TTB")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractDateOpe)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CONTRACT_DATE_OPE")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ContractDateValue)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CONTRACT_DATE_VALUE")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.CoverPoFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COVER_PO_FLG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DealNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Dealer)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEALER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dealtype)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEALTYPE");

                entity.Property(e => e.DeleteBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelivaryDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVARY_DATE")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.DelivaryThru)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVARY_THRU")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.DivisionCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DIVISION_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EQUIV_CCY_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_AMT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EquivCcyBal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_BAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EquivCcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EQUIV_CCY_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyTtb)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("EQUIV_CCY_TTB")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("EXCHANGE_RATE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExecutionRefNo).HasDefaultValueSql("(0)");

                entity.Property(e => e.GipDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GIP_DESCRIPTION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IbfId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IBF_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InternalRate)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("INTERNAL_RATE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.OptionsFlag).HasDefaultValueSql("(0)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.RemarksTrd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_TRD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Revise)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REVISE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SchemeNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SCHEME_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SetInstruction)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SettlementValueDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SETTLEMENT_VALUE_DATE")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.Spread)
                    .HasColumnType("decimal(9, 6)")
                    .HasColumnName("SPREAD")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subtype)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SUBTYPE");

                entity.Property(e => e.SwapRefNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SWAP_REF_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("VERIFY_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.HasOne(d => d.CustomerMaster)
                    .WithMany(p => p.FxTransactions)
                    .HasForeignKey(d => new { d.BranchNo, d.CustAbbr })
                    .HasConstraintName("FK_FX_TRANSACTION_CUSTOMER_MASTER");
            });

            modelBuilder.Entity<FxTransactionExt>(entity =>
            {
                entity.HasKey(e => e.RefNo);

                entity.ToTable("FX_TRANSACTION_EXT");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REF_NO");

                entity.Property(e => e.AuthorisedDealer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerFeeAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ContractCcyAbbrOrig)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_CCY_ABBR_ORIG")
                    .IsFixedLength(true);

                entity.Property(e => e.DealingMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquivCcyAbbrOrig)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQUIV_CCY_ABBR_ORIG")
                    .IsFixedLength(true);

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Gidupload).HasColumnName("GIDUpload");

                entity.Property(e => e.PortfolioBook)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioDesk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintDateTime).HasColumnType("datetime");

                entity.Property(e => e.SourceCtpy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceSystem)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FxTransactionExtBakMurexRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FX_TRANSACTION_EXT_Bak_MurexRelease");

                entity.Property(e => e.AuthorisedDealer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerFeeAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ContractCcyAbbrOrig)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_CCY_ABBR_ORIG")
                    .IsFixedLength(true);

                entity.Property(e => e.DealingMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquivCcyAbbrOrig)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQUIV_CCY_ABBR_ORIG")
                    .IsFixedLength(true);

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioBook)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioDesk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintDateTime).HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REF_NO");

                entity.Property(e => e.SourceCtpy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceSystem)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FxTransactionModCodesMurexRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FX_TRANSACTION_Mod_Codes_MurexRelease");

                entity.Property(e => e.AccountEntry)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_ENTRY");

                entity.Property(e => e.AccrualFrom)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ACCRUAL_FROM");

                entity.Property(e => e.AccrualTo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ACCRUAL_TO");

                entity.Property(e => e.ActAbbr)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ACT_ABBR");

                entity.Property(e => e.ActCd)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACT_CD");

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON");

                entity.Property(e => e.Addressee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESSEE");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON");

                entity.Property(e => e.Authorized)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZED");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.Broker)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BROKER");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.Code56)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE56");

                entity.Property(e => e.Code57)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE57");

                entity.Property(e => e.Code57a)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE57A");

                entity.Property(e => e.Code58)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE58");

                entity.Property(e => e.ContractCcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_CCY_ABBR");

                entity.Property(e => e.ContractCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("CONTRACT_CCY_AMT");

                entity.Property(e => e.ContractCcyBal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("CONTRACT_CCY_BAL");

                entity.Property(e => e.ContractCcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_CCY_CD");

                entity.Property(e => e.ContractCcyTtb)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("CONTRACT_CCY_TTB");

                entity.Property(e => e.ContractDateOpe)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CONTRACT_DATE_OPE");

                entity.Property(e => e.ContractDateValue)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CONTRACT_DATE_VALUE");

                entity.Property(e => e.CoverPoFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COVER_PO_FLG");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.CustCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE");

                entity.Property(e => e.DealNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Dealer)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEALER");

                entity.Property(e => e.Dealtype)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEALTYPE");

                entity.Property(e => e.DeleteBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON");

                entity.Property(e => e.DeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS");

                entity.Property(e => e.DelivaryDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVARY_DATE");

                entity.Property(e => e.DelivaryThru)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVARY_THRU");

                entity.Property(e => e.DivisionCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DIVISION_CD");

                entity.Property(e => e.EquivCcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EQUIV_CCY_ABBR");

                entity.Property(e => e.EquivCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_AMT");

                entity.Property(e => e.EquivCcyBal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_BAL");

                entity.Property(e => e.EquivCcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EQUIV_CCY_CD");

                entity.Property(e => e.EquivCcyTtb)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("EQUIV_CCY_TTB");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("EXCHANGE_RATE");

                entity.Property(e => e.GipDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GIP_DESCRIPTION");

                entity.Property(e => e.GipStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS");

                entity.Property(e => e.IbfId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IBF_ID");

                entity.Property(e => e.InternalRate)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("INTERNAL_RATE");

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REF_NO");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.RemarksTrd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS_TRD");

                entity.Property(e => e.Revise)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REVISE");

                entity.Property(e => e.SchemeNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SCHEME_NO");

                entity.Property(e => e.SetInstruction)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementValueDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SETTLEMENT_VALUE_DATE");

                entity.Property(e => e.Spread)
                    .HasColumnType("decimal(9, 6)")
                    .HasColumnName("SPREAD");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD");

                entity.Property(e => e.Subtype)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SUBTYPE");

                entity.Property(e => e.SwapRefNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SWAP_REF_NO");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO");

                entity.Property(e => e.VerifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_BY");

                entity.Property(e => e.VerifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("VERIFY_ON");
            });

            modelBuilder.Entity<FxTransactionUploadGipStatu>(entity =>
            {
                entity.HasKey(e => e.GipStatus)
                    .HasName("FX_TRANSACTION_GipStatus_PK");

                entity.ToTable("FX_TRANSACTION_UploadGipStatus");

                entity.Property(e => e.GipStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("Gip_Status");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Fxfarbitrage>(entity =>
            {
                entity.ToTable("FXFArbitrage");

                entity.HasIndex(e => e.SchemeNo, "IX_FXFArbitrage_SCHEMENO")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contractdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FixedCurrency)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FwdbghAmt).HasColumnName("FWDBghAmt");

                entity.Property(e => e.FwdbghCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FWDBghCCY")
                    .IsFixedLength(true);

                entity.Property(e => e.FwdexRate).HasColumnName("FWDExRate");

                entity.Property(e => e.FwdsoldAmt).HasColumnName("FWDSoldAmt");

                entity.Property(e => e.FwdsoldCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FWDSoldCCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Ibf)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IBF")
                    .IsFixedLength(true);

                entity.Property(e => e.IfwdBghAmt).HasColumnName("IFwdBghAmt");

                entity.Property(e => e.IfwdBghCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IFwdBghCCY")
                    .IsFixedLength(true);

                entity.Property(e => e.IfwdExRate).HasColumnName("IFwdExRate");

                entity.Property(e => e.IfwdSoldAmt).HasColumnName("IFwdSoldAmt");

                entity.Property(e => e.IfwdSoldCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IFwdSoldCCY")
                    .IsFixedLength(true);

                entity.Property(e => e.LendDaysAyear).HasColumnName("LendDaysAYear");

                entity.Property(e => e.LendPrinCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LendPrinCCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Printdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PRINTDATE");

                entity.Property(e => e.Printed).HasColumnName("PRINTED");

                entity.Property(e => e.Printtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PRINTTIME");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchemeNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SpotBghCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SpotBghCCY")
                    .IsFixedLength(true);

                entity.Property(e => e.SpotSoldCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SpotSoldCCY")
                    .IsFixedLength(true);

                entity.Property(e => e.TakeDaysAyear).HasColumnName("TakeDaysAYear");

                entity.Property(e => e.TakePrinCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TakePrinCCY")
                    .IsFixedLength(true);

                entity.Property(e => e.ValueDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<FxfbusCenter>(entity =>
            {
                entity.ToTable("FXFBusCenter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fxfcalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FXFCalendar");

                entity.Property(e => e.Ccycode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCYCODE");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<Fxfccy>(entity =>
            {
                entity.HasKey(e => e.CcyId);

                entity.ToTable("FXFCcy");

                entity.Property(e => e.CcyId).HasColumnName("CCY_ID");

                entity.Property(e => e.AudcrossCcyname)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUDCrossCCYName");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD")
                    .IsFixedLength(true);

                entity.Property(e => e.Ccydesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCYDESC");

                entity.Property(e => e.Days).HasColumnName("DAYS");

                entity.Property(e => e.Direct).HasColumnName("DIRECT");

                entity.Property(e => e.DreamsDesc)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fxblotterorder).HasColumnName("FXBLOTTERORDER");

                entity.Property(e => e.MurexRateQuotation)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Murex_Rate_Quotation");

                entity.Property(e => e.ReutersRateType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Reuters_Rate_Type");

                entity.Property(e => e.Spreadvalue).HasColumnName("SPREADVALUE");
            });

            modelBuilder.Entity<FxfcreditCustType>(entity =>
            {
                entity.ToTable("FXFCreditCustType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FxfcreditParent>(entity =>
            {
                entity.ToTable("FXFCreditParent");

                entity.HasIndex(e => e.CorpNo, "IX_FXFCreditParent_CorpNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CorpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustTypeId).HasColumnName("CustType_ID");

                entity.Property(e => e.DepositAlm).HasColumnName("DepositALM");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ibosno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IBOSNo");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamedayFx).HasColumnName("SamedayFX");
            });

            modelBuilder.Entity<Fxfcust>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("FXFCust");

                entity.HasIndex(e => e.Abbreviation, "IX_FXFCust_Abbreviation");

                entity.HasIndex(e => e.Shortname, "IX_FXFCust_SHORTNAME");

                entity.Property(e => e.CustId).HasColumnName("CUST_ID");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.Branch)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.CallDepositAudType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Call_Deposit_AUD_type");

                entity.Property(e => e.CallDepositFgnType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Call_Deposit_FGN_type");

                entity.Property(e => e.CallLoanAudType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Call_Loan_AUD_type");

                entity.Property(e => e.CallLoanFgnType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Call_Loan_FGN_type");

                entity.Property(e => e.Category)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ccif)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CCIF");

                entity.Property(e => e.City)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Country)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ibosno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IBOSNO");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ParentEntityId).HasColumnName("ParentEntity_ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Shortname)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("SHORTNAME");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Street1)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Street2)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Street3)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Street4)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Swift)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telex)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.MxGuideCustDetail)
                    .WithMany(p => p.Fxfcusts)
                    .HasForeignKey(d => d.MxGuideCustDetailId)
                    .HasConstraintName("FK_FXFCustMxGuideCustDetail");
            });

            modelBuilder.Entity<FxfcustBakMurexRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FXFCust_Bak_MurexRelease");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON");

                entity.Property(e => e.Branch)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.CallDepositAudType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Call_Deposit_AUD_type");

                entity.Property(e => e.CallDepositFgnType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Call_Deposit_FGN_type");

                entity.Property(e => e.CallLoanAudType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Call_Loan_AUD_type");

                entity.Property(e => e.CallLoanFgnType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Call_Loan_FGN_type");

                entity.Property(e => e.Category)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ccif)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CCIF");

                entity.Property(e => e.City)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Country)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CUST_ID");

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON");

                entity.Property(e => e.DeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ibosno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IBOSNO");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON");

                entity.Property(e => e.Notes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ParentEntityId).HasColumnName("ParentEntity_ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Shortname)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("SHORTNAME");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Street1)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Street2)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Street3)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Street4)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Swift)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telex)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fxfcustthreshold>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("FXFCUSTThreshold");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY");
            });

            modelBuilder.Entity<FxfdealType>(entity =>
            {
                entity.HasKey(e => e.DealtypeId)
                    .HasName("PK_FXFDEALTYPE")
                    .IsClustered(false);

                entity.ToTable("FXFDealType");

                entity.Property(e => e.DealtypeId).HasColumnName("DEALTYPE_ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CalcTypeId).HasColumnName("CalcType_ID");

                entity.Property(e => e.CorpLimitTypeId).HasColumnName("CorpLimitType_ID");

                entity.Property(e => e.Dealtype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DEALTYPE");

                entity.Property(e => e.FactorTypeId).HasColumnName("FactorType_ID");

                entity.Property(e => e.FilimitTypeId).HasColumnName("FILimitType_ID");

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

                entity.Property(e => e.ProductcodeId).HasColumnName("Productcode_ID");

                entity.Property(e => e.RefType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Subtype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUBTYPE");

                entity.Property(e => e.Tranname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TRANNAME");

                entity.Property(e => e.Typology)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fxfinstitution>(entity =>
            {
                entity.HasKey(e => e.Institutionid);

                entity.ToTable("FXFInstitution");

                entity.HasIndex(e => e.Code, "IX_FXFInstitution_CODE")
                    .IsUnique();

                entity.Property(e => e.Institutionid).HasColumnName("INSTITUTIONID");

                entity.Property(e => e.Code)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Subtypecode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SUBTYPECODE");
            });

            modelBuilder.Entity<Fxfswift>(entity =>
            {
                entity.ToTable("FXFSwift");

                entity.HasIndex(e => new { e.RecordKind, e.CustCode, e.CcyCd }, "IX_FXFSwift")
                    .IsUnique();

                entity.HasIndex(e => e.SifId, "IX_FXFSwift_SWIFT_ID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON");

                entity.Property(e => e.Addresse)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizeBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON");

                entity.Property(e => e.Bic561)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC56_1");

                entity.Property(e => e.Bic571)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_1");

                entity.Property(e => e.Bic572)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_2");

                entity.Property(e => e.Bic573)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_3");

                entity.Property(e => e.Bic574)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_4");

                entity.Property(e => e.Bic581)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC58_1");

                entity.Property(e => e.Bic591)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_1");

                entity.Property(e => e.Bic592)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_2");

                entity.Property(e => e.Bic593)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_3");

                entity.Property(e => e.Bic594)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_4");

                entity.Property(e => e.CcyCd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.CcyId).HasColumnName("CCY_ID");

                entity.Property(e => e.CustCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE");

                entity.Property(e => e.DeletionStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS");

                entity.Property(e => e.FxalmPartyIdentifier57)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("FXALM_PartyIdentifier57");

                entity.Property(e => e.FxalmPartyIdentifier58)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("FXALM_PartyIdentifier58");

                entity.Property(e => e.PartyIdentifier56)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartyIdentifier57)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartyIdentifier58)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartyIdentifier59)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.RecordKind)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_KIND")
                    .IsFixedLength(true);

                entity.Property(e => e.SifId).HasColumnName("SIF_ID");

                entity.Property(e => e.SpecialInstruction1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_1");

                entity.Property(e => e.SpecialInstruction2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_2");

                entity.Property(e => e.SpecialInstruction3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_3");

                entity.Property(e => e.SpecialInstruction4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_4");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<FxfswiftModCodesMurexRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FXFSwift_Mod_Codes_MurexRelease");

                entity.Property(e => e.AddBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON");

                entity.Property(e => e.Addresse)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizeBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON");

                entity.Property(e => e.Bic561)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC56_1");

                entity.Property(e => e.Bic571)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_1");

                entity.Property(e => e.Bic572)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_2");

                entity.Property(e => e.Bic573)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_3");

                entity.Property(e => e.Bic574)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_4");

                entity.Property(e => e.Bic581)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC58_1");

                entity.Property(e => e.Bic591)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_1");

                entity.Property(e => e.Bic592)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_2");

                entity.Property(e => e.Bic593)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_3");

                entity.Property(e => e.Bic594)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_4");

                entity.Property(e => e.CcyCd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.CcyId).HasColumnName("CCY_ID");

                entity.Property(e => e.CustCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE");

                entity.Property(e => e.DeletionStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS");

                entity.Property(e => e.FxalmPartyIdentifier57)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("FXALM_PartyIdentifier57");

                entity.Property(e => e.FxalmPartyIdentifier58)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("FXALM_PartyIdentifier58");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PartyIdentifier56)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartyIdentifier57)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartyIdentifier58)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartyIdentifier59)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.RecordKind)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_KIND")
                    .IsFixedLength(true);

                entity.Property(e => e.SifId).HasColumnName("SIF_ID");

                entity.Property(e => e.SpecialInstruction1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_1");

                entity.Property(e => e.SpecialInstruction2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_2");

                entity.Property(e => e.SpecialInstruction3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_3");

                entity.Property(e => e.SpecialInstruction4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_4");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<GasGoCredit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAS_GO_CREDIT");

                entity.Property(e => e.AccCdTx)
                    .HasMaxLength(5)
                    .HasColumnName("ACC_CD_TX");

                entity.Property(e => e.AccnumTx)
                    .HasMaxLength(12)
                    .HasColumnName("ACCNUM_TX");

                entity.Property(e => e.AdviseprintTx)
                    .HasMaxLength(1)
                    .HasColumnName("ADVISEPRINT_TX");

                entity.Property(e => e.AmountAmt)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNT_AMT");

                entity.Property(e => e.AvailableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AVAILABLE_DATE");

                entity.Property(e => e.CcyTx)
                    .HasMaxLength(4)
                    .HasColumnName("CCY_TX");

                entity.Property(e => e.ChecknoTx)
                    .HasMaxLength(10)
                    .HasColumnName("CHECKNO_TX");

                entity.Property(e => e.CustidTx)
                    .HasMaxLength(12)
                    .HasColumnName("CUSTID_TX");

                entity.Property(e => e.DetailsTx)
                    .HasMaxLength(30)
                    .HasColumnName("DETAILS_TX");

                entity.Property(e => e.DivisionTx)
                    .HasMaxLength(2)
                    .HasColumnName("DIVISION_TX");

                entity.Property(e => e.EntityTx)
                    .HasMaxLength(3)
                    .HasColumnName("ENTITY_TX");

                entity.Property(e => e.ExchrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("EXCHRATE_INT");

                entity.Property(e => e.FundTx)
                    .HasMaxLength(1)
                    .HasColumnName("FUND_TX");

                entity.Property(e => e.FxccyTx)
                    .HasMaxLength(4)
                    .HasColumnName("FXCCY_TX");

                entity.Property(e => e.GroupnoTx)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("GROUPNO_TX");

                entity.Property(e => e.IbfTx)
                    .HasMaxLength(1)
                    .HasColumnName("IBF_TX");

                entity.Property(e => e.InterrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("INTERRATE_INT");

                entity.Property(e => e.MinNo)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MIN_NO");

                entity.Property(e => e.TypeTx)
                    .HasMaxLength(1)
                    .HasColumnName("TYPE_TX");
            });

            modelBuilder.Entity<GasGoDebit>(entity =>
            {
                entity.HasKey(e => e.MinNo);

                entity.ToTable("GAS_GO_DEBIT");

                entity.HasIndex(e => e.MinNo, "GasGoDebit_MinNo")
                    .IsUnique();

                entity.Property(e => e.MinNo)
                    .HasMaxLength(18)
                    .HasColumnName("MIN_NO");

                entity.Property(e => e.AccCdTx)
                    .HasMaxLength(5)
                    .HasColumnName("ACC_CD_TX");

                entity.Property(e => e.AccnumTx)
                    .HasMaxLength(12)
                    .HasColumnName("ACCNUM_TX");

                entity.Property(e => e.AcubuTx)
                    .HasMaxLength(3)
                    .HasColumnName("ACUBU_TX");

                entity.Property(e => e.AdviseprintTx)
                    .HasMaxLength(1)
                    .HasColumnName("ADVISEPRINT_TX");

                entity.Property(e => e.AmountAmt)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNT_AMT");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(8)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.AvailableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AVAILABLE_DATE");

                entity.Property(e => e.BackvalueInd)
                    .HasMaxLength(1)
                    .HasColumnName("BACKVALUE_IND");

                entity.Property(e => e.BulkUploadInd)
                    .HasMaxLength(1)
                    .HasColumnName("BULK_UPLOAD_IND");

                entity.Property(e => e.CcyTx)
                    .HasMaxLength(4)
                    .HasColumnName("CCY_TX");

                entity.Property(e => e.ChecknoTx)
                    .HasMaxLength(10)
                    .HasColumnName("CHECKNO_TX");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(8)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.CustidTx)
                    .HasMaxLength(12)
                    .HasColumnName("CUSTID_TX");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(8)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_DATE");

                entity.Property(e => e.DeletionInd)
                    .HasMaxLength(1)
                    .HasColumnName("DELETION_IND");

                entity.Property(e => e.DescriptionTx)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION_TX");

                entity.Property(e => e.DetailsTx)
                    .HasMaxLength(30)
                    .HasColumnName("DETAILS_TX");

                entity.Property(e => e.DivisionTx)
                    .HasMaxLength(2)
                    .HasColumnName("DIVISION_TX");

                entity.Property(e => e.DreamsRefCode)
                    .HasMaxLength(12)
                    .HasColumnName("DREAMS_REF_CODE");

                entity.Property(e => e.EntityTx)
                    .HasMaxLength(3)
                    .HasColumnName("ENTITY_TX");

                entity.Property(e => e.ExchrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("EXCHRATE_INT");

                entity.Property(e => e.ExportedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPORTED_DT");

                entity.Property(e => e.FundTx)
                    .HasMaxLength(1)
                    .HasColumnName("FUND_TX");

                entity.Property(e => e.FxccyTx)
                    .HasMaxLength(4)
                    .HasColumnName("FXCCY_TX");

                entity.Property(e => e.GroupnoTx)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("GROUPNO_TX");

                entity.Property(e => e.IbfTx)
                    .HasMaxLength(1)
                    .HasColumnName("IBF_TX");

                entity.Property(e => e.InterrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("INTERRATE_INT");

                entity.Property(e => e.LastEditedBy)
                    .HasMaxLength(8)
                    .HasColumnName("LAST_EDITED_BY");

                entity.Property(e => e.LastEditedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_EDITED_DATE");

                entity.Property(e => e.PushFlag)
                    .HasMaxLength(1)
                    .HasColumnName("PUSH_FLAG");

                entity.Property(e => e.PushTxnFlag)
                    .HasMaxLength(1)
                    .HasColumnName("PUSH_TXN_FLAG");

                entity.Property(e => e.ReasonTx)
                    .HasMaxLength(30)
                    .HasColumnName("REASON_TX");

                entity.Property(e => e.RemarksTx)
                    .HasMaxLength(30)
                    .HasColumnName("REMARKS_TX");

                entity.Property(e => e.ReversedBy)
                    .HasMaxLength(8)
                    .HasColumnName("REVERSED_BY");

                entity.Property(e => e.ReversedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REVERSED_DATE");

                entity.Property(e => e.SeqNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SEQ_NO");

                entity.Property(e => e.StatusInt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STATUS_INT");

                entity.Property(e => e.TranType)
                    .HasMaxLength(1)
                    .HasColumnName("TRAN_TYPE");

                entity.Property(e => e.TransnoTx)
                    .HasMaxLength(5)
                    .HasColumnName("TRANSNO_TX");

                entity.Property(e => e.TypeTx)
                    .HasMaxLength(2)
                    .HasColumnName("TYPE_TX");

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(8)
                    .HasColumnName("UPLOADED_BY");

                entity.Property(e => e.UploadedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPLOADED_DATE");

                entity.Property(e => e.ValuedateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("VALUEDATE_DT");
            });

            modelBuilder.Entity<GasGoParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAS_GO_PARAMETER");

                entity.Property(e => e.AcubuTx)
                    .HasMaxLength(3)
                    .HasColumnName("ACUBU_TX");

                entity.Property(e => e.BackvalueInd)
                    .HasMaxLength(1)
                    .HasColumnName("BACKVALUE_IND");

                entity.Property(e => e.CrAccCodeTx)
                    .HasMaxLength(5)
                    .HasColumnName("CR_ACC_CODE_TX");

                entity.Property(e => e.CrChecknoTx)
                    .HasMaxLength(10)
                    .HasColumnName("CR_CHECKNO_TX");

                entity.Property(e => e.CrDivisionTx)
                    .HasMaxLength(3)
                    .HasColumnName("CR_DIVISION_TX");

                entity.Property(e => e.CrEntityTx)
                    .HasMaxLength(3)
                    .HasColumnName("CR_ENTITY_TX");

                entity.Property(e => e.DrAccCodeTx)
                    .HasMaxLength(5)
                    .HasColumnName("DR_ACC_CODE_TX");

                entity.Property(e => e.DrChecknoTx)
                    .HasMaxLength(10)
                    .HasColumnName("DR_CHECKNO_TX");

                entity.Property(e => e.DrDivisionTx)
                    .HasMaxLength(3)
                    .HasColumnName("DR_DIVISION_TX");

                entity.Property(e => e.DrEntityTx)
                    .HasMaxLength(3)
                    .HasColumnName("DR_ENTITY_TX");

                entity.Property(e => e.ExchrateInd)
                    .HasMaxLength(1)
                    .HasColumnName("EXCHRATE_IND");

                entity.Property(e => e.RemarksTx)
                    .HasMaxLength(30)
                    .HasColumnName("REMARKS_TX");

                entity.Property(e => e.TypeTx)
                    .HasMaxLength(2)
                    .HasColumnName("TYPE_TX");
            });

            modelBuilder.Entity<GasGoUploadParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAS_GO_UPLOAD_PARAMETER");

                entity.Property(e => e.GoScreenTx)
                    .HasMaxLength(7)
                    .HasColumnName("GO_SCREEN_TX");

                entity.Property(e => e.MasterMenuTx)
                    .HasMaxLength(2)
                    .HasColumnName("MASTER_MENU_TX");

                entity.Property(e => e.SectionTx)
                    .HasMaxLength(2)
                    .HasColumnName("SECTION_TX");

                entity.Property(e => e.SubMenuScreenTx)
                    .HasMaxLength(7)
                    .HasColumnName("SUB_MENU_SCREEN_TX");

                entity.Property(e => e.SubMenuTx)
                    .HasMaxLength(2)
                    .HasColumnName("SUB_MENU_TX");

                entity.Property(e => e.TypeTx)
                    .HasMaxLength(2)
                    .HasColumnName("TYPE_TX");
            });

            modelBuilder.Entity<GasTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAS_TEMPLATE");

                entity.Property(e => e.AcuBu)
                    .HasMaxLength(3)
                    .HasColumnName("ACU_BU");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(8)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.BackValue)
                    .HasMaxLength(1)
                    .HasColumnName("BACK_VALUE");

                entity.Property(e => e.Category)
                    .HasMaxLength(30)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(8)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Reason)
                    .HasMaxLength(30)
                    .HasColumnName("REASON");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(30)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("STATUS");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("TEMPLATE_NAME");

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<GasTemplateDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAS_TEMPLATE_DETAILS");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(5)
                    .HasColumnName("ACCOUNT_CODE");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .HasColumnName("ACCOUNT_NUMBER");

                entity.Property(e => e.Advice)
                    .HasMaxLength(1)
                    .HasColumnName("ADVICE");

                entity.Property(e => e.AmountAmount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNT_AMOUNT");

                entity.Property(e => e.AmountCcy)
                    .HasMaxLength(3)
                    .HasColumnName("AMOUNT_CCY");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.CustName)
                    .HasMaxLength(40)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.Debit)
                    .HasMaxLength(1)
                    .HasColumnName("DEBIT");

                entity.Property(e => e.Details)
                    .HasMaxLength(30)
                    .HasColumnName("DETAILS");

                entity.Property(e => e.Division)
                    .HasMaxLength(3)
                    .HasColumnName("DIVISION");

                entity.Property(e => e.Entity)
                    .HasMaxLength(3)
                    .HasColumnName("ENTITY");

                entity.Property(e => e.ExchRateAmount)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("EXCH_RATE_AMOUNT");

                entity.Property(e => e.ExchRateCcy)
                    .HasMaxLength(3)
                    .HasColumnName("EXCH_RATE_CCY");

                entity.Property(e => e.Fund)
                    .HasMaxLength(1)
                    .HasColumnName("FUND");

                entity.Property(e => e.IbfTx)
                    .HasMaxLength(1)
                    .HasColumnName("IBF_TX");

                entity.Property(e => e.Interrate)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("INTERRATE");

                entity.Property(e => e.ItemNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("ITEM_NUMBER");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("TEMPLATE_NAME");
            });

            modelBuilder.Entity<GasUploadHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAS_UPLOAD_HISTORY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.DescriptionTx)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION_TX");

                entity.Property(e => e.DreamsRefCode)
                    .HasMaxLength(12)
                    .HasColumnName("DREAMS_REF_CODE");

                entity.Property(e => e.GroupNo)
                    .HasMaxLength(2)
                    .HasColumnName("GROUP_NO");

                entity.Property(e => e.MinNo)
                    .IsRequired()
                    .HasMaxLength(26)
                    .HasColumnName("MIN_NO");

                entity.Property(e => e.SequencenoTx)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("SEQUENCENO_TX");

                entity.Property(e => e.Status)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.TranNumber)
                    .HasMaxLength(5)
                    .HasColumnName("TRAN_NUMBER");

                entity.Property(e => e.UploadMode)
                    .HasMaxLength(3)
                    .HasColumnName("UPLOAD_MODE");
            });

            modelBuilder.Entity<GasUploadStatu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAS_UPLOAD_STATUS");

                entity.Property(e => e.DescriptionTx)
                    .HasMaxLength(40)
                    .HasColumnName("DESCRIPTION_TX");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("FILE_TYPE");

                entity.Property(e => e.UploadCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("UPLOAD_CODE");

                entity.Property(e => e.UploadTag)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("UPLOAD_TAG");
            });

            modelBuilder.Entity<GasUploadTexception>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAS_UPLOAD_TEXCEPTIONS");

                entity.Property(e => e.DescriptionTx)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION_TX");

                entity.Property(e => e.FunctionTx)
                    .HasMaxLength(50)
                    .HasColumnName("FUNCTION_TX");

                entity.Property(e => e.GroupnoTx)
                    .HasMaxLength(2)
                    .HasColumnName("GROUPNO_TX");

                entity.Property(e => e.LogdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGDATE_DT");

                entity.Property(e => e.LogidTx)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("LOGID_TX");

                entity.Property(e => e.MainmoduleTx)
                    .HasMaxLength(50)
                    .HasColumnName("MAINMODULE_TX");

                entity.Property(e => e.MinnoTx)
                    .IsRequired()
                    .HasMaxLength(26)
                    .HasColumnName("MINNO_TX");

                entity.Property(e => e.SequencenoTx)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("SEQUENCENO_TX");
            });

            modelBuilder.Entity<GbaseErrorCode>(entity =>
            {
                entity.HasKey(e => e.ErrorCode);

                entity.ToTable("GBase_ErrorCode");

                entity.Property(e => e.ErrorCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_CODE");

                entity.Property(e => e.Message)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.ShortDesc)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_DESC");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<GbaseRateConversionByCcyPair>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GBase_rate_conversion_by_CCY_pair");

                entity.Property(e => e.Ccy1)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY1");

                entity.Property(e => e.Ccy2)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY2");

                entity.Property(e => e.DealType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Deal_type");
            });

            modelBuilder.Entity<GbaseReferenceNo>(entity =>
            {
                entity.HasKey(e => new { e.DealTypeCode, e.ReferenceCode })
                    .HasName("PK_GBASE_Reference_Number");

                entity.ToTable("GBase_ReferenceNo");

                entity.Property(e => e.DealTypeCode)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.ReferenceCode).HasColumnType("numeric(7, 0)");

                entity.Property(e => e.Expiry).HasColumnType("date");
            });

            modelBuilder.Entity<GbaseReferenceNoLastUsed>(entity =>
            {
                entity.HasKey(e => e.DealTypeCode);

                entity.ToTable("GBase_ReferenceNo_Last_Used");

                entity.Property(e => e.DealTypeCode)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.LastUsedReferenceCode).HasColumnType("numeric(6, 0)");
            });

            modelBuilder.Entity<GeneralisedCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GENERALISED_CODES");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ABBREVIATION");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedAmendedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_AMENDED_DATE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<GlinkQueueManagerAction>(entity =>
            {
                entity.ToTable("GlinkQueueManagerAction");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ActionObject)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuideBisRateTempl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GUIDE_BIS_RATE_TEMPL");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.DurationUnit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURATION_UNIT");

                entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");

                entity.Property(e => e.Ric)
                    .HasMaxLength(20)
                    .HasColumnName("RIC");
            });

            modelBuilder.Entity<GuideDepositRateTempl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GUIDE_DEPOSIT_RATE_TEMPL");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD");

                entity.Property(e => e.Ric)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("RIC");
            });

            modelBuilder.Entity<GuideExchangeRateTempl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GUIDE_EXCHANGE_RATE_TEMPL");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.MurexLable)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MUREX_LABLE");
            });

            modelBuilder.Entity<GuideLog>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.ToTable("GUIDE_LOG");

                entity.Property(e => e.AuditId).HasColumnName("AuditID");

                entity.Property(e => e.AuditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<GuideRevaluationRateTempl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GUIDE_REVALUATION_RATE_TEMPL");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Generator)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Market)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Maturity)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MurexLable)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MUREX_LABLE");

                entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");

                entity.Property(e => e.Ric)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RIC");

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuideSwapRateTempl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GUIDE_SWAP_RATE_TEMPL");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.DurationUnit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURATION_UNIT");

                entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");

                entity.Property(e => e.Ric)
                    .HasMaxLength(20)
                    .HasColumnName("RIC");
            });

            modelBuilder.Entity<InterbankAccountNo>(entity =>
            {
                entity.ToTable("INTERBANK_ACCOUNT_NO");

                entity.HasIndex(e => new { e.CcyCd, e.BranchNo, e.DefaultFlg }, "IX_INTERBANK_ACCOUNT_NO")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACT_CD");

                entity.Property(e => e.ActNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ACT_NO");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.CcyCd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.CustAbbr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.DefaultFlg)
                    .IsRequired()
                    .HasColumnName("Default_Flg")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Name)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.SwiftFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_FLG");

                entity.Property(e => e.SwiftId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_ID");
            });

            modelBuilder.Entity<MassApprovalInput>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("MASS_APPROVAL_INPUT");

                entity.Property(e => e.Identifier)
                    .HasColumnType("decimal(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDENTIFIER");

                entity.Property(e => e.AcuBuInd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACU_BU_IND");

                entity.Property(e => e.ApprovedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.EndTranNumber)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("END_TRAN_NUMBER");

                entity.Property(e => e.SectionCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SECTION_CODE");

                entity.Property(e => e.StartTranNumber)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("START_TRAN_NUMBER");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<MassDreamsApprovalAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASS_DREAMS_APPROVAL_ACCESS");

                entity.Property(e => e.DeptCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE");

                entity.Property(e => e.MenuOption)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MENU_OPTION");

                entity.Property(e => e.OptionDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OPTION_DESC");
            });

            modelBuilder.Entity<MassGbaseMenuAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASS_GBASE_MENU_ACCESS");

                entity.Property(e => e.ActiveInd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_IND");

                entity.Property(e => e.ApprovalFailureStatus)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_FAILURE_STATUS");

                entity.Property(e => e.ApprovalQueryStatus)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_QUERY_STATUS");

                entity.Property(e => e.ApprovalSuccessStatus)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_SUCCESS_STATUS");

                entity.Property(e => e.MassModuleFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MASS_MODULE_FLAG");

                entity.Property(e => e.MenuSection)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MENU_SECTION");

                entity.Property(e => e.ModuleId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.SectionDesc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECTION_DESC");

                entity.Property(e => e.SourceTableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TABLE_NAME");

                entity.Property(e => e.SourceTableUpdateFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TABLE_UPDATE_FLAG");

                entity.Property(e => e.UpdateColForDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_COL_FOR_DESC");

                entity.Property(e => e.UpdateColForStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_COL_FOR_STATUS");

                entity.Property(e => e.WhereColForAppBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WHERE_COL_FOR_APP_BY");

                entity.Property(e => e.WhereColForAppDt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WHERE_COL_FOR_APP_DT");

                entity.Property(e => e.WhereColForMinNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WHERE_COL_FOR_MIN_NO");

                entity.Property(e => e.WhereColForRefNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WHERE_COL_FOR_REF_NO");

                entity.Property(e => e.WhereColForTranNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WHERE_COL_FOR_TRAN_NO");
            });

            modelBuilder.Entity<MassTransaction>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.ToTable("MASS_TRANSACTION");

                entity.Property(e => e.TranId)
                    .HasColumnType("decimal(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TRAN_ID");

                entity.Property(e => e.AcuBuInd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACU_BU_IND");

                entity.Property(e => e.ApprovedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.BatchRefNo)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("BATCH_REF_NO");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.GbaseRefCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_REF_CODE");

                entity.Property(e => e.MinNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MIN_NO");

                entity.Property(e => e.ModuleId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.OperationMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION_MODE");

                entity.Property(e => e.ReapprovedOverrideBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("REAPPROVED_OVERRIDE_BY");

                entity.Property(e => e.ReapprovedOverrideDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REAPPROVED_OVERRIDE_DATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.TranNumber)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NUMBER");
            });

            modelBuilder.Entity<MassTransactionHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASS_TRANSACTION_HISTORY");

                entity.Property(e => e.AcuBuInd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACU_BU_IND");

                entity.Property(e => e.ApprovedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.BatchRefNo)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("BATCH_REF_NO");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.GbaseRefCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_REF_CODE");

                entity.Property(e => e.MinNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MIN_NO");

                entity.Property(e => e.ModuleId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.OperationMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION_MODE");

                entity.Property(e => e.ReapprovedOverrideBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("REAPPROVED_OVERRIDE_BY");

                entity.Property(e => e.ReapprovedOverrideDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REAPPROVED_OVERRIDE_DATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.TranId)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("TRAN_ID");

                entity.Property(e => e.TranNumber)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NUMBER");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MoneyMarketTicket>(entity =>
            {
                entity.HasKey(e => e.MmticketId);

                entity.ToTable("MoneyMarketTicket");

                entity.HasIndex(e => e.TicketCreatedTimestamp, "NCI_MoneyMarketTicket_TimeCreatedTimestamp");

                entity.Property(e => e.MmticketId).HasColumnName("MMTicketId");

                entity.Property(e => e.Authorised)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Broker)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brokerage).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.BuySell)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConsiderationAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ContractDate).HasColumnType("date");

                entity.Property(e => e.CounterpartyAbbreviation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CounterpartyDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CounterpartyShortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealingContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealingMethod)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Denomination).HasColumnType("decimal(15, 8)");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FaceAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.FinalDueDate).HasColumnType("date");

                entity.Property(e => e.FrontOfficeAuthorisedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrontOfficeInputBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FundType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GbaseRefNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GBaseRefNo");

                entity.Property(e => e.Gidupload).HasColumnName("GIDUpload");

                entity.Property(e => e.Ibf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IBF")
                    .IsFixedLength(true);

                entity.Property(e => e.Instrument)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.InterestRate).HasColumnType("decimal(15, 8)");

                entity.Property(e => e.InterestSet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InterestSetLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InternalRate).HasColumnType("decimal(15, 8)");

                entity.Property(e => e.IssuePrice).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerGbaseAbbreviation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IssuerGBaseAbbreviation");

                entity.Property(e => e.LegalEntity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MurexTradeId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nature)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NetInterest).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PayoutType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioBook)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioDesk)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioGroup)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrincipalAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.PrincipalAmountClosing).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.PrincipalAmountPrevious).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.RateConvention)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RolloverType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RolloverTypeLabel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SchemeNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDirectionLabel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TicketCreatedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.TicketTemplate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TransactionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Typology)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("date");

                entity.Property(e => e.WithholdingTaxAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.WithholdingTaxBearer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxBearerLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxRate).HasColumnType("decimal(15, 8)");

                entity.Property(e => e.Yield).HasColumnType("decimal(22, 8)");
            });

            modelBuilder.Entity<MoneyMarketTicketExt>(entity =>
            {
                entity.HasKey(e => e.MmticketId);

                entity.ToTable("MoneyMarketTicket_Ext");

                entity.Property(e => e.MmticketId)
                    .ValueGeneratedNever()
                    .HasColumnName("MMTicketId");

                entity.Property(e => e.AddBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddOn).HasColumnType("datetime");

                entity.Property(e => e.AuthorizeBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizeOn).HasColumnType("datetime");

                entity.Property(e => e.DeleteBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteOn).HasColumnType("datetime");

                entity.Property(e => e.DeletionStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GbaseDump)
                    .HasColumnType("text")
                    .HasColumnName("GBaseDump");

                entity.Property(e => e.GipDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.GipStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VerifyBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerifyOn).HasColumnType("datetime");

                entity.HasOne(d => d.Mmticket)
                    .WithOne(p => p.MoneyMarketTicketExt)
                    .HasForeignKey<MoneyMarketTicketExt>(d => d.MmticketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MoneyMarketTicket_Ext_MoneyMarketTicket");
            });

            modelBuilder.Entity<MsmqMessageData>(entity =>
            {
                entity.ToTable("MsmqMessageData");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MessageBody)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MessageLabel)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QueueName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsmqMessageHistoryData>(entity =>
            {
                entity.ToTable("MsmqMessageHistoryData");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MessageBody)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MessageLabel)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QueuePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionRefNo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MurexHolidayCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MUREX_HolidayCalendar");

                entity.Property(e => e.CalendarDesc)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CALENDAR_DESC");

                entity.Property(e => e.CalendarLabel)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CALENDAR_LABEL");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.HolidayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HOLIDAY_DATE");

                entity.Property(e => e.HolidayDesc)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("HOLIDAY_DESC");
            });

            modelBuilder.Entity<MurexRamSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MUREX_RAM_SUMMARY");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(27, 4)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.Kind)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("KIND");

                entity.Property(e => e.Nos).HasColumnName("NOS");
            });

            modelBuilder.Entity<MurexRateExportControl>(entity =>
            {
                entity.ToTable("MUREX_RATE_EXPORT_CONTROL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.Run).HasColumnName("RUN");
            });

            modelBuilder.Entity<MxCategory>(entity =>
            {
                entity.ToTable("MxCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MxCounterpartyType>(entity =>
            {
                entity.ToTable("MxCounterpartyType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(70);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MxCtpyTypeAttrCode>(entity =>
            {
                entity.ToTable("MxCtpyTypeAttrCode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttributeCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.CounterpartyTypeNavigation)
                    .WithMany(p => p.MxCtpyTypeAttrCodes)
                    .HasForeignKey(d => d.CounterpartyType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MxCtpyTypeAttrCode_MxCounterpartyType");

                entity.HasOne(d => d.EucCustAttributeCode)
                    .WithMany(p => p.MxCtpyTypeAttrCodes)
                    .HasForeignKey(d => new { d.AttributeCode, d.Branch })
                    .HasConstraintName("FK_MxCtpyTypeAttrCode_EucCustAttributeCode");
            });

            modelBuilder.Entity<MxCustCounterpartyType>(entity =>
            {
                entity.ToTable("MxCustCounterpartyType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CounterpartyTypeId).HasColumnName("CounterpartyTypeID");

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.HasOne(d => d.CounterpartyType)
                    .WithMany(p => p.MxCustCounterpartyTypes)
                    .HasForeignKey(d => d.CounterpartyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MxCustCounterpartyType_MxCounterpartyType");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.MxCustCounterpartyTypes)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MxCustCounterpartyType_FXFCust");
            });

            modelBuilder.Entity<MxCustCounterpartyTypeBakMurexRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MxCustCounterpartyType_Bak_MurexRelease");

                entity.Property(e => e.CounterpartyTypeId).HasColumnName("CounterpartyTypeID");

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<MxCustomerEvent>(entity =>
            {
                entity.ToTable("MxCustomerEvent");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MxCustomerStatu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MxEucBalanceEvent>(entity =>
            {
                entity.ToTable("MxEucBalanceEvent");

                entity.HasIndex(e => e.BatchNo, "NCI_MxEucBalanceEvent_BatchNo");

                entity.HasIndex(e => new { e.EventId, e.Status, e.Category }, "NCI_MxEucBalanceEvent_EventIdEtc");

                entity.HasIndex(e => new { e.GbaseReferenceNo, e.Id }, "NCI_MxEucBalanceEvent_GBaseRefNo");

                entity.Property(e => e.BorrowOrLend)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo).HasMaxLength(3);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClosingDate)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerAbbreviation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityType).HasMaxLength(11);

                entity.Property(e => e.GbaseReferenceNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GBaseReferenceNo");

                entity.Property(e => e.InitialRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaturityDate)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NominalAmount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Rates).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Revolving).HasMaxLength(3);

                entity.Property(e => e.SalesMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.TimeSent).HasColumnType("datetime");

                entity.Property(e => e.TradeDate)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TradeExternalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MxGuideCustDetail>(entity =>
            {
                entity.ToTable("MxGuideCustDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventId).HasMaxLength(50);

                entity.Property(e => e.TimeSent).HasColumnType("datetime");

                entity.HasOne(d => d.MxCustomerEventNavigation)
                    .WithMany(p => p.MxGuideCustDetails)
                    .HasForeignKey(d => d.MxCustomerEvent)
                    .HasConstraintName("FK_MxGuideCustDetail_MxCustomerEvent");

                entity.HasOne(d => d.MxCustomerStatusNavigation)
                    .WithMany(p => p.MxGuideCustDetails)
                    .HasForeignKey(d => d.MxCustomerStatus)
                    .HasConstraintName("FK_MxGuideCustDetail_MxCustomerStatus");
            });

            modelBuilder.Entity<MxGuideCustDetailBakMurexRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MxGuideCustDetail_Bak_MurexRelease");

                entity.Property(e => e.EventId).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TimeSent).HasColumnType("datetime");
            });

            modelBuilder.Entity<MxInboundEvent>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_MxInboundMessage");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.EventDate).HasColumnType("date");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageXml)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SendingSystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<MxInboundEventLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_MxInboundMessageLog");

                entity.ToTable("MxInboundEventLog");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EventId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Exception).IsUnicode(false);

                entity.Property(e => e.LogLevel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<MxInboundMessageStatu>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MxIndustryCodeSector>(entity =>
            {
                entity.HasKey(e => e.IndustryCode);

                entity.ToTable("MxIndustryCodeSector");

                entity.Property(e => e.IndustryCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IndustryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MxTaxCode>(entity =>
            {
                entity.ToTable("MxTaxCode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch).HasMaxLength(3);

                entity.Property(e => e.Code).HasMaxLength(2);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<NetWrixAuditError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK_NetWrix_ErrorID")
                    .IsClustered(false);

                entity.ToTable("NetWrix_audit_errors");

                entity.HasIndex(e => e.ErrorTime, "NetWrixErrorTimeClustered")
                    .IsClustered();

                entity.HasIndex(e => e.MessageId, "NetWrixMessageIDNonClustered");

                entity.Property(e => e.ErrorId)
                    .HasColumnName("ErrorID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasDefaultValueSql("(app_name())");

                entity.Property(e => e.DataBaseName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(db_name())");

                entity.Property(e => e.ErrorTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Workstation)
                    .IsRequired()
                    .HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<ObsBasisExportMapping>(entity =>
            {
                entity.ToTable("OBS_Basis_Export_Mapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Generator)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Market)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Maturity)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MurexCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MUREX_CCY");

                entity.Property(e => e.ObsCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OBS_CCY");

                entity.Property(e => e.ObsYieldMaturity)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OBS_YIELD_MATURITY");

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObsBasisRate>(entity =>
            {
                entity.ToTable("OBS_BASIS_RATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ask)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("ASK");

                entity.Property(e => e.Bid)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("BID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Mid)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("MID");

                entity.Property(e => e.ObsCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OBS_CCY");

                entity.Property(e => e.ObsYieldMaturity)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OBS_YIELD_MATURITY");
            });

            modelBuilder.Entity<ObsYieldExportMapping>(entity =>
            {
                entity.ToTable("OBS_Yield_Export_Mapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Generator)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Market)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Maturity)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MurexCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MUREX_CCY");

                entity.Property(e => e.ObsCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OBS_CCY");

                entity.Property(e => e.ObsYieldCurveType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OBS_YIELD_CURVE_TYPE");

                entity.Property(e => e.ObsYieldMaturity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OBS_YIELD_MATURITY");

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObsYieldFutureMaturity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OBS_Yield_Future_Maturity");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.ContractName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Maturity).HasColumnType("date");

                entity.Property(e => e.MurexMaturityLable)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObsYieldRate>(entity =>
            {
                entity.ToTable("OBS_YIELD_RATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ask)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("ASK");

                entity.Property(e => e.Bid)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("BID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Mid)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("MID");

                entity.Property(e => e.ObsCcy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OBS_CCY");

                entity.Property(e => e.ObsYieldCurveType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OBS_YIELD_CURVE_TYPE");

                entity.Property(e => e.ObsYieldMaturity)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OBS_YIELD_MATURITY");
            });

            modelBuilder.Entity<PasswordHistory>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Password, e.PwdChangeDt });

                entity.ToTable("PASSWORD_HISTORY");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.PwdChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("PWD_CHANGE_DT");

                entity.Property(e => e.SecurityFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SECURITY_FLAG");
            });

            modelBuilder.Entity<PaymentControlAccordConfirmation>(entity =>
            {
                entity.HasKey(e => e.AccordConfirmationId);

                entity.ToTable("PaymentControl_AccordConfirmation");

                entity.Property(e => e.A20sendersReference)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("A20SendersReference");

                entity.Property(e => e.A21ncontractNumber)
                    .HasMaxLength(255)
                    .HasColumnName("A21NContractNumber");

                entity.Property(e => e.A22aoperationType)
                    .HasMaxLength(255)
                    .HasColumnName("A22AOperationType");

                entity.Property(e => e.A22btypeOfEvent)
                    .HasMaxLength(255)
                    .HasColumnName("A22BTypeOfEvent");

                entity.Property(e => e.A82apartyA)
                    .HasMaxLength(255)
                    .HasColumnName("A82APartyA");

                entity.Property(e => e.A83funds)
                    .HasMaxLength(255)
                    .HasColumnName("A83Funds");

                entity.Property(e => e.A87apartyB)
                    .HasMaxLength(255)
                    .HasColumnName("A87APartyB");

                entity.Property(e => e.A94aoperationScope)
                    .HasMaxLength(255)
                    .HasColumnName("A94AOperationScope");

                entity.Property(e => e.ArchivalDate).HasColumnType("datetime");

                entity.Property(e => e.B132bboughtAmt)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("B132BBoughtAmt");

                entity.Property(e => e.B132bboughtCcy)
                    .HasMaxLength(255)
                    .HasColumnName("B132BBoughtCcy");

                entity.Property(e => e.B153deliveryAgent)
                    .HasMaxLength(255)
                    .HasColumnName("B153DeliveryAgent");

                entity.Property(e => e.B156intermediary)
                    .HasMaxLength(255)
                    .HasColumnName("B156Intermediary");

                entity.Property(e => e.B157receivingAgent)
                    .HasMaxLength(255)
                    .HasColumnName("B157ReceivingAgent");

                entity.Property(e => e.B17rpartyAsRole)
                    .HasMaxLength(255)
                    .HasColumnName("B17RPartyAsRole");

                entity.Property(e => e.B233bsoldAmt)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("B233BSoldAmt");

                entity.Property(e => e.B233bsoldCcy)
                    .HasMaxLength(255)
                    .HasColumnName("B233BSoldCcy");

                entity.Property(e => e.B253deliveryAgent)
                    .HasMaxLength(255)
                    .HasColumnName("B253DeliveryAgent");

                entity.Property(e => e.B256intermediary)
                    .HasMaxLength(255)
                    .HasColumnName("B256Intermediary");

                entity.Property(e => e.B257receivingAgent)
                    .HasMaxLength(255)
                    .HasColumnName("B257ReceivingAgent");

                entity.Property(e => e.B258beneficiary)
                    .HasMaxLength(255)
                    .HasColumnName("B258Beneficiary");

                entity.Property(e => e.B30pmaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("B30PMaturityDate");

                entity.Property(e => e.B30ttradeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("B30TTradeDate");

                entity.Property(e => e.B30vvalueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("B30VValueDate");

                entity.Property(e => e.B30xnextInterestDate)
                    .HasColumnType("datetime")
                    .HasColumnName("B30XNextInterestDate");

                entity.Property(e => e.B32bprincipalAmount)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("B32BPrincipalAmount");

                entity.Property(e => e.B32bprincipalCcy)
                    .HasMaxLength(255)
                    .HasColumnName("B32BPrincipalCcy");

                entity.Property(e => e.B32hsettlementAmount)
                    .HasMaxLength(255)
                    .HasColumnName("B32HSettlementAmount");

                entity.Property(e => e.B34einterestAmount)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("B34EInterestAmount");

                entity.Property(e => e.B36exchangeRate)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("B36ExchangeRate");

                entity.Property(e => e.B37ginterestRate)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("B37GInterestRate");

                entity.Property(e => e.C56intermediaryPartyA)
                    .HasMaxLength(255)
                    .HasColumnName("C56IntermediaryPartyA");

                entity.Property(e => e.C57receivingAgentPartyA)
                    .HasMaxLength(255)
                    .HasColumnName("C57ReceivingAgentPartyA");

                entity.Property(e => e.ConfirmationType).HasMaxLength(255);

                entity.Property(e => e.Counterparty).HasMaxLength(255);

                entity.Property(e => e.CounterpartyBic)
                    .HasMaxLength(255)
                    .HasColumnName("CounterpartyBIC");

                entity.Property(e => e.CounterpartyFirstTransactionId).HasMaxLength(255);

                entity.Property(e => e.CounterpartyFirstUtinamespace)
                    .HasMaxLength(255)
                    .HasColumnName("CounterpartyFirstUTINamespace");

                entity.Property(e => e.CounterpartyReport).HasMaxLength(255);

                entity.Property(e => e.CounterpartyTrn)
                    .HasMaxLength(255)
                    .HasColumnName("CounterpartyTRN");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.D56intermediaryPartyB)
                    .HasMaxLength(255)
                    .HasColumnName("D56IntermediaryPartyB");

                entity.Property(e => e.D57receivingAgentPartyB)
                    .HasMaxLength(255)
                    .HasColumnName("D57ReceivingAgentPartyB");

                entity.Property(e => e.DealChangeDate).HasColumnType("datetime");

                entity.Property(e => e.DealStatus).HasMaxLength(255);

                entity.Property(e => e.DealStatusDate).HasColumnType("datetime");

                entity.Property(e => e.Direction).HasMaxLength(255);

                entity.Property(e => e.E56intermediaryInterestPartyA)
                    .HasMaxLength(255)
                    .HasColumnName("E56IntermediaryInterestPartyA");

                entity.Property(e => e.E57receivingAgentInterestPartyA)
                    .HasMaxLength(255)
                    .HasColumnName("E57ReceivingAgentInterestPartyA");

                entity.Property(e => e.Entity).HasMaxLength(255);

                entity.Property(e => e.ErrorWarning).HasMaxLength(255);

                entity.Property(e => e.F56intermediaryInterestPartyB)
                    .HasMaxLength(255)
                    .HasColumnName("F56IntermediaryInterestPartyB");

                entity.Property(e => e.F57receivingAgentInterestPartyB)
                    .HasMaxLength(255)
                    .HasColumnName("F57ReceivingAgentInterestPartyB");

                entity.Property(e => e.FirstTransactionId).HasMaxLength(255);

                entity.Property(e => e.FirstUtinamespace)
                    .HasMaxLength(255)
                    .HasColumnName("FirstUTINamespace");

                entity.Property(e => e.IsLocked).HasMaxLength(255);

                entity.Property(e => e.IsTagged).HasMaxLength(255);

                entity.Property(e => e.ItemStatus).HasMaxLength(255);

                entity.Property(e => e.LastInChain).HasMaxLength(255);

                entity.Property(e => e.LockedBy).HasMaxLength(255);

                entity.Property(e => e.ManuallyMatched).HasMaxLength(255);

                entity.Property(e => e.MatchingComments).HasMaxLength(255);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.NumberOfChasersSent).HasMaxLength(255);

                entity.Property(e => e.NumberOfLinks).HasMaxLength(255);

                entity.Property(e => e.NumberOfPairs).HasMaxLength(255);

                entity.Property(e => e.TaggedTo).HasMaxLength(255);

                entity.Property(e => e.ThirdParty).HasMaxLength(255);

                entity.Property(e => e.ThirdPartyStatus).HasMaxLength(255);

                entity.Property(e => e.TypeOfLinks).HasMaxLength(255);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(255);

                entity.Property(e => e.UserStatus).HasMaxLength(255);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlAccordConfirmations)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_AccordConfirmation_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlMatchFx>(entity =>
            {
                entity.HasKey(e => e.MatchFxid);

                entity.ToTable("PaymentControl_MatchFX");

                entity.HasIndex(e => e.GbaseRefNo, "NCI_PaymentControl_MatchFX_GBaseRefNo");

                entity.HasIndex(e => e.Processed, "NCI_PaymentControl_MatchFX_Processed");

                entity.Property(e => e.MatchFxid).HasColumnName("MatchFXId");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GbaseRefNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("GBaseRefNo");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlMatchFxes)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_MatchFX_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlMatchMoneyMarket>(entity =>
            {
                entity.HasKey(e => e.MatchMoneyMarketId);

                entity.ToTable("PaymentControl_MatchMoneyMarket");

                entity.HasIndex(e => e.Processed, "NCI_PaymentControl_MatchMoneyMarket_Processed");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GbaseRefNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GBaseRefNo");

                entity.Property(e => e.MmticketId).HasColumnName("MMTicketId");

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlMatchMoneyMarkets)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_MatchMoneyMarket_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlMisysConfirmation>(entity =>
            {
                entity.HasKey(e => e.MisysConfirmationId);

                entity.ToTable("PaymentControl_MisysConfirmation");

                entity.Property(e => e.BuyAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.BuyCcy).HasMaxLength(50);

                entity.Property(e => e.BuyReceivingAgent).HasMaxLength(255);

                entity.Property(e => e.Counterparty).HasMaxLength(50);

                entity.Property(e => e.DealType).HasMaxLength(50);

                entity.Property(e => e.DmStatus).HasMaxLength(50);

                entity.Property(e => e.FinStatus).HasMaxLength(50);

                entity.Property(e => e.Fund).HasMaxLength(255);

                entity.Property(e => e.InstStatus).HasMaxLength(50);

                entity.Property(e => e.IntAmt).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.IntCurr).HasMaxLength(50);

                entity.Property(e => e.InterestRate).HasMaxLength(255);

                entity.Property(e => e.MaturityDate).HasColumnType("datetime");

                entity.Property(e => e.PartyAsRole).HasMaxLength(50);

                entity.Property(e => e.PrincipleAmt).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.PrincipleCurr).HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ReferenceNum).HasMaxLength(20);

                entity.Property(e => e.RelatedRefNo).HasMaxLength(50);

                entity.Property(e => e.SellAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.SellCcy).HasMaxLength(50);

                entity.Property(e => e.SellReceivingAgent).HasMaxLength(255);

                entity.Property(e => e.TradeDate).HasColumnType("datetime");

                entity.Property(e => e.TypeOfOprn).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWho).HasMaxLength(255);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlMisysConfirmations)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_MisysConfirmation_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("PaymentControl_Payment");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerAbbreviation)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GbaseRefNo)
                    .HasMaxLength(20)
                    .HasColumnName("GBaseRefNo");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.PaymentCurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("date");

                entity.Property(e => e.WaitingAckNack)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WaitingConfirmation)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WaitingPayment)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WaitingSwiftPayment)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ProductReference)
                    .WithMany(p => p.PaymentControlPayments)
                    .HasForeignKey(d => d.ProductReferenceId)
                    .HasConstraintName("FK_PaymentControl_Payment_PaymentControl_ProductReference");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PaymentControlPayments)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_PaymentControl_Payment_PaymentControl_Status");
            });

            modelBuilder.Entity<PaymentControlPaymentLog>(entity =>
            {
                entity.HasKey(e => e.PaymentLogId);

                entity.ToTable("PaymentControl_PaymentLog");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.When).HasColumnType("datetime");

                entity.Property(e => e.Who).HasMaxLength(1024);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlPaymentLogs)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentControl_PaymentLog_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("PaymentControl_Product");

                entity.HasIndex(e => e.Code, "UQ_PaymentControl_Product_Code")
                    .IsUnique();

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentControlProductReference>(entity =>
            {
                entity.HasKey(e => e.ProductReferenceId);

                entity.ToTable("PaymentControl_ProductReference");

                entity.HasIndex(e => e.Code, "UQ_PaymentControl_ProductReference_Code")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PaymentControlProductReferences)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentControl_ProductReference_PaymentControl_Product");
            });

            modelBuilder.Entity<PaymentControlRemittance>(entity =>
            {
                entity.HasKey(e => e.RemittanceId);

                entity.ToTable("PaymentControl_Remittance");

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.AccountWithBank1).HasMaxLength(50);

                entity.Property(e => e.AccountWithBankAc)
                    .HasMaxLength(50)
                    .HasColumnName("AccountWithBankAC");

                entity.Property(e => e.AccountWithBankSbic)
                    .HasMaxLength(50)
                    .HasColumnName("AccountWithBankSBIC");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ApplicationNo).HasMaxLength(50);

                entity.Property(e => e.BeneficiaryAccount).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomerAbbreviation).HasMaxLength(50);

                entity.Property(e => e.CustomerAccount).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.DeleteDate).HasMaxLength(50);

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.DetailsOfChgs).HasMaxLength(50);

                entity.Property(e => e.ExRate).HasMaxLength(50);

                entity.Property(e => e.GbaseRefNo)
                    .HasMaxLength(20)
                    .HasColumnName("GBaseRefNo");

                entity.Property(e => e.InstructedAmount).HasMaxLength(50);

                entity.Property(e => e.InstructedCurrency).HasMaxLength(50);

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.NostroId).HasMaxLength(50);

                entity.Property(e => e.NostroName).HasMaxLength(1024);

                entity.Property(e => e.PendingNo).HasMaxLength(50);

                entity.Property(e => e.PendingReason).HasMaxLength(50);

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate");

                entity.Property(e => e.ReceivingBankSbic)
                    .HasMaxLength(50)
                    .HasColumnName("ReceivingBankSBIC");

                entity.Property(e => e.RemarkSupportingDoc).HasMaxLength(50);

                entity.Property(e => e.RemarkTypeofApp).HasMaxLength(50);

                entity.Property(e => e.RemarksEuc)
                    .HasMaxLength(50)
                    .HasColumnName("RemarksEUC");

                entity.Property(e => e.RemitterBeneficiary1).HasMaxLength(50);

                entity.Property(e => e.RemitterBeneficiary2).HasMaxLength(50);

                entity.Property(e => e.SenderToReceiverInfo1).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("date");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlRemittances)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_Remittance_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlRtgsSwiftCodeTranslation>(entity =>
            {
                entity.HasKey(e => e.RtgsSwiftCodeTranslationId);

                entity.ToTable("PaymentControl_RtgsSwiftCodeTranslation");

                entity.Property(e => e.Bsb).HasMaxLength(1024);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(1024);

                entity.Property(e => e.RtgsBic).HasMaxLength(1024);

                entity.Property(e => e.SwiftCode).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentControlStatu>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("PaymentControl_Status");

                entity.HasIndex(e => e.Abbreviation, "UQ_PaymentControl_Status_Abbreviation")
                    .IsUnique();

                entity.Property(e => e.Abbreviation).IsRequired();

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentControlSwiftAck>(entity =>
            {
                entity.HasKey(e => e.SwiftAckId);

                entity.ToTable("PaymentControl_SwiftAck");

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BeneficiaryCustomerBank).HasMaxLength(1024);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Group).HasMaxLength(50);

                entity.Property(e => e.HostMessageNo).HasMaxLength(50);

                entity.Property(e => e.MessageNo).HasMaxLength(50);

                entity.Property(e => e.MessageType).HasMaxLength(50);

                entity.Property(e => e.Mx)
                    .HasMaxLength(50)
                    .HasColumnName("MX");

                entity.Property(e => e.OurRefNo).HasMaxLength(50);

                entity.Property(e => e.OutgoingStatus).HasMaxLength(50);

                entity.Property(e => e.ReceiverBankCode1).HasMaxLength(50);

                entity.Property(e => e.ReceiverBankCode2).HasMaxLength(50);

                entity.Property(e => e.ReceiverBankName).HasMaxLength(1024);

                entity.Property(e => e.ReceiverBranchCity).HasMaxLength(1024);

                entity.Property(e => e.ReceiverSwiftAddress).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SectionName).HasMaxLength(50);

                entity.Property(e => e.SectionNo).HasMaxLength(50);

                entity.Property(e => e.SendDate).HasColumnType("date");

                entity.Property(e => e.TheirRefNo).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlSwiftAcks)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_SwiftAck_PaymentControl_Payment");

                entity.HasOne(d => d.SwiftPayment)
                    .WithMany(p => p.PaymentControlSwiftAcks)
                    .HasForeignKey(d => d.SwiftPaymentId)
                    .HasConstraintName("FK_PaymentControl_SwiftAck_PaymentControl_SwiftPayment");
            });

            modelBuilder.Entity<PaymentControlSwiftPayment>(entity =>
            {
                entity.HasKey(e => e.SwiftPaymentId);

                entity.ToTable("PaymentControl_SwiftPayment");

                entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.BeneficiaryAccount).HasMaxLength(50);

                entity.Property(e => e.BeneficiaryCustomer).HasMaxLength(50);

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.GbaseRefNo)
                    .HasMaxLength(20)
                    .HasColumnName("GBaseRefNo");

                entity.Property(e => e.MessageType).HasMaxLength(50);

                entity.Property(e => e.Payment).HasColumnType("ntext");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.ReceiverBank).HasMaxLength(50);

                entity.Property(e => e.SenderBank).HasMaxLength(50);

                entity.Property(e => e.StatusIdUpdatedWho).HasMaxLength(50);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.HasOne(d => d.PaymentNavigation)
                    .WithMany(p => p.PaymentControlSwiftPayments)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_SwiftPayment_PaymentControl_Payment");

                entity.HasOne(d => d.ProductReference)
                    .WithMany(p => p.PaymentControlSwiftPayments)
                    .HasForeignKey(d => d.ProductReferenceId)
                    .HasConstraintName("FK_PaymentControl_SwiftPayment_PaymentControl_ProductReference");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PaymentControlSwiftPayments)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_PaymentControl_SwiftPayment_PaymentControl_Status");
            });

            modelBuilder.Entity<PaymentControlSwiftPaymentLog>(entity =>
            {
                entity.HasKey(e => e.SwiftPaymentLogId);

                entity.ToTable("PaymentControl_SwiftPaymentLog");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(1024);

                entity.Property(e => e.UpdatedWhen).HasColumnType("datetime");

                entity.Property(e => e.UpdatedWho).HasMaxLength(50);

                entity.Property(e => e.When).HasColumnType("datetime");

                entity.Property(e => e.Who).HasMaxLength(1024);

                entity.HasOne(d => d.SwiftPayment)
                    .WithMany(p => p.PaymentControlSwiftPaymentLogs)
                    .HasForeignKey(d => d.SwiftPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentControl_SwiftPaymentLog_PaymentControl_SwiftPayment");
            });

            modelBuilder.Entity<RacfSystemId>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.SystemId });

                entity.ToTable("RACF_SYSTEM_ID");

                entity.Property(e => e.IdType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ID_TYPE");

                entity.Property(e => e.SystemId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SYSTEM_ID");

                entity.Property(e => e.ChangedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CHANGED_BY");

                entity.Property(e => e.ChangedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGED_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.PwdCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PWD_CREATE_DATE");

                entity.Property(e => e.RacfPreviousPwd)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("RACF_PREVIOUS_PWD");

                entity.Property(e => e.RacfStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RACF_STATUS_CODE");
            });

            modelBuilder.Entity<RacfSystemIdHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RACF_SYSTEM_ID_HISTORY");

                entity.Property(e => e.IdType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ID_TYPE");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.PwdCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PWD_CREATE_DATE");

                entity.Property(e => e.SystemId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SYSTEM_ID");
            });

            modelBuilder.Entity<RamBaseRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RAM_BASE_RECORDS");

                entity.Property(e => e.ApprovedAmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("APPROVED_AMT");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.DeletedAmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DELETED_AMT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Kind)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KIND");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESS_DATE");

                entity.Property(e => e.RamTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RAM_TYPE_CODE");

                entity.Property(e => e.RecDeleted).HasColumnName("REC_DELETED");

                entity.Property(e => e.RecTotal).HasColumnName("REC_TOTAL");
            });

            modelBuilder.Entity<RamGbaseTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RAM_GBASE_TOTAL");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.DeleteTotal).HasColumnName("DELETE_TOTAL");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESS_DATE");

                entity.Property(e => e.Total).HasColumnName("TOTAL");
            });

            modelBuilder.Entity<RamReconSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RAM_RECON_SUMMARY");

                entity.Property(e => e.Branch)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.Comparefkey)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPAREFKEY");

                entity.Property(e => e.Comparerkey)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPARERKEY");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.FxalmAmt)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("FXALM_AMT");

                entity.Property(e => e.FxalmCount).HasColumnName("FXALM_COUNT");

                entity.Property(e => e.FxalmFormattedAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FXALM_FORMATTED_AMT");

                entity.Property(e => e.GbaseApprovedAmt)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("GBASE_APPROVED_AMT");

                entity.Property(e => e.GbaseDeleteTotal).HasColumnName("GBASE_DELETE_TOTAL");

                entity.Property(e => e.GbaseFormattedAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_FORMATTED_AMT");

                entity.Property(e => e.GbaseTotal).HasColumnName("GBASE_TOTAL");

                entity.Property(e => e.GuideAmount)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("GUIDE_AMOUNT");

                entity.Property(e => e.GuideFormattedAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GUIDE_FORMATTED_AMT");

                entity.Property(e => e.GuideNos).HasColumnName("GUIDE_NOS");

                entity.Property(e => e.Kind)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KIND");

                entity.Property(e => e.RamTypeCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RAM_TYPE_CODE");
            });

            modelBuilder.Entity<RatesGbaseUploadCriteria>(entity =>
            {
                entity.HasKey(e => new { e.RateType, e.Ccy });

                entity.ToTable("RATES_GBASE_UPLOAD_CRITERIA");

                entity.Property(e => e.RateType)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("RATE_TYPE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.AcuFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACU_FLAG");

                entity.Property(e => e.BuFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BU_FLAG");

                entity.Property(e => e.CriteriaType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRITERIA_TYPE");
            });

            modelBuilder.Entity<RatesGbaseUploadCtl>(entity =>
            {
                entity.HasKey(e => new { e.RateType, e.OprDate, e.Ccy });

                entity.ToTable("RATES_GBASE_UPLOAD_CTL");

                entity.Property(e => e.RateType)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("RATE_TYPE");

                entity.Property(e => e.OprDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OPR_DATE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.AcuStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACU_STATUS")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.AcuTransStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACU_TRANS_STATUS")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BuStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BU_STATUS")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.BuTransStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BU_TRANS_STATUS")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.GbaseMsg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_MSG");

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADED_BY");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AcuStatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACU_STATUS_CODE");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_STATUS");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.BuStatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BU_STATUS_CODE");

                entity.Property(e => e.CreatedAmendedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_AMENDED_BY");

                entity.Property(e => e.CreatedAmendedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_AMENDED_DATE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EMPLOYEE_NO");

                entity.Property(e => e.EnabledInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_IND");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.GbaseModiDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GBASE_MODI_DATE");

                entity.Property(e => e.GbasePreviousPwd)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_PREVIOUS_PWD");

                entity.Property(e => e.GbasePwdAcuStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_PWD_ACU_STATUS_CODE");

                entity.Property(e => e.GbasePwdBuStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_PWD_BU_STATUS_CODE");

                entity.Property(e => e.GbasePwdStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_PWD_STATUS_CODE");

                entity.Property(e => e.GbaseRegDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GBASE_REG_DATE");

                entity.Property(e => e.GbaseStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_STATUS_CODE");

                entity.Property(e => e.GbaseUploadedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GBASE_UPLOADED_DATE");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.MasterId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_ID");

                entity.Property(e => e.NoOfLoginAttempts)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("NO_OF_LOGIN_ATTEMPTS");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OPERATOR_ID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.ProfileEditedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE_EDITED_BY");

                entity.Property(e => e.ProfileEditedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROFILE_EDITED_DATE");

                entity.Property(e => e.PwdChangeInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PWD_CHANGE_IND");

                entity.Property(e => e.PwdCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PWD_CREATE_DATE");

                entity.Property(e => e.RacfPreviousPwd)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("RACF_PREVIOUS_PWD");

                entity.Property(e => e.RacfStatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RACF_STATUS_CODE");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RANK_CODE");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS");

                entity.Property(e => e.ResetBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("RESET_BY");

                entity.Property(e => e.ResetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RESET_DATE");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.SgIdentifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("SG_IDENTIFIER");

                entity.Property(e => e.SubDeptCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SUB_DEPT_CODE");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.UserProfileStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_PROFILE_STATUS");
            });

            modelBuilder.Entity<RevaluationRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Days });

                entity.ToTable("REVALUATION_RATE");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Days).HasColumnName("DAYS");

                entity.Property(e => e.GbaseMsg)
                    .HasMaxLength(78)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_MSG");

                entity.Property(e => e.ImportedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IMPORTED_BY");

                entity.Property(e => e.ImportedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("IMPORTED_TIME");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("RATE");

                entity.Property(e => e.RecStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RmbDefault>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RMB_Default");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.DefultFlg)
                    .HasColumnName("defult_flg")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RateToUse).HasColumnName("Rate_to_Use");
            });

            modelBuilder.Entity<SecurityGroup>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("SECURITY_GROUPS");

                entity.Property(e => e.Identifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("IDENTIFIER");

                entity.Property(e => e.CreatedAmendedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_AMENDED_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EnabledInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_IND");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<SecurityGroupFunction>(entity =>
            {
                entity.HasKey(e => new { e.SgIdentifier, e.SfIdentifier });

                entity.ToTable("SECURITY_GROUP_FUNCTIONS");

                entity.Property(e => e.SgIdentifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("SG_IDENTIFIER");

                entity.Property(e => e.SfIdentifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("SF_IDENTIFIER");
            });

            modelBuilder.Entity<SettlementCorpCustDefault>(entity =>
            {
                entity.HasKey(e => e.CorpCustId);

                entity.ToTable("SETTLEMENT_CORP_CUST_DEFAULT");

                entity.HasIndex(e => new { e.BranchNo, e.RecordKind, e.CcyAbbr, e.RecSettlCode, e.DefaultFlg }, "IX_SETTLEMENT_CORP_CUST_DEFAULT")
                    .IsUnique();

                entity.Property(e => e.CorpCustId).HasColumnName("CORP_CUST_ID");

                entity.Property(e => e.AccBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BANK_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdviceRecFlg)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADVICE_REC_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AdviceRecLimit)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("ADVICE_REC_LIMIT");

                entity.Property(e => e.BeneBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BENE_BANK_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO")
                    .HasDefaultValueSql("(751)");

                entity.Property(e => e.CcyAbbr)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.DefaultFlg)
                    .IsRequired()
                    .HasColumnName("DEFAULT_FLG")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IntermediaryBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("INTERMEDIARY_BANK_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderingBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ORDERING_BANK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderingCustomer)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ORDERING_CUSTOMER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayActCd)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_CD");

                entity.Property(e => e.PayActNo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayMessageType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PAY_MESSAGE_TYPE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayMethod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_METHOD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayRmtFlg)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_RMT_FLG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaySettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SETTL_CODE");

                entity.Property(e => e.PriortyFlg)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PRIORTY_FLG")
                    .HasDefaultValueSql("(2)");

                entity.Property(e => e.RecActCd)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_CD");

                entity.Property(e => e.RecActNo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_BANK_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecCorres)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_CORRES")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecMessageType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REC_MESSAGE_TYPE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecMethod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_METHOD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecRmtFlg)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_RMT_FLG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecSettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_SETTL_CODE");

                entity.Property(e => e.RecordKind)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_KIND")
                    .HasDefaultValueSql("(2)");

                entity.Property(e => e.SenderCorres)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SENDER_CORRES")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<SettlementCorpCustDefault2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SETTLEMENT_CORP_CUST_DEFAULT_2");

                entity.Property(e => e.AccBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BANK_ID");

                entity.Property(e => e.AdviceRecFlg)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADVICE_REC_FLG");

                entity.Property(e => e.AdviceRecLimit)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("ADVICE_REC_LIMIT");

                entity.Property(e => e.BeneBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BENE_BANK_ID");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyAbbr)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.CorpCustId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CORP_CUST_ID");

                entity.Property(e => e.DefaultFlg).HasColumnName("DEFAULT_FLG");

                entity.Property(e => e.IntermediaryBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("INTERMEDIARY_BANK_ID");

                entity.Property(e => e.OrderingBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ORDERING_BANK");

                entity.Property(e => e.OrderingCustomer)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ORDERING_CUSTOMER");

                entity.Property(e => e.PayActCd)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_CD");

                entity.Property(e => e.PayActNo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_NO");

                entity.Property(e => e.PayMessageType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PAY_MESSAGE_TYPE");

                entity.Property(e => e.PayMethod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_METHOD");

                entity.Property(e => e.PayRmtFlg)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_RMT_FLG");

                entity.Property(e => e.PaySettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SETTL_CODE");

                entity.Property(e => e.PriortyFlg)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PRIORTY_FLG");

                entity.Property(e => e.RecActCd)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_CD");

                entity.Property(e => e.RecActNo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_NO");

                entity.Property(e => e.RecBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_BANK_ID");

                entity.Property(e => e.RecCorres)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_CORRES");

                entity.Property(e => e.RecMessageType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REC_MESSAGE_TYPE");

                entity.Property(e => e.RecMethod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_METHOD");

                entity.Property(e => e.RecRmtFlg)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_RMT_FLG");

                entity.Property(e => e.RecSettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_SETTL_CODE");

                entity.Property(e => e.RecordKind)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_KIND");

                entity.Property(e => e.SenderCorres)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SENDER_CORRES");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<SettlementInf>(entity =>
            {
                entity.HasKey(e => e.SifId);

                entity.ToTable("SETTLEMENT_INF");

                entity.HasIndex(e => new { e.BranchNo, e.CustAbbr, e.CcyCd, e.RecordKind }, "IX_SETTLEMENT_INF")
                    .IsUnique();

                entity.Property(e => e.SifId).HasColumnName("SIF_ID");

                entity.Property(e => e.AccBankActno)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BANK_ACTNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BANK_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AdviceRecFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADVICE_REC_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AdviceRecLimit)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("ADVICE_REC_LIMIT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.BankFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANK_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BankInf)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BANK_INF")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankInfFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANK_INF_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BeneBankActno)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("BENE_BANK_ACTNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BENE_BANK_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO")
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.CcyCd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.ConfirmationFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMATION_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ConfirmationSwiftId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMATION_SWIFT_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoverPoFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COVER_PO_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CustAbbr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELETE_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GIP_DESCRIPTION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IntermediaryBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("INTERMEDIARY_BANK_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFY_ON")
                    .HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.OcnnectFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OCNNECT_FLG")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OpeDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("OPE_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayActNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PAY_MESSAGE_TYPE")
                    .HasDefaultValueSql("('202')");

                entity.Property(e => e.PayMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_METHOD")
                    .HasDefaultValueSql("('SW')");

                entity.Property(e => e.PayRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_RMT_FLG")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.PaySettlCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SETTL_CODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PriortyFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PRIORTY_FLG")
                    .HasDefaultValueSql("('02')");

                entity.Property(e => e.RecActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecActNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankBrActno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REC_BANK_BR_ACTNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankHoActno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REC_BANK_HO_ACTNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_BANK_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecCustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_CUST_ABBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REC_MESSAGE_TYPE")
                    .HasDefaultValueSql("('210')");

                entity.Property(e => e.RecMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_METHOD")
                    .HasDefaultValueSql("('SW')");

                entity.Property(e => e.RecRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_RMT_FLG")
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.RecSettlCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_SETTL_CODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordKind)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_KIND");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SettlementInterbankDefault>(entity =>
            {
                entity.HasKey(e => e.InterbankId);

                entity.ToTable("SETTLEMENT_INTERBANK_DEFAULT");

                entity.HasIndex(e => new { e.RecordKind, e.CcyCd, e.DefaultFlg }, "IX_SETTLEMENT_INTERBANK_DEFAULT")
                    .IsUnique();

                entity.Property(e => e.InterbankId).HasColumnName("INTERBANK_ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdviceRecFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADVICE_REC_FLG");

                entity.Property(e => e.AdviceRecLimit)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("ADVICE_REC_LIMIT");

                entity.Property(e => e.BankFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANK_FLG");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.CoverPoFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COVER_PO_FLG");

                entity.Property(e => e.DefaultFlg)
                    .IsRequired()
                    .HasColumnName("DEFAULT_FLG")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ObuAccountNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OBU_ACCOUNT_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_CD");

                entity.Property(e => e.PayMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PAY_MESSAGE_TYPE");

                entity.Property(e => e.PayMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_METHOD");

                entity.Property(e => e.PayRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_RMT_FLG");

                entity.Property(e => e.PaySettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SETTL_CODE");

                entity.Property(e => e.PriortyFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PRIORTY_FLG");

                entity.Property(e => e.RecActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_CD");

                entity.Property(e => e.RecBankId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_BANK_ID");

                entity.Property(e => e.RecMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REC_MESSAGE_TYPE");

                entity.Property(e => e.RecMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_METHOD");

                entity.Property(e => e.RecRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_RMT_FLG");

                entity.Property(e => e.RecSettlCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_SETTL_CODE");

                entity.Property(e => e.RecordKind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_KIND");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<ShipUploadingHistory>(entity =>
            {
                entity.HasKey(e => e.UploadingId);

                entity.ToTable("SHIP_UPLOADING_HISTORY");

                entity.Property(e => e.UploadingId).HasColumnName("UPLOADING_ID");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.GbaseRef)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_REF");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("INSERT_DATE");

                entity.Property(e => e.Scenario)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SCENARIO");

                entity.Property(e => e.ShipMinNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SHIP_MIN_NO");

                entity.Property(e => e.ShipSeqNo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SHIP_SEQ_NO");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.TranNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NUMBER");

                entity.Property(e => e.UploadSeq)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UPLOAD_SEQ");
            });

            modelBuilder.Entity<SpotRateUsdEquiv>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy })
                    .HasName("PK_SPOT_RATE");

                entity.ToTable("SPOT_RATE_USD_EQUIV");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.ImportedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("IMPORTED_TIME");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(16, 5)")
                    .HasColumnName("RATE");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STATUS");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ShortDes)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_DES");
            });

            modelBuilder.Entity<SwapRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Duration, e.DurationUnit });

                entity.ToTable("SWAP_RATE");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_DATE");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.DurationUnit)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURATION_UNIT");

                entity.Property(e => e.BidRate)
                    .HasColumnType("decimal(16, 7)")
                    .HasColumnName("BID_RATE");

                entity.Property(e => e.ImportedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IMPORTED_BY")
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.ImportedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("IMPORTED_TIME")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OfferRate)
                    .HasColumnType("decimal(16, 7)")
                    .HasColumnName("OFFER_RATE");

                entity.Property(e => e.RecStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SystemFunction>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("SYSTEM_FUNCTIONS");

                entity.Property(e => e.Identifier)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("IDENTIFIER");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<SystemMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("SYSTEM_MESSAGES");

                entity.Property(e => e.MessageId)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MESSAGE_ID");

                entity.Property(e => e.CreatedAmendedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_AMENDED_DATE");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TEXT");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<SystemModule>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("SYSTEM_MODULES");

                entity.Property(e => e.Identifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("IDENTIFIER");

                entity.Property(e => e.CreatedAmendedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_AMENDED_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EnabledInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_IND");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<SystemModuleGroup>(entity =>
            {
                entity.HasKey(e => new { e.SmIdentifier, e.SgIdentifier });

                entity.ToTable("SYSTEM_MODULE_GROUPS");

                entity.Property(e => e.SmIdentifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("SM_IDENTIFIER");

                entity.Property(e => e.SgIdentifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("SG_IDENTIFIER");
            });

            modelBuilder.Entity<SystemParameter>(entity =>
            {
                entity.HasKey(e => e.ParamType);

                entity.ToTable("SYSTEM_PARAMETERS");

                entity.Property(e => e.ParamType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PARAM_TYPE");

                entity.Property(e => e.ParamValue)
                    .IsRequired()
                    .HasMaxLength(130)
                    .IsUnicode(false)
                    .HasColumnName("PARAM_VALUE");
            });

            modelBuilder.Entity<SystemRegistryParameter>(entity =>
            {
                entity.HasKey(e => e.ParamKey);

                entity.ToTable("SYSTEM_REGISTRY_PARAMETERS");

                entity.Property(e => e.ParamKey)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PARAM_KEY");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_FLAG");

                entity.Property(e => e.EncriptInd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENCRIPT_IND");

                entity.Property(e => e.ParamValue)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("PARAM_VALUE");
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Database)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettingGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SettingID");

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionKindAdvancedNotice>(entity =>
            {
                entity.HasKey(e => e.Instrument);

                entity.ToTable("TransactionKindAdvancedNotice");

                entity.Property(e => e.Instrument)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Actabbr)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ACTAbbr");

                entity.Property(e => e.Actname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ACTName");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ComfirmationType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Days)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LegalEntity)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Rate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RATE");

                entity.Property(e => e.TicketProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionKind)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.Typology)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionKindMoneyMarket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransactionKindMoneyMarket");

                entity.Property(e => e.AccountCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BuySell)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CounterpartyTypeRule)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MxLegalEntity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MxTypology)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Payout)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TermRule)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionKind)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionKindOverrideCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransactionKindOverrideCode");

                entity.Property(e => e.CounterpartyLabel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GbaseCustomerAbbrev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GBaseCustomerAbbrev");

                entity.Property(e => e.MxPayout)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MxTypology)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionKind)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.AcuStatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACU_STATUS_CODE");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_STATUS");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.BuStatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BU_STATUS_CODE");

                entity.Property(e => e.CreatedAmendedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_AMENDED_BY");

                entity.Property(e => e.CreatedAmendedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_AMENDED_DATE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EMPLOYEE_NO");

                entity.Property(e => e.EnabledInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_IND");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.GbaseModiDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GBASE_MODI_DATE");

                entity.Property(e => e.GbasePreviousPwd)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_PREVIOUS_PWD");

                entity.Property(e => e.GbasePwdAcuStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_PWD_ACU_STATUS_CODE");

                entity.Property(e => e.GbasePwdBuStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_PWD_BU_STATUS_CODE");

                entity.Property(e => e.GbasePwdStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_PWD_STATUS_CODE");

                entity.Property(e => e.GbaseRegDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GBASE_REG_DATE");

                entity.Property(e => e.GbaseStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_STATUS_CODE");

                entity.Property(e => e.GbaseUploadedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GBASE_UPLOADED_DATE");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.MasterId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_ID");

                entity.Property(e => e.NoOfLoginAttempts).HasColumnName("NO_OF_LOGIN_ATTEMPTS");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OPERATOR_ID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.ProfileEditedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE_EDITED_BY");

                entity.Property(e => e.ProfileEditedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROFILE_EDITED_DATE");

                entity.Property(e => e.PwdChangeInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PWD_CHANGE_IND");

                entity.Property(e => e.PwdCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PWD_CREATE_DATE");

                entity.Property(e => e.RacfPreviousPwd)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("RACF_PREVIOUS_PWD");

                entity.Property(e => e.RacfStatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RACF_STATUS_CODE");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RANK_CODE");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS");

                entity.Property(e => e.ResetBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("RESET_BY");

                entity.Property(e => e.ResetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RESET_DATE");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE");

                entity.Property(e => e.SgIdentifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("SG_IDENTIFIER");

                entity.Property(e => e.SubDeptCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SUB_DEPT_CODE");

                entity.Property(e => e.UserProfileStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_PROFILE_STATUS");
            });

            modelBuilder.Entity<UserSecurityGroup>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SgIdentifier });

                entity.ToTable("USER_SECURITY_GROUPS");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.SgIdentifier)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("SG_IDENTIFIER");
            });

            modelBuilder.Entity<UsersExt>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("USERS_Ext");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.NetworkId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsersExt)
                    .HasForeignKey<UsersExt>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERS_Ext_USERS");
            });

            modelBuilder.Entity<UsrGbaseSplTransaction>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("USR_GBASE_SPL_TRANSACTION");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.AccountSettlement)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_SETTLEMENT");

                entity.Property(e => e.ApprovalLdgrMod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_LDGR_MOD");

                entity.Property(e => e.ApprovalOfCorrection)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_OF_CORRECTION");

                entity.Property(e => e.ApprovalOfLoan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_OF_LOAN");

                entity.Property(e => e.ApprovalOfOd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_OF_OD");

                entity.Property(e => e.ApprovalOfRemittance)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_OF_REMITTANCE");

                entity.Property(e => e.ApprovalOfTmpod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_OF_TMPOD");

                entity.Property(e => e.ApprovalWarnCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_WARN_CD");

                entity.Property(e => e.EdpManager)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EDP_MANAGER");

                entity.Property(e => e.FwdValueRemittance)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FWD_VALUE_REMITTANCE");

                entity.Property(e => e.NonOnlineAcc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NON_ONLINE_ACC");

                entity.Property(e => e.Personnel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERSONNEL");

                entity.Property(e => e.ProfitManagement)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROFIT_MANAGEMENT");

                entity.Property(e => e.ReversalOfOp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REVERSAL_OF_OP");

                entity.Property(e => e.SynthLimitCont)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SYNTH_LIMIT_CONT");

                entity.Property(e => e.System)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SYSTEM");

                entity.Property(e => e.TakeInPosting)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TAKE_IN_POSTING");

                entity.Property(e => e.TransmitOfOut)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANSMIT_OF_OUT");

                entity.Property(e => e.UpdateOfMessage)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_OF_MESSAGE");

                entity.Property(e => e.WarningCdOverrd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WARNING_CD_OVERRD");
            });

            modelBuilder.Entity<VgasGeneraloperation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VGAS_GENERALOPERATION");

                entity.Property(e => e.AcubuTx)
                    .HasMaxLength(3)
                    .HasColumnName("ACUBU_TX");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(8)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.ApprovedPassword)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_PASSWORD");

                entity.Property(e => e.AvaildateDtDd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AVAILDATE_DT_DD");

                entity.Property(e => e.AvaildateDtMm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AVAILDATE_DT_MM");

                entity.Property(e => e.AvaildateDtYy)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AVAILDATE_DT_YY");

                entity.Property(e => e.BackvalueInd)
                    .HasMaxLength(1)
                    .HasColumnName("BACKVALUE_IND");

                entity.Property(e => e.BulkUploadInd)
                    .HasMaxLength(1)
                    .HasColumnName("BULK_UPLOAD_IND");

                entity.Property(e => e.Cr1AccCdTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_ACC_CD_TX");

                entity.Property(e => e.Cr1AccnumTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_ACCNUM_TX");

                entity.Property(e => e.Cr1AdviseprintTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_ADVISEPRINT_TX");

                entity.Property(e => e.Cr1AmountAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CR1_AMOUNT_AMT");

                entity.Property(e => e.Cr1AvailableDate)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_AVAILABLE_DATE");

                entity.Property(e => e.Cr1AvailableDateDdDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_AVAILABLE_DATE_DD_DT");

                entity.Property(e => e.Cr1AvailableDateDdYy)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_AVAILABLE_DATE_DD_YY");

                entity.Property(e => e.Cr1AvailableDateMmDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_AVAILABLE_DATE_MM_DT");

                entity.Property(e => e.Cr1CcyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_CCY_TX");

                entity.Property(e => e.Cr1CcyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CR1_CCY_UPLOAD");

                entity.Property(e => e.Cr1ChecknoTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_CHECKNO_TX");

                entity.Property(e => e.Cr1CustidTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_CUSTID_TX");

                entity.Property(e => e.Cr1DetailsTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_DETAILS_TX");

                entity.Property(e => e.Cr1DivisionTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_DIVISION_TX");

                entity.Property(e => e.Cr1EntityTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_ENTITY_TX");

                entity.Property(e => e.Cr1ExchrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_EXCHRATE_INT");

                entity.Property(e => e.Cr1FundTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_FUND_TX");

                entity.Property(e => e.Cr1FxccyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_FXCCY_TX");

                entity.Property(e => e.Cr1FxccyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CR1_FXCCY_UPLOAD");

                entity.Property(e => e.Cr1IbfTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_IBF_TX");

                entity.Property(e => e.Cr1InterrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_INTERRATE_INT");

                entity.Property(e => e.Cr1TypeTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CR1_TYPE_TX");

                entity.Property(e => e.Cr2AccCdTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_ACC_CD_TX");

                entity.Property(e => e.Cr2AccnumTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_ACCNUM_TX");

                entity.Property(e => e.Cr2AdviseprintTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_ADVISEPRINT_TX");

                entity.Property(e => e.Cr2AmountAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cr2_AMOUNT_AMT");

                entity.Property(e => e.Cr2AvailableDate)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_AVAILABLE_DATE");

                entity.Property(e => e.Cr2AvailableDateDdDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_AVAILABLE_DATE_DD_DT");

                entity.Property(e => e.Cr2AvailableDateDdYy)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_AVAILABLE_DATE_DD_YY");

                entity.Property(e => e.Cr2AvailableDateMmDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_AVAILABLE_DATE_MM_DT");

                entity.Property(e => e.Cr2CcyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_CCY_TX");

                entity.Property(e => e.Cr2CcyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr2_CCY_UPLOAD");

                entity.Property(e => e.Cr2ChecknoTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_CHECKNO_TX");

                entity.Property(e => e.Cr2CustidTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_CUSTID_TX");

                entity.Property(e => e.Cr2DetailsTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_DETAILS_TX");

                entity.Property(e => e.Cr2DivisionTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_DIVISION_TX");

                entity.Property(e => e.Cr2EntityTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_ENTITY_TX");

                entity.Property(e => e.Cr2ExchrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_EXCHRATE_INT");

                entity.Property(e => e.Cr2FundTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_FUND_TX");

                entity.Property(e => e.Cr2FxccyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_FXCCY_TX");

                entity.Property(e => e.Cr2FxccyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr2_FXCCY_UPLOAD");

                entity.Property(e => e.Cr2IbfTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_IBF_TX");

                entity.Property(e => e.Cr2InterrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_INTERRATE_INT");

                entity.Property(e => e.Cr2TypeTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr2_TYPE_TX");

                entity.Property(e => e.Cr3AccCdTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_ACC_CD_TX");

                entity.Property(e => e.Cr3AccnumTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_ACCNUM_TX");

                entity.Property(e => e.Cr3AdviseprintTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_ADVISEPRINT_TX");

                entity.Property(e => e.Cr3AmountAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cr3_AMOUNT_AMT");

                entity.Property(e => e.Cr3AvailableDate)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_AVAILABLE_DATE");

                entity.Property(e => e.Cr3AvailableDateDdDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_AVAILABLE_DATE_DD_DT");

                entity.Property(e => e.Cr3AvailableDateDdYy)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_AVAILABLE_DATE_DD_YY");

                entity.Property(e => e.Cr3AvailableDateMmDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_AVAILABLE_DATE_MM_DT");

                entity.Property(e => e.Cr3CcyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_CCY_TX");

                entity.Property(e => e.Cr3CcyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr3_CCY_UPLOAD");

                entity.Property(e => e.Cr3ChecknoTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_CHECKNO_TX");

                entity.Property(e => e.Cr3CustidTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_CUSTID_TX");

                entity.Property(e => e.Cr3DetailsTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_DETAILS_TX");

                entity.Property(e => e.Cr3DivisionTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_DIVISION_TX");

                entity.Property(e => e.Cr3EntityTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_ENTITY_TX");

                entity.Property(e => e.Cr3ExchrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_EXCHRATE_INT");

                entity.Property(e => e.Cr3FundTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_FUND_TX");

                entity.Property(e => e.Cr3FxccyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_FXCCY_TX");

                entity.Property(e => e.Cr3FxccyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr3_FXCCY_UPLOAD");

                entity.Property(e => e.Cr3IbfTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_IBF_TX");

                entity.Property(e => e.Cr3InterrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_INTERRATE_INT");

                entity.Property(e => e.Cr3TypeTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr3_TYPE_TX");

                entity.Property(e => e.Cr4AccCdTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_ACC_CD_TX");

                entity.Property(e => e.Cr4AccnumTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_ACCNUM_TX");

                entity.Property(e => e.Cr4AdviseprintTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_ADVISEPRINT_TX");

                entity.Property(e => e.Cr4AmountAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cr4_AMOUNT_AMT");

                entity.Property(e => e.Cr4AvailableDate)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_AVAILABLE_DATE");

                entity.Property(e => e.Cr4AvailableDateDdDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_AVAILABLE_DATE_DD_DT");

                entity.Property(e => e.Cr4AvailableDateDdYy)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_AVAILABLE_DATE_DD_YY");

                entity.Property(e => e.Cr4AvailableDateMmDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_AVAILABLE_DATE_MM_DT");

                entity.Property(e => e.Cr4CcyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_CCY_TX");

                entity.Property(e => e.Cr4CcyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr4_CCY_UPLOAD");

                entity.Property(e => e.Cr4ChecknoTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_CHECKNO_TX");

                entity.Property(e => e.Cr4CustidTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_CUSTID_TX");

                entity.Property(e => e.Cr4DetailsTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_DETAILS_TX");

                entity.Property(e => e.Cr4DivisionTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_DIVISION_TX");

                entity.Property(e => e.Cr4EntityTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_ENTITY_TX");

                entity.Property(e => e.Cr4ExchrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_EXCHRATE_INT");

                entity.Property(e => e.Cr4FundTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_FUND_TX");

                entity.Property(e => e.Cr4FxccyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_FXCCY_TX");

                entity.Property(e => e.Cr4FxccyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr4_FXCCY_UPLOAD");

                entity.Property(e => e.Cr4IbfTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_IBF_TX");

                entity.Property(e => e.Cr4InterrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_INTERRATE_INT");

                entity.Property(e => e.Cr4TypeTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr4_TYPE_TX");

                entity.Property(e => e.Cr5AccCdTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_ACC_CD_TX");

                entity.Property(e => e.Cr5AccnumTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_ACCNUM_TX");

                entity.Property(e => e.Cr5AdviseprintTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_ADVISEPRINT_TX");

                entity.Property(e => e.Cr5AmountAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cr5_AMOUNT_AMT");

                entity.Property(e => e.Cr5AvailableDate)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_AVAILABLE_DATE");

                entity.Property(e => e.Cr5AvailableDateDdDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_AVAILABLE_DATE_DD_DT");

                entity.Property(e => e.Cr5AvailableDateDdYy)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_AVAILABLE_DATE_DD_YY");

                entity.Property(e => e.Cr5AvailableDateMmDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_AVAILABLE_DATE_MM_DT");

                entity.Property(e => e.Cr5CcyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_CCY_TX");

                entity.Property(e => e.Cr5CcyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr5_CCY_UPLOAD");

                entity.Property(e => e.Cr5ChecknoTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_CHECKNO_TX");

                entity.Property(e => e.Cr5CustidTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_CUSTID_TX");

                entity.Property(e => e.Cr5DetailsTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_DETAILS_TX");

                entity.Property(e => e.Cr5DivisionTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_DIVISION_TX");

                entity.Property(e => e.Cr5EntityTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_ENTITY_TX");

                entity.Property(e => e.Cr5ExchrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_EXCHRATE_INT");

                entity.Property(e => e.Cr5FundTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_FUND_TX");

                entity.Property(e => e.Cr5FxccyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_FXCCY_TX");

                entity.Property(e => e.Cr5FxccyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr5_FXCCY_UPLOAD");

                entity.Property(e => e.Cr5IbfTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_IBF_TX");

                entity.Property(e => e.Cr5InterrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_INTERRATE_INT");

                entity.Property(e => e.Cr5TypeTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr5_TYPE_TX");

                entity.Property(e => e.Cr6AccCdTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_ACC_CD_TX");

                entity.Property(e => e.Cr6AccnumTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_ACCNUM_TX");

                entity.Property(e => e.Cr6AdviseprintTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_ADVISEPRINT_TX");

                entity.Property(e => e.Cr6AmountAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cr6_AMOUNT_AMT");

                entity.Property(e => e.Cr6AvailableDate)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_AVAILABLE_DATE");

                entity.Property(e => e.Cr6AvailableDateDdDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_AVAILABLE_DATE_DD_DT");

                entity.Property(e => e.Cr6AvailableDateDdYy)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_AVAILABLE_DATE_DD_YY");

                entity.Property(e => e.Cr6AvailableDateMmDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_AVAILABLE_DATE_MM_DT");

                entity.Property(e => e.Cr6CcyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_CCY_TX");

                entity.Property(e => e.Cr6CcyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr6_CCY_UPLOAD");

                entity.Property(e => e.Cr6ChecknoTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_CHECKNO_TX");

                entity.Property(e => e.Cr6CustidTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_CUSTID_TX");

                entity.Property(e => e.Cr6DetailsTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_DETAILS_TX");

                entity.Property(e => e.Cr6DivisionTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_DIVISION_TX");

                entity.Property(e => e.Cr6EntityTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_ENTITY_TX");

                entity.Property(e => e.Cr6ExchrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_EXCHRATE_INT");

                entity.Property(e => e.Cr6FundTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_FUND_TX");

                entity.Property(e => e.Cr6FxccyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_FXCCY_TX");

                entity.Property(e => e.Cr6FxccyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr6_FXCCY_UPLOAD");

                entity.Property(e => e.Cr6IbfTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_IBF_TX");

                entity.Property(e => e.Cr6InterrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_INTERRATE_INT");

                entity.Property(e => e.Cr6TypeTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr6_TYPE_TX");

                entity.Property(e => e.Cr7AccCdTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_ACC_CD_TX");

                entity.Property(e => e.Cr7AccnumTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_ACCNUM_TX");

                entity.Property(e => e.Cr7AdviseprintTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_ADVISEPRINT_TX");

                entity.Property(e => e.Cr7AmountAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cr7_AMOUNT_AMT");

                entity.Property(e => e.Cr7AvailableDate)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_AVAILABLE_DATE");

                entity.Property(e => e.Cr7AvailableDateDdDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_AVAILABLE_DATE_DD_DT");

                entity.Property(e => e.Cr7AvailableDateDdYy)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_AVAILABLE_DATE_DD_YY");

                entity.Property(e => e.Cr7AvailableDateMmDt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_AVAILABLE_DATE_MM_DT");

                entity.Property(e => e.Cr7CcyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_CCY_TX");

                entity.Property(e => e.Cr7CcyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr7_CCY_UPLOAD");

                entity.Property(e => e.Cr7ChecknoTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_CHECKNO_TX");

                entity.Property(e => e.Cr7CustidTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_CUSTID_TX");

                entity.Property(e => e.Cr7DetailsTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_DETAILS_TX");

                entity.Property(e => e.Cr7DivisionTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_DIVISION_TX");

                entity.Property(e => e.Cr7EntityTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_ENTITY_TX");

                entity.Property(e => e.Cr7ExchrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_EXCHRATE_INT");

                entity.Property(e => e.Cr7FundTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_FUND_TX");

                entity.Property(e => e.Cr7FxccyTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_FXCCY_TX");

                entity.Property(e => e.Cr7FxccyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cr7_FXCCY_UPLOAD");

                entity.Property(e => e.Cr7IbfTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_IBF_TX");

                entity.Property(e => e.Cr7InterrateInt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_INTERRATE_INT");

                entity.Property(e => e.Cr7TypeTx)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("cr7_TYPE_TX");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(8)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(8)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_DATE");

                entity.Property(e => e.DeletedPassword)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_PASSWORD");

                entity.Property(e => e.DeletionInd)
                    .HasMaxLength(1)
                    .HasColumnName("DELETION_IND");

                entity.Property(e => e.DescriptionTx)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION_TX");

                entity.Property(e => e.DrAccCdTx)
                    .HasMaxLength(5)
                    .HasColumnName("DR_ACC_CD_TX");

                entity.Property(e => e.DrAccnumTx)
                    .HasMaxLength(12)
                    .HasColumnName("DR_ACCNUM_TX");

                entity.Property(e => e.DrAdviseprintTx)
                    .HasMaxLength(1)
                    .HasColumnName("DR_ADVISEPRINT_TX");

                entity.Property(e => e.DrAmountAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DR_AMOUNT_AMT");

                entity.Property(e => e.DrCcyTx)
                    .HasMaxLength(4)
                    .HasColumnName("DR_CCY_TX");

                entity.Property(e => e.DrCcyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DR_CCY_UPLOAD");

                entity.Property(e => e.DrChecknoTx)
                    .HasMaxLength(10)
                    .HasColumnName("DR_CHECKNO_TX");

                entity.Property(e => e.DrCustidTx)
                    .HasMaxLength(12)
                    .HasColumnName("DR_CUSTID_TX");

                entity.Property(e => e.DrDetailsTx)
                    .HasMaxLength(30)
                    .HasColumnName("DR_DETAILS_TX");

                entity.Property(e => e.DrDivisionTx)
                    .HasMaxLength(2)
                    .HasColumnName("DR_DIVISION_TX");

                entity.Property(e => e.DrEntityTx)
                    .HasMaxLength(3)
                    .HasColumnName("DR_ENTITY_TX");

                entity.Property(e => e.DrExchrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DR_EXCHRATE_INT");

                entity.Property(e => e.DrFxccyTx)
                    .HasMaxLength(4)
                    .HasColumnName("DR_FXCCY_TX");

                entity.Property(e => e.DrFxccyUpload)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DR_FXCCY_UPLOAD");

                entity.Property(e => e.DrIbfTx)
                    .HasMaxLength(1)
                    .HasColumnName("DR_IBF_TX");

                entity.Property(e => e.DrInterrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DR_INTERRATE_INT");

                entity.Property(e => e.DreamsRefCode)
                    .HasMaxLength(12)
                    .HasColumnName("DREAMS_REF_CODE");

                entity.Property(e => e.EncryptInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENCRYPT_IND");

                entity.Property(e => e.ExportedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPORTED_DT");

                entity.Property(e => e.FundTx)
                    .HasMaxLength(1)
                    .HasColumnName("FUND_TX");

                entity.Property(e => e.GroupnoTx)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("GROUPNO_TX");

                entity.Property(e => e.HostName)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("HOST_NAME");

                entity.Property(e => e.LastEditedBy)
                    .HasMaxLength(8)
                    .HasColumnName("LAST_EDITED_BY");

                entity.Property(e => e.LastEditedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_EDITED_DATE");

                entity.Property(e => e.MinNo)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MIN_NO");

                entity.Property(e => e.ReasonTx)
                    .HasMaxLength(30)
                    .HasColumnName("REASON_TX");

                entity.Property(e => e.RemarksTx)
                    .HasMaxLength(30)
                    .HasColumnName("REMARKS_TX");

                entity.Property(e => e.ReversedBy)
                    .HasMaxLength(8)
                    .HasColumnName("REVERSED_BY");

                entity.Property(e => e.ReversedPassword)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("REVERSED_PASSWORD");

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_DESC");

                entity.Property(e => e.StatusInt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STATUS_INT");

                entity.Property(e => e.TranType)
                    .HasMaxLength(1)
                    .HasColumnName("TRAN_TYPE");

                entity.Property(e => e.TransnoTx)
                    .HasMaxLength(5)
                    .HasColumnName("TRANSNO_TX");

                entity.Property(e => e.TypeTx)
                    .HasMaxLength(2)
                    .HasColumnName("TYPE_TX");

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(8)
                    .HasColumnName("UPLOADED_BY");

                entity.Property(e => e.UploadedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPLOADED_DATE");

                entity.Property(e => e.UploadedPassword)
                    .HasMaxLength(68)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADED_PASSWORD");

                entity.Property(e => e.Userid)
                    .HasMaxLength(8)
                    .HasColumnName("USERID");

                entity.Property(e => e.ValuedateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("VALUEDATE_DT");

                entity.Property(e => e.ValuedateDtDd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VALUEDATE_DT_DD");

                entity.Property(e => e.ValuedateDtMm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VALUEDATE_DT_MM");

                entity.Property(e => e.ValuedateDtYy)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VALUEDATE_DT_YY");
            });

            modelBuilder.Entity<VgasSelectwebgastransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VGAS_SELECTWEBGASTRANSACTIONS");

                entity.Property(e => e.AccCdTx)
                    .HasMaxLength(5)
                    .HasColumnName("ACC_CD_TX");

                entity.Property(e => e.AccnumTx)
                    .HasMaxLength(12)
                    .HasColumnName("ACCNUM_TX");

                entity.Property(e => e.AcubuTx)
                    .HasMaxLength(3)
                    .HasColumnName("ACUBU_TX");

                entity.Property(e => e.AdviseprintTx)
                    .HasMaxLength(1)
                    .HasColumnName("ADVISEPRINT_TX");

                entity.Property(e => e.AmountAmt)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNT_AMT");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(8)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.AvailableDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_DATE");

                entity.Property(e => e.BackvalueInd)
                    .HasMaxLength(1)
                    .HasColumnName("BACKVALUE_IND");

                entity.Property(e => e.BulkUploadInd)
                    .HasMaxLength(1)
                    .HasColumnName("BULK_UPLOAD_IND");

                entity.Property(e => e.CcyTx)
                    .HasMaxLength(4)
                    .HasColumnName("CCY_TX");

                entity.Property(e => e.ChecknoTx)
                    .HasMaxLength(10)
                    .HasColumnName("CHECKNO_TX");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(8)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.CustidTx)
                    .HasMaxLength(12)
                    .HasColumnName("CUSTID_TX");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(8)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_DATE");

                entity.Property(e => e.DeletionInd)
                    .HasMaxLength(1)
                    .HasColumnName("DELETION_IND");

                entity.Property(e => e.DescriptionTx)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION_TX");

                entity.Property(e => e.DetailsTx)
                    .HasMaxLength(30)
                    .HasColumnName("DETAILS_TX");

                entity.Property(e => e.DivisionTx)
                    .HasMaxLength(2)
                    .HasColumnName("DIVISION_TX");

                entity.Property(e => e.DreamsRefCode)
                    .HasMaxLength(12)
                    .HasColumnName("DREAMS_REF_CODE");

                entity.Property(e => e.EntityTx)
                    .HasMaxLength(3)
                    .HasColumnName("ENTITY_TX");

                entity.Property(e => e.ExchrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("EXCHRATE_INT");

                entity.Property(e => e.FundTx)
                    .HasMaxLength(1)
                    .HasColumnName("FUND_TX");

                entity.Property(e => e.FxccyTx)
                    .HasMaxLength(4)
                    .HasColumnName("FXCCY_TX");

                entity.Property(e => e.GroupnoTx)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("GROUPNO_TX");

                entity.Property(e => e.IbfTx)
                    .HasMaxLength(1)
                    .HasColumnName("IBF_TX");

                entity.Property(e => e.InterrateInt)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("INTERRATE_INT");

                entity.Property(e => e.LastEditedBy)
                    .HasMaxLength(8)
                    .HasColumnName("LAST_EDITED_BY");

                entity.Property(e => e.LastEditedDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("LAST_EDITED_DATE");

                entity.Property(e => e.MinNo)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MIN_NO");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ReasonTx)
                    .HasMaxLength(30)
                    .HasColumnName("REASON_TX");

                entity.Property(e => e.RecordType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_TYPE");

                entity.Property(e => e.RectypeTx)
                    .HasMaxLength(1)
                    .HasColumnName("RECTYPE_TX");

                entity.Property(e => e.RemarksTx)
                    .HasMaxLength(30)
                    .HasColumnName("REMARKS_TX");

                entity.Property(e => e.ReversedBy)
                    .HasMaxLength(8)
                    .HasColumnName("REVERSED_BY");

                entity.Property(e => e.ReversedDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REVERSED_DATE");

                entity.Property(e => e.SeqNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SEQ_NO");

                entity.Property(e => e.StatusCodeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CODE_DESC");

                entity.Property(e => e.StatusInt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STATUS_INT");

                entity.Property(e => e.TranType)
                    .HasMaxLength(1)
                    .HasColumnName("TRAN_TYPE");

                entity.Property(e => e.TransnoTx)
                    .HasMaxLength(5)
                    .HasColumnName("TRANSNO_TX");

                entity.Property(e => e.TypeTx)
                    .HasMaxLength(2)
                    .HasColumnName("TYPE_TX");

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(8)
                    .HasColumnName("UPLOADED_BY");

                entity.Property(e => e.UploadedDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADED_DATE");

                entity.Property(e => e.ValuedateDt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("VALUEDATE_DT");
            });

            modelBuilder.Entity<ViewEucBankInfPrepare1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_EUC_BANK_INF_PREPARE1");

                entity.Property(e => e.Acronym)
                    .HasMaxLength(6)
                    .HasColumnName("ACRONYM");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.ChapsSortCd)
                    .HasMaxLength(6)
                    .HasColumnName("CHAPS_SORT_CD");

                entity.Property(e => e.ChipsAba)
                    .HasMaxLength(4)
                    .HasColumnName("CHIPS_ABA");

                entity.Property(e => e.ChipsUid)
                    .HasMaxLength(6)
                    .HasColumnName("CHIPS_UID");

                entity.Property(e => e.CorBankCd)
                    .HasMaxLength(7)
                    .HasColumnName("COR_BANK_CD");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.FedId)
                    .HasMaxLength(9)
                    .HasColumnName("FED_ID");

                entity.Property(e => e.LocationCountry)
                    .HasMaxLength(2)
                    .HasColumnName("LOCATION_COUNTRY");

                entity.Property(e => e.MhcbBrAbbr)
                    .HasMaxLength(2)
                    .HasColumnName("MHCB_BR_ABBR");

                entity.Property(e => e.NameAddr1)
                    .HasMaxLength(35)
                    .HasColumnName("NAME_ADDR_1");

                entity.Property(e => e.NameAddr2)
                    .HasMaxLength(35)
                    .HasColumnName("NAME_ADDR_2");

                entity.Property(e => e.NameAddr3)
                    .HasMaxLength(35)
                    .HasColumnName("NAME_ADDR_3");

                entity.Property(e => e.NameAddr4)
                    .HasMaxLength(35)
                    .HasColumnName("NAME_ADDR_4");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.SettlBranchNo)
                    .HasMaxLength(3)
                    .HasColumnName("SETTL_BRANCH_NO");

                entity.Property(e => e.SwiftFlg)
                    .HasMaxLength(1)
                    .HasColumnName("SWIFT_FLG");

                entity.Property(e => e.SwiftId)
                    .HasMaxLength(11)
                    .HasColumnName("SWIFT_ID");
            });

            modelBuilder.Entity<ViewEucBankInfPrepare2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_EUC_BANK_INF_PREPARE2");

                entity.Property(e => e.Acronym)
                    .HasMaxLength(6)
                    .HasColumnName("ACRONYM");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.ChapsSortCd)
                    .HasMaxLength(6)
                    .HasColumnName("CHAPS_SORT_CD");

                entity.Property(e => e.ChipsAba)
                    .HasMaxLength(4)
                    .HasColumnName("CHIPS_ABA");

                entity.Property(e => e.ChipsUid)
                    .HasMaxLength(6)
                    .HasColumnName("CHIPS_UID");

                entity.Property(e => e.CorBankCd)
                    .HasMaxLength(7)
                    .HasColumnName("COR_BANK_CD");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.FedId)
                    .HasMaxLength(9)
                    .HasColumnName("FED_ID");

                entity.Property(e => e.LocationCountry)
                    .HasMaxLength(2)
                    .HasColumnName("LOCATION_COUNTRY");

                entity.Property(e => e.MhcbBrAbbr)
                    .HasMaxLength(2)
                    .HasColumnName("MHCB_BR_ABBR");

                entity.Property(e => e.NameAddr1)
                    .HasMaxLength(35)
                    .HasColumnName("NAME_ADDR_1");

                entity.Property(e => e.NameAddr2)
                    .HasMaxLength(35)
                    .HasColumnName("NAME_ADDR_2");

                entity.Property(e => e.NameAddr3)
                    .HasMaxLength(35)
                    .HasColumnName("NAME_ADDR_3");

                entity.Property(e => e.NameAddr4)
                    .HasMaxLength(35)
                    .HasColumnName("NAME_ADDR_4");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.SettlBranchNo)
                    .HasMaxLength(3)
                    .HasColumnName("SETTL_BRANCH_NO");

                entity.Property(e => e.SwiftFlg)
                    .HasMaxLength(1)
                    .HasColumnName("SWIFT_FLG");

                entity.Property(e => e.SwiftId)
                    .HasMaxLength(11)
                    .HasColumnName("SWIFT_ID");
            });

            modelBuilder.Entity<ViewEucCcyCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_EUC_CCY_CODE");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyAbbr)
                    .HasMaxLength(4)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.CcyName)
                    .HasMaxLength(25)
                    .HasColumnName("CCY_NAME");

                entity.Property(e => e.DecimalPoint)
                    .HasMaxLength(1)
                    .HasColumnName("DECIMAL_POINT");

                entity.Property(e => e.DkbSpecialRateJpy)
                    .HasColumnType("decimal(9, 5)")
                    .HasColumnName("DKB_SPECIAL_RATE_JPY");

                entity.Property(e => e.DkbSpecialRateUsd)
                    .HasColumnType("decimal(8, 6)")
                    .HasColumnName("DKB_SPECIAL_RATE_USD");

                entity.Property(e => e.Mark3Cd)
                    .HasMaxLength(4)
                    .HasColumnName("MARK3_CD");

                entity.Property(e => e.StepsCd)
                    .HasMaxLength(2)
                    .HasColumnName("STEPS_CD");

                entity.Property(e => e.SwiftCd)
                    .HasMaxLength(3)
                    .HasColumnName("SWIFT_CD");
            });

            modelBuilder.Entity<ViewFxsystemCreditparent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_ FXSYSTEM_CREDITPARENT");

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CorpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustTypeId).HasColumnName("CustType_ID");

                entity.Property(e => e.DepositAlm).HasColumnName("DepositALM");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ibosno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IBOSNo");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SamedayFx).HasColumnName("SamedayFX");
            });

            modelBuilder.Entity<ViewGipFxTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_GIP_FX_TRANSACTION");

                entity.Property(e => e.AccountEntry)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_ENTRY");

                entity.Property(e => e.AccrualFrom)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ACCRUAL_FROM");

                entity.Property(e => e.AccrualTo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ACCRUAL_TO");

                entity.Property(e => e.ActAbbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ACT_ABBR");

                entity.Property(e => e.ActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACT_CD");

                entity.Property(e => e.AddBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY");

                entity.Property(e => e.AddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ADD_ON");

                entity.Property(e => e.Addressee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESSEE");

                entity.Property(e => e.AuthorizeBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY");

                entity.Property(e => e.AuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AUTHORIZE_ON");

                entity.Property(e => e.Authorized)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZED");

                entity.Property(e => e.Bank).HasColumnName("bank");

                entity.Property(e => e.Banktobankinf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANKTOBANKINF");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.Broker)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BROKER");

                entity.Property(e => e.CcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.Code56)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE56");

                entity.Property(e => e.Code57)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE57");

                entity.Property(e => e.Code57a)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE57A");

                entity.Property(e => e.Code58)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE58");

                entity.Property(e => e.ContractCcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_CCY_ABBR");

                entity.Property(e => e.ContractCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("CONTRACT_CCY_AMT");

                entity.Property(e => e.ContractCcyBal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("CONTRACT_CCY_BAL");

                entity.Property(e => e.ContractCcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_CCY_CD");

                entity.Property(e => e.ContractCcyTtb)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("CONTRACT_CCY_TTB");

                entity.Property(e => e.ContractDateOpe)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CONTRACT_DATE_OPE");

                entity.Property(e => e.ContractDateValue)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CONTRACT_DATE_VALUE");

                entity.Property(e => e.CoverPoFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COVER_PO_FLG");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE");

                entity.Property(e => e.Dealer)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEALER");

                entity.Property(e => e.Dealno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DEALNO");

                entity.Property(e => e.Dealtype)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEALTYPE");

                entity.Property(e => e.DelivaryDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVARY_DATE");

                entity.Property(e => e.DelivaryThru)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVARY_THRU");

                entity.Property(e => e.DivisionCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DIVISION_CD");

                entity.Property(e => e.EquivCcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EQUIV_CCY_ABBR");

                entity.Property(e => e.EquivCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_AMT");

                entity.Property(e => e.EquivCcyBal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_BAL");

                entity.Property(e => e.EquivCcyCd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EQUIV_CCY_CD");

                entity.Property(e => e.EquivCcyTtb)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("EQUIV_CCY_TTB");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("EXCHANGE_RATE");

                entity.Property(e => e.ExecutionRefNo1)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("EXECUTION_REF_NO");

                entity.Property(e => e.Executionrefno).HasColumnName("EXECUTIONREFNO");

                entity.Property(e => e.GbaseContractAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_CONTRACT_AMT");

                entity.Property(e => e.GbaseDeliveryContractAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_DELIVERY_CONTRACT_AMT");

                entity.Property(e => e.GbaseEquivCcyAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_EQUIV_CCY_AMT");

                entity.Property(e => e.GipDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GIP_DESCRIPTION");

                entity.Property(e => e.GipStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GIP_STATUS");

                entity.Property(e => e.IbfId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IBF_ID");

                entity.Property(e => e.InternalRate)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("INTERNAL_RATE");

                entity.Property(e => e.OperationId).HasColumnName("OPERATION_ID");

                entity.Property(e => e.Optionsflag).HasColumnName("OPTIONSFLAG");

                entity.Property(e => e.PayAccBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACC_BANK");

                entity.Property(e => e.PayActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_CD");

                entity.Property(e => e.PayActNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_NO");

                entity.Property(e => e.PayAdviceRecFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ADVICE_REC_FLG");

                entity.Property(e => e.PayBeneficiary)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAY_BENEFICIARY");

                entity.Property(e => e.PayCustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAY_CUST_ABBR");

                entity.Property(e => e.PayHoFavorMt202)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_HO_FAVOR_MT202");

                entity.Property(e => e.PayIntermediaryBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAY_INTERMEDIARY_BANK");

                entity.Property(e => e.PayKihyoIrai)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_KIHYO_IRAI");

                entity.Property(e => e.PayMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PAY_MESSAGE_TYPE");

                entity.Property(e => e.PayMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_METHOD");

                entity.Property(e => e.PayOrderingCustomer)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ORDERING_CUSTOMER");

                entity.Property(e => e.PayOtherCr)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("PAY_OTHER_CR");

                entity.Property(e => e.PayOtherDr)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("PAY_OTHER_DR");

                entity.Property(e => e.PayOtherMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_OTHER_METHOD");

                entity.Property(e => e.PayOtherRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_OTHER_RMT_FLG");

                entity.Property(e => e.PayPaymentDetails1)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("PAY_PAYMENT_DETAILS1");

                entity.Property(e => e.PayPaymentDetails2)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("PAY_PAYMENT_DETAILS2");

                entity.Property(e => e.PayPaymentDetails3)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("PAY_PAYMENT_DETAILS3");

                entity.Property(e => e.PayPaymentDetails4)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("PAY_PAYMENT_DETAILS4");

                entity.Property(e => e.PayPriortyFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_PRIORTY_FLG");

                entity.Property(e => e.PayRecBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAY_REC_BANK");

                entity.Property(e => e.PayReceiverCorres)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAY_RECEIVER_CORRES");

                entity.Property(e => e.PayRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAY_RMT_FLG");

                entity.Property(e => e.PaySenderCorres)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SENDER_CORRES");

                entity.Property(e => e.PaySettlCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SETTL_CODE");

                entity.Property(e => e.RecActCd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_CD");

                entity.Property(e => e.RecActNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_NO");

                entity.Property(e => e.RecAdviceRecFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_ADVICE_REC_FLG");

                entity.Property(e => e.RecCustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_CUST_ABBR");

                entity.Property(e => e.RecHoFavorMt202)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_HO_FAVOR_MT202");

                entity.Property(e => e.RecIntermediaryBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_INTERMEDIARY_BANK");

                entity.Property(e => e.RecKihyoIrai)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_KIHYO_IRAI");

                entity.Property(e => e.RecMessageType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REC_MESSAGE_TYPE");

                entity.Property(e => e.RecMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_METHOD");

                entity.Property(e => e.RecOrderingBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_ORDERING_BANK");

                entity.Property(e => e.RecOrderingCustomer)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_ORDERING_CUSTOMER");

                entity.Property(e => e.RecOtherCr)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("REC_OTHER_CR");

                entity.Property(e => e.RecOtherDr)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("REC_OTHER_DR");

                entity.Property(e => e.RecOtherMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_OTHER_METHOD");

                entity.Property(e => e.RecOtherRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_OTHER_RMT_FLG");

                entity.Property(e => e.RecPriortyFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_PRIORTY_FLG");

                entity.Property(e => e.RecRecBank)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_REC_BANK");

                entity.Property(e => e.RecRelatedRef)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("REC_RELATED_REF");

                entity.Property(e => e.RecRmtFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_RMT_FLG");

                entity.Property(e => e.RecSettlCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_SETTL_CODE");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REF_NO");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Revise)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REVISE");

                entity.Property(e => e.SchemeNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SCHEME_NO");

                entity.Property(e => e.Setinstruction)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SETINSTRUCTION");

                entity.Property(e => e.SettleTranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SETTLE_TRAN_NO");

                entity.Property(e => e.SettlementAuthorizeBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SETTLEMENT_AUTHORIZE_BY");

                entity.Property(e => e.SettlementValueDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SETTLEMENT_VALUE_DATE");

                entity.Property(e => e.Spread)
                    .HasColumnType("decimal(9, 6)")
                    .HasColumnName("SPREAD");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.StatusCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD");

                entity.Property(e => e.Subtype)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SUBTYPE");

                entity.Property(e => e.SwapRefNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SWAP_REF_NO");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO");

                entity.Property(e => e.Transcode).HasColumnName("TRANSCODE");
            });

            modelBuilder.Entity<ViewGuideCorpCustomerAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_GUIDE_CORP_CUSTOMER_ACCOUNT");

                entity.Property(e => e.ActCd)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACT_CD");

                entity.Property(e => e.ActNo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ACT_NO");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.CcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY_ABBR");

                entity.Property(e => e.CcyCd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCY_CD");

                entity.Property(e => e.CustAbbr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");
            });

            modelBuilder.Entity<ViewGuideCustomerMasterAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_GUIDE_CUSTOMER_MASTER_ALL");

                entity.Property(e => e.AddBy1)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY1");

                entity.Property(e => e.AddBy2)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ADD_BY2");

                entity.Property(e => e.Address)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS2");

                entity.Property(e => e.AttributeCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizeBy1)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY1");

                entity.Property(e => e.AuthorizeBy2)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("AUTHORIZE_BY2");

                entity.Property(e => e.Bank).HasColumnName("BANK");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CustAbbr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.CustCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE");

                entity.Property(e => e.CustId).HasColumnName("CUST_ID");

                entity.Property(e => e.CustName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.DeleteBy1)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY1");

                entity.Property(e => e.DeleteBy2)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_BY2");

                entity.Property(e => e.DeletionStatus1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS1");

                entity.Property(e => e.DeletionStatus2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETION_STATUS2");

                entity.Property(e => e.Ibosno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IBOSNO");

                entity.Property(e => e.IndustryCd)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("INDUSTRY_CD");

                entity.Property(e => e.LocationCountry)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_COUNTRY");

                entity.Property(e => e.ModifyBy1)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY1");

                entity.Property(e => e.ModifyBy2)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY2");

                entity.Property(e => e.MxName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MxStatus)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Status1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS1");

                entity.Property(e => e.Status2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS2");

                entity.Property(e => e.StatusCd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CD");

                entity.Property(e => e.TranNo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_NO");
            });

            modelBuilder.Entity<ViewGuideFxTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_GUIDE_FX_TRANSACTION");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NO");

                entity.Property(e => e.Broker)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BROKER");

                entity.Property(e => e.BuyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("BUY_AMT");

                entity.Property(e => e.BuyCcy)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BUY_CCY");

                entity.Property(e => e.ContractCcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_CCY_ABBR");

                entity.Property(e => e.ContractCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("CONTRACT_CCY_AMT");

                entity.Property(e => e.ContractCcyBal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("CONTRACT_CCY_BAL");

                entity.Property(e => e.ContractCcyTtb)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("CONTRACT_CCY_TTB");

                entity.Property(e => e.ContractDateOpe)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CONTRACT_DATE_OPE");

                entity.Property(e => e.ContractDateValue)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CONTRACT_DATE_VALUE");

                entity.Property(e => e.CustAbbr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUST_ABBR");

                entity.Property(e => e.CustCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE");

                entity.Property(e => e.DealNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Dealer)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEALER");

                entity.Property(e => e.DelivaryDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVARY_DATE");

                entity.Property(e => e.DelivaryThru)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVARY_THRU");

                entity.Property(e => e.DeliveryAddBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_ADD_BY");

                entity.Property(e => e.DeliveryAddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVERY_ADD_ON");

                entity.Property(e => e.DeliveryAuthorizeBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_AUTHORIZE_BY");

                entity.Property(e => e.DeliveryAuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVERY_AUTHORIZE_ON");

                entity.Property(e => e.DeliveryContractCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("DELIVERY_CONTRACT_CCY_AMT");

                entity.Property(e => e.DeliveryDeleteBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_DELETE_BY");

                entity.Property(e => e.DeliveryDeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVERY_DELETE_ON");

                entity.Property(e => e.DeliveryDeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_DELETION_STATUS");

                entity.Property(e => e.DeliveryEquivCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("DELIVERY_EQUIV_CCY_AMT");

                entity.Property(e => e.DeliveryGipDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_GIP_DESCRIPTION");

                entity.Property(e => e.DeliveryGipStatus)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_GIP_STATUS");

                entity.Property(e => e.DeliveryModifyBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_MODIFY_BY");

                entity.Property(e => e.DeliveryModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVERY_MODIFY_ON");

                entity.Property(e => e.DeliveryStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_STATUS");

                entity.Property(e => e.DeliveryTranNo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_TRAN_NO");

                entity.Property(e => e.DeliveryVerifyBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_VERIFY_BY");

                entity.Property(e => e.DeliveryVerifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DELIVERY_VERIFY_ON");

                entity.Property(e => e.EquivCcyAbbr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EQUIV_CCY_ABBR");

                entity.Property(e => e.EquivCcyAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_AMT");

                entity.Property(e => e.EquivCcyBal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("EQUIV_CCY_BAL");

                entity.Property(e => e.EquivCcyTtb)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("EQUIV_CCY_TTB");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("EXCHANGE_RATE");

                entity.Property(e => e.ExecutionRefNo).HasColumnName("ExecutionRefNO");

                entity.Property(e => e.Optionsflag).HasColumnName("OPTIONSFlag");

                entity.Property(e => e.PayActNo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PAY_ACT_NO");

                entity.Property(e => e.PaySettlCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SETTL_CODE");

                entity.Property(e => e.RecActNo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("REC_ACT_NO");

                entity.Property(e => e.RecSettlCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_SETTL_CODE");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REF_No");

                entity.Property(e => e.RefNum)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Num");

                entity.Property(e => e.SchemeNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Scheme_NO");

                entity.Property(e => e.SellAmt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("SELL_AMT");

                entity.Property(e => e.SellCcy)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SELL_CCY");

                entity.Property(e => e.Shortname)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("SHORTNAME");

                entity.Property(e => e.TransAddBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_ADD_BY");

                entity.Property(e => e.TransAddOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TRANS_ADD_ON");

                entity.Property(e => e.TransAuthorizeBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_AUTHORIZE_BY");

                entity.Property(e => e.TransAuthorizeOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TRANS_AUTHORIZE_ON");

                entity.Property(e => e.TransDeleteBy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_DELETE_BY");

                entity.Property(e => e.TransDeleteOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TRANS_DELETE_ON");

                entity.Property(e => e.TransDeletionStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_DELETION_STATUS");

                entity.Property(e => e.TransGipDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_GIP_DESCRIPTION");

                entity.Property(e => e.TransGipStatus)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_GIP_STATUS");

                entity.Property(e => e.TransModifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_MODIFY_BY");

                entity.Property(e => e.TransModifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TRANS_MODIFY_ON");

                entity.Property(e => e.TransStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_STATUS");

                entity.Property(e => e.TransTranNo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_TRAN_NO");

                entity.Property(e => e.TransVerifyBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_VERIFY_BY");

                entity.Property(e => e.TransVerifyOn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TRANS_VERIFY_ON");
            });

            modelBuilder.Entity<ViewMmTicketDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_MM_TICKET_DETAILS");

                entity.Property(e => e.Addresse)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Authorised)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Bic561)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC56_1");

                entity.Property(e => e.Bic571)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_1");

                entity.Property(e => e.Bic572)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_2");

                entity.Property(e => e.Bic573)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_3");

                entity.Property(e => e.Bic574)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC57_4");

                entity.Property(e => e.Bic581)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC58_1");

                entity.Property(e => e.Bic591)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_1");

                entity.Property(e => e.Bic592)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_2");

                entity.Property(e => e.Bic593)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_3");

                entity.Property(e => e.Bic594)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("BIC59_4");

                entity.Property(e => e.Broker)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brokerage).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.BuySell)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConsiderationAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.ContractDate).HasColumnType("date");

                entity.Property(e => e.CounterpartyAbbreviation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CounterpartyDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CounterpartyShortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealingContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealingMethod)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Denomination).HasColumnType("decimal(15, 8)");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FaceAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.FinalDueDate).HasColumnType("date");

                entity.Property(e => e.FrontOfficeAuthorisedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrontOfficeInputBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FundType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FxalmPartyIdentifier57)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("FXALM_PartyIdentifier57");

                entity.Property(e => e.FxalmPartyIdentifier58)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("FXALM_PartyIdentifier58");

                entity.Property(e => e.GbaseRefNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GBaseRefNo");

                entity.Property(e => e.Ibf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IBF")
                    .IsFixedLength(true);

                entity.Property(e => e.Instrument)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.InterestRate).HasColumnType("decimal(15, 8)");

                entity.Property(e => e.InterestSet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InterestSetLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InternalRate).HasColumnType("decimal(15, 8)");

                entity.Property(e => e.IssuePrice).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerGbaseAbbreviation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IssuerGBaseAbbreviation");

                entity.Property(e => e.LegalEntity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MizuhoTicketProduct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MmticketId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MMTicketId");

                entity.Property(e => e.MurexTradeId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nature)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NetInterest).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.PartyIdentifier56)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartyIdentifier57)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartyIdentifier58)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartyIdentifier59)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PayoutType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioBook)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioDesk)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioGroup)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrincipalAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.PrincipalAmountClosing).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.PrincipalAmountPrevious).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.RateConvention)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RolloverType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RolloverTypeLabel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SchemeNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDirectionLabel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstruction1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_1");

                entity.Property(e => e.SpecialInstruction2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_2");

                entity.Property(e => e.SpecialInstruction3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_3");

                entity.Property(e => e.SpecialInstruction4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SpecialInstruction_4");

                entity.Property(e => e.TicketCreatedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.TicketTemplate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDue).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TransactionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Typology)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("date");

                entity.Property(e => e.WithholdingTaxAmount).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.WithholdingTaxBearer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxBearerLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxRate).HasColumnType("decimal(15, 8)");

                entity.Property(e => e.Yield).HasColumnType("decimal(22, 8)");
            });

            modelBuilder.Entity<ViewRamReconSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_RAM_RECON_SUMMARY");

                entity.Property(e => e.Branch)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCY");

                entity.Property(e => e.Comparefkey)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPAREFKEY");

                entity.Property(e => e.Comparerkey)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPARERKEY");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.FxalmAmt)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("FXALM_AMT");

                entity.Property(e => e.FxalmCount).HasColumnName("FXALM_COUNT");

                entity.Property(e => e.FxalmFormattedAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FXALM_FORMATTED_AMT");

                entity.Property(e => e.GbaseApprovedAmt)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("GBASE_APPROVED_AMT");

                entity.Property(e => e.GbaseDeleteTotal).HasColumnName("GBASE_DELETE_TOTAL");

                entity.Property(e => e.GbaseFormattedAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GBASE_FORMATTED_AMT");

                entity.Property(e => e.GbaseTotal).HasColumnName("GBASE_TOTAL");

                entity.Property(e => e.GuideAmount)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("GUIDE_AMOUNT");

                entity.Property(e => e.GuideFormattedAmt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GUIDE_FORMATTED_AMT");

                entity.Property(e => e.GuideNos).HasColumnName("GUIDE_NOS");

                entity.Property(e => e.Kind)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KIND");

                entity.Property(e => e.RamTypeCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RAM_TYPE_CODE");
            });

            modelBuilder.Entity<ViewRatesGuideBisRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_RATES_GUIDE_BIS_RATE");

                entity.Property(e => e.BaseRate)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("BASE_RATE");

                entity.Property(e => e.BidRate)
                    .HasColumnType("decimal(23, 6)")
                    .HasColumnName("BID_RATE");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.DurationUnit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURATION_UNIT");

                entity.Property(e => e.OfferRate)
                    .HasColumnType("decimal(23, 6)")
                    .HasColumnName("OFFER_RATE");

                entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");
            });

            modelBuilder.Entity<ViewRatesGuideDepositRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_RATES_GUIDE_DEPOSIT_RATE");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(23, 6)")
                    .HasColumnName("RATE");
            });

            modelBuilder.Entity<ViewRatesGuideSwapRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_RATES_GUIDE_SWAP_RATE");

                entity.Property(e => e.BidRate)
                    .HasColumnType("decimal(23, 6)")
                    .HasColumnName("BID_RATE");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY")
                    .IsFixedLength(true);

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.DurationUnit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURATION_UNIT");

                entity.Property(e => e.OfferRate)
                    .HasColumnType("decimal(23, 6)")
                    .HasColumnName("OFFER_RATE");

                entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
