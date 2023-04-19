using school_oop.entity;

using System;

namespace school_oop.student
{

    class Student : Entity
    {
        public Student()
        {

        }
        public int RegNumber { get; set; }

        public void student_info()
        {
            string Details = $"student's Name : {this.Name} \nstudent Unique-number : {this.RegNumber}";
            Console.WriteLine(Details);
            Console.WriteLine(" ");
            Console.WriteLine("****************************************");
            Console.WriteLine(" ");
        }
    }
}
