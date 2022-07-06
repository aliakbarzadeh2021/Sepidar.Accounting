using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ImportExportTemplate : BaseEntity
    {
          
 
		public Int32 ImportExportTemplateID { get; set; }  
 
		public String PersianTitle { get; set; }  
 
		public String EnglishTitle { get; set; }  
 
		public Byte[] Template { get; set; }  
 
		public Guid GUID { get; set; }  
 
		public String Type { get; set; }  
 
		public Nullable<Boolean> IsImport { get; set; } 
    }
}


