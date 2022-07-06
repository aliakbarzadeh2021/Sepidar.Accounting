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
    public class AddImportExportTemplateCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ImportExportTemplateID { get; set; }  
 
		public String PersianTitle { get; set; }  
 
		public String EnglishTitle { get; set; }  
 
		public Byte[] Template { get; set; }  
 
		public Guid GUID { get; set; }  
 
		public String Type { get; set; }  
 
		public Nullable<Boolean> IsImport { get; set; } 

        public void Validate()
        {
            new AddImportExportTemplateCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
