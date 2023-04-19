//using school;
using school_oop.entity;

//using school_oop.entity;
using System;

namespace school_oop.courses
{
    class Courses : Entity
    {
        public Courses()
        {

        }

        public int course_completed { get; set; }
        public int Times_Taught { get; set; }

        public void Courses_Info()
        {
            string Detail = $"Course name : {this.Name} \nCourse completion : {this.course_completed}% \n" +
                $"Classes Taught : {this.Times_Taught} in a week";
            Console.WriteLine(Detail);
        }
    }
}
