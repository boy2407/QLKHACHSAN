//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_DatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_DatPhong()
        {
            this.tb_DatPhong_CT = new HashSet<tb_DatPhong_CT>();
            this.tb_DatPhong_Phong_NgayO = new HashSet<tb_DatPhong_Phong_NgayO>();
            this.tb_DatPhong_SP = new HashSet<tb_DatPhong_SP>();
        }
    
        public int IDDP { get; set; }
        public int IDKH { get; set; }
        public Nullable<System.DateTime> NGAYDAT { get; set; }
        public Nullable<System.DateTime> NGAYTRA { get; set; }
        public Nullable<double> SOTIEN { get; set; }
        public Nullable<int> SONGUOIO { get; set; }
        public int UID { get; set; }
        public string MACTY { get; set; }
        public string MADVI { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public Nullable<bool> DISABLED { get; set; }
        public Nullable<bool> THEODOAN { get; set; }
        public Nullable<bool> BOOKING { get; set; }
        public string GHICHU { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> UPDATE_BY { get; set; }
        public Nullable<bool> NHAN { get; set; }
    
        public virtual tb_CongTy tb_CongTy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DatPhong_CT> tb_DatPhong_CT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DatPhong_Phong_NgayO> tb_DatPhong_Phong_NgayO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DatPhong_SP> tb_DatPhong_SP { get; set; }
        public virtual tb_DonVi tb_DonVi { get; set; }
        public virtual tb_KhachHang tb_KhachHang { get; set; }
    }
}
