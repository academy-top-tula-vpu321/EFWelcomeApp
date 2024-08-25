using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EFWelcomeApp
{
    public class CompaniesDbContext : DbContext
    {
        //readonly StreamWriter logWriter = new StreamWriter("log.txt", true);
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=Y5-0\MSSQLSERVER01;Initial Catalog=CompaniesDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //optionsBuilder.LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted });
 
            //optionsBuilder.UseSqlServer(connectionString);

        //    var config = new ConfigurationBuilder()
        //                    .AddJsonFile("appsettings.json")
        //                    .SetBasePath(Directory.GetCurrentDirectory())
        //                    .Build();

        //    optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
