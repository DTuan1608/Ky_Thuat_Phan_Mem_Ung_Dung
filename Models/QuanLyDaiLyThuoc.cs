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
    
    public partial class QuanLyDaiLyThuoc
    {
        public string MaQuanLy { get; set; }
        public string MaDaiLy { get; set; }
        public string MaThuoc { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual DaiLyThuoc DaiLyThuoc { get; set; }
        public virtual Thuoc Thuoc { get; set; }
    }
}
