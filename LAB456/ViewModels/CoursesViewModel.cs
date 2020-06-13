using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LAB456.Models;

namespace LAB456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}