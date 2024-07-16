using Microsoft.EntityFrameworkCore;
using SchoolMgmt.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgmt.DAL.DBContext
{
    public class databasecontext : DbContext 
    {
        public databasecontext(DbContextOptions<databasecontext> options):base(options) {
        }
        public DbSet<StudentModel> StudentModel { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
