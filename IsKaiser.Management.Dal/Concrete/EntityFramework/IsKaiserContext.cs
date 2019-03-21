using IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping;
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
            modelBuilder.ApplyConfiguration(new AffairMap());
            modelBuilder.ApplyConfiguration(new AffairDetailMap());
            modelBuilder.ApplyConfiguration(new AffairEmployeeDetailMap());
            modelBuilder.ApplyConfiguration(new AffairVehicleDetailMap());
            modelBuilder.ApplyConfiguration(new AppointmentMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CustomerAccountantMap());
            modelBuilder.ApplyConfiguration(new CustomerDirectorMap());
            modelBuilder.ApplyConfiguration(new CustomerPurchasingStaffMap());
            modelBuilder.ApplyConfiguration(new DebateMap());
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new EmployeeTeamMap());
            modelBuilder.ApplyConfiguration(new InvoiceLineMap());
            modelBuilder.ApplyConfiguration(new InvoiceMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ProductTypeMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new VehicleMap());
            modelBuilder.ApplyConfiguration(new SaleInvoiceMap());
            modelBuilder.ApplyConfiguration(new CompanyBankAccountMap());
            modelBuilder.ApplyConfiguration(new CompanyInformationMap());
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
        public DbSet<SaleInvoice> SaleInvoices { get; set; }

        public DbSet<CompanyInformation> CompanyInformations { get; set; }
        public DbSet<CompanyBankAccount> CompanyBankAccounts { get; set; }

    }
}
