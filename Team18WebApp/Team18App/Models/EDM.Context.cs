﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team18App.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
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
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UsersTbl> UsersTbls { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<task> tasks { get; set; }
    }
}