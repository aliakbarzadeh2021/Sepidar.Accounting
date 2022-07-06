using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class UserReports : BaseEntity
    {
          
 
		public Int32 UserReportsID { get; set; }  
 
		public String Name { get; set; }  
 
		public String PersianTitle { get; set; }  
 
		public String EnglishTitle { get; set; }  
 
		public Byte[] ReportData { get; set; }  
 
		public Byte[] XMLData { get; set; }  
 
		public String ParentName { get; set; }  
 
		public Nullable<Int32> ReportMetaDataType { get; set; } 
    }
}


