using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise.Models;
using Exercise.ViewModels;

namespace Exercise.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            UserCourseListViewModel userCourseListViewModel = new UserCourseListViewModel();

            UserCourseBusinessLayer userCourseBal = new UserCourseBusinessLayer();

            List<User> users = userCourseBal.GetUsers();
            List<Course> courses = userCourseBal.GetCourses();

            List<UserViewModel> userViewModels = new List<UserViewModel>();
            List<CourseViewModel> courseViewModels = new List<CourseViewModel>();

            foreach (User user in users)
            {
                UserViewModel userViewModel = new UserViewModel();
                userViewModel.Name = user.Name;
                userViewModel.Age = user.Age;
                userViewModel.University = user.University;

                userViewModels.Add(userViewModel);
            }
            userCourseListViewModel.Users = userViewModels;

            foreach(Course course in courses)
            {
                CourseViewModel courseViewModel = new CourseViewModel();
                courseViewModel.title = course.title;
                if(course.result == "pass")
                {
                    courseViewModel.resultColor = "green";
                }
                else
                {
                    courseViewModel.resultColor = "yellow";
                }
                courseViewModel.result = course.result;

                courseViewModels.Add(courseViewModel);
            }
            userCourseListViewModel.Courses = courseViewModels;

            return View("User", userCourseListViewModel);
        }

        public ActionResult CreateCourse()
        {
            return View("CreateCourse");
        }

        public ActionResult SaveCourse(Course c, string BtnSubmit)
        {
            //var status = false; 

            if (BtnSubmit=="Save")
            {
                return RedirectToAction("Index");

            }
            else if(BtnSubmit == "Cancel")
            {
                return RedirectToAction("Index");
            }

            return new EmptyResult();
        }
    }
}