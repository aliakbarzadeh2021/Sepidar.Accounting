using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class AssetClass : BaseEntity
    {
          
 
		public Int32 AssetClassID { get; set; }  
 
		public String Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Nullable<Int32> AssetSLRef { get; set; }  
 
		public Nullable<Int32> DepreciationSLRef { get; set; }  
 
		public Nullable<Int32> AccumulatedDepreciationSLRef { get; set; }  
 
		public Nullable<Int32> AssetClassRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


