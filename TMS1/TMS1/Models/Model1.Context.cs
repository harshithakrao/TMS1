﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMS1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tmsdbEntities : DbContext
    {
        public tmsdbEntities()
            : base("name=tmsdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TM_Offence> TM_Offence { get; set; }
        public virtual DbSet<TM_OwnerDetails> TM_OwnerDetails { get; set; }
        public virtual DbSet<TM_RegDetails> TM_RegDetails { get; set; }
        public virtual DbSet<TM_UserMaster> TM_UserMaster { get; set; }
        public virtual DbSet<TM_VehicleDetails> TM_VehicleDetails { get; set; }
        public virtual DbSet<Offence_Details> Offence_Details { get; set; }
    }
}
