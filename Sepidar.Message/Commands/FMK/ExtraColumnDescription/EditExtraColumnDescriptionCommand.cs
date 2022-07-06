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
    public class EditExtraColumnDescriptionCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ExtraColumnDescriptionID { get; set; }  
 
		public String EntityTypeName { get; set; }  
 
		public String UrlColumn1Description { get; set; }  
 
		public String UrlColumn2Description { get; set; }  
 
		public String UrlColumn3Description { get; set; }  
 
		public String UrlColumn4Description { get; set; }  
 
		public String UrlColumn5Description { get; set; }  
 
		public String StringColumn1Description { get; set; }  
 
		public String StringColumn2Description { get; set; }  
 
		public String StringColumn3Description { get; set; }  
 
		public String StringColumn4Description { get; set; }  
 
		public String StringColumn5Description { get; set; }  
 
		public String StringColumn6Description { get; set; }  
 
		public String StringColumn7Description { get; set; }  
 
		public String StringColumn8Description { get; set; }  
 
		public String StringColumn9Description { get; set; }  
 
		public String StringColumn10Description { get; set; }  
 
		public String StringColumn11Description { get; set; }  
 
		public String StringColumn12Description { get; set; }  
 
		public String StringColumn13Description { get; set; }  
 
		public String StringColumn14Description { get; set; }  
 
		public String StringColumn15Description { get; set; }  
 
		public String DateColumn1Description { get; set; }  
 
		public String DateColumn2Description { get; set; }  
 
		public String DateColumn3Description { get; set; }  
 
		public String DateColumn4Description { get; set; }  
 
		public String DateColumn5Description { get; set; }  
 
		public String IntegerColumn1Description { get; set; }  
 
		public String IntegerColumn2Description { get; set; }  
 
		public String IntegerColumn3Description { get; set; }  
 
		public String IntegerColumn4Description { get; set; }  
 
		public String IntegerColumn5Description { get; set; }  
 
		public String DecimalColumn1Description { get; set; }  
 
		public String DecimalColumn2Description { get; set; }  
 
		public String DecimalColumn3Description { get; set; }  
 
		public String DecimalColumn4Description { get; set; }  
 
		public String DecimalColumn5Description { get; set; }  
 
		public String DecimalColumn6Description { get; set; }  
 
		public String DecimalColumn7Description { get; set; }  
 
		public String DecimalColumn8Description { get; set; }  
 
		public String DecimalColumn9Description { get; set; }  
 
		public String DecimalColumn10Description { get; set; }  
 
		public Nullable<Int32> UrlColumn1Order { get; set; }  
 
		public Nullable<Int32> UrlColumn2Order { get; set; }  
 
		public Nullable<Int32> UrlColumn3Order { get; set; }  
 
		public Nullable<Int32> UrlColumn4Order { get; set; }  
 
		public Nullable<Int32> UrlColumn5Order { get; set; }  
 
		public Nullable<Int32> StringColumn1Order { get; set; }  
 
		public Nullable<Int32> StringColumn2Order { get; set; }  
 
		public Nullable<Int32> StringColumn3Order { get; set; }  
 
		public Nullable<Int32> StringColumn4Order { get; set; }  
 
		public Nullable<Int32> StringColumn5Order { get; set; }  
 
		public Nullable<Int32> StringColumn6Order { get; set; }  
 
		public Nullable<Int32> StringColumn7Order { get; set; }  
 
		public Nullable<Int32> StringColumn8Order { get; set; }  
 
		public Nullable<Int32> StringColumn9Order { get; set; }  
 
		public Nullable<Int32> StringColumn10Order { get; set; }  
 
		public Nullable<Int32> StringColumn11Order { get; set; }  
 
		public Nullable<Int32> StringColumn12Order { get; set; }  
 
		public Nullable<Int32> StringColumn13Order { get; set; }  
 
		public Nullable<Int32> StringColumn14Order { get; set; }  
 
		public Nullable<Int32> StringColumn15Order { get; set; }  
 
		public Nullable<Int32> DateColumn1Order { get; set; }  
 
		public Nullable<Int32> DateColumn2Order { get; set; }  
 
		public Nullable<Int32> DateColumn3Order { get; set; }  
 
		public Nullable<Int32> DateColumn4Order { get; set; }  
 
		public Nullable<Int32> DateColumn5Order { get; set; }  
 
		public Nullable<Int32> IntegerColumn1Order { get; set; }  
 
		public Nullable<Int32> IntegerColumn2Order { get; set; }  
 
		public Nullable<Int32> IntegerColumn3Order { get; set; }  
 
		public Nullable<Int32> IntegerColumn4Order { get; set; }  
 
		public Nullable<Int32> IntegerColumn5Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn1Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn2Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn3Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn4Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn5Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn6Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn7Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn8Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn9Order { get; set; }  
 
		public Nullable<Int32> DecimalColumn10Order { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditExtraColumnDescriptionCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
