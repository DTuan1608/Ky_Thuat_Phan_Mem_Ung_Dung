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
    
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            this.QuanLyDaiLyThuocs = new HashSet<QuanLyDaiLyThuoc>();
        }
    
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public Nullable<System.DateTime> HanSuDung { get; set; }
        public string MaDV { get; set; }
    
        public virtual DongVatChanNuoi DongVatChanNuoi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuanLyDaiLyThuoc> QuanLyDaiLyThuocs { get; set; }
    }
}
