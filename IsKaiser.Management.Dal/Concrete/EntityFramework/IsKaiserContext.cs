using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework
{
    public class IsKaiserContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string kaiserConnection = "data source=ISKAISER01\\SQLSERVER2017;Initial Catalog=IS-KAISER-HID;User ID=HidSoftware;Password=Halil1616.";
            string localConnection = "data source=ASUS\\SQLSERVER2017;Initial Catalog=db;Integrated Security=true";
            optionsBuilder.UseSqlServer(localConnection);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Affair>().HasKey(a => a.AffairId);
            modelBuilder.Entity<AffairDetail>().HasKey(ad => ad.AffairDetailId);
            modelBuilder.Entity<AffairEmployeeDetail>().HasKey(ed => ed.EmployeeDetailId);
            modelBuilder.Entity<AffairVehicleDetail>().HasKey(vd => vd.VehicleDetailId);
            modelBuilder.Entity<Vehicle>().HasKey(v => v.VehicleId);
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Invoice>().HasKey(i => i.InvoiceId);
            modelBuilder.Entity<InvoiceLine>().HasKey(il => il.LineId);
            modelBuilder.Entity<ProductType>().HasKey(pt => pt.TypeId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAccountant> CustomerAccountants { get; set; }
        public DbSet<CustomerDirector> CustomerDirectors { get; set; }
        public DbSet<CustomerPurchasingStaff> CustomerPurchasingStaffs { get; set; }
        public DbSet<Debate> Debates { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTeam> EmployeeTeams { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Affair> Affairs { get; set; }
        public DbSet<AffairDetail> AffairDetails { get; set; }
        public DbSet<AffairEmployeeDetail> AffairEmployeeDetails { get; set; }
        public DbSet<AffairVehicleDetail> AffairVehicleDetails { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceLine> InvoiceLines { get; set; }

    }
}
