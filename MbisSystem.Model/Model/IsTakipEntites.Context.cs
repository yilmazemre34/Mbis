﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MbisSystem.Model.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IsTakipEntities : DbContext
    {
        public IsTakipEntities()
            : base("name=IsTakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Isler> Islers { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}