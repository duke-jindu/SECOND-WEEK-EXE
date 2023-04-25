//using school_oop.entity;





//using school_oop.school;



//namespace school
//{


//class School
//{
//    public School() { }
//    // public float RegNumber { get; set; }
//    public string Name { get; set; }
//    // public string courses { get; set; }
//    //public string courseName { get; set; }

//}

namespace school_oop
{



    class program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "duke chukwujindu";
            student.RegNumber = 2018374013;

           Teacher teacher = new Teacher();
            teacher.Name = "Mis Jennifer";
            teacher.NumberOfCourses = 4;

            Courses courses = new Courses();
            courses.Name = "programming in c#";
            courses.course_completed = 65 ;
            courses.Times_Taught = 5;


            student.student_info();
            teacher.teacher_info();
           // Teacher.teacher_Info();
            courses.Courses_Info();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("press enter");

            Console.ReadKey();
            


            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(" ");


        }
    }
}
//}
