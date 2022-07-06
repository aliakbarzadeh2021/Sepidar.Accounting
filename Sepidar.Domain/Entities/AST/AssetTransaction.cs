using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class AssetTransaction : BaseEntity
    {
          
 
		public Int32 AssetTransactionID { get; set; }  
 
		public Int32 TransactionType { get; set; }  
 
		public Nullable<Int32> AssetTransactionRef { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 AssetState { get; set; }  
 
		public Nullable<Int32> CostCenterDlRef { get; set; }  
 
		public Int32 AssetGroupRef { get; set; }  
 
		public Nullable<Int32> EmplacementRef { get; set; }  
 
		public Nullable<Int32> ReceiverPartyRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public DateTime ActivityDate { get; set; }  
 
		public Nullable<Int32> ActivityNumber { get; set; }  
 
		public Int32 ActivityRef { get; set; } 
    }
}


