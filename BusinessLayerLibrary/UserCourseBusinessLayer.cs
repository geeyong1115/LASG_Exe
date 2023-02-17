using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise.DataAccessLayer;

namespace Exercise.Models
{
    public class UserCourseBusinessLayer
    {
        public List<User> GetUsers()
        {
            UsersCoursesERPDAL usersCoursesDal = new UsersCoursesERPDAL();
            return usersCoursesDal.Users.ToList();
        }
        public List<Course> GetCourses()
        {
            UsersCoursesERPDAL usersCoursesDal = new UsersCoursesERPDAL();
            return usersCoursesDal.Courses.ToList();
        }

        public Course SaveCourse(Course c)
        {
            UsersCoursesERPDAL usersCoursesERPDAL = new UsersCoursesERPDAL();
            usersCoursesERPDAL.Courses.Add(c);
            usersCoursesERPDAL.SaveChanges();
            return c;
        }
    }
}