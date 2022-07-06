using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ImportExportTemplateDto
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


