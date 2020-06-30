using LoginSampleBackend.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginSampleBackend.DataAccess.Concrete.EntityFramework.Contexts
{
    public class LoginSampleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FER2F6Q;Database=LoginSample;integrated security=true;Trusted_Connection=true");
        }
        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}
