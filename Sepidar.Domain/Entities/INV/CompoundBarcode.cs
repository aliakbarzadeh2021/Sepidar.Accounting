using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CompoundBarcode : BaseEntity
    {
          
 
		public Int32 CompoundBarcodeID { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String FixedPart { get; set; }  
 
		public Nullable<Int32> FixedPartStart { get; set; }  
 
		public Int32 ItemIdentifier { get; set; }  
 
		public Int32 CodeStart { get; set; }  
 
		public Nullable<Int32> CodeLength { get; set; }  
 
		public String CodeSeparator { get; set; }  
 
		public Nullable<Int32> TracingStart { get; set; }  
 
		public Nullable<Int32> TracingLength { get; set; }  
 
		public String TracingSeparator { get; set; }  
 
		public Nullable<Int32> QuantityStart { get; set; }  
 
		public Nullable<Int32> QuantityWholeLength { get; set; }  
 
		public String QuantityDecimalSeparator { get; set; }  
 
		public Nullable<Int32> QuantityDecimalLength { get; set; }  
 
		public String QuantitySeparator { get; set; }  
 
		public Nullable<Int32> SecondaryQuantityStart { get; set; }  
 
		public Nullable<Int32> SecondaryQuantityWholeLength { get; set; }  
 
		public String SecondaryQuantityDecimalSeparator { get; set; }  
 
		public Nullable<Int32> SecondaryQuantityDecimalLength { get; set; }  
 
		public String SecondaryQuantitySeparator { get; set; }  
 
		public Nullable<Int32> DescriptionStart { get; set; }  
 
		public Nullable<Int32> DescriptionLength { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


