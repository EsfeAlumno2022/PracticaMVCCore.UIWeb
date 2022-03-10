using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// ********************************
using Microsoft.EntityFrameworkCore;
namespace PracticaMVCCore.UIWeb.Models
{
    public class ComunDB: DbContext
    {
        public DbSet<Rol> Rol { get; set; }       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DEV01\SQLEXPRESS02;Initial Catalog=SeguridadWebdb;Integrated Security=True");
        }
    }
}
