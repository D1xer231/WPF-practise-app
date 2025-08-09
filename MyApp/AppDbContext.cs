using Microsoft.EntityFrameworkCore;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace MyApp
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var serverVersion = new MySqlServerVersion(new Version(9, 0, 8));
            options.UseMySql(
                "server=localhost;port=3306;username=root;password=root;database=MyMethApp",
                serverVersion
            );
        }
    }
}
