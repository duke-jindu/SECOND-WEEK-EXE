//using school;

//using school_oop.entity;
using System;

namespace school_oop
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
            string Detail = $"Course name : {Name} \nCourse completion : {course_completed}% \n" +
                $"Classes Taught : {Times_Taught} in a week";
            Console.WriteLine(Detail);
        }
    }
}
