﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Galaxie_MVC_Angular
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GalaxieDev2Entities : DbContext
    {
        public GalaxieDev2Entities()
            : base("name=GalaxieDev2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<lstFeeType> lstFeeType { get; set; }
        public virtual DbSet<lstSourceCode> lstSourceCode { get; set; }
        public virtual DbSet<tblItem> tblItem { get; set; }
        public virtual DbSet<tblItemCost> tblItemCost { get; set; }
        public virtual DbSet<tblItemDetail> tblItemDetail { get; set; }
        public virtual DbSet<tblItemPrice> tblItemPrice { get; set; }
        public virtual DbSet<tblItemPriceDetail> tblItemPriceDetail { get; set; }
        public virtual DbSet<tblSdp> tblSdp { get; set; }
        public virtual DbSet<tblTax> tblTax { get; set; }
        public virtual DbSet<tblTaxGrp> tblTaxGrp { get; set; }
    }
}
