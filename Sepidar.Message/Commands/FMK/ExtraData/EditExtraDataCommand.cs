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
    public class EditExtraDataCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ExtraDataID { get; set; }  
 
		public String EntityTypeName { get; set; }  
 
		public Int32 EntityRef { get; set; }  
 
		public String UrlColumn1 { get; set; }  
 
		public String UrlColumn2 { get; set; }  
 
		public String UrlColumn3 { get; set; }  
 
		public String UrlColumn4 { get; set; }  
 
		public String UrlColumn5 { get; set; }  
 
		public String StringColumn1 { get; set; }  
 
		public String StringColumn2 { get; set; }  
 
		public String StringColumn3 { get; set; }  
 
		public String StringColumn4 { get; set; }  
 
		public String StringColumn5 { get; set; }  
 
		public String StringColumn6 { get; set; }  
 
		public String StringColumn7 { get; set; }  
 
		public String StringColumn8 { get; set; }  
 
		public String StringColumn9 { get; set; }  
 
		public String StringColumn10 { get; set; }  
 
		public String StringColumn11 { get; set; }  
 
		public String StringColumn12 { get; set; }  
 
		public String StringColumn13 { get; set; }  
 
		public String StringColumn14 { get; set; }  
 
		public String StringColumn15 { get; set; }  
 
		public String Note { get; set; }  
 
		public Nullable<DateTime> DateColumn1 { get; set; }  
 
		public Nullable<DateTime> DateColumn2 { get; set; }  
 
		public Nullable<DateTime> DateColumn3 { get; set; }  
 
		public Nullable<DateTime> DateColumn4 { get; set; }  
 
		public Nullable<DateTime> DateColumn5 { get; set; }  
 
		public Nullable<Int64> IntegerColumn1 { get; set; }  
 
		public Nullable<Int64> IntegerColumn2 { get; set; }  
 
		public Nullable<Int64> IntegerColumn3 { get; set; }  
 
		public Nullable<Int64> IntegerColumn4 { get; set; }  
 
		public Nullable<Int64> IntegerColumn5 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn1 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn2 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn3 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn4 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn5 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn6 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn7 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn8 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn9 { get; set; }  
 
		public Nullable<Decimal> DecimalColumn10 { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditExtraDataCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
