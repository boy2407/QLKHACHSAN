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
    
    public partial class tb_CongTy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_CongTy()
        {
            this.tb_DatPhong_Phong_NgayO = new HashSet<tb_DatPhong_Phong_NgayO>();
            this.tb_DatPhong = new HashSet<tb_DatPhong>();
            this.tb_DonVi = new HashSet<tb_DonVi>();
            this.tb_KyPhong = new HashSet<tb_KyPhong>();
            this.tb_Param = new HashSet<tb_Param>();
            this.tb_SYS_USER = new HashSet<tb_SYS_USER>();
        }
    
        public string MACTY { get; set; }
        public string TENCTY { get; set; }
        public string DIENTHOAI { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        public Nullable<bool> DISABLED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DatPhong_Phong_NgayO> tb_DatPhong_Phong_NgayO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DatPhong> tb_DatPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DonVi> tb_DonVi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_KyPhong> tb_KyPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Param> tb_Param { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SYS_USER> tb_SYS_USER { get; set; }
    }
}
