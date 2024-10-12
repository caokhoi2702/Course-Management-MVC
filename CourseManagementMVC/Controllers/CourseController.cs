using CourseManagementMVC.Models;
using CourseManagementMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagementMVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDBContext context;

        public CourseController(ApplicationDBContext context) 
        {
            this.context = context;
        }

        public IActionResult Index(int? id)
        {
            // Store list of Courses, the chosen course and list of Subjects of that course into viewBag.
            var courses = context.Courses.ToList();
            ViewBag.Courses = courses;

            // Check if the user chose a course
            if (id.HasValue)
            {
                var subjects = context.Subjects.Where(subject => subject.KhoaHocID == id.Value).ToList();
                ViewBag.Subjects = subjects;
                ViewBag.CourseName = courses.FirstOrDefault(c => c.ID == id.Value)?.TenKhoaHoc; // Pass course name

                foreach (var course in courses)
                {
                    if (course.ID == id)
                    {
                        ViewBag.curCourse = course.TenKhoaHoc;
                        break;
                    }
                }

            }
            else
            {
                ViewBag.Subjects = null; // No subjects if no course is selected
                ViewBag.curCourse = "";
            }

            return View(courses);
        }

    }
}
