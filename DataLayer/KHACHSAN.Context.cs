﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_CongTy> tb_CongTy { get; set; }
        public virtual DbSet<tb_DatPhong> tb_DatPhong { get; set; }
        public virtual DbSet<tb_DatPhong_CT> tb_DatPhong_CT { get; set; }
        public virtual DbSet<tb_DatPhong_SP> tb_DatPhong_SP { get; set; }
        public virtual DbSet<tb_DonVi> tb_DonVi { get; set; }
        public virtual DbSet<tb_LoaiPhong> tb_LoaiPhong { get; set; }
        public virtual DbSet<tb_Param> tb_Param { get; set; }
        public virtual DbSet<tb_Phong> tb_Phong { get; set; }
        public virtual DbSet<tb_Phong_ThietBi> tb_Phong_ThietBi { get; set; }
        public virtual DbSet<tb_SanPham> tb_SanPham { get; set; }
        public virtual DbSet<tb_SYS_Func> tb_SYS_Func { get; set; }
        public virtual DbSet<tb_SYS_GROUP> tb_SYS_GROUP { get; set; }
        public virtual DbSet<tb_SYS_REPORT> tb_SYS_REPORT { get; set; }
        public virtual DbSet<tb_SYS_RIGHT> tb_SYS_RIGHT { get; set; }
        public virtual DbSet<tb_SYS_RIGHT_REP> tb_SYS_RIGHT_REP { get; set; }
        public virtual DbSet<tb_SYS_USER> tb_SYS_USER { get; set; }
        public virtual DbSet<tb_Tang> tb_Tang { get; set; }
        public virtual DbSet<tb_ThietBi> tb_ThietBi { get; set; }
        public virtual DbSet<v_DATPHONG_DATPHONG_CT_PHONG> v_DATPHONG_DATPHONG_CT_PHONG { get; set; }
        public virtual DbSet<V_FUNC_SYS_RIGHT> V_FUNC_SYS_RIGHT { get; set; }
        public virtual DbSet<V_PHONGBYNGAY> V_PHONGBYNGAY { get; set; }
        public virtual DbSet<V_REP_SYS_RIGHT_REP> V_REP_SYS_RIGHT_REP { get; set; }
        public virtual DbSet<V_USER_INGROUP> V_USER_INGROUP { get; set; }
        public virtual DbSet<V_USER_NOTIN_GROUP> V_USER_NOTIN_GROUP { get; set; }
        public virtual DbSet<tb_KhachHang> tb_KhachHang { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
    
        public virtual int REP_DOANHTHU_CONGTY_NGAY(Nullable<System.DateTime> nGAYD, Nullable<System.DateTime> nGAYC, string mACTY)
        {
            var nGAYDParameter = nGAYD.HasValue ?
                new ObjectParameter("NGAYD", nGAYD) :
                new ObjectParameter("NGAYD", typeof(System.DateTime));
    
            var nGAYCParameter = nGAYC.HasValue ?
                new ObjectParameter("NGAYC", nGAYC) :
                new ObjectParameter("NGAYC", typeof(System.DateTime));
    
            var mACTYParameter = mACTY != null ?
                new ObjectParameter("MACTY", mACTY) :
                new ObjectParameter("MACTY", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("REP_DOANHTHU_CONGTY_NGAY", nGAYDParameter, nGAYCParameter, mACTYParameter);
        }
    }
}
