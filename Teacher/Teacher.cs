using System;

using school_oop.entity;


namespace school_oop.teacher
{
    class Teacher : Entity
    {
        public Teacher()
        {

        }
        public int NumberOfCourses { get; set; }

        public void teacher_info()
        {
            string Details = $"Teacher's Name : {this.Name} \nNumber of course assigned : {this.NumberOfCourses}";
            Console.WriteLine(Details);
            Console.WriteLine(" ");
            Console.WriteLine("****************************************");
            Console.WriteLine(" ");
        }
    }
}
