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
    public class EditAdditionFactorCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AdditionFactorID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 SaleVolumeType { get; set; }  
 
		public Int32 Basis { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Boolean IsEffectiveOnVat { get; set; }  
 
		public Nullable<DateTime> StartDate { get; set; }  
 
		public Nullable<DateTime> EndDate { get; set; }  
 
		public Nullable<Int32> SaleTypeRef { get; set; }  
 
		public Nullable<Int32> CurrencyRef { get; set; }  
 
		public Nullable<Int32> CustomerGroupingRef { get; set; }  
 
		public Int32 SLRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditAdditionFactorCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
