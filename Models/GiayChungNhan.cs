//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KTPMUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiayChungNhan
    {
        public string MaChungNhan { get; set; }
        public string TenChungNhan { get; set; }
        public string MaCoSoCN { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public string MaCoQuanCap { get; set; }
    
        public virtual CoQuanCapChungNhan CoQuanCapChungNhan { get; set; }
        public virtual CoSoChanNuoi CoSoChanNuoi { get; set; }
    }
}
