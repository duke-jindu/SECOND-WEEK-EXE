using System;


namespace school_oop
{
    class Teacher : Entity
    {
        public Teacher()
        {

        }
        public int NumberOfCourses { get; set; }

        public void teacher_info()
        {
            string Details = $"Teacher's Name : {Name} \nNumber of course assigned : {NumberOfCourses}";
            Console.WriteLine(Details);
            Console.WriteLine(" ");
            Console.WriteLine("****************************************");
            Console.WriteLine(" ");
        }
    }
}
