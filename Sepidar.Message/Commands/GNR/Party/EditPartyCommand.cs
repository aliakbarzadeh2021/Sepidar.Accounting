using Sepidar.Message.Base;
using Sepidar.Message.Extentions;
using Sepidar.Message.Validators;
using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class EditPartyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PartyId { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 SubType { get; set; }  
 
		public String Name { get; set; }  
 
		public String LastName { get; set; }  
 
		public String Name_En { get; set; }  
 
		public String LastName_En { get; set; }  
 
		public String EconomicCode { get; set; }  
 
		public String IdentificationCode { get; set; }  
 
		public String RegistrationCode { get; set; }  
 
		public String Website { get; set; }  
 
		public String Email { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public Boolean IsInBlacklist { get; set; }  
 
		public Boolean IsVendor { get; set; }  
 
		public Nullable<Int32> VendorGroupingRef { get; set; }  
 
		public Boolean IsBroker { get; set; }  
 
		public Nullable<Int32> BrokerGroupingRef { get; set; }  
 
		public Nullable<Decimal> CommissionRate { get; set; }  
 
		public Nullable<Decimal> BrokerOpeningBalance { get; set; }  
 
		public Nullable<Int32> BrokerOpeningBalanceType { get; set; }  
 
		public Boolean IsEmployee { get; set; }  
 
		public Boolean IsCustomer { get; set; }  
 
		public Nullable<Int32> SalespersonPartyRef { get; set; }  
 
		public Nullable<Decimal> DiscountRate { get; set; }  
 
		public Nullable<Decimal> MaximumCredit { get; set; }  
 
		public Nullable<Int32> CustomerGroupingRef { get; set; }  
 
		public Int32 CustomerCategoryForTax { get; set; }  
 
		public Nullable<DateTime> BirthDate { get; set; }  
 
		public Nullable<DateTime> MarriageDate { get; set; }  
 
		public Boolean HasCredit { get; set; }  
 
		public Int32 CreditCheckingType { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public String Guid { get; set; }  
 
		public Nullable<Decimal> CustomerRemaining { get; set; } 

        public void Validate()
        {
            new EditPartyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
