﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NgVanDuoc2210900016.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NgVanDuoc_2210900016Entities : DbContext
    {
        public NgVanDuoc_2210900016Entities()
            : base("name=NgVanDuoc_2210900016Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NVD_SACH> NVD_SACH { get; set; }
        public virtual DbSet<NVD_TACGIA> NVD_TACGIA { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
