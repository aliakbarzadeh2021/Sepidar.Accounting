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
    public class AddPersonnelCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersonnelId { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public String BirthIdentity { get; set; }  
 
		public String BirthSerial { get; set; }  
 
		public Nullable<Int32> BirthLocationRef { get; set; }  
 
		public String FatherName { get; set; }  
 
		public Int32 Nationality { get; set; }  
 
		public Int32 MarriageStatus { get; set; }  
 
		public Nullable<DateTime> StatusDate { get; set; }  
 
		public Nullable<Int32> Children { get; set; }  
 
		public Nullable<Int32> FamilyCount { get; set; }  
 
		public Int32 EducationDegree { get; set; }  
 
		public String EducationField { get; set; }  
 
		public String InsuranceNumber { get; set; }  
 
		public String SupportInsuranceNumber { get; set; }  
 
		public Nullable<Int32> InsuranceDay { get; set; }  
 
		public Int32 MilitaryStatus { get; set; }  
 
		public Nullable<Int32> BankRef { get; set; }  
 
		public Nullable<Int32> BankBranchRef { get; set; }  
 
		public Nullable<Int32> AccountTypeRef { get; set; }  
 
		public String AccountNo { get; set; }  
 
		public Int32 Sex { get; set; }  
 
		public Int32 EmployeeStatus { get; set; } 

        public void Validate()
        {
            new AddPersonnelCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
