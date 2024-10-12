using CourseManagementMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CourseManagementMVC.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<KhoaHoc> Courses { get; set; }
        public DbSet<MonHoc> Subjects { get; set; }


    }
}
