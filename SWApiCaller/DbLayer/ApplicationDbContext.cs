using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SWApiCaller.DBModels;


namespace SWApiCaller.DbLayer
{
    public class ApplicationDbContext:DbContext
    {
        private string _connString;

        public DbSet<Films> Films { get; set; }
        
        public DbSet<People> people { get; set; }
        
        public DbSet<Vehicle> vehicles { get; set; }

        public ApplicationDbContext()
        {
            _connString = "Server=DESKTOP-0CANB1R;Database=StarwarsAPI;Trusted_Connection=True";
        }

        public ApplicationDbContext(string connection) : base()
        {
            _connString = connection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }
    }
}
