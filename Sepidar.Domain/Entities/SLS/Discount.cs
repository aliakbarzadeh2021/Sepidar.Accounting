using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Discount : BaseEntity
    {
          
 
		public Int32 DiscountID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 SaleVolumeType { get; set; }  
 
		public Int32 DiscountCalcType { get; set; }  
 
		public Int32 DiscountCalculationBasis { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public Nullable<DateTime> StartDate { get; set; }  
 
		public Nullable<DateTime> EndDate { get; set; }  
 
		public Nullable<Int32> SaleTypeRef { get; set; }  
 
		public Nullable<Int32> CurrencyRef { get; set; }  
 
		public Nullable<Int32> CustomerGroupingRef { get; set; } 
    }
}


