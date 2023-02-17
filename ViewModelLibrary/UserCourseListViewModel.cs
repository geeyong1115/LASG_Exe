using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exercise.ViewModels
{
    public class UserCourseListViewModel:DbContext
    {
        public List<UserViewModel> Users { get; set; }
        public List<CourseViewModel> Courses { get; set; }


    }
}