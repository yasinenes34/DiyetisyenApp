﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiyetisyenApp.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DiyetisyenContext : DbContext
    {
        public DiyetisyenContext()
            : base("name=DiyetisyenContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KullaniciRole> KullaniciRoles { get; set; }
        public virtual DbSet<KullaniciTable> KullaniciTables { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
}