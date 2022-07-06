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
    public class EditElementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ElementId { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Class { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 NormalType { get; set; }  
 
		public Nullable<Int32> AccountRef { get; set; }  
 
		public Int32 DlType { get; set; }  
 
		public Nullable<Boolean> InsuranceCoverage { get; set; }  
 
		public Nullable<Boolean> Taxable { get; set; }  
 
		public Nullable<Boolean> UnrelatedToWorkingTime { get; set; }  
 
		public Nullable<Boolean> CalculateForMinWorkingTime { get; set; }  
 
		public Nullable<Int32> CalculateForMinBase { get; set; }  
 
		public Nullable<Decimal> Coefficient { get; set; }  
 
		public Nullable<Decimal> FixPoint { get; set; }  
 
		public Nullable<Int32> DenominatorsType { get; set; }  
 
		public Nullable<Decimal> Denominators { get; set; }  
 
		public Nullable<Boolean> SavingRemainder { get; set; }  
 
		public Nullable<Boolean> IsActive { get; set; }  
 
		public Int32 DisplayOrder { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Nullable<Int32> PaymentAccountRef { get; set; }  
 
		public Nullable<Int32> PaymentDlType { get; set; } 

        public void Validate()
        {
            new EditElementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
