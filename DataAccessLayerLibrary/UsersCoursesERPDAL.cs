using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exercise.DataAccessLayer
{
    public class UsersCoursesERPDAL:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("TblUser");
            modelBuilder.Entity<Course>().ToTable("TblCourse");

            base.OnModelCreating(modelBuilder);
        }
    }
}