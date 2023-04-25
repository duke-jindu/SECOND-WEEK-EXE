using System;

namespace school_oop
{

    class Student : Entity
    {
        public Student()
        {

        }
        public int RegNumber { get; set; }

        public void student_info()
        {
            string Details = $"student's Name : {Name} \nstudent Unique-number : {RegNumber}";
            Console.WriteLine(Details);
            Console.WriteLine(" ");
            Console.WriteLine("****************************************");
            Console.WriteLine(" ");
        }
    }
}
