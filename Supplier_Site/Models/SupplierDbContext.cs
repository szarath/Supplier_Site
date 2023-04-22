using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Supplier_Site.Models
{
    public class SupplierDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public SupplierDbContext(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("SupplierDB"));
        }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Code = 234, Name = "Eskom Holdings Limited", TelephoneNo = "086 0037566" },
                new Supplier { Id = 2, Code = 939, Name = "Focus Rooms (Pty) Ltd", TelephoneNo = "0820776910" },
                new Supplier { Id = 3, Code = 34, Name = "GSM Electro", TelephoneNo = "0128110069" },
                new Supplier { Id = 4, Code = 1264, Name = "Jody and Herman Investments CC", TelephoneNo = "0118864227" },
                new Supplier { Id = 5, Code = 5667, Name = "Johan Le Roux Ingenieurswerke", TelephoneNo = "0233423390" },
                new Supplier { Id = 6, Code = 667, Name = "L. J. Ross t/a Petite Cafe'", TelephoneNo = "0117868101" },
                new Supplier { Id = 7, Code = 45, Name = "L.A Auto Center  CC t/a LA Body Works", TelephoneNo = "0219488412" },
                new Supplier { Id = 8, Code = 1351, Name = "LG Tow-In CC", TelephoneNo = "0828044026" },
                new Supplier { Id = 9, Code = 1352, Name = "LM Greyling t/aThe Electric Advertiser", TelephoneNo = "0119545972" },
                new Supplier { Id = 10, Code = 1437, Name = "M.H Cloete Enterprises (Pty) Ltd  t/a  Rola Motors", TelephoneNo = "0218418300" },
                new Supplier { Id = 11, Code = 67, Name = "M.M Hydraulics CC", TelephoneNo = "011425 6578" },
                new Supplier { Id = 12, Code = 1980, Name = "Phulo Human Capital (Pty) Ltd", TelephoneNo = "0114755934" },
                new Supplier { Id = 13, Code = 345, Name = "Picaro 115 CC t/a H2O CT Services", TelephoneNo = "0216745710" },
                new Supplier { Id = 14, Code = 2279, Name = "Safetygrip CC", TelephoneNo = "0117086660" },
                new Supplier { Id = 15, Code = 876, Name = "Safic (Pty) Ltd", TelephoneNo = "0114064000" },
                new Supplier { Id = 16, Code = 2549, Name = "The Financial Planning Institute Of Southern Africa", TelephoneNo = "0861000374" },
                new Supplier { Id = 17, Code = 935, Name = "The Fitment Zone  CC", TelephoneNo = "0118234181" },
                new Supplier { Id = 18, Code = 2693, Name = "Turnweld Engineering CC", TelephoneNo = "0115468790" },
                new Supplier { Id = 19, Code = 6, Name = "Tutuka Motor Holdings Pty Ltd t/a Tutuka Motor Lab", TelephoneNo = "0117044324" },
                new Supplier { Id = 20, Code = 134, Name = "WP Exhaust Brake & Clutch t/a In Focus Fleet Services", TelephoneNo = "0219055028" },
                new Supplier { Id = 21, Code = 3277, Name = "WP Sekuriteit", TelephoneNo = "0233421732" },
                new Supplier { Id = 22, Code = 53, Name = "Brietta Trading (Pty) Ltd", TelephoneNo = "0115526000" },
                new Supplier { Id = 23, Code = 392, Name = "C.N. Braam t/a CNB Electrical Services", TelephoneNo = "0832835399" },
                new Supplier { Id = 24, Code = 625, Name = "Creative Crew (Pty) Ltd", TelephoneNo = "0120040218" }
            );
        }
    }

}
