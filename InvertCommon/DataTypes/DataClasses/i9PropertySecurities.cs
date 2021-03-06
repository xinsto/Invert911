//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invert911.InvertCommon.DataTypes.DataClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class i9PropertySecurities
    {
        public string SecuritiesTypeCode { get; set; }
        public string SecuritiesTypeText { get; set; }
        public string SerialNumber { get; set; }
        public string Denomination { get; set; }
        public string Issuer { get; set; }
        public string SecurityOwner { get; set; }
        public string DateOrSeriesYear { get; set; }
        public string MaturityDate { get; set; }
        public string CollectionStartDate { get; set; }
        public string CollectionEndDate { get; set; }
        public string SecuritiesRansomMoneyIndicatorCode { get; set; }
        public System.Guid i9PropertySecuritiesID { get; set; }
        public System.Guid i9PropertyID { get; set; }
    
        public virtual i9Property i9Property { get; set; }
    }
}
