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
    
    public partial class i9SysPersonnelPhone
    {
        public string PhoneNumber { get; set; }
        public string PhoneType { get; set; }
        public System.Guid i9SysPersonnelPhoneID { get; set; }
        public System.Guid i9SysPersonnelID { get; set; }
    
        public virtual i9SysPersonnel i9SysPersonnel { get; set; }
    }
}
