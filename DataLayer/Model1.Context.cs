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
    
    public partial class Entities_web : DbContext
    {
        public Entities_web()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<details_slider> details_slider { get; set; }
        public virtual DbSet<feedback> feedbacks { get; set; }
        public virtual DbSet<room_booking_details> room_booking_details { get; set; }
        public virtual DbSet<room> rooms { get; set; }
        public virtual DbSet<slider> sliders { get; set; }
    }
}
