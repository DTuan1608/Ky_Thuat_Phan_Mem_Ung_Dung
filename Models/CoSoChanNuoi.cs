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
    
    public partial class CoSoChanNuoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoSoChanNuoi()
        {
            this.DongVatChanNuois = new HashSet<DongVatChanNuoi>();
            this.GiayChungNhans = new HashSet<GiayChungNhan>();
        }
    
        public string MaCoSoCN { get; set; }
        public string TenCSCN { get; set; }
        public string MaVung { get; set; }
        public string MaTCCN { get; set; }
        public string DiaChiCSCN { get; set; }
        public string MaDieuKien { get; set; }
    
        public virtual DieuKienChanNuoi DieuKienChanNuoi { get; set; }
        public virtual ToChucCaNhanChanNuoi ToChucCaNhanChanNuoi { get; set; }
        public virtual Vung Vung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DongVatChanNuoi> DongVatChanNuois { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiayChungNhan> GiayChungNhans { get; set; }
    }
}
