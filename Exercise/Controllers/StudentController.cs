using Exercise.Models;
using Exercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Exercise.Controllers
{
    public class StudentController : ApiController
    {
        [System.Web.Mvc.Route("api/Student/InsertCourse")]
        [System.Web.Mvc.HttpPost]
        public Course InsertCourse(Course _course)
        {
            UserCourseBusinessLayer userCourseBusinessLayer = new UserCourseBusinessLayer();
            userCourseBusinessLayer.SaveCourse(_course);
            return _course;
        }
    }
}
