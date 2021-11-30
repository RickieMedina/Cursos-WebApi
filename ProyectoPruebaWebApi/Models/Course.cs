using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoPruebaWebApi.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public Int16 Duration { get; set; }
        public string InstructorName { get; set; }
        public bool IsActive { get; set; }



    }
}
