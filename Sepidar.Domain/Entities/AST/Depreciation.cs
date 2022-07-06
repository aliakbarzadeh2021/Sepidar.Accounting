using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Depreciation : BaseEntity
    {
          
 
		public Int32 DepreciationID { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; }  
 
		public Int32 LastAssetTransactionRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


