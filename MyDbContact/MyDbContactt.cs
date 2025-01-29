using atakankendikendine1.Models; // dosyayı ekledim
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atakankendikendine1.MyDbContact
{
    public class MyDbContactt:DbContext
    {
      public  DbSet<Car>Cars { get;set; }
        public DbSet<Employee>Employees { get; set; }

        public DbSet<EmployeeCar>EmployeeCars { get; set; }
        public DbSet<LicensePlate>LicensePlates { get; set; }
        public DbSet<Owner>Owners { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI\\SQLEXPRESS;database=AtakanKendiKendine001Db;trusted_connection=true;trustservercertificate=true");
        }
    }
}
